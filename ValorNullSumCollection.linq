<Query Kind="Program" />

void Main()
{
	var lista = new List<Teste>();
	
	lista.Add(new Teste(){valor = null});
	lista.Add(new Teste(){valor = null});
	lista.Add(new Teste(){valor = null});
	lista.Add(new Teste());
	
	decimal valor2 = lista.Sum(t=>t.valor).Value;
	
	Console.WriteLine(valor2);
	
	decimal? valor=null;
	Console.WriteLine(valor.GetValueOrDefault());
}

// Define other methods and classes here
public class Teste {
	
	public decimal? valor{get;set;}
}
