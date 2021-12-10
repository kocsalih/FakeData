﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeData1
{
    public class Database
    {
        public List<Musteri> musteriler = new List<Musteri>();
        public Database()
        {

        }

        public List<Musteri> musteriListele()
        {
            for (int i = 1; i < 1001; i++)
            {
                Musteri Temp = new Musteri();

                Temp.id = 1000 + i;
                Temp.isim = FakeData.NameData.GetFirstName();
                Temp.soyisim = FakeData.NameData.GetSurname();
                Temp.tamAdi = $"{Temp.isim} {Temp.soyisim}";
                Temp.emailAdres = FakeData.NetworkData.GetEmail(Temp.isim, Temp.soyisim);
                Temp.telefonNumarası = FakeData.PhoneNumberData.GetPhoneNumber();
                Temp.il = FakeData.PlaceData.GetCity();
                Temp.ilce = FakeData.PlaceData.GetCounty();
                Temp.adres = FakeData.PlaceData.GetAddress();
                musteriler.Add(Temp);
            }
            return musteriler;
        }
    }
}
