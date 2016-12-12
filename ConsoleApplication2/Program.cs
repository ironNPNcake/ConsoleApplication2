using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
//hello hi
namespace ConsoleApplication2
{
    public class Program
    {
        public static ekran ek = new ekran();
        public static Image hero = new Image("Hero.txt");
        public static List<Postac> sprites = new List<Postac>();
        public static Postac mainHero = new Character(100, 100, hero, 10, 10);
        private static int _frame;

        public static void Main(string[] args)
        {
            sprites.Add(mainHero);
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.SetWindowSize(120, 30);
            Console.SetBufferSize(120, 30);
            Console.CursorVisible = false;

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            //pierwszy koment
            /*drugi   komentarz*/


            fightFrame a = new fightFrame();


            Timer time = new Timer(100);
            time.Elapsed += new ElapsedEventHandler(animate);
            time.Start();
            //while (true) { }
            ek.drawCharacter(mainHero);
            ek.show();

            

            Update();
            
        }
        public static void Update()
        {
            while (true)
            {
                    ConsoleKey a = Console.ReadKey(true).Key;
                if ( a == ConsoleKey.W)
                {
                    ek.clearCharacter(mainHero);
                    mainHero._pozY -= 1;
                    ek.drawCharacter(mainHero);
                    //ek.show();
                }
                else if (a == ConsoleKey.S)
                {
                    ek.clearCharacter(mainHero);
                    mainHero._pozY += 1;
                    ek.drawCharacter(mainHero);
                    //ek.show();
                }
                else if ( a == ConsoleKey.A)
                {
                    ek.clearCharacter(mainHero);
                    mainHero._pozX -= 1;
                    ek.drawCharacter(mainHero);
                    //ek.show();
                }
                else if (a == ConsoleKey.D)
                {
                    ek.clearCharacter(mainHero);
                    mainHero._pozX += 1;
                    ek.drawCharacter(mainHero);
                    //ek.show();
                }

                foreach(Postac i in sprites)
                {
                    ek.clearCharacter(i);
                    ek.drawCharacter(i);
                }
            }
        }
        public static void animate(object sender, EventArgs e)
        {
            if (_frame % 8 == 0)
            {
                mainHero._pic._img =
                    mainHero._pic._img.Substring(2, 1)
                    + mainHero._pic._img.Substring(1, 1)
                    + mainHero._pic._img.Substring(0, 1)
                    + mainHero._pic._img.Substring(5, 1)
                    + mainHero._pic._img.Substring(4, 1)
                    + mainHero._pic._img.Substring(3, 1)
                    + mainHero._pic._img.Substring(6, 1)
                    + '\u2569' 
                    + mainHero._pic._img.Substring(8);
            }
            else if(_frame %8 == 4)
            {
                //mainHero._pic._img = mainHero._pic._img.Substring(0, 7) + '\u2568' + mainHero._pic._img.Substring(8);
                mainHero._pic._img =
                    mainHero._pic._img.Substring(2, 1)
                    + mainHero._pic._img.Substring(1, 1)
                    + mainHero._pic._img.Substring(0, 1)
                    + mainHero._pic._img.Substring(5, 1)
                    + mainHero._pic._img.Substring(4, 1)
                    + mainHero._pic._img.Substring(3, 1)
                    + mainHero._pic._img.Substring(6, 1)
                    + '\u2568'
                    + mainHero._pic._img.Substring(8);
                
            }
            ek.drawCharacter(mainHero);
            _frame++;
            ek.show();
        }
    }
}
