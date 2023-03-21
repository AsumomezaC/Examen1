namespace Examen1{
  class Menu{
      
    Jugador player = new Jugador();

    public void ShowMenu(){
      Console.Clear();
      Console.WriteLine("Seleccione una opcion");
      Console.WriteLine("1) Apostar");
      Console.WriteLine("2) Consultar estadisticas");
      Console.WriteLine("3) Salir");
    }
  }
}