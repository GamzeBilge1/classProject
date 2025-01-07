using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classProject
{
    public class Person
    { 
        //kişi ad , soyad ve doğum tarihi bilgileri için fieldlar
        private string ad;
        private string soyad;
        private DateTime dogumtarihi;

        public string Ad // "ad" fieldını dışarıdan erişebilir yapmak için bir property
        {
            get
            {
                return ad;
            }

            set
            {
                ad = value;
            }
        }

        public string Soyad // "soyad" fieldını dışarıdan erişebilir yapmak için bir property
        {
            get
            {
                return soyad;
            }
            set
            {
                soyad = value;
            }
        }

        public DateTime DogumTarihi // "doğum tarihi" fieldını dışarıdan erişebilir yapmak için bir property
        {
            get
            {
                return dogumtarihi;
            }

            set
            {
                dogumtarihi = value;
            }
        }
    }
}

