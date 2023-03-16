using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public static BallSpawner Instance;
    [SerializeField] private GameObject ball;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        SpawnBall();
    }

    public void SpawnBall(GameObject oldBall = null)
    {
        if (oldBall != null)
            Destroy(oldBall);

        GameObject newBall = Instantiate(ball);

        Ball ballObj = newBall.AddComponent<Ball>();

        ballObj.ImpactEffect = ThemeManager.Instance.Theme.CollisionEffect;
        ballObj.GoalEffect = ThemeManager.Instance.Theme.GoalEffect;

        newBall.transform.position = transform.position;
    }
}
