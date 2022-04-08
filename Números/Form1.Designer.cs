namespace Números
{
    partial class nNumeros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(nNumeros));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisar = new Bunifu.Framework.UI.BunifuTextbox();
            this.txtnum2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtnum1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnSomar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.dtgv = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Violet;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnPesquisar);
            this.panel1.Controls.Add(this.txtPesquisar);
            this.panel1.Controls.Add(this.txtnum2);
            this.panel1.Controls.Add(this.txtnum1);
            this.panel1.Controls.Add(this.btnSomar);
            this.panel1.ForeColor = System.Drawing.Color.Magenta;
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 343);
            this.panel1.TabIndex = 0;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.Violet;
            this.btnPesquisar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.BackgroundImage")));
            this.btnPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPesquisar.ForeColor = System.Drawing.Color.Transparent;
            this.btnPesquisar.Location = new System.Drawing.Point(111, 25);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(37, 31);
            this.btnPesquisar.TabIndex = 5;
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click_1);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.BackColor = System.Drawing.Color.Snow;
            this.txtPesquisar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtPesquisar.BackgroundImage")));
            this.txtPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtPesquisar.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.txtPesquisar.Icon = ((System.Drawing.Image)(resources.GetObject("txtPesquisar.Icon")));
            this.txtPesquisar.Location = new System.Drawing.Point(6, 25);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(107, 31);
            this.txtPesquisar.TabIndex = 3;
            this.txtPesquisar.text = "";
            // 
            // txtnum2
            // 
            this.txtnum2.BackColor = System.Drawing.Color.Snow;
            this.txtnum2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtnum2.Font = new System.Drawing.Font("ISOCTEUR", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnum2.ForeColor = System.Drawing.Color.Black;
            this.txtnum2.HintForeColor = System.Drawing.Color.Black;
            this.txtnum2.HintText = "1º Número";
            this.txtnum2.isPassword = false;
            this.txtnum2.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtnum2.LineIdleColor = System.Drawing.Color.Gray;
            this.txtnum2.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtnum2.LineThickness = 4;
            this.txtnum2.Location = new System.Drawing.Point(6, 134);
            this.txtnum2.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtnum2.Name = "txtnum2";
            this.txtnum2.Size = new System.Drawing.Size(142, 40);
            this.txtnum2.TabIndex = 4;
            this.txtnum2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtnum1
            // 
            this.txtnum1.BackColor = System.Drawing.Color.Snow;
            this.txtnum1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtnum1.Font = new System.Drawing.Font("ISOCTEUR", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnum1.ForeColor = System.Drawing.Color.Black;
            this.txtnum1.HintForeColor = System.Drawing.Color.Black;
            this.txtnum1.HintText = "2º Número";
            this.txtnum1.isPassword = false;
            this.txtnum1.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtnum1.LineIdleColor = System.Drawing.Color.Gray;
            this.txtnum1.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtnum1.LineThickness = 4;
            this.txtnum1.Location = new System.Drawing.Point(6, 182);
            this.txtnum1.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtnum1.Name = "txtnum1";
            this.txtnum1.Size = new System.Drawing.Size(142, 38);
            this.txtnum1.TabIndex = 3;
            this.txtnum1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnSomar
            // 
            this.btnSomar.ActiveBorderThickness = 1;
            this.btnSomar.ActiveCornerRadius = 20;
            this.btnSomar.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnSomar.ActiveForecolor = System.Drawing.Color.White;
            this.btnSomar.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnSomar.BackColor = System.Drawing.Color.Violet;
            this.btnSomar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSomar.BackgroundImage")));
            this.btnSomar.ButtonText = "SOMAR";
            this.btnSomar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSomar.Font = new System.Drawing.Font("Academy", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSomar.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnSomar.IdleBorderThickness = 1;
            this.btnSomar.IdleCornerRadius = 35;
            this.btnSomar.IdleFillColor = System.Drawing.Color.Azure;
            this.btnSomar.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnSomar.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnSomar.Location = new System.Drawing.Point(10, 284);
            this.btnSomar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnSomar.Name = "btnSomar";
            this.btnSomar.Size = new System.Drawing.Size(121, 41);
            this.btnSomar.TabIndex = 2;
            this.btnSomar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSomar.Click += new System.EventHandler(this.btnSomar_Click);
            // 
            // dtgv
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgv.BackgroundColor = System.Drawing.Color.Snow;
            this.dtgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv.DoubleBuffered = true;
            this.dtgv.EnableHeadersVisualStyles = false;
            this.dtgv.GridColor = System.Drawing.Color.LavenderBlush;
            this.dtgv.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dtgv.HeaderForeColor = System.Drawing.Color.Honeydew;
            this.dtgv.Location = new System.Drawing.Point(231, -1);
            this.dtgv.Name = "dtgv";
            this.dtgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgv.Size = new System.Drawing.Size(404, 343);
            this.dtgv.TabIndex = 1;
            // 
            // nNumeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(636, 340);
            this.Controls.Add(this.dtgv);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "nNumeros";
            this.Text = "Numeros";
            this.Load += new System.EventHandler(this.nNumeros_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtnum1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSomar;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dtgv;
        private Bunifu.Framework.UI.BunifuTextbox txtPesquisar;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtnum2;
        private System.Windows.Forms.Button btnPesquisar;
    }
}

