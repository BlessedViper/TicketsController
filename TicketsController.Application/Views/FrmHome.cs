using MaterialSkin;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketsController.Application.Controllers;
using TicketsController.Application.Services;
using TicketsController.Domain.Entities;
using TicketsController.Infra.DatabaseRepository;

namespace TicketsController.Application.Views
{
    public partial class FrmHome : MaterialSkin.Controls.MaterialForm
    {
        private MaterialSkinManager _materialSkinManager = MaterialSkinManager.Instance;
        private DateTime _atualDate = DateTime.Now;
        private DataController _repo;
        private MovideskController _movideskController;
        private List<Ticket> _result = new();
        private FormController _control;
        private DateTime _initialDate;
        private DateTime _finalDate;

        public FrmHome(DataController dataController, MovideskController movideskController, FormController control)
        {
            InitializeComponent();
            this.lblStats.Text = "";
            _repo = dataController;
            _movideskController = movideskController;
            _materialSkinManager.AddFormToManage(this);
            _materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            _materialSkinManager.ColorScheme = new ColorScheme(
                Primary.DeepPurple700,
                Primary.DeepPurple700,
                Primary.DeepPurple700,
                Accent.DeepPurple700,
                TextShade.WHITE
                );

            this.txtFinalDate.Text = _atualDate.ToString("dd/MM/yyyy");
            this.txtInitialDate.Text = _atualDate.ToString("dd/MM/yyyy");
            _control = control;
        }
        public void EnableComponents(bool stats)
        {
            btnFinalCalendar.Enabled = stats;
            btnFind.Enabled = stats;
            btnExport.Enabled = stats;
            btnHistory.Enabled = stats;
            btnInitialCalendar.Enabled = stats;
        }

        #region Events
        /*buttons*/
        private async void BtnFind_Click(object sender, System.EventArgs e)
        {

            _finalDate = DateTime.Parse(txtFinalDate.Text).AddDays(1);
            _initialDate = DateTime.Parse(txtInitialDate.Text);

            try
            {
                if (_result.Count != 0 && _initialDate.Equals(txtInitialDate.Text) && _finalDate.Equals(txtFinalDate.Text))
                {
                    EnableComponents(false);
                    _control.OpenTicketList(_result, this);
                }
                else
                {
                    EnableComponents(false);
                    this.lblStats.Text = "Buscando Tickets, aguarde por gentileza!";
                    Task<Task<List<Ticket>>> task = new(async () =>
                    {
                        var tickets = await _movideskController.SearchTickets(_initialDate, _finalDate, 0);
                        return tickets;
                    });
                    task.Start();
                    this.lblStats.Text = "Atualizando lista de tickets para exibição";
                    _result = await task.Result;
                    _control.OpenTicketList(_result, this);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.lblStats.Text = "";
                EnableComponents(true);
            }
        }
        private void BtnFinalCalendar_Click(object sender, EventArgs e)
        {
            mcFinalDate.Visible = true;
            mcFinalDate.Focus();
        }
        private void BtnInitialCalendar_Click(object sender, EventArgs e)
        {
            mcInitialDate.Visible = true;
            mcInitialDate.Focus();
        }
        private void BntHistory_Click(object sender, System.EventArgs e)
        {
            try
            {
                EnableComponents(false);
                Task<List<History>> task = new(() =>
                {
                   var history = _repo.ListHistory();
                   return history;
                });
                task.Start();
                _control.OpenHistoryList(task.Result);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                EnableComponents(true);
            }
        }
        private void BntExport_Click(object sender, EventArgs e)
        {
            try
            {
                EnableComponents(false);
                _control.OpenExport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                EnableComponents(true);
            }
        }

        /*Month Calendar*/
        private void McFinalDate_DataSelected(object sender, System.Windows.Forms.DateRangeEventArgs e)
        {
            var date = sender as MonthCalendar;
            txtFinalDate.Text = date.SelectionStart.ToString("dd/MM/yyyy");
            mcFinalDate.Visible = false;
        }
        private void McInitialDate_DateSelected(object sender, System.Windows.Forms.DateRangeEventArgs e)
        {
            var date = sender as MonthCalendar;
            txtInitialDate.Text = date.SelectionStart.ToString("dd/MM/yyyy");
            mcInitialDate.Visible = false;
        }
        private void McFinalDate_LostFocus(object sender, EventArgs e)
        {
            mcFinalDate.Visible = false;
        }
        private void McInitialDate_LostFocus(object sender, EventArgs e)
        {
            mcInitialDate.Visible = false;
        }
        private void Home_click(object sender, EventArgs e)
        {
            this.Focus();
        }

        /*Text*/
        private void TxtInitialDate_LostFocus(object sender, EventArgs e)
        {
            try
            {
                DateTime.Parse(txtInitialDate.Text);

            }
            catch
            {
                if (MessageBox.Show("Formato de data Inválido!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                    txtInitialDate.Focus();

            }
        }
        private void TxtFinalDate_LostFocus(object sender, EventArgs e)
        {
            try
            {
                DateTime.Parse(txtFinalDate.Text);
            }
            catch
            { 
                if(MessageBox.Show("Formato de data Inválido!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                    txtFinalDate.Focus();
            }
        }

        #endregion

        
    }
}