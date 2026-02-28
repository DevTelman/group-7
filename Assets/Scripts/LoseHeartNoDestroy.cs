using UnityEngine;

public class LoseHeartNoDestroy : MonoBehaviour
{

    public Lous playerLife;   // Inspector-ում կկցենք

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == playerLife.gameObject)
        {
            playerLife.TakeDamage();

    
        }
    }

}

