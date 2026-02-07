using UnityEngine;
using UnityEngine.InputSystem;

public class Shoot : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;
    public float bulletSpeed = 10f;

    private SpriteRenderer sr;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            Fire();
        }
    }

    void Fire()
    {
        GameObject bullet = Instantiate(
            bulletPrefab,
            firePoint.position,
            Quaternion.identity
        );

        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();

        // If player is flipped → shoot LEFT
        if (sr.flipX)
        {
            rb.linearVelocity = new Vector2(-bulletSpeed, 0f);
        }
        else // shoot RIGHT
        {
            rb.linearVelocity = new Vector2(bulletSpeed, 0f);
        }
    }
}
