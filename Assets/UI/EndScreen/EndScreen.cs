using UnityEngine;
using UnityEngine.UIElements;

public class EndScreen : MonoBehaviour
{
    private void Start()
    {
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;

        Button playAgain = root.Q<Button>("PlayAgain");
        playAgain.RegisterCallback<NavigationSubmitEvent>(_ => LevelState.Instance.LoadLevel(1));
        playAgain.RegisterCallback<ClickEvent>(_ => LevelState.Instance.LoadLevel(1));

        Button mainMenu = root.Q<Button>("MainMenu");
        mainMenu.RegisterCallback<NavigationSubmitEvent>(_ => LevelState.Instance.MainMenu());
        mainMenu.RegisterCallback<ClickEvent>(_ => LevelState.Instance.MainMenu());
    }
}
