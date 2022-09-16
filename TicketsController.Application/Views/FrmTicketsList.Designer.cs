
namespace TicketsController.Application.Views
{
    partial class FrmTicketsList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTicketsList));
            this.btnClose = new MaterialSkin.Controls.MaterialButton();
            this.btnRecord = new MaterialSkin.Controls.MaterialButton();
            this.dtgvTicketsList = new System.Windows.Forms.DataGridView();
            this.lblSearchResult = new MaterialSkin.Controls.MaterialLabel();
            this.lblTicketsCount = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTicketsList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.AutoSize = false;
            this.btnClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClose.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnClose.Depth = 0;
            this.btnClose.HighEmphasis = true;
            this.btnClose.Icon = null;
            this.btnClose.Location = new System.Drawing.Point(7, 406);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClose.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClose.Name = "btnClose";
            this.btnClose.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnClose.Size = new System.Drawing.Size(124, 35);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Cancelar";
            this.btnClose.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnClose.UseAccentColor = false;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // btnRecord
            // 
            this.btnRecord.AutoSize = false;
            this.btnRecord.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRecord.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRecord.Depth = 0;
            this.btnRecord.HighEmphasis = true;
            this.btnRecord.Icon = null;
            this.btnRecord.Location = new System.Drawing.Point(668, 406);
            this.btnRecord.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRecord.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRecord.Size = new System.Drawing.Size(125, 35);
            this.btnRecord.TabIndex = 2;
            this.btnRecord.Text = "Gravar";
            this.btnRecord.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRecord.UseAccentColor = false;
            this.btnRecord.UseVisualStyleBackColor = true;
            this.btnRecord.Click += new System.EventHandler(this.BntGravar_Click);
            // 
            // dtgvTicketsList
            // 
            this.dtgvTicketsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvTicketsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgvTicketsList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgvTicketsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTicketsList.Location = new System.Drawing.Point(7, 37);
            this.dtgvTicketsList.Name = "dtgvTicketsList";
            this.dtgvTicketsList.RowTemplate.Height = 25;
            this.dtgvTicketsList.Size = new System.Drawing.Size(786, 360);
            this.dtgvTicketsList.TabIndex = 3;
            // 
            // lblSearchResult
            // 
            this.lblSearchResult.Depth = 0;
            this.lblSearchResult.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblSearchResult.Location = new System.Drawing.Point(7, 7);
            this.lblSearchResult.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSearchResult.Name = "lblSearchResult";
            this.lblSearchResult.Size = new System.Drawing.Size(174, 27);
            this.lblSearchResult.TabIndex = 4;
            this.lblSearchResult.Text = "Quantidade buscada:";
            // 
            // lblTicketsCount
            // 
            this.lblTicketsCount.Depth = 0;
            this.lblTicketsCount.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTicketsCount.Location = new System.Drawing.Point(173, 7);
            this.lblTicketsCount.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTicketsCount.Name = "lblTicketsCount";
            this.lblTicketsCount.Size = new System.Drawing.Size(153, 27);
            this.lblTicketsCount.TabIndex = 5;
            // 
            // FrmTicketsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTicketsCount);
            this.Controls.Add(this.lblSearchResult);
            this.Controls.Add(this.dtgvTicketsList);
            this.Controls.Add(this.btnRecord);
            this.Controls.Add(this.btnClose);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmTicketsList";
            this.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicketsList";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTicketsList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton btnClose;
        private MaterialSkin.Controls.MaterialButton btnRecord;
        private System.Windows.Forms.DataGridView dtgvTicketsList;
        private MaterialSkin.Controls.MaterialLabel lblSearchResult;
        private MaterialSkin.Controls.MaterialLabel lblTicketsCount;
    }
}