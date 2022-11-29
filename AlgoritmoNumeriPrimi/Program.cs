
//string risposta = "s";

//while(risposta == "s")
//{

//    Console.Write("Inserisci il numero: ");
//    int n = int.Parse(Console.ReadLine());
//    bool isPrimo = true;
//    for (int i = 2; i < n; i++)
//    {
//        if (n % i == 0)
//        {
//            isPrimo = false;
//        }
            
//    }
//    if (isPrimo == true)
//        Console.WriteLine("Il numero è primo");
//    else
//        Console.WriteLine("Il numero non è primo");
//    Console.ReadKey();
//}

int numeriPrimi = 0;
for(int j = 100000; j < 101000; j++)
{
    Console.WriteLine(j.ToString());
    bool isPrimo = true;
    for(int i = 2; i < j; i++)
    {
        if(j % i == 0)
        {
            isPrimo = false;
        }
    }
    if (isPrimo == true)
    {
        Console.WriteLine("il numero è primo");
        numeriPrimi = numeriPrimi + 1;
    }
    else
    {
        Console.WriteLine("il numero non è primo");
    }
}
Console.WriteLine("i numeri primi sono: " + numeriPrimi);   