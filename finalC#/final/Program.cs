using System;
class Program{
public static void Main(string[]arg){

 Microwave Micro=new Microwave("A",2);
WashingMachine Washing=new WashingMachine("B",3);
 Refrigerator Refriger=new Refrigerator("Mac",4,3);

Device []d=new Device[3];
d [0]= Refriger;
d [1]= Washing;
d [2]= Micro;
for(int i=0;i<d.Length;i++){
d[i].TurnOn();

}
d[0].SetPower(150);
d[1].SetPower(700);
d[2].SetPower(1200);
// d[2].HeatFood(3);
Console.WriteLine(" the total number "+Device.TotalDevices);
}
}