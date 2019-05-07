<Query Kind="Program" />

void Main()
{
	// No linqPad não cai no finally testar essa rotina no visualStudio
	try {
	
		List<string> lista = new List<String>();
		var teste = lista.Single();
		
	}  finally {
		Console.WriteLine("teste");
	}
}

// Define other methods and classes here
