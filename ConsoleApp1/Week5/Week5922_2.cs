using System;
using System.IO.Compression;

namespace ConsoleApp1{
    public interface ISmartDevice{
        void TurnOn();
        void TurnOff();
        void GetStatus();
    }

    public class SmartLight : ISmartDevice{
        bool toggled=false;
        public void TurnOn(){
            Console.WriteLine("SmartLight is now ON.");
        }

        public void TurnOff(){
            Console.WriteLine("SmartLight is now OFF.");
        }

        public void GetStatus(){
            Console.WriteLine("SmartLight is currently ON/OFF");
        }
    }

    public class SmartThermostat : ISmartDevice{
        bool toggled=false;
        public void TurnOn(){
            Console.WriteLine("Smart Thermostat is now ON. Temperature is set to 22°C.");
            toggled=false;
        }

        public void TurnOff(){
            Console.WriteLine("Smart Thermostat is now OFF.");
        }

        public void GetStatus(){
            Console.WriteLine("Smart Thermostat is currently ON/OFF");
        }
    }
}