<Query Kind="Program" />

void Main()
{
	
	Pessoa pessoa = new Pessoa();
	
	pessoa.Imprimi();
}

partial class Pessoa {

	
}

// Legal é colocar em outros arquivos
// se não for fazer dessa forma terá que utilizar herança
// se tiver várias variações é melhor utilizar partial
// No final o compilador cria um único arquivo com todos
// os pedaços da classe
partial class Pessoa {

	public void Imprimi() {
		
		Console.WriteLine("Leandro Shindi Ekamoto");
	}
}



// Define other methods, classes and namespaces here
