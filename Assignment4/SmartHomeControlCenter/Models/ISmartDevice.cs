using MakeenAssignment.Assignment4.SmartHomeControlCenter.Eunm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeenAssignment.Assignment4.SmartHomeControlCenter.Models
{
    public interface ISmartDevice
    {
        
        public void TurnOn();
        public void TurnOff();
        public void ShowStatus();
        public DeviceType  GetDevice();
    }
}
