﻿namespace Examen1{
  class Program{
    static Menu menu = new Menu();
    static void Main(string[] args){
      // presentacion
      Console.WriteLine("Bienvenido al Casino");
      do{
        Console.WriteLine();
        Console.Write("Presione enter para continuar");
        Console.ReadLine();
      }while(menu.ShowMenu());
    }
  }
}
