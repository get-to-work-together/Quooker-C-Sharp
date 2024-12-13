using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LedDriver
{
    internal class LedDriver
    {
        // Enumerations
        public enum Pattern
        {
            Solid,
            Fast,
            Slow,
        }

        public enum BasicColor
        {
            Red,
            Green,
            Blue,
            Cyan,
            Magenta,
            Yellow
        }

        // attributes
        public bool On = false;
        public int Red = 0;
        public int Green = 0;
        public int Blue = 0;
        public Pattern BlinkingPattern = Pattern.Solid;
        public int PatternSpeed = 0;

        public struct Person
        {
            public string Name;
            public string Description;
        }
        List<Person> coll;

        // constructor
        public LedDriver()
        {
            Person p1 = new Person();
            p1.Name = "Peter";
            p1.Description = "m";
            coll.Add(p1);
        }

        // methods
        public void Send()
        {
        }

        public void TurnOn()
        {
            On = true;
        }
        public void TurnOff()
        {
            On = false;
        }

        public void SetColor(int red, int green, int blue)
        {
            Red = Math.Min(Math.Max(red, 0), 255);
            Green = Math.Min(Math.Max(green, 0), 255);
            Blue = Math.Min(Math.Max(blue, 0), 255);
        }
        public void SetColor(BasicColor color)
        {
            switch (color)
            {
                case BasicColor.Red:
                    SetColor(255, 0, 0);
                    break;
                case BasicColor.Green:
                    SetColor(0, 255, 0);
                    break;
                case BasicColor.Blue:
                    SetColor(0, 0, 255);
                    break;
                case BasicColor.Cyan:
                    SetColor(0, 255, 255);
                    break;
                case BasicColor.Magenta:
                    SetColor(255, 0, 255);
                    break;
                case BasicColor.Yellow:
                    SetColor(255, 255, 0);
                    break;
            }
        }

    }

}
