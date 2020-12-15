using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projLista02
{
    class Pessoa
    {
        private string nome;
        private string email;
        private string fone;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Telefone
        {
            get { return fone; }
            set { fone = value; }
        }

        public Pessoa(string nome, string email,string fone)
        {
            this.nome = nome;
            this.email = email;
            this.fone = fone;
        }

        public Pessoa()
            : this("", "","")
        {
        }

    
        
        public override string ToString()
        {
            return "Nome: " + nome + " - E-mail: " + email + "Telefone: " + fone ;
        }
        
        public override bool Equals(object obj)
        {
            return nome.Equals(((Pessoa)obj).nome);
        }
    }
}
