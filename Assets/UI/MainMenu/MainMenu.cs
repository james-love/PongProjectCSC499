using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private UIDocument mainMenu;
    [SerializeField] private UIDocument startMenu;
    [SerializeField] private UIDocument controlsMenu;

    [SerializeField] private AudioClip backSound;
    [SerializeField] private AudioClip forwardSound;

    [SerializeField] private AudioClip navigationSound;
    [SerializeField] private AudioClip clickSound;

    [SerializeField] private AudioClip menuMusic;

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

        startMenu.rootVisualElement.style.display = DisplayStyle.None;
        controlsMenu.rootVisualElement.style.display = DisplayStyle.None;
        mainMenu.rootVisualElement.style.display = DisplayStyle.Flex;

        AddNavigationSound();
    }

    private void Start()
    {
        SoundManager.Instance.PlayMusic(menuMusic);
    }

    private void AddNavigationSound()
    {
        // TODO: A lot of stray sounds to clean up. Slider sound is wild.
        List<Button> navigationElements = mainMenu.rootVisualElement.Query<Button>(null, "button").ToList();
        navigationElements.AddRange(startMenu.rootVisualElement.Query<Button>(null, "button").ToList());
        navigationElements.AddRange(controlsMenu.rootVisualElement.Query<Button>(null, "button").ToList());
        foreach (Button btn in navigationElements)
        {
            btn.RegisterCallback<NavigationSubmitEvent>(_ => SoundManager.Instance.PlaySound(clickSound));
            btn.RegisterCallback<ClickEvent>(_ => SoundManager.Instance.PlaySound(clickSound));
            btn.RegisterCallback<FocusInEvent>(e => SoundManager.Instance.PlaySound(navigationSound));
            btn.RegisterCallback<MouseOverEvent>(_ => SoundManager.Instance.PlaySound(navigationSound));
        }

        SliderInt slider = startMenu.rootVisualElement.Query<SliderInt>("Slider");
        slider.RegisterCallback<FocusInEvent>(_ => SoundManager.Instance.PlaySound(navigationSound));
        slider.RegisterCallback<MouseOverEvent>(_ => SoundManager.Instance.PlaySound(navigationSound));
        slider.RegisterValueChangedCallback(_ => SoundManager.Instance.PlaySound(clickSound));
    }

    private void DisplayMainMenu()
    {
        SoundManager.Instance.PlaySound(backSound);
        startMenu.rootVisualElement.style.display = DisplayStyle.None;
        controlsMenu.rootVisualElement.style.display = DisplayStyle.None;
        mainMenu.rootVisualElement.style.display = DisplayStyle.Flex;
    }

    private void DisplayStartMenu()
    {
        SoundManager.Instance.PlaySound(forwardSound);
        mainMenu.rootVisualElement.style.display = DisplayStyle.None;
        controlsMenu.rootVisualElement.style.display = DisplayStyle.None;
        startMenu.rootVisualElement.style.display = DisplayStyle.Flex;
    }

    private void DisplayControlsMenu()
    {
        SoundManager.Instance.PlaySound(forwardSound);
        mainMenu.rootVisualElement.style.display = DisplayStyle.None;
        startMenu.rootVisualElement.style.display = DisplayStyle.None;
        controlsMenu.rootVisualElement.style.display = DisplayStyle.Flex;
    }
}
