Console.WriteLine("1:Human");
Console.WriteLine("2:Computer");
Console.Write("Choose the player: ");
int secenek2 = Convert.ToInt32(Console.ReadLine());
string oyuncuTuru;
string isim = "";
char A = 'A';
char B = 'B';
char C = 'C';
char D = 'D';
char E = 'E';

switch (secenek2)
{
    case 1:
        oyuncuTuru = "human";
        do
        {
            Console.Write("Enter your name: ");
            isim = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(isim))
            {
                Console.WriteLine("Invalid name.Please try again.");
            }
        } while (string.IsNullOrWhiteSpace(isim));
        break;
    case 2:
        oyuncuTuru = "computer";
        break;
    default:
        Console.WriteLine("Invalid option.Please try again.");
        return;
}

Console.Write("Write number of types of symbols between 1 - 5: ");
int secenek = Convert.ToInt32(Console.ReadLine());

string sembol = "";

switch (secenek)
{
    case 1:
        A = 'A';
        sembol = ($"{A}");
        break;
    case 2:
        A = 'A';
        B = 'B';
        sembol = ($"{A},{B}");
        break;
    case 3:
        A = 'A';
        B = 'B';
        C = 'C';
        sembol = ($"{A},{B},{C}");
        break;
    case 4:
        A = 'A';
        B = 'B';
        C = 'C';
        D = 'D';
        sembol = ($"{A},{B},{C},{D}");
        break;
    case 5:
        A = 'A';
        B = 'B';
        C = 'C';
        D = 'D';
        E = 'E';
        sembol = ($"{A},{B},{C},{D},{E}");
        break;
    default:
        while (!(secenek == 1 || secenek == 2 || secenek == 3 || secenek == 4 || secenek == 5))
        {
            if (!(secenek == 1 || secenek == 2 || secenek == 3 || secenek == 4 || secenek == 5))
            {
                Console.WriteLine("Invalid option.Please try again.");
                Console.Write("Write number of types of symbols between 1 - 5: ");
                secenek = Convert.ToInt32(Console.ReadLine());
            }
        }
        break;
}

//bool dogruMu = int.TryParse(sembolSayisi);

//Console.Write("Write number of symbols between 1 - 6: ");
//string sembolSayisi = Console.ReadLine();

//if (!int.TryParse(sembolSayisi, out sembolSayisi))
//{
//    Console.WriteLine("Please write a valid number");
//}

Console.Write("Hareket sayısını girin: ");
int hareketSayisi = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

Console.WriteLine("Oyun Modu");
Console.WriteLine("-------------");

if (oyuncuTuru == "insan")
{
    Console.WriteLine($"Oyuncu:{isim}");
}
else if (oyuncuTuru == "bilgisayar")
{
    Console.WriteLine($"Oyuncu: {oyuncuTuru}");
}

Console.WriteLine($"Semboller: {sembol}");
//Console.WriteLine($"Sembol sayısı: {sembolSayisi}");
Console.WriteLine($"Hareket sayısı: {hareketSayisi}");

Console.ReadLine();



