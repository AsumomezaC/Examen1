namespace Examen1{
  class Menu{
      
    Jugador player = new Jugador();

    public bool ShowMenu(){
      
      int opcion = SeleccionarOpcion();
      return EjecutarOpciones(opcion); // se seguira ejecutando hasta retornar false
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
      int tipo = SeleccionarApuesta();
      int monto = SeleccionarMonto();
      return player.Apostar(monto, tipo);
    }

    public bool Estadisticas(){
      return true;
    }

    public void Salir(){
      Console.WriteLine("Hasta luego, que pase un lindo día");
    }
    // fin acciones posibles

    // sub menus
    public int SeleccionarApuesta(){
      string? opcion;

      do{
        Console.Clear();
        Console.WriteLine("Seleccione el tipo de apuesta a realizar");
        Console.WriteLine("1) Numero específico");
        Console.WriteLine("2) Por color");
        Console.WriteLine("3) Par o impar");
        opcion = Console.ReadLine();
        if(opcion != "1" && opcion != "2" && opcion != "3"){ // si no se selecciona una opcion valida
          Console.WriteLine("Opcion invalida, presione para continuar");
          Console.ReadLine();
          opcion = null;
        }
      } while (opcion == null);

      return Int32.Parse(opcion);
    }

    public int SeleccionarMonto(){
      string? opcion;
      int monto;

      do{
        do{
          Console.Clear();
          Console.WriteLine("Cuanto desea apostar?");
          Console.WriteLine("La apuesta debe de ser en multiplos de 10");
          opcion = Console.ReadLine();
        } while (opcion == null);
        monto = Int32.Parse(opcion);
      } while((monto % 10) != 0);//si no se selecciono un monto multiplo de 10

      return monto;
    }
    // fin de submenus
  }
}