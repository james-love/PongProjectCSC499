using UnityEngine;

public class Ball : MonoBehaviour
{
    private float speed = 4; // was private readonly

    public float Speed
    {
        get { return speed; } set { speed = value; }
    }

    private Vector2 direction;
    private GameObject lastHitPaddle;

    private void Start()
    {
        direction = Random.Range(0f, 1f) < 0.5 ? Vector2.left : Vector2.right;
        direction.y = Random.Range(-1f, 1f);
    }

    private void Update()
    {
        transform.Translate(speed * Time.deltaTime * direction);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Paddle":
                SoundManager.Instance.PlaySound(ThemeManager.Instance.Theme.PaddleHit);
                direction.x *= -1;
                lastHitPaddle = collision.gameObject;
                break;
            case "Border":
                SoundManager.Instance.PlaySound(ThemeManager.Instance.Theme.WallHit); // giving NullReferenceException errors  here (line 30)..........
                direction.y *= -1;
                break;
            case "Goal":
                SoundManager.Instance.PlaySound(ThemeManager.Instance.Theme.Goal); // .........and here (line 34)
                BallSpawner.Instance.SpawnBall(gameObject);
                break;
            // TODO: Maybe move logic to Powerup.cs and remove this (and the tag)
            case "Powerup":
                SoundManager.Instance.PlaySound(ThemeManager.Instance.Theme.PowerupPickup);

                Powerup component = collision.gameObject.GetComponent<Powerup>();

                if (lastHitPaddle != null)
                {
                    component.Effect(this.gameObject, lastHitPaddle);

                    PowerupSpawner.Instance.SpawnPowerup(collision.gameObject);
                }

                break;
            default:
                break;
        }
    }
}
