using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projLista02
{
    class Menu
    {
        
       private int res;

        public int Res { get => res; set => res = value; }
    }

    public int adicionaContato()
    {
        Pessoa.Add(new Pessoa(Console.ReadLine(), Console.ReadLine(), Console.ReadLine()));
    }
}
