namespace LesterAlmendarez
{
    partial class FormEjer2
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
            this.label2 = new System.Windows.Forms.Label();
            this.PRODUCTO1textBox = new System.Windows.Forms.TextBox();
            this.PRECIO1textBox = new System.Windows.Forms.TextBox();
            this.PRECIO2textBox = new System.Windows.Forms.TextBox();
            this.PRODUCTO2textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CALCULObutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "PRODUCTO 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "PRECIO 1";
            // 
            // PRODUCTO1textBox
            // 
            this.PRODUCTO1textBox.Location = new System.Drawing.Point(151, 65);
            this.PRODUCTO1textBox.Name = "PRODUCTO1textBox";
            this.PRODUCTO1textBox.Size = new System.Drawing.Size(100, 22);
            this.PRODUCTO1textBox.TabIndex = 2;
            this.PRODUCTO1textBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // PRECIO1textBox
            // 
            this.PRECIO1textBox.Location = new System.Drawing.Point(151, 124);
            this.PRECIO1textBox.Name = "PRECIO1textBox";
            this.PRECIO1textBox.Size = new System.Drawing.Size(100, 22);
            this.PRECIO1textBox.TabIndex = 3;
            // 
            // PRECIO2textBox
            // 
            this.PRECIO2textBox.Location = new System.Drawing.Point(422, 124);
            this.PRECIO2textBox.Name = "PRECIO2textBox";
            this.PRECIO2textBox.Size = new System.Drawing.Size(100, 22);
            this.PRECIO2textBox.TabIndex = 7;
            // 
            // PRODUCTO2textBox
            // 
            this.PRODUCTO2textBox.Location = new System.Drawing.Point(422, 65);
            this.PRODUCTO2textBox.Name = "PRODUCTO2textBox";
            this.PRODUCTO2textBox.Size = new System.Drawing.Size(100, 22);
            this.PRODUCTO2textBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(329, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "PRECIO 2 ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(329, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "PRODUCTO 2";
            // 
            // CALCULObutton
            // 
            this.CALCULObutton.Location = new System.Drawing.Point(243, 224);
            this.CALCULObutton.Name = "CALCULObutton";
            this.CALCULObutton.Size = new System.Drawing.Size(122, 58);
            this.CALCULObutton.TabIndex = 8;
            this.CALCULObutton.Text = "CALCULO DE LA VENTA FINALCON SU DESCUENTO";
            this.CALCULObutton.UseVisualStyleBackColor = true;
            this.CALCULObutton.Click += new System.EventHandler(this.CALCULObutton_Click);
            // 
            // FormEjer2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CALCULObutton);
            this.Controls.Add(this.PRECIO2textBox);
            this.Controls.Add(this.PRODUCTO2textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PRECIO1textBox);
            this.Controls.Add(this.PRODUCTO1textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormEjer2";
            this.Text = "SEGUNDO EJERCICIO";
            this.Load += new System.EventHandler(this.FormEjer2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PRODUCTO1textBox;
        private System.Windows.Forms.TextBox PRECIO1textBox;
        private System.Windows.Forms.TextBox PRECIO2textBox;
        private System.Windows.Forms.TextBox PRODUCTO2textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CALCULObutton;
    }
}