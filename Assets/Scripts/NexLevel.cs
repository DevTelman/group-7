using UnityEngine;
using UnityEngine.SceneManagement;

public class NexLevel : MonoBehaviour
{
    public void LoadNextLevel()
    {
        int currentindex=SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentindex+1);
    }

}
