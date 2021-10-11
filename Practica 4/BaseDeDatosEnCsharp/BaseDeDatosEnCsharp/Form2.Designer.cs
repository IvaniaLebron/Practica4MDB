
namespace BaseDeDatosEnCsharp
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnIngresarC = new System.Windows.Forms.Button();
            this.btnLimpiarC = new System.Windows.Forms.Button();
            this.btnVolverC = new System.Windows.Forms.Button();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Revit_HEB_SHX", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(156, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "CLIENTES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre";
            // 
            // btnIngresarC
            // 
            this.btnIngresarC.Location = new System.Drawing.Point(30, 265);
            this.btnIngresarC.Name = "btnIngresarC";
            this.btnIngresarC.Size = new System.Drawing.Size(94, 29);
            this.btnIngresarC.TabIndex = 6;
            this.btnIngresarC.Text = "Ingresar";
            this.btnIngresarC.UseVisualStyleBackColor = true;
            this.btnIngresarC.Click += new System.EventHandler(this.btnIngresarC_Click);
            // 
            // btnLimpiarC
            // 
            this.btnLimpiarC.Location = new System.Drawing.Point(307, 220);
            this.btnLimpiarC.Name = "btnLimpiarC";
            this.btnLimpiarC.Size = new System.Drawing.Size(94, 29);
            this.btnLimpiarC.TabIndex = 7;
            this.btnLimpiarC.Text = "Limpiar";
            this.btnLimpiarC.UseVisualStyleBackColor = true;
            this.btnLimpiarC.Click += new System.EventHandler(this.btnLimpiarC_Click);
            // 
            // btnVolverC
            // 
            this.btnVolverC.Location = new System.Drawing.Point(307, 265);
            this.btnVolverC.Name = "btnVolverC";
            this.btnVolverC.Size = new System.Drawing.Size(94, 29);
            this.btnVolverC.TabIndex = 8;
            this.btnVolverC.Text = "Volver";
            this.btnVolverC.UseVisualStyleBackColor = true;
            this.btnVolverC.Click += new System.EventHandler(this.btnVolverC_Click);
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(145, 163);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(212, 27);
            this.txtnombre.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(156, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 29);
            this.button1.TabIndex = 10;
            this.button1.Text = "Borrar registro";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 331);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.btnVolverC);
            this.Controls.Add(this.btnLimpiarC);
            this.Controls.Add(this.btnIngresarC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnIngresarC;
        private System.Windows.Forms.Button btnLimpiarC;
        private System.Windows.Forms.Button btnVolverC;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Button button1;
    }
}