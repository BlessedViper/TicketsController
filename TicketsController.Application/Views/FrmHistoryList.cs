using MaterialSkin;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TicketsController.Domain.Entities;

namespace TicketsController.Application.Views
{
    public partial class FrmHistoryList : MaterialSkin.Controls.MaterialForm
    {
        private MaterialSkinManager _materialSkinManager = MaterialSkinManager.Instance;
        public FrmHistoryList()
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
        }

        #region Grid
        public void FeedGrid(IEnumerable<History> history)
        {
            dtgvListHistory.Rows.Clear();
            dtgvListHistory.Columns.Clear();
            try
            {
                var columnID = new DataGridViewTextBoxColumn();
                var columnImpDate = new DataGridViewTextBoxColumn();
                var columnImpQtd = new DataGridViewTextBoxColumn();
                columnID.HeaderText = "ID";
                columnImpDate.HeaderText = "Data de Importação";
                columnImpQtd.HeaderText = "Quantidade Importada";

                dtgvListHistory.Columns.AddRange(columnID, columnImpQtd, columnImpDate);
                foreach(var data in history)
                {
                    dtgvListHistory.Rows.Add(data.Id, data.QuantidadeImportada, data.DataImportacao);
                }
            } 
            catch(Exception ex)
            {
                throw new Exception(ex.Message) { Source = ex.Source };
            }
        }
        #endregion
        #region Button
        public void BntFechar_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Parent = null;
        }
        #endregion
    }
}
