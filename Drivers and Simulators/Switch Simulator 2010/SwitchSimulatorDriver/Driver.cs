﻿using System;
using System.Collections;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using ASCOM.DeviceInterface;
using ASCOM.Utilities;

namespace ASCOM.Simulator
{
    //
    // Your driver's DeviceID is ASCOM.Simulator.Switch
    //
    // The Guid attribute sets the CLSID for ASCOM.Simulator.Switch
    // The ClassInterface/None addribute prevents an empty interface called
    // _Conceptual from being created and used as the [default] interface
    //

    /// <summary>
    /// ASCOM Switch Driver for a conceptual switch (proof of concept).
    /// This class is the implementation of the public ASCOM interface.
    /// </summary>
    [Guid("1F07419A-0C9E-4B90-8B62-FC8053E89EE2"), ClassInterface(ClassInterfaceType.None), ComVisible(true)]
    [ProgId(name)] //Force the ProgID we want to have
    public class Controller : IController, IDisposable
    {
        #region Constants

        /// <summary>
        /// Name of the Driver
        /// </summary>
        private const string name = "ASCOM.ToggleSwitchSimulator.Controller";

        /// <summary>
        /// Description of the driver
        /// </summary>
        private const string description = "ASCOM ToggleSwitch Simulator Driver";

        /// <summary>
        /// Device type
        /// </summary>
        private const string deviceType = "Controller";
        
        /// <summary>
        /// Driver information
        /// </summary>
        private const string driverInfo = "Toggle switch simulator driver and collection of toggle switch controllers devices";

        /// <summary>
        /// Driver interface version
        /// </summary>
        private const short interfaceVersion = 1;

        /// <summary>
        /// Driver version number
        /// </summary>
        private const string driverVersion = "6.0";

        /// <summary>
        /// ASCOM DeviceID (COM ProgID) for this driver.
        /// The DeviceID is used by ASCOM applications to load the driver at runtime.
        /// </summary>
        private const string sCsDriverId = "ASCOM.ToggleSwitchSimulator.Controller";

        /// <summary>
        /// Driver description that displays in the ASCOM Chooser.
        /// </summary>
        private const string sCsDriverDescription = "ASCOM Toggle Switch Simulator";

        /// <summary>
        /// The number of physical switches that this device has.
        /// </summary>
        private const int numSwitches = 7;

        /// <summary>
        /// Type of switches for this driver
        /// </summary>
        private const string switchType = "ToggleSwitch";

        /// <summary>
        /// Backing store for the private switch collection.
        /// </summary>
        private static readonly ArrayList SwitchList = new ArrayList(numSwitches);

        /// <summary>
        /// Sets up the permenant store for saved settings
        /// </summary>
        private static readonly Profile Profile = new Profile();

        /// <summary>
        /// Sets up the permenant store for device names
        /// </summary>
        private static readonly string[] DeviceNames = {
                                                           "White Lights", "Red Lights", "Telescope Power",
                                                           "Camera Power",
                                                           "Focuser Power", "Dew Heaters", "Dome Power", "Self Destruct"
                                                       };

        #endregion

        #region Constructors

        //
        // PUBLIC COM INTERFACE ISwitch IMPLEMENTATION
        //

        /// <summary>
        /// Initializes a new instance of the <see cref="Controller"/> class.
        /// Must be public for COM registration.
        /// </summary>
        public Controller()
        {
            //new instance so load switches
            Profile.DeviceType = deviceType;
            LoadSwitchDevices();
            SaveProfileSettings();
        }

        #endregion

        #region IDisposable Members

        void IDisposable.Dispose()
        {
            Dispose();
        }

        #endregion

        #region Common Members

        /// <summary>
        /// Displays the Setup Dialog form.
        /// If the user clicks the OK button to dismiss the form, then
        /// the new settings are saved, otherwise the old values are reloaded.
        /// </summary>
        public void SetupDialog()
        {
            var f = new SetupDialogForm();
            f.ShowDialog();
        }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Controller"/> is connected.
        /// </summary>
        /// <value><c>true</c> if connected; otherwise, <c>false</c>.</value>
        public bool Connected { get; set; }

        /// <summary>
        /// Gets the description.
        /// </summary>
        /// <value>The description.</value>
        public string Description
        {
            get { return description; }
        }

        /// <summary>
        /// Gets the driver info.
        /// </summary>
        /// <value>The driver info.</value>
        public string DriverInfo
        {
            get { return driverInfo; }
        }

        /// <summary>
        /// Gets the driver version.
        /// </summary>
        /// <value>The driver version.</value>
        public string DriverVersion
        {
            get { return driverVersion; }
        }

        /// <summary>
        /// Gets the interface version.
        /// </summary>
        /// <value>The interface version.</value>
        public short InterfaceVersion
        {
            get { return interfaceVersion; }
        }

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name
        {
            get { return name; }
        }

        void IController.Dispose()
        {
            Dispose();
        }


        /// <summary>
        /// Gets the supported actions.
        /// </summary>
        public string Action(string actionName, string actionParameters)
        {
            return null;
        }

        /// <summary>
        /// Transmits an arbitrary string to the device and does not 
        /// wait for a response. Optionally, protocol framing 
        /// characters may be added to the string before transmission.
        /// </summary>
        public void CommandBlind(string command, bool raw)
        {
        }

        /// <summary>
        /// Transmits an arbitrary string to the device and waits 
        /// for a boolean response. Optionally, protocol framing 
        /// characters may be added to the string before transmission.
        /// </summary>
        public bool CommandBool(string command, bool raw)
        {
            return false;
        }

        /// <summary>
        /// Transmits an arbitrary string to the device and waits 
        /// for a string response. Optionally, protocol framing 
        /// characters may be added to the string before transmission.
        /// </summary>
        public string CommandString(string command, bool raw)
        {
            return null;
        }

        /// <summary>
        /// Gets the supported actions.
        /// </summary>
        public ArrayList SupportedActions
        {
            // no supported actions, return empty array
            get
            {
                var sa = new ArrayList();
                return sa;
            }
        }

        #endregion

        #region Controller Members
        /// <summary>
        /// Returns an <c>Arraylist</c> of ToggleSwitch ControllerDevices
        /// </summary>
        public ArrayList ControllerDevices
        {
            get
            {
              return SwitchList;
            }
        }

        /// <summary>
        /// return a specific switch
        /// </summary>
        /// <value>name of the switch</value>
        public object GetSwitch(string switchName)
        {
            if (switchName == null) throw new ASCOM.InvalidValueException("switchName");
            return SwitchList.Cast<ToggleSwitch>().FirstOrDefault(t => t.Name == switchName);
        }

        /// <summary>
        ///  Sets a ControllerDevice On or Off
        /// </summary>
        /// <param name="controllerName">Name of the ControllerDevice</param>
        /// <param name="State">Boolean True to turn on or False to turn off</param>
        public void SetSwitch(string controllerName, bool State)
        {
            if (controllerName == null) throw new ASCOM.InvalidValueException("switchName");
            foreach (ToggleSwitch t in from ToggleSwitch t in SwitchList where t.Name == controllerName select t)
            {
                t.On = State;
            }
            SaveProfileSettings();
        }

        #endregion

        #region Private Members

        private static void Dispose()
        {
        }

        /// <summary>
        /// Simulate reading the hardware devices
        /// </summary>
        private static void LoadSwitchDevices()
        {
            bool state;
            SwitchList.Clear();

            foreach (var deviceName in DeviceNames)
            {
                var v = Profile.GetValue(sCsDriverId, deviceName, "Switches");
                if (! bool.TryParse(v, out state))
                {
                    state = false;
                }
                var toggleSwitch = new ToggleSwitch (deviceName);
                toggleSwitch.On = state;
                var add = SwitchList.Add(toggleSwitch);
            }
        }

        /// <summary>
        /// Saves all settings to the profile for this driver
        /// </summary>
        private static void SaveProfileSettings()
        {
            foreach (ToggleSwitch t in SwitchList)
            {
                Profile.WriteValue(sCsDriverId, t.Name, t.On.ToString(), "Switches");
            }
        }

        #endregion

        #region ASCOM Registration

        //
        // Register or unregister driver for ASCOM. This is harmless if already
        // registered or unregistered. 
        //
        /// <summary>
        /// Register or unregister the driver with the ASCOM Platform.
        /// This is harmless if the driver is already registered/unregistered.
        /// </summary>
        /// <param name="bRegister">If <c>true</c>, registers the driver, otherwise unregisters it.</param>
        private static void RegUnregASCOM(bool bRegister)
        {
            var p = new Profile {DeviceType = deviceType};
            if (bRegister)
            {
                p.Register(sCsDriverId, sCsDriverDescription);
                p.CreateSubKey(sCsDriverId, "Switches"); //Driver instantiation fails if this subkey is not present
            }
            else
            {
                p.Unregister(sCsDriverId);
            }
        }

        /// <summary>
        /// This function registers the driver with the ASCOM Chooser and
        /// is called automatically whenever this class is registered for COM Interop.
        /// </summary>
        /// <param name="t">Type of the class being registered, not used.</param>
        /// <remarks>
        /// This method typically runs in two distinct situations:
        /// <list type="numbered">
        /// <item>
        /// In Visual Studio, when the project is successfully built.
        /// For this to work correctly, the option <c>Register for COM Interop</c>
        /// must be enabled in the project settings.
        /// </item>
        /// <item>During setup, when the installer registers the assembly for COM Interop.</item>
        /// </list>
        /// This technique should mean that it is never necessary to manually register a driver with ASCOM.
        /// </remarks>
        [ComRegisterFunction]
        public static void RegisterASCOM(Type t)
        {
            RegUnregASCOM(true);
        }

        /// <summary>
        /// This function unregisters the driver from the ASCOM Chooser and
        /// is called automatically whenever this class is unregistered from COM Interop.
        /// </summary>
        /// <param name="t">Type of the class being registered, not used.</param>
        /// <remarks>
        /// This method typically runs in two distinct situations:
        /// <list type="numbered">
        /// <item>
        /// In Visual Studio, when the project is cleaned or prior to rebuilding.
        /// For this to work correctly, the option <c>Register for COM Interop</c>
        /// must be enabled in the project settings.
        /// </item>
        /// <item>During uninstall, when the installer unregisters the assembly from COM Interop.</item>
        /// </list>
        /// This technique should mean that it is never necessary to manually unregister a driver from ASCOM.
        /// </remarks>
        [ComUnregisterFunction]
        public static void UnregisterASCOM(Type t)
        {
            RegUnregASCOM(false);
        }

        #endregion
    }
}