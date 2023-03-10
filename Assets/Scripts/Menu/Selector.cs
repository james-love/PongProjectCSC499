using System;
using System.Collections.Generic;
using UnityEngine.UIElements;

public class Selector<T>
    where T : Enum
{
    public Selector(VisualElement selector, Dictionary<T, string> options)
    {
        this.Options = options;
        this.Value = default;
        selector.Q<Button>("Left").RegisterCallback<ClickEvent>(_ => this.CycleValue(-1));
        selector.Q<Button>("Right").RegisterCallback<ClickEvent>(_ => this.CycleValue(1));
    }

    public delegate void ValueChangedEvent(T newValue);
    public event ValueChangedEvent OnValueChanged;
    protected int Value { get; set; }
    protected Dictionary<T, string> Options { get; set; }

    protected virtual void CycleValue(int adj)
    {
        if (Value + adj < 0)
            Value = Options.Count - 1;
        else if (Value + adj >= Options.Count)
            Value = 0;
        else
            Value += adj;

        OnValueChanged?.Invoke((T)(object)Value);
    }
}
