using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace GestionNegocio.MainClasses
{
    public class Cliente
    {
        public int cedula { get; set; }
        public string nombre { get; set; }
        public string correo { get; set; }
        public int edad { get; set; }
        public string residencia { get; set; }
        public int xp { get; set; }
        public int nivel { get; set; }

        public Cliente(int _cedula, string _nombre, string _correo, int _edad, string _residencia, int _nivel, int _xp)
        {
            cedula = _cedula;
            nombre = _nombre;
            correo = _correo;
            edad = _edad;
            residencia = _residencia;
            nivel = _nivel;
            xp = _xp;
        }

        public int GetXp()
        {
            return xp;
        }

        public int GetNivel()
        {
            return nivel;
        }

        public void SetXp(int _xp)
        {
            xp = _xp;
        }

        public void SetNivel(int _nivel)
        {
            nivel = _nivel;
        }

        public void SumarXp(int _xp)
        {
            xp += _xp;
            while (xp >= CalcularXPParaNivel(nivel))
            {
                xp -= CalcularXPParaNivel(nivel);
                SubirNivel();
            }
        }

        public void RegistrarCompra()
        {
            SumarXp(1);
        }

        private void SubirNivel()
        {
            nivel++;
        }

        // Fórmula escalable para XP requerida
        public int CalcularXPParaNivel(int _nivel)
        {
            return _nivel * 5; 
        }

        public int CalcularXPRestante()
        {
            return CalcularXPParaNivel(nivel) - xp;
        }

        public int GetXpRestante()
        {
            return CalcularXPRestante();
        }
    }

}
