namespace Examen1{
  class Apuestas{
    Numeros numeros = new Numeros();
    public Estadisticas? estadisticas;
    // Apostar retorna verdadero si gano y falso si perdio
    // recibe el tipo de apuesta
    public bool Apostar(int tipoApuesta){
      // crear numero
      Random random = new Random();
      int numCreado = random.Next(0, 37);
      
      // estadisticas
      AniadirEstadisticas(numCreado);

      switch(tipoApuesta){
        case 1:
          return ApuestaNumero(numCreado);
        case 2:
          return ApuestaColor(numCreado);
        case 3:
          return ApuestaPar(numCreado);
        default:
          Console.WriteLine("Ocurrio un error");
          return false;
      }
    }

    // tipos de apuestas
    public bool ApuestaNumero(int numeroCreado){
      int numero = SelecionarNumero(); // el usuario hace la seleccion de su apuesta
      ImprimirNumero(numeroCreado);
      return numeroCreado == numero;
    }

    public bool ApuestaColor(int numeroCreado){
      // true red false black
      bool color = SeleccionarColor(); // el usuario hace la seleccion de su apuesta
      ImprimirNumero(numeroCreado);
      if((Color(numeroCreado) == "negro" && color == false) 
      || (Color(numeroCreado) == "rojo" && color == true)){
        return true;
      }
      return false;
    }

    public bool ApuestaPar(int numeroCreado){
      // true par false impar
      bool par = SeleccionarPar();// el usuario hace la seleccion de su apuesta
      ImprimirNumero(numeroCreado);
      if((par == true && (numeroCreado % 2) == 0) 
      || (par == false && (numeroCreado % 2) == 1)){
        return true;
      }
      return false;
    }
    // fin de tipos de apuestas

    // selecciones de apuestas
      public int SelecionarNumero(){
        string? opcion;

        do{
          Console.Clear();
          Console.WriteLine("Selecciona un numero del 0 al 36");
          opcion = Console.ReadLine();
        } while (opcion == null);

        return Int32.Parse(opcion);
      }

      public bool SeleccionarColor(){
        // regresa verdadero si se escoge rojo y falso si escoje negro
        string? opcion;

        do{
          Console.Clear();
          Console.WriteLine("Selecciona un color");
          Console.WriteLine("1) Rojo");
          Console.WriteLine("2) Negro");
          opcion = Console.ReadLine();
          if(opcion != "1" && opcion != "2"){ // si no se selecciona una opcion valida
            Console.WriteLine("Opcion invalida, presione para continuar");
            Console.ReadLine();
            opcion = null;
          }
        } while (opcion == null);

        if(opcion == "1")
          return true;
        else 
          return false;
      }

      public bool SeleccionarPar(){
        // regresa verdadero si se escoge par y falso si escoje impar
        string? opcion;

        do{
          Console.Clear();
          Console.WriteLine("El numero sera par o impar?");
          Console.WriteLine("1) Par");
          Console.WriteLine("2) Impar");
          opcion = Console.ReadLine();
          if(opcion != "1" && opcion != "2"){ // si no se selecciona una opcion valida
            Console.WriteLine("Opcion invalida, presione para continuar");
            Console.ReadLine();
            opcion = null;
          }
        } while (opcion == null);

        if(opcion == "1")
          return true;
        else 
          return false;
      }
    // fin de selecciones de apuestas

    // metodos de estaditica
    public void AniadirEstadisticas(int numero){
      estadisticas.noGiros++;

      estadisticas.numeros[numero]++;// aniade conteo al numero que se agrego

      // determina si el nuevo numero es mas popular que el anterior
      if(estadisticas.numeros[estadisticas.noPopular] < estadisticas.numeros[numero]){
        estadisticas.noPopular = numero;
      }

      //determina el numero impopular
      for(int i = 0; i <= 36; i++){
        if(estadisticas.numeros[estadisticas.noImpopular] > estadisticas.numeros[i]){
          estadisticas.noImpopular = i;
        }
      }

      if(Color(numero) == "negro")
        estadisticas.negros++;
      else if(Color(numero) == "rojo")
        estadisticas.rojos++;

      if(numero % 2 == 0)
        estadisticas.pares++;
      else
        estadisticas.impares++;
    }
    //fin de metodos de estadidtica

    // metodos adicionales
    public void ImprimirNumero(int numero){
      Console.WriteLine("Y el numero es...");
      if(numero == 0){
        Console.WriteLine("0, sin color");
      } else {
        Console.WriteLine($"{numero}, {Color(numero)}");
      }
    }

    public string Color(int numero){
      // retorna 0 si el numero no tiene color, 1 si es negro y 2 si es rojo
      if(numero == 0)
        return "na";
      if(DefinirColor(numeros.listaBlack, numero))
        return "negro";
      if(DefinirColor(numeros.listaRed, numero))
        return "rojo";
      return "error"; // si retorna 3 ocurrio un error
    }

    bool DefinirColor(List<int> lista, int numero){
      foreach (int n in lista){
        if (n == numero){
          return true;
        }
      }
      return false;
    }
    // fin metodos adicionales
  }
}