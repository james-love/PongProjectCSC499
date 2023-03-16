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

        newBall.AddComponent<Ball>();

        newBall.transform.position = transform.position;
    }
}
