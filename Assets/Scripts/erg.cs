using UnityEngine;

public class erg : MonoBehaviour
{
    public AudioSource audioSource;   // Enemy-ի AudioSource
    public GameObject player;         // Player-ը Inspector-ով կքաշես

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == player)
        {
            audioSource.Play();
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == player)
        {
            audioSource.Play();
        }
    }
}
