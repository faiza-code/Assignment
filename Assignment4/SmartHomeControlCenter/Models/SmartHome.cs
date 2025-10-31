using MakeenAssignment.Assignment4.OnlineCourseEnrollmentSystemProject.Enum;
using MakeenAssignment.Assignment4.SmartHomeControlCenter.Eunm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeenAssignment.Assignment4.SmartHomeControlCenter.Models
{
    public class SmartHome
    {
        public List<ISmartDevice> Devices = new List<ISmartDevice>();

        public void AddDevices(ISmartDevice device)
        {
            Devices.Add(device);
        }
        public SmartHome()
        {

            Devices.Add(new Light());
            Devices.Add(new Fan());
            Devices.Add(new AC());
            Devices.Add(new Heater());
        }


        public ISmartDevice this[DeviceType deviceType]
        {
            get
            {
                foreach (var element in Devices)
                {
                    if (element.GetDevice() == deviceType)
                    {
                        return element;
                    }
                }
                return null;
            }







        }
    }
}
