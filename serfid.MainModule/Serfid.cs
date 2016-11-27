﻿using Ninject;
using System;
using serfid.Interfaces.ValueObjects;

namespace serfid.MainModule
{
    public class Serfid : IDisposable
    {
        private SerfidCore _serfidCore;
        private IKernel _kernel;

        public Serfid()
        {
            _kernel = new StandardKernel(new InjectionModule());
            _serfidCore = _kernel.Get<SerfidCore>();
        }

        public void Run()
        {
            _serfidCore.AppStart();
        }

        public void ReadWeft(string reading)
        {
            _serfidCore.ReadWeft(reading);
        }

        public void Dispose()
        {
            _serfidCore = null;
            _kernel.Dispose();
        }

        public bool RegisterDevice(DeviceInfo device)
        {
            return _serfidCore.RegisterDevice(device);
        }
    }
}