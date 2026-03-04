using UnityEngine;

public class BarrierController : MonoBehaviour
{
    public GameObject imageUI;  
    public bool hasItem = false; 

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (!hasItem)
            {
                imageUI.SetActive(true);
            }
        }
    }

    public void OpenBarrier()
    {
        hasItem = true;
        GetComponent<Collider2D>().enabled = false;
    }
}
