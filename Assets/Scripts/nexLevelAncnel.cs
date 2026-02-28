using UnityEngine;
using UnityEngine.SceneManagement;

public class nextLevelAncnel : MonoBehaviour
{
    [Header("Current Level (optional)")]
    public string currentLevelName;

    [Header("Next Level")]
    public string nextLevelName;

    // Այս ֆունկցիան կկանչվի Button-ից
    public void LoadNextLevel()
    {
        // Եթե current level-ը գրված է, ստուգում ենք
        if (!string.IsNullOrEmpty(currentLevelName))
        {
            if (SceneManager.GetActiveScene().name != currentLevelName)
            {
                Debug.Log("Wrong level. Expected: " + currentLevelName);
                return;
            }
        }

        SceneManager.LoadScene(nextLevelName);
    }
}