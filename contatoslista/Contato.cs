using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contatoslista
{
    internal class Contato
    {
        private string primeirosexo;
        private string sobrenome;
        private string telefone;

        public string PrimeiroNome
        {
            get { return primeirosexo; }
            set { primeirosexo = value; }
        }
        public string Telefone
        {
            get { return telefone; }
            set
            {
                if (value.Length == 11)

                    Telefone = value;
                else

                    Telefone = "00-00000-0000";
            }
        }
        //Método Construtor da Classe 

        public Contato()
        {
            PrimeiroNome = "José";
            sobrenome = "Carlos Libralon";
            Telefone = "6999-9290900-11";
        }
        //Sobrecarga do método construtor da classe 
        
        public Contato(string primeironome ,string sobrenome , string telefone)
        {
            PrimeiroNome= primeironome;
            Sobrenome = sobrenome;
            Telefone = telefone;    
        }

        public override string ToString()
        {
            string saida = String.Empty; 
        }
    }
}
               

