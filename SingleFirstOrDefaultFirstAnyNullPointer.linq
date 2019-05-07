<Query Kind="Program" />

void Main()
{
	IEnumerable<Pessoa> lista = new List<Pessoa>();
	
	//var single = lista.Single();
	//var first = lista.First();
	var singleOrDefault = lista.SingleOrDefault();
	var firstOrDefault = lista.FirstOrDefault();
	var any = lista.Any();
	
	if(firstOrDefault==null)
	{
		Console.WriteLine("Objeto é nulo");
	}
	
	Pessoa pessoa = new Pessoa();
	pessoa.TestePassarNull(null);
	
}

class Pessoa {
	public string nome{get;set;}
	
	public void TestePassarNull(int? numero)
	{
		Console.WriteLine("Chegou de boa");
	}
	
}

// Define other methods and classes here