namespace MenuAleatorio
{
    partial class frmMenuAleatorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuAleatorio));
            this.btnGerarMenu = new System.Windows.Forms.Button();
            this.lblSanduíche1 = new System.Windows.Forms.Label();
            this.lblSanduíche2 = new System.Windows.Forms.Label();
            this.lblSanduíche3 = new System.Windows.Forms.Label();
            this.lblSanduíche4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGerarMenu
            // 
            this.btnGerarMenu.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnGerarMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGerarMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarMenu.Location = new System.Drawing.Point(92, 165);
            this.btnGerarMenu.Name = "btnGerarMenu";
            this.btnGerarMenu.Size = new System.Drawing.Size(444, 36);
            this.btnGerarMenu.TabIndex = 0;
            this.btnGerarMenu.Text = "Gerar Menu";
            this.btnGerarMenu.UseVisualStyleBackColor = false;
            this.btnGerarMenu.Click += new System.EventHandler(this.btnGerarMenu_Click);
            // 
            // lblSanduíche1
            // 
            this.lblSanduíche1.AutoSize = true;
            this.lblSanduíche1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSanduíche1.Location = new System.Drawing.Point(12, 21);
            this.lblSanduíche1.Name = "lblSanduíche1";
            this.lblSanduíche1.Size = new System.Drawing.Size(124, 20);
            this.lblSanduíche1.TabIndex = 1;
            this.lblSanduíche1.Text = "Sanduíche de:";
            // 
            // lblSanduíche2
            // 
            this.lblSanduíche2.AutoSize = true;
            this.lblSanduíche2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSanduíche2.Location = new System.Drawing.Point(12, 57);
            this.lblSanduíche2.Name = "lblSanduíche2";
            this.lblSanduíche2.Size = new System.Drawing.Size(124, 20);
            this.lblSanduíche2.TabIndex = 1;
            this.lblSanduíche2.Text = "Sanduíche de:";
            // 
            // lblSanduíche3
            // 
            this.lblSanduíche3.AutoSize = true;
            this.lblSanduíche3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSanduíche3.Location = new System.Drawing.Point(12, 93);
            this.lblSanduíche3.Name = "lblSanduíche3";
            this.lblSanduíche3.Size = new System.Drawing.Size(124, 20);
            this.lblSanduíche3.TabIndex = 1;
            this.lblSanduíche3.Text = "Sanduíche de:";
            // 
            // lblSanduíche4
            // 
            this.lblSanduíche4.AutoSize = true;
            this.lblSanduíche4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSanduíche4.Location = new System.Drawing.Point(12, 129);
            this.lblSanduíche4.Name = "lblSanduíche4";
            this.lblSanduíche4.Size = new System.Drawing.Size(124, 20);
            this.lblSanduíche4.TabIndex = 1;
            this.lblSanduíche4.Text = "Sanduíche de:";
            // 
            // frmMenuAleatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(610, 213);
            this.Controls.Add(this.lblSanduíche4);
            this.Controls.Add(this.lblSanduíche3);
            this.Controls.Add(this.lblSanduíche2);
            this.Controls.Add(this.lblSanduíche1);
            this.Controls.Add(this.btnGerarMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMenuAleatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Aleatório";
            this.Load += new System.EventHandler(this.frmMenuAleatorio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGerarMenu;
        private System.Windows.Forms.Label lblSanduíche1;
        private System.Windows.Forms.Label lblSanduíche2;
        private System.Windows.Forms.Label lblSanduíche3;
        private System.Windows.Forms.Label lblSanduíche4;
    }
}

