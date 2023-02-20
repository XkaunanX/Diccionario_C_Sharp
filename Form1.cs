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
using System.Timers;

namespace Diccionario_C_sharp
{
    public partial class form1 : Form
    {
        //VARIABLES RUTAS IMAGENES

        public string direccion_recursos = Directory.GetCurrentDirectory() + @"\Resources";  // direccion_programa + @"\Resources";

        public int conteo;


        public form1()
        {
            InitializeComponent();

            conteo = 0;
            animacion.Enabled = true;
        }

        //MOVIMIENTO BARRA POR LIBRERIA

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);

        private void barra_MouseDown(object sender, MouseEventArgs e)
        {
            //OBJETO AL QUE APLICA EL MOVIMIENTO

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void etiquetabarra_MouseDown(object sender, MouseEventArgs e)
        {
            //OBJETO AL QUE APLICA EL MOVIMIENTO

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            //CERRAR APLICACION

            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //MINIMIZAR APLICACION

            this.WindowState = FormWindowState.Minimized;
        }

        private void form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Form1 Cargado correctamente");

        }

        //EVENTOS DE BOTONES EVENTOS DE BOTONES EVENTOS DE BOTONES EVENTOS DE BOTONES_________¡


        public void btn_for_loop_Click(object sender, EventArgs e)
        {
            //BOTON FOR

            TextReader leer = new StreamReader(direccion_recursos + @"\for_descripcion.txt");//LECTURA DE INFORMACION

            string texto_etiqueta = "Bucle For";

            string img_form2 = (direccion_recursos + @"\refresh.png");

            Form2 miforma = new Form2(leer.ReadToEnd(), texto_etiqueta, img_form2); //PARAMETROS UTILIZADOS EN EL FORM2 PARAMETRO1, PAR2,PAR3 ...

            miforma.Ruta_Imagen_Display = (direccion_recursos + @"\for_ejemplo.png"); //OTRA FORMA DE MANDAR INFORMACION A FORM 2 ATRAVEZ DE PROPIEDADES

            display_sintaxis.Image = null;
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;

            var a = direccion_recursos + @"\sintaxis_for.png";
            Console.WriteLine(a);
            display_sintaxis.Image = Image.FromFile(a);
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;

            miforma.Show();

        }

        private void btn_foreach_loop_Click(object sender, EventArgs e)
        {
            //BOTON FOREACH

            TextReader leer = new StreamReader(direccion_recursos + @"\foreach_descripcion.txt");//LECTURA DE INFORMACION

            string texto_etiqueta = "Bucle Foreach";

            string img_form2 = (direccion_recursos + @"\refresh.png");

            Form2 miforma = new Form2(leer.ReadToEnd(), texto_etiqueta, img_form2); //PARAMETROS UTILIZADOS EN EL FORM2 PARAMETRO1, PAR2,PAR3 ...

            miforma.Ruta_Imagen_Display = (direccion_recursos + @"\foreach_ejemplo.png"); //OTRA FORMA DE MANDAR INFORMACION A FORM 2 ATRAVEZ DE PROPIEDADES

            display_sintaxis.Image = null;
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;

            var a = direccion_recursos + @"\sintaxis_foreach.png";
            Console.WriteLine(a);
            display_sintaxis.Image = Image.FromFile(a);
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;

            miforma.Show();
        }

        private void btn_while_loop_Click(object sender, EventArgs e)
        {
            //BOTON WHILELOOP

            TextReader leer = new StreamReader(direccion_recursos + @"\while_descripcion.txt");//LECTURA DE INFORMACION

            string texto_etiqueta = "Bucle While";

            string img_form2 = (direccion_recursos + @"\refresh.png");

            Form2 miforma = new Form2(leer.ReadToEnd(), texto_etiqueta, img_form2); //PARAMETROS UTILIZADOS EN EL FORM2 PARAMETRO1, PAR2,PAR3 ...

            miforma.Ruta_Imagen_Display = (direccion_recursos + @"\while_ejemplo.png"); //OTRA FORMA DE MANDAR INFORMACION A FORM 2 ATRAVEZ DE PROPIEDADES

            display_sintaxis.Image = null;
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;

            var a = direccion_recursos + @"\sintaxis_while.png";
            Console.WriteLine(a);
            display_sintaxis.Image = Image.FromFile(a);
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;

            miforma.Show();

        }

        private void btn_do_while_Click(object sender, EventArgs e)
        {
            //BOTON DOWHILE

            TextReader leer = new StreamReader(direccion_recursos + @"\dowhile_descripcion.txt");//LECTURA DE INFORMACION

            string texto_etiqueta = "Bucle Do While";

            string img_form2 = (direccion_recursos + @"\refresh.png");

            Form2 miforma = new Form2(leer.ReadToEnd(), texto_etiqueta, img_form2); //PARAMETROS UTILIZADOS EN EL FORM2 PARAMETRO1, PAR2,PAR3 ...

            miforma.Ruta_Imagen_Display = (direccion_recursos + @"\dowhile_ejemplo.png"); //OTRA FORMA DE MANDAR INFORMACION A FORM 2 ATRAVEZ DE PROPIEDADES

            display_sintaxis.Image = null;
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;

            var a = direccion_recursos + @"\sintaxis_dowhile.png";
            Console.WriteLine(a);
            display_sintaxis.Image = Image.FromFile(a);
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;

            miforma.Show();
        }

        private void btn_write_Click(object sender, EventArgs e)
        {
            //BOTON WRITE

            TextReader leer = new StreamReader(direccion_recursos + @"\write_descripcion.txt");//LECTURA DE INFORMACION

            string texto_etiqueta = "Write";

            string img_form2 = (direccion_recursos + @"\output.png");

            Form2 miforma = new Form2(leer.ReadToEnd(), texto_etiqueta, img_form2); //PARAMETROS UTILIZADOS EN EL FORM2 PARAMETRO1, PAR2,PAR3 ...

            miforma.Ruta_Imagen_Display = (direccion_recursos + @"\write_ejemplo.png"); //OTRA FORMA DE MANDAR INFORMACION A FORM 2 ATRAVEZ DE PROPIEDADES

            display_sintaxis.Image = null;
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;

            var a = direccion_recursos + @"\sintaxis_write.png";
            Console.WriteLine(a);
            display_sintaxis.Image = Image.FromFile(a);
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;

            miforma.Show();

        }

        private void btn_write_line_Click(object sender, EventArgs e)
        {
            //BOTON WRITELINE

            TextReader leer = new StreamReader(direccion_recursos + @"\writeline_descripcion.txt");//LECTURA DE INFORMACION

            string texto_etiqueta = "WriteLine";

            string img_form2 = (direccion_recursos + @"\output.png");

            Form2 miforma = new Form2(leer.ReadToEnd(), texto_etiqueta, img_form2); //PARAMETROS UTILIZADOS EN EL FORM2 PARAMETRO1, PAR2,PAR3 ...

            miforma.Ruta_Imagen_Display = (direccion_recursos + @"\writeline_ejemplo.png"); //OTRA FORMA DE MANDAR INFORMACION A FORM 2 ATRAVEZ DE PROPIEDADES

            display_sintaxis.Image = null;
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;

            var a = direccion_recursos + @"\sintaxis_writeline.png";
            Console.WriteLine(a);
            display_sintaxis.Image = Image.FromFile(a);
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;

            miforma.Show();
        }

        private void btn_int_Click(object sender, EventArgs e)
        {
            //BOTON INT

            TextReader leer = new StreamReader(direccion_recursos + @"\int_descripcion.txt");//LECTURA DE INFORMACION

            string texto_etiqueta = "Tipo de Dato Entero";

            string img_form2 = (direccion_recursos + @"\caja.png");

            Form2 miforma = new Form2(leer.ReadToEnd(), texto_etiqueta, img_form2); //PARAMETROS UTILIZADOS EN EL FORM2 PARAMETRO1, PAR2,PAR3 ...

            miforma.Ruta_Imagen_Display = (direccion_recursos + @"\int_ejemplo.png"); //OTRA FORMA DE MANDAR INFORMACION A FORM 2 ATRAVEZ DE PROPIEDADES

            display_sintaxis.Image = null;
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;

            var a = direccion_recursos + @"\sintaxis_int.png";
            Console.WriteLine(a);
            display_sintaxis.Image = Image.FromFile(a);
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;
            int s = 123;

            if (s < 123)
            {

            }
            miforma.Show();
        }

        private void btn_double_Click(object sender, EventArgs e)
        {
            //BOTON DOUBLE

            TextReader leer = new StreamReader(direccion_recursos + @"\double_descripcion.txt");//LECTURA DE INFORMACION

            string texto_etiqueta = "Tipo de Dato de Numero Flotante";

            string img_form2 = (direccion_recursos + @"\caja.png");

            Form2 miforma = new Form2(leer.ReadToEnd(), texto_etiqueta, img_form2); //PARAMETROS UTILIZADOS EN EL FORM2 PARAMETRO1, PAR2,PAR3 ...

            miforma.Ruta_Imagen_Display = (direccion_recursos + @"\double_ejemplo.png"); //OTRA FORMA DE MANDAR INFORMACION A FORM 2 ATRAVEZ DE PROPIEDADES

            display_sintaxis.Image = null;
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;

            var a = direccion_recursos + @"\sintaxis_double.png";
            Console.WriteLine(a);
            display_sintaxis.Image = Image.FromFile(a);
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;

            miforma.Show();

        }

        private void btn_char_Click(object sender, EventArgs e)
        {
            //BOTON CHAR

            TextReader leer = new StreamReader(direccion_recursos + @"\char_descripcion.txt");//LECTURA DE INFORMACION

            string texto_etiqueta = "Tipo de Dato Caracter";

            string img_form2 = (direccion_recursos + @"\caja.png");

            Form2 miforma = new Form2(leer.ReadToEnd(), texto_etiqueta, img_form2); //PARAMETROS UTILIZADOS EN EL FORM2 PARAMETRO1, PAR2,PAR3 ...

            miforma.Ruta_Imagen_Display = (direccion_recursos + @"\char_ejemplo.png"); //OTRA FORMA DE MANDAR INFORMACION A FORM 2 ATRAVEZ DE PROPIEDADES

            display_sintaxis.Image = null;
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;

            var a = direccion_recursos + @"\sintaxis_char.png";
            Console.WriteLine(a);
            display_sintaxis.Image = Image.FromFile(a);
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;

            miforma.Show();

        }

        private void btn_string_Click(object sender, EventArgs e)
        {
            //BOTON STRING

            TextReader leer = new StreamReader(direccion_recursos + @"\string_descripcion.txt");//LECTURA DE INFORMACION

            string texto_etiqueta = "Tipo de Dato de Cadena de Caracteres";

            string img_form2 = (direccion_recursos + @"\caja.png");

            Form2 miforma = new Form2(leer.ReadToEnd(), texto_etiqueta, img_form2); //PARAMETROS UTILIZADOS EN EL FORM2 PARAMETRO1, PAR2,PAR3 ...

            miforma.Ruta_Imagen_Display = (direccion_recursos + @"\string_ejemplo.png"); //OTRA FORMA DE MANDAR INFORMACION A FORM 2 ATRAVEZ DE PROPIEDADES

            display_sintaxis.Image = null;
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;

            var a = direccion_recursos + @"\sintaxis_string.png";
            Console.WriteLine(a);
            display_sintaxis.Image = Image.FromFile(a);
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;

            miforma.Show();
        }

        private void btn_boolean_Click(object sender, EventArgs e)
        {
            //BOTON BOOLEAN

            TextReader leer = new StreamReader(direccion_recursos + @"\boolean_descripcion.txt");//LECTURA DE INFORMACION

            string texto_etiqueta = "Tipo de Dato Boolean";

            string img_form2 = (direccion_recursos + @"\caja.png");

            Form2 miforma = new Form2(leer.ReadToEnd(), texto_etiqueta, img_form2); //PARAMETROS UTILIZADOS EN EL FORM2 PARAMETRO1, PAR2,PAR3 ...

            miforma.Ruta_Imagen_Display = (direccion_recursos + @"\boolean_ejemplo.png"); //OTRA FORMA DE MANDAR INFORMACION A FORM 2 ATRAVEZ DE PROPIEDADES

            display_sintaxis.Image = null;
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;

            var a = direccion_recursos + @"\sintaxis_boolean.png";
            Console.WriteLine(a);
            display_sintaxis.Image = Image.FromFile(a);
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;

            miforma.Show();

        }

        private void btn_var_Click(object sender, EventArgs e)
        {
            //B0TON VAR

            TextReader leer = new StreamReader(direccion_recursos + @"\var_descripcion.txt");//LECTURA DE INFORMACION

            string texto_etiqueta = "Tipo de Dato implicito";

            string img_form2 = (direccion_recursos + @"\caja.png");

            Form2 miforma = new Form2(leer.ReadToEnd(), texto_etiqueta, img_form2); //PARAMETROS UTILIZADOS EN EL FORM2 PARAMETRO1, PAR2,PAR3 ...

            miforma.Ruta_Imagen_Display = (direccion_recursos + @"\var_ejemplo.png"); //OTRA FORMA DE MANDAR INFORMACION A FORM 2 ATRAVEZ DE PROPIEDADES

            display_sintaxis.Image = null;
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;

            var a = direccion_recursos + @"\sintaxis_var.png";
            Console.WriteLine(a);
            display_sintaxis.Image = Image.FromFile(a);
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;

            miforma.Show();
        }

        private void btn_const_Click(object sender, EventArgs e)
        {
            //BOTON CONST

            TextReader leer = new StreamReader(direccion_recursos + @"\constante_descripcion.txt");//LECTURA DE INFORMACION

            string texto_etiqueta = "Tipo de Dato que No Cambia durante Ejecucion";

            string img_form2 = (direccion_recursos + @"\identificacion.png");

            Form2 miforma = new Form2(leer.ReadToEnd(), texto_etiqueta, img_form2); //PARAMETROS UTILIZADOS EN EL FORM2 PARAMETRO1, PAR2,PAR3 ...

            miforma.Ruta_Imagen_Display = (direccion_recursos + @"\constante_ejemplo.png"); //OTRA FORMA DE MANDAR INFORMACION A FORM 2 ATRAVEZ DE PROPIEDADES

            display_sintaxis.Image = null;
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;

            var a = direccion_recursos + @"\sintaxis_constante.png";
            Console.WriteLine(a);
            display_sintaxis.Image = Image.FromFile(a);
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;

            miforma.Show();
        }


        private void btn_con_to_dou_Click(object sender, EventArgs e)
        {
            //CONVERT TO DOUBLE

            TextReader leer = new StreamReader(direccion_recursos + @"\convert_to_double_descripcion.txt");//LECTURA DE INFORMACION

            string texto_etiqueta = "Convert.ToDouble";

            string img_form2 = (direccion_recursos + @"\convertir.png");

            Form2 miforma = new Form2(leer.ReadToEnd(), texto_etiqueta, img_form2); //PARAMETROS UTILIZADOS EN EL FORM2 PARAMETRO1, PAR2,PAR3 ...

            miforma.Ruta_Imagen_Display = (direccion_recursos + @"\convert_to_double_ejemplo.png"); //OTRA FORMA DE MANDAR INFORMACION A FORM 2 ATRAVEZ DE PROPIEDADES

            display_sintaxis.Image = null;
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;

            var a = direccion_recursos + @"\sintaxis_convert_to_double.png";
            Console.WriteLine(a);
            display_sintaxis.Image = Image.FromFile(a);
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;

            miforma.Show();

        }


        private void btn_con_to_str_Click(object sender, EventArgs e)
        {
            //BOTON CONVERT TO STRING

            TextReader leer = new StreamReader(direccion_recursos + @"\convert_to_string_descripcion.txt");//LECTURA DE INFORMACION

            string texto_etiqueta = "Convert.ToString";

            string img_form2 = (direccion_recursos + @"\convertir.png");

            Form2 miforma = new Form2(leer.ReadToEnd(), texto_etiqueta, img_form2); //PARAMETROS UTILIZADOS EN EL FORM2 PARAMETRO1, PAR2,PAR3 ...

            miforma.Ruta_Imagen_Display = (direccion_recursos + @"\convert_to_string_ejemplo.png"); //OTRA FORMA DE MANDAR INFORMACION A FORM 2 ATRAVEZ DE PROPIEDADES

            display_sintaxis.Image = null;
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;

            var a = direccion_recursos + @"\sintaxis_convert_to_string.png";
            Console.WriteLine(a);
            display_sintaxis.Image = Image.FromFile(a);
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;

            miforma.Show();
        }

        private void btn_con_to_int32_Click(object sender, EventArgs e)
        {
            //BOTON CONVERT TO INTEGER

            TextReader leer = new StreamReader(direccion_recursos + @"\convert_to_integer_descripcion.txt");//LECTURA DE INFORMACION

            string texto_etiqueta = "Convert.ToInt32";

            string img_form2 = (direccion_recursos + @"\convertir.png");

            Form2 miforma = new Form2(leer.ReadToEnd(), texto_etiqueta, img_form2); //PARAMETROS UTILIZADOS EN EL FORM2 PARAMETRO1, PAR2,PAR3 ...

            miforma.Ruta_Imagen_Display = (direccion_recursos + @"\convert_to_integer_ejemplo.png"); //OTRA FORMA DE MANDAR INFORMACION A FORM 2 ATRAVEZ DE PROPIEDADES

            display_sintaxis.Image = null;
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;

            var a = direccion_recursos + @"\sintaxis_convert_to_integer.png";
            Console.WriteLine(a);
            display_sintaxis.Image = Image.FromFile(a);
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;

            miforma.Show();

        }

        private void btn_con_to_int64_Click(object sender, EventArgs e)
        {
            //BOTON CONVERT TO LONG

            TextReader leer = new StreamReader(direccion_recursos + @"\convert_to_long_descripcion.txt");//LECTURA DE INFORMACION

            string texto_etiqueta = "Convert.ToInt64";

            string img_form2 = (direccion_recursos + @"\convertir.png");

            Form2 miforma = new Form2(leer.ReadToEnd(), texto_etiqueta, img_form2); //PARAMETROS UTILIZADOS EN EL FORM2 PARAMETRO1, PAR2,PAR3 ...

            miforma.Ruta_Imagen_Display = (direccion_recursos + @"\convert_to_long_ejemplo.png"); //OTRA FORMA DE MANDAR INFORMACION A FORM 2 ATRAVEZ DE PROPIEDADES

            display_sintaxis.Image = null;
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;

            var a = direccion_recursos + @"\sintaxis_convert_to_long.png";
            Console.WriteLine(a);
            display_sintaxis.Image = Image.FromFile(a);
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;

            miforma.Show();
        }

        private void btn_str_len_Click(object sender, EventArgs e)
        {
            //BOTON STRING LENGHT

            TextReader leer = new StreamReader(direccion_recursos + @"\string_lenght_descripcion.txt");//LECTURA DE INFORMACION

            string texto_etiqueta = "string.Lenght";

            string img_form2 = (direccion_recursos + @"\bloque.png");

            Form2 miforma = new Form2(leer.ReadToEnd(), texto_etiqueta, img_form2); //PARAMETROS UTILIZADOS EN EL FORM2 PARAMETRO1, PAR2,PAR3 ...

            miforma.Ruta_Imagen_Display = (direccion_recursos + @"\string_lenght_ejemplo.png"); //OTRA FORMA DE MANDAR INFORMACION A FORM 2 ATRAVEZ DE PROPIEDADES

            display_sintaxis.Image = null;
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;

            var a = direccion_recursos + @"\sintaxis_string_lenght.png";
            Console.WriteLine(a);
            display_sintaxis.Image = Image.FromFile(a);
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;

            miforma.Show();

        }

        private void btn_toupper_Click(object sender, EventArgs e)
        {
            //BOTON TOUPPER

            TextReader leer = new StreamReader(direccion_recursos + @"\toupper_descripcion.txt");//LECTURA DE INFORMACION

            string texto_etiqueta = "string.ToUpper";

            string img_form2 = (direccion_recursos + @"\bloque.png");

            Form2 miforma = new Form2(leer.ReadToEnd(), texto_etiqueta, img_form2); //PARAMETROS UTILIZADOS EN EL FORM2 PARAMETRO1, PAR2,PAR3 ...

            miforma.Ruta_Imagen_Display = (direccion_recursos + @"\toupper_ejemplo.png"); //OTRA FORMA DE MANDAR INFORMACION A FORM 2 ATRAVEZ DE PROPIEDADES

            display_sintaxis.Image = null;
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;

            var a = direccion_recursos + @"\sintaxis_toupper.png";
            Console.WriteLine(a);
            display_sintaxis.Image = Image.FromFile(a);
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;


            miforma.Show();
        }

        private void btn_tolower_Click(object sender, EventArgs e)
        {
            //BOTON TOLOWER

            TextReader leer = new StreamReader(direccion_recursos + @"\tolower_descripcion.txt");//LECTURA DE INFORMACION

            string texto_etiqueta = "string.ToLower";

            string img_form2 = (direccion_recursos + @"\bloque.png");

            Form2 miforma = new Form2(leer.ReadToEnd(), texto_etiqueta, img_form2); //PARAMETROS UTILIZADOS EN EL FORM2 PARAMETRO1, PAR2,PAR3 ...

            miforma.Ruta_Imagen_Display = (direccion_recursos + @"\tolower_ejemplo.png"); //OTRA FORMA DE MANDAR INFORMACION A FORM 2 ATRAVEZ DE PROPIEDADES

            display_sintaxis.Image = null;
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;

            var a = direccion_recursos + @"\sintaxis_tolower.png";
            Console.WriteLine(a);
            display_sintaxis.Image = Image.FromFile(a);
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;

            miforma.Show();
        }

        private void btn_str_concat_Click(object sender, EventArgs e)
        {
            //BOTON STRING CONCAT
            TextReader leer = new StreamReader(direccion_recursos + @"\string_concatenacion_descripcion.txt");//LECTURA DE INFORMACION

            string texto_etiqueta = "Concatenacion";

            string img_form2 = (direccion_recursos + @"\bloque.png");

            Form2 miforma = new Form2(leer.ReadToEnd(), texto_etiqueta, img_form2); //PARAMETROS UTILIZADOS EN EL FORM2 PARAMETRO1, PAR2,PAR3 ...

            miforma.Ruta_Imagen_Display = (direccion_recursos + @"\string_concatenacion_ejemplo.png"); //OTRA FORMA DE MANDAR INFORMACION A FORM 2 ATRAVEZ DE PROPIEDADES

            display_sintaxis.Image = null;
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;

            var a = direccion_recursos + @"\sintaxis_string_concatenacion.png";
            Console.WriteLine(a);
            display_sintaxis.Image = Image.FromFile(a);
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;

            miforma.Show();
        }

        private void btn_indexof_Click(object sender, EventArgs e)
        {
            //BOTON INDEXOF

            TextReader leer = new StreamReader(direccion_recursos + @"\indexof_descripcion.txt");//LECTURA DE INFORMACION

            string texto_etiqueta = "Encontrar Indice de 'cuerda' en String";

            string img_form2 = (direccion_recursos + @"\bloque.png");

            Form2 miforma = new Form2(leer.ReadToEnd(), texto_etiqueta, img_form2); //PARAMETROS UTILIZADOS EN EL FORM2 PARAMETRO1, PAR2,PAR3 ...

            miforma.Ruta_Imagen_Display = (direccion_recursos + @"\indexof_ejemplo.png"); //OTRA FORMA DE MANDAR INFORMACION A FORM 2 ATRAVEZ DE PROPIEDADES

            display_sintaxis.Image = null;
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;

            var a = direccion_recursos + @"\sintaxis_indexof.png";
            Console.WriteLine(a);
            display_sintaxis.Image = Image.FromFile(a);
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;

            miforma.Show();

        }

        private void btn_substring_Click(object sender, EventArgs e)
        {
            //BOTON SUBSTRING


            TextReader leer = new StreamReader(direccion_recursos + @"\substring_descripcion.txt");//LECTURA DE INFORMACION

            string texto_etiqueta = "Devuelve una Cadena a Partir de Otra";

            string img_form2 = (direccion_recursos + @"\bloque.png");

            Form2 miforma = new Form2(leer.ReadToEnd(), texto_etiqueta, img_form2); //PARAMETROS UTILIZADOS EN EL FORM2 PARAMETRO1, PAR2,PAR3 ...

            miforma.Ruta_Imagen_Display = (direccion_recursos + @"\substring_ejemplo.png"); //OTRA FORMA DE MANDAR INFORMACION A FORM 2 ATRAVEZ DE PROPIEDADES

            display_sintaxis.Image = null;
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;

            var a = direccion_recursos + @"\sintaxis_substring.png";
            Console.WriteLine(a);
            display_sintaxis.Image = Image.FromFile(a);
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;

            miforma.Show();

        }

        private void btn_interpolation_Click(object sender, EventArgs e)
        {
            //BOTON Trim

            TextReader leer = new StreamReader(direccion_recursos + @"\trim_descripcion.txt");//LECTURA DE INFORMACION

            string texto_etiqueta = "Elimina lo Especificado";

            string img_form2 = (direccion_recursos + @"\bloque.png");

            Form2 miforma = new Form2(leer.ReadToEnd(), texto_etiqueta, img_form2); //PARAMETROS UTILIZADOS EN EL FORM2 PARAMETRO1, PAR2,PAR3 ...

            miforma.Ruta_Imagen_Display = (direccion_recursos + @"\trim_ejemplo.png"); //OTRA FORMA DE MANDAR INFORMACION A FORM 2 ATRAVEZ DE PROPIEDADES

            display_sintaxis.Image = null;
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;

            var a = direccion_recursos + @"\sintaxis_trim.png";
            Console.WriteLine(a);
            display_sintaxis.Image = Image.FromFile(a);
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;

            miforma.Show();
        }

        private void btn_if_Click(object sender, EventArgs e)
        {
            //BOTON IF

            TextReader leer = new StreamReader(direccion_recursos + @"\if_decripcion.txt");//LECTURA DE INFORMACION

            string texto_etiqueta = "Ejecuta el Codigo en Su Interior SI Cumple la Condicion";

            string img_form2 = (direccion_recursos + @"\bloque.png");

            Form2 miforma = new Form2(leer.ReadToEnd(), texto_etiqueta, img_form2); //PARAMETROS UTILIZADOS EN EL FORM2 PARAMETRO1, PAR2,PAR3 ...

            miforma.Ruta_Imagen_Display = (direccion_recursos + @"\if_ejemplo.png"); //OTRA FORMA DE MANDAR INFORMACION A FORM 2 ATRAVEZ DE PROPIEDADES

            display_sintaxis.Image = null;
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;

            var a = direccion_recursos + @"\sintaxis_if.png";
            Console.WriteLine(a);
            display_sintaxis.Image = Image.FromFile(a);
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;

            miforma.Show();
        }

        private void btn_else_Click(object sender, EventArgs e)
        {
            //BOTON ELSE

            TextReader leer = new StreamReader(direccion_recursos + @"\else_descripcion.txt");//LECTURA DE INFORMACION

            string texto_etiqueta = "Ejecuta el Codigo en Su Interior SI Cumple la Condicion o No La Cumple";

            string img_form2 = (direccion_recursos + @"\bloque.png");

            Form2 miforma = new Form2(leer.ReadToEnd(), texto_etiqueta, img_form2); //PARAMETROS UTILIZADOS EN EL FORM2 PARAMETRO1, PAR2,PAR3 ...

            miforma.Ruta_Imagen_Display = (direccion_recursos + @"\else_ejemplo.png"); //OTRA FORMA DE MANDAR INFORMACION A FORM 2 ATRAVEZ DE PROPIEDADES

            display_sintaxis.Image = null;
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;

            var a = direccion_recursos + @"\sintaxis_else.png";
            Console.WriteLine(a);
            display_sintaxis.Image = Image.FromFile(a);
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;

            miforma.Show();
        }

        private void btn_elseif_Click(object sender, EventArgs e)
        {
            TextReader leer = new StreamReader(direccion_recursos + @"\elseif_descripcion.txt");//LECTURA DE INFORMACION

            string texto_etiqueta = "Luego del Primer IF Crea Una Nueva Condicion";

            string img_form2 = (direccion_recursos + @"\bloque.png");

            Form2 miforma = new Form2(leer.ReadToEnd(), texto_etiqueta, img_form2); //PARAMETROS UTILIZADOS EN EL FORM2 PARAMETRO1, PAR2,PAR3 ...

            miforma.Ruta_Imagen_Display = (direccion_recursos + @"\elseif_ejemplo.png"); //OTRA FORMA DE MANDAR INFORMACION A FORM 2 ATRAVEZ DE PROPIEDADES

            display_sintaxis.Image = null;
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;

            var a = direccion_recursos + @"\sintaxis_elseif.png";
            Console.WriteLine(a);
            display_sintaxis.Image = Image.FromFile(a);
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;

            miforma.Show();
        }

        private void btn_switch_Click(object sender, EventArgs e)
        {
            //BOTON SWITCH
            TextReader leer = new StreamReader(direccion_recursos + @"\switch_descripcion.txt");//LECTURA DE INFORMACION

            string texto_etiqueta = "Selecciona una Lista de Instrucciones Para Ejecutarla";

            string img_form2 = (direccion_recursos + @"\choice.png");

            Form2 miforma = new Form2(leer.ReadToEnd(), texto_etiqueta, img_form2); //PARAMETROS UTILIZADOS EN EL FORM2 PARAMETRO1, PAR2,PAR3 ...

            miforma.Ruta_Imagen_Display = (direccion_recursos + @"\switch_ejemplo.png"); //OTRA FORMA DE MANDAR INFORMACION A FORM 2 ATRAVEZ DE PROPIEDADES

            display_sintaxis.Image = null;
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;

            var a = direccion_recursos + @"\sintaxis_switch.png";
            Console.WriteLine(a);
            display_sintaxis.Image = Image.FromFile(a);
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;

            miforma.Show();
        }

        private void btn_case_Click(object sender, EventArgs e)
        {
            //BOTON CASE
            TextReader leer = new StreamReader(direccion_recursos + @"\case_descripcion.txt");//LECTURA DE INFORMACION

            string texto_etiqueta = "Si hay Una Coincidencia, se Ejecuta el Bloque de Código Asociado";

            string img_form2 = (direccion_recursos + @"\choice.png");

            Form2 miforma = new Form2(leer.ReadToEnd(), texto_etiqueta, img_form2); //PARAMETROS UTILIZADOS EN EL FORM2 PARAMETRO1, PAR2,PAR3 ...

            miforma.Ruta_Imagen_Display = (direccion_recursos + @"\case_ejemplo.png"); //OTRA FORMA DE MANDAR INFORMACION A FORM 2 ATRAVEZ DE PROPIEDADES

            display_sintaxis.Image = null;
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;

            var a = direccion_recursos + @"\sintaxis_case.png";
            Console.WriteLine(a);
            display_sintaxis.Image = Image.FromFile(a);
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;

            miforma.Show();
        }

        private void btn_break_Click(object sender, EventArgs e)
        {
            //BOTON BREAK
            TextReader leer = new StreamReader(direccion_recursos + @"\break_descripcion.txt");//LECTURA DE INFORMACION

            string texto_etiqueta = "Salir del Switch";

            string img_form2 = (direccion_recursos + @"\choice.png");

            Form2 miforma = new Form2(leer.ReadToEnd(), texto_etiqueta, img_form2); //PARAMETROS UTILIZADOS EN EL FORM2 PARAMETRO1, PAR2,PAR3 ...

            miforma.Ruta_Imagen_Display = (direccion_recursos + @"\break_ejemplo.png"); //OTRA FORMA DE MANDAR INFORMACION A FORM 2 ATRAVEZ DE PROPIEDADES

            display_sintaxis.Image = null;
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;

            var a = direccion_recursos + @"\sintaxis_break.png";
            Console.WriteLine(a);
            display_sintaxis.Image = Image.FromFile(a);
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;

            miforma.Show();
        }


        private void btn_default_Click(object sender, EventArgs e)
        {
            //DEFAULT
            TextReader leer = new StreamReader(direccion_recursos + @"\default_descripcion.txt");//LECTURA DE INFORMACION

            string texto_etiqueta = "En Caso que no Cumpla Ninguna Condicion";

            string img_form2 = (direccion_recursos + @"\choice.png");

            Form2 miforma = new Form2(leer.ReadToEnd(), texto_etiqueta, img_form2); //PARAMETROS UTILIZADOS EN EL FORM2 PARAMETRO1, PAR2,PAR3 ...

            miforma.Ruta_Imagen_Display = (direccion_recursos + @"\default_ejemplo.png"); //OTRA FORMA DE MANDAR INFORMACION A FORM 2 ATRAVEZ DE PROPIEDADES

            display_sintaxis.Image = null;
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;

            var a = direccion_recursos + @"\sintaxis_default.png";
            Console.WriteLine(a);
            display_sintaxis.Image = Image.FromFile(a);
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;

            miforma.Show();
        }

        private void btn_continue_Click(object sender, EventArgs e)
        {
            //BOTON CONTINUE
            TextReader leer = new StreamReader(direccion_recursos + @"\continue_descripcion.txt");//LECTURA DE INFORMACION

            string texto_etiqueta = "Inicia una Nueva Iteración de la Continua";

            string img_form2 = (direccion_recursos + @"\continuo.png");

            Form2 miforma = new Form2(leer.ReadToEnd(), texto_etiqueta, img_form2); //PARAMETROS UTILIZADOS EN EL FORM2 PARAMETRO1, PAR2,PAR3 ...

            miforma.Ruta_Imagen_Display = (direccion_recursos + @"\continue_ejemplo.png"); //OTRA FORMA DE MANDAR INFORMACION A FORM 2 ATRAVEZ DE PROPIEDADES

            display_sintaxis.Image = null;
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;

            var a = direccion_recursos + @"\sintaxis_continue.png";
            Console.WriteLine(a);
            display_sintaxis.Image = Image.FromFile(a);
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;

            miforma.Show();

        }

        private void btn_funcion_Click(object sender, EventArgs e)
        {
            //BOTON FUNCION
            TextReader leer = new StreamReader(direccion_recursos + @"\funcion_descripcion.txt");//LECTURA DE INFORMACION

            string texto_etiqueta = "Crear una funcion Local";

            string img_form2 = (direccion_recursos + @"\rubik.png");

            Form2 miforma = new Form2(leer.ReadToEnd(), texto_etiqueta, img_form2); //PARAMETROS UTILIZADOS EN EL FORM2 PARAMETRO1, PAR2,PAR3 ...

            miforma.Ruta_Imagen_Display = (direccion_recursos + @"\funcion_ejemplo.png"); //OTRA FORMA DE MANDAR INFORMACION A FORM 2 ATRAVEZ DE PROPIEDADES

            display_sintaxis.Image = null;
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;

            var a = direccion_recursos + @"\sintaxis_funcion.png";
            Console.WriteLine(a);
            display_sintaxis.Image = Image.FromFile(a);
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;

            miforma.Show();

        }

        private void btn_sobrecarga_metodo_Click(object sender, EventArgs e)
        {
            //BOTON SOBRECARGA METODO
            TextReader leer = new StreamReader(direccion_recursos + @"\sobrecarga_descripcion.txt");//LECTURA DE INFORMACION

            string texto_etiqueta = "Sobrecargar una Funcion";

            string img_form2 = (direccion_recursos + @"\rubik.png");

            Form2 miforma = new Form2(leer.ReadToEnd(), texto_etiqueta, img_form2); //PARAMETROS UTILIZADOS EN EL FORM2 PARAMETRO1, PAR2,PAR3 ...

            miforma.Ruta_Imagen_Display = (direccion_recursos + @"\sobrecarga_ejemplo.png"); //OTRA FORMA DE MANDAR INFORMACION A FORM 2 ATRAVEZ DE PROPIEDADES

            display_sintaxis.Image = null;
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;

            var a = direccion_recursos + @"\sintaxis_sobrecarga.png";
            Console.WriteLine(a);
            display_sintaxis.Image = Image.FromFile(a);
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;

            miforma.Show();
        }

        private void btn_create_array_Click(object sender, EventArgs e)
        {
            //BOTON CREATE ARRAY

            TextReader leer = new StreamReader(direccion_recursos + @"\create_descripcion.txt");//LECTURA DE INFORMACION

            string texto_etiqueta = "Crear un Vector o Matriz";

            string img_form2 = (direccion_recursos + @"\arreglar.png");

            Form2 miforma = new Form2(leer.ReadToEnd(), texto_etiqueta, img_form2); //PARAMETROS UTILIZADOS EN EL FORM2 PARAMETRO1, PAR2,PAR3 ...

            miforma.Ruta_Imagen_Display = (direccion_recursos + @"\create_ejemplo.png"); //OTRA FORMA DE MANDAR INFORMACION A FORM 2 ATRAVEZ DE PROPIEDADES

            display_sintaxis.Image = null;
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;

            var a = direccion_recursos + @"\sintaxis_create.png";
            Console.WriteLine(a);
            display_sintaxis.Image = Image.FromFile(a);
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;

            miforma.Show();
        }

        private void btn_acces_elem_of_array_Click(object sender, EventArgs e)
        {
            //BOTON ACCES ELEMENT OF ARRAY

            TextReader leer = new StreamReader(direccion_recursos + @"\acces_descripcion.txt");//LECTURA DE INFORMACION

            string texto_etiqueta = "Acceder a un Valor de Un Vector";

            string img_form2 = (direccion_recursos + @"\arreglar.png");

            Form2 miforma = new Form2(leer.ReadToEnd(), texto_etiqueta, img_form2); //PARAMETROS UTILIZADOS EN EL FORM2 PARAMETRO1, PAR2,PAR3 ...

            miforma.Ruta_Imagen_Display = (direccion_recursos + @"\acces_ejemplo.png"); //OTRA FORMA DE MANDAR INFORMACION A FORM 2 ATRAVEZ DE PROPIEDADES

            display_sintaxis.Image = null;
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;

            var a = direccion_recursos + @"\sintaxis_acces.png";
            Console.WriteLine(a);
            display_sintaxis.Image = Image.FromFile(a);
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;

            miforma.Show();
            
        }

        private void btn_change_array_ele_Click(object sender, EventArgs e)
        {
            //BOTON CHANGE ARRAY ELEMENT

            TextReader leer = new StreamReader(direccion_recursos + @"\change_descripcion.txt");//LECTURA DE INFORMACION

            string texto_etiqueta = "Cambiar un Valor de Un Vector";

            string img_form2 = (direccion_recursos + @"\arreglar.png");

            Form2 miforma = new Form2(leer.ReadToEnd(), texto_etiqueta, img_form2); //PARAMETROS UTILIZADOS EN EL FORM2 PARAMETRO1, PAR2,PAR3 ...

            miforma.Ruta_Imagen_Display = (direccion_recursos + @"\change_ejemplo.png"); //OTRA FORMA DE MANDAR INFORMACION A FORM 2 ATRAVEZ DE PROPIEDADES

            display_sintaxis.Image = null;
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;

            var a = direccion_recursos + @"\sintaxis_change.png";
            Console.WriteLine(a);
            display_sintaxis.Image = Image.FromFile(a);
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;

            miforma.Show();
        }

        private void btn_array_length_Click(object sender, EventArgs e)
        {
            //BOTON ARRAY LENGHT

            TextReader leer = new StreamReader(direccion_recursos + @"\array_lenght_descripcion.txt");//LECTURA DE INFORMACION

            string texto_etiqueta = "Obtener el Numero de Indices 'largo' de Un Vector";

            string img_form2 = (direccion_recursos + @"\arreglar.png");

            Form2 miforma = new Form2(leer.ReadToEnd(), texto_etiqueta, img_form2); //PARAMETROS UTILIZADOS EN EL FORM2 PARAMETRO1, PAR2,PAR3 ...

            miforma.Ruta_Imagen_Display = (direccion_recursos + @"\array_lenght_ejemplo.png"); //OTRA FORMA DE MANDAR INFORMACION A FORM 2 ATRAVEZ DE PROPIEDADES

            display_sintaxis.Image = null;
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;

            var a = direccion_recursos + @"\sintaxis_array_lenght.png";
            Console.WriteLine(a);
            display_sintaxis.Image = Image.FromFile(a);
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;

            miforma.Show();
        }

        private void btn_loop_array_Click(object sender, EventArgs e)
        {
            //BOTON LOOP ARRAY

            TextReader leer = new StreamReader(direccion_recursos + @"\array_loop_descripcion.txt");//LECTURA DE INFORMACION

            string texto_etiqueta = "Como se Comportan Los Bucles en un Vector";

            string img_form2 = (direccion_recursos + @"\arreglar.png");

            Form2 miforma = new Form2(leer.ReadToEnd(), texto_etiqueta, img_form2); //PARAMETROS UTILIZADOS EN EL FORM2 PARAMETRO1, PAR2,PAR3 ...

            miforma.Ruta_Imagen_Display = (direccion_recursos + @"\array_loop_ejemplo.png"); //OTRA FORMA DE MANDAR INFORMACION A FORM 2 ATRAVEZ DE PROPIEDADES

            display_sintaxis.Image = null;
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;

            var a = direccion_recursos + @"\sintaxis_array_loop.png";
            Console.WriteLine(a);
            display_sintaxis.Image = Image.FromFile(a);
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;

            miforma.Show();
        }

        private void btn_array_sort_Click(object sender, EventArgs e)
        {
            //BOTON ARRAY SORT

            TextReader leer = new StreamReader(direccion_recursos + @"\array_sort_descripcion.txt");//LECTURA DE INFORMACION

            string texto_etiqueta = "Ordena los Valores que Estan Dentro de un Vector";

            string img_form2 = (direccion_recursos + @"\arreglar.png");

            Form2 miforma = new Form2(leer.ReadToEnd(), texto_etiqueta, img_form2); //PARAMETROS UTILIZADOS EN EL FORM2 PARAMETRO1, PAR2,PAR3 ...

            miforma.Ruta_Imagen_Display = (direccion_recursos + @"\array_sort_ejemplo.png"); //OTRA FORMA DE MANDAR INFORMACION A FORM 2 ATRAVEZ DE PROPIEDADES

            display_sintaxis.Image = null;
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;

            var a = direccion_recursos + @"\sintaxis_array_sort.png";
            Console.WriteLine(a);
            display_sintaxis.Image = Image.FromFile(a);
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;

            miforma.Show();
        }

        private void btn_copy_Click(object sender, EventArgs e)
        {
            //BOTON COPY

            TextReader leer = new StreamReader(direccion_recursos + @"\copy_descripcion.txt");//LECTURA DE INFORMACION

            string texto_etiqueta = "Crear un Archivo";

            string img_form2 = (direccion_recursos + @"\carpeta.png");

            Form2 miforma = new Form2(leer.ReadToEnd(), texto_etiqueta, img_form2); //PARAMETROS UTILIZADOS EN EL FORM2 PARAMETRO1, PAR2,PAR3 ...

            miforma.Ruta_Imagen_Display = (direccion_recursos + @"\copy_ejemplo.png"); //OTRA FORMA DE MANDAR INFORMACION A FORM 2 ATRAVEZ DE PROPIEDADES

            display_sintaxis.Image = null;
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;

            var a = direccion_recursos + @"\sintaxis_copy.png";
            Console.WriteLine(a);
            display_sintaxis.Image = Image.FromFile(a);
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;

            miforma.Show();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            //BOTON CREATE

            TextReader leer = new StreamReader(direccion_recursos + @"\create_file_descripcion.txt");//LECTURA DE INFORMACION

            string texto_etiqueta = "Copiar un archivo";

            string img_form2 = (direccion_recursos + @"\arreglar.png");

            Form2 miforma = new Form2(leer.ReadToEnd(), texto_etiqueta, img_form2); //PARAMETROS UTILIZADOS EN EL FORM2 PARAMETRO1, PAR2,PAR3 ...

            miforma.Ruta_Imagen_Display = (direccion_recursos + @"\create_file_ejemplo.png"); //OTRA FORMA DE MANDAR INFORMACION A FORM 2 ATRAVEZ DE PROPIEDADES

            display_sintaxis.Image = null;
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;

            var a = direccion_recursos + @"\sintaxis_create_file.png";
            Console.WriteLine(a);
            display_sintaxis.Image = Image.FromFile(a);
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;

            miforma.Show();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            //BOTON DELETE

            TextReader leer = new StreamReader(direccion_recursos + @"\delete_descripcion.txt");//LECTURA DE INFORMACION

            string texto_etiqueta = "Eliminar un archivo";

            string img_form2 = (direccion_recursos + @"\arreglar.png");

            Form2 miforma = new Form2(leer.ReadToEnd(), texto_etiqueta, img_form2); //PARAMETROS UTILIZADOS EN EL FORM2 PARAMETRO1, PAR2,PAR3 ...

            miforma.Ruta_Imagen_Display = (direccion_recursos + @"\delete_ejemplo.png"); //OTRA FORMA DE MANDAR INFORMACION A FORM 2 ATRAVEZ DE PROPIEDADES

            display_sintaxis.Image = null;
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;

            var a = direccion_recursos + @"\sintaxis_delete.png";
            Console.WriteLine(a);
            display_sintaxis.Image = Image.FromFile(a);
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;

            miforma.Show();
        }

        private void btn_exists_Click(object sender, EventArgs e)
        {
            //BOTON EXITS

            TextReader leer = new StreamReader(direccion_recursos + @"\exits_descripcion.txt");//LECTURA DE INFORMACION

            string texto_etiqueta = "Pregunta Por un archivo";

            string img_form2 = (direccion_recursos + @"\arreglar.png");

            Form2 miforma = new Form2(leer.ReadToEnd(), texto_etiqueta, img_form2); //PARAMETROS UTILIZADOS EN EL FORM2 PARAMETRO1, PAR2,PAR3 ...

            miforma.Ruta_Imagen_Display = (direccion_recursos + @"\exits_ejemplo.png"); //OTRA FORMA DE MANDAR INFORMACION A FORM 2 ATRAVEZ DE PROPIEDADES

            display_sintaxis.Image = null;
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;

            var a = direccion_recursos + @"\sintaxis_exits.png";
            Console.WriteLine(a);
            display_sintaxis.Image = Image.FromFile(a);
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;

            miforma.Show();        
        }

        private void btn_replace_Click(object sender, EventArgs e)
        {
            //BOTON REPLACE

            TextReader leer = new StreamReader(direccion_recursos + @"\replace_descripcion.txt");//LECTURA DE INFORMACION

            string texto_etiqueta = "Remplazar un archivo";

            string img_form2 = (direccion_recursos + @"\arreglar.png");

            Form2 miforma = new Form2(leer.ReadToEnd(), texto_etiqueta, img_form2); //PARAMETROS UTILIZADOS EN EL FORM2 PARAMETRO1, PAR2,PAR3 ...

            miforma.Ruta_Imagen_Display = (direccion_recursos + @"\replace_ejemplo.png"); //OTRA FORMA DE MANDAR INFORMACION A FORM 2 ATRAVEZ DE PROPIEDADES

            display_sintaxis.Image = null;
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;

            var a = direccion_recursos + @"\sintaxis_replace.png";
            Console.WriteLine(a);
            display_sintaxis.Image = Image.FromFile(a);
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;

            miforma.Show();
        }

        private void btn_writealltext_Click(object sender, EventArgs e)
        {
            //BOTON WRITEALLTEXT

            TextReader leer = new StreamReader(direccion_recursos + @"\writealltext_descripcion.txt");//LECTURA DE INFORMACION

            string texto_etiqueta = "Escribe el Contenido en el Archivo";

            string img_form2 = (direccion_recursos + @"\arreglar.png");

            Form2 miforma = new Form2(leer.ReadToEnd(), texto_etiqueta, img_form2); //PARAMETROS UTILIZADOS EN EL FORM2 PARAMETRO1, PAR2,PAR3 ...

            miforma.Ruta_Imagen_Display = (direccion_recursos + @"\writealltext_ejemplo.png"); //OTRA FORMA DE MANDAR INFORMACION A FORM 2 ATRAVEZ DE PROPIEDADES

            display_sintaxis.Image = null;
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;

            var a = direccion_recursos + @"\sintaxis_writealltext.png";
            Console.WriteLine(a);
            display_sintaxis.Image = Image.FromFile(a);
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;

            miforma.Show();
        }

        private void btn_create_class_Click(object sender, EventArgs e)
        {
            //BOTON CREATE CLASS

            TextReader leer = new StreamReader(direccion_recursos + @"\create_class_descripcion.txt");//LECTURA DE INFORMACION

            string texto_etiqueta = "Crear una clase";

            string img_form2 = (direccion_recursos + @"\programacion.png");

            Form2 miforma = new Form2(leer.ReadToEnd(), texto_etiqueta, img_form2); //PARAMETROS UTILIZADOS EN EL FORM2 PARAMETRO1, PAR2,PAR3 ...

            miforma.Ruta_Imagen_Display = (direccion_recursos + @"\create_class_ejemplo.png"); //OTRA FORMA DE MANDAR INFORMACION A FORM 2 ATRAVEZ DE PROPIEDADES

            display_sintaxis.Image = null;
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;

            var a = direccion_recursos + @"\sintaxis_create_class.png";
            Console.WriteLine(a);
            display_sintaxis.Image = Image.FromFile(a);
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;

            miforma.Show();
        }

        private void btn_create_object_Click(object sender, EventArgs e)
        {
            //BOTON CREATE OBJECT

            TextReader leer = new StreamReader(direccion_recursos + @"\create_object_descripcion.txt");//LECTURA DE INFORMACION

            string texto_etiqueta = "Crear un objeto";

            string img_form2 = (direccion_recursos + @"\programacion.png");

            Form2 miforma = new Form2(leer.ReadToEnd(), texto_etiqueta, img_form2); //PARAMETROS UTILIZADOS EN EL FORM2 PARAMETRO1, PAR2,PAR3 ...

            miforma.Ruta_Imagen_Display = (direccion_recursos + @"\create_object_ejemplo.png"); //OTRA FORMA DE MANDAR INFORMACION A FORM 2 ATRAVEZ DE PROPIEDADES

            display_sintaxis.Image = null;
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;

            var a = direccion_recursos + @"\sintaxis_create_object.png";
            Console.WriteLine(a);
            display_sintaxis.Image = Image.FromFile(a);
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;

            miforma.Show();
        }

        private void btn_multiple_obj_Click(object sender, EventArgs e)
        {
            //BOTON MULTIPLE OBJECT

            TextReader leer = new StreamReader(direccion_recursos + @"\multiple_object_descripcion.txt");//LECTURA DE INFORMACION

            string texto_etiqueta = "Crear Muchos objeto";

            string img_form2 = (direccion_recursos + @"\programacion.png");

            Form2 miforma = new Form2(leer.ReadToEnd(), texto_etiqueta, img_form2); //PARAMETROS UTILIZADOS EN EL FORM2 PARAMETRO1, PAR2,PAR3 ...

            miforma.Ruta_Imagen_Display = (direccion_recursos + @"\multiple_object_ejemplo.png"); //OTRA FORMA DE MANDAR INFORMACION A FORM 2 ATRAVEZ DE PROPIEDADES

            display_sintaxis.Image = null;
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;

            var a = direccion_recursos + @"\sintaxis_multiple_object.png";
            Console.WriteLine(a);
            display_sintaxis.Image = Image.FromFile(a);
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;

            miforma.Show();
        }

        private void btn_field_Click(object sender, EventArgs e)
        {
            //BOTON FIELS 

            TextReader leer = new StreamReader(direccion_recursos + @"\field_descripcion.txt");//LECTURA DE INFORMACION

            string texto_etiqueta = "Crear un objeto";

            string img_form2 = (direccion_recursos + @"\programacion.png");

            Form2 miforma = new Form2(leer.ReadToEnd(), texto_etiqueta, img_form2); //PARAMETROS UTILIZADOS EN EL FORM2 PARAMETRO1, PAR2,PAR3 ...

            miforma.Ruta_Imagen_Display = (direccion_recursos + @"\field_ejemplo.png"); //OTRA FORMA DE MANDAR INFORMACION A FORM 2 ATRAVEZ DE PROPIEDADES

            display_sintaxis.Image = null;
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;

            var a = direccion_recursos + @"\sintaxis_field.png";
            Console.WriteLine(a);
            display_sintaxis.Image = Image.FromFile(a);
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;

            miforma.Show();
        }

        private void btn_obj_methods_Click(object sender, EventArgs e)
        {
            //BOTON OBJECT METHODS

            TextReader leer = new StreamReader(direccion_recursos + @"\object_methods_descripcion.txt");//LECTURA DE INFORMACION

            string texto_etiqueta = "Metodos de un Objeto";

            string img_form2 = (direccion_recursos + @"\programacion.png");

            Form2 miforma = new Form2(leer.ReadToEnd(), texto_etiqueta, img_form2); //PARAMETROS UTILIZADOS EN EL FORM2 PARAMETRO1, PAR2,PAR3 ...

            miforma.Ruta_Imagen_Display = (direccion_recursos + @"\object_methods_ejemplo.png"); //OTRA FORMA DE MANDAR INFORMACION A FORM 2 ATRAVEZ DE PROPIEDADES

            display_sintaxis.Image = null;
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;

            var a = direccion_recursos + @"\sintaxis_object_methods.png";
            Console.WriteLine(a);
            display_sintaxis.Image = Image.FromFile(a);
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;

            miforma.Show();
        }

        private void btn_constructors_Click(object sender, EventArgs e)
        {
            //BOTON CONSTRUCTOR

            TextReader leer = new StreamReader(direccion_recursos + @"\constructor_descripcion.txt");//LECTURA DE INFORMACION

            string texto_etiqueta = "Crear un Constructor";

            string img_form2 = (direccion_recursos + @"\programacion.png");

            Form2 miforma = new Form2(leer.ReadToEnd(), texto_etiqueta, img_form2); //PARAMETROS UTILIZADOS EN EL FORM2 PARAMETRO1, PAR2,PAR3 ...

            miforma.Ruta_Imagen_Display = (direccion_recursos + @"\constructor_ejemplo.png"); //OTRA FORMA DE MANDAR INFORMACION A FORM 2 ATRAVEZ DE PROPIEDADES

            display_sintaxis.Image = null;
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;

            var a = direccion_recursos + @"\sintaxis_constructor.png";
            Console.WriteLine(a);
            display_sintaxis.Image = Image.FromFile(a);
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;

            miforma.Show();
        }

        private void btn_acces_modifiers_Click(object sender, EventArgs e)
        {
            //BOTON ACCES MODIFIERS

            TextReader leer = new StreamReader(direccion_recursos + @"\modificador_descripcion.txt");//LECTURA DE INFORMACION

            string texto_etiqueta = "Modificador de Acceso";

            string img_form2 = (direccion_recursos + @"\programacion.png");

            Form2 miforma = new Form2(leer.ReadToEnd(), texto_etiqueta, img_form2); //PARAMETROS UTILIZADOS EN EL FORM2 PARAMETRO1, PAR2,PAR3 ...

            miforma.Ruta_Imagen_Display = (direccion_recursos + @"\modificador_ejemplo.png"); //OTRA FORMA DE MANDAR INFORMACION A FORM 2 ATRAVEZ DE PROPIEDADES

            display_sintaxis.Image = null;
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;

            var a = direccion_recursos + @"\sintaxis_modificador.png";
            Console.WriteLine(a);
            display_sintaxis.Image = Image.FromFile(a);
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;

            miforma.Show();
        }

        private void btn_properties_Click(object sender, EventArgs e)
        {
            //BOTON PROPERTIES

            TextReader leer = new StreamReader(direccion_recursos + @"\propiedades_descripcion.txt");//LECTURA DE INFORMACION

            string texto_etiqueta = "Propiedades";

            string img_form2 = (direccion_recursos + @"\programacion.png");

            Form2 miforma = new Form2(leer.ReadToEnd(), texto_etiqueta, img_form2); //PARAMETROS UTILIZADOS EN EL FORM2 PARAMETRO1, PAR2,PAR3 ...

            miforma.Ruta_Imagen_Display = (direccion_recursos + @"\Propiedades_ejemplo.png"); //OTRA FORMA DE MANDAR INFORMACION A FORM 2 ATRAVEZ DE PROPIEDADES

            display_sintaxis.Image = null;
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;

            var a = direccion_recursos + @"\sintaxis_Propiedades.png";
            Console.WriteLine(a);
            display_sintaxis.Image = Image.FromFile(a);
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;

            miforma.Show();
        }

        private void btn_inheritance_Click(object sender, EventArgs e)
        {
            //BOTON INHERITANCE
            TextReader leer = new StreamReader(direccion_recursos + @"\herencia_descripcion.txt");//LECTURA DE INFORMACION

            string texto_etiqueta = "Herencia  (clase derivada y base)";

            string img_form2 = (direccion_recursos + @"\programacion.png");

            Form2 miforma = new Form2(leer.ReadToEnd(), texto_etiqueta, img_form2); //PARAMETROS UTILIZADOS EN EL FORM2 PARAMETRO1, PAR2,PAR3 ...

            miforma.Ruta_Imagen_Display = (direccion_recursos + @"\herencia_ejemplo.png"); //OTRA FORMA DE MANDAR INFORMACION A FORM 2 ATRAVEZ DE PROPIEDADES

            display_sintaxis.Image = null;
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;

            var a = direccion_recursos + @"\sintaxis_herencia.png";
            Console.WriteLine(a);
            display_sintaxis.Image = Image.FromFile(a);
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;

            miforma.Show();
        }

        private void btn_poly_Click(object sender, EventArgs e)
        {
            //BOTON POLY

            TextReader leer = new StreamReader(direccion_recursos + @"\polimorfismo_descripcion.txt");//LECTURA DE INFORMACION

            string texto_etiqueta = "Muchas Formas";

            string img_form2 = (direccion_recursos + @"\programacion.png");

            Form2 miforma = new Form2(leer.ReadToEnd(), texto_etiqueta, img_form2); //PARAMETROS UTILIZADOS EN EL FORM2 PARAMETRO1, PAR2,PAR3 ...

            miforma.Ruta_Imagen_Display = (direccion_recursos + @"\polimorfismo_ejemplo.png"); //OTRA FORMA DE MANDAR INFORMACION A FORM 2 ATRAVEZ DE PROPIEDADES

            display_sintaxis.Image = null;
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;

            var a = direccion_recursos + @"\sintaxis_polimorfismo.png";
            Console.WriteLine(a);
            display_sintaxis.Image = Image.FromFile(a);
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;

            miforma.Show();
        }

        private void btn_abstrac_Click(object sender, EventArgs e)
        {
            //BOTON ABSTRAC

            TextReader leer = new StreamReader(direccion_recursos + @"\abstraccion_descripcion.txt");//LECTURA DE INFORMACION

            string texto_etiqueta = "Ocultar Ciertos Detalles y Mostrar Solo la Información Esencial";

            string img_form2 = (direccion_recursos + @"\programacion.png");

            Form2 miforma = new Form2(leer.ReadToEnd(), texto_etiqueta, img_form2); //PARAMETROS UTILIZADOS EN EL FORM2 PARAMETRO1, PAR2,PAR3 ...

            miforma.Ruta_Imagen_Display = (direccion_recursos + @"\abstraccion_ejemplo.png"); //OTRA FORMA DE MANDAR INFORMACION A FORM 2 ATRAVEZ DE PROPIEDADES

            display_sintaxis.Image = null;
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;

            var a = direccion_recursos + @"\sintaxis_abstraccion.png";
            Console.WriteLine(a);
            display_sintaxis.Image = Image.FromFile(a);
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;

            miforma.Show();
        }

        private void btn_interface_Click(object sender, EventArgs e)
        {
            //BOTON INTERFACE

            TextReader leer = new StreamReader(direccion_recursos + @"\inter_descripcion.txt");//LECTURA DE INFORMACION

            string texto_etiqueta = "Ocultar Ciertos Detalles y Mostrar Solo la Información Esencial";

            string img_form2 = (direccion_recursos + @"\programacion.png");

            Form2 miforma = new Form2(leer.ReadToEnd(), texto_etiqueta, img_form2); //PARAMETROS UTILIZADOS EN EL FORM2 PARAMETRO1, PAR2,PAR3 ...

            miforma.Ruta_Imagen_Display = (direccion_recursos + @"\inter_ejemplo.png"); //OTRA FORMA DE MANDAR INFORMACION A FORM 2 ATRAVEZ DE PROPIEDADES

            display_sintaxis.Image = null;
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;

            var a = direccion_recursos + @"\sintaxis_inter.png";
            Console.WriteLine(a);
            display_sintaxis.Image = Image.FromFile(a);
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;

            miforma.Show();
        }

        private void btn_enums_Click(object sender, EventArgs e)
        {
            //BOTON ENUMS

            TextReader leer = new StreamReader(direccion_recursos + @"\enum_descripcion.txt");//LECTURA DE INFORMACION

            string texto_etiqueta = "Representa un Grupo de Constantes";

            string img_form2 = (direccion_recursos + @"\programacion.png");

            Form2 miforma = new Form2(leer.ReadToEnd(), texto_etiqueta, img_form2); //PARAMETROS UTILIZADOS EN EL FORM2 PARAMETRO1, PAR2,PAR3 ...

            miforma.Ruta_Imagen_Display = (direccion_recursos + @"\enum_ejemplo.png"); //OTRA FORMA DE MANDAR INFORMACION A FORM 2 ATRAVEZ DE PROPIEDADES

            display_sintaxis.Image = null;
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;

            var a = direccion_recursos + @"\sintaxis_enum.png";
            Console.WriteLine(a);
            display_sintaxis.Image = Image.FromFile(a);
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;

            miforma.Show();
        }

        private void btn_event_Click(object sender, EventArgs e)
        {
            //BOTON EVENTS

            TextReader leer = new StreamReader(direccion_recursos + @"\event_descripcion.txt");//LECTURA DE INFORMACION

            string texto_etiqueta = "Eventos";

            string img_form2 = (direccion_recursos + @"\programacion.png");

            Form2 miforma = new Form2(leer.ReadToEnd(), texto_etiqueta, img_form2); //PARAMETROS UTILIZADOS EN EL FORM2 PARAMETRO1, PAR2,PAR3 ...

            miforma.Ruta_Imagen_Display = (direccion_recursos + @"\event_ejemplo.png"); //OTRA FORMA DE MANDAR INFORMACION A FORM 2 ATRAVEZ DE PROPIEDADES

            display_sintaxis.Image = null;
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;

            var a = direccion_recursos + @"\sintaxis_event.png";
            Console.WriteLine(a);
            display_sintaxis.Image = Image.FromFile(a);
            display_sintaxis.SizeMode = PictureBoxSizeMode.CenterImage;

            miforma.Show();
        }



        private void animacion_Tick(object sender, EventArgs e)//ANIMACION
        {
            conteo++;
            if(conteo == 4)
            {   
                var az = direccion_recursos + @"\liso.png";
                display_sintaxis.Image = Image.FromFile(az);
                animacion.Enabled = false;
            }
        }

        private void animacion2_Tick(object sender, EventArgs e)
        {

        }

       
    }
}
