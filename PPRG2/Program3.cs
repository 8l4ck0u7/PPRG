Console.WriteLine("podaj ilosc racji");
int racje = int.Parse(Console.ReadLine());

Console.WriteLine("podaj liczbe czlonkow druzyny");
int druzyna = int.Parse(Console.ReadLine());

Console.WriteLine("podaj ilosc dni wyprawy");
int dni = int.Parse(Console.ReadLine());

int pRacje= racje % druzyna;

int pozRacje = (racje - pRacje) / druzyna;

Console.WriteLine("Pelne racje: " +pozRacje);

Console.WriteLine("Pozostale racje: "  +pRacje);

double dRacje = (double)racje / (double)druzyna / (double)dni;
Console.WriteLine($"Dzienne racje na osobe: {dRacje:F2}");



double medRacje = (double)racje / (double)dni;

Console.WriteLine($"Dzienne racje na druzyne {medRacje:F2} ");