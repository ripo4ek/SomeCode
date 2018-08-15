using System;
using System.Management;

namespace ActionsAndTriggers
{
    class SystemManagmentOperator
    {
        private readonly ManagementClass _mcWin32;
        private readonly ManagementBaseObject _mboShutdownParams;
        public SystemManagmentOperator()
        {
            _mcWin32 = new ManagementClass("Win32_OperatingSystem");
            _mcWin32.Get();
            _mcWin32.Scope.Options.EnablePrivileges = true;
            _mboShutdownParams = _mcWin32.GetMethodParameters("Win32Shutdown");

        }
        public void Initialize(OptionState state)
        {
            _mboShutdownParams["Flags"] = Convert.ToString((int)state);
            _mboShutdownParams["Reserved"] = "0";
            foreach (var o in _mcWin32.GetInstances())
            {
                var manObj = (ManagementObject)o;
                manObj.InvokeMethod("Win32Shutdown",
                    _mboShutdownParams, null);
            }
        }
    }
}