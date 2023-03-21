namespace Examen1{
  class Jugador{
    public int dinero;
    public Jugador(){
      // El jugador deberá iniciar con un monto de dinero inicial ($300)
      this.dinero = 300;
    }
    // tipo se refiere al tipo de apuesta que se esta haciendo
    // Si retorna true puede seguir jugando, de lo contrario termina el juego
    public bool apostar(int dineroApostado, int tipo){
      if((this.dinero - dineroApostado) < 0){
        // Fondos insuficientes para la apuesta
        Console.WriteLine("Ups, parece que no tienes suficiente dinero para apostar :(");
        return true;
      } else {
        // Hay sufficientos fondos para la apuesta
        this.dinero-=dineroApostado;
        return true;
        //verificar si gana la apuesta tiene suficiente dinero para seguir apostando <10, o si acaba el juego
      }
    }
  }
}