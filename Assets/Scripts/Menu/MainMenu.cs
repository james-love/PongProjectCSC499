using UnityEngine;
using UnityEngine.UIElements;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private UIDocument mainMenu;
    [SerializeField] private UIDocument startMenu;

    private void Awake()
    {
        Button start = mainMenu.rootVisualElement.Q<Button>("Start");
        start.clicked -= DisplayStartMenu;
        start.clicked += DisplayStartMenu;

        Button quit = mainMenu.rootVisualElement.Q<Button>("Quit");
        quit.clicked -= Application.Quit;
        quit.clicked += Application.Quit;

        Button back = startMenu.rootVisualElement.Q<Button>("Back");
        back.clicked -= DisplayMainMenu;
        back.clicked += DisplayMainMenu;

        DisplayMainMenu();
    }

    private void DisplayMainMenu()
    {
        startMenu.rootVisualElement.style.display = DisplayStyle.None;
        mainMenu.rootVisualElement.style.display = DisplayStyle.Flex;
    }

    private void DisplayStartMenu()
    {
        mainMenu.rootVisualElement.style.display = DisplayStyle.None;
        startMenu.rootVisualElement.style.display = DisplayStyle.Flex;
    }
}
