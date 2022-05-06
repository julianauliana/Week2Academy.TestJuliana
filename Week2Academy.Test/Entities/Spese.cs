using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Academy.Test
{
    public class Spese
    {
        public DateTime Data { get; set; }
        public string Categoria { get; set; }
        public string Descrizione { get; set; }
        public double Importo { get; set; }
        
        public Spese()
        {

        }
        public Spese(DateTime data, string categoria, string descrizione, double importo)
        {
            Data = data;
            Categoria = categoria;
            Descrizione = descrizione;
            Importo = importo;
        }
        
        public override string ToString()
        {
            return $"Data {Data.ToShortDateString()} \t categoria {Categoria} - Descrizione {Descrizione} \t Importo:{Importo}";
        }
    }
}
