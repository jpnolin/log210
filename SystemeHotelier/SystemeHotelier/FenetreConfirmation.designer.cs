namespace WindowsFormsApplication2
{
    partial class FenetreConfirmation
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.buttonConfirmer = new System.Windows.Forms.Button();
            this.labelNom = new System.Windows.Forms.Label();
            this.labelNoTel = new System.Windows.Forms.Label();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxTel1 = new System.Windows.Forms.TextBox();
            this.textBoxPrenom = new System.Windows.Forms.TextBox();
            this.labelPrenom = new System.Windows.Forms.Label();
            this.groupBoxInfoClient = new System.Windows.Forms.GroupBox();
            this.textBoxTel3 = new System.Windows.Forms.TextBox();
            this.textBoxTel2 = new System.Windows.Forms.TextBox();
            this.propertyGridInfo = new System.Windows.Forms.PropertyGrid();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.groupBoxInfoClient.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonAnnuler);
            this.panel2.Controls.Add(this.buttonConfirmer);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 373);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(349, 39);
            this.panel2.TabIndex = 2;
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAnnuler.Location = new System.Drawing.Point(181, 6);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(75, 23);
            this.buttonAnnuler.TabIndex = 1;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            // 
            // buttonConfirmer
            // 
            this.buttonConfirmer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonConfirmer.Location = new System.Drawing.Point(262, 6);
            this.buttonConfirmer.Name = "buttonConfirmer";
            this.buttonConfirmer.Size = new System.Drawing.Size(75, 23);
            this.buttonConfirmer.TabIndex = 0;
            this.buttonConfirmer.Text = "Confirmer";
            this.buttonConfirmer.UseVisualStyleBackColor = true;
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(20, 22);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(29, 13);
            this.labelNom.TabIndex = 3;
            this.labelNom.Text = "Nom";
            this.labelNom.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelNoTel
            // 
            this.labelNoTel.AutoSize = true;
            this.labelNoTel.Location = new System.Drawing.Point(20, 74);
            this.labelNoTel.Name = "labelNoTel";
            this.labelNoTel.Size = new System.Drawing.Size(86, 13);
            this.labelNoTel.TabIndex = 4;
            this.labelNoTel.Text = "No de téléphone";
            // 
            // textBoxNom
            // 
            this.textBoxNom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNom.Location = new System.Drawing.Point(110, 19);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(199, 20);
            this.textBoxNom.TabIndex = 5;
            // 
            // textBoxTel1
            // 
            this.textBoxTel1.Location = new System.Drawing.Point(110, 71);
            this.textBoxTel1.Name = "textBoxTel1";
            this.textBoxTel1.Size = new System.Drawing.Size(50, 20);
            this.textBoxTel1.TabIndex = 6;
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPrenom.Location = new System.Drawing.Point(110, 45);
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.Size = new System.Drawing.Size(199, 20);
            this.textBoxPrenom.TabIndex = 7;
            // 
            // labelPrenom
            // 
            this.labelPrenom.AutoSize = true;
            this.labelPrenom.Location = new System.Drawing.Point(20, 48);
            this.labelPrenom.Name = "labelPrenom";
            this.labelPrenom.Size = new System.Drawing.Size(43, 13);
            this.labelPrenom.TabIndex = 8;
            this.labelPrenom.Text = "Prénom";
            this.labelPrenom.Click += new System.EventHandler(this.label3_Click);
            // 
            // groupBoxInfoClient
            // 
            this.groupBoxInfoClient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxInfoClient.Controls.Add(this.textBoxTel3);
            this.groupBoxInfoClient.Controls.Add(this.textBoxTel2);
            this.groupBoxInfoClient.Controls.Add(this.textBoxNom);
            this.groupBoxInfoClient.Controls.Add(this.labelPrenom);
            this.groupBoxInfoClient.Controls.Add(this.labelNom);
            this.groupBoxInfoClient.Controls.Add(this.textBoxPrenom);
            this.groupBoxInfoClient.Controls.Add(this.labelNoTel);
            this.groupBoxInfoClient.Controls.Add(this.textBoxTel1);
            this.groupBoxInfoClient.Location = new System.Drawing.Point(12, 12);
            this.groupBoxInfoClient.Name = "groupBoxInfoClient";
            this.groupBoxInfoClient.Size = new System.Drawing.Size(325, 103);
            this.groupBoxInfoClient.TabIndex = 9;
            this.groupBoxInfoClient.TabStop = false;
            this.groupBoxInfoClient.Text = "Informations du client";
            this.groupBoxInfoClient.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBoxTel3
            // 
            this.textBoxTel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTel3.Location = new System.Drawing.Point(223, 71);
            this.textBoxTel3.Name = "textBoxTel3";
            this.textBoxTel3.Size = new System.Drawing.Size(86, 20);
            this.textBoxTel3.TabIndex = 10;
            // 
            // textBoxTel2
            // 
            this.textBoxTel2.Location = new System.Drawing.Point(166, 71);
            this.textBoxTel2.Name = "textBoxTel2";
            this.textBoxTel2.Size = new System.Drawing.Size(51, 20);
            this.textBoxTel2.TabIndex = 9;
            // 
            // propertyGridInfo
            // 
            this.propertyGridInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGridInfo.Location = new System.Drawing.Point(0, 121);
            this.propertyGridInfo.Name = "propertyGridInfo";
            this.propertyGridInfo.Size = new System.Drawing.Size(349, 252);
            this.propertyGridInfo.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBoxInfoClient);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 121);
            this.panel1.TabIndex = 15;
            // 
            // FenetreConfirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 412);
            this.Controls.Add(this.propertyGridInfo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(365, 450);
            this.Name = "FenetreConfirmation";
            this.Text = "Confirmation";
            this.Load += new System.EventHandler(this.fenetreConfirmation_Load);
            this.panel2.ResumeLayout(false);
            this.groupBoxInfoClient.ResumeLayout(false);
            this.groupBoxInfoClient.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.Button buttonConfirmer;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labelNoTel;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.TextBox textBoxTel1;
        private System.Windows.Forms.TextBox textBoxPrenom;
        private System.Windows.Forms.Label labelPrenom;
        private System.Windows.Forms.GroupBox groupBoxInfoClient;
        private System.Windows.Forms.TextBox textBoxTel3;
        private System.Windows.Forms.TextBox textBoxTel2;
        private System.Windows.Forms.PropertyGrid propertyGridInfo;
        private System.Windows.Forms.Panel panel1;
    }
}