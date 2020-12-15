﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projLista02
{

    class Program
    {

        static void Main(string[] args)
        {
            Menu m = new Menu();

            Console.WriteLine("Digite o número para qual você deseja: ");
            Console.WriteLine("0. SAIR ");
            Console.WriteLine("1. ADICIONAR CONTATO ");
            Console.WriteLine("2. PESQUISAR CONTATO ");
            Console.WriteLine("3. ALTERAR CONTATO ");
            Console.WriteLine("4. REMOVER CONTATO ");
            Console.WriteLine("5. LISTAR CONTATOS ");

            Convert.ToInt32(Console.ReadLine(),m.Res);

            if (m.Res == 0)
            {
                Close();
            }

            List<Pessoa> pessoas;
            pessoas = new List<Pessoa>();

            pessoas.Add(new Pessoa(Console.ReadLine(), Console.ReadLine(), Console.ReadLine()));

            listaPessoas(pessoas);

            pessoas.Insert(3, new Pessoa("Roberta", "Silva", "F"));

            listaPessoas(pessoas);

            // Remoção pelo valor
            Console.WriteLine(pessoas.Remove(new Pessoa("Antonio", "Santos")) ? "Removeu" : "Não encontrou");
            listaPessoas(pessoas);



            static void listaPessoas(List<Pessoa> lp)
            {
                Console.WriteLine("- Qtde: {0} -----------------------------", lp.Count);
                foreach (Pessoa p in lp)
                {
                    Console.WriteLine(p.ToString());
                }
                Console.WriteLine("---------------------------------------");
            }


        }
    }
}