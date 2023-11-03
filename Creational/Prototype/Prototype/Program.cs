// See https://aka.ms/new-console-template for more information

using Prototype;

ColorManager colorManager = new ColorManager();
colorManager["Red"] = new Color(255,0,0);
colorManager["Green"] = new Color(0, 255, 0);
colorManager["Blue"] = new Color(0, 0, 255);

colorManager["angry"] = new Color(255, 54, 0);
colorManager["peace"] = new Color(128, 211, 128);
colorManager["flame"] = new Color(211, 34, 20);

Color color1 = colorManager["Red"].Clone() as Color;
Color color2 = colorManager["Green"].Clone() as Color;
Color color3 = colorManager["Blue"].Clone() as Color;

Console.WriteLine("\ncolor1");
Console.WriteLine(color1);
Console.WriteLine("\ncolor2");
Console.WriteLine(color2);
Console.WriteLine("\ncolor3");
Console.WriteLine(color3);

