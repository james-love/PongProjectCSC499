using UnityEngine;
using UnityEngine.UIElements;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private UIDocument mainMenu;
    [SerializeField] private UIDocument startMenu;
    [SerializeField] private UIDocument controlsMenu;

    private void Awake()
    {
        Button start = mainMenu.rootVisualElement.Q<Button>("Start");
        start.clicked -= DisplayStartMenu;
        start.clicked += DisplayStartMenu;

        Button controls = mainMenu.rootVisualElement.Q<Button>("Controls");
        controls.clicked -= DisplayControlsMenu;
        controls.clicked += DisplayControlsMenu;

        Button quit = mainMenu.rootVisualElement.Q<Button>("Quit");
        quit.clicked -= Application.Quit;
        quit.clicked += Application.Quit;

        Button startBack = startMenu.rootVisualElement.Q<Button>("Back");
        startBack.clicked -= DisplayMainMenu;
        startBack.clicked += DisplayMainMenu;

        Button controlsBack = controlsMenu.rootVisualElement.Q<Button>("Back");
        controlsBack.clicked -= DisplayMainMenu;
        controlsBack.clicked += DisplayMainMenu;

        DisplayMainMenu();
    }

    private void DisplayMainMenu()
    {
        startMenu.rootVisualElement.style.display = DisplayStyle.None;
        controlsMenu.rootVisualElement.style.display = DisplayStyle.None;
        mainMenu.rootVisualElement.style.display = DisplayStyle.Flex;
    }

    private void DisplayStartMenu()
    {
        mainMenu.rootVisualElement.style.display = DisplayStyle.None;
        controlsMenu.rootVisualElement.style.display = DisplayStyle.None;
        startMenu.rootVisualElement.style.display = DisplayStyle.Flex;
    }

    private void DisplayControlsMenu()
    {
        mainMenu.rootVisualElement.style.display = DisplayStyle.None;
        startMenu.rootVisualElement.style.display = DisplayStyle.None;
        controlsMenu.rootVisualElement.style.display = DisplayStyle.Flex;
    }
}
