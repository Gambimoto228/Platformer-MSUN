using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float Speed = 5f;
    public float JumpForce = 300f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Движение влево-вправо
        float horizontal = Keyboard.current.aKey.isPressed ? -1 :
                           Keyboard.current.dKey.isPressed ? 1 : 0;

        transform.Translate(horizontal * Speed * Time.deltaTime, 0, 0);

        // Прыжок
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            rb.AddForce(Vector3.up * JumpForce);
        }
    }
}
