namespace _1056_Soare_Claudiu_Florin_Proiect.Forms
{
    partial class FormMedic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMedic));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelNumeM = new System.Windows.Forms.Label();
            this.labelClinicaM = new System.Windows.Forms.Label();
            this.labelVarstaM = new System.Windows.Forms.Label();
            this.textBoxNumeM = new System.Windows.Forms.TextBox();
            this.textBoxVarstaM = new System.Windows.Forms.TextBox();
            this.comboBoxClinicaM = new System.Windows.Forms.ComboBox();
            this.buttonAdaugaM = new System.Windows.Forms.Button();
            this.listViewMedici = new System.Windows.Forms.ListView();
            this.columnHeaderNume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderClinica = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderVarsta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStripMedici = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ștergeElementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelLista = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStripMedici.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelNumeM
            // 
            this.labelNumeM.AutoSize = true;
            this.labelNumeM.Location = new System.Drawing.Point(15, 115);
            this.labelNumeM.Name = "labelNumeM";
            this.labelNumeM.Size = new System.Drawing.Size(35, 13);
            this.labelNumeM.TabIndex = 1;
            this.labelNumeM.Text = "Nume";
            // 
            // labelClinicaM
            // 
            this.labelClinicaM.AutoSize = true;
            this.labelClinicaM.Location = new System.Drawing.Point(17, 152);
            this.labelClinicaM.Name = "labelClinicaM";
            this.labelClinicaM.Size = new System.Drawing.Size(38, 13);
            this.labelClinicaM.TabIndex = 2;
            this.labelClinicaM.Text = "Clinică";
            // 
            // labelVarstaM
            // 
            this.labelVarstaM.AutoSize = true;
            this.labelVarstaM.Location = new System.Drawing.Point(15, 189);
            this.labelVarstaM.Name = "labelVarstaM";
            this.labelVarstaM.Size = new System.Drawing.Size(37, 13);
            this.labelVarstaM.TabIndex = 3;
            this.labelVarstaM.Text = "Vârstă";
            // 
            // textBoxNumeM
            // 
            this.textBoxNumeM.Location = new System.Drawing.Point(61, 115);
            this.textBoxNumeM.Name = "textBoxNumeM";
            this.textBoxNumeM.Size = new System.Drawing.Size(89, 20);
            this.textBoxNumeM.TabIndex = 4;
            this.textBoxNumeM.TextChanged += new System.EventHandler(this.textBoxNumeM_TextChanged);
            this.textBoxNumeM.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxNumeM_Validating);
            // 
            // textBoxVarstaM
            // 
            this.textBoxVarstaM.Location = new System.Drawing.Point(61, 189);
            this.textBoxVarstaM.Name = "textBoxVarstaM";
            this.textBoxVarstaM.Size = new System.Drawing.Size(89, 20);
            this.textBoxVarstaM.TabIndex = 5;
            this.textBoxVarstaM.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxVarstaM_Validating);
            // 
            // comboBoxClinicaM
            // 
            this.comboBoxClinicaM.FormattingEnabled = true;
            this.comboBoxClinicaM.Items.AddRange(new object[] {
            "Med Ase",
            "MedLife",
            "Medsana"});
            this.comboBoxClinicaM.Location = new System.Drawing.Point(61, 149);
            this.comboBoxClinicaM.Name = "comboBoxClinicaM";
            this.comboBoxClinicaM.Size = new System.Drawing.Size(89, 21);
            this.comboBoxClinicaM.TabIndex = 6;
            this.comboBoxClinicaM.SelectedIndexChanged += new System.EventHandler(this.comboBoxClinicaM_SelectedIndexChanged);
            this.comboBoxClinicaM.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxClinicaM_Validating);
            // 
            // buttonAdaugaM
            // 
            this.buttonAdaugaM.FlatAppearance.BorderSize = 0;
            this.buttonAdaugaM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdaugaM.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdaugaM.Image")));
            this.buttonAdaugaM.Location = new System.Drawing.Point(156, 152);
            this.buttonAdaugaM.Name = "buttonAdaugaM";
            this.buttonAdaugaM.Size = new System.Drawing.Size(137, 31);
            this.buttonAdaugaM.TabIndex = 7;
            this.buttonAdaugaM.Text = "Adaugă medic";
            this.buttonAdaugaM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAdaugaM.UseVisualStyleBackColor = true;
            this.buttonAdaugaM.Click += new System.EventHandler(this.buttonAdaugaM_Click);
            // 
            // listViewMedici
            // 
            this.listViewMedici.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderNume,
            this.columnHeaderClinica,
            this.columnHeaderVarsta});
            this.listViewMedici.ContextMenuStrip = this.contextMenuStripMedici;
            this.listViewMedici.HideSelection = false;
            this.listViewMedici.Location = new System.Drawing.Point(156, 25);
            this.listViewMedici.Name = "listViewMedici";
            this.listViewMedici.Size = new System.Drawing.Size(227, 127);
            this.listViewMedici.TabIndex = 8;
            this.listViewMedici.UseCompatibleStateImageBehavior = false;
            this.listViewMedici.View = System.Windows.Forms.View.Details;
            this.listViewMedici.SelectedIndexChanged += new System.EventHandler(this.listViewMedici_SelectedIndexChanged);
            // 
            // columnHeaderNume
            // 
            this.columnHeaderNume.Text = "Nume";
            this.columnHeaderNume.Width = 80;
            // 
            // columnHeaderClinica
            // 
            this.columnHeaderClinica.Text = "Clinică";
            this.columnHeaderClinica.Width = 100;
            // 
            // columnHeaderVarsta
            // 
            this.columnHeaderVarsta.Text = "Vârstă";
            // 
            // contextMenuStripMedici
            // 
            this.contextMenuStripMedici.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem,
            this.ștergeElementToolStripMenuItem});
            this.contextMenuStripMedici.Name = "contextMenuStripMedici";
            this.contextMenuStripMedici.Size = new System.Drawing.Size(154, 48);
            this.contextMenuStripMedici.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripMedici_Opening);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("refreshToolStripMenuItem.Image")));
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // ștergeElementToolStripMenuItem
            // 
            this.ștergeElementToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ștergeElementToolStripMenuItem.Image")));
            this.ștergeElementToolStripMenuItem.Name = "ștergeElementToolStripMenuItem";
            this.ștergeElementToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.ștergeElementToolStripMenuItem.Text = "Șterge element";
            this.ștergeElementToolStripMenuItem.Click += new System.EventHandler(this.ștergeElementToolStripMenuItem_Click);
            // 
            // labelLista
            // 
            this.labelLista.AutoSize = true;
            this.labelLista.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLista.Location = new System.Drawing.Point(152, 1);
            this.labelLista.Name = "labelLista";
            this.labelLista.Size = new System.Drawing.Size(166, 21);
            this.labelLista.TabIndex = 9;
            this.labelLista.Text = "Lista medicilor: ";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(295, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 31);
            this.button1.TabIndex = 10;
            this.button1.Text = "Șterge listă";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormMedic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 221);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelLista);
            this.Controls.Add(this.listViewMedici);
            this.Controls.Add(this.buttonAdaugaM);
            this.Controls.Add(this.comboBoxClinicaM);
            this.Controls.Add(this.textBoxVarstaM);
            this.Controls.Add(this.textBoxNumeM);
            this.Controls.Add(this.labelVarstaM);
            this.Controls.Add(this.labelClinicaM);
            this.Controls.Add(this.labelNumeM);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(167, 100);
            this.Name = "FormMedic";
            this.Text = "FormMedic";
            this.Load += new System.EventHandler(this.FormMedic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStripMedici.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelNumeM;
        private System.Windows.Forms.Label labelClinicaM;
        private System.Windows.Forms.Label labelVarstaM;
        private System.Windows.Forms.TextBox textBoxNumeM;
        private System.Windows.Forms.TextBox textBoxVarstaM;
        private System.Windows.Forms.ComboBox comboBoxClinicaM;
        private System.Windows.Forms.Button buttonAdaugaM;
        private System.Windows.Forms.ListView listViewMedici;
        private System.Windows.Forms.Label labelLista;
        private System.Windows.Forms.ColumnHeader columnHeaderNume;
        private System.Windows.Forms.ColumnHeader columnHeaderClinica;
        private System.Windows.Forms.ColumnHeader columnHeaderVarsta;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripMedici;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ștergeElementToolStripMenuItem;
    }
}