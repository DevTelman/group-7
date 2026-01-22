using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("LosePoint"))
        {
            Debug.Log("YOU LOSE!");

            
            Time.timeScale = 0f;

            
        }
    }
}