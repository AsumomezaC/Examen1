namespace Examen1{
  class Apuestas{
    // Apostar retorna verdadero si gano y falso si perdio
    // recibe el tipo de apuesta
    public bool Apostar(int tipoApuesta){
      switch(tipoApuesta){
        case 1:
          return ApuestaNumero();
        case 2:
          return ApuestaColor();
        case 3:
          return ApuestaPar();
        default:
          Console.WriteLine("Ocurrio un error");
          return false;
      }
    }

    // tipos de apuestas
    public bool ApuestaNumero(){
      int numero = SelecionarNumero(); // el usuario hace la seleccion de su apuesta
    }

    public bool ApuestaColor(){
      bool color = SeleccionarColor(); // el usuario hace la seleccion de su apuesta
    }

    public bool ApuestaPar(){
      bool par = SeleccionarPar();// el usuario hace la seleccion de su apuesta
    }
    // fin de tipos de apuestas

    // selecciones de apuestas
      public int SelecionarNumero(){
        
      }

      public bool SeleccionarColor(){

      }

      public bool SeleccionarPar(){

      }
    // fin de selecciones de apuestas
  }
}