using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class Character :Postac
    {

        public Character(int p, int hp, Image img, int x,int y)
            :base(p,hp,img,x,y)
        {
            this._name = "Human";
        }
        public override void attack()
        {

            base.attack();
        }
    }
}
