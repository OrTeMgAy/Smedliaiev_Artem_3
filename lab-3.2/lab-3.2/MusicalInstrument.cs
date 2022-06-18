using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3._2
{
    internal class MusicalInstrument
    {
        public string name; //назва інструменту
        public int type;//тип (духовий, клавішний і т.д.)
        public bool condition;//стан (зламаний/робочий)
        public bool belong;//чи належить комусь чи ні
        public MusicalInstrument(string name, int type, bool condition, bool belong)
        {
            this.name = name;
            this.type = type;
            this.condition = condition;
            this.belong = belong;
        }
    }
}
