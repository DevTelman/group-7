using UnityEngine;

public class WinTriggerDebug : MonoBehaviour
{
    public GameObject winPanel;

    private void Start()
    {
        if (winPanel != null)
            winPanel.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger: " + other.name + " Tag: " + other.tag);

        if (other.CompareTag("Player"))
        {
            Debug.Log("✅ Player կպել WinCube-ին!");
            if (winPanel != null)
                winPanel.SetActive(true);
            Time.timeScale = 0f;
        }
    }

}