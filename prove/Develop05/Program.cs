using System;

class Program
{
	static void Main(string[] args)
	{
		Menu menu = Menu.AutoLoad();
		menu.DisplayMenu();
	}
}