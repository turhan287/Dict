using System;
using System.Collections.Generic;
using System.Text;

namespace GenerecisIntro
{
    class MyDict<T>
    {
        T[] items;
        public MyDict() //constructor oluşturduk ctor tab tab yaz. bir class new lendiğinde çalışan satıra const denir.
        {                // MyList class açılınca otomatik const da çalışır.
            items = new T[0];// 0 elemanlı bir dizi oluşturduk.

        }
        public void Add(T item)
        {
            T[] tempArray = items;  // dizideki elemanlar kaybolmasın diye geçici dizi olşuturduk referansı temparraye atadık.
            items = new T[items.Length+1]; // items dizisinin eleman sayısını 1 artırdık dinamik dizi oluşturduk.
            for (int i = 0; i < tempArray.Length; i++)// items dizisi 1 arttı ve eskiden temparraye atılan değerleri geri alındı.
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = item;     //Add classta gelen item son elemana atandı.   
        }
     
    
    }
}
