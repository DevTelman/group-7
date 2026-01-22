using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevelSimple : MonoBehaviour
{
   
    public void RestartLevel()
    {
       
        Time.timeScale = 1f;

        
        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.name);
    }
}