<Query Kind="Program" />

void Main()
{
	var processador = new Processador();
	
	var tipoDoido1 = new RegraTipoDoida();
	var tipoDoido2 = new RegraTipoDoidaMaluca();
	processador.Processa(tipoDoido1);
	processador.Processa(tipoDoido2);
	
}

public abstract class TipoDoido
{


	public abstract void Processa();
	
	public abstract bool Regra1();
	public abstract bool Regra2();
}

public class RegraTipoDoida: TipoDoido
{
	public override bool Regra1()
	{
		return true;
	}
	public override bool Regra2()
	{
		return true;
	}
	public override void Processa()
	{
		if(Regra1())
		{
			Console.WriteLine("Passou pela regra 1");
			if(Regra2())
			{
				Console.WriteLine("Passou pela regra 2");	
			}
		}
	}
}


public class RegraTipoDoidaMaluca: TipoDoido
{
	public override bool Regra1()
	{
		return true;
	}
	public override bool Regra2()
	{
		return false;
	}
	public override void Processa()
	{
		if(Regra1())
		{
			Console.WriteLine("Passou pela regra 1");
			if(Regra2())
			{
				Console.WriteLine("Passou pela regra 2");	
			}
		}
	}
}

public class Processador {

	public void Processa(TipoDoido tipoDoido)
	{
		tipoDoido.Processa();
	}
}

// You can define other methods, fields, classes and namespaces here
