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
        public string Sobrenome
        {
            get { return sobrenome; }
            set { sobrenome = value; }
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
            saida += string.Format("{0}, {1}", PrimeiroNome, sobrenome);
            saida += String.Format("{0}-{1}-{2}", Telefone.Substring(0, 1), Telefone.Substring(2,4),Telefone.Substring(7,3));

            return saida;   
        }
    }
}
               

