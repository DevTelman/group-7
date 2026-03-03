using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float lifeTime = 2f;

    public GameObject targetPrefab; // քաշում ես enemy prefab-ը
    public AudioClip hitClip;

    void Start()
    {
        Destroy(gameObject, lifeTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // ստուգում ենք՝ սա նույն prefab-ից ա՞
        if (other.gameObject.name.Contains(targetPrefab.name))
        {
            if (hitClip != null)
            {
                AudioSource.PlayClipAtPoint(hitClip, transform.position);
            }

            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}