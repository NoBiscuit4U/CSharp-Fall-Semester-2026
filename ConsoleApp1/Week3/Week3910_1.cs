using System;

namespace ConsoleApp1{
    class Week3910_1{
        private int num;
        public int Number{
            get {return num;}
            set {num=(value>0)?value:Math.Abs(value);}
        }
    }
}