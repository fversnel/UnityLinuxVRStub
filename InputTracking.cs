namespace UnityEngine.VR {
    public static class InputTracking {
        public static Vector3 GetLocalPosition(VRNode node) {
            return Vector3.zero;
        }

        public static Quaternion GetLocalRotation(VRNode node) {
            return Quaternion.identity;
        }

        public static void Recenter() {}
    }
}