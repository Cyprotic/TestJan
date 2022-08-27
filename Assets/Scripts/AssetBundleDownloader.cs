using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

public class AssetBundleDownloader : MonoBehaviour
{
    void Start() 
    {
        StartCoroutine(GetAssetBundle());
    }
    IEnumerator GetAssetBundle()
    {
        UnityWebRequest www = UnityWebRequestAssetBundle.GetAssetBundle("https://vaffacosmogame.com/test/Jan/deathwing.card");
        yield return www.SendWebRequest();
 
        if (www.result != UnityWebRequest.Result.Success) 
        {
            Debug.Log(www.error);
        }
        else 
        {
            AssetBundle bundle = DownloadHandlerAssetBundle.GetContent(www);
            UserPrefs.bundle = bundle;
            Debug.Log(UserPrefs.bundle);
            SceneManager.LoadScene("Game");
        }
    }
}
