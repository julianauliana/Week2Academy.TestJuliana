// See https://aka.ms/new-console-template for more information
using Week2Academy.Test;
using Week2Academy.Test.Entities;
using Week2Academy.Test.Factory;
using Week2Academy.Test.Handler;

Console.WriteLine("--------Spese-----------");


//controllo se stampa il FILE

//VisualizzaElenco();

//void VisualizzaElenco()
//{
//    var listaSpese = RepositorySpeseFile.GetAll();
//    if (listaSpese == null)
//    {
//        Console.WriteLine("Lista Vuota");
//    }
//    else
//    {
//        Console.WriteLine("ecco l'elenco dei spesa ");
//        foreach (var s in listaSpese)
//        {
//            Console.WriteLine(s.ToString());
//        }
//    }
//}

//APPROVAZIONE

IHandler manager = new ManagerHandler();
IHandler operatinalManager = new OperationalManagerHandler();
IHandler ceo = new CEOHandler();

manager.SetNext(operatinalManager).SetNext(ceo);

var listaSpese = RepositorySpeseFile.GetAll();

foreach (var item in listaSpese)
{
    if (item.Importo >= 2500 || item.Importo == 0)
    {
        Console.WriteLine($"**Non approvata** {item}");
    }
    else
    {
        Console.WriteLine("Aprovata per: " + manager.Handle(item) + "\tCategoria:" + (item.Categoria));
    }
}

//RIMBORSO PER CATEGORIA 
foreach (var item in listaSpese)
{   
    
    FactorySpesa factory = new FactorySpesa();
    ISpese spesa = factory.CreateRimborso(item.Categoria);

    if(spesa != null)
    {

    }
    else
    {
        Console.WriteLine();
    }
    
}













string path = @"C:\Users\j.de.carvalho.uliana\Desktop\Academy\Week 2 - 02.05\exercicio\Week2Academy.TestJu\Week2Academy.Test\Spese_elaborate.txt";

using (StreamWriter sw1 = new StreamWriter(path))
{
    sw1.WriteLine();
}


