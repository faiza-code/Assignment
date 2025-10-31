using MakeenAssignment.Assignment4.SmartHomeControlCenter.Eunm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeenAssignment.Assignment4.SmartHomeControlCenter.Models
{
    
    public class Heater : ISmartDevice
    {
        public bool isOn = false;
        public void TurnOn()
        {
            isOn = true;
        }

        public void TurnOff()
        {
            isOn = false;
        }

        public void ShowStatus()
        {
            if (isOn)
            {
                Console.WriteLine("The Heater is On");
            }
            else
            {
                Console.WriteLine("The Heater is Off");
            }

        }

        public DeviceType GetDevice()
        {
            return DeviceType.Heater;
        }


    }
}
