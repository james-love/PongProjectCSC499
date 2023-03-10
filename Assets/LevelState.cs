using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEditor.Experimental.GraphView.GraphView;

public class LevelState : MonoBehaviour
{
    [SerializeField] private Animator _transition;
    [SerializeField] private GameObject _loadingScreen;
    public bool Loading { get; private set; }

    public Theme Theme;
    public Players Players;
    public GameMode Mode;
    public int Score;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

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

    private IEnumerator LoadAsync(int levelIndex)
    {
        Loading = true;
        Time.timeScale = 0;
        _transition.SetTrigger("Start");
        yield return new WaitUntil(AnimationFinished);

        _loadingScreen.SetActive(true);

        AsyncOperation operation = SceneManager.LoadSceneAsync(levelIndex);
        while (!operation.isDone)
        {
            yield return null;
        }

        // TODO: use the state vals here

        _loadingScreen.SetActive(false);

        _transition.SetTrigger("Loaded");
        Loading = false;
        Time.timeScale = 1;
    }

    private bool AnimationFinished()
    {
        return _transition.GetCurrentAnimatorStateInfo(0).IsName("Wipe_Start") &&
            _transition.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1;
    }
}
