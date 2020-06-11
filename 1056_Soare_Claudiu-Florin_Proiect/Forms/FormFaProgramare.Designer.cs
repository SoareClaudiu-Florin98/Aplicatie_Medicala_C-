namespace _1056_Soare_Claudiu_Florin_Proiect.Forms
{
    partial class FormFaProgramare
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFaProgramare));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBoxMediciBD = new System.Windows.Forms.ComboBox();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.textBoxTelefon = new System.Windows.Forms.TextBox();
            this.textBoxPacient = new System.Windows.Forms.TextBox();
            this.comboBoxSpecialitate = new System.Windows.Forms.ComboBox();
            this.buttonProgramare = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.listViewBD = new System.Windows.Forms.ListView();
            this.columnHeaderPacient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderData = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderMedic = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderMail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTelefon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSpecialitate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.stergeProgramareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Medic";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefon";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(207, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Specialitate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(207, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Pacient";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(53, 18);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // comboBoxMediciBD
            // 
            this.comboBoxMediciBD.FormattingEnabled = true;
            this.comboBoxMediciBD.Items.AddRange(new object[] {
            "Claudiu",
            "Andrei",
            "Razvan"});
            this.comboBoxMediciBD.Location = new System.Drawing.Point(53, 69);
            this.comboBoxMediciBD.Name = "comboBoxMediciBD";
            this.comboBoxMediciBD.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMediciBD.TabIndex = 7;
            this.comboBoxMediciBD.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxMediciBD_Validating);
            // 
            // textBoxMail
            // 
            this.textBoxMail.Location = new System.Drawing.Point(53, 110);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(100, 20);
            this.textBoxMail.TabIndex = 8;
            // 
            // textBoxTelefon
            // 
            this.textBoxTelefon.Location = new System.Drawing.Point(53, 155);
            this.textBoxTelefon.Name = "textBoxTelefon";
            this.textBoxTelefon.Size = new System.Drawing.Size(100, 20);
            this.textBoxTelefon.TabIndex = 9;
            this.textBoxTelefon.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxTelefon_Validating);
            // 
            // textBoxPacient
            // 
            this.textBoxPacient.AllowDrop = true;
            this.textBoxPacient.Location = new System.Drawing.Point(292, 107);
            this.textBoxPacient.Name = "textBoxPacient";
            this.textBoxPacient.Size = new System.Drawing.Size(100, 20);
            this.textBoxPacient.TabIndex = 11;
            this.textBoxPacient.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBoxPacient_DragDrop);
            this.textBoxPacient.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBoxPacient_DragEnter);
            this.textBoxPacient.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxPacient_Validating);
            // 
            // comboBoxSpecialitate
            // 
            this.comboBoxSpecialitate.FormattingEnabled = true;
            this.comboBoxSpecialitate.Items.AddRange(new object[] {
            "Chirurgie",
            "Boli infectioase",
            "Cardiologie",
            "Dermatologie"});
            this.comboBoxSpecialitate.Location = new System.Drawing.Point(292, 64);
            this.comboBoxSpecialitate.Name = "comboBoxSpecialitate";
            this.comboBoxSpecialitate.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSpecialitate.TabIndex = 12;
            this.comboBoxSpecialitate.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxSpecialitate_Validating);
            // 
            // buttonProgramare
            // 
            this.buttonProgramare.FlatAppearance.BorderSize = 0;
            this.buttonProgramare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProgramare.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProgramare.Image = ((System.Drawing.Image)(resources.GetObject("buttonProgramare.Image")));
            this.buttonProgramare.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonProgramare.Location = new System.Drawing.Point(210, 145);
            this.buttonProgramare.Name = "buttonProgramare";
            this.buttonProgramare.Size = new System.Drawing.Size(141, 38);
            this.buttonProgramare.TabIndex = 13;
            this.buttonProgramare.Text = "Programeaza-te";
            this.buttonProgramare.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonProgramare.UseVisualStyleBackColor = true;
            this.buttonProgramare.Click += new System.EventHandler(this.buttonProgramare_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(207, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(195, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "-Datele vor fi introduse in Baza de Date-";
            // 
            // listViewBD
            // 
            this.listViewBD.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.listViewBD.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderPacient,
            this.columnHeaderData,
            this.columnHeaderMedic,
            this.columnHeaderMail,
            this.columnHeaderTelefon,
            this.columnHeaderSpecialitate});
            this.listViewBD.ContextMenuStrip = this.contextMenuStrip1;
            this.listViewBD.HideSelection = false;
            this.listViewBD.Location = new System.Drawing.Point(0, 202);
            this.listViewBD.Name = "listViewBD";
            this.listViewBD.Size = new System.Drawing.Size(634, 218);
            this.listViewBD.TabIndex = 15;
            this.listViewBD.UseCompatibleStateImageBehavior = false;
            this.listViewBD.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderPacient
            // 
            this.columnHeaderPacient.Text = "Pacient";
            // 
            // columnHeaderData
            // 
            this.columnHeaderData.Text = "Data";
            // 
            // columnHeaderMedic
            // 
            this.columnHeaderMedic.Text = "Medic";
            // 
            // columnHeaderMail
            // 
            this.columnHeaderMail.Text = "Mail";
            // 
            // columnHeaderTelefon
            // 
            this.columnHeaderTelefon.Text = "Telefon";
            // 
            // columnHeaderSpecialitate
            // 
            this.columnHeaderSpecialitate.Text = "Specialitate";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stergeProgramareToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(173, 26);
            // 
            // stergeProgramareToolStripMenuItem
            // 
            this.stergeProgramareToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("stergeProgramareToolStripMenuItem.Image")));
            this.stergeProgramareToolStripMenuItem.Name = "stergeProgramareToolStripMenuItem";
            this.stergeProgramareToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.stergeProgramareToolStripMenuItem.Text = "Sterge programare";
            this.stergeProgramareToolStripMenuItem.Click += new System.EventHandler(this.stergeProgramareToolStripMenuItem_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Andrei",
            "Dragos",
            "Robert",
            "Ionel",
            "Claudiu"});
            this.listBox1.Location = new System.Drawing.Point(443, 102);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(164, 69);
            this.listBox1.TabIndex = 16;
            this.listBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(440, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 15);
            this.label8.TabIndex = 17;
            this.label8.Text = "Pacienti : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(517, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "-drag and drop-";
            // 
            // FormFaProgramare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 410);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.listViewBD);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonProgramare);
            this.Controls.Add(this.comboBoxSpecialitate);
            this.Controls.Add(this.textBoxPacient);
            this.Controls.Add(this.textBoxTelefon);
            this.Controls.Add(this.textBoxMail);
            this.Controls.Add(this.comboBoxMediciBD);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormFaProgramare";
            this.Text = "FormFaRezervare";
            this.Load += new System.EventHandler(this.FormFaRezervare_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBoxMediciBD;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.TextBox textBoxTelefon;
        private System.Windows.Forms.TextBox textBoxPacient;
        private System.Windows.Forms.ComboBox comboBoxSpecialitate;
        private System.Windows.Forms.Button buttonProgramare;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView listViewBD;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem stergeProgramareToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeaderPacient;
        private System.Windows.Forms.ColumnHeader columnHeaderData;
        private System.Windows.Forms.ColumnHeader columnHeaderMedic;
        private System.Windows.Forms.ColumnHeader columnHeaderMail;
        private System.Windows.Forms.ColumnHeader columnHeaderTelefon;
        private System.Windows.Forms.ColumnHeader columnHeaderSpecialitate;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox listBox1;
    }
}