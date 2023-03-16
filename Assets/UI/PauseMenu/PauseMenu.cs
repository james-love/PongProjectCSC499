using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using static UnityEngine.InputSystem.InputAction;

public class PauseMenu : MonoBehaviour
{
    private VisualElement root;
    [SerializeField] private Sprite muteMusicIcon;
    [SerializeField] private Sprite unMuteMusicIcon;

    [SerializeField] private Sprite muteSFXIcon;
    [SerializeField] private Sprite unMuteSFXIcon;

    [SerializeField] private AudioClip clickSound;
    [SerializeField] private AudioClip navigationSound;

    private void Awake()
    {
        root = GetComponent<UIDocument>().rootVisualElement;

        root.style.display = DisplayStyle.None;

        Button resume = root.Q<Button>("Resume");
        resume.RegisterCallback<NavigationSubmitEvent>(_ => Resume());
        resume.RegisterCallback<ClickEvent>(_ => Resume());

        Button muteMusic = root.Q<Button>("MuteMusic");
        muteMusic.RegisterCallback<NavigationSubmitEvent>(_ => ToggleMusic());
        muteMusic.RegisterCallback<ClickEvent>(_ => ToggleMusic());

        Button muteSFX = root.Q<Button>("MuteSFX");
        muteSFX.RegisterCallback<NavigationSubmitEvent>(_ => ToggleSFX());
        muteSFX.RegisterCallback<ClickEvent>(_ => ToggleSFX());

        Slider volumeSlider = root.Q<Slider>("VolumeLevel");
        volumeSlider.RegisterValueChangedCallback(_ => SoundManager.Instance.SetVolume(_.newValue));

        Button reload = root.Query<Button>("Reload");
        reload.RegisterCallback<NavigationSubmitEvent>(_ => LevelState.Instance.ReloadGame());
        reload.RegisterCallback<ClickEvent>(_ => LevelState.Instance.ReloadGame());

        Button mainMenu = root.Query<Button>("MainMenu");
        mainMenu.RegisterCallback<NavigationSubmitEvent>(_ => LevelState.Instance.ReloadMainMenu());
        mainMenu.RegisterCallback<ClickEvent>(_ => LevelState.Instance.ReloadMainMenu());

        Button quit = root.Query<Button>("Quit");
        mainMenu.RegisterCallback<NavigationSubmitEvent>(_ => Application.Quit());
        mainMenu.RegisterCallback<ClickEvent>(_ => Application.Quit());

        AddNavigationSound();
    }

    private void AddNavigationSound()
    {
        List<Button> navigationElements = root.Query<Button>(null, "button").ToList();
        foreach (Button btn in navigationElements)
        {
            btn.RegisterCallback<NavigationSubmitEvent>(_ => SoundManager.Instance.PlaySound(clickSound));
            btn.RegisterCallback<ClickEvent>(_ => SoundManager.Instance.PlaySound(clickSound));
            btn.RegisterCallback<FocusInEvent>(e => SoundManager.Instance.PlaySound(navigationSound));
            btn.RegisterCallback<MouseOverEvent>(_ => SoundManager.Instance.PlaySound(navigationSound));
        }
    }

    private void ToggleMusic()
    {
        SoundManager.Instance.ToggleMusic();
        root.Q<Button>("MuteMusic").style.backgroundImage = new StyleBackground(SoundManager.Instance.MusicMuted ? muteMusicIcon : unMuteMusicIcon);
        UpdateVolumeDisplay();
    }

    private void ToggleSFX()
    {
        SoundManager.Instance.ToggleSFX();
        UpdateVolumeDisplay();
    }

    private void UpdateVolumeDisplay()
    {
        root.Q<Button>("MuteMusic").style.backgroundImage = new StyleBackground(SoundManager.Instance.MusicMuted ? muteMusicIcon : unMuteMusicIcon);
        root.Q<Button>("MuteSFX").style.backgroundImage = new StyleBackground(SoundManager.Instance.SFXMuted ? muteSFXIcon : unMuteSFXIcon);
        root.Q<Slider>("VolumeLevel").value = AudioListener.volume;
    }

    public void Pause(CallbackContext context)
    {
        if (context.started)
        {
            Time.timeScale = 0;
            UpdateVolumeDisplay();
            root.style.display = DisplayStyle.Flex;
        }
    }

    private void Resume()
    {
        Time.timeScale = 1;
        root.style.display = DisplayStyle.None;
    }
}
