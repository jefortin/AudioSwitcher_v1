﻿using AudioSwitcher.AudioApi;

namespace FortyOne.AudioSwitcher
{
    public class AudioDeviceUIWrapper
    {
        private readonly IDevice Device;

        public AudioDeviceUIWrapper(IDevice ad)
        {
            Device = ad;
        }

        public string DeviceName
        {
            get { return Device.ShortName; }
        }

        public string DeviceDescription
        {
            get { return Device.Description; }
        }

        public string State
        {
            get
            {
                switch (Device.State)
                {
                    case DeviceState.Active:
                        return "Ready";
                    case DeviceState.Disabled:
                        return "Disabled";
                    case DeviceState.Unplugged:
                        return "Not Plugged In";
                }
                return "Unknown";
            }
        }
    }
}