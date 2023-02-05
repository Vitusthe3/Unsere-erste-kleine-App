// Unsere erste kleine App
// Gelerntes:
// 1. Using Direktiven und Variablen setzen
string Enter = "";
Boolean won = false;

// 2. Gestaltung

Console.WriteLine("Hallo ^^");
Thread.Sleep(1000);
Console.WriteLine("Das Zahlenspiel:");
Thread.Sleep(1000);
Console.WriteLine("Errate die Zahl, indem du einen Vorschlag in die Konsole schreibst.");

// Zahl generieren

Random r = new Random();
int ran = r.Next(0, 101);
while(won == false)
{
Enter = Console.ReadLine();

if (Convert.ToInt32(Enter) < ran)
{
        Console.WriteLine("---------------------");
        Console.WriteLine("Zahl ist zu klein.");
        Console.WriteLine("---------------------");
    }
if (Convert.ToInt32(Enter) > ran)
{
        Console.WriteLine("---------------------");
        Console.WriteLine("Zahl ist zu groß.");
        Console.WriteLine("---------------------");
    }
if (Convert.ToInt32(Enter) == ran)
{
        Console.WriteLine("---------------------");
        Console.WriteLine("GEWONNEN");
        Console.WriteLine("---------------------");
    Thread.Sleep(5000);
    won = true;
    
}
}
    



