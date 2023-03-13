using UnityEngine;
using UnityEngine.UIElements;

public class NavigationOverides : MonoBehaviour
{
    private VisualElement root;

    private void Awake()
    {
        root = GetComponent<UIDocument>().rootVisualElement;
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

        OverrideNavigation(back, null, themeLeft, null, themeLeft);
        OverrideNavigation(play, powerupRight, null, powerupRight);
        OverrideNavigation(themeLeft, back, themeRight, back, modeLeft);
        OverrideNavigation(themeRight, themeLeft, playersLeft, back, modeRight);
        OverrideNavigation(playersLeft, themeRight, playersRight, back, powerupLeft);
        OverrideNavigation(playersRight, playersLeft, play, back, powerupRight);
        OverrideNavigation(modeLeft, back, modeRight, themeLeft, play, scoreContainer, scoreSlider);
        OverrideNavigation(modeRight, modeLeft, powerupLeft, themeRight, play, scoreContainer, scoreSlider);
        OverrideNavigation(powerupLeft, modeRight, powerupRight, playersLeft, play);
        OverrideNavigation(powerupRight, powerupLeft, play, playersRight, play);
        OverrideNavigation(scoreSlider, null, null, modeLeft, play);
    }

    private void OverrideNavigation(VisualElement element, VisualElement left = null, VisualElement right = null, VisualElement up = null, VisualElement down = null, VisualElement scoreContainer = null, VisualElement scoreSlider = null)
    {
        element.RegisterCallback<NavigationMoveEvent>(e =>
        {
            switch (e.direction)
            {
                case NavigationMoveEvent.Direction.Left:
                    left?.Focus();
                    break;
                case NavigationMoveEvent.Direction.Right:
                    right?.Focus();
                    break;
                case NavigationMoveEvent.Direction.Up:
                    up?.Focus();
                    break;
                case NavigationMoveEvent.Direction.Down:
                    if (scoreContainer != null && scoreContainer.visible)
                        scoreSlider.Focus();
                    else
                        down?.Focus();
                    break;
                default:
                    break;
            }

            e.PreventDefault();
        });
    }
}
