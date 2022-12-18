using System.Runtime.InteropServices;
using UnityEngine;

namespace Plugins.SimpleToaster
{
    public class SimpleToasterIOS : ISimpleToaster
    {
        [DllImport("iOSToaster_ShowToast")]
        private static extern void ShowToast(string message, bool isShortDuration);
        
        public void Show(string message, bool isShortDuration)
        {
            #if !UNITY_EDITOR
            ShowToast(message,isShortDuration);
            #else
            Debug.Log($"[{nameof(SimpleToasterIOS)}]: Editor doesn't support toast message, your message: {message}");
            #endif
        }
    }
}