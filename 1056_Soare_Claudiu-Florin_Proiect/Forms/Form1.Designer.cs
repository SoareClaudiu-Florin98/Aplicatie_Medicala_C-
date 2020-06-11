namespace _1056_Soare_Claudiu_Florin_Proiect
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonHome = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.meniu = new System.Windows.Forms.PictureBox();
            this.buttonRetete = new System.Windows.Forms.Button();
            this.buttonPacienti = new System.Windows.Forms.Button();
            this.buttonMedici = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelBun = new System.Windows.Forms.Panel();
            this.pContainer = new System.Windows.Forms.Panel();
            this.labelForTimer = new System.Windows.Forms.Label();
            this.timerActual = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panContainer = new System.Windows.Forms.Panel();
            this.buttonProgramari = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.meniu)).BeginInit();
            this.panelContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.buttonHome);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.buttonStop);
            this.panel1.Location = new System.Drawing.Point(165, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(628, 50);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // buttonHome
            // 
            this.buttonHome.FlatAppearance.BorderSize = 0;
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHome.Image = ((System.Drawing.Image)(resources.GetObject("buttonHome.Image")));
            this.buttonHome.Location = new System.Drawing.Point(0, 3);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(50, 44);
            this.buttonHome.TabIndex = 4;
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(518, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 40);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // buttonStop
            // 
            this.buttonStop.FlatAppearance.BorderSize = 0;
            this.buttonStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStop.Image = ((System.Drawing.Image)(resources.GetObject("buttonStop.Image")));
            this.buttonStop.Location = new System.Drawing.Point(565, 3);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(63, 40);
            this.buttonStop.TabIndex = 2;
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(3, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Med Ase";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Controls.Add(this.buttonProgramari);
            this.panel2.Controls.Add(this.meniu);
            this.panel2.Controls.Add(this.buttonRetete);
            this.panel2.Controls.Add(this.buttonPacienti);
            this.panel2.Controls.Add(this.buttonMedici);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(166, 478);
            this.panel2.TabIndex = 1;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // meniu
            // 
            this.meniu.Image = ((System.Drawing.Image)(resources.GetObject("meniu.Image")));
            this.meniu.Location = new System.Drawing.Point(124, 3);
            this.meniu.Name = "meniu";
            this.meniu.Size = new System.Drawing.Size(42, 33);
            this.meniu.TabIndex = 6;
            this.meniu.TabStop = false;
            // 
            // buttonRetete
            // 
            this.buttonRetete.FlatAppearance.BorderSize = 0;
            this.buttonRetete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRetete.ForeColor = System.Drawing.Color.White;
            this.buttonRetete.Image = ((System.Drawing.Image)(resources.GetObject("buttonRetete.Image")));
            this.buttonRetete.Location = new System.Drawing.Point(0, 225);
            this.buttonRetete.Name = "buttonRetete";
            this.buttonRetete.Size = new System.Drawing.Size(160, 73);
            this.buttonRetete.TabIndex = 3;
            this.buttonRetete.Text = "Rețete";
            this.buttonRetete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonRetete.UseVisualStyleBackColor = true;
            this.buttonRetete.Click += new System.EventHandler(this.buttonRetete_Click);
            // 
            // buttonPacienti
            // 
            this.buttonPacienti.FlatAppearance.BorderSize = 0;
            this.buttonPacienti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPacienti.ForeColor = System.Drawing.Color.White;
            this.buttonPacienti.Image = ((System.Drawing.Image)(resources.GetObject("buttonPacienti.Image")));
            this.buttonPacienti.Location = new System.Drawing.Point(0, 316);
            this.buttonPacienti.Name = "buttonPacienti";
            this.buttonPacienti.Size = new System.Drawing.Size(160, 73);
            this.buttonPacienti.TabIndex = 2;
            this.buttonPacienti.Text = "Pacienți";
            this.buttonPacienti.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonPacienti.UseVisualStyleBackColor = true;
            this.buttonPacienti.Click += new System.EventHandler(this.Pacienti_Click);
            // 
            // buttonMedici
            // 
            this.buttonMedici.FlatAppearance.BorderSize = 0;
            this.buttonMedici.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMedici.ForeColor = System.Drawing.Color.White;
            this.buttonMedici.Image = ((System.Drawing.Image)(resources.GetObject("buttonMedici.Image")));
            this.buttonMedici.Location = new System.Drawing.Point(0, 149);
            this.buttonMedici.Name = "buttonMedici";
            this.buttonMedici.Size = new System.Drawing.Size(160, 73);
            this.buttonMedici.TabIndex = 0;
            this.buttonMedici.Text = "Medici";
            this.buttonMedici.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonMedici.UseVisualStyleBackColor = true;
            this.buttonMedici.Click += new System.EventHandler(this.Medici_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelContainer.Controls.Add(this.panelBun);
            this.panelContainer.Controls.Add(this.pContainer);
            this.panelContainer.Controls.Add(this.labelForTimer);
            this.panelContainer.Location = new System.Drawing.Point(165, 46);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(628, 55);
            this.panelContainer.TabIndex = 2;
            this.panelContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContainer_Paint);
            // 
            // panelBun
            // 
            this.panelBun.Location = new System.Drawing.Point(2, 54);
            this.panelBun.Name = "panelBun";
            this.panelBun.Size = new System.Drawing.Size(625, 370);
            this.panelBun.TabIndex = 5;
            // 
            // pContainer
            // 
            this.pContainer.Location = new System.Drawing.Point(0, 61);
            this.pContainer.Name = "pContainer";
            this.pContainer.Size = new System.Drawing.Size(595, 368);
            this.pContainer.TabIndex = 4;
            this.pContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.pContainer_Paint);
            // 
            // labelForTimer
            // 
            this.labelForTimer.AutoSize = true;
            this.labelForTimer.Location = new System.Drawing.Point(558, 23);
            this.labelForTimer.Name = "labelForTimer";
            this.labelForTimer.Size = new System.Drawing.Size(37, 20);
            this.labelForTimer.TabIndex = 0;
            this.labelForTimer.Text = "Ora";
            // 
            // timerActual
            // 
            this.timerActual.Tick += new System.EventHandler(this.timerActual_Tick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // panContainer
            // 
            this.panContainer.Location = new System.Drawing.Point(167, 100);
            this.panContainer.Name = "panContainer";
            this.panContainer.Size = new System.Drawing.Size(624, 374);
            this.panContainer.TabIndex = 8;
            this.panContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.panContainer_Paint);
            // 
            // buttonProgramari
            // 
            this.buttonProgramari.FlatAppearance.BorderSize = 0;
            this.buttonProgramari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProgramari.ForeColor = System.Drawing.Color.White;
            this.buttonProgramari.Image = ((System.Drawing.Image)(resources.GetObject("buttonProgramari.Image")));
            this.buttonProgramari.Location = new System.Drawing.Point(3, 398);
            this.buttonProgramari.Name = "buttonProgramari";
            this.buttonProgramari.Size = new System.Drawing.Size(160, 73);
            this.buttonProgramari.TabIndex = 7;
            this.buttonProgramari.Text = "Programări";
            this.buttonProgramari.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonProgramari.UseVisualStyleBackColor = true;
            this.buttonProgramari.Click += new System.EventHandler(this.buttonProgramari_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(793, 477);
            this.Controls.Add(this.panContainer);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "   ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.meniu)).EndInit();
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonMedici;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Label labelForTimer;
        private System.Windows.Forms.Timer timerActual;
        private System.Windows.Forms.PictureBox meniu;
        private System.Windows.Forms.Button buttonRetete;
        private System.Windows.Forms.Button buttonPacienti;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pContainer;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Panel panelBun;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.Panel panContainer;
        private System.Windows.Forms.Button buttonProgramari;
    }
}

