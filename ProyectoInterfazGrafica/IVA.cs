using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoInterfazGrafica
{
    public partial class IVA : Form
    {
        String nombreUsuario;
        String[] categorias = { "Lácteo", "Fruta", "Verdura", "Fruto seco", "Cereal", "Carne" }; 





        public IVA(String nombre)
        {
            InitializeComponent();
            nombreUsuario = nombre; 
        } 

       

        private void Saludo_Click(object sender, EventArgs e)
        {
           
        }

        void MostrarListaCategorias()
        {
            int i; 
            for( i = 0; i<categorias.Length; i++)
            {
                comboBox1.Items.Add(categorias[i]);
            } 
        }

        private void IVA_Load(object sender, EventArgs e)
        {
            Saludo.Text += nombreUsuario;
            MostrarListaCategorias();
          
        }

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            this.Close(); 
        } 

         int validaciones()
        {
            if (NombreProducto.Text.Trim() == string.Empty || NombreProducto.Text.All(char.IsDigit)) 
            {
                return 1; 
            }
            else
            {
                if (comboBox1.SelectedIndex <= -1)
                {
                    return 2; 
                }
                else
                {
                    if (!(PrecioUnitario.Text.All(char.IsDigit)) || PrecioUnitario.Text == "")
                    {
                        return 3; 
                    } 

                }
            }
           return 0;  
         }

      
        private void BotonCalcular_Click(object sender, EventArgs e)
        {

            errorProvider1.Clear();
           

            double impuestoIva = 1.21;
            double precioFinal; 


            switch (validaciones())
            {
                case 0: 
                    {
                        precioFinal = int.Parse(PrecioUnitario.Text) * impuestoIva;
                        String mensaje = "El producto " + NombreProducto.Text + " de la categoría " + comboBox1.Text + " tiene un precio final de " + precioFinal + " pesos";
                        MessageBoxButtons botones = MessageBoxButtons.OK;
                        MessageBox.Show(mensaje,"Cálculo de precio Final", botones);
                        // al apretar OK en el Message Box, so borran los campos para poder ingresar otros nuevos. 
                        NombreProducto.Text = "";
                        comboBox1.SelectedIndex = -1;
                        PrecioUnitario.Text = ""; 

                        break; 
                    }
                case 1:
                    {
                        errorProvider1.SetError(NombreProducto, "Nombre de producto inválido o vacío");
                        break; 
                    }
                case 2:
                    {
                        errorProvider1.SetError(comboBox1, "debe seleccionar una opción "); 
                        break;
                    }
                case 3:
                    {
                        errorProvider1.SetError(PrecioUnitario, "valor inválido o vacío");
                        break;
                    }
            }

        }
    }
}
