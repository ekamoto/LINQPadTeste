<Query Kind="Program" />

void Main()
{
	var processador = new Processador();
	var nome = processador.Processa();
	Console.WriteLine(nome);
	
}

public class Processador{


	public string Processa()
	{
		string nome = "leandro";
		try
		{
		
			throw new Exception("Deu erro mano");
		}
		catch(Exception ex)
		{
			
		}
		
		return nome;
	}
}

// You can define other methods, fields, classes and namespaces here

