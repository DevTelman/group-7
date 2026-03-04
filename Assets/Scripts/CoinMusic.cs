using UnityEngine;

public class CoinPickup : MonoBehaviour
{
    public AudioClip coinClip;   // քաշում ես միայն ձայնը (ոչ AudioSource)
    public GameObject player;    // քաշում ես Player-ը

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == player)
        {
            // 🔊 նվագում է անկախ քոյնից
            AudioSource.PlayClipAtPoint(coinClip, transform.position);

            // 👻 քոյնը անմիջապես անհետանում է
            Destroy(gameObject);
        }
    }
}