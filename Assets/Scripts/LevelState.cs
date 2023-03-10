using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelState : MonoBehaviour
{
    [SerializeField] private Animator transition;
    [SerializeField] private GameObject loadingScreen;
    public bool Loading { get; private set; }
    public Theme Theme { get; private set; }
    public Players Players { get; private set; }
    public GameMode Mode { get; private set; }
    public int Score { get; private set; }

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

    public void LoadLevel(int levelIndex)
    {
        StartCoroutine(LoadAsync(levelIndex));
    }

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    private IEnumerator LoadAsync(int levelIndex)
    {
        Loading = true;
        Time.timeScale = 0;
        transition.SetTrigger("Start");
        yield return new WaitUntil(AnimationFinished);

        loadingScreen.SetActive(true);

        AsyncOperation operation = SceneManager.LoadSceneAsync(levelIndex);
        while (!operation.isDone)
        {
            yield return null;
        }

        // TODO: use the state vals here

        loadingScreen.SetActive(false);

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
