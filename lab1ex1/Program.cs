/*Scrieti un program care citind de la tastaura cele trei dimensiuni ale unui
paralelipiped dreptunghic, va afisa volumul lui
*/
Console.WriteLine("Introduceti latimea paralelipipedului:");
int latime = int.Parse(Console.ReadLine());
Console.WriteLine("Introduceti lungimea paralelipipedului:");
int lungime = int.Parse(Console.ReadLine());
Console.WriteLine("Introduceti inaltimea paralelipipedului:");
int inaltime = int.Parse(Console.ReadLine());

int volum = latime * lungime * inaltime;
Console.WriteLine("Volumul paralelipipedului este:" + volum);