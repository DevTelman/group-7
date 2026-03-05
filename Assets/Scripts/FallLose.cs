using UnityEngine;

public class FallLose : MonoBehaviour
{
    public float fallY = -10f;
    public GameObject losePanel;

    void Start()
    {
        losePanel.SetActive(false);
    }

    void Update()
    {
        if (transform.position.y < fallY)
        {
            losePanel.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}