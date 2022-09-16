
using System;

namespace TicketsController.Application.Views
{
    partial class FrmExport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmExport));
            this.btnExportar = new MaterialSkin.Controls.MaterialButton();
            this.btnCancelar = new MaterialSkin.Controls.MaterialButton();
            this.btnDirectory = new MaterialSkin.Controls.MaterialButton();
            this.txtDirectory = new MaterialSkin.Controls.MaterialTextBox2();
            this.cbxOperation = new System.Windows.Forms.ComboBox();
            this.lbOperation = new MaterialSkin.Controls.MaterialLabel();
            this.lbInitialDate = new MaterialSkin.Controls.MaterialLabel();
            this.lbFinalDate = new MaterialSkin.Controls.MaterialLabel();
            this.txtInitialDate = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtFinalDate = new MaterialSkin.Controls.MaterialTextBox2();
            this.btnInitialDate = new MaterialSkin.Controls.MaterialButton();
            this.btnFinalDate = new MaterialSkin.Controls.MaterialButton();
            this.mcInitialDate = new System.Windows.Forms.MonthCalendar();
            this.mcFinalDate = new System.Windows.Forms.MonthCalendar();
            this.chbxDateFilter = new MaterialSkin.Controls.MaterialCheckbox();
            this.pbarExport = new System.Windows.Forms.ProgressBar();
            this.lbStats = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // btnExportar
            // 
            this.btnExportar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportar.AutoSize = false;
            this.btnExportar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExportar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnExportar.Depth = 0;
            this.btnExportar.HighEmphasis = true;
            this.btnExportar.Icon = null;
            this.btnExportar.Location = new System.Drawing.Point(476, 366);
            this.btnExportar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnExportar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnExportar.Size = new System.Drawing.Size(93, 34);
            this.btnExportar.TabIndex = 1;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnExportar.UseAccentColor = false;
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.BntExport_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.AutoSize = false;
            this.btnCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCancelar.Depth = 0;
            this.btnCancelar.HighEmphasis = true;
            this.btnCancelar.Icon = null;
            this.btnCancelar.Location = new System.Drawing.Point(375, 366);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCancelar.Size = new System.Drawing.Size(93, 34);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCancelar.UseAccentColor = false;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.BntCancel_Click);
            // 
            // btnDirectory
            // 
            this.btnDirectory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnDirectory.AutoSize = false;
            this.btnDirectory.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDirectory.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDirectory.Depth = 0;
            this.btnDirectory.HighEmphasis = true;
            this.btnDirectory.Icon = global::TicketsController.Application.Properties.Resources._64673;
            this.btnDirectory.Location = new System.Drawing.Point(8, 289);
            this.btnDirectory.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDirectory.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDirectory.Name = "btnDirectory";
            this.btnDirectory.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDirectory.Size = new System.Drawing.Size(38, 48);
            this.btnDirectory.TabIndex = 4;
            this.btnDirectory.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDirectory.UseAccentColor = false;
            this.btnDirectory.UseVisualStyleBackColor = true;
            this.btnDirectory.Click += new System.EventHandler(this.BntDirectory_Click);
            // 
            // txtDirectory
            // 
            this.txtDirectory.AnimateReadOnly = false;
            this.txtDirectory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtDirectory.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtDirectory.Depth = 0;
            this.txtDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDirectory.HideSelection = true;
            this.txtDirectory.LeadingIcon = null;
            this.txtDirectory.Location = new System.Drawing.Point(53, 290);
            this.txtDirectory.MaxLength = 32767;
            this.txtDirectory.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDirectory.Name = "txtDirectory";
            this.txtDirectory.PasswordChar = '\0';
            this.txtDirectory.PrefixSuffixText = null;
            this.txtDirectory.ReadOnly = false;
            this.txtDirectory.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDirectory.SelectedText = "";
            this.txtDirectory.SelectionLength = 0;
            this.txtDirectory.SelectionStart = 0;
            this.txtDirectory.ShortcutsEnabled = true;
            this.txtDirectory.Size = new System.Drawing.Size(520, 48);
            this.txtDirectory.TabIndex = 5;
            this.txtDirectory.TabStop = false;
            this.txtDirectory.Text = "C:\\Temp\\Tickets.xlsx";
            this.txtDirectory.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDirectory.TrailingIcon = null;
            this.txtDirectory.UseSystemPasswordChar = false;
            // 
            // cbxOperation
            // 
            this.cbxOperation.FormattingEnabled = true;
            this.cbxOperation.Location = new System.Drawing.Point(90, 69);
            this.cbxOperation.Name = "cbxOperation";
            this.cbxOperation.Size = new System.Drawing.Size(278, 23);
            this.cbxOperation.TabIndex = 6;
            // 
            // lbOperation
            // 
            this.lbOperation.AutoSize = true;
            this.lbOperation.Depth = 0;
            this.lbOperation.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbOperation.Location = new System.Drawing.Point(7, 71);
            this.lbOperation.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbOperation.Name = "lbOperation";
            this.lbOperation.Size = new System.Drawing.Size(77, 19);
            this.lbOperation.TabIndex = 7;
            this.lbOperation.Text = "Operação: ";
            // 
            // lbInitialDate
            // 
            this.lbInitialDate.AutoSize = true;
            this.lbInitialDate.Depth = 0;
            this.lbInitialDate.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbInitialDate.Location = new System.Drawing.Point(77, 107);
            this.lbInitialDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbInitialDate.Name = "lbInitialDate";
            this.lbInitialDate.Size = new System.Drawing.Size(85, 19);
            this.lbInitialDate.TabIndex = 10;
            this.lbInitialDate.Text = "Data Inicial:";
            // 
            // lbFinalDate
            // 
            this.lbFinalDate.AutoSize = true;
            this.lbFinalDate.Depth = 0;
            this.lbFinalDate.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbFinalDate.Location = new System.Drawing.Point(413, 107);
            this.lbFinalDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbFinalDate.Name = "lbFinalDate";
            this.lbFinalDate.Size = new System.Drawing.Size(78, 19);
            this.lbFinalDate.TabIndex = 11;
            this.lbFinalDate.Text = "Data Final:";
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
            this.txtInitialDate.Location = new System.Drawing.Point(46, 129);
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
            this.txtInitialDate.Size = new System.Drawing.Size(190, 48);
            this.txtInitialDate.TabIndex = 12;
            this.txtInitialDate.TabStop = false;
            this.txtInitialDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtInitialDate.TrailingIcon = null;
            this.txtInitialDate.UseSystemPasswordChar = false;
            // 
            // txtFinalDate
            // 
            this.txtFinalDate.AnimateReadOnly = false;
            this.txtFinalDate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtFinalDate.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtFinalDate.Depth = 0;
            this.txtFinalDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtFinalDate.HideSelection = true;
            this.txtFinalDate.LeadingIcon = null;
            this.txtFinalDate.Location = new System.Drawing.Point(370, 129);
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
            this.txtFinalDate.Size = new System.Drawing.Size(191, 48);
            this.txtFinalDate.TabIndex = 12;
            this.txtFinalDate.TabStop = false;
            this.txtFinalDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFinalDate.TrailingIcon = null;
            this.txtFinalDate.UseSystemPasswordChar = false;
            // 
            // btnInitialDate
            // 
            this.btnInitialDate.AutoSize = false;
            this.btnInitialDate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnInitialDate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnInitialDate.Depth = 0;
            this.btnInitialDate.HighEmphasis = true;
            this.btnInitialDate.Icon = null;
            this.btnInitialDate.Location = new System.Drawing.Point(11, 129);
            this.btnInitialDate.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnInitialDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnInitialDate.Name = "btnInitialDate";
            this.btnInitialDate.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnInitialDate.Size = new System.Drawing.Size(34, 48);
            this.btnInitialDate.TabIndex = 13;
            this.btnInitialDate.Text = "🗓";
            this.btnInitialDate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnInitialDate.UseAccentColor = false;
            this.btnInitialDate.UseVisualStyleBackColor = true;
            this.btnInitialDate.Click += new System.EventHandler(this.BntMcInitialDate_Click);
            // 
            // btnFinalDate
            // 
            this.btnFinalDate.AutoSize = false;
            this.btnFinalDate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFinalDate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnFinalDate.Depth = 0;
            this.btnFinalDate.HighEmphasis = true;
            this.btnFinalDate.Icon = null;
            this.btnFinalDate.Location = new System.Drawing.Point(334, 129);
            this.btnFinalDate.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnFinalDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnFinalDate.Name = "btnFinalDate";
            this.btnFinalDate.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnFinalDate.Size = new System.Drawing.Size(34, 48);
            this.btnFinalDate.TabIndex = 14;
            this.btnFinalDate.Text = "🗓";
            this.btnFinalDate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnFinalDate.UseAccentColor = false;
            this.btnFinalDate.UseVisualStyleBackColor = true;
            this.btnFinalDate.Click += new System.EventHandler(this.BntMcFinalDate_Click);
            // 
            // mcInitialDate
            // 
            this.mcInitialDate.Location = new System.Drawing.Point(9, 176);
            this.mcInitialDate.Name = "mcInitialDate";
            this.mcInitialDate.TabIndex = 16;
            this.mcInitialDate.Visible = false;
            this.mcInitialDate.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.McInitialDate_DateSelected);
            this.mcInitialDate.LostFocus += new System.EventHandler(this.McInitialDate_LostFocus);
            // 
            // mcFinalDate
            // 
            this.mcFinalDate.Location = new System.Drawing.Point(334, 176);
            this.mcFinalDate.Name = "mcFinalDate";
            this.mcFinalDate.TabIndex = 17;
            this.mcFinalDate.Visible = false;
            this.mcFinalDate.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.McFinalDate_DataSelected);
            this.mcFinalDate.LostFocus += new System.EventHandler(this.McFinalDate_LostFocus);
            // 
            // chbxDateFilter
            // 
            this.chbxDateFilter.Depth = 0;
            this.chbxDateFilter.Location = new System.Drawing.Point(389, 64);
            this.chbxDateFilter.Margin = new System.Windows.Forms.Padding(0);
            this.chbxDateFilter.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chbxDateFilter.MouseState = MaterialSkin.MouseState.HOVER;
            this.chbxDateFilter.Name = "chbxDateFilter";
            this.chbxDateFilter.ReadOnly = false;
            this.chbxDateFilter.Ripple = true;
            this.chbxDateFilter.Size = new System.Drawing.Size(141, 33);
            this.chbxDateFilter.TabIndex = 21;
            this.chbxDateFilter.Text = "Filtrar por Data";
            this.chbxDateFilter.UseVisualStyleBackColor = true;
            this.chbxDateFilter.CheckedChanged += new System.EventHandler(this.chbxDateFilter_CheckedChanged);
            // 
            // pbarExport
            // 
            this.pbarExport.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.pbarExport.Location = new System.Drawing.Point(9, 379);
            this.pbarExport.Name = "pbarExport";
            this.pbarExport.Size = new System.Drawing.Size(225, 21);
            this.pbarExport.TabIndex = 23;
            // 
            // lbStats
            // 
            this.lbStats.AutoSize = true;
            this.lbStats.Depth = 0;
            this.lbStats.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbStats.Location = new System.Drawing.Point(11, 347);
            this.lbStats.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbStats.Name = "lbStats";
            this.lbStats.Size = new System.Drawing.Size(148, 19);
            this.lbStats.TabIndex = 24;
            this.lbStats.Text = "Buscando os Tcikets";
            // 
            // FrmExport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 409);
            this.Controls.Add(this.lbStats);
            this.Controls.Add(this.pbarExport);
            this.Controls.Add(this.mcInitialDate);
            this.Controls.Add(this.chbxDateFilter);
            this.Controls.Add(this.mcFinalDate);
            this.Controls.Add(this.btnFinalDate);
            this.Controls.Add(this.btnInitialDate);
            this.Controls.Add(this.txtInitialDate);
            this.Controls.Add(this.txtFinalDate);
            this.Controls.Add(this.lbFinalDate);
            this.Controls.Add(this.lbInitialDate);
            this.Controls.Add(this.lbOperation);
            this.Controls.Add(this.cbxOperation);
            this.Controls.Add(this.txtDirectory);
            this.Controls.Add(this.btnDirectory);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnExportar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 450);
            this.Name = "FrmExport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exportação de Tickets";
            this.Click += new System.EventHandler(this.Export_click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton btnExportar;
        private MaterialSkin.Controls.MaterialButton btnCancelar;
        private MaterialSkin.Controls.MaterialButton btnDirectory;
        private MaterialSkin.Controls.MaterialTextBox2 txtDirectory;
        private System.Windows.Forms.ComboBox cbxOperation;
        private MaterialSkin.Controls.MaterialLabel lbOperation;
        private MaterialSkin.Controls.MaterialLabel lbInitialDate;
        private MaterialSkin.Controls.MaterialLabel lbFinalDate;
        private MaterialSkin.Controls.MaterialTextBox2 txtInitialDate;
        private MaterialSkin.Controls.MaterialTextBox2 txtFinalDate;
        private MaterialSkin.Controls.MaterialButton btnInitialDate;
        private MaterialSkin.Controls.MaterialButton btnFinalDate;
        private System.Windows.Forms.MonthCalendar mcInitialDate;
        private System.Windows.Forms.MonthCalendar mcFinalDate;
        private MaterialSkin.Controls.MaterialCheckbox chbxDateFilter;
        private System.Windows.Forms.ProgressBar pbarExport;
        private MaterialSkin.Controls.MaterialLabel lbStats;
    }
}