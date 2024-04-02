<Query Kind="Program" />

void Main()
{
	var teste = new Teste();
	
	Console.WriteLine("Inicio");
	
	teste.testeException();
	
	Console.WriteLine("Fim");
}

public class Teste {

	public void testeException()
	{
		throw new System.ArgumentException("Mensagem ", " -------");
	}
}

// Define other methods and classes here
