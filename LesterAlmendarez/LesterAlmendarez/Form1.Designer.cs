namespace LesterAlmendarez
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eJERCICIO1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eJERCICIO2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eJERCICIO3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pRIMERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sEGUNDOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tERCEROToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eJERCICIO1ToolStripMenuItem,
            this.eJERCICIO2ToolStripMenuItem,
            this.eJERCICIO3ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(535, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // eJERCICIO1ToolStripMenuItem
            // 
            this.eJERCICIO1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pRIMERToolStripMenuItem});
            this.eJERCICIO1ToolStripMenuItem.Name = "eJERCICIO1ToolStripMenuItem";
            this.eJERCICIO1ToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.eJERCICIO1ToolStripMenuItem.Text = "EJERCICIO 1";
            // 
            // eJERCICIO2ToolStripMenuItem
            // 
            this.eJERCICIO2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sEGUNDOToolStripMenuItem});
            this.eJERCICIO2ToolStripMenuItem.Name = "eJERCICIO2ToolStripMenuItem";
            this.eJERCICIO2ToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.eJERCICIO2ToolStripMenuItem.Text = "EJERCICIO2";
            // 
            // eJERCICIO3ToolStripMenuItem
            // 
            this.eJERCICIO3ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tERCEROToolStripMenuItem});
            this.eJERCICIO3ToolStripMenuItem.Name = "eJERCICIO3ToolStripMenuItem";
            this.eJERCICIO3ToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.eJERCICIO3ToolStripMenuItem.Text = "EJERCICIO3";
            // 
            // pRIMERToolStripMenuItem
            // 
            this.pRIMERToolStripMenuItem.Name = "pRIMERToolStripMenuItem";
            this.pRIMERToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.pRIMERToolStripMenuItem.Text = "NUMERO 1";
            this.pRIMERToolStripMenuItem.Click += new System.EventHandler(this.pRIMERToolStripMenuItem_Click);
            // 
            // sEGUNDOToolStripMenuItem
            // 
            this.sEGUNDOToolStripMenuItem.Name = "sEGUNDOToolStripMenuItem";
            this.sEGUNDOToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.sEGUNDOToolStripMenuItem.Text = "NUMERO 2";
            this.sEGUNDOToolStripMenuItem.Click += new System.EventHandler(this.sEGUNDOToolStripMenuItem_Click);
            // 
            // tERCEROToolStripMenuItem
            // 
            this.tERCEROToolStripMenuItem.Name = "tERCEROToolStripMenuItem";
            this.tERCEROToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.tERCEROToolStripMenuItem.Text = "NUMERO 3";
            this.tERCEROToolStripMenuItem.Click += new System.EventHandler(this.tERCEROToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "MENU ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem eJERCICIO1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pRIMERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eJERCICIO2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sEGUNDOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eJERCICIO3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tERCEROToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

