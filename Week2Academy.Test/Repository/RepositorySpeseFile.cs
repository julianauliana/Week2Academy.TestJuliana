using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Week2Academy.Test
{
    public class RepositorySpeseFile
    {
        static string path = @"C:\Users\j.de.carvalho.uliana\Desktop\Academy\Week 2 - 02.05\exercicio\Week2Academy.TestJu\Week2Academy.Test\Repository\spese.txt";
       
        //public bool Aggiungi(Spese item)
        //{
        //    using (StreamWriter sw = new StreamWriter(path, true))
        //    {
        //        sw.WriteLine($"{item.Data},{item.Categoria},{item.Descrizione},{item.Importo}");
        //    }
        //    return true;
        //}

        public static List<Spese> GetAll()
        {
            List<Spese> listaSpese = new List<Spese>();
            using (StreamReader sw = new StreamReader(path))
            {                
                string contenutoFile = sw.ReadToEnd();

                if (string.IsNullOrEmpty(contenutoFile))
                {
                    return new List<Spese>();
                }
                else
                {
                    var righeDelFile = contenutoFile.Split("\r\n");
                    for (int i = 0; i < righeDelFile.Length; i++)
                    {
                        var campiDellaRiga = righeDelFile[i].Split(",");
                        Spese s = new Spese();
                        s.Data = DateTime.Parse((campiDellaRiga[0]));
                        s.Categoria = campiDellaRiga[1];
                        s.Descrizione = campiDellaRiga[2];
                        s.Importo = double.Parse(campiDellaRiga[3]);
                        listaSpese.Add(s);
                    }
                }
                return listaSpese;
            }
        }
    }
}
