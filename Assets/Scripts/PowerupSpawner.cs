using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupSpawner : MonoBehaviour
{
    public static PowerupSpawner Instance;
    [SerializeField] private List<GameObject> powerups;
    [SerializeField] private float waitTime;
    [SerializeField] private GameObject topLeftBound;
    [SerializeField] private GameObject bottomRightBound;
    private Coroutine powerupSpawner;

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
        if (LevelState.Instance.Powerup)
            SpawnPowerup();
    }

    public void SpawnPowerup(GameObject oldPowerup = null)
    {
        if (oldPowerup != null)
        {
            Destroy(oldPowerup);
        }

        powerupSpawner = StartCoroutine(SpawnPowerupAfterSeconds(waitTime));
    }

    private IEnumerator SpawnPowerupAfterSeconds(float seconds)
    {
        yield return new WaitForSeconds(seconds);

        GameObject newPowerup = Instantiate(powerups[Random.Range(0, powerups.Count)]);

        newPowerup.transform.position = new Vector3(
            Random.Range(topLeftBound.transform.position.x, bottomRightBound.transform.position.x),
            Random.Range(bottomRightBound.transform.position.y, topLeftBound.transform.position.y),
            0
        );

        StopCoroutine(powerupSpawner);
    }
}
