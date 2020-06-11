namespace _1056_Soare_Claudiu_Florin_Proiect.Forms
{
    partial class FormAdaugaPacient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdaugaPacient));
            this.labelNumeP = new System.Windows.Forms.Label();
            this.labelIdP = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxNumeP = new System.Windows.Forms.TextBox();
            this.textBoxVarstaP = new System.Windows.Forms.TextBox();
            this.comboBoxMedicP = new System.Windows.Forms.ComboBox();
            this.buttonAdaugaP = new System.Windows.Forms.Button();
            this.buttonRenuntaP = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fisierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.binaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salveazaInFisierBinarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incarcaDinFisierBinarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.textToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salveazaInFisierTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incarcaDinFisierTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNumeP
            // 
            this.labelNumeP.AutoSize = true;
            this.labelNumeP.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumeP.Location = new System.Drawing.Point(26, 107);
            this.labelNumeP.Name = "labelNumeP";
            this.labelNumeP.Size = new System.Drawing.Size(45, 16);
            this.labelNumeP.TabIndex = 0;
            this.labelNumeP.Text = "Nume";
            this.labelNumeP.Validating += new System.ComponentModel.CancelEventHandler(this.labelNumeP_Validating);
            // 
            // labelIdP
            // 
            this.labelIdP.AutoSize = true;
            this.labelIdP.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdP.Location = new System.Drawing.Point(26, 60);
            this.labelIdP.Name = "labelIdP";
            this.labelIdP.Size = new System.Drawing.Size(22, 16);
            this.labelIdP.TabIndex = 1;
            this.labelIdP.Text = "Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vârsta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Medic";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(129, 57);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(86, 20);
            this.textBoxId.TabIndex = 4;
            this.textBoxId.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxId_Validating);
            // 
            // textBoxNumeP
            // 
            this.textBoxNumeP.Location = new System.Drawing.Point(129, 107);
            this.textBoxNumeP.Name = "textBoxNumeP";
            this.textBoxNumeP.Size = new System.Drawing.Size(86, 20);
            this.textBoxNumeP.TabIndex = 5;
            this.textBoxNumeP.TextChanged += new System.EventHandler(this.textBoxNumeP_TextChanged);
            this.textBoxNumeP.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxNumeP_Validating);
            // 
            // textBoxVarstaP
            // 
            this.textBoxVarstaP.Location = new System.Drawing.Point(129, 154);
            this.textBoxVarstaP.Name = "textBoxVarstaP";
            this.textBoxVarstaP.Size = new System.Drawing.Size(86, 20);
            this.textBoxVarstaP.TabIndex = 6;
            this.textBoxVarstaP.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxVarstaP_Validating);
            // 
            // comboBoxMedicP
            // 
            this.comboBoxMedicP.FormattingEnabled = true;
            this.comboBoxMedicP.Items.AddRange(new object[] {
            "Radu",
            "Mircea",
            "Andrei"});
            this.comboBoxMedicP.Location = new System.Drawing.Point(129, 193);
            this.comboBoxMedicP.Name = "comboBoxMedicP";
            this.comboBoxMedicP.Size = new System.Drawing.Size(85, 21);
            this.comboBoxMedicP.TabIndex = 7;
            this.comboBoxMedicP.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxMedicP_Validating);
            // 
            // buttonAdaugaP
            // 
            this.buttonAdaugaP.FlatAppearance.BorderSize = 0;
            this.buttonAdaugaP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdaugaP.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdaugaP.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdaugaP.Image")));
            this.buttonAdaugaP.Location = new System.Drawing.Point(12, 260);
            this.buttonAdaugaP.Name = "buttonAdaugaP";
            this.buttonAdaugaP.Size = new System.Drawing.Size(113, 56);
            this.buttonAdaugaP.TabIndex = 8;
            this.buttonAdaugaP.Text = "Adaugă";
            this.buttonAdaugaP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAdaugaP.UseVisualStyleBackColor = true;
            this.buttonAdaugaP.Click += new System.EventHandler(this.buttonAdaugaP_Click);
            // 
            // buttonRenuntaP
            // 
            this.buttonRenuntaP.FlatAppearance.BorderSize = 0;
            this.buttonRenuntaP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRenuntaP.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRenuntaP.Image = ((System.Drawing.Image)(resources.GetObject("buttonRenuntaP.Image")));
            this.buttonRenuntaP.Location = new System.Drawing.Point(148, 260);
            this.buttonRenuntaP.Name = "buttonRenuntaP";
            this.buttonRenuntaP.Size = new System.Drawing.Size(119, 56);
            this.buttonRenuntaP.TabIndex = 9;
            this.buttonRenuntaP.Text = "Renunță";
            this.buttonRenuntaP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonRenuntaP.UseVisualStyleBackColor = true;
            this.buttonRenuntaP.Click += new System.EventHandler(this.buttonRenuntaP_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fisierToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(279, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fisierToolStripMenuItem
            // 
            this.fisierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.binaryToolStripMenuItem,
            this.toolStripSeparator2,
            this.textToolStripMenuItem});
            this.fisierToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fisierToolStripMenuItem.Image")));
            this.fisierToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.fisierToolStripMenuItem.Name = "fisierToolStripMenuItem";
            this.fisierToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.fisierToolStripMenuItem.Text = "Fisier";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(104, 6);
            // 
            // binaryToolStripMenuItem
            // 
            this.binaryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salveazaInFisierBinarToolStripMenuItem,
            this.incarcaDinFisierBinarToolStripMenuItem});
            this.binaryToolStripMenuItem.Name = "binaryToolStripMenuItem";
            this.binaryToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.binaryToolStripMenuItem.Text = "Binary";
            // 
            // salveazaInFisierBinarToolStripMenuItem
            // 
            this.salveazaInFisierBinarToolStripMenuItem.Name = "salveazaInFisierBinarToolStripMenuItem";
            this.salveazaInFisierBinarToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.salveazaInFisierBinarToolStripMenuItem.Text = "Salveaza in fisier binar";
            this.salveazaInFisierBinarToolStripMenuItem.Click += new System.EventHandler(this.salveazaInFisierBinarToolStripMenuItem_Click);
            // 
            // incarcaDinFisierBinarToolStripMenuItem
            // 
            this.incarcaDinFisierBinarToolStripMenuItem.Name = "incarcaDinFisierBinarToolStripMenuItem";
            this.incarcaDinFisierBinarToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.incarcaDinFisierBinarToolStripMenuItem.Text = "Incarca din fisier binar";
            this.incarcaDinFisierBinarToolStripMenuItem.Click += new System.EventHandler(this.incarcaDinFisierBinarToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(104, 6);
            // 
            // textToolStripMenuItem
            // 
            this.textToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salveazaInFisierTextToolStripMenuItem,
            this.incarcaDinFisierTextToolStripMenuItem});
            this.textToolStripMenuItem.Name = "textToolStripMenuItem";
            this.textToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.textToolStripMenuItem.Text = "Text";
            // 
            // salveazaInFisierTextToolStripMenuItem
            // 
            this.salveazaInFisierTextToolStripMenuItem.Name = "salveazaInFisierTextToolStripMenuItem";
            this.salveazaInFisierTextToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.salveazaInFisierTextToolStripMenuItem.Text = "Salveaza in fisier text";
            this.salveazaInFisierTextToolStripMenuItem.Click += new System.EventHandler(this.salveazaInFisierTextToolStripMenuItem_Click);
            // 
            // incarcaDinFisierTextToolStripMenuItem
            // 
            this.incarcaDinFisierTextToolStripMenuItem.Name = "incarcaDinFisierTextToolStripMenuItem";
            this.incarcaDinFisierTextToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.incarcaDinFisierTextToolStripMenuItem.Text = "Incarca din fisier text";
            this.incarcaDinFisierTextToolStripMenuItem.Click += new System.EventHandler(this.incarcaDinFisierTextToolStripMenuItem_Click);
            // 
            // FormAdaugaPacient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(279, 349);
            this.Controls.Add(this.buttonRenuntaP);
            this.Controls.Add(this.buttonAdaugaP);
            this.Controls.Add(this.comboBoxMedicP);
            this.Controls.Add(this.textBoxVarstaP);
            this.Controls.Add(this.textBoxNumeP);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelIdP);
            this.Controls.Add(this.labelNumeP);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Location = new System.Drawing.Point(0, 900);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormAdaugaPacient";
            this.Load += new System.EventHandler(this.FormAdaugaPacient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNumeP;
        private System.Windows.Forms.Label labelIdP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxNumeP;
        private System.Windows.Forms.TextBox textBoxVarstaP;
        private System.Windows.Forms.ComboBox comboBoxMedicP;
        private System.Windows.Forms.Button buttonAdaugaP;
        private System.Windows.Forms.Button buttonRenuntaP;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fisierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem binaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salveazaInFisierBinarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incarcaDinFisierBinarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salveazaInFisierTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incarcaDinFisierTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}