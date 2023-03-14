using UnityEngine;
using static UnityEngine.InputSystem.InputAction;

public class Paddle : MonoBehaviour
{
    [SerializeField] private float speed = 100f;
    private float direction = 0f;
    private Rigidbody2D rigidBody;
    public void Move(CallbackContext context)
    {
        if (context.started)
            direction = context.ReadValue<float>();
    }

    public void Stop(CallbackContext context)
    {
        if (context.canceled)
            direction = 0f;
    }

    private void Awake()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        //transform.Translate(direction * speed * Time.deltaTime * Vector3.up);
        rigidBody.MovePosition(rigidBody.position + (direction * speed * Time.deltaTime * Vector2.up));
    }
}
