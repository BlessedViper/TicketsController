
namespace TicketsController.Application.Views
{
    partial class FrmHistoryList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHistoryList));
            this.dtgvListHistory = new System.Windows.Forms.DataGridView();
            this.lbHistory = new MaterialSkin.Controls.MaterialLabel();
            this.bntClose = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvListHistory
            // 
            this.dtgvListHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtgvListHistory.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvListHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvListHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgvListHistory.GridColor = System.Drawing.SystemColors.Control;
            this.dtgvListHistory.Location = new System.Drawing.Point(7, 37);
            this.dtgvListHistory.Name = "dtgvListHistory";
            this.dtgvListHistory.RowTemplate.Height = 25;
            this.dtgvListHistory.Size = new System.Drawing.Size(786, 360);
            this.dtgvListHistory.TabIndex = 0;
            // 
            // lbHistory
            // 
            this.lbHistory.Depth = 0;
            this.lbHistory.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbHistory.Location = new System.Drawing.Point(7, 7);
            this.lbHistory.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbHistory.Name = "lbHistory";
            this.lbHistory.Size = new System.Drawing.Size(179, 23);
            this.lbHistory.TabIndex = 1;
            this.lbHistory.Text = "Histórico de Importação: ";
            // 
            // bntClose
            // 
            this.bntClose.AutoSize = false;
            this.bntClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bntClose.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bntClose.Depth = 0;
            this.bntClose.HighEmphasis = true;
            this.bntClose.Icon = null;
            this.bntClose.Location = new System.Drawing.Point(7, 406);
            this.bntClose.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.bntClose.MouseState = MaterialSkin.MouseState.HOVER;
            this.bntClose.Name = "bntClose";
            this.bntClose.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bntClose.Size = new System.Drawing.Size(125, 35);
            this.bntClose.TabIndex = 2;
            this.bntClose.Text = "Fechar";
            this.bntClose.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.bntClose.UseAccentColor = false;
            this.bntClose.UseVisualStyleBackColor = true;
            this.bntClose.Click += new System.EventHandler(this.BntFechar_Click);
            // 
            // FrmHistoryList
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bntClose);
            this.Controls.Add(this.lbHistory);
            this.Controls.Add(this.dtgvListHistory);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 450);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "FrmHistoryList";
            this.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvListHistory;
        private MaterialSkin.Controls.MaterialLabel lbHistory;
        private MaterialSkin.Controls.MaterialButton bntClose;
    }
}