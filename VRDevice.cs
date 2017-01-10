using System;

namespace UnityEngine.VR {
    public static class VRDevice {
        public static bool isPresent {
            get { return false; }
        }

        public static string family {
            get { return ""; }
        }

        public static string model {
            get { return ""; }
        }

        public static float refreshRate {
            get { return 0f; }
        }

        public static IntPtr GetNativePtr() {
            return IntPtr.Zero;
        }
    }
}