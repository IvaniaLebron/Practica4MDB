
namespace MDB_LF212591_PRACTICA4
{
    partial class Form2
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
            this.buscar2 = new System.Windows.Forms.Button();
            this.insertar2 = new System.Windows.Forms.Button();
            this.textedad2 = new System.Windows.Forms.TextBox();
            this.textapel2 = new System.Windows.Forms.TextBox();
            this.textnom2 = new System.Windows.Forms.TextBox();
            this.textcod2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buscar2
            // 
            this.buscar2.Location = new System.Drawing.Point(239, 293);
            this.buscar2.Name = "buscar2";
            this.buscar2.Size = new System.Drawing.Size(96, 37);
            this.buscar2.TabIndex = 19;
            this.buscar2.Text = "Buscar";
            this.buscar2.UseVisualStyleBackColor = true;
            this.buscar2.Click += new System.EventHandler(this.buscar2_Click);
            // 
            // insertar2
            // 
            this.insertar2.Location = new System.Drawing.Point(50, 293);
            this.insertar2.Name = "insertar2";
            this.insertar2.Size = new System.Drawing.Size(98, 37);
            this.insertar2.TabIndex = 18;
            this.insertar2.Text = "Insertar";
            this.insertar2.UseVisualStyleBackColor = true;
            this.insertar2.Click += new System.EventHandler(this.insertar2_Click);
            // 
            // textedad2
            // 
            this.textedad2.Location = new System.Drawing.Point(126, 224);
            this.textedad2.Name = "textedad2";
            this.textedad2.Size = new System.Drawing.Size(175, 27);
            this.textedad2.TabIndex = 17;
            // 
            // textapel2
            // 
            this.textapel2.Location = new System.Drawing.Point(126, 169);
            this.textapel2.Name = "textapel2";
            this.textapel2.Size = new System.Drawing.Size(175, 27);
            this.textapel2.TabIndex = 16;
            // 
            // textnom2
            // 
            this.textnom2.Location = new System.Drawing.Point(126, 106);
            this.textnom2.Name = "textnom2";
            this.textnom2.Size = new System.Drawing.Size(175, 27);
            this.textnom2.TabIndex = 15;
            // 
            // textcod2
            // 
            this.textcod2.Location = new System.Drawing.Point(126, 46);
            this.textcod2.Name = "textcod2";
            this.textcod2.Size = new System.Drawing.Size(175, 27);
            this.textcod2.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Edad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Codigo";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 390);
            this.Controls.Add(this.buscar2);
            this.Controls.Add(this.insertar2);
            this.Controls.Add(this.textedad2);
            this.Controls.Add(this.textapel2);
            this.Controls.Add(this.textnom2);
            this.Controls.Add(this.textcod2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buscar2;
        private System.Windows.Forms.Button insertar2;
        private System.Windows.Forms.TextBox textedad2;
        private System.Windows.Forms.TextBox textapel2;
        private System.Windows.Forms.TextBox textnom2;
        private System.Windows.Forms.TextBox textcod2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}