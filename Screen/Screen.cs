using System;

namespace Screen
{
    class Screen
    {
        public String Firm { get; set; }

        private int _type;
        public String Type
        {
            get
            {
                if (this._type == 0) return "String"; else return "enum";
            }

            set
            {
                this._type = Convert.ToInt32(value);
            }
        }

        public float Diagonal { get; set; }

        public Screen()
        {
            this.Firm = "";
            this.Type = "0";
            this.Diagonal = 0;
        }

        public void Input()
        {
            Console.Write("Input manufacter of Screen: "); this.Firm = Console.ReadLine();
            Console.Write("Input type of screen 0 - String, 1 - enum: "); this.Type = Console.ReadLine();
            Console.Write("Input diagonal of screen: "); this.Diagonal = (float)Convert.ToDouble(Console.ReadLine());
        }

        public void Print()
        {
            Console.WriteLine($"Firm: { this.Firm }");
            Console.WriteLine($"Type: { this.Type }");
            Console.WriteLine($"Diagonal: { this.Diagonal }");
        }

    }
}