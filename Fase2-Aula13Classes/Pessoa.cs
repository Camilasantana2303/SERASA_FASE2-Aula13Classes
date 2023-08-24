using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Fase2_Aula13Classes
{
    internal class Pessoa
    {

        public string nome;
        public int idade;
        public string rua;
        public string cidade;

        //construtor

        public Pessoa(string nome,int idade, string rua, string cidade)
        {
            this.nome = nome;
            this.idade = idade;
            this.rua = rua;
            this.cidade = cidade;
            Console.WriteLine("Salve");
            
        }

        public void mostra()
        {
            Console.WriteLine($"Meu nome é {nome}, tenho {idade} anos e moro na {rua} na cidade de {cidade}");
        }
    }
}
