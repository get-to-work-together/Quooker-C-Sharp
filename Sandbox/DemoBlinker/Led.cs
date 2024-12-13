using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoBlinker
{
    internal class Led
    {
        public enum LedColor
        {
            Green,
            Orange,
            Red,
            Blue
        }

        bool isOn = false;
        bool isBlinking = false;
        int timeBlinkOn = 500; // ms
        int timeBlinkOff = 500; // ms
        LedColor ledColor = LedColor.Green;
        Control control;

        public Led(Label control)
        {
            this.control = control;
        }

        public void SetOn()
        {
            isOn = true;
            control.Visible = true;
        }
        public void SetOff()
        {
            isOn = false;
            control.Visible = false;
        }
        public void StartBlinking(int tOn = 500, int tOff = 500)
        {
            isBlinking = true;
            timeBlinkOn = tOn;
            timeBlinkOff = tOff;
        }
        public void StopBlinking()
        {
            isBlinking = false;
        }
        public void SetColor(LedColor color)
        {
            ledColor = color;
            switch (ledColor)
            {
                case LedColor.Green:
                    control.ForeColor = Color.Green;
                    break;
                case LedColor.Orange:
                    control.ForeColor = Color.Orange;
                    break;
                case LedColor.Red:
                    control.ForeColor = Color.Red;
                    break;
                case LedColor.Blue:
                    control.ForeColor = Color.Blue;
                    break;
            }
        }
        public void Driver()
        {
            while (isBlinking)
            {
                SetOn();
                Thread.Sleep(timeBlinkOn);
                SetOff();
                Thread.Sleep(timeBlinkOff);
            }
        }
    }
}
