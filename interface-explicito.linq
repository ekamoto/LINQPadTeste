<Query Kind="Program" />

void Main()
{
	var processarExplicito = new ProcessarExplicito();
	
	InterfaceI interfaceI = processarExplicito;
	InterfaceII interfaceII = processarExplicito;
	
	interfaceI.processar();
	interfaceII.processar();
}

interface InterfaceI {
	
	void processar();
}

interface InterfaceII {

	void processar();
}

class Processar: InterfaceI, InterfaceII {

	public void processar() 
	{
	
	}
}

class ProcessarExplicito: InterfaceI, InterfaceII 
{

	void InterfaceI.processar () 
	{
		Console.WriteLine("InterfaceI");
	}
	
	void InterfaceII.processar () 
	{
		Console.WriteLine("InterfaceII");
	}
}