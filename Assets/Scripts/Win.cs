using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("WinPoint"))
        {
            Debug.Log("YOU WIN!");


            Time.timeScale = 0f;

        }   
    }
}