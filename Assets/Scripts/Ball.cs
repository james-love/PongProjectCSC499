using UnityEngine;

public class Ball : MonoBehaviour
{
    public float Speed { get; set; } = 4;
    public void UnoReverse() => direction.x *= -1;

    private Vector2 direction;
    private GameObject lastHitPaddle;

    private void Start()
    {
        direction = Random.Range(0f, 1f) < 0.5 ? Vector2.left : Vector2.right;
        direction.y = Random.Range(-1f, 1f);
    }

    private void Update()
    {
        transform.Translate(Speed * Time.deltaTime * direction);
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
                SoundManager.Instance.PlaySound(ThemeManager.Instance.Theme.WallHit);
                direction.y *= -1;
                break;
            case "Goal":
                SoundManager.Instance.PlaySound(ThemeManager.Instance.Theme.Goal);
                BallSpawner.Instance.SpawnBall(gameObject);
                break;
            case "Powerup":
                if (lastHitPaddle != null)
                {
                    SoundManager.Instance.PlaySound(ThemeManager.Instance.Theme.PowerupPickup);
                    PowerupEffect.GenerateEffect(collision.gameObject.GetComponent<Powerup>().PowerupType, gameObject, lastHitPaddle);
                    PowerupSpawner.Instance.SpawnPowerup(collision.gameObject);
                }

                break;
            default:
                break;
        }
    }
}
