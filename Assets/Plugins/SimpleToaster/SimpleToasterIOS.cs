#if UNITY_IOS
using System.Runtime.InteropServices;
using UnityEngine;

namespace Plugins.SimpleToaster
{
    public class SimpleToasterIOS : ISimpleToaster
    {
        [DllImport("__Internal")]
        private static extern void iOSToaster_ShowToast(string message, bool isShortDuration);
        
        public void Show(string message, bool isShortDuration)
        {
            #if !UNITY_EDITOR
            iOSToaster_ShowToast(message,isShortDuration);
            #else
            Debug.Log($"[{nameof(SimpleToasterIOS)}]: Editor doesn't support toast message, your message: {message}");
            #endif
        }
    }
}
#endif