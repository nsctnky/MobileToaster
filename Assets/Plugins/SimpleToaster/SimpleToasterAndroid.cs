using UnityEngine;

namespace Plugins.SimpleToaster
{
    public class SimpleToasterAndroid : ISimpleToaster
    {
        private const string UnityPlayer = "com.unity3d.player.UnityPlayer";
        private const string CurrentActivity = "currentActivity";
        private const string Toaster = "com.nsctnky.androidtoaster.ToasterController";
        private const string ShowToast = "ShowToast";
        
        private readonly AndroidJavaObject _unityActivity;
        private readonly AndroidJavaObject _toaster;
        
        public SimpleToasterAndroid()
        {
            var unityPlayerClass = new AndroidJavaClass(UnityPlayer);
            _unityActivity = unityPlayerClass.GetStatic<AndroidJavaObject>(CurrentActivity);
            _toaster = new AndroidJavaObject(Toaster);
        }
        
        public void Show(string message, bool isShortDuration)
        {
            object[] parameters = new object[3];

            parameters[0] = _unityActivity;
            parameters[1] = message;
            parameters[2] = isShortDuration;
            
            _toaster.Call(ShowToast, parameters);
        }
    }
}
