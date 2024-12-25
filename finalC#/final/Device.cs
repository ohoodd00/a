using System;
public class Device{
    public string brand{get;set;}
     private int power{get;set;}
     public static int  TotalDevices;
     public  Device(string _brand,int _power){
brand=_brand;
power=_power;
TotalDevices++;
     }
public  virtual void TurnOn(){
    Console.WriteLine("Device is now on!");
}
public virtual void SetPower(int watts){
    power=watts;
    Console.WriteLine("Power now is:"+power);
}
public int GetPower(){
    return power;
}


}