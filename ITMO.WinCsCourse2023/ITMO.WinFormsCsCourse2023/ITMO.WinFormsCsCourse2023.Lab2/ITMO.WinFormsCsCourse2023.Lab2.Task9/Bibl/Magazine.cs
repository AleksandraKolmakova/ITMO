using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ITMO.WinFormsCsCourse2023.Lab2.Task6
{
    class Magazine : Item, IPubs
    {
        private String volume;    // том
        private int number;        // номер
        private String title;       // название
        private int year;      // дата выпуска

        public bool IfSubs { get; set; } // подписка на журнал

        public Magazine(String volume, int number, String title, int year, long invNumber, bool taken)
            : base(invNumber, taken)
        {
            this.volume = volume;
            this.number = number;
            this.title = title;
            this.year = year;
        }
        public Magazine()
        { }


        public override void Return()    // операция "вернуть"
       {
           taken = true;
       }

        // реализация интерфейса

      
      public void Subs()
      {
            IfSubs = true;  // действия при оформлении подписки на журнал
      }


       public override string ToString()
       {
           if (IfSubs)
           return "\nЖурнал:\nНазвание: " + title + "\nТом: " + volume +
           "\nНомер: " + number + "\nГод выпуска: " + year + " p.\n"+ base.ToString() + "\nПодписка оформлена";
           else
               return "\nЖурнал:\nНазвание: " + title + "\nТом: " + volume +
           "\nНомер: " + number + "\nГод выпуска: " + year + " p.\n" + base.ToString() + "\nПодписка не оформлена"; ;
       }
    }
}
