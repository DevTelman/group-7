using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public string sceneName;

    public void Go()
    {
        SceneManager.LoadScene(sceneName);
    }
}