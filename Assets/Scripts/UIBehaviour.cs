using UnityEngine;
using UnityEngine.SceneManagement;

public class UIBehaviour : MonoBehaviour
{
    public void SceneLoader()
    {
        SceneManager.LoadScene("Game");
    }
}
