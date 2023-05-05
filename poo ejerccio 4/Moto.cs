using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo_ejerccio_4
{
    class Moto : Vehiculo
    {
        char sidecar;
        public Moto(int id, string marca, string modelo, int km, decimal precio, int anio, char sidecar)
        {
            this.Id = id;
            this.Marca = marca;
            this.Modelo = modelo;
            this.Km = km;
            this.Precio = precio;
            this.Anio = anio;
            this.sidecar = sidecar;
        }

        public char Sidecar { get => sidecar; set => sidecar = value; }

        public override decimal Global()
        {
            if (sidecar == 's')
            {
                Precio += 50;
                return base.Global();
            }
            else
            {
                Console.WriteLine("No se ha añadido el Aribag el precio es {0}..", Precio);
                return Global();
            }
        }
    }
}
