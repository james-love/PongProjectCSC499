using UnityEngine;
using UnityEngine.UIElements;

public class EndScreen : MonoBehaviour
{
    private void Start()
    {
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;

        Button playAgain = root.Q<Button>("PlayAgain");
        playAgain.RegisterCallback<NavigationSubmitEvent>(_ => LevelState.Instance.ReloadGame());
        playAgain.RegisterCallback<ClickEvent>(_ => LevelState.Instance.ReloadGame());

        Button mainMenu = root.Q<Button>("MainMenu");
        mainMenu.RegisterCallback<NavigationSubmitEvent>(_ => LevelState.Instance.ReloadMainMenu());
        mainMenu.RegisterCallback<ClickEvent>(_ => LevelState.Instance.ReloadMainMenu());
    }
}
