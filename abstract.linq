<Query Kind="Program" />

void Main()
{
	ClasseDerivada classe = new ClasseDerivada();
	
	classe.ImprimirNome("Leandro");
	
}

abstract public class ClasseAbstrata {

	// Não pode ter implementação como no Virtual
	public abstract void ImprimirNome (string nome);
}

public class ClasseDerivada: ClasseAbstrata {

	// Você é obrigado a implementar os métodos quando você herda
	public override void ImprimirNome(string nome)
	{
		Console.WriteLine(nome);
	}
}

// Define other methods, classes and namespaces here
