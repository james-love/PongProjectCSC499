using UnityEngine.UIElements;

public static class Navigation
{
    public static void OverrideNavigation(VisualElement element, VisualElement left = null, VisualElement right = null, VisualElement up = null, VisualElement down = null, VisualElement scoreContainer = null, VisualElement scoreSlider = null)
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
