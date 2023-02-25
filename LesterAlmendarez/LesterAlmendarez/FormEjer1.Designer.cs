namespace LesterAlmendarez
{
    partial class FormEjer1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.CALCULARbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(177, 33);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(183, 324);
            this.listBox1.TabIndex = 0;
            // 
            // CALCULARbutton
            // 
            this.CALCULARbutton.Location = new System.Drawing.Point(480, 148);
            this.CALCULARbutton.Name = "CALCULARbutton";
            this.CALCULARbutton.Size = new System.Drawing.Size(85, 90);
            this.CALCULARbutton.TabIndex = 1;
            this.CALCULARbutton.Text = "CALCULAR";
            this.CALCULARbutton.UseVisualStyleBackColor = true;
            this.CALCULARbutton.Click += new System.EventHandler(this.CALCULARbutton_Click);
            // 
            // FormEjer1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CALCULARbutton);
            this.Controls.Add(this.listBox1);
            this.Name = "FormEjer1";
            this.Text = "PRIMER EJERCICIO";
            this.Load += new System.EventHandler(this.FormEjer1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button CALCULARbutton;
    }
}