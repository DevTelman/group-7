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

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("HIT WALL");

        if (collision.gameObject == player)
        {
            objectToShow.SetActive(true);
        }
    }

    void Update()
    {
        bool allDestroyed = true;

        foreach (GameObject a in animals)
        {
            if (a != null)
            {
                allDestroyed = false;
            }
        }

        if (allDestroyed && objectToShow.activeSelf)
        {
            objectToShow.SetActive(false);
        }
    }
}