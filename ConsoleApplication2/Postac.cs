using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication2;

namespace ConsoleApplication2
{
    public abstract class Postac :Program
    {
        protected int _power { get; set; }
        protected int _healthPoints { get; set; }
        protected string _name { get; set; }
        private int pozX, pozY;
        public Image _pic;
        public int _pozX
        {
            get { return pozX; }
            set
            {
                /*if (value > 0 && value < 120 - _pic._width)
                    pozX = value;*/
                if (ek._screen[value, pozY] == ' ' && ek._screen[value+_pic._width-1,pozY]==' ' )
                    pozX = value;
                else if (pozX == 0)
                    pozX = value;
            }
        }
        public int _pozY
        {
            get { return pozY; }
            set
            {
                /*if (value > 0 && value < 30 - _pic._height - 1)
                    pozY = value;*/
                if (ek._screen[pozX, value] == ' '&&ek._screen[pozX,value+_pic._height-1]==' ')
                    pozY = value;
            }
        }

        /// <summary>
        /// Virtual constructor for one character 
        /// </summary>
        /// <param name="p">Power of character</param>
        /// <param name="hp">Health points</param>
        public Postac(int p,int hp)
        {
            _power = p;
            _healthPoints = hp;
        }
        /// <summary>
        /// Virtual constructor for one character 
        /// </summary>
        /// <param name="p">Power of character</param>
        /// <param name="hp">Health points</param>
        /// <param name="img">Image of character</param>
        public Postac(int p, int hp, Image img)
        {
            _power = p;
            _healthPoints = hp;
            _pic = img;
        }
        /// <summary>
        /// This should be invoke to properly create sprites
        /// </summary>
        /// <param name="p">power</param>
        /// <param name="hp">health points</param>
        /// <param name="img">picture in ascii whatever</param>
        /// <param name="x">X coordinates</param>
        /// <param name="y">Y coordinates</param>
        public Postac(int p, int hp, Image img,int x,int y)
        {
            _power = p;
            _healthPoints = hp;
            _pic = img;
            _pozX = x;
            _pozY = y;
        }
        public virtual void attack()
        {

        }


        public void changeCoordinates(int x, int y)
        {
            _pozX = x;
            _pozY = y;
        }

    }
}
