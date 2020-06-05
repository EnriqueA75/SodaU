using System;
using System.Collections.Generic;
using System.Text;

namespace SodaU.Modelos
{
    public class Comidas
    { 
    public int IdComida { get; set; }
    public string Nombre { get; set; }
    public string Descripcion { get; set; }
    public decimal Costo { get; set; }
    public string Foto { get; set; }
    public string IdCategoriaComida { get; set; }
    public string IdEstado { get; set; }

        public Comidas(int IdComida, string Nombre, string Descripcion, decimal Costo, string Foto, string IdCategoriaComida, string IdEstado)
    {
        this.IdComida = IdComida;
        this.Nombre = Nombre;
        this.Descripcion = Descripcion;
        this.Costo = Costo;
        this.Foto = Foto;
        this.IdCategoriaComida = IdCategoriaComida;
        this.IdEstado = IdEstado;
    }

 
    }
}
