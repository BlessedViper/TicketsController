using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TicketsController.Domain.Entities;
using TicketsController.Infra.DatabaseRepository;
using MaterialSkin;
using System.Threading.Tasks;
using TicketsController.Application.Controllers;

namespace TicketsController.Application.Views
{
    public partial class FrmTicketsList : MaterialSkin.Controls.MaterialForm
    {
        private FrmHome _frmHome;
        private DataController _repo;
        private History _history;
        private MaterialSkinManager _materialSkinManager = MaterialSkinManager.Instance;
        private List<Ticket> _list = new();
        private long saved;
        public FrmTicketsList(FrmHome frmHome, FormController control, DataController data, History history)
        {
            InitializeComponent();
            _frmHome = frmHome;
            _materialSkinManager.AddFormToManage(this);
            _materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            _materialSkinManager.ColorScheme = new ColorScheme(
                Primary.DeepPurple700,
                Primary.DeepPurple700,
                Primary.DeepPurple700,
                Accent.DeepPurple700,
                TextShade.WHITE
                );
            _history = history;
            _repo = data;
        }
        #region Grid
        public void FeedGrid(List<Ticket> tickets)
        {
            dtgvTicketsList.Rows.Clear();
            dtgvTicketsList.Columns.Clear();
            _list = tickets;
            try
            {
                lblTicketsCount.Text = tickets.Count.ToString();
                var columnID = new DataGridViewTextBoxColumn();
                var columnTitle = new DataGridViewTextBoxColumn();
                var columnCreatedDate = new DataGridViewTextBoxColumn();

                columnID.HeaderText = "ID";
                columnTitle.HeaderText = "Título";
                columnCreatedDate.HeaderText = "Data Criação";

                dtgvTicketsList.Columns.AddRange(columnID, columnTitle, columnCreatedDate);

                foreach(var item in tickets)
                {
                    dtgvTicketsList.Rows.Add(item.Id, item.Titulo, item.DataCriacao);
                }

            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message) { Source = ex.Source };
            }
        }
        #endregion
        #region Button
        private void BtnClose_Click(object sender, EventArgs e)
        {
            _frmHome.EnableComponents(true);
            this.Hide();
            this.Parent = null;
        }
        private async void BntGravar_Click(object sender, EventArgs e)
        {
            var ticketCount = _list.Count;
            _history.DataImportacao = DateTime.Now;
            EnableComponents(false);
            try
            {
                await Task.Run(() =>
                {
                    saved = _repo.SaveListAsync(_list, _history);
                }).ContinueWith(t => { MessageBox.Show($"Realizado a importação de {saved} Ticket(s)", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information); });

            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Close();
            }
        }
        private void EnableComponents(bool stats)
        {
            this.btnClose.Enabled = stats;
            this.btnRecord.Enabled = stats;
        }
        #endregion
    }
}
