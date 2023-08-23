Console.Write("Iveskite dienos numeri: ");
string day = Console.ReadLine();
if (day == "1")
{
    Console.WriteLine("Pirmadienis");
}
else if (day == "2")
{
    Console.WriteLine("Antradienis");
}
else if (day == "3")
{
    Console.WriteLine("Treciadienis");
}
else if (day == "4")
{
    Console.WriteLine("Ketvirtadienis");
}
else if (day == "5")
{
    Console.WriteLine("Penktadienis");
}
else if (day == "6")
{
    Console.WriteLine("Sestadienis");
}
else if (day == "7")
{
    Console.WriteLine("Sekmadienis");
}
else
{
    Console.WriteLine("Neteisingas dienos numeris");
}