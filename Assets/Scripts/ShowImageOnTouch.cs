using UnityEngine;

public class ShowObjectOnWallTouch : MonoBehaviour
{
    public GameObject player;          // Player
    public Collider2D targetCollider; // Պատի collider
    public GameObject[] animal;         // Animal

    private void Start()
    {
        gameObject.SetActive(false); // սկզբում փակ է
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Player-ը կպել է կոնկրետ պատին
        if (collision.gameObject == player && collision.otherCollider == targetCollider)
        {
            // եթե animal-ը դեռ չի վերցվել
            if (animal != null)
            {
                gameObject.SetActive(true);
            }
        }
    }

    private void Update()
    {
        // եթե animal-ը վերցվել է (destroy)
        if (animal == null && gameObject.activeSelf)
        {
            gameObject.SetActive(false);
        }
    }
}