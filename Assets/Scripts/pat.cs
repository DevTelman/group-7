using UnityEngine;

public class Barrier : MonoBehaviour
{
    public GameObject player;
    public GameObject objectToShow;
    public GameObject animal;

    private void Start()
    {
        objectToShow.SetActive(false);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("HIT WALL");

        if (collision.gameObject == player && animal != null)
        {
            objectToShow.SetActive(true);
        }
    }

    private void Update()
    {
        if (animal == null && objectToShow.activeSelf)
        {
            objectToShow.SetActive(false);
        }
    }
}