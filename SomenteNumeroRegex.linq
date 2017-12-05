<Query Kind="Program" />

void Main()
{
	string stringValue = "ALKSJDF.ASDF.ASDF.ASDF.AS!@##$%¨&*+_)(*&¨%DF.123.3.3.4.5.001.2.3.4.5.6.7.8.9";
	
	Console.WriteLine(new Regex(@"[^\d]").Replace(stringValue, ""));
}

// Define other methods and classes here
