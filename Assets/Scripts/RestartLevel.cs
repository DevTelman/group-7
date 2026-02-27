using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevelSimple : MonoBehaviour
{
   
    public void RestartLevel()
    {
       
        Time.timeScale = 1f;


       SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex);
        
    }
}