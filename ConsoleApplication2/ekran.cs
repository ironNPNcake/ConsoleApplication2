using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//I want to live free

namespace ConsoleApplication2
{
    /// <summary>
    /// This class is used for manipulate things that happen on screen
    /// </summary>
    public class ekran
    {
        public char[,] _screen = new char[120,30];
        private string _sign = "                                                                                          By JS All rights reserved";

        public ekran()
        {
            clear();
        }


        private void clear()
        {
            for(int i =0;i<29;i++)
            {
                for(int j=0;j<120;j++)
                {
                    _screen[j,i] = ' ';
                }
            }
            drawFrame();
            //show();
        }
        /// <summary>
        /// fill entire screen with custom character
        /// </summary>
        /// <param name="a">character to fill the screen</param>
        public void fill(char a)
        {
            for (int i = 0; i < 30; i++)
            {
                for (int j = 0; j < 120; j++)
                {
                    _screen[j, i] = a;
                }
            }
            //show();
        }
        /// <summary>
        /// Show buffer on screen
        /// </summary>
        public void show()
        {
            // Console.Clear();
            Console.SetCursorPosition(0, 0);
            for(int i = 0;i<_sign.Length;i++)
            _screen[i, 29] = _sign[i];
            for(int i =0;i<29;i++)
            {
                for (int j = 0; j < 120; j++)
                {
                        Console.Write(_screen[j, i]);
                }
            }
            Console.Write(_sign); //this is the way to write sign without console auto scroll
            Console.SetCursorPosition(0,0);
        }
        /// <summary>
        /// Change string using X,Y coordinates
        /// </summary>
        /// <param name="x">Cursor X position</param>
        /// <param name="y">Cursor Y position</param>
        /// <param name="a">string to change</param>
        public void change(int x,int y,string a)
        {
            for (int i = 0; i < a.Length; i++)
                _screen[x+i, y] = a[i];
            //show();
        }
        /// <summary>
        /// Change single character using X,Y coordinates
        /// </summary>
        /// <param name="x">Cursor X position</param>
        /// <param name="y">Cursor Y position</param>
        /// <param name="a">character value to change</param>
        public void change(int x, int y, char a)
        {
            _screen[x, y] = a;
            //show();
        }
        /// <summary>
        /// Change string using X,Y coordinates and clear the rest line
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="a"></param>
        /// <param name="line">If true the end of line will be clear</param>
        public void change(int x, int y, string a,bool line)
        {
            change(x, y, a);
            if(line)
            {
                for (int i = x+a.Length; i < 120; i++)
                    _screen[i, y] = ' ';
            }
            //show();
        }

        /// <summary>
        /// Draw picture on screen
        /// </summary>
        /// <param name="x">Cursor X coordinate</param>
        /// <param name="y">Cursor Y coordinate</param>
        /// <param name="width">width of the picture</param>
        /// <param name="height">height of the picture</param>
        /// <param name="a">picture array</param>
        public void draw(int x, int y, int width, int height, char[] a)
        {
            for(int i =0;i<height;i++)
            {
                for (int j=0;j<width;j++)
                {
                    _screen[x+j, y+i] = a[j+ i * height];

                }
            }
            //show();
        }


        public void drawCharacter(int x, int y, Image a)
        {
            for (int i = 0; i < a._height; i++)
            {
                for (int j = 0; j < a._width; j++)
                {
                    _screen[x + j, y + i] = a._img[j + i * a._height];

                }
            }
            //show();
        }
        public void clearCharacter(Postac a)
        {
            //clear previous character
            for (int i = 0; i < a._pic._height; i++)
            {
                for (int j = 0; j < a._pic._width; j++)
                {
                    _screen[a._pozX + j, a._pozY + i] = ' ';

                }
            }
        }
        public void drawCharacter(Postac a)
        {

            for (int i = 0; i <  a._pic._height; i++)
            {
                for (int j = 0; j < a._pic._width; j++)
                {
                    _screen[a._pozX + j, a._pozY + i] = a._pic._img[j + i * a._pic._height];

                }
            }
            //show();
        }
        /// <summary>
        /// Draw picture on screen
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="a"></param>
        public void drawPict(int x,int y, Image a)
        {
            for(int i =0;i<a._height;i++)
            {
                for (int j = 0; j < a._width; j++)
                {
                    _screen[x+j, y+i] = a._img[i * a._height + j];
                }
            }
            //show();
        }
        /// <summary>
        /// draw Frame for game
        /// </summary>
        public void drawFrame()
        {
            _screen[0, 0] = ('\u2554');                                     //left up corner
            for (int i = 0; i < 118; i++) _screen[i + 1, 0] = ('\u2550');   //up border
            _screen[119, 0] = ('\u2557');                                   //right up corner
            for (int i = 0; i < 27; i++) _screen[0, i + 1] = ('\u2551');    //left border
            for (int i = 0; i < 27; i++) _screen[119, i + 1] = ('\u2551');  //right border
            _screen[0, 28] = ('\u255A');                                    //left down corner
            _screen[119, 28] = ('\u255D');                                  //right down corner
            for (int i = 0; i < 118; i++) _screen[i + 1, 28] = ('\u2550');  //down border
        }

        public void changeCharColor(int x, int y, ConsoleColor a)
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = a;
            Console.Write(_screen[x, y]);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public void drawMap(Image map)
        {
            //for(int i =0;i<)
        }
    }
}
