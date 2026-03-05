using UnityEngine;

public class PickupItem : MonoBehaviour
{
    public Collider2D barrier;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            AnimalCollector collector=other.GetComponent<AnimalCollector>();
            if (collector != null)
            {
                collector.Collect();
            
            
            }
            Destroy(gameObject);

        }
    }
}