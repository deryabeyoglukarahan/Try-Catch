Console.Write("Bir sayı giriniz:");
try
{
    int sayi = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Girilen sayının karesi: " + sayi * sayi);
}
catch (Exception ex)
{
    Console.WriteLine("Geçersiz giriş! Lütfen bir sayı giriniz.");
    Console.WriteLine(ex.Message);
}
