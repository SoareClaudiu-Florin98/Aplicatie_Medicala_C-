namespace _1056_Soare_Claudiu_Florin_Proiect.Forms
{
    partial class FormPacienti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPacienti));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fisierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fereastraNouaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ștergeListăToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.iesireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printDocumentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printListaPacienti = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialogListaPacienti = new System.Windows.Forms.PrintPreviewDialog();
            this.chartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fisierToolStripMenuItem,
            this.printToolStripMenuItem,
            this.chartToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(612, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fisierToolStripMenuItem
            // 
            this.fisierToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.fisierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fereastraNouaToolStripMenuItem,
            this.toolStripSeparator1,
            this.ștergeListăToolStripMenuItem,
            this.toolStripSeparator2,
            this.iesireToolStripMenuItem});
            this.fisierToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fisierToolStripMenuItem.Image")));
            this.fisierToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.fisierToolStripMenuItem.Name = "fisierToolStripMenuItem";
            this.fisierToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.fisierToolStripMenuItem.Text = "Fisier";
            // 
            // fereastraNouaToolStripMenuItem
            // 
            this.fereastraNouaToolStripMenuItem.Name = "fereastraNouaToolStripMenuItem";
            this.fereastraNouaToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.fereastraNouaToolStripMenuItem.Text = "&Adaugă pacient";
            this.fereastraNouaToolStripMenuItem.Click += new System.EventHandler(this.fereastraNouaToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(154, 6);
            // 
            // ștergeListăToolStripMenuItem
            // 
            this.ștergeListăToolStripMenuItem.Name = "ștergeListăToolStripMenuItem";
            this.ștergeListăToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.ștergeListăToolStripMenuItem.Text = "Șterge listă";
            this.ștergeListăToolStripMenuItem.Click += new System.EventHandler(this.ștergeListăToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(154, 6);
            // 
            // iesireToolStripMenuItem
            // 
            this.iesireToolStripMenuItem.Name = "iesireToolStripMenuItem";
            this.iesireToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.iesireToolStripMenuItem.Text = "&Iesire";
            this.iesireToolStripMenuItem.Click += new System.EventHandler(this.iesireToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printDocumentToolStripMenuItem,
            this.printPreviewToolStripMenuItem});
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.printToolStripMenuItem.Text = "Print";
            // 
            // printDocumentToolStripMenuItem
            // 
            this.printDocumentToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printDocumentToolStripMenuItem.Image")));
            this.printDocumentToolStripMenuItem.Name = "printDocumentToolStripMenuItem";
            this.printDocumentToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.printDocumentToolStripMenuItem.Text = "Print Document";
            this.printDocumentToolStripMenuItem.Click += new System.EventHandler(this.printDocumentToolStripMenuItem_Click);
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printPreviewToolStripMenuItem.Image")));
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.printPreviewToolStripMenuItem.Text = "Print Preview";
            this.printPreviewToolStripMenuItem.Click += new System.EventHandler(this.printPreviewToolStripMenuItem_Click);
            // 
            // printListaPacienti
            // 
            this.printListaPacienti.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printListaPacienti_PrintPage);
            // 
            // printPreviewDialogListaPacienti
            // 
            this.printPreviewDialogListaPacienti.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialogListaPacienti.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialogListaPacienti.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialogListaPacienti.Document = this.printListaPacienti;
            this.printPreviewDialogListaPacienti.Enabled = true;
            this.printPreviewDialogListaPacienti.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialogListaPacienti.Icon")));
            this.printPreviewDialogListaPacienti.Name = "printPreviewDialogListaPacienti";
            this.printPreviewDialogListaPacienti.Visible = false;
            this.printPreviewDialogListaPacienti.Load += new System.EventHandler(this.printPreviewDialogListaPacienti_Load);
            // 
            // chartToolStripMenuItem
            // 
            this.chartToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("chartToolStripMenuItem.Image")));
            this.chartToolStripMenuItem.Name = "chartToolStripMenuItem";
            this.chartToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.chartToolStripMenuItem.Text = "Grafic";
            this.chartToolStripMenuItem.Click += new System.EventHandler(this.chartToolStripMenuItem_Click);
            // 
            // FormPacienti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 498);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPacienti";
            this.Text = "FormPacienti";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fisierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fereastraNouaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iesireToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ștergeListăToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printDocumentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Drawing.Printing.PrintDocument printListaPacienti;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialogListaPacienti;
        private System.Windows.Forms.ToolStripMenuItem chartToolStripMenuItem;
    }
}