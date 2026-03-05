using UnityEngine;

public class ShowImage : MonoBehaviour
{
    public GameObject player;
    public GameObject image;
    void Start()
    {
        image.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == player)
        {
            image.SetActive(true);
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject == player)
        {
            image.SetActive(false);
        }
    }
}