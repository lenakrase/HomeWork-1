using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Cat
    {

        public Cat(int age)
        {
            Age = age;
            Color = new CatColor();
        }

        private string _name;
       
        /// <summary>
        /// read only property
        /// </summary>
        public int Age { get; }

        /// <summary>
        /// private Field
        /// </summary>
        private int _health = 5;

        /// <summary>
        /// write first Property
        /// </summary>
        public string Name
        {
            get { return _name; }
            set
            {
                if (_name == null)
                    _name = value;
            }
        }

        public void Feed()
        {
            _health++;
        }

        public void Punish()
        {
            _health--;
        }

        /// <summary>
        /// read/write property
        /// </summary>
        public CatColor Color { get; set; }

        /// <summary>
        /// Вычисляемое поле
        /// </summary>
        public string CurrentColor
        {
            get
            {
                if (_health < 5)
                {
                    return Color.SickColor;
                }
                else
                {
                    return Color.HeathyColor;
                }
            }
        }
    }
}

