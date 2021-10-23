using System;

public class option
{
	public option(string nom, int max)
	{
		this.onom = nom;
		this.omax = max;
		this.placedispo = max;
	}


	public string onom;
	public int omax; //capacite de la filiere
	public int placedispo;
}
