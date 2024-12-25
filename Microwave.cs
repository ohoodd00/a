using System;
public class Microwave: Device{
      public  override void TurnOn(){
    Console.WriteLine("The microwave begins heating!");
}
public float mult;
public int Plates;

    public Microwave(string _brand, int _power) : base(_brand, _power)
    {
    }

    public  void HeatFood(int seconds){
mult=seconds*GetPower();
}
public void Platess(int _Plates){
    Plates=_Plates;
}

}