using System;

public class Program
{
    public static void Main()
    {
        try
        {

            Console.Write("Karesi alınacak sayıyı giriniz: ");
            string input = Console.ReadLine();
            int number = Convert.ToInt32(input);

            int sonuc = number * number;

            Console.WriteLine("Karesi " + sonuc);
        }
        catch (FormatException ex)
        {
            // Format hatası durumunda burası çalışır
            Console.WriteLine("Hata: Sayı formatı geçersiz. Lütfen doğru formatta bir sayı giriniz.");
        }

        finally
        {
            // Her durumda çalışmasını istediğiniz kodlar buraya yazılır
            Console.WriteLine("İşlem tamamlandı.");
        }
    }
}