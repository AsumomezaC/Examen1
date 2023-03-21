namespace Examen1{
  class Menu{
      
    Jugador player = new Jugador();

    public bool ShowMenu(){

      int opcion = SeleccionarOpcion();
      return EjecutarOpciones(opcion);
    }

    public int SeleccionarOpcion(){
      string? opcion;

      do{
        Console.Clear();
        Console.WriteLine("Seleccione una opcion");
        Console.WriteLine("1) Apostar");
        Console.WriteLine("2) Consultar estadisticas");
        Console.WriteLine("3) Salir");
        opcion = Console.ReadLine();
        if(opcion != "1" && opcion != "2" && opcion != "3"){ // si no se selecciona una opcion valida
          Console.WriteLine("Opcion invalida, presione para continuar");
          Console.ReadLine();
          opcion = null;
        }
      } while (opcion == null);

      return Int32.Parse(opcion);
    }

    public bool EjecutarOpciones(int opcion){
      switch(opcion){
        case 1:
          return Apostar();
        case 2:
          return Estadisticas();
        default: 
          Salir();
          return false;
      }
    }

    //acciones posibles
    public bool Apostar(){
      return true;
    }

    public bool Estadisticas(){
      return true;
    }

    public void Salir(){
      Console.WriteLine("Hasta luego, que pase un lindo día");
    }
    // fin acciones posibles
  }
}