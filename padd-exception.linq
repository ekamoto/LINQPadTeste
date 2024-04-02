<Query Kind="Program" />

void Main()
{
	var processo1 = new Processo1();
	try
	{
		processo1.Processa1();
	} 
	catch (Exception ex)
	{
		Console.WriteLine(ex.ToString());	
	}
	
}


class Processo1 
{
	public void Processa1()
	{
		try
		{
			var processo2 = new Processo2();
			processo2.Processa2();
		}
		catch(Exception ex)
		{
			Console.WriteLine("Classe1");
			Console.WriteLine(ex);
		}
	}
}

class Processo2
{
	public void Processa2()
	{
		try
		{
			var processo3 = new Processo3();
			processo3.Processa3();
		}
		catch(Exception ex)
		{
			Console.WriteLine("Classe2");
			throw;
		}
	}
}

class Processo3
{
	public void Processa3()
	{
		try
		{
			throw new Exception("Deu erro no processo 3 mano");
		}
		catch(Exception ex)
		{
			Console.WriteLine("Classe3");
			throw;
		}
		Console.WriteLine("Isso aqui nunca é executado");
	}
}

// You can define other methods, fields, classes and namespaces here
