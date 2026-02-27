using UnityEngine;
using System.Collections;

public class DoorWin : MonoBehaviour
{
    [Header("Door settings")]
    public Transform doorToRotate;     
    public float openSpeed = 3f;
    public float openAngleZ= 90f;

    [Header("Trigger object")]
    public GameObject allowedObject;   

    [Header("Win UI")]
    public GameObject winPanel;
    public float winDelay = 0.5f;

    private bool isOpening = false;
    private Quaternion targetRotation;

    void Start()
    {
        if (winPanel != null)
            winPanel.SetActive(false);

        targetRotation = Quaternion.Euler(0f, 0f, openAngleZ);
    }

    void Update()
    {
        if (isOpening)
        {
            doorToRotate.rotation = Quaternion.Lerp(
                doorToRotate.rotation,
                targetRotation,
                Time.deltaTime * openSpeed
            );
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject == allowedObject)
        {
            StartCoroutine(OpenDoorAndWin());
        }
    }

    IEnumerator OpenDoorAndWin()
    {
        isOpening = true;

        
        yield return new WaitForSeconds(1f);

        if (winPanel != null)
            winPanel.SetActive(true);
    }
}