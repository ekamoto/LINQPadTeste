<Query Kind="Program" />

void Main()
{
	var tipo1 = new Tipo1(new Tipo2());
	var retorno = tipo1.Processa();
	Console.WriteLine(retorno);
}

public abstract class Tipo
{
	public Tipo OutroTipo { get; set; }
	public Tipo() { OutroTipo = null; }
	public Tipo(Tipo tipo) { OutroTipo = tipo; }
	
	public abstract string Processa();
	
	public string ProcessaProximo()
	{
		if(OutroTipo != null)
			return OutroTipo.Processa();
			
		return "";
	}
}

public class Tipo1: Tipo
{
	public Tipo1() { }
	public Tipo1(Tipo tipo): base(tipo) { }
	
	public override string Processa()
	{
		return "tipo1-"+ProcessaProximo();
	}
}	

public class Tipo2: Tipo
{
	public Tipo2() { }
	public Tipo2(Tipo tipo): base(tipo) { }
	
	public override string Processa()
	{
		return "tipo2-"+ProcessaProximo();
	}
}	
// You can define other methods, fields, classes and namespaces here
