using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;

        //constructor bir class new lendiğinde çalışan bloğa constuctor denir
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items; //gecicidizi
            items = new T[items.Length + 1]; // newlendiği için yeni referans numarası aldığı için öncesinde geçicidiziye atıyoruz.
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;
            
        }

    }
}
