<Query Kind="Program" />

void Main()
{
	List<Teste> lista = new List<Teste>();
	List<int> ordem = new List<int>();
	ordem.Add(1);
	ordem.Add(2);
	ordem.Add(3);
	
	lista.Add(new Teste(){
	//	numero = 2,
		nome= "Leandro",
		ordem = ordem
	});
	var l = lista.LastOrDefault();
	Console.WriteLine(l);
	
	if(l != null && l.numero.HasValue)
		Console.WriteLine(l.numero.GetValueOrDefault());
	else
		Console.WriteLine("Valor Nulo");
	
	// short? x; // Dessa forma o GetValueOrDefault dá erro, short nullable é diferente de short nullable do objeto propriedade
	// Console.WriteLine(x.GetValueOrDefault());
	
	Console.WriteLine(l.numero.GetValueOrDefault());
}

class Teste{
	public short? numero;
	public string nome;
	public List<int> ordem;
}
// Define other methods and classes here
