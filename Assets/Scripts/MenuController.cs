using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void LoadLevel1()
    {
        SceneManager.LoadScene("Level1");
    }

    public void LoadTutorial()
    {
        SceneManager.LoadScene("TutorialScene");
    }
    public void LoadMenu1()
    {
        SceneManager.LoadScene("Menu1");
    }
}
