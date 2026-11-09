using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Text;

namespace _4laba_norml
{
    internal class Studdent
    {
        private string name = string.Empty;
        private string group = string.Empty;
        private Dictionary<string, double> bal = new Dictionary<string, double>();

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Group
        {
            get { return group; }
            set { group = value; }
        }

        public Dictionary<string, double> Bal
        {
            get { return bal; }
            set { bal = value; }
        }

        public double SessionCalculate(double a, double b, double c, double d)
        {
            double evl = (a + b + c + d) / 4;
            return evl;
        }

        public string SetStudett(double evl)
        {
           if (evl < 50)
           {
               return $"Студент {name} из группы {group} ОТЧИСЛЕН";
           }
           else if (evl >= 50 && evl < 70)
           {
               return $"Студент {name} из группы {group} имеет удовлетворительную успеваемость.";
           }
            else if (evl >= 70 && evl < 90)
            {
                return $"Студент {name} из группы {group} имеет хорошую успеваемость.";
            }
            else
            {
                return $"Студент {name} из группы {group} имеет отличную успеваемость.";
            }
        }
    }
}
