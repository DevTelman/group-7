using UnityEngine;

public class Shoot1 : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;
    public AudioSource shootSound;

    public float fireSpeed = 20f;

    float direction = 1f; // 1 = աջ, -1 = ձախ

    void Update()
    {
        // շարժման ուղղություն սլաքներով
        if (Input.GetKey(KeyCode.RightArrow))
        {
            direction = 1f;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            direction = -1f;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(
            bulletPrefab,
            firePoint.position,
            Quaternion.identity
        );

        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();

        rb.linearVelocity = new Vector2(direction * fireSpeed, 0);

        if (shootSound != null)
            shootSound.Play();
    }
}