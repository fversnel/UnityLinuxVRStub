using System;

namespace UnityEngine.VR {
    public static class VRSettings {
        public static bool enabled {
            get { return false; }
            set { }
        }

        public static bool isDeviceActive {
            get { return false; }
        }

        public static bool showDeviceView {
            get { return false; }
            set { }
        }

        public static float renderScale {
            get { return 1f; }
            set { }
        }

        public static int eyeTextureWidth {
            get { return 0; }
        }

        public static int eyeTextureHeight {
            get { return 0; }
        }

//    /// <summary>
//    ///   <para>Controls the texel:pixel ratio before lens correction, trading performance for sharpness.</para>
//    /// </summary>
//    public static float renderViewportScale {
//      get {
//        return UnityEngine.VR.VRSettings.renderViewportScaleInternal;
//      }
//      set {
//        VRSettings.renderViewportScaleInternal = value;
//      }
//    }
//
//    internal static float renderViewportScaleInternal {  }

        [Obsolete("loadedDevice is deprecated.  Use loadedDeviceName and LoadDeviceByName instead.")]
        public static VRDeviceType loadedDevice {
            get { return VRDeviceType.None; }
            set { }
        }

        public static string loadedDeviceName {
            get { return ""; }
        }

        public static string[] supportedDevices {
            get { return new string[0]; }
        }

        public static void LoadDeviceByName(string deviceName) {
        }

        public static void LoadDeviceByName(string[] prioritizedDeviceNameList) {
        }
    }
}