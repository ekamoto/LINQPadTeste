<Query Kind="Program" />

void Main()
{
	var compra = new Compra();
	
	compra.MostraSituacao();
	
	compra.ProcessarCompra();
	compra.MostraSituacao();
	
	compra.AnalisarCompra();
	compra.MostraSituacao();
	
	compra.EstornarCompra();
	compra.MostraSituacao();
	
	compra.AnalisarCompra();
	compra.MostraSituacao();
}

public class Compra
{
	public Status Situacao;
	
	public Compra()
	{
		Situacao = new Analise();
	}
	
	public void ProcessarCompra()
	{
		Situacao.EmProcessamento(this);
	}
	
	public void AnalisarCompra()
	{
		Situacao.EmAnalise(this);
	}
	
	public void EstornarCompra()
	{
		Situacao.Estornada(this);
	}
	
	public void MostraSituacao()
	{
		Console.WriteLine(Situacao.SituacaoAtual());
	}
}

public enum SituacaoCompraEnum
{
	EM_ANALISE,
	PROCESSADA,
	ESTORNADA
}

public interface Status
{
	void EmAnalise(Compra compra);
	void EmProcessamento(Compra compra);
	void Estornada(Compra compra);
	SituacaoCompraEnum SituacaoAtual();
}

public class Analise: Status
{
	public void EmAnalise(Compra compra)
	{
		Console.WriteLine("Compra já está em Análise");
	}
	
	public void EmProcessamento(Compra compra)
	{
		compra.Situacao = new Processamento();
	}
	
	public void Estornada(Compra compra)
	{
		compra.Situacao = new ComEstorno();
	}
	
	public SituacaoCompraEnum SituacaoAtual()
	{
		return SituacaoCompraEnum.EM_ANALISE;
	}
}

public class Processamento: Status
{
	public void EmAnalise(Compra compra)
	{
		compra.Situacao = new Analise();
	}
	
	public void EmProcessamento(Compra compra)
	{
		Console.WriteLine("A compra já está em processamento");
	}
	
	public void Estornada(Compra compra)
	{
		compra.Situacao = new ComEstorno();
	}
	
	public SituacaoCompraEnum SituacaoAtual()
	{
		return SituacaoCompraEnum.PROCESSADA;
	}
}

public class ComEstorno: Status
{
	public void EmAnalise(Compra compra)
	{
		Console.WriteLine("Não é possível voltar para em análise conta estornada");
	}
	
	public void EmProcessamento(Compra compra)
	{
		Console.WriteLine("Não é possível voltar para em processamento conta estornada");
	}
	
	public void Estornada(Compra compra)
	{
		compra.Situacao = new ComEstorno();
	}
	
	public SituacaoCompraEnum SituacaoAtual()
	{
		return SituacaoCompraEnum.ESTORNADA;
	}
}


// You can define other methods, fields, classes and namespaces here
