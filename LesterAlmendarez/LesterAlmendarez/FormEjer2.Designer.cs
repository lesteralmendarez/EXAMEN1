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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PRODUCTO1textBox = new System.Windows.Forms.TextBox();
            this.PRODUCTO2textBox = new System.Windows.Forms.TextBox();
            this.PRECIO1textBox = new System.Windows.Forms.TextBox();
            this.PRECIO2textBox = new System.Windows.Forms.TextBox();
            this.CALCULARbutton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(363, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "PRECIO 2 ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(363, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "PRODUCTO 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(31, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "PRODUCTO 1";
            // 
            // PRODUCTO1textBox
            // 
            this.PRODUCTO1textBox.Location = new System.Drawing.Point(148, 56);
            this.PRODUCTO1textBox.Name = "PRODUCTO1textBox";
            this.PRODUCTO1textBox.Size = new System.Drawing.Size(100, 22);
            this.PRODUCTO1textBox.TabIndex = 7;
            // 
            // PRODUCTO2textBox
            // 
            this.PRODUCTO2textBox.Location = new System.Drawing.Point(487, 59);
            this.PRODUCTO2textBox.Name = "PRODUCTO2textBox";
            this.PRODUCTO2textBox.Size = new System.Drawing.Size(99, 22);
            this.PRODUCTO2textBox.TabIndex = 8;
            // 
            // PRECIO1textBox
            // 
            this.PRECIO1textBox.Location = new System.Drawing.Point(148, 127);
            this.PRECIO1textBox.Name = "PRECIO1textBox";
            this.PRECIO1textBox.Size = new System.Drawing.Size(99, 22);
            this.PRECIO1textBox.TabIndex = 9;
            // 
            // PRECIO2textBox
            // 
            this.PRECIO2textBox.Location = new System.Drawing.Point(473, 127);
            this.PRECIO2textBox.Name = "PRECIO2textBox";
            this.PRECIO2textBox.Size = new System.Drawing.Size(113, 22);
            this.PRECIO2textBox.TabIndex = 10;
            // 
            // CALCULARbutton
            // 
            this.CALCULARbutton.Location = new System.Drawing.Point(249, 255);
            this.CALCULARbutton.Name = "CALCULARbutton";
            this.CALCULARbutton.Size = new System.Drawing.Size(208, 106);
            this.CALCULARbutton.TabIndex = 11;
            this.CALCULARbutton.Text = "CALCULAR ";
            this.CALCULARbutton.UseVisualStyleBackColor = true;
            this.CALCULARbutton.Click += new System.EventHandler(this.CALCULARbutton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(172, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(407, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "CALCULO DEL DESCUENTO DE UNA COMPRA DE UN CLIENTE ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(762, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "EL BOTON CALCULAR MUESTRA COMPRA SIN DESCUENTO ,EL DESCUENTO Y COMPRA CON DESCUEN" +
    "TO INCLUIDO.";
            // 
            // FormEjer2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CALCULARbutton);
            this.Controls.Add(this.PRECIO2textBox);
            this.Controls.Add(this.PRECIO1textBox);
            this.Controls.Add(this.PRODUCTO2textBox);
            this.Controls.Add(this.PRODUCTO1textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Name = "FormEjer2";
            this.Text = "SEGUNDO EJERCICIO";
            this.Load += new System.EventHandler(this.FormEjer2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PRODUCTO1textBox;
        private System.Windows.Forms.TextBox PRODUCTO2textBox;
        private System.Windows.Forms.TextBox PRECIO1textBox;
        private System.Windows.Forms.TextBox PRECIO2textBox;
        private System.Windows.Forms.Button CALCULARbutton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}