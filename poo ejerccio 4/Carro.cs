using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo_ejerccio_4
{
    class Carro:Vehiculo
    {
        char airbag;

      
        public Carro(int id, string marca, string modelo, int km, decimal precio, int anio,char airbag)
        {
            this.Id = id;
            this.Marca = marca;
            this.Modelo = modelo;
            this.Km = km;
            this.Precio = precio;
            this.Anio = anio;
            this.airbag = airbag;
        }

        public char Airbag { get => airbag; set => airbag = value; }

        public override decimal Global()
        {
            if (airbag == 's' )
            {
                this.Precio += 250;
                return base.Global();
            }
            else
            {
                Console.WriteLine("No se ha añadido el Aribag el precio es {0}..",Precio);
                return Global();
            }
        }
    }

    
}
