using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            CoinManager.instance.AddCoin();
            Debug.Log("Coin touched");
            Destroy(gameObject); 
        }
    }
}
