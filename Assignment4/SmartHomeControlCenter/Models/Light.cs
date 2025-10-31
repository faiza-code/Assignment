using MakeenAssignment.Assignment4.SmartHomeControlCenter.Eunm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MakeenAssignment.Assignment4.SmartHomeControlCenter.Models
{
    public class Light : ISmartDevice
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
                Console.WriteLine("The Light is On");
            }
            else
            {
                Console.WriteLine("The Light is Off");
            }

        }

        public DeviceType GetDevice()
        {
            return DeviceType.Light;
        }


    }
}