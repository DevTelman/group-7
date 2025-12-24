using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerJump : MonoBehaviour
{
    public float jumpForce = 7f;

    private Rigidbody rigidbodyComponent;
    private bool isGrounded;

    void Start()
    {
        rigidbodyComponent = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Թռիչք՝ ↑ սլաքով
        if (Keyboard.current.upArrowKey.wasPressedThisFrame && isGrounded)
        {
            rigidbodyComponent.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }
}
