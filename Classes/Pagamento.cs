using System;

namespace CSHARP_dev.Classes
{
    public abstract class Pagamento
    {
        private DateTime data;

        public string DateTime{
            get{return DateTime;}

        }

        protected float valor;

        public string Cancelar(){
            return "";
        }
    }
}