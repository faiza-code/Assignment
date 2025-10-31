using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeenAssignment.Assignment4.SmartHomeControlCenter.Models
{
   
    public class Ac : ISmartDevice
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
                Console.WriteLine("The Ac is On");
            }
            else
            {
                Console.WriteLine("The Ac is Off");
            }

        }


        public DeviceType GetDevice()
        {
            return DeviceType.AC;
        }



    }
}
