using System;

namespace UnityEngine.VR {
    public static class VRDevice {
        public static bool isPresent { get; } = false;

        public static string family { get; } = "";

        public static string model { get; } = "";

        public static float refreshRate { get; } = 0f;

        public static IntPtr GetNativePtr() {
            return IntPtr.Zero;
        }
    }
}