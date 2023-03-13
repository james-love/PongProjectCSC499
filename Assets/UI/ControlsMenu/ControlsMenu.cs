using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class ControlsMenu : MonoBehaviour
{
    [SerializeField] private InputActionAsset inputs;
    private void Start()
    {
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;

        Label overlay = root.Q<Label>("Overlay");

        InputAction p1Move = inputs.FindAction("Players/LeftPlayerMove");
        int p1Up = p1Move.bindings.IndexOf(b => b.name == "positive");
        int p1Down = p1Move.bindings.IndexOf(b => b.name == "negative");

        InputAction p2Move = inputs.FindAction("Players/RightPlayerMove");
        int p2Up = p2Move.bindings.IndexOf(b => b.name == "positive");
        int p2Down = p2Move.bindings.IndexOf(b => b.name == "negative");

        VisualElement rebindPlayerOneUp = root.Query<VisualElement>("PlayerOne").Descendents<VisualElement>("RebindUp");
        new RebindControl(rebindPlayerOneUp, p1Move, p1Up, overlay);

        VisualElement rebindPlayerOneDown = root.Query<VisualElement>("PlayerOne").Descendents<VisualElement>("RebindDown");
        new RebindControl(rebindPlayerOneDown, p1Move, p1Down, overlay);

        VisualElement rebindPlayerTwoUp = root.Query<VisualElement>("PlayerTwo").Descendents<VisualElement>("RebindUp");
        new RebindControl(rebindPlayerTwoUp, p2Move, p2Up, overlay);

        VisualElement rebindPlayerTwoDown = root.Query<VisualElement>("PlayerTwo").Descendents<VisualElement>("RebindDown");
        new RebindControl(rebindPlayerTwoDown, p2Move, p2Down, overlay);
    }

    private void OnEnable()
    {
        string rebinds = PlayerPrefs.GetString("rebinds");
        if (!string.IsNullOrEmpty(rebinds))
            inputs.LoadBindingOverridesFromJson(rebinds);
    }

    private void OnDisable()
    {
        string rebinds = inputs.SaveBindingOverridesAsJson();
        PlayerPrefs.SetString("rebinds", rebinds);
    }
}
