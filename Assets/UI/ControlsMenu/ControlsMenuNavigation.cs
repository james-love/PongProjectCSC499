using UnityEngine;
using UnityEngine.UIElements;

public class ControlsMenuNavigation : MonoBehaviour
{
    private void Awake()
    {
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;
        Button back = root.Q<Button>("Back");
        Button playerOneUpRebind = root.Query<VisualElement>("PlayerOne").Descendents<VisualElement>("RebindUp").Descendents<Button>("Rebind");
        Button playerOneUpReset = root.Query<VisualElement>("PlayerOne").Descendents<VisualElement>("RebindUp").Descendents<Button>("Reset");
        Button playerOneDownRebind = root.Query<VisualElement>("PlayerOne").Descendents<VisualElement>("RebindDown").Descendents<Button>("Rebind");
        Button playerOneDownReset = root.Query<VisualElement>("PlayerOne").Descendents<VisualElement>("RebindDown").Descendents<Button>("Reset");
        Button playerTwoUpRebind = root.Query<VisualElement>("PlayerTwo").Descendents<VisualElement>("RebindUp").Descendents<Button>("Rebind");
        Button playerTwoUpReset = root.Query<VisualElement>("PlayerTwo").Descendents<VisualElement>("RebindUp").Descendents<Button>("Reset");
        Button playerTwoDownRebind = root.Query<VisualElement>("PlayerTwo").Descendents<VisualElement>("RebindDown").Descendents<Button>("Rebind");
        Button playerTwoDownReset = root.Query<VisualElement>("PlayerTwo").Descendents<VisualElement>("RebindDown").Descendents<Button>("Reset");

        Navigation.OverrideNavigation(back, null, playerOneUpRebind, null, playerOneUpRebind);
        Navigation.OverrideNavigation(playerOneUpRebind, back, playerOneUpReset, back, playerOneDownRebind);
        Navigation.OverrideNavigation(playerOneUpReset, playerOneUpRebind, playerTwoUpRebind, back, playerOneDownReset);
        Navigation.OverrideNavigation(playerOneDownRebind, back, playerOneDownReset, playerOneUpRebind);
        Navigation.OverrideNavigation(playerOneDownReset, playerOneDownRebind, playerTwoDownRebind, playerOneUpReset);
        Navigation.OverrideNavigation(playerTwoUpRebind, playerOneUpReset, playerTwoUpReset, back, playerTwoDownRebind);
        Navigation.OverrideNavigation(playerTwoUpReset, playerTwoUpRebind, null, back, playerTwoDownReset);
        Navigation.OverrideNavigation(playerTwoDownRebind, playerOneDownReset, playerTwoDownReset, playerTwoUpRebind);
        Navigation.OverrideNavigation(playerTwoDownReset, playerTwoDownRebind, null, playerTwoUpReset);
    }
}
