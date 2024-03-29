//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Scripts/Player/PlayerControls.inputactions
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

public partial class @PlayerControls: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""e2a8b612-a6ab-46a4-ba66-f290305ba488"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""9575f750-de23-4a9f-b636-a500ffe59216"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""bcdb6914-9155-41e1-99f2-9e5e06bb766d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""BuffTest"",
                    ""type"": ""Button"",
                    ""id"": ""8f156942-18a4-4f6a-b2b6-e03e7ad7d564"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""DropScore"",
                    ""type"": ""Button"",
                    ""id"": ""d51c0d36-b622-46c7-8a32-8c3f4e5b9175"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""DropPrank"",
                    ""type"": ""Button"",
                    ""id"": ""9b9d246c-c75f-4135-95d9-e95984b8ddea"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""UsePrank"",
                    ""type"": ""Button"",
                    ""id"": ""75f3d068-a2d6-4674-a2df-977ab02a68f5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""40dea3c1-a24e-4b96-bae9-bfb9304d3e43"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""left"",
                    ""id"": ""2a75d4c7-9d9a-4ec8-9654-8da467124406"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""LeftKeyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""70734922-96da-4b6f-ac71-b53b508ca701"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""LeftKeyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""a3a3dfd3-ce1b-44ba-9fca-a7aab49eee9c"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""left"",
                    ""id"": ""f8d8b14b-a96b-4e66-9296-0d9a5d27fb54"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""RightKeyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""5481f579-0269-43e7-b69f-3701bd1ae5ac"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""RightKeyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""7864a676-c815-422f-ace9-942de0f1cf18"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""LeftKeyboard"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e2ea4ba8-7f79-4cc5-90ab-054d51d2f2fc"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""RightKeyboard"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e925063a-3e69-43a3-9b02-d371434148d8"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": ""Scale"",
                    ""groups"": ""LeftKeyboard"",
                    ""action"": ""BuffTest"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1520efb9-61f3-4023-a911-5d8ad86acf46"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": ""Scale(factor=2)"",
                    ""groups"": ""LeftKeyboard"",
                    ""action"": ""BuffTest"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f836e06b-5745-48d9-91fd-c4f930e94d2b"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": """",
                    ""processors"": ""Scale(factor=3)"",
                    ""groups"": ""LeftKeyboard"",
                    ""action"": ""BuffTest"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a16227fc-1c18-4a55-9976-340b6487bdb9"",
                    ""path"": ""<Keyboard>/4"",
                    ""interactions"": """",
                    ""processors"": ""Scale(factor=4)"",
                    ""groups"": ""LeftKeyboard"",
                    ""action"": ""BuffTest"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4e8fa064-0f48-4657-a28c-0edbc6ccdc52"",
                    ""path"": ""<Keyboard>/5"",
                    ""interactions"": """",
                    ""processors"": ""Scale(factor=5)"",
                    ""groups"": ""LeftKeyboard"",
                    ""action"": ""BuffTest"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c486c6cf-5902-413d-b52b-beeb04d4497a"",
                    ""path"": ""<Keyboard>/6"",
                    ""interactions"": """",
                    ""processors"": ""Scale(factor=6)"",
                    ""groups"": ""LeftKeyboard"",
                    ""action"": ""BuffTest"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4842081b-9006-4f39-a3a0-1cf9b978c8d7"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""LeftKeyboard"",
                    ""action"": ""DropScore"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4f535656-5bc5-4b7b-9a30-66b65ea506c6"",
                    ""path"": ""<Keyboard>/comma"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""RightKeyboard"",
                    ""action"": ""DropScore"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e35ca398-4e58-4836-bfe8-9c19e50d97a1"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""LeftKeyboard"",
                    ""action"": ""DropPrank"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bb531343-7d75-40d8-8975-a34a80551920"",
                    ""path"": ""<Keyboard>/period"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""RightKeyboard"",
                    ""action"": ""DropPrank"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""41ebc6a7-71cb-4969-9183-50f557100aae"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""LeftKeyboard"",
                    ""action"": ""UsePrank"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""86c21f4b-5028-4ac9-8fd7-f0e8f4d88917"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""RightKeyboard"",
                    ""action"": ""UsePrank"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""LeftKeyboard"",
            ""bindingGroup"": ""LeftKeyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""RightKeyboard"",
            ""bindingGroup"": ""RightKeyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Move = m_Player.FindAction("Move", throwIfNotFound: true);
        m_Player_Jump = m_Player.FindAction("Jump", throwIfNotFound: true);
        m_Player_BuffTest = m_Player.FindAction("BuffTest", throwIfNotFound: true);
        m_Player_DropScore = m_Player.FindAction("DropScore", throwIfNotFound: true);
        m_Player_DropPrank = m_Player.FindAction("DropPrank", throwIfNotFound: true);
        m_Player_UsePrank = m_Player.FindAction("UsePrank", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private List<IPlayerActions> m_PlayerActionsCallbackInterfaces = new List<IPlayerActions>();
    private readonly InputAction m_Player_Move;
    private readonly InputAction m_Player_Jump;
    private readonly InputAction m_Player_BuffTest;
    private readonly InputAction m_Player_DropScore;
    private readonly InputAction m_Player_DropPrank;
    private readonly InputAction m_Player_UsePrank;
    public struct PlayerActions
    {
        private @PlayerControls m_Wrapper;
        public PlayerActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Player_Move;
        public InputAction @Jump => m_Wrapper.m_Player_Jump;
        public InputAction @BuffTest => m_Wrapper.m_Player_BuffTest;
        public InputAction @DropScore => m_Wrapper.m_Player_DropScore;
        public InputAction @DropPrank => m_Wrapper.m_Player_DropPrank;
        public InputAction @UsePrank => m_Wrapper.m_Player_UsePrank;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void AddCallbacks(IPlayerActions instance)
        {
            if (instance == null || m_Wrapper.m_PlayerActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PlayerActionsCallbackInterfaces.Add(instance);
            @Move.started += instance.OnMove;
            @Move.performed += instance.OnMove;
            @Move.canceled += instance.OnMove;
            @Jump.started += instance.OnJump;
            @Jump.performed += instance.OnJump;
            @Jump.canceled += instance.OnJump;
            @BuffTest.started += instance.OnBuffTest;
            @BuffTest.performed += instance.OnBuffTest;
            @BuffTest.canceled += instance.OnBuffTest;
            @DropScore.started += instance.OnDropScore;
            @DropScore.performed += instance.OnDropScore;
            @DropScore.canceled += instance.OnDropScore;
            @DropPrank.started += instance.OnDropPrank;
            @DropPrank.performed += instance.OnDropPrank;
            @DropPrank.canceled += instance.OnDropPrank;
            @UsePrank.started += instance.OnUsePrank;
            @UsePrank.performed += instance.OnUsePrank;
            @UsePrank.canceled += instance.OnUsePrank;
        }

        private void UnregisterCallbacks(IPlayerActions instance)
        {
            @Move.started -= instance.OnMove;
            @Move.performed -= instance.OnMove;
            @Move.canceled -= instance.OnMove;
            @Jump.started -= instance.OnJump;
            @Jump.performed -= instance.OnJump;
            @Jump.canceled -= instance.OnJump;
            @BuffTest.started -= instance.OnBuffTest;
            @BuffTest.performed -= instance.OnBuffTest;
            @BuffTest.canceled -= instance.OnBuffTest;
            @DropScore.started -= instance.OnDropScore;
            @DropScore.performed -= instance.OnDropScore;
            @DropScore.canceled -= instance.OnDropScore;
            @DropPrank.started -= instance.OnDropPrank;
            @DropPrank.performed -= instance.OnDropPrank;
            @DropPrank.canceled -= instance.OnDropPrank;
            @UsePrank.started -= instance.OnUsePrank;
            @UsePrank.performed -= instance.OnUsePrank;
            @UsePrank.canceled -= instance.OnUsePrank;
        }

        public void RemoveCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlayerActions instance)
        {
            foreach (var item in m_Wrapper.m_PlayerActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PlayerActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    private int m_LeftKeyboardSchemeIndex = -1;
    public InputControlScheme LeftKeyboardScheme
    {
        get
        {
            if (m_LeftKeyboardSchemeIndex == -1) m_LeftKeyboardSchemeIndex = asset.FindControlSchemeIndex("LeftKeyboard");
            return asset.controlSchemes[m_LeftKeyboardSchemeIndex];
        }
    }
    private int m_RightKeyboardSchemeIndex = -1;
    public InputControlScheme RightKeyboardScheme
    {
        get
        {
            if (m_RightKeyboardSchemeIndex == -1) m_RightKeyboardSchemeIndex = asset.FindControlSchemeIndex("RightKeyboard");
            return asset.controlSchemes[m_RightKeyboardSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnBuffTest(InputAction.CallbackContext context);
        void OnDropScore(InputAction.CallbackContext context);
        void OnDropPrank(InputAction.CallbackContext context);
        void OnUsePrank(InputAction.CallbackContext context);
    }
}
