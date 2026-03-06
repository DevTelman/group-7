using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float lifeTime = 2f;

    public GameObject targetPrefab;
    public AudioSource hitAudio; 

    void Start()
    {
        Destroy(gameObject, lifeTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name.Contains(targetPrefab.name))
        {
            
            if (hitAudio != null)
            {
                hitAudio.Play();
            }

            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}