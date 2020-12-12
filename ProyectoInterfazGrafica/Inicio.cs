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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void BotonSalida_Click(object sender, EventArgs e) 
        {
            this.Close(); 
        }

        private void Inicio_Load(object sender, EventArgs e) //Evento de inicio de la ventana. 
        {
            BotonIngresar.Enabled = false; 
        } 

        private void controlBotones() 
        { 
            //nombreUsuario.Text (es un string) -> nombreUsuario es un objeto de tipo textBox y la propiedad Text permite capturar lo que se escribe dentro. 
            // trim() -> quita los espacios en blanco del string. 
            //string.Empty -> representa un string vacio 
            // All(char.IsLetter) -> para corroborar que todos los caracteres sean letras. retorna un booleano. 

            if(nombreUsuario.Text.Trim()!= string.Empty && nombreUsuario.Text.All(char.IsLetter))
            {
                BotonIngresar.Enabled = true;
                errorProvider1.SetError(nombreUsuario, ""); 
            }
            else
            { 
                if(!(nombreUsuario.Text.All(char.IsLetter)))
                {
                    errorProvider1.SetError(nombreUsuario, "El nombre solo debe contener letras."); 
                }
                else
                {
                    errorProvider1.SetError(nombreUsuario, "Debe introducir su nombre");
                }
                BotonIngresar.Enabled = false;
                nombreUsuario.Focus(); //establece foco en el objeto que lo llama. 

            }

        }

        private void nombreUsuario_TextChanged(object sender, EventArgs e) // evento del textBox. Que acciones se realizan cuando no es texto lo que se ingresa. 
        {
            controlBotones(); 
        }

        private void BotonIngresar_Click(object sender, EventArgs e)
        {
            using (IVA ventanaIva = new IVA(nombreUsuario.Text))      //Using: luego de ejecutado el código, se borra de la memoria toda referencia del objeto
                ventanaIva.ShowDialog();                              // ShowDialog permite que el proximo formulario va ser modal, osea no podemos volver al primero sin haber realizado alguna accion en el segundo
        }
    }
}
