using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionNegocio.UIclasses;

namespace GestionNegocio.MainClasses
{
    public class Negocio
    {
        private string Nombre;
        public string nombre
        {
            get { return Nombre; }
            set { Nombre = value; }
        }
        //private int fundacion;
        //private string tipo;
        //private string rif;
        //private bool censado;
        //private bool sancionado;
        //private bool privado;
        private PaletaDeColor ColoresPrograma;
        public PaletaDeColor coloresPrograma
        {
            get { return ColoresPrograma; }
            set { ColoresPrograma = value; }
        }
        private string Credencial;
        public string credencial
        {
            get { return Credencial; }
            set { Credencial = value; }
        }


        // constructor
        public Negocio(string nombre, PaletaDeColor paleta, string credencial)
        {
            this.Nombre = nombre;
            this.ColoresPrograma = paleta;
            this.Credencial = credencial;
        }

        // getters
        public string GetNombre()
        {
            return nombre;
        }
        /*
        public int GetFundacion()
        {
            return fundacion;
        }
        public string GetTipo()
        {
            return tipo;
        }
        public string GetRif()
        {
            return rif;
        }
        public bool EstaCensado()
        {
            return censado;
        }
        public bool EsPrivado()
        {
            return privado;
        }
        public bool EstaSancionado()
        {
            return sancionado;
        }

        // setters
        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public void SetFundacion(int fundacion)
        {
            this.fundacion = fundacion;
        }
        public void SetTipo(string tipo)
        {
            this.tipo = tipo;
        }
        public void SetRif(string rif)
        {
            this.rif = rif;
        }
        public void SetCensado(bool _censado)
        {
            this.censado = _censado;
        }
        public void SetPrivado(bool _privado)
        {
            this.privado = _privado;
        }
        public void SetSancionado(bool _sancionado)
        {
            this.sancionado = _sancionado;
        }
        */
    }
}
