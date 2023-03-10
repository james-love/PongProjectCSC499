using System;
using System.Collections.Generic;
using UnityEngine.UIElements;

public class Selector<T> where T : Enum
{
    protected int value;
    protected Dictionary<T, string> options;

    public delegate void ValueChangedEvent(T newValue);
    public event ValueChangedEvent OnValueChanged;

    public Selector(VisualElement selector, Dictionary<T, string> options)
    {
        this.options = options;
        this.value = default;
        selector.Q<Button>("Left").RegisterCallback<ClickEvent>(_ => this.CycleValue(-1));
        selector.Q<Button>("Right").RegisterCallback<ClickEvent>(_ => this.CycleValue(1));
    }

    virtual protected void CycleValue(int adj)
    {
        if (value + adj < 0)
            value = options.Count - 1;
        else if (value + adj >= options.Count)
            value = 0;
        else
            value += adj;

        if (OnValueChanged != null)
            OnValueChanged((T)(object)value);
    }
}

public class SelectorWithDisplay<T> : Selector<T> where T : Enum
{
    private Label display;

    public SelectorWithDisplay(VisualElement selector, Dictionary<T, string> options)
        : base(selector, options)
    {
        this.display = selector.Q<Label>("Display");
        this.UpdateDisplay();
    }
    protected override void CycleValue(int adj)
    {
        base.CycleValue(adj);
        this.UpdateDisplay();
    }

    private void UpdateDisplay()
    {
        display.text = options[(T)(object)value];
    }
}
