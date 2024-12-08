using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Processor
    {
        // attributes
        private double invoer;
        private double stored;
        private double display;
        private string operation;

        // constructor
        public Processor()
        {
            invoer = 0;
            stored = 0;
            display = 0;
            operation = "";
        }

        // methods
        public string getDisplay()
        {
            return $"{display:0.#######}";
        }

        public void keyPressed(string key)
        {
            switch (key)
            {
                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                case "0":
                    invoer = invoer * 10 + int.Parse(key);
                    display = invoer;
                    break;
                case "+":
                case "-":
                case "*":
                case "/":
                case "=":
                    calculate();
                    operation = key;
                    invoer = 0;
                    display = stored;
                    break;
                case "C":
                    invoer = 0;
                    stored = 0;
                    operation = "";
                    display = stored;
                    break;
            }
        }

        private void calculate()
        {
            switch (operation) {
                case "+":
                    stored += invoer;
                    break;
                case "-":
                    stored -= invoer;
                    break;
                case "*":
                    stored *= invoer;
                    break;
                case "/":
                    stored /= invoer;
                    break;
                case "=":
                case "":
                    stored = display;
                    break;
                }
            }
        }

    }
