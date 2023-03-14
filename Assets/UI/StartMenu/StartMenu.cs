using UnityEngine;
using UnityEngine.UIElements;

public class StartMenu : MonoBehaviour
{
    private UIDocument startMenu;
    private void Start()
    {
        startMenu = GetComponent<UIDocument>();

        SelectorWithDisplay<Theme> themeControl = new(
            startMenu.rootVisualElement.Query<VisualElement>("Theme").Children<VisualElement>("Selector"),
            MenuData.ThemeDescription);

        themeControl.OnValueChanged += LevelState.Instance.ThemeChanged;

        SelectorWithDisplay<Players> playersControl = new(
            startMenu.rootVisualElement.Query<VisualElement>("PlayerAmount").Children<VisualElement>("Selector"),
            MenuData.PlayersDescription);

        playersControl.OnValueChanged += LevelState.Instance.PlayersChanged;

        SelectorWithDisplay<GameMode> modeControl = new(
            startMenu.rootVisualElement.Query<VisualElement>("GameMode").Children<VisualElement>("Selector"),
            MenuData.GameModeDescription);

        modeControl.OnValueChanged += GameModeChanged;

        SelectorWithDisplay<Powerups> powerupControl = new(
            startMenu.rootVisualElement.Query<VisualElement>("Powerups").Children<VisualElement>("Selector"),
            MenuData.PowerupDescription);

        powerupControl.OnValueChanged += LevelState.Instance.PowerupChanged;

        SliderInt scoreSlider = startMenu.rootVisualElement.Query<VisualElement>("Score").Descendents<SliderInt>("Slider");
        Label scoreText = startMenu.rootVisualElement.Query<VisualElement>("Score").Descendents<Label>("Text");
        VisualElement scoreDragger = scoreSlider.Query("unity-dragger");

        scoreSlider.RegisterValueChangedCallback(x =>
        {
            scoreText.text = x.newValue.ToString();

            LevelState.Instance.ScoreChanged(x.newValue);
        });

        scoreSlider.RegisterCallback<FocusInEvent>(x =>
        {
            scoreDragger.AddToClassList("highlight-dragger");
        });

        scoreSlider.RegisterCallback<FocusOutEvent>(x =>
        {
            scoreDragger.RemoveFromClassList("highlight-dragger");
        });

        Button start = startMenu.rootVisualElement.Query<Button>("Play");
        start.clicked -= Play;
        start.clicked += Play;
    }

    private void GameModeChanged(GameMode newVal)
    {
        LevelState.Instance.GameModeChanged(newVal);

        VisualElement score = startMenu.rootVisualElement.Query<VisualElement>("Score");
        SliderInt slider = score.Query<SliderInt>("Slider");
        Label text = score.Query<Label>("Text");

        if (newVal == GameMode.Score)
        {
            score.style.visibility = Visibility.Visible;

            slider.value = slider.lowValue;
            text.text = slider.lowValue.ToString();
            LevelState.Instance.ScoreChanged(slider.lowValue);
        }
        else
        {
            score.style.visibility = Visibility.Hidden;
        }
    }

    private void Play()
    {
        LevelState.Instance.LoadLevel(1);
    }
}
