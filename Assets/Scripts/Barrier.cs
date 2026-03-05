using UnityEngine;

public class Barrier1 : MonoBehaviour
{
    public GameObject player;
    public GameObject objectToShow;
    public GameObject[] animals;

    void Start()
    {
        objectToShow.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == player)
        {
            bool animalsLeft = false;

            foreach (GameObject a in animals)
            {
                if (a != null)
                {
                    animalsLeft = true;
                }
            }

            if (animalsLeft)
            {
                objectToShow.SetActive(true);
            }
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject == player)
        {
            objectToShow.SetActive(false);
        }
    }
}