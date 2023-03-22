namespace Examen1{
  class Estadisticas{
    public int balance;
    public int noGiros;
    public int noPopular;
    public int noImpopular;
    public int rojos;
    public int negros;
    public int pares;
    public int impares;
    public int[] numeros = new int[37]; // un espacio para cada numero 36 + el 0

    public Estadisticas(int balance)
    {
      this.balance = balance;
      this.noGiros = 0;
      this.noPopular = 0;
      this.noImpopular = 0;
      this.rojos = 0;
      this.negros = 0;
      this.pares = 0;
      this.impares = 0;
      for (int i = 0; i < this.numeros.Length; i++) {
          this.numeros[i] = 0;
      }
    }
  }
}