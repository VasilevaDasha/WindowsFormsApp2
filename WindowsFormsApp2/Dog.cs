using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
namespace WindowsFormsApp2
{
    class Dog
    {
        private string Dog_name;
        public Dog(string n) { Dog_name = n; } // конструктор
        public string getDogName() { return Dog_name; }
        public void Dog_gav(string sound_filename)
        {
            // будем проигрывать звук из файла sound_filename
            SoundPlayer sp = new SoundPlayer();
            sp.SoundLocation = sound_filename;
            sp.Load();
            sp.Play();
        }
    }
}
