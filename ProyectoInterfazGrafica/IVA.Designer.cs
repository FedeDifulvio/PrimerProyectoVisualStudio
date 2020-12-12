
namespace ProyectoInterfazGrafica
{
    partial class IVA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IVA));
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Saludo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NombreProducto = new System.Windows.Forms.TextBox();
            this.BotonCalcular = new System.Windows.Forms.Button();
            this.BotonVolver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PrecioUnitario = new System.Windows.Forms.TextBox();
            this.DatosProducto = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.DatosProducto.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Saludo
            // 
            this.Saludo.AutoSize = true;
            this.Saludo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Saludo.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Saludo.Location = new System.Drawing.Point(210, 40);
            this.Saludo.Name = "Saludo";
            this.Saludo.Size = new System.Drawing.Size(146, 29);
            this.Saludo.TabIndex = 0;
            this.Saludo.Text = "Bienvenido, ";
            this.Saludo.Click += new System.EventHandler(this.Saludo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre del Producto: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(131, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Categoría: ";
            // 
            // NombreProducto
            // 
            this.NombreProducto.Location = new System.Drawing.Point(237, 33);
            this.NombreProducto.Name = "NombreProducto";
            this.NombreProducto.Size = new System.Drawing.Size(182, 20);
            this.NombreProducto.TabIndex = 3;
            
            // 
            // BotonCalcular
            // 
            this.BotonCalcular.BackColor = System.Drawing.Color.MediumAquamarine;
            this.BotonCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonCalcular.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BotonCalcular.Location = new System.Drawing.Point(362, 330);
            this.BotonCalcular.Name = "BotonCalcular";
            this.BotonCalcular.Size = new System.Drawing.Size(114, 56);
            this.BotonCalcular.TabIndex = 4;
            this.BotonCalcular.Text = "CALCULAR";
            this.BotonCalcular.UseVisualStyleBackColor = false;
            this.BotonCalcular.Click += new System.EventHandler(this.BotonCalcular_Click);
            // 
            // BotonVolver
            // 
            this.BotonVolver.BackColor = System.Drawing.Color.LightCoral;
            this.BotonVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonVolver.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BotonVolver.Location = new System.Drawing.Point(686, 411);
            this.BotonVolver.Name = "BotonVolver";
            this.BotonVolver.Size = new System.Drawing.Size(106, 38);
            this.BotonVolver.TabIndex = 5;
            this.BotonVolver.Text = "VOLVER";
            this.BotonVolver.UseVisualStyleBackColor = false;
            this.BotonVolver.Click += new System.EventHandler(this.BotonVolver_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Precio unitario: ";
            // 
            // PrecioUnitario
            // 
            this.PrecioUnitario.Location = new System.Drawing.Point(237, 127);
            this.PrecioUnitario.Name = "PrecioUnitario";
            this.PrecioUnitario.Size = new System.Drawing.Size(182, 20);
            this.PrecioUnitario.TabIndex = 7;
           
            // 
            // DatosProducto
            // 
            this.DatosProducto.BackColor = System.Drawing.Color.NavajoWhite;
            this.DatosProducto.Controls.Add(this.comboBox1);
            this.DatosProducto.Controls.Add(this.NombreProducto);
            this.DatosProducto.Controls.Add(this.PrecioUnitario);
            this.DatosProducto.Controls.Add(this.label2);
            this.DatosProducto.Controls.Add(this.label1);
            this.DatosProducto.Controls.Add(this.label3);
            this.DatosProducto.Location = new System.Drawing.Point(125, 118);
            this.DatosProducto.Name = "DatosProducto";
            this.DatosProducto.Size = new System.Drawing.Size(510, 168);
            this.DatosProducto.TabIndex = 8;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(237, 77);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(182, 21);
            this.comboBox1.TabIndex = 8;
           
            // 
            // IVA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.DatosProducto);
            this.Controls.Add(this.BotonVolver);
            this.Controls.Add(this.BotonCalcular);
            this.Controls.Add(this.Saludo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "IVA";
            this.Text = "IVA";
            this.Load += new System.EventHandler(this.IVA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.DatosProducto.ResumeLayout(false);
            this.DatosProducto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label Saludo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NombreProducto;
        private System.Windows.Forms.Button BotonCalcular;
        private System.Windows.Forms.Panel DatosProducto;
        private System.Windows.Forms.TextBox PrecioUnitario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BotonVolver;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}