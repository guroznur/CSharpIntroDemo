﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //naming convention
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Sepete Eklendi:" + urun.Adi);
            Console.WriteLine("Sepete Eklendi:" + urun.Aciklama);
           

        }
     
    }
}
