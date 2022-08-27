using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Networking;

public class GameManager : MonoBehaviour
{
    public int score;
    [SerializeField]
    private TextMeshProUGUI scoreText;
    public float difficulty = 1;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString();
    }

    public void UploadCaller()
    {
        StartCoroutine(Upload());
    }

    private IEnumerator Upload()
    {
        WWWForm form = new WWWForm();
        form.AddField("score", score);

        UnityWebRequest www = UnityWebRequest.Post("http://localhost/apis/insertScore.php", form);
        yield return www.SendWebRequest();

        if (www.result != UnityWebRequest.Result.Success)
        {
            Debug.Log(www.error);
        }
        else
        {
            Debug.Log("Form upload complete!");
        }
    }
}
