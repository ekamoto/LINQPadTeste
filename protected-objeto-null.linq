<Query Kind="Program" />

void Main()
{
	
	Pessoa p = null;
	Console.WriteLine(p?.Nome);
}

public class Pessoa {

	public string Nome { get; set; }
}