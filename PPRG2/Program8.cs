Console.WriteLine("podaj ilosc hp");
int hp = int.Parse(Console.ReadLine());

Console.WriteLine("czy masz klucz");
bool key = bool.Parse(Console.ReadLine());

Console.WriteLine("czy masz hasło");
bool password = bool.Parse(Console.ReadLine());

//Console.WriteLine($"Health Points: {hp}\nHas key: {key}\nKnow password: {password}");

bool isAlive = hp <= 0;

Console.WriteLine(isAlive);

if (isAlive != false)

    Console.WriteLine("nie zyjesz, nie mozesz wejsc!");

else if (isAlive == true && password == true || key == true)
    Console.WriteLine("zyjesz, znasz haslo lub masz klucz, mozesz wejsc");
else 
    Console.WriteLine("nie masz jak otworzyc drzwi");
