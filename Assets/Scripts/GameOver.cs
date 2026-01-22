using UnityEngine;

public class GameOver: MonoBehaviour
{
    public GameObject gameOverPanel; 

    private bool triggered = false; 

  
    void OnTriggerEnter2D(Collider2D other)
    {
        if (triggered) return; 

     
        if (other.CompareTag("Player"))
        {
            triggered = true;

          
            if (gameOverPanel != null)
                gameOverPanel.SetActive(true);

           
            Time.timeScale = 0f;

            Debug.Log("YOU LOSE!");
        }
    }
}