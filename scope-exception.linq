<Query Kind="Program" />

void Main()
{
	try
	{
		var processador = new Processador();
		processador.Processa();
		
	}
	catch(Exception ex)
	{
		Console.WriteLine(ex);
	}
	
	Console.WriteLine("Chegou até aqui mano");
}


class Processador
{
	public void Processa()
	{
		throw new Exception("Deu erro mano");
		
		Console.WriteLine("A exception interrompe o fluxo de execução do código dentro do escopo. Ou seja essa parte não é executada");
	}
}

// You can define other methods, fields, classes and namespaces here
