using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Academy.Test.Entities
{
    public class Vitto : ISpese
    {
        public double CalcolaSpese(Spese importo)
        {
            return importo.Importo * (70 / 100);
        }
    }
}
