using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week2Academy.Test.Entities;

namespace Week2Academy.Test.Factory
{
    public class FactorySpesa
    {
        public ISpese CreateRimborso(string categoria)
        {
            ISpese spese = null;
            if (categoria == "Viaggio")
                return new Viaggio();
            if (categoria == "Alloggio")
                return new Alloggio();
            if (categoria == "Vitto")
                return new Vitto();
            else
                return new Altro();

        }
       
    }
}
