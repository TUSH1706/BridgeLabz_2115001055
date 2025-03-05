using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeDevices
{
    public class Device
    {
        public string deviceId;
        public string status;

        public Device(string deviceId, string status)
        {
            this.deviceId = deviceId;
            this.status = status;
        }

        public virtual void DisplayStatus()
        {
            Console.WriteLine($"Device ID: {deviceId}, Status: {status}");
        }
    }

    class Thermostat : Device
    {
        public int temperatureSetting;

        public Thermostat(string deviceId, string status, int temperatureSetting) : base(deviceId, status)
        {
            this.temperatureSetting = temperatureSetting;
        }

        public override void DisplayStatus()
        {
            Console.WriteLine("Thermostat...");
            base.DisplayStatus();
            Console.WriteLine($"Temperature Setting: {temperatureSetting}°C");
        }
    }
}
