using UnityEngine;

public class WinTriggerDebug : MonoBehaviour
{
    public GameObject winPanel;
    public GameObject playerObject;
    public GameObject saveAnimalPanel;
    public AnimalCollector collector;

    private void Start()
    {
        if (winPanel != null)
            winPanel.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.gameObject == playerObject)
        {
            Debug.Log(collector.animalCount);
            if (collector.animalCount  >0)
            {
                saveAnimalPanel.SetActive(true);
                return;
            }
            Debug.Log(" Player won!");
            if (winPanel != null)
            {
                winPanel.SetActive(true);
                Time.timeScale = 1f; 
            }
        }
    }
}