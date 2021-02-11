<Query Kind="Program" />

void Main()
{
	try {
	
		throw new System.ArgumentException("Parameter cannot be null", "original");
		
		Console.WriteLine("Esse código não é executado");
	} 
	catch(Exception ex)
	{
		
		try {
			Console.WriteLine("Erro1");
			throw new System.ArgumentException("Parameter cannot be null", "original");
		} 
		catch(Exception ex2)
		{
			Console.WriteLine("Erro2");
		}
	}
}
