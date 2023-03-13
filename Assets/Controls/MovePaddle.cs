using UnityEngine;
using static UnityEngine.InputSystem.InputAction;

public class MovePaddle : MonoBehaviour
{
    [SerializeField] private float speed = 10f;
    private float direction = 0f;
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

    private void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime * Vector3.up);
    }
}
