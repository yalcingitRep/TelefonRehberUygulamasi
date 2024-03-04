using System;
namespace TelefonRehberUygulamasi{
    class NumaraKaydet{

        string isim;
        string soyisim;
        int telNo;

        static NumaraKaydet(){
            
        }
        public NumaraKaydet(string isim, string soyisim,int telNo){
            this.isim = isim;
            this.soyisim = soyisim;
            this.telNo = telNo;
        }



        public string Isim{
            get{
                return isim;
            }
            set{
                isim = value;
            }
        }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int TelNo { get => telNo; set => telNo = value; }

        public void Kaydet(){

        }
    }
}