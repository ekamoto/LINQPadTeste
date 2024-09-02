<Query Kind="Program" />

void Main()
{
	List<Pessoa> lista = new List<Pessoa>{
		new Pessoa { Nome="Leandro" },
		new Pessoa { Nome="Priscila" },
		new Pessoa { Nome="Marina" }
	};
	
	foreach(var pessoa in lista)
	{
		Console.WriteLine(pessoa.Nome);
	}
	
	List<Pessoa> listaParaRemover = new List<Pessoa>{
		new Pessoa { Nome="Leandro" }
	};
	
	var nomes = listaParaRemover.Select(x => x.Nome);
	
	var lista100Leandro = lista.Where(t => !nomes.Contains(t.Nome));
	
	Console.WriteLine("Saída");
	foreach(var pessoa in lista100Leandro)
	{
		Console.WriteLine(pessoa.Nome);
	}
	
}

public class Pessoa
{
	public string Nome {get;set;}
}