using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class EndScreen : MonoBehaviour
{
    [SerializeField] private AudioClip clickSound;
    [SerializeField] private AudioClip navigationSound;

    private void Start()
    {
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;

        Button playAgain = root.Q<Button>("PlayAgain");
        playAgain.RegisterCallback<NavigationSubmitEvent>(_ => LevelState.Instance.ReloadGame());
        playAgain.RegisterCallback<ClickEvent>(_ => LevelState.Instance.ReloadGame());

        Button mainMenu = root.Q<Button>("MainMenu");
        mainMenu.RegisterCallback<NavigationSubmitEvent>(_ => LevelState.Instance.ReloadMainMenu());
        mainMenu.RegisterCallback<ClickEvent>(_ => LevelState.Instance.ReloadMainMenu());

        Button quit = root.Q<Button>("Quit");
        quit.RegisterCallback<NavigationSubmitEvent>(_ => Application.Quit());
        quit.RegisterCallback<ClickEvent>(_ => Application.Quit());

        List<Button> navigationElements = root.Query<Button>(null, "button").ToList();
        foreach (Button btn in navigationElements)
        {
            btn.RegisterCallback<NavigationSubmitEvent>(_ => SoundManager.Instance.PlaySound(clickSound));
            btn.RegisterCallback<ClickEvent>(_ => SoundManager.Instance.PlaySound(clickSound));
            btn.RegisterCallback<FocusInEvent>(e => SoundManager.Instance.PlaySound(navigationSound));
            btn.RegisterCallback<MouseOverEvent>(_ => SoundManager.Instance.PlaySound(navigationSound));
        }
    }
}
