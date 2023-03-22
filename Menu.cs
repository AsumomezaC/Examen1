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
          Estadisticas();
          return true;
        default: 
          Resumen();
          return false;
      }
    }

    //acciones posibles
    public bool Apostar(){
      int tipo = SeleccionarApuesta();
      int monto = SeleccionarMonto();
      return player.Apostar(monto, tipo);
    }

    public void Estadisticas(){
      int consulta = TipoConsulta();
      player.Consulta(consulta);
    }

    public void Resumen(){
      Console.Clear();

      Console.WriteLine("Resumen del juego:");
      if((player.dinero - 300) > 0){
        Console.WriteLine($"Has ganado ${player.dinero - 300}, felicidades");
      } else {
        if((player.dinero - 300) == 0){
          Console.WriteLine("Has ganado... has perdido... espera, has quedado igual");
          Console.WriteLine("Seguro que jugaste? jajaja");
        } else {
          Console.WriteLine($"Has perdido ${300 - player.dinero}, lastima...");
        }
      }
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
      } while((monto % 10) != 0 || monto < 10);//si no se selecciono un monto multiplo de 10

      return monto;
    }
    
    public int TipoConsulta(){
      string? opcion;

      do{
        Console.Clear();
        Console.WriteLine("Que deseas consultar?");
        Console.WriteLine("1) Mi balance");
        Console.WriteLine("2) Cantidad de giros realizados");
        Console.WriteLine("3) Numero que mas veces se ha tirado");
        Console.WriteLine("4) Numero que menos veces se ha tirado");
        Console.WriteLine("5) Cantidad de resultados rojos");
        Console.WriteLine("6) Cantidad de resultados negros");
        Console.WriteLine("7) Cantidad de resultados pares");
        Console.WriteLine("8) Cantidad de resultados impares");
        opcion = Console.ReadLine();
      } while(opcion == null);

      return Int32.Parse(opcion);
    }
    // fin de submenus
  }
}