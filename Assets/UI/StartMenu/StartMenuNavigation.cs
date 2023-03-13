using UnityEngine;
using UnityEngine.UIElements;

public class StartMenuNavigation : MonoBehaviour
{
    private void Awake()
    {
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;
        Button back = root.Query<Button>("Back");
        Button play = root.Query<Button>("Play");
        Button themeLeft = root.Query<VisualElement>("Theme").Descendents<Button>("Left");
        Button themeRight = root.Query<VisualElement>("Theme").Descendents<Button>("Right");
        Button modeLeft = root.Query<VisualElement>("GameMode").Descendents<Button>("Left");
        Button modeRight = root.Query<VisualElement>("GameMode").Descendents<Button>("Right");
        Button powerupLeft = root.Query<VisualElement>("Powerups").Descendents<Button>("Left");
        Button powerupRight = root.Query<VisualElement>("Powerups").Descendents<Button>("Right");
        Button playersLeft = root.Query<VisualElement>("PlayerAmount").Descendents<Button>("Left");
        Button playersRight = root.Query<VisualElement>("PlayerAmount").Descendents<Button>("Right");
        VisualElement scoreContainer = root.Query<VisualElement>("Score");
        SliderInt scoreSlider = scoreContainer.Query<SliderInt>("Slider");

        Navigation.OverrideNavigation(back, null, themeLeft, null, themeLeft);
        Navigation.OverrideNavigation(play, powerupRight, null, powerupRight);
        Navigation.OverrideNavigation(themeLeft, back, themeRight, back, modeLeft);
        Navigation.OverrideNavigation(themeRight, themeLeft, playersLeft, back, modeRight);
        Navigation.OverrideNavigation(playersLeft, themeRight, playersRight, back, powerupLeft);
        Navigation.OverrideNavigation(playersRight, playersLeft, play, back, powerupRight);
        Navigation.OverrideNavigation(modeLeft, back, modeRight, themeLeft, play, scoreContainer, scoreSlider);
        Navigation.OverrideNavigation(modeRight, modeLeft, powerupLeft, themeRight, play, scoreContainer, scoreSlider);
        Navigation.OverrideNavigation(powerupLeft, modeRight, powerupRight, playersLeft, play);
        Navigation.OverrideNavigation(powerupRight, powerupLeft, play, playersRight, play);
        Navigation.OverrideNavigation(scoreSlider, null, null, modeLeft, play);
    }
}
