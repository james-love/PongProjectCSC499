using UnityEngine;
using UnityEngine.UIElements;

public class PauseMenuNavigation : MonoBehaviour
{
    private void Awake()
    {
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;
        Button resume = root.Query<Button>("Resume");
        Button reload = root.Query<Button>("Reload");
        Button mainMenu = root.Query<Button>("MainMenu");
        Button quit = root.Query<Button>("Quit");
        Button muteMusic = root.Query<Button>("MuteMusic");
        Button muteSFX = root.Query<Button>("MuteSFX");
        Slider volume = root.Query<Slider>("VolumeLevel");

        Navigation.OverrideNavigation(resume, muteMusic, null, muteMusic, reload);
        Navigation.OverrideNavigation(reload, muteMusic, null, resume, mainMenu);
        Navigation.OverrideNavigation(mainMenu, muteMusic, null, reload, quit);
        Navigation.OverrideNavigation(quit, muteMusic, null, mainMenu);
        Navigation.OverrideNavigation(muteMusic, null, muteSFX, null, volume);
        Navigation.OverrideNavigation(muteSFX, muteMusic, resume, null, volume);
        Navigation.OverrideNavigation(volume, null, null, muteMusic, resume);
    }
}
