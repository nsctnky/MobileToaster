using UnityEngine;

namespace Plugins.SimpleToaster.Example
{
    public class ToastExample : MonoBehaviour
    {
        public void OnButtonPressed()
        {
            Toast toast = new Toast("Example Toast Message", true);
            toast.Show();
        }
    }
}
