using System;
using TelefonRehberUygulamasi;
class Program{
    public static void Main(string[] args){
        Console.WriteLine("Lütfen yapmak istediginiz islemi seciniz: ");
        Console.WriteLine("(1) Yeni numara kaydetmek (2) Varolan numarayi silmek (3) varolan numarayi guncellemek (4) Rehber Listelemek (5) Rehberde arama yapmak");
        int num = 0;;
        PhoneAction phoneAction = new PhoneAction();
        int count =0;

        while(true){
            count = 0;
            Console.WriteLine("(1) Yeni numara kaydetmek (2) Varolan numarayi silmek (3) varolan numarayi guncellemek (4) Rehber Listelemek (5) Rehberde arama yapmak");
        while(count == 0){
            num = Convert.ToInt32(Console.ReadLine());
            if(num.GetType().Name == "Int32" ){
                count = 1;
            }
            else{
                Console.WriteLine("Lütfen verilen aralikta numerik deger girin.");
            }
        }
        switch(num){
            case 1:
                phoneAction.AddUser();
                break;
            case 2:
                phoneAction.DeleteUser();
                break;
            case 3:
                phoneAction.UpdateUser();
                break;
            case 4:
                Console.WriteLine("AtoZ listeleme");
                phoneAction.KayitListeleAtoZ();
                Console.WriteLine("ZtoA listeme");
                phoneAction.KayitListeleZtoA();
                break;
            case 5:
                phoneAction.UserSearch();
                break;
            default:   
                break;
        }
      }
    }
}