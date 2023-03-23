
abstract class musico
{
public string Nombre {get; set;}
public musico (string n) {Nombre = n;}
public virtual string  GetSaludo() => "Hola soy" + Nombre;

public virtual void Saludar() => Console.WriteLine(GetSaludo());


public abstract /*virtual*/ void Toca ();
            /*{
                Console.WriteLine($"{Nombre} tocando su intrumento" );
// los metodos abrastractos se delega implementacion a la clase obligatoria
            }*/

}


class Baterista:musico
{
    public string Bateria {get; set;}

    public Baterista(string nombre, string bateria):base(nombre) => Bateria = bateria;

    public override /*new*/ void Toca() => Console.WriteLine($"{Nombre} está tocando su {Bateria}");
    //para implementar metodos abstractos debemos de usar la palabra reservada override (redefinir/sobreescribir)

    public override string GetSaludo() => base.GetSaludo() + " y soy baterísta" ;
    public override void Saludar() => Console.WriteLine(GetSaludo());
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
      base.Saludar();
        Console.WriteLine($"{Nombre} tocando su {bajo}" );
    }

}


 class Program
{
    static void Main(string[] args)
    {
        List <musico> grupo = new List<musico>();
        grupo.Add(new bajista("Joe", "Yahmaha"));
        grupo.Add(new Baterista("Pepe", "Bateria") );

        foreach(var m in grupo)
        m.Saludar();
          foreach(var m in grupo)
        m.Toca();


       /* musico gustavo = new musico("Gustavo");
        gustavo.saluda();*/


        //musico otto  = new musico("Otto");
        
    }
}