using UnityEngine;

public class kendani : MonoBehaviour
{
    public GameObject player;              // այստեղ կքաշես Player-ը
    public pat barrier;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == player)
        {
            barrier.OpenBarrier();
            Destroy(gameObject);
        }
    }
}