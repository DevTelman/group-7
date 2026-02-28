using UnityEngine;

public class WinTriggerDebug : MonoBehaviour
{
    public GameObject winPanel;
    public GameObject playerObject;

    private void Start()
    {
        if (winPanel != null)
            winPanel.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.gameObject == playerObject)
        {
            Debug.Log(" Player won!");
            if (winPanel != null)
            {
                winPanel.SetActive(true);
                Time.timeScale = 1f; 
            }
        }
    }
}