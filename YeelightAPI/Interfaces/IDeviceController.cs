﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YeelightAPI.Models.Adjust;
using YeelightAPI.Models.ColorFlow;

namespace YeelightAPI
{
    public interface IDeviceController
    {

        void Disconnect();

        Task<bool> Connect();

        Task<bool> Toggle();

        Task<bool> SetPower(bool state = true);

        Task<bool> SetBrightness(int value, int? smooth = null);

        Task<bool> SetRGBColor(int r, int g, int b, int? smooth = null);

        Task<bool> SetHSVColor(int hue, int sat, int? smooth = null);

        Task<bool> SetColorTemperature(int temperature, int? smooth = null);

        Task<bool> StartColorFlow(ColorFlow flow);

        Task<bool> StopColorFlow();

        Task<bool> Adjust(AdjustAction action, AdjustProperty property);
    }
}
