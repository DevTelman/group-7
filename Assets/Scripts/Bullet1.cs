using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float lifeTime = 2f;

    public GameObject targetPrefab;
    public AudioSource hitAudio; // 👉 հիմա AudioSource ա

    void Start()
    {
        Destroy(gameObject, lifeTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name.Contains(targetPrefab.name))
        {
            // 🔊 ձայն
            if (hitAudio != null)
            {
                hitAudio.Play();
            }

            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}