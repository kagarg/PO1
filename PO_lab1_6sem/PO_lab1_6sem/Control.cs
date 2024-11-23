using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Convertor;

namespace Convertor
{
    class Control
    {
        //Основание системы сч. исходного числа. 
        private int pin = 10;
        //Основание системы сч. результата. 
        private int pout = 16;
        //Число разрядов в дробной части результата. 
        private int accuracy = 10;
        public History his = new History();
        public enum State { Editing, Converted }
        //Свойство для чтения и записи состояние Конвертера.
        public State St { get; set; }
        //Конструктор.
        public Control(int pin, int pout)
        {
            St = State.Editing;
            Pin = pin;
            Pout = pout;
        }
        //объект редактор
        public Editor ed = new Editor();
        //Свойство для чтения и записи основание системы сч. р1.
        public int Pin 
        {
            get { return pin; }
            set { pin = value; }
        }
        //Свойство для чтения и записи основание системы сч. р2.
        public int Pout 
        {
            get { return pout; }
            set { pout = value; }
        }
        //Выполнить команду конвертера.
        public string DoCmnd(string j)
        {
            if (j == "GO")
            {
                double r;
                if (pin != 10) // если входная сс != 10, то конвертируем число в 10сс
                    r = Conver_P_10.dval(ed.Number, (Int16)Pin);
                else
                    if (ed.Number.Contains('.'))// если входная сс 10 то просто запоминаем число
                    r = double.Parse(ed.Number, CultureInfo.InvariantCulture);
                else
                    r = int.Parse(ed.Number, CultureInfo.InvariantCulture);

                string res = Conver_10_P.Do(r, (Int32)Pout, acc()); // переводим в нужную сс
                St = State.Converted;
                his.AddRecord(Pin, Pout, ed.Number, res);
                return res;
            }
            else
            {
                St = State.Editing;
                return ed.DoEdit(j);
            }

        }
        //Точность представления результата.
        private int acc()
        {
            return (int)Math.Round(ed.Acc() * Math.Log(Pin) / Math.Log(Pout) + 0.5);
        }
    }
}

