using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using static UnityEngine.InputSystem.InputAction;

public class PauseMenu : MonoBehaviour
{
    private VisualElement root;
    private void Awake()
    {
        root = GetComponent<UIDocument>().rootVisualElement;

        root.style.display = DisplayStyle.None;

        Button resume = root.Q<Button>("Resume");
        resume.RegisterCallback<NavigationSubmitEvent>(_ => Resume());
        resume.RegisterCallback<ClickEvent>(_ => Resume());
    }

    public void Pause(CallbackContext context)
    {
        if (context.started)
        {
            Time.timeScale = 0;
            root.style.display = DisplayStyle.Flex;
        }
    }

    private void Resume()
    {
        Time.timeScale = 1;
        root.style.display = DisplayStyle.None;
    }
}
