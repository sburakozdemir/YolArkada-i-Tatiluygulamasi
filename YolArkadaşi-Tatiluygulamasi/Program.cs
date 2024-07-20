bool devamEt = true;
// Kullanıcıya karşılama mesajı yazdırılır.
Console.WriteLine("Merhabalar Yol Arkadaşı: Tatil uygulamasına hoş geldiniz.");
// Ana döngü, kullanıcı başka bir tatil planlamak istediği sürece devam eder.
while (devamEt)
{
    int toplam = 0;
    string lokasyon = "";
    int lokasyonFiyatı = 0;

    

    bool geçerliLokasyon = false;
    // Kullanıcıdan geçerli bir lokasyon girişi alınana kadar döngü devam eder.
    while (!geçerliLokasyon)
    {
        Console.WriteLine("Lütfen gitmek istediğiniz lokasyonu yazınız:");
        Console.WriteLine("1 - Bodrum (Paket başlangıç fiyatı 4000 TL)");
        Console.WriteLine("2 - Marmaris (Paket başlangıç fiyatı 3000 TL)");
        Console.WriteLine("3 - Çeşme (Paket başlangıç fiyatı 5000 TL)");

        // Kullanıcıdan alınan giriş küçük harflere dönüştürülür.
        string başlangıç = Console.ReadLine().ToLower();

        // Lokasyon seçimine göre fiyat ve özet bilgi belirlenir.
        switch (başlangıç)
        {
            case "bodrum":
                lokasyon = "Bodrum";
                lokasyonFiyatı = 4000;
                geçerliLokasyon = true;
                Console.WriteLine("Bodrum'da tatil sırasında yapabilecekleriniz:");
                Console.WriteLine("- Bodrum Kalesi'ni ziyaret edebilirsiniz.");
                Console.WriteLine("- Gümbet Plajı'nda denizin tadını çıkarabilirsiniz.");
                Console.WriteLine("- Barlar Sokağı'nda gece hayatını keşfedebilirsiniz.");
                break;
            case "marmaris":
                lokasyon = "Marmaris";
                lokasyonFiyatı = 3000;
                geçerliLokasyon = true;
                Console.WriteLine("Marmaris'te tatil sırasında yapabilecekleriniz:");
                Console.WriteLine("- Marmaris Kalesi'ni ziyaret edebilirsiniz.");
                Console.WriteLine("- İçmeler Plajı'nda güneşlenebilirsiniz.");
                Console.WriteLine("- Marmaris Marina'da yürüyüş yapabilirsiniz.");
                break;
            case "çeşme":
                lokasyon = "Çeşme";
                lokasyonFiyatı = 5000;
                geçerliLokasyon = true;
                Console.WriteLine("Çeşme'de tatil sırasında yapabilecekleriniz:");
                Console.WriteLine("- Çeşme Kalesi'ni gezebilirsiniz.");
                Console.WriteLine("- Ilıca Plajı'nda yüzebilirsiniz.");
                Console.WriteLine("- Alaçatı'da rüzgar sörfü yapabilirsiniz.");
                break;
            default:
                Console.WriteLine("Geçersiz giriş lütfen tekrar deneyiniz. (Bodrum, Marmaris, Çeşme)");
                break;
        }
    }

  

    // Kullanıcıdan kaç kişi için tatil planlandığı bilgisi alınır.
    Console.WriteLine("Kaç kişi için tatil planlamak istiyorsunuz?");
    int kişiSayısı = int.Parse(Console.ReadLine());

    // Seçilen lokasyon ve kişi sayısı kullanıcıya özet olarak gösterilir.
    Console.WriteLine($"Seçtiğiniz lokasyon: {lokasyon}");
    Console.WriteLine($"Kişi sayısı: {kişiSayısı}");

    bool geçerliUlaşım = false;
    int ulaşımFiyatı = 0;
    // Kullanıcıdan geçerli bir ulaşım şekli girişi alınana kadar döngü devam eder.
    while (!geçerliUlaşım)
    {
        Console.WriteLine("Tatiline ne şekilde gitmek istiyorsunuz?");
        Console.WriteLine("1 - Kara yolu (Kişi başı ulaşım tutarı gidiş-dönüş 1500 TL)");
        Console.WriteLine("2 - Hava yolu (Kişi başı ulaşım tutarı gidiş-dönüş 4000 TL)");
        Console.WriteLine("Lütfen yukarıdaki seçeneklerden bir tanesini seçiniz (1 veya 2):");

        // Kullanıcıdan alınan ulaşım şekli seçimine göre fiyat belirlenir.
        string ulaşım = Console.ReadLine();

        switch (ulaşım)
        {
            case "1":
                ulaşımFiyatı = 1500;
                geçerliUlaşım = true;
                break;
            case "2":
                ulaşımFiyatı = 4000;
                geçerliUlaşım = true;
                break;
            default:
                Console.WriteLine("Geçersiz giriş lütfen tekrar deneyiniz.");
                break;
        }
    }

    // Toplam tutar hesaplanır.
    toplam += ulaşımFiyatı * kişiSayısı+lokasyonFiyatı*kişiSayısı;

    // Sonuçlar kullanıcıya gösterilir.
    Console.WriteLine($"Gidilecek lokasyon: {lokasyon}");
    Console.WriteLine($"Kişi sayısı: {kişiSayısı}");
    Console.WriteLine($"Ulaşım şekli: {(ulaşımFiyatı == 1500 ? "Kara yolu" : "Hava yolu")}");
    Console.WriteLine($"Toplam tutar: {toplam} TL");

    // Kullanıcıya başka bir tatil planlamak isteyip istemediği sorulur.
    Console.WriteLine("Başka bir tatil planlamak ister misiniz? (evet/hayır)");
    devamEt = Console.ReadLine().ToLower() == "evet";
}

// Uygulama sonlandırılır.
Console.WriteLine("İyi günler dileriz!");