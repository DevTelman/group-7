using UnityEngine;
using UnityEngine.UI;

public class Lous : MonoBehaviour
{
    public Image[] hearts;
    public GameObject gameOverPanel;

    int currentLife;

    void Start()
    {
        currentLife = hearts.Length;
        gameOverPanel.SetActive(false);
    }

    public void TakeDamage()
    {
        if (currentLife <= 0) return;

        currentLife--;
        hearts[currentLife].enabled = false;

        if (currentLife == 0)
        {
            gameOverPanel.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}