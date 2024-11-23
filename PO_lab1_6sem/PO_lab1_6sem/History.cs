using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convertor
{
    public struct Record
    {
        private int p1;
        private int p2;
        private string number1;
        private string number2;
        public Record(int p1, int p2, string n1, string n2) 
        {
            this.p1 = p1;
            this.p2 = p2;
            this.number1 = n1;
            this.number2 = n2;
        }
        public string P1
        {
            get { return p1.ToString(); }
        }

        public string P2
        {
            get { return p2.ToString(); }
        }

        public string N1
        {
            get { return number1; }
        }

        public string N2
        {
            get { return number2; }
        }

        public override string ToString()
        {
            return $"P1: {this.p1}; N1: {this.number1} => P2: {this.p2}; N2: {this.number2}";
        }
    }
    public class History
    {
        private List<Record> L;
        //public Record this[int i] { }
        public void AddRecord(int p1, int p2, string n1, string n2)
        {
            this.L.Add(new Record(p1, p2, n1, n2));
        }
        public Record GetLastRecord()
        {
            return L.Last();
        }
        public void Clear()
        {
            this.L.Clear();
        }
        public int Count() 
        {
            return L.Count();
        }
        public History()
        {
            this.L = new List<Record>();
        }
    }
}
