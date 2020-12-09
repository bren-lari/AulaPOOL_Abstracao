using System;

namespace CSHARP_dev.Classes
{
    public class Boleto : Pagamento
    {
        private string codigoDeBarras;

        public string desconto;

        public string CodigoDeBarras{
            get{return codigoDeBarras = "000000000000000000";}
        }

        public void Registrar(string valor){
            this.codigoDeBarras = valor;

        }

       public string resposta;

       public string valorTotal = "500";

       public float Total(string valorTotal){
           return 0.12f;

       }

      
       }
}

