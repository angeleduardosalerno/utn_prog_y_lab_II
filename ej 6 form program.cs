using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void rtxtTexto_TextChanged(object sender, EventArgs e)
        {
            int cantidadPalabras = 0;
            int cantidadFinalizaLA = 0;

            //ESTA PARTE ES PARA LEER LAS PALABRAS QUE TIENEN A Y ESPACIO AL FINAL!
            // Quito los espacios en blanco a izquierda y derecha - SACA EL ESPACIO DEL PRINCIPIO Y DEL FINAL!
            string texto = rtxtTexto.Text.Trim();
            // Divido la cadena a través de los espacios vacios ' ' y la recorro

            foreach (string s in texto.Split(' ')) // ACA LO QUE SE ANALIZA ES EL TEXTO QUE SE OBTIENE DEL RICHTEXT!
            {
                // Si la palabra no es null o vacia, incremento mi acumulador

                if (!string.IsNullOrEmpty(s))
                {
                    cantidadPalabras += 1; // AUMENTA EL CONTADOR!
                    
                    // Si finaliza en "la" incremento mi acumulador

                    if (s.Length >= 2) // SI LA PALABRA ES MAS GRANDE QUE DOS LETRAS!
                        if (s.ToLower().LastIndexOf("la") == s.Length - 2) // ACA BUSCA LA ULTIMA PALABRA! COMPARA USANDO LAST INDEX CON LENGHTH!
                            cantidadFinalizaLA += 1; // AUMENTA EL CONTADOR!
                }
            }

           
            lblPalabras1.Text = cantidadPalabras.ToString(); //ACA LE PASA A STRING EL TEXTO AL LBL
            lblFinalizaLA.Text = cantidadFinalizaLA.ToString(); //ACA LE PASA A STRING EL TEXTO AL LBL
            //ACA HAY QUE PONER EL .TEXT POR QUE SINO NO LO LEE, ESTO ES COMO DECIRLE EN EL TEXTO DEL LBL...
        }

        private void txtVeintePalabras_Click(object sender, EventArgs e)
        {
            txtResultado.Text = ""; // ACA LE PONES AL TEXTO DEL TXT RESULTADO EN BLANCO!

            int acum = 0;
            
            // Quito los espacios en blanco a izquierda y derecha
            string texto = rtxtTexto.Text.Trim();

            // Divido la cadena a través de los espacios vacios ' ' y la recorro
            foreach (string s in texto.Split(' '))
            {
                // Si la palabra no es null o vacia, la muestro
                if (!string.IsNullOrEmpty(s))
                {
                    txtResultado.Text += "* " + s; // ACA IMPRIME LA PALABRA S ANTECEDIDA DE UN * !!
                    // Cuanto haya llegado a las 20 palabras, rompo el FOR
                    acum++;

                    if (acum >= 20)
                        break;
                }
            }
        }

        private void btnCienLetras_Click(object sender, EventArgs e)
        {
            // Limpio el cuadro de resultados
            txtResultado.Text = "";

            // Calculo el valor máximo para substring
            //         = CONDICION ? true : false;
            int valMax = rtxtTexto.Text.Length >= 100 ? 100 : rtxtTexto.Text.Length;

            txtResultado.Text = rtxtTexto.Text.Substring(0, valMax); // aca te imprime del 0 al 100 por pantalla de texto
        }
    }
}
