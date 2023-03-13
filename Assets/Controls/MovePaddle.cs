using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.InputSystem.InputAction;

public class MovePaddle : MonoBehaviour
{
    [SerializeField] private float speed = 10f;
    private float direction = 0f;
    public void Move(CallbackContext context)
    {
        direction = context.ReadValue<float>();
    }

    public void Stop(CallbackContext context)
    {
        direction = 0f;
    }

    private void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime * Vector3.up);
    }
}
