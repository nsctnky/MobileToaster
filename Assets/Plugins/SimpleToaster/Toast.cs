namespace Plugins.SimpleToaster
{
    public class Toast
    {
        private readonly string _message;
        private readonly bool _isShortDuration;
        private readonly ISimpleToaster _simpleToaster;
        
        public Toast(string message, bool isShortDuration)
        {
            _message = message;
            _isShortDuration = isShortDuration;
            
            #if UNITY_ANDROID
            _simpleToaster = new SimpleToasterAndroid();
            #elif UNITY_IOS
            _simpleToaster = new SimpleToasterIOS();
            #endif
        }

        public void Show()
        {
            _simpleToaster.Show(_message, _isShortDuration);
        }
    }
}