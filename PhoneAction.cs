using System;
using System.Security.Principal;
namespace TelefonRehberUygulamasi{
    class PhoneAction{
        List<NumaraKaydet> numaraKaydetList = new List<NumaraKaydet>();
        
        public PhoneAction(){
            numaraKaydetList.Add(new NumaraKaydet("yalcin","mrl",0234234));
            numaraKaydetList.Add(new NumaraKaydet("Ayse","yildirim",0524234));
            numaraKaydetList.Add(new NumaraKaydet("Buse","yilmaz",999843));
            numaraKaydetList.Add(new NumaraKaydet("Ahmet","tan",345212));
            numaraKaydetList.Add(new NumaraKaydet("aylin","koc",0234253));
        }

        public void AddUser(){
            Console.WriteLine("Lutfen kisi adinizi giriniz: ");
            string name = Console.ReadLine();
            Console.WriteLine("Lutfen kisi soyadinizi giriniz: ");
            string surname = Console.ReadLine();
            Console.WriteLine("Lutfen kisi numarasini giriniz: ");
            int num = Convert.ToInt32(Console.ReadLine());

            NumaraKaydet newNumaraKaydet = new NumaraKaydet(name,surname,num);
            numaraKaydetList.Add(newNumaraKaydet);
            Console.WriteLine("Kayit basarili");
        }
        public void DeleteUser(){
            Console.WriteLine("lütfen kisinin ismini veya soyismini giriniz: ");
            string delNameSurname = Console.ReadLine();

            for(int i = 0;i< numaraKaydetList.Count;i++){
                if(numaraKaydetList[i].Isim.Equals(delNameSurname) || numaraKaydetList[i].Soyisim.Equals(delNameSurname)){
                    Console.WriteLine(numaraKaydetList[i].Isim + " Adli kisi silinecektir onayliyor musunuz (1) onayliyorsaniz (0) onaylamiyorsaniz tuslayin");
                    int onayVal = int.Parse(Console.ReadLine());
                    if(onayVal == 1){
                        Console.WriteLine(numaraKaydetList[i].Isim + " kisi silinmistir.");
                        numaraKaydetList.RemoveAt(i);
                        break;
                    }
                    else{
                        break;
                    }
                }
                 if(i == numaraKaydetList.Count -1){
                        Console.WriteLine("Aranan kisi rehberde bulunamadi. tekrar denemek icin (1) sileme isleminden cikmak icin (0) basiniz");
                        int onayVal = int.Parse(Console.ReadLine());
                        if(onayVal == 1){
                            DeleteUser();
                        }
                        else{
                            break;
                        }
                    }
            }
        }
        public void UpdateUser(){
            Console.WriteLine("Lutfen kisinin ismini veya soyisimini giriniz: ");
            string delNameSurname = Console.ReadLine();

            for(int i = 0;i<numaraKaydetList.Count;i++){
                if(numaraKaydetList[i].Isim.Equals(delNameSurname) || numaraKaydetList[i].Soyisim.Equals(delNameSurname)){
                    Console.WriteLine("(1) Adi guncelle (2) Soyadi guncelle (3) numarayi guncelle (0) guncellemekten vazgec");
                    int onayVal = int.Parse(Console.ReadLine());
                    if(onayVal == 1){
                        Console.WriteLine("Lutfen yeni isim giriniz: ");
                        string newName= Console.ReadLine();
                        Console.WriteLine(numaraKaydetList[i].Isim + " adli kisi ");
                        numaraKaydetList[i].Isim = newName;
                        Console.WriteLine(numaraKaydetList[i].Isim + " olarak guncellenmistir.");
                    }
                    if(onayVal == 2){
                        Console.WriteLine("Lutfen yeni soyisim giriniz: ");
                        string newSurName= Console.ReadLine();
                        Console.WriteLine(numaraKaydetList[i].Soyisim + " adli kisi ");
                        numaraKaydetList[i].Soyisim = newSurName;
                        Console.WriteLine(numaraKaydetList[i].Soyisim + " olarak guncellenmistir.");
                    }
                    if(onayVal == 3){
                        Console.WriteLine("Lutfen yeni numara giriniz: ");
                        int newNum= int.Parse(Console.ReadLine());
                        Console.WriteLine(numaraKaydetList[i].TelNo + " adli kisi ");
                        numaraKaydetList[i].TelNo = newNum;
                        Console.WriteLine(numaraKaydetList[i].TelNo + " olarak guncellenmistir.");
                    }
                    else{
                        break;
                    }
                }
                if(i == numaraKaydetList.Count -1){
                    Console.WriteLine("Aranan kisi rehberde bulunamamistir. tekrar denemek icin (1) cikmak icin (0) giriniz");
                    int onayVal = int.Parse(Console.ReadLine());
                    if(onayVal == 1){
                        UpdateUser();
                    }
                    else{
                        break;
                    }
                }
            }
        }

        public void KayitListeleAtoZ(){
            var sortedList = numaraKaydetList.OrderBy(value =>value.Isim);
            foreach(var kisiler in sortedList){
                Console.WriteLine("Kisi adi : " + kisiler.Isim);
                Console.WriteLine("soyisim : "+ kisiler.Soyisim);
                Console.WriteLine("Numarasi : " + kisiler.TelNo.ToString());
            }
        }
        public void KayitListeleZtoA(){
            var sortedList = numaraKaydetList.OrderBy(value=>value.Isim).Reverse();
            foreach(var kisiler in sortedList){
                Console.WriteLine("Kisi adi : " + kisiler.Isim);
                Console.WriteLine("soyisim : "+ kisiler.Soyisim);
                Console.WriteLine("Numarasi : " + kisiler.TelNo.ToString());    
            }
        }
        public void UserSearch(){
            Console.WriteLine("Lutfen aramak istediginiz kisinin adini veya soyadini giriniz:");
            string isimSoyisim = Console.ReadLine();

            for(int i = 0;i<numaraKaydetList.Count;i++){
                if(numaraKaydetList[i].Isim.Equals(isimSoyisim) || numaraKaydetList[i].Soyisim.Equals(isimSoyisim)){
                    Console.WriteLine("Kişinin adı: " + numaraKaydetList[i].Isim);
                    Console.WriteLine("Kişinin adı: " + numaraKaydetList[i].Soyisim);
                    Console.WriteLine("Kişinin adı: " + numaraKaydetList[i].TelNo);
                    break;
                }
                if(i == numaraKaydetList.Count -1){
                    Console.WriteLine("Aranan kisi bulunamadi");
                    break;
                }
            }
        }
    }
}