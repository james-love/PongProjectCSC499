using System;
using System.Collections.Generic;
using UnityEngine.UIElements;

public class SelectorWithDisplay<T> : Selector<T>
    where T : Enum
{
    private readonly Label display;

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
        display.text = Options[(T)(object)Value];
    }
}
