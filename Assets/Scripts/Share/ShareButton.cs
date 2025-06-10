using System.Runtime.InteropServices;
using UnityEngine;

public class ShareButton : MonoBehaviour
{
    [DllImport("__Internal")]
    private static extern void ShareToVK(string url);

    public void ShareGame()
    {
        #if UNITY_WEBGL && !UNITY_EDITOR
            string link = "https://vk.com/app123456#ref=yourRef"; // подставь свой ID
            ShareToVK(link);
        #else
            Debug.Log("Sharing would be triggered here on WebGL.");
        #endif
    }
}
