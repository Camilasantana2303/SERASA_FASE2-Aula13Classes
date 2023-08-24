
using Fase2_Aula13Classes;
using System.ComponentModel.DataAnnotations;

Console.WriteLine("Hello, World!");

Pessoa camila= new Pessoa("Camila", 19, "Rua rio Paranapanema","São Carlos");
Pessoa conrado = new Pessoa("Conrado",27,"Rua epsicopal", "São carlos");
Pessoa mike = new Pessoa("Mike", 22, "Rua Xl", "São carlos");
Pessoa natan = new Pessoa("Natan", 23, "Rua wl", "São Carlos");


List<Pessoa> pessoas= new List<Pessoa>();


pessoas.Add(camila);
pessoas.Add(conrado);
pessoas.Add(mike);
pessoas.Add(natan);

for(int i = 0;i < pessoas.Count; i++)
{

    pessoas[i].mostra();
    //Console.WriteLine(pessoas[i]);
}


camila.mostra();
conrado.mostra();
mike.mostra();
natan.mostra();

Console.ReadKey();
