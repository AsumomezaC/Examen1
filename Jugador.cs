namespace Examen1{
  class Jugador{
    public int dinero;
    public Apuestas apuestas = new Apuestas();
    public Jugador(){
      // El jugador deberá iniciar con un monto de dinero inicial ($300)
      this.dinero = 300;
      // Inicializa las estadisticas
      this.apuestas.estadisticas = new Estadisticas(this.dinero);
    }

    // tipo se refiere al tipo de apuesta que se esta haciendo
    // Si retorna true puede seguir jugando, de lo contrario termina el juego
    public bool Apostar(int dineroApostado, int tipo){
      if((this.dinero - dineroApostado) < 0){
        // Fondos insuficientes para la apuesta
        Console.WriteLine("Ups, parece que no tienes suficiente dinero para apostar :(");
        return true;
      } else {
        // Hay sufficientos fondos para la apuesta
        this.dinero-=dineroApostado;// disminuye fondos apostados
        apuestas.estadisticas.balance = this.dinero;
        //verificar si gana la apuesta tiene suficiente dinero para seguir apostando <10, o si acaba el juego
        if(apuestas.Apostar(tipo)){
          Console.WriteLine("Felicidades, has ganado la apuesta");
          AgregarGanancia(dineroApostado, tipo);
          apuestas.estadisticas.balance = this.dinero;
          return true;
        } else {
          Console.WriteLine("Una lastima, has perdido");
          if(this.dinero < 10){
            Console.WriteLine("\n...Parece que no tienes suficiente dinero para seguir jugando");
            Console.WriteLine("Game Over");
            return false; // se termina el juego, si tienes menos de 10 no puedes seguir apostando
          } else {
            Console.WriteLine("Mas suerte la proxima");
            return true; // puede seguir realizando apuestas
          }
        }
      }
    }

    public void AgregarGanancia(int ganancia, int tipo){
      switch(tipo){
        case 1:
          this.dinero+=(ganancia*10);
          return;
        case 2:
          this.dinero+=(ganancia*5);
          return;
        case 3:
          this.dinero+=(ganancia*2);
          return;
        default:
          Console.WriteLine("Ups, ocurrio un error");
          break;
      }
    }

    // estadisticas
    public void Consulta(int tipo){
      Console.Clear();

      switch(tipo){
        case 1:
          Console.WriteLine($"Su balance es: ${apuestas.estadisticas.balance}");
          break;
        case 2:
          Console.WriteLine($"Cantidad de giros realizados: {apuestas.estadisticas.noGiros}");
          break;
        case 3:
          Console.WriteLine($"Numero que mas veces se ha tirado: {apuestas.estadisticas.noPopular}");
          break;
        case 4:
          Console.WriteLine($"Numero que menos veces se ha tirado: {apuestas.estadisticas.noImpopular}");
          break;
        case 5:
          Console.WriteLine($"Cantidad de resultados rojos: {apuestas.estadisticas.rojos}");
          break;
        case 6:
          Console.WriteLine($"Cantidad de resultados negros: {apuestas.estadisticas.negros}");
          break;
        case 7:
          Console.WriteLine($"Cantidad de resultados pares: {apuestas.estadisticas.pares}");
          break;
        case 8:
          Console.WriteLine($"Cantidad de resultados impares: {apuestas.estadisticas.impares}");
          break;
        default:
          Console.WriteLine("Ocurrio un error, intente nuevamente");
          break;
      }
    }
  }
}