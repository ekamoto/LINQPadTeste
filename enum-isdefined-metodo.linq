<Query Kind="Program" />

void Main()
{
	Console.WriteLine(Enum.IsDefined(typeof(TIPO),1));	
}

public enum TIPO
{
	PRIMEIRO = 1,
	SEGUNDO = 2
}

// You can define other methods, fields, classes and namespaces here
