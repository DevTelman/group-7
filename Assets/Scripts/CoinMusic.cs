using UnityEngine;

public class CoinPickup : MonoBehaviour
{
    public GameObject player;      // Քաշում ես Player-ը
    public AudioSource coinSound;  // Քաշում ես coin-ի AudioSource

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == player)
        {
            coinSound.Play();
            Destroy(gameObject, coinSound.clip.length);
        }
    }
}