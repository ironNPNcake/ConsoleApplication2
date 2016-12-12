using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;


namespace ConsoleApplication2
{
    public class Image
    {
        public string _name { get; private set; }
        public int _height { get; private set; }
        public int _width { get; private set; }
        public string _img { get; set;}
        private char[] _buffer = new char[3] ;

        /// <summary>
        /// Create image
        /// </summary>
        /// <param name="name">name of the file in default location</param>
        public Image(string name)
        {
            try
            {
                StreamReader file = new StreamReader(name);
                _name = name;
                file.Read(_buffer, 0, 3);
                _height = (_buffer[0] - 48) * 100 + (_buffer[1] - 48) * 10 + (_buffer[2] - 48) * 1;
                file.Read(_buffer, 0, 3);
                _width = (_buffer[0] - 48) * 100 + (_buffer[1] - 48) * 10 + (_buffer[2] - 48) * 1;
                _img = file.ReadToEnd();
                file.Close();

            }
            catch(Exception ex )
            {

                MessageBox.Show( ex.Message);
            }
        }
        /// <summary>
        /// Create image
        /// </summary>
        /// <param name="path">Path to the file</param>
        /// <param name="name">name of the file</param>
        public Image(string path, string name)
        {
            try
            {
                StreamReader file = new StreamReader(path + "\\" + name);
                _name = name;
                file.Read(_buffer, 0, 3);
                _height = (_buffer[0] - 48) * 100 + (_buffer[1] - 48) * 10 + (_buffer[2] - 48) * 1;
                file.Read(_buffer, 0, 3);
                _width = (_buffer[0] - 48) * 100 + (_buffer[1] - 48) * 10 + (_buffer[2] - 48) * 1;
                _img = file.ReadToEnd();
                file.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

    }
}
