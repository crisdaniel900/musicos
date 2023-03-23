
abstract class musico
{
public string Nombre {get; set;}
public musico (string n) {Nombre = n;}
public void saluda () {Console.WriteLine($"Hola a todos soy {Nombre}"  );}
public abstract /*virtual*/ void Toca ();
            /*{
                Console.WriteLine($"{Nombre} tocando su intrumento" );
// los metodos abrastractos se delega implementacion a la clase obligatoria
            }*/

}


class bateria: musico
{
public string baterista  {get; set;}
public  bateria (string n, string b):base(n)
  {
    baterista = b;

  }
    public override void Toca()
    {
        Console.WriteLine($"{Nombre} tocando su {baterista}" );
    }

}

class bajista:musico
{
public string bajo  {get; set;}
public bajista (string n, string b):base(n)
  {
    bajo = b;

  }
    public override void Toca()
    {
        Console.WriteLine($"{Nombre} tocando su {bajo}" );
    }

}


 class Program
{
    static void Main(string[] args)
    {
        List <musico> grupo = new List<musico>();
        grupo.Add(new bajista("Joe", "Yahmaha"));
        grupo.Add(new bateria("Pepe", "Bateria") );

        foreach(var m in grupo)
        m.saluda();
          foreach(var m in grupo)
        m.Toca();


       /* musico gustavo = new musico("Gustavo");
        gustavo.saluda();*/


        //musico otto  = new musico("Otto");
        
    }
}