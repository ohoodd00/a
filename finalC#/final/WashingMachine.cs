  using System;
  public class WashingMachine: Device{
    public WashingMachine(string _brand, int _power) : base(_brand, _power)
    {
    }

    public  override void TurnOn(){
    Console.WriteLine("The Washing Machine is starts spinong!.");
}

public override void SetPower(int watts){
int a=GetPower();
    a=watts;
    Console.WriteLine("Power now is:"+a);
}
}