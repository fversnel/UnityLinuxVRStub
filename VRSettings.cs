using System;

namespace UnityEngine.VR {
    public static class VRSettings {
        public static bool enabled {
            get { return false; }
            set { }
        }

        public static bool isDeviceActive { get; } = false;

        public static bool showDeviceView {
            get { return false; }
            set { }
        }

        public static float renderScale {
            get { return 1f; }
            set { }
        }

        public static int eyeTextureWidth { get; } = 0;

        public static int eyeTextureHeight { get; } = 0;

        public static float renderViewportScale {
            get { return 0f; }
            set { }
        }

        [Obsolete("loadedDevice is deprecated.  Use loadedDeviceName and LoadDeviceByName instead.")]
        public static VRDeviceType loadedDevice {
            get { return VRDeviceType.None; }
            set { }
        }

        public static string loadedDeviceName { get; } = "";

        public static string[] supportedDevices { get; } = new string[0];

        public static void LoadDeviceByName(string deviceName) {}

        public static void LoadDeviceByName(string[] prioritizedDeviceNameList) {}
    }
}