using MaterialSkin;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketsController.Application.Services;
using TicketsController.Domain.Entities;
using TicketsController.Infra.DatabaseRepository;

namespace TicketsController.Application.Views
{
    public partial class FrmExport : MaterialSkin.Controls.MaterialForm
    {
        private MaterialSkinManager _materialSkinManager = MaterialSkinManager.Instance;
        private FolderBrowserDialog _folderDialog = new();
        private ExportFile _export;
        private List<Ticket> _list;
        private DataController _data;
        private string _pathComplete;
        private string _path;
        private int _generated;
        private DateTime _initialDate;
        private DateTime _finalDate;
        private MovideskController _movideskController;
        private History _hist;

        public FrmExport(DataController data, int generated, History history, MovideskController movideskController)
        {
            InitializeComponent();
            _materialSkinManager.AddFormToManage(this);
            _materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            _materialSkinManager.ColorScheme = new ColorScheme(
                Primary.DeepPurple700,
                Primary.DeepPurple700,
                Primary.DeepPurple700,
                Accent.DeepPurple700,
                TextShade.WHITE
                );
            _data = data;
            _export = new();
            FeedCbxOperation();
            GetMyDocuments();
            EnableDateFilters(false);
            this.txtFinalDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            this.txtInitialDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            this.cbxOperation.SelectedIndex = 0;
            _pathComplete = this.txtDirectory.Text;
            this.pbarExport.Visible = false;
            this.lbStats.Visible = false;
            _generated = generated;
            _hist = history;
            _movideskController = movideskController;
        }

        #region Events
        private void BntDirectory_Click(object sender, System.EventArgs e)
        {
            try
            {
                _folderDialog.ShowDialog();
                _path = _folderDialog.SelectedPath;
                this.txtDirectory.Text = @$"{_path}\Ticket.xlsx";
                _pathComplete = this.txtDirectory.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BntCancel_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            this.Parent = null;
        }
        private async void BntExport_Click(object sender, System.EventArgs e)
        {
            try
            {
                EnableDateFilters(false);
                EnableComponents(false);
                this.pbarExport.Value = 0;

                _initialDate = Convert.ToDateTime(txtInitialDate.Text);
                _finalDate = Convert.ToDateTime(txtFinalDate.Text).AddDays(1);

                if (!_generated.Equals(0))
                {
                    _pathComplete = $@"{_path}\Ticket{_generated}.xlsx";
                }

                var progress = new Progress<int>(value =>
                {
                    this.pbarExport.Value = value;
                });


                this.lbStats.Text = "Buscando os Tickets";
                this.lbStats.Visible = true;
                this.pbarExport.Visible = true;

                if (chbxDateFilter.Checked)
                {
                    await Task.Run(() => { _list = _data.ListTicketWithDate(_initialDate, _finalDate); });
                }
                else
                {
                    await Task.Run(() => { _list = _data.ListObject(); });
                }

                if (_list.Count.Equals(0))
                {
                    var result = MessageBox.Show("Não houve retorno de dados entre as dastas selecionadas, deseja realizar a busca de tickets entre as dastas?", "Informação", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result.Equals(DialogResult.Yes))
                    {
                        GetTicket();
                    }
                    else
                    {
                        this.Hide();
                        this.Parent = null;
                        return;
                    }
                }
                this.lbStats.Text = "Exportando os Tickets";

                if (cbxOperation.SelectedIndex.Equals(0))
                {
                    await Task.Run(() => { _export.ExportAnaliseDemanda(_pathComplete, _list, progress); });
                }
                else
                {
                    await Task.Run(() => { _export.ExportAll(_pathComplete, _list, progress); });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            var listCount = _list.Count;

            MessageBox.Show($"Realizado a exporta de {listCount} tickets no caminho {_pathComplete}", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            EnableComponents(true);

            this.pbarExport.Visible = false;
            this.lbStats.Visible = false;
            if (chbxDateFilter.Checked)
            {
                EnableDateFilters(true);
            }

            this.Hide();
            this.Parent = null;
        }
        private void BntMcInitialDate_Click(object sender, EventArgs e)
        {
            this.mcInitialDate.Visible = true;
            this.mcInitialDate.Focus();
        }
        private void BntMcFinalDate_Click(object sender, EventArgs e)
        {
            this.mcFinalDate.Visible = true;
            this.mcFinalDate.Focus();
        }
        #endregion

        #region ComponentsManipulation
        private void EnableComponents(bool stats)
        {
            this.lbOperation.Enabled = stats;
            this.txtDirectory.Enabled = stats;
            this.btnDirectory.Enabled = stats;
            this.btnExportar.Enabled = stats;
            this.cbxOperation.Enabled = stats;
            this.btnCancelar.Enabled = stats;
            this.chbxDateFilter.Enabled = stats;
        }
        private void EnableDateFilters(bool stats)
        {
            this.lbFinalDate.Enabled = stats;
            this.lbInitialDate.Enabled = stats;
            this.txtFinalDate.Enabled = stats;
            this.txtInitialDate.Enabled = stats;
            this.btnFinalDate.Enabled = stats;
            this.btnInitialDate.Enabled = stats;
        }
        private void FeedCbxOperation()
        {
            this.cbxOperation.Items.Clear();
            this.cbxOperation.Items.Add("Análise de demanda");
            this.cbxOperation.Items.Add("Exportar Tickets");
        }
        private void GetMyDocuments()
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            _path = path;
            txtDirectory.Text = @$"{path}\Tickets.xlsx";
        }
        private void chbxDateFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxDateFilter.Checked)
            {
                EnableDateFilters(true);
            }
            else
                EnableDateFilters(false);
        }
        #endregion

        #region Mouth Calendar
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
        private void Export_click(object sender, EventArgs e)
        {
            this.Focus();
        }
        #endregion

        private async void GetTicket()
        {
            try
            {
                Task<Task<List<Ticket>>> task = new(async () =>
                {
                    var tickets = await _movideskController.SearchTickets(_initialDate, _finalDate, 0);
                    return tickets;
                });
                task.Start();
                var _result = await task.Result;
                _hist.QuantidadeImportada = _result.Count;
                _hist.DataImportacao = DateTime.Now;
                _data.SaveListAsync(_result, _hist);

                await Task.Run(() => { _list = _data.ListTicketWithDate(_initialDate, _finalDate); });
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
