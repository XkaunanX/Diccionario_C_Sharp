using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace Diccionario_C_sharp
{
    public partial class Form2 : Form
    {
        //VARIABLES DE CONEXION

        private string ruta_imagen_display; //NECESARIO PARA LA PROPIEDAD

        public Form2(string texto_descripcion, string texto_etiqueta, string img_ventana) //PARAMETROS ENVIADOS DESDE EL FORM1

        {
            InitializeComponent();
            txt_descripcion2.Text = texto_descripcion;

            etiqueta_quienes_form2.Text = texto_etiqueta;

            picture_ventana.Image = Image.FromFile(img_ventana);
            picture_ventana.SizeMode = PictureBoxSizeMode.Zoom;
            
        }

        public Form2()
        {
        }

        //MOVIMIENTO BARRA POR LIBRERIA

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);

        //CREO UNA PROPIEDAD

        public string Ruta_Imagen_Display
        {
            set
            {
                ruta_imagen_display = value;
                display_ejemplo2.Image = Image.FromFile(ruta_imagen_display);
            }
        }

        private void barra2_MouseDown(object sender, MouseEventArgs e)//MOVIMIENTO MOUSEDOWN BARRA
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void etiqueta_quienes_form2_MouseDown(object sender, MouseEventArgs e)//MOVIMIENTO MOUSEDOWN ETIQUETA
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btncerrar2_Click(object sender, EventArgs e)//CERRAR LA VENTANA
        {   
            this.Close();
        }

        
    }
}
