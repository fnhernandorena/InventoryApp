using System;

public class Sell
{
	public int id{ get; set; }
	public DateTime date { get; set; } = DateTime.Now;
	public string name { get; set; }
	public double? price { get; set; }
	public int transfer {  get; set; } = 0;
}
