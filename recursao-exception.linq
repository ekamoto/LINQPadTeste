<Query Kind="Program" />

void Main()
{
	var processador = new Processador();
	
	var retorno = processador.Processa();
	Console.WriteLine(retorno);
	
	Console.WriteLine(processador.contador);
}


class Processador {

	public int contador = 0;
	
	public string Processa()
	{
		
		try {
		
			if(contador != 3)
				throw new System.ArgumentException("Parameter cannot be null", "original");
			else
				return "Processado";
				
		} catch (Exception e)
		{
			if(contador < 3)
			{
				contador++;
				return Processa();
			}
			
		}
		return "Falha ao processar";
	}
	
}

// You can define other methods, fields, classes and namespaces here
