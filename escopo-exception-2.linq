<Query Kind="Program" />

void Main()
{
	var processador = new Processador();
	try
	{
		processador.Processa();
	}
	catch(Exception ex)
	{
		Console.WriteLine(ex.ToString());
	}
	
}

public class Processador
{

	public void Processa()
	{
	
		try{
			
			throw new ArgumentException("Opa deu erro");
		}
		catch(Exception ex)
		{
			
			Console.WriteLine(ex.ToString());
			//throw; isso aqui lança a exceção para cima, ou seja o código abaixo não é executado
		}
		Console.WriteLine("Final do método");
	}
}

// You can define other methods, fields, classes and namespaces here
