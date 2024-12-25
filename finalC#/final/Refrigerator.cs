using System;
public class Refrigerator :Device{
    
    public  override void TurnOn(){
    Console.WriteLine("The refrigerator is humming quietly.");
}
public int Capacity;

    public Refrigerator(string _brand, int _power,int _Capacity) : base(_brand, _power)
    {
         Capacity=_Capacity;
    }
   
}
