<Query Kind="Program" />

void Main()
{
	List<Pessoa> lista = new List<Pessoa>();
	
	//AnyListaVazia
	var teste = lista.Any(t=>t.numero == 1);
	Console.WriteLine(teste);
}

class Pessoa{
	public int numero{get;set;}
}

// Define other methods and classes here
