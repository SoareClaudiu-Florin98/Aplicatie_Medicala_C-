namespace _1056_Soare_Claudiu_Florin_Proiect.Forms
{
    partial class FormRetete
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonGripa = new System.Windows.Forms.Button();
            this.buttonRaceala = new System.Windows.Forms.Button();
            this.buttonTuse = new System.Windows.Forms.Button();
            this.panelContainerUC = new System.Windows.Forms.Panel();
            this.tuseUC1 = new _1056_Soare_Claudiu_Florin_Proiect.UserControls.TuseUC();
            this.racealaUC1 = new _1056_Soare_Claudiu_Florin_Proiect.UserControls.RacealaUC();
            this.gripaUC1 = new _1056_Soare_Claudiu_Florin_Proiect.UserControls.GripaUC();
            this.startUC1 = new _1056_Soare_Claudiu_Florin_Proiect.UserControls.StartUC();
            this.panelContainerUC.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Doresc o reteta pentru : ";
            // 
            // buttonGripa
            // 
            this.buttonGripa.FlatAppearance.BorderSize = 0;
            this.buttonGripa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGripa.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGripa.Location = new System.Drawing.Point(202, 4);
            this.buttonGripa.Name = "buttonGripa";
            this.buttonGripa.Size = new System.Drawing.Size(69, 35);
            this.buttonGripa.TabIndex = 1;
            this.buttonGripa.Text = "Gripă";
            this.buttonGripa.UseVisualStyleBackColor = true;
            this.buttonGripa.Click += new System.EventHandler(this.buttonGripa_Click);
            // 
            // buttonRaceala
            // 
            this.buttonRaceala.FlatAppearance.BorderSize = 0;
            this.buttonRaceala.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRaceala.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRaceala.Location = new System.Drawing.Point(277, 4);
            this.buttonRaceala.Name = "buttonRaceala";
            this.buttonRaceala.Size = new System.Drawing.Size(69, 35);
            this.buttonRaceala.TabIndex = 2;
            this.buttonRaceala.Text = "Răceala";
            this.buttonRaceala.UseVisualStyleBackColor = true;
            this.buttonRaceala.Click += new System.EventHandler(this.buttonRaceala_Click);
            // 
            // buttonTuse
            // 
            this.buttonTuse.FlatAppearance.BorderSize = 0;
            this.buttonTuse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTuse.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTuse.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonTuse.Location = new System.Drawing.Point(342, 4);
            this.buttonTuse.Name = "buttonTuse";
            this.buttonTuse.Size = new System.Drawing.Size(69, 35);
            this.buttonTuse.TabIndex = 3;
            this.buttonTuse.Text = "Tuse";
            this.buttonTuse.UseVisualStyleBackColor = true;
            this.buttonTuse.Click += new System.EventHandler(this.buttonTuse_Click);
            // 
            // panelContainerUC
            // 
            this.panelContainerUC.Controls.Add(this.tuseUC1);
            this.panelContainerUC.Controls.Add(this.racealaUC1);
            this.panelContainerUC.Controls.Add(this.gripaUC1);
            this.panelContainerUC.Controls.Add(this.startUC1);
            this.panelContainerUC.Location = new System.Drawing.Point(0, 45);
            this.panelContainerUC.Name = "panelContainerUC";
            this.panelContainerUC.Size = new System.Drawing.Size(411, 177);
            this.panelContainerUC.TabIndex = 4;
            // 
            // tuseUC1
            // 
            this.tuseUC1.Location = new System.Drawing.Point(3, 3);
            this.tuseUC1.Name = "tuseUC1";
            this.tuseUC1.Size = new System.Drawing.Size(407, 171);
            this.tuseUC1.TabIndex = 3;
            // 
            // racealaUC1
            // 
            this.racealaUC1.Location = new System.Drawing.Point(3, 3);
            this.racealaUC1.Name = "racealaUC1";
            this.racealaUC1.Size = new System.Drawing.Size(408, 172);
            this.racealaUC1.TabIndex = 2;
            // 
            // gripaUC1
            // 
            this.gripaUC1.Location = new System.Drawing.Point(0, 0);
            this.gripaUC1.Name = "gripaUC1";
            this.gripaUC1.Size = new System.Drawing.Size(411, 176);
            this.gripaUC1.TabIndex = 1;
            // 
            // startUC1
            // 
            this.startUC1.Location = new System.Drawing.Point(0, 0);
            this.startUC1.Name = "startUC1";
            this.startUC1.Size = new System.Drawing.Size(410, 176);
            this.startUC1.TabIndex = 0;
            // 
            // FormRetete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 224);
            this.Controls.Add(this.panelContainerUC);
            this.Controls.Add(this.buttonTuse);
            this.Controls.Add(this.buttonRaceala);
            this.Controls.Add(this.buttonGripa);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(167, 100);
            this.Name = "FormRetete";
            this.Text = "FormRetete";
            this.panelContainerUC.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonGripa;
        private System.Windows.Forms.Button buttonRaceala;
        private System.Windows.Forms.Button buttonTuse;
        private System.Windows.Forms.Panel panelContainerUC;
        private UserControls.TuseUC tuseUC1;
        private UserControls.RacealaUC racealaUC1;
        private UserControls.GripaUC gripaUC1;
        private UserControls.StartUC startUC1;
    }
}