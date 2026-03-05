using UnityEngine;

public class GarbageShoot : MonoBehaviour
{
   public GameObject bulletPrefab;
    public Transform firePoint;
    public AudioSource shootSound;

    public float fireSpeed = 20f;

    void Update()
    {
            Shoot();
        
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(
            bulletPrefab,
            firePoint.position,
            Quaternion.identity
        );

        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();

        float direction = GetComponent<SpriteRenderer>().flipX ? -1f : 1f;

        rb.linearVelocity = new Vector2(direction * fireSpeed, 0f);

        if (shootSound != null)
            shootSound.Play();
    }
}
