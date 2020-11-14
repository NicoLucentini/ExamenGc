using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenGlobalCitizen
{
    public class Camisas : Prenda
    {
        public bool tieneCuelloMao { get; internal set; }
        public bool esMangaCorta { get; internal set; }

        public Camisas(float precio, int stock,  bool esMangaCorta, bool tieneCuelloMao) : base(precio, stock )
        {
            this.esMangaCorta = esMangaCorta;
            this.tieneCuelloMao = tieneCuelloMao;
        }
       
        public override float Cotizar(bool esPremium)
        {
            float precioFinal = precio;

            if (esMangaCorta)
                precioFinal *= .9f;
            if (tieneCuelloMao)
                precioFinal *= 1.03f;
            
            return precioFinal * base.Cotizar(esPremium);
        }

        public override string ToString()
        {
            return "Camisa |" + (tieneCuelloMao ? " Cuello Mao" : "") + ( esMangaCorta ? " Manga Corta " : "Manga Larga");
        }
    }
}
