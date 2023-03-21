namespace Examen1{
  class Jugador{
    public int dinero;
    public Estadisticas estadisticas = new Estadisticas();
    public Apuestas apuestas = new Apuestas();
    public Jugador(){
      // El jugador deberá iniciar con un monto de dinero inicial ($300)
      this.dinero = 300;
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
        //verificar si gana la apuesta tiene suficiente dinero para seguir apostando <10, o si acaba el juego
        if(apuestas.Apostar(tipo)){
          Console.WriteLine("Felicidades, has ganado la apuesta");
          AgregarGanancia(dineroApostado, tipo);
          return true;
        } else {
          Console.WriteLine("Una lastima, has perdido :c");
          if(this.dinero < 10){
            Console.WriteLine("Parece que no tienes suficiente dinero para seguir jugando");
            Console.WriteLine("Game Over");
            return false; // se termina el juego, si tienes menos de 10 no puedes seguir apostando
          } else {
            Console.WriteLine("Mas suerte la poxima");
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
  }
}