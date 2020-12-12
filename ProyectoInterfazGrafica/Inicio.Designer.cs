
namespace ProyectoInterfazGrafica
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nombreUsuario = new System.Windows.Forms.TextBox();
            this.BotonIngresar = new System.Windows.Forms.Button();
            this.BotonSalida = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(253, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cálculo de Precio Final";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoInterfazGrafica.Properties.Resources.IVA_Alquiler_1024x836;
            this.pictureBox1.Location = new System.Drawing.Point(312, 128);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(111, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = " Ingrese su nombre: ";
            // 
            // nombreUsuario
            // 
            this.nombreUsuario.Location = new System.Drawing.Point(312, 321);
            this.nombreUsuario.Name = "nombreUsuario";
            this.nombreUsuario.Size = new System.Drawing.Size(153, 20);
            this.nombreUsuario.TabIndex = 3;
            this.nombreUsuario.TextChanged += new System.EventHandler(this.nombreUsuario_TextChanged);
            // 
            // BotonIngresar
            // 
            this.BotonIngresar.BackColor = System.Drawing.Color.DarkTurquoise;
            this.BotonIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonIngresar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BotonIngresar.Location = new System.Drawing.Point(312, 363);
            this.BotonIngresar.Name = "BotonIngresar";
            this.BotonIngresar.Size = new System.Drawing.Size(153, 51);
            this.BotonIngresar.TabIndex = 4;
            this.BotonIngresar.Text = "INGRESAR";
            this.BotonIngresar.UseVisualStyleBackColor = false;
            this.BotonIngresar.Click += new System.EventHandler(this.BotonIngresar_Click);
            // 
            // BotonSalida
            // 
            this.BotonSalida.BackColor = System.Drawing.Color.OrangeRed;
            this.BotonSalida.ForeColor = System.Drawing.Color.Snow;
            this.BotonSalida.Location = new System.Drawing.Point(706, 391);
            this.BotonSalida.Name = "BotonSalida";
            this.BotonSalida.Size = new System.Drawing.Size(86, 44);
            this.BotonSalida.TabIndex = 5;
            this.BotonSalida.Text = "SALIR ";
            this.BotonSalida.UseVisualStyleBackColor = false;
            this.BotonSalida.Click += new System.EventHandler(this.BotonSalida_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.BotonSalida);
            this.Controls.Add(this.BotonIngresar);
            this.Controls.Add(this.nombreUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio ";
            this.Load += new System.EventHandler(this.Inicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nombreUsuario;
        private System.Windows.Forms.Button BotonIngresar;
        private System.Windows.Forms.Button BotonSalida;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

