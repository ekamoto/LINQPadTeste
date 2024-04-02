<Query Kind="Program" />

void Main()
{
	
	var pessoas = new List<Pessoa>();
	pessoas.Add(new Pessoa {
		Nome = "Leandro",
		ListaCompra = new List<Compra>{	new Compra{ Nome="produto 1", Valor=12},
										new Compra{ Nome="produto 2", Valor=26}
									  }
	});
	
	pessoas.Add(new Pessoa {
		Nome = "Priscila"
	});
	
	foreach(var pessoa in pessoas)
	{
		Console.WriteLine(pessoa.Nome);
		foreach(var compra in pessoa.ListaCompra)
		{
			Console.WriteLine(compra.Nome);
		}
	}
	
	
}

public class Compra {
	public string Nome{get;set;}
	public decimal Valor{get;set;}
}

public class Pessoa {

	public string Nome {get;set;}
	public Pessoa()
	{
		ListaCompra = new List<Compra>();
	}
	
	public List<Compra>ListaCompra { get; set; }
}

// You can define other methods, fields, classes and namespaces here