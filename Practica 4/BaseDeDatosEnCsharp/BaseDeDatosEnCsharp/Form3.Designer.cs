
namespace BaseDeDatosEnCsharp
{
    partial class Form3
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
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nUDcant = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.dtime1 = new System.Windows.Forms.DateTimePicker();
            this.btnIngresarP = new System.Windows.Forms.Button();
            this.btnLimpiarP = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lbNombreC = new System.Windows.Forms.Label();
            this.btnVolverP = new System.Windows.Forms.Button();
            this.lbPrecioP = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbLibrosP = new System.Windows.Forms.Label();
            this.lbIDlibro = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nUDcant)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Revit_HEB_SHX", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(52, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "PEDIDOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "ID cliente";
            // 
            // cbCliente
            // 
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(134, 105);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(183, 28);
            this.cbCliente.TabIndex = 7;
            this.cbCliente.SelectedIndexChanged += new System.EventHandler(this.cbCliente_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cantidad de libros";
            // 
            // nUDcant
            // 
            this.nUDcant.Location = new System.Drawing.Point(214, 164);
            this.nUDcant.Name = "nUDcant";
            this.nUDcant.Size = new System.Drawing.Size(65, 27);
            this.nUDcant.TabIndex = 9;
            this.nUDcant.ValueChanged += new System.EventHandler(this.nUDcant_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Fecha";
            // 
            // dtime1
            // 
            this.dtime1.Location = new System.Drawing.Point(107, 233);
            this.dtime1.Name = "dtime1";
            this.dtime1.Size = new System.Drawing.Size(293, 27);
            this.dtime1.TabIndex = 11;
            // 
            // btnIngresarP
            // 
            this.btnIngresarP.Location = new System.Drawing.Point(53, 297);
            this.btnIngresarP.Name = "btnIngresarP";
            this.btnIngresarP.Size = new System.Drawing.Size(102, 33);
            this.btnIngresarP.TabIndex = 12;
            this.btnIngresarP.Text = "Ingresar";
            this.btnIngresarP.UseVisualStyleBackColor = true;
            this.btnIngresarP.Click += new System.EventHandler(this.btnIngresarP_Click);
            // 
            // btnLimpiarP
            // 
            this.btnLimpiarP.Location = new System.Drawing.Point(225, 297);
            this.btnLimpiarP.Name = "btnLimpiarP";
            this.btnLimpiarP.Size = new System.Drawing.Size(102, 33);
            this.btnLimpiarP.TabIndex = 13;
            this.btnLimpiarP.Text = "Limpiar";
            this.btnLimpiarP.UseVisualStyleBackColor = true;
            this.btnLimpiarP.Click += new System.EventHandler(this.btnLimpiarP_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(466, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Nombre:";
            // 
            // lbNombreC
            // 
            this.lbNombreC.AutoSize = true;
            this.lbNombreC.Location = new System.Drawing.Point(466, 113);
            this.lbNombreC.Name = "lbNombreC";
            this.lbNombreC.Size = new System.Drawing.Size(50, 20);
            this.lbNombreC.TabIndex = 15;
            this.lbNombreC.Text = "label6";
            this.lbNombreC.Visible = false;
            // 
            // btnVolverP
            // 
            this.btnVolverP.Location = new System.Drawing.Point(652, 297);
            this.btnVolverP.Name = "btnVolverP";
            this.btnVolverP.Size = new System.Drawing.Size(102, 33);
            this.btnVolverP.TabIndex = 16;
            this.btnVolverP.Text = "Volver";
            this.btnVolverP.UseVisualStyleBackColor = true;
            this.btnVolverP.Click += new System.EventHandler(this.btnVolverP_Click);
            // 
            // lbPrecioP
            // 
            this.lbPrecioP.AutoSize = true;
            this.lbPrecioP.Location = new System.Drawing.Point(469, 240);
            this.lbPrecioP.Name = "lbPrecioP";
            this.lbPrecioP.Size = new System.Drawing.Size(28, 20);
            this.lbPrecioP.TabIndex = 18;
            this.lbPrecioP.Text = "0.0";
            this.lbPrecioP.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(466, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Pedido:";
            // 
            // lbLibrosP
            // 
            this.lbLibrosP.AutoSize = true;
            this.lbLibrosP.Location = new System.Drawing.Point(497, 208);
            this.lbLibrosP.Name = "lbLibrosP";
            this.lbLibrosP.Size = new System.Drawing.Size(50, 20);
            this.lbLibrosP.TabIndex = 19;
            this.lbLibrosP.Text = "label6";
            this.lbLibrosP.Visible = false;
            // 
            // lbIDlibro
            // 
            this.lbIDlibro.AutoSize = true;
            this.lbIDlibro.Location = new System.Drawing.Point(466, 208);
            this.lbIDlibro.Name = "lbIDlibro";
            this.lbIDlibro.Size = new System.Drawing.Size(17, 20);
            this.lbIDlibro.TabIndex = 20;
            this.lbIDlibro.Text = "0";
            this.lbIDlibro.Visible = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 363);
            this.Controls.Add(this.lbIDlibro);
            this.Controls.Add(this.lbLibrosP);
            this.Controls.Add(this.lbPrecioP);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnVolverP);
            this.Controls.Add(this.lbNombreC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnLimpiarP);
            this.Controls.Add(this.btnIngresarP);
            this.Controls.Add(this.dtime1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nUDcant);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nUDcant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nUDcant;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtime1;
        private System.Windows.Forms.Button btnIngresarP;
        private System.Windows.Forms.Button btnLimpiarP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbNombreC;
        private System.Windows.Forms.Button btnVolverP;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label lbPrecioP;
        public System.Windows.Forms.Label lbLibrosP;
        public System.Windows.Forms.Label lbIDlibro;
    }
}