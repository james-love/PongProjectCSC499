//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.5.0
//     from Assets/Controls/Controls.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @Controls: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""Menu"",
            ""id"": ""ac1610d9-f5df-4489-9e48-7feb64baed5c"",
            ""actions"": [
                {
                    ""name"": ""Up"",
                    ""type"": ""Button"",
                    ""id"": ""4ba88344-a166-47fa-8879-4b4c94b271ed"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Down"",
                    ""type"": ""Button"",
                    ""id"": ""aa10679f-1ad2-4f75-9e14-f4a5eef11903"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Select"",
                    ""type"": ""Button"",
                    ""id"": ""dd6f1d2a-49ae-4cf9-9b83-0732f89a40ec"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Back"",
                    ""type"": ""Button"",
                    ""id"": ""a28668cf-d031-4557-b96f-5a98f0348b66"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""af6c3e7d-dc90-4b4c-ae4d-7e83fe5ff46d"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f7e200ee-6622-4437-b5ee-f18aaa216b63"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""da82572f-2ca4-450f-a20f-ea52e63deec1"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5b0ad673-9909-4a50-aa91-734e797b3d18"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2183ad8c-2463-40fb-9661-f8005f1c5cce"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9749db6a-d885-4111-bb9c-51e81bc35065"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7827f67f-89b2-4deb-bfa5-b3bac559bfee"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b2109992-44a7-40a1-b4bc-e73c373faeb0"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b324098b-2dbf-4e14-ba1d-82c7be26677d"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Back"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dcd229db-63b3-4cd7-80b1-565f0774e42e"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Back"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""02e8bba1-4cdf-437c-81f2-f64926eb2e54"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Back"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""67e8bb6f-8bd7-4ff4-8c55-8f7128fe1e38"",
                    ""path"": ""<Keyboard>/backspace"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Back"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""SinglePlayer"",
            ""id"": ""b6463d74-8fe1-4bce-a316-75d0803163c9"",
            ""actions"": [
                {
                    ""name"": ""Up"",
                    ""type"": ""Button"",
                    ""id"": ""a916968c-7b82-451b-a2b0-d357eeb94065"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Down"",
                    ""type"": ""Button"",
                    ""id"": ""35b45f42-d88d-497d-ae7a-2231f81076c1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""081eff8a-cc99-4ebc-8314-b092b486cfa8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""f86e920c-23f8-4860-8a7d-5dbe28385c4c"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""48f265ae-1132-480d-95d4-d3142029a27d"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""82f739fb-2172-4722-a904-4bc69f64603e"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""258df8b5-fd56-4457-985c-d72aabcbc5a3"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1b89decb-b8bb-4533-9756-12bbcdaca324"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""359ad702-ce7e-4f26-8484-00fb753fe3f0"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""628bcefd-8222-4b4d-adc9-f8334adb6bd4"",
                    ""path"": ""<Keyboard>/backspace"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7025b3a0-f316-4197-97bb-d11834b89104"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4f95e574-0d9e-4cc7-8ac2-e38ceed6bff5"",
                    ""path"": ""<Keyboard>/p"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""TwoPlayer"",
            ""id"": ""d77b6f29-cbc3-42e5-8a95-6f77aec613bf"",
            ""actions"": [
                {
                    ""name"": ""LeftPlayerUp"",
                    ""type"": ""Button"",
                    ""id"": ""11606118-8e3c-4d10-9213-e0a429db5674"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""LeftPlayerDown"",
                    ""type"": ""Button"",
                    ""id"": ""b69982d2-074d-4ff6-badc-609121de4e79"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""RightPlayerUp"",
                    ""type"": ""Button"",
                    ""id"": ""ce67ade1-0113-47cb-97f4-d83f32fbcb5f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""RightPlayerDown"",
                    ""type"": ""Button"",
                    ""id"": ""cdb7b959-837c-449c-8eef-a65dcf10d1de"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""5389c61e-da8f-401b-9820-58e91d8526b1"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftPlayerUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""788b710d-4394-4a13-a81b-6d97ae8a9e6a"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftPlayerDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""67e09de4-21b8-45eb-82c2-ca27dc54ec5e"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightPlayerUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""79328574-7d2c-40f0-a77a-1255d539c341"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightPlayerDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Menu
        m_Menu = asset.FindActionMap("Menu", throwIfNotFound: true);
        m_Menu_Up = m_Menu.FindAction("Up", throwIfNotFound: true);
        m_Menu_Down = m_Menu.FindAction("Down", throwIfNotFound: true);
        m_Menu_Select = m_Menu.FindAction("Select", throwIfNotFound: true);
        m_Menu_Back = m_Menu.FindAction("Back", throwIfNotFound: true);
        // SinglePlayer
        m_SinglePlayer = asset.FindActionMap("SinglePlayer", throwIfNotFound: true);
        m_SinglePlayer_Up = m_SinglePlayer.FindAction("Up", throwIfNotFound: true);
        m_SinglePlayer_Down = m_SinglePlayer.FindAction("Down", throwIfNotFound: true);
        m_SinglePlayer_Pause = m_SinglePlayer.FindAction("Pause", throwIfNotFound: true);
        // TwoPlayer
        m_TwoPlayer = asset.FindActionMap("TwoPlayer", throwIfNotFound: true);
        m_TwoPlayer_LeftPlayerUp = m_TwoPlayer.FindAction("LeftPlayerUp", throwIfNotFound: true);
        m_TwoPlayer_LeftPlayerDown = m_TwoPlayer.FindAction("LeftPlayerDown", throwIfNotFound: true);
        m_TwoPlayer_RightPlayerUp = m_TwoPlayer.FindAction("RightPlayerUp", throwIfNotFound: true);
        m_TwoPlayer_RightPlayerDown = m_TwoPlayer.FindAction("RightPlayerDown", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Menu
    private readonly InputActionMap m_Menu;
    private List<IMenuActions> m_MenuActionsCallbackInterfaces = new List<IMenuActions>();
    private readonly InputAction m_Menu_Up;
    private readonly InputAction m_Menu_Down;
    private readonly InputAction m_Menu_Select;
    private readonly InputAction m_Menu_Back;
    public struct MenuActions
    {
        private @Controls m_Wrapper;
        public MenuActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Up => m_Wrapper.m_Menu_Up;
        public InputAction @Down => m_Wrapper.m_Menu_Down;
        public InputAction @Select => m_Wrapper.m_Menu_Select;
        public InputAction @Back => m_Wrapper.m_Menu_Back;
        public InputActionMap Get() { return m_Wrapper.m_Menu; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MenuActions set) { return set.Get(); }
        public void AddCallbacks(IMenuActions instance)
        {
            if (instance == null || m_Wrapper.m_MenuActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_MenuActionsCallbackInterfaces.Add(instance);
            @Up.started += instance.OnUp;
            @Up.performed += instance.OnUp;
            @Up.canceled += instance.OnUp;
            @Down.started += instance.OnDown;
            @Down.performed += instance.OnDown;
            @Down.canceled += instance.OnDown;
            @Select.started += instance.OnSelect;
            @Select.performed += instance.OnSelect;
            @Select.canceled += instance.OnSelect;
            @Back.started += instance.OnBack;
            @Back.performed += instance.OnBack;
            @Back.canceled += instance.OnBack;
        }

        private void UnregisterCallbacks(IMenuActions instance)
        {
            @Up.started -= instance.OnUp;
            @Up.performed -= instance.OnUp;
            @Up.canceled -= instance.OnUp;
            @Down.started -= instance.OnDown;
            @Down.performed -= instance.OnDown;
            @Down.canceled -= instance.OnDown;
            @Select.started -= instance.OnSelect;
            @Select.performed -= instance.OnSelect;
            @Select.canceled -= instance.OnSelect;
            @Back.started -= instance.OnBack;
            @Back.performed -= instance.OnBack;
            @Back.canceled -= instance.OnBack;
        }

        public void RemoveCallbacks(IMenuActions instance)
        {
            if (m_Wrapper.m_MenuActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IMenuActions instance)
        {
            foreach (var item in m_Wrapper.m_MenuActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_MenuActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public MenuActions @Menu => new MenuActions(this);

    // SinglePlayer
    private readonly InputActionMap m_SinglePlayer;
    private List<ISinglePlayerActions> m_SinglePlayerActionsCallbackInterfaces = new List<ISinglePlayerActions>();
    private readonly InputAction m_SinglePlayer_Up;
    private readonly InputAction m_SinglePlayer_Down;
    private readonly InputAction m_SinglePlayer_Pause;
    public struct SinglePlayerActions
    {
        private @Controls m_Wrapper;
        public SinglePlayerActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Up => m_Wrapper.m_SinglePlayer_Up;
        public InputAction @Down => m_Wrapper.m_SinglePlayer_Down;
        public InputAction @Pause => m_Wrapper.m_SinglePlayer_Pause;
        public InputActionMap Get() { return m_Wrapper.m_SinglePlayer; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(SinglePlayerActions set) { return set.Get(); }
        public void AddCallbacks(ISinglePlayerActions instance)
        {
            if (instance == null || m_Wrapper.m_SinglePlayerActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_SinglePlayerActionsCallbackInterfaces.Add(instance);
            @Up.started += instance.OnUp;
            @Up.performed += instance.OnUp;
            @Up.canceled += instance.OnUp;
            @Down.started += instance.OnDown;
            @Down.performed += instance.OnDown;
            @Down.canceled += instance.OnDown;
            @Pause.started += instance.OnPause;
            @Pause.performed += instance.OnPause;
            @Pause.canceled += instance.OnPause;
        }

        private void UnregisterCallbacks(ISinglePlayerActions instance)
        {
            @Up.started -= instance.OnUp;
            @Up.performed -= instance.OnUp;
            @Up.canceled -= instance.OnUp;
            @Down.started -= instance.OnDown;
            @Down.performed -= instance.OnDown;
            @Down.canceled -= instance.OnDown;
            @Pause.started -= instance.OnPause;
            @Pause.performed -= instance.OnPause;
            @Pause.canceled -= instance.OnPause;
        }

        public void RemoveCallbacks(ISinglePlayerActions instance)
        {
            if (m_Wrapper.m_SinglePlayerActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(ISinglePlayerActions instance)
        {
            foreach (var item in m_Wrapper.m_SinglePlayerActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_SinglePlayerActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public SinglePlayerActions @SinglePlayer => new SinglePlayerActions(this);

    // TwoPlayer
    private readonly InputActionMap m_TwoPlayer;
    private List<ITwoPlayerActions> m_TwoPlayerActionsCallbackInterfaces = new List<ITwoPlayerActions>();
    private readonly InputAction m_TwoPlayer_LeftPlayerUp;
    private readonly InputAction m_TwoPlayer_LeftPlayerDown;
    private readonly InputAction m_TwoPlayer_RightPlayerUp;
    private readonly InputAction m_TwoPlayer_RightPlayerDown;
    public struct TwoPlayerActions
    {
        private @Controls m_Wrapper;
        public TwoPlayerActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @LeftPlayerUp => m_Wrapper.m_TwoPlayer_LeftPlayerUp;
        public InputAction @LeftPlayerDown => m_Wrapper.m_TwoPlayer_LeftPlayerDown;
        public InputAction @RightPlayerUp => m_Wrapper.m_TwoPlayer_RightPlayerUp;
        public InputAction @RightPlayerDown => m_Wrapper.m_TwoPlayer_RightPlayerDown;
        public InputActionMap Get() { return m_Wrapper.m_TwoPlayer; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(TwoPlayerActions set) { return set.Get(); }
        public void AddCallbacks(ITwoPlayerActions instance)
        {
            if (instance == null || m_Wrapper.m_TwoPlayerActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_TwoPlayerActionsCallbackInterfaces.Add(instance);
            @LeftPlayerUp.started += instance.OnLeftPlayerUp;
            @LeftPlayerUp.performed += instance.OnLeftPlayerUp;
            @LeftPlayerUp.canceled += instance.OnLeftPlayerUp;
            @LeftPlayerDown.started += instance.OnLeftPlayerDown;
            @LeftPlayerDown.performed += instance.OnLeftPlayerDown;
            @LeftPlayerDown.canceled += instance.OnLeftPlayerDown;
            @RightPlayerUp.started += instance.OnRightPlayerUp;
            @RightPlayerUp.performed += instance.OnRightPlayerUp;
            @RightPlayerUp.canceled += instance.OnRightPlayerUp;
            @RightPlayerDown.started += instance.OnRightPlayerDown;
            @RightPlayerDown.performed += instance.OnRightPlayerDown;
            @RightPlayerDown.canceled += instance.OnRightPlayerDown;
        }

        private void UnregisterCallbacks(ITwoPlayerActions instance)
        {
            @LeftPlayerUp.started -= instance.OnLeftPlayerUp;
            @LeftPlayerUp.performed -= instance.OnLeftPlayerUp;
            @LeftPlayerUp.canceled -= instance.OnLeftPlayerUp;
            @LeftPlayerDown.started -= instance.OnLeftPlayerDown;
            @LeftPlayerDown.performed -= instance.OnLeftPlayerDown;
            @LeftPlayerDown.canceled -= instance.OnLeftPlayerDown;
            @RightPlayerUp.started -= instance.OnRightPlayerUp;
            @RightPlayerUp.performed -= instance.OnRightPlayerUp;
            @RightPlayerUp.canceled -= instance.OnRightPlayerUp;
            @RightPlayerDown.started -= instance.OnRightPlayerDown;
            @RightPlayerDown.performed -= instance.OnRightPlayerDown;
            @RightPlayerDown.canceled -= instance.OnRightPlayerDown;
        }

        public void RemoveCallbacks(ITwoPlayerActions instance)
        {
            if (m_Wrapper.m_TwoPlayerActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(ITwoPlayerActions instance)
        {
            foreach (var item in m_Wrapper.m_TwoPlayerActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_TwoPlayerActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public TwoPlayerActions @TwoPlayer => new TwoPlayerActions(this);
    public interface IMenuActions
    {
        void OnUp(InputAction.CallbackContext context);
        void OnDown(InputAction.CallbackContext context);
        void OnSelect(InputAction.CallbackContext context);
        void OnBack(InputAction.CallbackContext context);
    }
    public interface ISinglePlayerActions
    {
        void OnUp(InputAction.CallbackContext context);
        void OnDown(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
    }
    public interface ITwoPlayerActions
    {
        void OnLeftPlayerUp(InputAction.CallbackContext context);
        void OnLeftPlayerDown(InputAction.CallbackContext context);
        void OnRightPlayerUp(InputAction.CallbackContext context);
        void OnRightPlayerDown(InputAction.CallbackContext context);
    }
}