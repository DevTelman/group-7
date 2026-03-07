using UnityEngine;
using UnityEngine.SceneManagement;

public class AboutUsManager : MonoBehaviour
{
    public GameObject AboutUsPanel; 

    void Start()
    {
        AboutUsPanel.SetActive(false);
    }

    public void OpenAbout()
    {
        AboutUsPanel.SetActive(true);
    }

    public void CloseAbout()
    {
        AboutUsPanel.SetActive(false);
    }

    public void OpenLevels()
    {
        SceneManager.LoadScene("Menu2");
    }
}