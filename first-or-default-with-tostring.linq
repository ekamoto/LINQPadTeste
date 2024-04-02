<Query Kind="Program" />

void Main()
{
	IEnumerable<Teste> teste = new List<Teste>();
	
	teste.FirstOrDefault().ToString();
}

class Teste {

	public string Nome;
}

// Define other methods and classes here
