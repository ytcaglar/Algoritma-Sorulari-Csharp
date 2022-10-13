using System;

namespace odev1_algoritma_sorulari
{
    class Program
    {
        static void Main(string[] args)
        {
          // Soru 1 - Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). 
          // Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş 
          // olduğu sayılardan çift olanlar console'a yazdırın.

        //   Console.Write("Bir sayı dizisi oluşturulacaktır.\nLütfen kaç elemanlı olacaksa eleman sayısını giriniz: ");
        //   int n = int.Parse(Console.ReadLine());
        //   int[] dizi = new int[n];
        //   int i = 0;
        //   while(n!=i){
        //     Console.Write("Lütfen dizinin {0}.elemanını giriniz: ",i+1);
        //     dizi[i] = int.Parse(Console.ReadLine());
        //     i++; 
        //   }
        //   Console.WriteLine("Girmiş olduğunuz sayı dizisinde ki çift olan sayılar:");
        //   foreach(var item in dizi){
        //     if (item % 2 == 0)
        //         Console.WriteLine(item);
        //     }
            

           // Soru 2- Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). 
           //Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit 
           // yada tam bölünenleri console'a yazdırın.
        //    Console.Write("Bir sayı dizisi oluşturulacaktır.\nLütfen kaç elemanlı olacaksa eleman sayısını giriniz: ");
        //    int n = int.Parse(Console.ReadLine());
        //    int[] dizi = new int[n];
        //    int i = 0;
        //    while(n!=i){
        //    Console.Write("Lütfen dizinin {0}.elemanını giriniz: ",i+1);
        //    dizi[i] = int.Parse(Console.ReadLine());
        //    i++; 
        //   }
        //    Console.Write("Girmiş olduğunuz sayı dizisindeki elemanlara mod alma işlemi uygulancaktır.\nMod alma işlemi için bir mod sayısı giriniz: ");

        //    int m = int.Parse(Console.ReadLine());

        //    foreach(var item in dizi){
        //     if (item % m == 0)
        //         Console.WriteLine(item);
        //     }

            // Soru 3 - Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). 
            // Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri 
            // sondan başa doğru console'a yazdırın.

        //     Console.Write("Bir string dizisi oluşturulacaktır.\nLütfen kaç elemanlı olacaksa eleman sayısını giriniz: ");
        //     int n = int.Parse(Console.ReadLine());
        //     string[] dizi = new string[n];
        //     int i = 0;
        //     while(n!=i){
        //     Console.Write("Lütfen dizinin {0}.elemanını giriniz: ",i+1);
        //     dizi[i] = Console.ReadLine();
        //     i++; 
        //    }
        //    Array.Reverse(dizi);

        //    foreach (var item in dizi)
        //    {
        //         Console.WriteLine(item);
        //    }

            // Soru 4 - Bir konsol uygulamasında kullanıcıdan bir cümle yazmasını isteyin. Cümledeki toplam kelime ve 
            // harf sayısını console'a yazdırın.

            Console.Write("Lütfen bir cümle girişi yapınız: ");
            string cumle =  Console.ReadLine();
            string[] kelime = cumle.Split(" ");
            Console.WriteLine("Cümledeki toplam kelime sayısı: {0}\nCümledeki toplam harf sayısı: {1}",kelime.Count(),cumle.Count());

    }
        }
       
}

