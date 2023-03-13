using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class RebindControl
{
    private InputActionRebindingExtensions.RebindingOperation rebindOperation;
    private int bindingIndex;
    private InputAction action;
    private Button rebindButton;
    private VisualElement overlay;

    public RebindControl(VisualElement control, InputAction action, int bindingIndex, VisualElement overlay)
    {
        this.bindingIndex = bindingIndex;
        this.action = action;
        this.overlay = overlay;

        rebindButton = control.Q<Button>("Rebind");
        Button resetBtn = control.Q<Button>("Reset");

        rebindButton.clicked += PerformInteractiveRebind;
        resetBtn.clicked += ResetToDefault;

        UpdateDisplay();
    }

    private void UpdateDisplay()
    {
        InputBinding binding = action.bindings[bindingIndex];
        rebindButton.text = binding.ToDisplayString();
    }

    private void ResetToDefault()
    {
        action.RemoveBindingOverride(bindingIndex);
        UpdateDisplay();
    }

    private void PerformInteractiveRebind()
    {
        rebindOperation?.Cancel();

        void CleanUp()
        {
            rebindOperation?.Dispose();
            rebindOperation = null;
        }

        rebindOperation = action.PerformInteractiveRebinding(bindingIndex)
            .OnCancel(
                operation =>
                {
                    CleanUp();
                    UpdateDisplay();
                    overlay.style.display = DisplayStyle.None;
                })
            .OnComplete(
                operation =>
                {
                    CleanUp();
                    UpdateDisplay();
                    overlay.style.display = DisplayStyle.None;
                });

        overlay.style.display = DisplayStyle.Flex;

        rebindOperation.Start();
    }
}
