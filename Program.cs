using System; 
namespace Abstraction{}
public abstract class tol
  { 
    public abstract void jalantol(); 
    
  } 
public class tolj : tol 
{ 
    public override void jalantol() 
    { 
        Console.WriteLine("Tempelkan Kartu Tol Jagorawi Anda Di Mesin"); 
    } 
} 
public class tols : tol 
{ 
  public override void jalantol()
  {
    Console.WriteLine("Tempelkan Kartu Tol Serpan Anda Di Mesin");
  }
}
public class main_method 
{ 
    public static void Main() 
    { 
        tol j = new tolj();
        j.jalantol(); 
        tol s = new tols();
        s.jalantol();
    } 
}   