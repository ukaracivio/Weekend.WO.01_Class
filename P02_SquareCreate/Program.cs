internal class Program
{
    private static void Main(string[] args)
    {
        // Kullanıcıdan 1..10 arasında deger alınacak
        // kenarlar * olacak, ortası boş olacak

        Console.WriteLine("1 ile 10 arasında bir değer giriniz... : ");

        int edgeLength=int.Parse(Console.ReadLine()); // bildiğimiz Convert.ToInt32 karşılığı

        if (edgeLength >=1 && edgeLength <=10)
        {
            for (int i = 0; i < edgeLength; i++) // satırlar için döngü
            {
                for (int j = 0; j < edgeLength; j++) // kolonlar için döngü
                {
                    if (i == 0 || i==edgeLength - 1 || j==0 || j==edgeLength - 1) // Hem satırda hem kolonda en son olanın önündemiyim. Başlardamıyım ortalardamıyım....
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }


                }

                Console.WriteLine(); // Yeni satıra atlama....
            }
        }
        else
        {
            Console.WriteLine("Hatalı giriş. Lütfen tekrar deneyiniz...");
        }


        Console.ReadKey();
    }
}