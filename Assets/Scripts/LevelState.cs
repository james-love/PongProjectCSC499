using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelState : MonoBehaviour
{
    public static LevelState Instance;
    [SerializeField] private Animator transition;
    public bool Loading { get; private set; }
    public Theme Theme { get; private set; } = Theme.Classic;
    public Players Players { get; private set; } = Players.OnePlayer;
    public GameMode Mode { get; private set; } = GameMode.Endless;
    public int Score { get; private set; } = 7;
    public bool Powerup { get; private set; } = true;

    public void ThemeChanged(Theme newValue)
    {
        Theme = newValue;
    }

    public void PlayersChanged(Players newValue)
    {
        Players = newValue;
    }

    public void GameModeChanged(GameMode newValue)
    {
        Mode = newValue;
    }

    public void ScoreChanged(int newValue)
    {
        Score = newValue;
    }

    public void PowerupChanged(Powerups newValue)
    {
        Powerup = newValue == Powerups.Enable;
    }

    public void MainMenu()
    {
        Theme = Theme.Classic;
        Players = Players.OnePlayer;
        Mode = GameMode.Endless;
        Score = 7;
        Powerup = true;

        LoadLevel(0);
    }

    public void LoadLevel(int levelIndex)
    {
        StartCoroutine(LoadAsync(levelIndex));
    }

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

    private IEnumerator LoadAsync(int levelIndex)
    {
        Loading = true;
        Time.timeScale = 0;
        transition.SetTrigger("Start");
        yield return new WaitUntil(AnimationFinished);

        AsyncOperation operation = SceneManager.LoadSceneAsync(levelIndex);
        while (!operation.isDone)
        {
            yield return null;
        }

        // TODO: use the state vals here, maybe

        transition.SetTrigger("Loaded");
        Loading = false;
        Time.timeScale = 1;
    }

    private bool AnimationFinished()
    {
        return transition.GetCurrentAnimatorStateInfo(0).IsName("Wipe_Start") &&
            transition.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1;
    }
}
