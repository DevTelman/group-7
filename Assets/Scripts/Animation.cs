using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private Animator anim;

    void Awake()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        // Jump
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            anim.SetTrigger("Jump");
        }
    }
}
