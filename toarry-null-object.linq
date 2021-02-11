<Query Kind="Program" />

void Main()
{

	List<Pessoa> lista = null;
	
	// Se não for instânciado a lista o ToArray da exception
	lista.ToArray();
}

class Pessoa
{

}

// You can define other methods, fields, classes and namespaces here
