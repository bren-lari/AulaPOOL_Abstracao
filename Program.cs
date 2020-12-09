using System;
using CSHARP_dev.Classes;

namespace CSHARP_dev
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Boleto b = new Boleto();
            
           Console.WriteLine("--- Seção Pagamento ---");
           
               do{
                Console.WriteLine("\r\nForma de pagamento");
                Console.WriteLine("_________________________");
                Console.WriteLine("\r\nSelecione a forma de pagamento: ");
                Console.WriteLine("[1º-> Boleto");
                Console.WriteLine("[2º-> Cartão de débito]");
                Console.WriteLine("[3º -> Cartão de crédito]");
                Console.WriteLine("[0] Sair\r\n");
                b.resposta = Console.ReadLine();

                switch (b.resposta)
              {
                  case "1":
                 Console.ForegroundColor = ConsoleColor.DarkCyan;
                 Console.WriteLine($"--- Você receberá um desconto de 12%.\r\nO valor da compra sem o desconto foi de: {b.valorTotal}");                  
                 Console.ResetColor();
                 
                break;


               } 

            

    } while (b.resposta !="0");
}
}
}

