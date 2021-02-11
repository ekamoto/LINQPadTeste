<Query Kind="Program" />

void Main()
{
	var listaPessoas = new List<Pessoa>	();
	listaPessoas.Add(new Pessoa{
		Codigo = 1
	});
	listaPessoas.Add(new Pessoa{
		Codigo = 2
	});
	listaPessoas.Add(new Pessoa{
		Codigo = 3
	});
	
	var listaPessoasDesejadas = new List<Pessoa>();
	
	int[] codigosDesejados = listaPessoasDesejadas.Select(f => f.Codigo).ToArray();
	
	var processador = new Processador();
	int[] codigos = {1, 14, 3};
	
	processador.Processa(listaPessoas, codigosDesejados);
	
	// É possível que em algum momento essa lista seja nula
	// e se passar null vai dar erro na hora de fazer o contains
	//processador.Processa(listaPessoas, null);
}

public class Pessoa
{

	public int Codigo{ get; set; }
	
	
}


public class Processador
{

	public void Processa(List<Pessoa> listaPessoa, int[] codigos)
	{
		
		var listaFiltrada = listaPessoa.Where(x => !codigos.Contains(x.Codigo));
		foreach(var item in listaFiltrada)
		{
			Console.WriteLine(item.Codigo);
		}
	}
}

