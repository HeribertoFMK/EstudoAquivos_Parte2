using System;
using System.IO;


namespace arquivos1
{
    class Program
    {
        static void Main(string[] args)
        {
        //     //? Primeiro exercico onde le so um linha.
           string path = @"C:\csharp\texto1.txt";
           FileStream fs = null;
           StreamReader  sr = null;

           try
           {
               fs = new FileStream(path,FileMode.Open);
               sr = new StreamReader(fs);
               string line = sr.ReadLine();//! Ler so a primeira linha
               System.Console.WriteLine(line);

               }
           catch (IOException e)
           {
                System.Console.WriteLine("Houve um Erro!");
                System.Console.WriteLine(e.Message);
           }
           finally{

               if(fs != null) fs.Close();
               if(sr != null) sr.Close();

           }



        //    ? segundo exercico onde se le a lista dentro do arquivo.
           string path1 = @"C:\csharp\texto1.txt";
           FileStream fs1 = null;
           StreamReader sr1 = null;

           try
           {
               fs1 = new FileStream(path1,FileMode.Open);
               sr1 = new StreamReader(fs1);
              
               while(!sr1.EndOfStream){

                   string lines = sr1.ReadLine();
                   System.Console.WriteLine(lines);
               }



               
           }
           catch (IOException e)
           {
                System.Console.WriteLine("Houve um Erro!");
                System.Console.WriteLine(e.Message);
           }
           finally{

               if(fs1 != null) fs1.Close();
               if(sr1 != null) sr1.Close();

           }

           //? terceiro exercico, mais simplificado em ler a lista dentro do arquivo.

           string path2 = @"C:\csharp\texto1.txt";
           StreamReader  sr2 = null;
           
        try
        {
            sr2 = File.OpenText(path2);
            while(!sr2.EndOfStream){
                string line = sr2.ReadLine();
                System.Console.WriteLine(line);
            }
        }
        catch (IOException e)
        {
             System.Console.WriteLine("Houve um erro!");
             System.Console.WriteLine(e.Message);
        }
        finally{
            if(sr2 != null) sr2.Close();



        }
        }
        }
        }
        





        
    


