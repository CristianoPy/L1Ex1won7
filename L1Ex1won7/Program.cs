/*Scrieti un program care citind de la tastaura cele trei dimensiuni ale unui
paralelipiped dreptunghic, va afisa volumul lui*/

int alt;
Console.WriteLine("Introduce inaltimea: ");
alt = Convert.ToInt32(Console.ReadLine());

int lag;
Console.WriteLine("Introduce latimea: ");
lag = Convert.ToInt32(Console.ReadLine());

int comp;
Console.WriteLine("Introduce lungimea: ");
comp = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("OVolumul paralelepipedului este: " + alt * lag * comp);

Console.ReadLine();