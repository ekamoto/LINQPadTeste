<Query Kind="Program" />

void Main()
{
	var processador = new Processador();
	var regra1 = new Regra1();
	regra1.Valor = 410;
	
	var regra2 = new Regra2();
	regra2.Nome="leandro";
	regra1.ProximaRegra = regra2;
	
	processador.Processa(regra1);
}

public interface Regras
{
	public void Processa();
	public Regras ProximaRegra{ get; set; }
}

public class Regra1: Regras
{
	public int Valor{ get; set; }
	
	public Regras ProximaRegra{ get; set; }
	public void Processa()
	{
		if(Valor>10)	
			Console.WriteLine("Valor maior que 10");
			
		ProximaRegra?.Processa();
	}
}

public class Regra2: Regras
{
	public string Nome { get; set; }
	public Regras ProximaRegra{ get; set; }
	public void Processa()
	{
		if(Nome=="leandro")
			Console.WriteLine("O nome é Leandro");
			
		ProximaRegra?.Processa();
	}
}

public class Processador
{
	public void Processa(Regras regras)
	{
		regras.Processa();
	}
}
