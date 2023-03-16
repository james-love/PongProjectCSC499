using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    private Vector3 direction = Vector3.zero;
    private Rigidbody2D rigidBody;

    private void Awake()
    {
        if (LevelState.Instance.Players == Players.TwoPlayer)
            this.enabled = false;

        rigidBody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // Really terrible poor performance AI
        GameObject ball = GameObject.Find("Ball(Clone)");
        if (ball != null)
        {
            Vector3 ballDirection = Vector3.Normalize(ball.transform.position - transform.position);

            if (Mathf.Abs(ballDirection.y) > 0.1)
                direction = new Vector3(0, ballDirection.y < 0 ? -1 : 1, 0);
            else
                direction = Vector3.zero;
        }
    }

    private void FixedUpdate()
    {
        rigidBody.MovePosition(rigidBody.position + (direction * speed * Time.deltaTime * Vector2.up));
    }
}
