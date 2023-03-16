using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class Score : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI leftText;
    [SerializeField] private TextMeshProUGUI rightText;
    [SerializeField] private UIDocument endScreen;
    private int leftScore = 0;
    private int rightScore = 0;

    public void LeftScore()
    {
        leftScore++;
        UpdateDisplay();
        CheckScore();
    }

    public void RightScore()
    {
        rightScore++;
        UpdateDisplay();
        CheckScore();
    }

    private void Awake()
    {
        endScreen.rootVisualElement.style.display = DisplayStyle.None;
    }

    private void Start()
    {
        UpdateDisplay();
    }

    private void UpdateDisplay()
    {
        leftText.text = leftScore.ToString();
        rightText.text = rightScore.ToString();
    }

    private void CheckScore()
    {
        if (LevelState.Instance.Mode == GameMode.Score)
        {
            if (leftScore >= LevelState.Instance.Score || rightScore >= LevelState.Instance.Score)
            {
                endScreen.rootVisualElement.Q<Label>("EndText").text = LevelState.Instance.Players == Players.TwoPlayer ?
                    leftScore > rightScore ? "Player One Wins!" : "Player Two Wins!" :
                    leftScore > rightScore ? "You win!" : "You Lost.";


                Time.timeScale = 0;

                endScreen.rootVisualElement.style.display = DisplayStyle.Flex;
            }
        }
    }
}
