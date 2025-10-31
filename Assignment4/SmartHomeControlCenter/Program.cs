using MakeenAssignment.Assignment4.SmartHomeControlCenter.Eunm;
using MakeenAssignment.Assignment4.SmartHomeControlCenter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeenAssignment.Assignment4.SmartHomeControlCenter
{
    public class Program
    {
        static void Main (string[] args)
        {
            SmartHome smarthome = new SmartHome();

            smarthome[DeviceType.Light].TurnOn();
            smarthome[DeviceType.Light].ShowStatus();


            smarthome[DeviceType.AC].TurnOn();
            smarthome[DeviceType.AC].ShowStatus();


            smarthome[DeviceType.Fan].TurnOff();
            smarthome[DeviceType.Fan].ShowStatus();


            smarthome[DeviceType.Heater].TurnOn();
            smarthome[DeviceType.Heater].ShowStatus();

        }
    }
}
