using UnityEngine;
using UnityEngine.UIElements;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private UIDocument mainMenu;
    [SerializeField] private UIDocument startMenu;
    [SerializeField] private LevelState state;

    private void Awake()
    {
        LoadMainMenu();
    }

    private void LoadMainMenu()
    {
        startMenu.rootVisualElement.style.display = DisplayStyle.None;
        mainMenu.rootVisualElement.style.display = DisplayStyle.Flex;

        Button start = mainMenu.rootVisualElement.Q<Button>("Start");
        start.clicked -= LoadStartMenu;
        start.clicked += LoadStartMenu;

        Button quit = mainMenu.rootVisualElement.Q<Button>("Quit");
        quit.clicked -= Application.Quit;
        quit.clicked += Application.Quit;
    }

    private void LoadStartMenu()
    {
        mainMenu.rootVisualElement.style.display = DisplayStyle.None;
        startMenu.rootVisualElement.style.display = DisplayStyle.Flex;

        Button back = startMenu.rootVisualElement.Query<Button>("Back");
        back.clicked -= LoadMainMenu;
        back.clicked += LoadMainMenu;

        SelectorWithDisplay<Theme> themeControl = new(
            startMenu.rootVisualElement.Query<VisualElement>("Theme").Children<VisualElement>("Selector"),
            MenuData.ThemeDescription);

        themeControl.OnValueChanged += state.ThemeChanged;

        SelectorWithDisplay<Players> playersControl = new(
            startMenu.rootVisualElement.Query<VisualElement>("PlayerAmount").Children<VisualElement>("Selector"),
            MenuData.PlayersDescription);

        playersControl.OnValueChanged += state.PlayersChanged;

        SelectorWithDisplay<GameMode> modeControl = new(
            startMenu.rootVisualElement.Query<VisualElement>("GameMode").Children<VisualElement>("Selector"),
            MenuData.GameModeDescription);

        modeControl.OnValueChanged += state.GameModeChanged;
    }
}
