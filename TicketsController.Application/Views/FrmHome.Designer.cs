
namespace TicketsController.Application.Views
{
    partial class FrmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHome));
            this.txtInitialDate = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtFinalDate = new MaterialSkin.Controls.MaterialTextBox2();
            this.inicialDateLb = new MaterialSkin.Controls.MaterialLabel();
            this.finalDateLb = new MaterialSkin.Controls.MaterialLabel();
            this.btnFind = new MaterialSkin.Controls.MaterialButton();
            this.mcInitialDate = new System.Windows.Forms.MonthCalendar();
            this.mcFinalDate = new System.Windows.Forms.MonthCalendar();
            this.btnInitialCalendar = new MaterialSkin.Controls.MaterialButton();
            this.btnFinalCalendar = new MaterialSkin.Controls.MaterialButton();
            this.lblStats = new MaterialSkin.Controls.MaterialLabel();
            this.btnHistory = new MaterialSkin.Controls.MaterialButton();
            this.btnExport = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // txtInitialDate
            // 
            this.txtInitialDate.AnimateReadOnly = false;
            this.txtInitialDate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtInitialDate.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtInitialDate.Depth = 0;
            this.txtInitialDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtInitialDate.HideSelection = true;
            this.txtInitialDate.LeadingIcon = null;
            this.txtInitialDate.Location = new System.Drawing.Point(40, 99);
            this.txtInitialDate.MaxLength = 32767;
            this.txtInitialDate.MouseState = MaterialSkin.MouseState.OUT;
            this.txtInitialDate.Name = "txtInitialDate";
            this.txtInitialDate.PasswordChar = '\0';
            this.txtInitialDate.PrefixSuffixText = null;
            this.txtInitialDate.ReadOnly = false;
            this.txtInitialDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtInitialDate.SelectedText = "";
            this.txtInitialDate.SelectionLength = 0;
            this.txtInitialDate.SelectionStart = 0;
            this.txtInitialDate.ShortcutsEnabled = true;
            this.txtInitialDate.Size = new System.Drawing.Size(193, 48);
            this.txtInitialDate.TabIndex = 1;
            this.txtInitialDate.TabStop = false;
            this.txtInitialDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtInitialDate.TrailingIcon = null;
            this.txtInitialDate.UseSystemPasswordChar = false;
            this.txtInitialDate.LostFocus += new System.EventHandler(this.TxtInitialDate_LostFocus);
            // 
            // txtFinalDate
            // 
            this.txtFinalDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFinalDate.AnimateReadOnly = false;
            this.txtFinalDate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtFinalDate.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtFinalDate.Depth = 0;
            this.txtFinalDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtFinalDate.HideSelection = true;
            this.txtFinalDate.LeadingIcon = null;
            this.txtFinalDate.Location = new System.Drawing.Point(330, 99);
            this.txtFinalDate.MaxLength = 32767;
            this.txtFinalDate.MouseState = MaterialSkin.MouseState.OUT;
            this.txtFinalDate.Name = "txtFinalDate";
            this.txtFinalDate.PasswordChar = '\0';
            this.txtFinalDate.PrefixSuffixText = null;
            this.txtFinalDate.ReadOnly = false;
            this.txtFinalDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtFinalDate.SelectedText = "";
            this.txtFinalDate.SelectionLength = 0;
            this.txtFinalDate.SelectionStart = 0;
            this.txtFinalDate.ShortcutsEnabled = true;
            this.txtFinalDate.Size = new System.Drawing.Size(200, 48);
            this.txtFinalDate.TabIndex = 2;
            this.txtFinalDate.TabStop = false;
            this.txtFinalDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFinalDate.TrailingIcon = null;
            this.txtFinalDate.UseSystemPasswordChar = false;
            this.txtFinalDate.LostFocus += new System.EventHandler(this.TxtFinalDate_LostFocus);
            // 
            // inicialDateLb
            // 
            this.inicialDateLb.Depth = 0;
            this.inicialDateLb.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.inicialDateLb.Location = new System.Drawing.Point(6, 77);
            this.inicialDateLb.MouseState = MaterialSkin.MouseState.HOVER;
            this.inicialDateLb.Name = "inicialDateLb";
            this.inicialDateLb.Size = new System.Drawing.Size(227, 22);
            this.inicialDateLb.TabIndex = 2;
            this.inicialDateLb.Text = "Data Inicial";
            this.inicialDateLb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // finalDateLb
            // 
            this.finalDateLb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.finalDateLb.Depth = 0;
            this.finalDateLb.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.finalDateLb.Location = new System.Drawing.Point(329, 78);
            this.finalDateLb.MouseState = MaterialSkin.MouseState.HOVER;
            this.finalDateLb.Name = "finalDateLb";
            this.finalDateLb.Size = new System.Drawing.Size(228, 19);
            this.finalDateLb.TabIndex = 3;
            this.finalDateLb.Text = "Data Final";
            this.finalDateLb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFind
            // 
            this.btnFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFind.AutoSize = false;
            this.btnFind.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFind.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnFind.Depth = 0;
            this.btnFind.HighEmphasis = true;
            this.btnFind.Icon = null;
            this.btnFind.Location = new System.Drawing.Point(468, 268);
            this.btnFind.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnFind.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnFind.Name = "btnFind";
            this.btnFind.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnFind.Size = new System.Drawing.Size(93, 34);
            this.btnFind.TabIndex = 9;
            this.btnFind.Text = "Buscar";
            this.btnFind.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnFind.UseAccentColor = false;
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.BtnFind_Click);
            // 
            // mcInitialDate
            // 
            this.mcInitialDate.Location = new System.Drawing.Point(6, 140);
            this.mcInitialDate.Name = "mcInitialDate";
            this.mcInitialDate.TabIndex = 5;
            this.mcInitialDate.Visible = false;
            this.mcInitialDate.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.McInitialDate_DateSelected);
            this.mcInitialDate.LostFocus += new System.EventHandler(this.McInitialDate_LostFocus);
            // 
            // mcFinalDate
            // 
            this.mcFinalDate.Location = new System.Drawing.Point(330, 140);
            this.mcFinalDate.Name = "mcFinalDate";
            this.mcFinalDate.TabIndex = 6;
            this.mcFinalDate.Visible = false;
            this.mcFinalDate.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.McFinalDate_DataSelected);
            this.mcFinalDate.LostFocus += new System.EventHandler(this.McFinalDate_LostFocus);
            // 
            // btnInitialCalendar
            // 
            this.btnInitialCalendar.AutoSize = false;
            this.btnInitialCalendar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnInitialCalendar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnInitialCalendar.Depth = 0;
            this.btnInitialCalendar.HighEmphasis = true;
            this.btnInitialCalendar.Icon = null;
            this.btnInitialCalendar.Location = new System.Drawing.Point(6, 99);
            this.btnInitialCalendar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnInitialCalendar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnInitialCalendar.Name = "btnInitialCalendar";
            this.btnInitialCalendar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnInitialCalendar.Size = new System.Drawing.Size(34, 48);
            this.btnInitialCalendar.TabIndex = 7;
            this.btnInitialCalendar.Text = "🗓";
            this.btnInitialCalendar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnInitialCalendar.UseAccentColor = false;
            this.btnInitialCalendar.UseVisualStyleBackColor = true;
            this.btnInitialCalendar.Click += new System.EventHandler(this.BtnInitialCalendar_Click);
            // 
            // btnFinalCalendar
            // 
            this.btnFinalCalendar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFinalCalendar.AutoSize = false;
            this.btnFinalCalendar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFinalCalendar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnFinalCalendar.Depth = 0;
            this.btnFinalCalendar.HighEmphasis = true;
            this.btnFinalCalendar.Icon = null;
            this.btnFinalCalendar.Location = new System.Drawing.Point(523, 99);
            this.btnFinalCalendar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnFinalCalendar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnFinalCalendar.Name = "btnFinalCalendar";
            this.btnFinalCalendar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnFinalCalendar.Size = new System.Drawing.Size(34, 48);
            this.btnFinalCalendar.TabIndex = 8;
            this.btnFinalCalendar.Text = "🗓";
            this.btnFinalCalendar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnFinalCalendar.UseAccentColor = false;
            this.btnFinalCalendar.UseVisualStyleBackColor = true;
            this.btnFinalCalendar.Click += new System.EventHandler(this.BtnFinalCalendar_Click);
            // 
            // lblStats
            // 
            this.lblStats.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStats.BackColor = System.Drawing.Color.White;
            this.lblStats.Depth = 0;
            this.lblStats.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblStats.Location = new System.Drawing.Point(6, 232);
            this.lblStats.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblStats.Name = "lblStats";
            this.lblStats.Size = new System.Drawing.Size(555, 19);
            this.lblStats.TabIndex = 0;
            this.lblStats.Text = "Status";
            this.lblStats.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bntHistory
            // 
            this.btnHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHistory.AutoSize = false;
            this.btnHistory.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHistory.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnHistory.Depth = 0;
            this.btnHistory.HighEmphasis = true;
            this.btnHistory.Icon = null;
            this.btnHistory.Location = new System.Drawing.Point(367, 268);
            this.btnHistory.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnHistory.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnHistory.Name = "bntHistory";
            this.btnHistory.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnHistory.Size = new System.Drawing.Size(93, 34);
            this.btnHistory.TabIndex = 10;
            this.btnHistory.Text = "Histórico";
            this.btnHistory.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnHistory.UseAccentColor = false;
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.BntHistory_Click);
            // 
            // bntExport
            // 
            this.btnExport.AutoSize = false;
            this.btnExport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExport.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnExport.Depth = 0;
            this.btnExport.HighEmphasis = true;
            this.btnExport.Icon = null;
            this.btnExport.Location = new System.Drawing.Point(7, 268);
            this.btnExport.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnExport.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExport.Name = "bntExport";
            this.btnExport.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnExport.Size = new System.Drawing.Size(93, 34);
            this.btnExport.TabIndex = 11;
            this.btnExport.Text = "Exportar";
            this.btnExport.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnExport.UseAccentColor = false;
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.BntExport_Click);
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 310);
            this.Controls.Add(this.mcFinalDate);
            this.Controls.Add(this.mcInitialDate);
            this.Controls.Add(this.lblStats);
            this.Controls.Add(this.btnFinalCalendar);
            this.Controls.Add(this.btnInitialCalendar);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.finalDateLb);
            this.Controls.Add(this.inicialDateLb);
            this.Controls.Add(this.txtFinalDate);
            this.Controls.Add(this.txtInitialDate);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.btnExport);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(567, 310);
            this.MinimumSize = new System.Drawing.Size(567, 310);
            this.Name = "FrmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicketsController";
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox2 txtInitialDate;
        private MaterialSkin.Controls.MaterialTextBox2 txtFinalDate;
        private MaterialSkin.Controls.MaterialLabel inicialDateLb;
        private MaterialSkin.Controls.MaterialLabel finalDateLb;
        private MaterialSkin.Controls.MaterialButton btnFind;
        private System.Windows.Forms.MonthCalendar mcInitialDate;
        private System.Windows.Forms.MonthCalendar mcFinalDate;
        private MaterialSkin.Controls.MaterialButton btnInitialCalendar;
        private MaterialSkin.Controls.MaterialButton btnFinalCalendar;
        private MaterialSkin.Controls.MaterialLabel lblStats;
        private MaterialSkin.Controls.MaterialButton btnHistory;
        private MaterialSkin.Controls.MaterialButton btnExport;
    }
}