﻿/****************************************************************************
** SAKARYA ÜNİVERSİTESİ
** BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
** BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ BÖLÜMÜ
** NESNEYE DAYALI PROGRAMLAMA DERSİ
** 2019-2020 BAHAR DÖNEMİ
**
** ÖDEV NUMARASI..........: 01
** ÖĞRENCİ ADI............: Selin YILMAZ
** ÖĞRENCİ NUMARASI.......: B181200024
** DERSİN ALINDIĞI GRUP...: A
****************************************************************************/

using System;

namespace NDP.ÖDEV1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Portakallı kakaolu kek için 1, köfte için 2, mercimek çorbası için 3 ve taze fasulye için 4 yazınız.");
            //Kullanıcı 4 farklı yemek tarifinden birini seçiyor.
            int sayi1;
            sayi1 = Convert.ToInt32(Console.ReadLine());

            //Kullanıcıdan aldığımız sayının hangi tarife denk geldiğine bakıyoruz.
            if ((sayi1 <= 4) && (sayi1 > 2))
            {
                if (sayi1 < 4)
                {
                    //Kullanıcıdan yemeğin miktarı için kişi sayısı alıyoruz.
                    int sayi;
                    //Tarifin tek kişilik malzeme katsayılarını işlem kolaylığı için değişkenlere atadım.
                    double KatSayi = 0.5;
                    double KatSayi1 = 0.16;
                    double KatSayi2 = 0.25;
                    double KatSayi3 = 1;

                    Console.Write("Çorbanızın kaç kişilik olmasını istediğinizi yazınız.");
                    sayi = Convert.ToInt32(Console.ReadLine());
                    //Malzemenin katsayıları ve aldığımız kişi sayısını çarparak doğru malzeme miktarını hesaplayıp ekrana yazıyoruz.
                    double miktar = sayi * KatSayi;
                    Console.WriteLine("Sıvı yağ(yemek kaşığı) {0}", miktar);
                    double miktar1 = sayi * KatSayi1;
                    Console.WriteLine("Soğan {0}", miktar1);
                    Console.WriteLine("Un(yemek kaşığı) {0}", miktar1);
                    Console.WriteLine("Havuç {0}", miktar1);
                    Console.WriteLine("Patates {0}", miktar1);
                    Console.WriteLine("Tuz(tatlı kaşığı) {0}", miktar1);
                    Console.WriteLine("Karabiber(çay kaşığı) {0}", miktar1);
                    double miktar2 = sayi * KatSayi2;
                    Console.WriteLine("Mercimek(su bardağı) {0}", miktar2);
                    double miktar3 = sayi * KatSayi3;
                    Console.WriteLine("Sıcak Su(su bardağı) {0}", miktar3);

                    //Tarifi de ekrana yazdırıyoruz.
                    Console.WriteLine("Derin bir tencereye sıvı yağı ekleyin. İri doğranmış soğanınızı sıvı yağ ile birlikte kavurun.Kavrulan soğanlara unu ekleyin ve kokusu çıkıp, renk alana kadar kavurma işlemini sürdürün. İri parçalar halinde doğradığınız havuç ve patatesi tencereye aktarıp karıştırmaya devam edin.Tuz, karabiber ve bol suda yıkadıktan sonra suyunu süzdürdüğünüz mercimeği  de ilave edin ve son kez güzelce karıştırın. Suyu da tencereye ilave edin.Ardından kapağını kapatın, patates ve havuçlar yumuşayana kadar ara ara karıştırarak 40 dakika kadar pişirin.Çorba piştikten sonra pürüzsüz bir kıvam alması için; el blenderından geçirin. 5 dakika daha pişirdikten sonra ocaktan alın. Servis edebilirsiniz.");
                }
                else
                {
                    //Kullanıcıdan yemeğin miktarı için kişi sayısı alıyoruz.
                    int sayi2;
                    //Tarifin tek kişilik malzeme katsayılarını işlem kolaylığı için değişkenlere atadım.
                    double KatSayi4 = 0.15;
                    double KatSayi5 = 1.25;
                    double KatSayi6 = 0.25;
                    double KatSayi7 = 0.5;
                    double KatSayi8 = 0.75;

                    Console.Write("Taze fasulyenizin kaç kişilik olmasını istediğinizi yazınız.");
                    sayi2 = Convert.ToInt32(Console.ReadLine());
                    //Malzemenin katsayıları ve aldığımız kişi sayısını çarparak doğru malzeme miktarını hesaplayıp ekrana yazıyoruz.
                    double miktar4 = sayi2 * KatSayi4;
                    Console.WriteLine("Fasulye(kilo) {0}", miktar4);
                    double miktar5 = sayi2 * KatSayi5;
                    Console.WriteLine("Zeytin Yağı(yemek kaşığı) {0}", miktar5);
                    double miktar6 = sayi2 * KatSayi6;
                    Console.WriteLine("Soğan {0}", miktar6);
                    Console.WriteLine("Sıcak su(su bardağı) {0}", miktar6);
                    Console.WriteLine("Toz şeker(çay kaşığı) {0}", miktar6);
                    double miktar7 = sayi2 * KatSayi7;
                    Console.WriteLine("Sarımsak(diş) {0}", miktar7);
                    Console.WriteLine("Tuz(çay kaşığı) {0}", miktar7);
                    double miktar8 = sayi2 * KatSayi8;
                    Console.WriteLine("Domates {0}", miktar8);

                    //Tarifi de ekrana yazdırıyoruz.
                    Console.WriteLine("Soğanları küçük küpler halinde kesin. Sarımsakları ince ince dilimleyin. Domatesleri rendeleyin. Fasulyeleri de ayıklayarak bir köşeye alın. Zeytinyağını bir tencerede kızdırın.Doğradığınız soğanı ve sarımsakları hafif bir renk alana kadar kavurun.Doğranmış taze fasulyeyi de ekleyerek kavurma işlemini sürdürün.Tuz, toz şeker, domates ve sıcak suyu da ekledikten sonra güzelce karıştırın.Kapağını kapatıp fasulyeler yumuşayana kadar kısık ateşte pişirmeye bırakın.Arzuya göre ılık, fakat daha da lezzetli olması için soğuk olarak servis edin. Afiyet olsun!");


                }
            }
            else
            {
                if (sayi1 < 2)
                {
                    //Kullanıcıdan yemeğin miktarı için kişi sayısı alıyoruz.
                    int sayi;
                    //Tarifin tek kişilik malzeme katsayılarını işlem kolaylığı için değişkenlere atadım.
                    double KatSayi = 0.5;
                    double KatSayi1 = 0.25;
                    double KatSayi2 = 0.16;
                    double KatSayi3 = 0.33;

                    Console.Write("Kekinizin kaç kişilik olmasını istediğinizi yazınız.");
                    sayi = Convert.ToInt32(Console.ReadLine());
                    //Malzemenin katsayıları ve aldığımız kişi sayısını çarparak doğru malzeme miktarını hesaplayıp ekrana yazıyoruz.
                    double miktar = sayi * KatSayi;
                    Console.WriteLine("Yumurta {0}", miktar);
                    Console.WriteLine("Un {0}", miktar);
                    double miktar1 = sayi * KatSayi1;
                    Console.WriteLine("Şeker(su bardağı) {0}", miktar1);
                    double miktar2 = sayi * KatSayi2;
                    Console.WriteLine("Portakal {0}", miktar2);
                    Console.WriteLine("Süt(su bardağı) {0}", miktar2);
                    Console.WriteLine("Kabartma tozu(paket) {0}", miktar2);
                    Console.WriteLine("Sıvı yağ(çaybardağı) {0}", miktar2);
                    double miktar3 = sayi * KatSayi3;
                    Console.WriteLine("Kakao(yemek kaşığı) {0}", miktar3);

                    //Tarifi de ekrana yazdırıyoruz.
                    Console.WriteLine("Yumurta ve şeker beyaz oluncaya kadar çırpın. İçine yoğurt ve sıvı yağ ilave edilerek çırpmaya devam edin. Portakalı kabukları ile birlikte bütün olarak rendeleyin. Un ve kabartma tozunu da eleyip ilave ederek tekrar çırpın.");
                    Console.WriteLine("Karışımın yarısını ayrı bir kaseye aktarın. Buna kakao ilave edilerek karıştırın. (Arzuya göre sadece kakaolu ya da sade de yapılabilir.)");
                    Console.WriteLine("Yağlanmış kek kalıbına bir kakaolu bir sade karışımdan sırayla dökerek 180 derece önceden ısıtılmış fırında pişirin. Dilimleyerek servis yapılır.");

                }
                else
                {
                    //Kullanıcıdan yemeğin miktarı için kişi sayısı alıyoruz.
                    int sayi2;
                    //Tarifin tek kişilik malzeme katsayılarını işlem kolaylığı için değişkenlere atadım.
                    double KatSayi4 = 0.16;
                    double KatSayi5 = 1.33;
                    double KatSayi6 = 0.33;
                    double KatSayi7 = 0.66;
                    double KatSayi8 = 2;

                    Console.Write("Köftenizin kaç kişilik olmasını istediğinizi yazınız.");
                    sayi2 = Convert.ToInt32(Console.ReadLine());
                    //Malzemenin katsayıları ve aldığımız kişi sayısını çarparak doğru malzeme miktarını hesaplayıp ekrana yazıyoruz.
                    double miktar4 = sayi2 * KatSayi4;
                    Console.WriteLine("Kıyma(kilo) {0}", miktar4);
                    double miktar5 = sayi2 * KatSayi5;
                    Console.WriteLine("Ekmek(dilim) {0}", miktar5);
                    double miktar6 = sayi2 * KatSayi6;
                    Console.WriteLine("Soğan {0}", miktar6);
                    Console.WriteLine("Tuz(çay kaşığı) {0}", miktar6);
                    Console.WriteLine("Karabiber(çay kaşığı) {0}", miktar6);
                    double miktar7 = sayi2 * KatSayi7;
                    Console.WriteLine("Yumurta {0}", miktar7);
                    double miktar8 = sayi2 * KatSayi8;
                    Console.WriteLine("Maydanoz(dal) {0}", miktar8);

                    //Tarifi de ekrana yazdırıyoruz.
                    Console.WriteLine("Köfte için önce, bayat ekmek içini suyla ıslatıp sıkın. Kıymayı derin bir kaba alıp, soğanı rendeleyin.Üzerine ekmekleri, yumurtayı, ince kıyılmış maydanozu, karabiber ve tuzu ekleyip iyice yoğurun.Harçtan ceviz büyüklüğünde parçalar kopartıp yuvarlak veya oval köfteler hazırlayın.Kızgın sıvı yağda kızartıp, servis edin.");


                }
            }
        }
    }
}
