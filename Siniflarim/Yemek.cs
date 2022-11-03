using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siniflarim
{
    // adi, fiyati, kategori adi
    public class Yemek
    {
        public int Id { get; set; }
        public string Ad { get; set; }


        // bu private küçük fiyatı kullanmazsan alttaki get ve set'i kullanamazsın
        private int fiyat;
        // 10 tl'dan küçük bir fiyat girilemez
        // girilse default olarak o yemeğin fiyatını 10 tl yap
        public int Fiyat 
        {
            // get okumak için yani fiyatı ekrana yazdırabilmek için
            get
            {
                return fiyat;
            }

            // set ise o fiyatı değiştirmek için kullanıyoruz.
            set
            {
                if (value < 10 )
                {
                    value = 10;
                    fiyat = value;
                }

                else
                {
                    fiyat = value;
                }

            }


        }
        public int KategoriId { get; set; }

    }
}
