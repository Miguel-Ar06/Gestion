using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionNegocio.MainClasses
{
    public class Cliente
    {
        private long Cedula;
        public long cedula 
        {
            get { return Cedula; }
            set { Cedula = value; }
        }

        private string Nombre;
        public string nombre 
        {
            get { return Nombre; }
            set { Nombre = value; }
        }

        private string Correo;
        public string correo 
        {
            get { return Correo; }
            set { Correo = value; }
        }

        private int Edad;
        public int edad 
        {
            get { return Edad; }
            set { Edad = value; }
        }

        private string Residencia;
        public string residencia 
        {
            get { return Residencia; }
            set { Residencia = value; }
        }
        
        private string Contrasena;
        public string contrasena
        {
            get { return Contrasena; }
            set { Contrasena = value; }
        }

        public Cliente(long _cedula, string _nombre, string _correo, int _edad, string _residencia, string _contrasena)
        {
            this.Cedula = _cedula;
            this.Nombre = _nombre;
            this.Correo = _correo;
            this.Edad = _edad;
            this.Residencia = _residencia;
            this.Contrasena = _contrasena;
        }
    }
}
