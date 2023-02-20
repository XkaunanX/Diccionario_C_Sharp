using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diccionario_C_sharp
{
    class Class1
    {
        public string _imagen_sintaxis;
        public string _imagen_ejemplo;
        public string _imagen_explicacion;

        public Class1(string imagen_sintaxis, string imagen_ejemplo, string imagen_explicacion)
        {
            this._imagen_sintaxis = imagen_sintaxis;
            this._imagen_ejemplo = imagen_ejemplo;
            this._imagen_explicacion = imagen_explicacion;
        }
        public string imagen_sintaxis { get => _imagen_sintaxis; set => _imagen_sintaxis = value; }
        public string imagen_ejemplo { get => _imagen_ejemplo; set => _imagen_ejemplo = value; }
        public string imagen_explicacion { get => _imagen_explicacion; set => _imagen_explicacion = value; }
    }
}

