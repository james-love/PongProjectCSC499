using UnityEngine;
using static UnityEngine.InputSystem.InputAction;

public class Paddle : MonoBehaviour
{
    [SerializeField] private float speed = 100f;
    private ParticleSystem collisionEffect;
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

    public void GetParticleSystem(bool rotate)
    {
        collisionEffect = GetComponentInChildren<ParticleSystem>();
        collisionEffect.transform.rotation = Quaternion.Euler(new Vector3(
            collisionEffect.transform.rotation.x,
            90,
            collisionEffect.transform.rotation.z));
    }

    private void Awake()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            collisionEffect.Stop();
            collisionEffect.Play();
        }
    }

    private void FixedUpdate()
    {
        rigidBody.MovePosition(rigidBody.position + (direction * speed * Time.deltaTime * Vector2.up));
    }
}
