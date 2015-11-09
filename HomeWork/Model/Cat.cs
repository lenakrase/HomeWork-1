using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Cat
    {
        private string _name;
        public Cat(int Age1)
        {
            Age = Age1;
        }
        public string Name
        {
            get { return _name; }
            set
            {
                if (_name == null)
                    _name = value;
            }
        }
        public int Age { get; private set; }
        public int Health { get; private set; } = 5;
        public void Feed()
        {
            Health++;
        }
        public void Punish()
        {
            Health--;
        }

        public string CurrentColor
        {
            set { }
            get
            {
                if (Health < 5)
                {
                    return CatColor.SickColor;
                }
                else
                {
                    return CatColor.HeathyColor;
                }
            }
        }

    }

}

