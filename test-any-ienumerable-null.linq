<Query Kind="Program" />

void Main()
{
	List<Teste> lista = new List<Teste>();
	//lista.Add(new Teste(){ nome = "leandro"});
	//lista = lista.Where(x => x.nome=="").ToList();
	
	lista.OrderByDescending(t=>t.nome);
	lista = null;
	
	IEnumerable<Teste> teste = null;
	
	if(!teste.Any())
	{
	
	}
	
}

public class Teste {

	public string nome{ get; set; }
}

// Define other methods and classes here