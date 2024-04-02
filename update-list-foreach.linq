<Query Kind="Program" />

void Main()
{
	var lista = new List<Teste>();
	lista.Add(new Teste("1"));
	lista.Add(new Teste("2"));
	lista.Add(new Teste("3"));
	
	foreach(var item in lista)
	{
		Console.WriteLine(item.nome);
	}
	
	lista.ForEach(p => p.nome = "opaa");

	foreach(var item in lista)
	{
		Console.WriteLine(item.nome);
	}
}

public class Teste{
	public string nome;
	
	public Teste(string nome){
		this.nome = nome;
	}
}