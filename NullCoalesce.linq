<Query Kind="Program" />

void Main()
{
	string cache = null;
	//string cache = "cache";
	string d = "nao nulo";
	var e = cache??d;
	
	Console.WriteLine(""+e);
}
