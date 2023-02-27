internal class Program
{
    private static void Main(string[] args)
    {
        float vf_monthlySalary = 8500f;

        int year = 1;

        Console.WriteLine("Başlangıç maaşını : {0} PNG Kina'dır...",String.Format("{0:###,###}",vf_monthlySalary));

        for (year=2; year <= 5; year++)
        {
            vf_monthlySalary = vf_monthlySalary * 1.15f;

            Console.WriteLine("{0}. yıl maaşınız : {1} PNG Kina",year.ToString(),Math.Ceiling(vf_monthlySalary));
        }

        Console.ReadKey();
    }
}