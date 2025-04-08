using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionNegocio.MainClasses
{
    internal class Cupones
    {
        public string nombre { get; set; }
        public int porcentaje { get; set; }



        public Cupones(string nombre, int porcentaje)
        {
            this.nombre = nombre;
            this.porcentaje = porcentaje;
        }


        public static int AplicarCupon(string nombre, int porcentaje, int total)
        {
            int descuento = (total * porcentaje) / 100;
            int precioFinal = total - descuento;
            MessageBox.Show($"Cupon aplicado: {nombre} el precio final es {precioFinal}");
            return precioFinal;
        }
    }
}
