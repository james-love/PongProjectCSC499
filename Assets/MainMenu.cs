using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UIElements;
using static UnityEngine.Rendering.DebugUI.MessageBox;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private UIDocument _mainMenu;
    [SerializeField] private UIDocument _startMenu;
    [SerializeField] private LevelState _state;

    private void Awake()
    {
        LoadMainMenu();
    }
    private void LoadMainMenu()
    { 
        _startMenu.rootVisualElement.style.display = DisplayStyle.None;
        _mainMenu.rootVisualElement.style.display = DisplayStyle.Flex;

        Button start = _mainMenu.rootVisualElement.Q<Button>("Start");
        start.clicked -= LoadStartMenu;
        start.clicked += LoadStartMenu;

        Button quit = _mainMenu.rootVisualElement.Q<Button>("Quit");
        quit.clicked -= Application.Quit;
        quit.clicked += Application.Quit;
    }

    private void LoadStartMenu()
    {
        _mainMenu.rootVisualElement.style.display = DisplayStyle.None;
        _startMenu.rootVisualElement.style.display = DisplayStyle.Flex;

        Button back = _startMenu.rootVisualElement.Query<Button>("Back");
        back.clicked -= LoadMainMenu;
        back.clicked += LoadMainMenu;

        SelectorWithDisplay<Theme> themeControl = new(
            _startMenu.rootVisualElement.Query<VisualElement>("Theme").Children<VisualElement>("Selector"),
            MenuData.ThemeDescription
        );

        themeControl.OnValueChanged += _state.ThemeChanged;

        SelectorWithDisplay<Players> playersControl = new(
            _startMenu.rootVisualElement.Query<VisualElement>("PlayerAmount").Children<VisualElement>("Selector"),
            MenuData.PlayersDescription
        );

        playersControl.OnValueChanged += _state.PlayersChanged;

        SelectorWithDisplay<GameMode> modeControl = new(
            _startMenu.rootVisualElement.Query<VisualElement>("GameMode").Children<VisualElement>("Selector"),
            MenuData.GameModeDescription
        );

        modeControl.OnValueChanged += _state.GameModeChanged;
    }
}
