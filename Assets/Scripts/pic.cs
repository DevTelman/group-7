using UnityEngine;

public class AnimalPickup : MonoBehaviour
{
    public GameObject player;
    public Collider2D barrierCollider; // ՍԱ ՓՈԽԻ

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == player)
        {
            barrierCollider.isTrigger = true;
            gameObject.SetActive(false);
        }
    }
}