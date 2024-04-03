//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.5.1
//     from Assets/Joystick Controls.inputactions
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

public partial class @JoystickControls: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @JoystickControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Joystick Controls"",
    ""maps"": [
        {
            ""name"": ""Gameplay"",
            ""id"": ""b19e0dab-a671-44ed-82fe-4685d95bac2f"",
            ""actions"": [
                {
                    ""name"": ""Thruster"",
                    ""type"": ""Value"",
                    ""id"": ""825ef9d8-38c9-4acb-9f8a-c942d7a3f492"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Joystick"",
                    ""type"": ""Value"",
                    ""id"": ""55f15aa1-b1bd-4272-ade6-6732766df884"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""MaxSpeed1"",
                    ""type"": ""Button"",
                    ""id"": ""6760b65e-d97e-4310-b936-04749eae813e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""MaxSpeed2"",
                    ""type"": ""Button"",
                    ""id"": ""c8ecf94c-f9db-4470-9315-32bdd1bbd993"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""MaxSpeed3"",
                    ""type"": ""Button"",
                    ""id"": ""bee8050c-291c-47b8-a04d-64916dbbd152"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Left"",
                    ""type"": ""Button"",
                    ""id"": ""51eb7f95-0770-4e02-90e4-985cc5231c0b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Right"",
                    ""type"": ""Button"",
                    ""id"": ""393fbfd6-f0b1-42fa-967c-1ada682717c7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Up"",
                    ""type"": ""Button"",
                    ""id"": ""7a84a8cd-12e8-4cd2-80c8-64388557173c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Down"",
                    ""type"": ""Button"",
                    ""id"": ""55309688-7867-443a-ab1d-ea7bbc31ea71"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ResetScene"",
                    ""type"": ""Button"",
                    ""id"": ""d0ec507a-4388-476e-a3cd-0c957c3acb3c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""eefd3f16-81dc-47d4-8a4e-4de7f908ae13"",
                    ""path"": ""<HID::Thrustmaster T.16000M>/slider"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Thruster"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""69d4ded2-f0cb-4b2c-b7cd-8b420b6d8b2d"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Thruster"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""212fc295-4a4a-4680-8632-ac798b256376"",
                    ""path"": ""<HID::Mad Catz Saitek Pro Flight X-56 Rhino Throttle>/stick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Thruster"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""da639a3b-cfa5-4d26-b0b6-4a3ee37b3f97"",
                    ""path"": ""<HID::Thrustmaster T.16000M>/stick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Joystick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""eac62991-5088-4646-b45d-65b4d1513d89"",
                    ""path"": ""<HID::Mad Catz Saitek Pro Flight X-56 Rhino Stick>/stick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Joystick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d20de8e4-ab20-4d82-88de-704077ef7d21"",
                    ""path"": ""<Keyboard>/f1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MaxSpeed1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""08140320-a55e-4700-b275-cf35a8eac1c8"",
                    ""path"": ""<Keyboard>/f2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MaxSpeed2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""33513ea6-4eca-4852-a9be-6ace452d59f1"",
                    ""path"": ""<Keyboard>/f3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MaxSpeed3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4ce7fb52-aba2-40e4-bed2-5b7e09d43a61"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5fb8398b-c79b-4620-9a7b-82f65b763f2a"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4f7620ac-79fc-4120-93c7-064b49391481"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""500fb981-749c-4163-a54d-61e6764a947e"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d3c833da-4da9-48bf-ace8-034fc16586f2"",
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
                    ""id"": ""73c59498-5f23-4d63-bd5b-ee4e2cf9c51a"",
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
                    ""id"": ""cb22c93c-6762-4918-92f5-452c529cb665"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ResetScene"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Gameplay
        m_Gameplay = asset.FindActionMap("Gameplay", throwIfNotFound: true);
        m_Gameplay_Thruster = m_Gameplay.FindAction("Thruster", throwIfNotFound: true);
        m_Gameplay_Joystick = m_Gameplay.FindAction("Joystick", throwIfNotFound: true);
        m_Gameplay_MaxSpeed1 = m_Gameplay.FindAction("MaxSpeed1", throwIfNotFound: true);
        m_Gameplay_MaxSpeed2 = m_Gameplay.FindAction("MaxSpeed2", throwIfNotFound: true);
        m_Gameplay_MaxSpeed3 = m_Gameplay.FindAction("MaxSpeed3", throwIfNotFound: true);
        m_Gameplay_Left = m_Gameplay.FindAction("Left", throwIfNotFound: true);
        m_Gameplay_Right = m_Gameplay.FindAction("Right", throwIfNotFound: true);
        m_Gameplay_Up = m_Gameplay.FindAction("Up", throwIfNotFound: true);
        m_Gameplay_Down = m_Gameplay.FindAction("Down", throwIfNotFound: true);
        m_Gameplay_ResetScene = m_Gameplay.FindAction("ResetScene", throwIfNotFound: true);
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

    // Gameplay
    private readonly InputActionMap m_Gameplay;
    private List<IGameplayActions> m_GameplayActionsCallbackInterfaces = new List<IGameplayActions>();
    private readonly InputAction m_Gameplay_Thruster;
    private readonly InputAction m_Gameplay_Joystick;
    private readonly InputAction m_Gameplay_MaxSpeed1;
    private readonly InputAction m_Gameplay_MaxSpeed2;
    private readonly InputAction m_Gameplay_MaxSpeed3;
    private readonly InputAction m_Gameplay_Left;
    private readonly InputAction m_Gameplay_Right;
    private readonly InputAction m_Gameplay_Up;
    private readonly InputAction m_Gameplay_Down;
    private readonly InputAction m_Gameplay_ResetScene;
    public struct GameplayActions
    {
        private @JoystickControls m_Wrapper;
        public GameplayActions(@JoystickControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Thruster => m_Wrapper.m_Gameplay_Thruster;
        public InputAction @Joystick => m_Wrapper.m_Gameplay_Joystick;
        public InputAction @MaxSpeed1 => m_Wrapper.m_Gameplay_MaxSpeed1;
        public InputAction @MaxSpeed2 => m_Wrapper.m_Gameplay_MaxSpeed2;
        public InputAction @MaxSpeed3 => m_Wrapper.m_Gameplay_MaxSpeed3;
        public InputAction @Left => m_Wrapper.m_Gameplay_Left;
        public InputAction @Right => m_Wrapper.m_Gameplay_Right;
        public InputAction @Up => m_Wrapper.m_Gameplay_Up;
        public InputAction @Down => m_Wrapper.m_Gameplay_Down;
        public InputAction @ResetScene => m_Wrapper.m_Gameplay_ResetScene;
        public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        public void AddCallbacks(IGameplayActions instance)
        {
            if (instance == null || m_Wrapper.m_GameplayActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_GameplayActionsCallbackInterfaces.Add(instance);
            @Thruster.started += instance.OnThruster;
            @Thruster.performed += instance.OnThruster;
            @Thruster.canceled += instance.OnThruster;
            @Joystick.started += instance.OnJoystick;
            @Joystick.performed += instance.OnJoystick;
            @Joystick.canceled += instance.OnJoystick;
            @MaxSpeed1.started += instance.OnMaxSpeed1;
            @MaxSpeed1.performed += instance.OnMaxSpeed1;
            @MaxSpeed1.canceled += instance.OnMaxSpeed1;
            @MaxSpeed2.started += instance.OnMaxSpeed2;
            @MaxSpeed2.performed += instance.OnMaxSpeed2;
            @MaxSpeed2.canceled += instance.OnMaxSpeed2;
            @MaxSpeed3.started += instance.OnMaxSpeed3;
            @MaxSpeed3.performed += instance.OnMaxSpeed3;
            @MaxSpeed3.canceled += instance.OnMaxSpeed3;
            @Left.started += instance.OnLeft;
            @Left.performed += instance.OnLeft;
            @Left.canceled += instance.OnLeft;
            @Right.started += instance.OnRight;
            @Right.performed += instance.OnRight;
            @Right.canceled += instance.OnRight;
            @Up.started += instance.OnUp;
            @Up.performed += instance.OnUp;
            @Up.canceled += instance.OnUp;
            @Down.started += instance.OnDown;
            @Down.performed += instance.OnDown;
            @Down.canceled += instance.OnDown;
            @ResetScene.started += instance.OnResetScene;
            @ResetScene.performed += instance.OnResetScene;
            @ResetScene.canceled += instance.OnResetScene;
        }

        private void UnregisterCallbacks(IGameplayActions instance)
        {
            @Thruster.started -= instance.OnThruster;
            @Thruster.performed -= instance.OnThruster;
            @Thruster.canceled -= instance.OnThruster;
            @Joystick.started -= instance.OnJoystick;
            @Joystick.performed -= instance.OnJoystick;
            @Joystick.canceled -= instance.OnJoystick;
            @MaxSpeed1.started -= instance.OnMaxSpeed1;
            @MaxSpeed1.performed -= instance.OnMaxSpeed1;
            @MaxSpeed1.canceled -= instance.OnMaxSpeed1;
            @MaxSpeed2.started -= instance.OnMaxSpeed2;
            @MaxSpeed2.performed -= instance.OnMaxSpeed2;
            @MaxSpeed2.canceled -= instance.OnMaxSpeed2;
            @MaxSpeed3.started -= instance.OnMaxSpeed3;
            @MaxSpeed3.performed -= instance.OnMaxSpeed3;
            @MaxSpeed3.canceled -= instance.OnMaxSpeed3;
            @Left.started -= instance.OnLeft;
            @Left.performed -= instance.OnLeft;
            @Left.canceled -= instance.OnLeft;
            @Right.started -= instance.OnRight;
            @Right.performed -= instance.OnRight;
            @Right.canceled -= instance.OnRight;
            @Up.started -= instance.OnUp;
            @Up.performed -= instance.OnUp;
            @Up.canceled -= instance.OnUp;
            @Down.started -= instance.OnDown;
            @Down.performed -= instance.OnDown;
            @Down.canceled -= instance.OnDown;
            @ResetScene.started -= instance.OnResetScene;
            @ResetScene.performed -= instance.OnResetScene;
            @ResetScene.canceled -= instance.OnResetScene;
        }

        public void RemoveCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IGameplayActions instance)
        {
            foreach (var item in m_Wrapper.m_GameplayActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_GameplayActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public GameplayActions @Gameplay => new GameplayActions(this);
    public interface IGameplayActions
    {
        void OnThruster(InputAction.CallbackContext context);
        void OnJoystick(InputAction.CallbackContext context);
        void OnMaxSpeed1(InputAction.CallbackContext context);
        void OnMaxSpeed2(InputAction.CallbackContext context);
        void OnMaxSpeed3(InputAction.CallbackContext context);
        void OnLeft(InputAction.CallbackContext context);
        void OnRight(InputAction.CallbackContext context);
        void OnUp(InputAction.CallbackContext context);
        void OnDown(InputAction.CallbackContext context);
        void OnResetScene(InputAction.CallbackContext context);
    }
}
