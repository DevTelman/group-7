using UnityEngine;

public class PickupItem : MonoBehaviour
{
    public BarrierController barrier;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            barrier.OpenBarrier();
            Destroy(gameObject);
        }
    }
}