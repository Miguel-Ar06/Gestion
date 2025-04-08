using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionNegocio.MainClasses
{
    public class Producto
    {
        private int Id;
        public int id 
        {
            get { return Id; }
            set { Id = value; }
        }
        private string Nombre;
        public string nombre 
        {  
            get { return Nombre; }
            set { Nombre = value; }
        }
        private decimal Precio;
        public decimal precio 
        { 
            get { return Precio; }
            set { Precio = value; }
        }
        private string? Descripcion;
        public string? descripcion 
        {
            get { return Descripcion; }
            set { Descripcion = value; }
        }
        private int Cantidad;
        public int cantidad 
        { 
            get { return Cantidad; }
            set { Cantidad = value; }
        }

        // constructor
        public Producto(int _id, string _nombre, decimal _precio, string? _descripcion, int _cantidad )
        {
            this.id = _id;
            this.nombre = _nombre;
            this.precio = _precio;
            this.descripcion = _descripcion;
            this.cantidad = _cantidad;
        }
    }
}
