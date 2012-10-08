namespace WindowsFormsApplication2
{
    partial class FenetreReservation
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
            this.calendarArriver = new System.Windows.Forms.MonthCalendar();
            this.calendarDepart = new System.Windows.Forms.MonthCalendar();
            this.labelDepart = new System.Windows.Forms.Label();
            this.labelArriver = new System.Windows.Forms.Label();
            this.nomReservation = new System.Windows.Forms.Label();
            this.buttonReservation = new System.Windows.Forms.Button();
            this.comboBoxChambre = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listInfo = new System.Windows.Forms.ListView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelChambre = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // calendarArriver
            // 
            this.calendarArriver.Location = new System.Drawing.Point(35, 143);
            this.calendarArriver.MaxSelectionCount = 1;
            this.calendarArriver.Name = "calendarArriver";
            this.calendarArriver.ShowToday = false;
            this.calendarArriver.TabIndex = 0;
            this.calendarArriver.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // calendarDepart
            // 
            this.calendarDepart.Location = new System.Drawing.Point(292, 143);
            this.calendarDepart.MaxSelectionCount = 1;
            this.calendarDepart.Name = "calendarDepart";
            this.calendarDepart.ShowToday = false;
            this.calendarDepart.ShowTodayCircle = false;
            this.calendarDepart.TabIndex = 1;
            this.calendarDepart.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar2_DateChanged);
            // 
            // labelDepart
            // 
            this.labelDepart.AutoSize = true;
            this.labelDepart.Location = new System.Drawing.Point(289, 121);
            this.labelDepart.Name = "labelDepart";
            this.labelDepart.Size = new System.Drawing.Size(78, 13);
            this.labelDepart.TabIndex = 2;
            this.labelDepart.Text = "Date de départ";
            // 
            // labelArriver
            // 
            this.labelArriver.AutoSize = true;
            this.labelArriver.Location = new System.Drawing.Point(32, 121);
            this.labelArriver.Name = "labelArriver";
            this.labelArriver.Size = new System.Drawing.Size(67, 13);
            this.labelArriver.TabIndex = 3;
            this.labelArriver.Text = "Date d\'arrivé";
            // 
            // nomReservation
            // 
            this.nomReservation.AutoSize = true;
            this.nomReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomReservation.Location = new System.Drawing.Point(29, 9);
            this.nomReservation.Name = "nomReservation";
            this.nomReservation.Size = new System.Drawing.Size(222, 33);
            this.nomReservation.TabIndex = 7;
            this.nomReservation.Text = "RÉSERVATION";
            // 
            // buttonReservation
            // 
            this.buttonReservation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReservation.Location = new System.Drawing.Point(453, 9);
            this.buttonReservation.Name = "buttonReservation";
            this.buttonReservation.Size = new System.Drawing.Size(109, 23);
            this.buttonReservation.TabIndex = 4;
            this.buttonReservation.Text = "Réserver";
            this.buttonReservation.UseVisualStyleBackColor = true;
            this.buttonReservation.Click += new System.EventHandler(this.buttonReservation_Click);
            // 
            // comboBoxChambre
            // 
            this.comboBoxChambre.FormattingEnabled = true;
            this.comboBoxChambre.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.comboBoxChambre.Location = new System.Drawing.Point(32, 89);
            this.comboBoxChambre.Name = "comboBoxChambre";
            this.comboBoxChambre.Size = new System.Drawing.Size(121, 21);
            this.comboBoxChambre.TabIndex = 10;
            this.comboBoxChambre.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listInfo);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 326);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(574, 126);
            this.panel1.TabIndex = 11;
            // 
            // listInfo
            // 
            this.listInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listInfo.Location = new System.Drawing.Point(0, 0);
            this.listInfo.Name = "listInfo";
            this.listInfo.Size = new System.Drawing.Size(574, 82);
            this.listInfo.TabIndex = 1;
            this.listInfo.UseCompatibleStateImageBehavior = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonReservation);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(574, 44);
            this.panel2.TabIndex = 0;
            // 
            // labelChambre
            // 
            this.labelChambre.AutoSize = true;
            this.labelChambre.Location = new System.Drawing.Point(32, 65);
            this.labelChambre.Name = "labelChambre";
            this.labelChambre.Size = new System.Drawing.Size(80, 13);
            this.labelChambre.TabIndex = 12;
            this.labelChambre.Text = "Nb de chambre";
            // 
            // FenetreReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 452);
            this.Controls.Add(this.labelChambre);
            this.Controls.Add(this.comboBoxChambre);
            this.Controls.Add(this.nomReservation);
            this.Controls.Add(this.labelArriver);
            this.Controls.Add(this.labelDepart);
            this.Controls.Add(this.calendarDepart);
            this.Controls.Add(this.calendarArriver);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(580, 480);
            this.MinimumSize = new System.Drawing.Size(580, 480);
            this.Name = "FenetreReservation";
            this.Text = "Réservation";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar calendarArriver;
        private System.Windows.Forms.MonthCalendar calendarDepart;
        private System.Windows.Forms.Label labelDepart;
        private System.Windows.Forms.Label labelArriver;
        private System.Windows.Forms.Label nomReservation;
        private System.Windows.Forms.Button buttonReservation;
        private System.Windows.Forms.ComboBox comboBoxChambre;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listInfo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelChambre;
    }
}

