using UnityEngine;

public class Shoot2 : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;
    public AudioSource shootSound;

    public float fireSpeed = 20f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        if (bulletPrefab == null || firePoint == null)
        {
            Debug.LogError("Bullet կամ FirePoint կապած չի!");
            return;
        }

        GameObject bullet = Instantiate(
            bulletPrefab,
            firePoint.position,
            Quaternion.identity
        );

        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        if (transform.eulerAngles.z == 0)
        {
            rb.linearVelocity = transform.right * fireSpeed;
        }
        else
        {
            rb.linearVelocity = transform.up * fireSpeed;
        }

        if (shootSound != null)
            shootSound.Play();
    }
}