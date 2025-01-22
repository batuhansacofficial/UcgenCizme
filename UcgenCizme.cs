using System;

class UcgenCizimi
{
	static void Main()
	{
		int buyukluk = UcgenBuyuklugu();
		UcgenCiz(buyukluk);
	}
	
	/// <summary>
	/// Kullanıcıdan üçgenin boyutunu girmesini ister.
	/// </summary>
	/// <returns>'integer' olarak üçgenin büyüklüğü</returns>
	static int UcgenBuyuklugu()
	{
		int buyukluk;
		Console.Write("Üçgenin büyüklüğünü giriniz: ");
		while (!int.TryParse(Console.ReadLine(), out buyukluk) || buyukluk <= 0)
		{
		    Console.Write("Geçersiz değer. Lütfen sıfırdan büyük bir sayı giriniz: ");
		}
		return buyukluk;
	}
	
	/// <summary>
	/// '*' karakteri ile belirtilen büyüklükteki üçgeni çizer.
	/// </summary>
	/// <param name="buyukluk">Üçgenin büyüklüğü.</param>
	static void UcgenCiz(int buyukluk)
	{
	    for (int i = 1; i <= buyukluk; i++)
	    {
	        Console.WriteLine(new string('*', i));
	    }
	}
}