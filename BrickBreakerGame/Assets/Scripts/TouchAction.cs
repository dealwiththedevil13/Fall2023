// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/TouchAction.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @TouchAction : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @TouchAction()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""TouchAction"",
    ""maps"": [
        {
            ""name"": ""Touch"",
            ""id"": ""02087915-cf0c-46fc-a837-6beee556ac7b"",
            ""actions"": [
                {
                    ""name"": ""MoveLeft"",
                    ""type"": ""Value"",
                    ""id"": ""503bbf96-d563-4137-9555-4f01fe080b8e"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveRight"",
                    ""type"": ""Value"",
                    ""id"": ""b2e2f48c-3c09-4c36-ab00-92c1136c05fc"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""159065fe-af10-476b-9eb0-dc08ba36cb78"",
                    ""path"": ""<Touchscreen>/position"",
                    ""interactions"": ""Tap"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""22682d19-7a77-45a5-8929-0c447042c5ce"",
                    ""path"": ""<Touchscreen>/position"",
                    ""interactions"": ""Tap"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Touch
        m_Touch = asset.FindActionMap("Touch", throwIfNotFound: true);
        m_Touch_MoveLeft = m_Touch.FindAction("MoveLeft", throwIfNotFound: true);
        m_Touch_MoveRight = m_Touch.FindAction("MoveRight", throwIfNotFound: true);
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

    // Touch
    private readonly InputActionMap m_Touch;
    private ITouchActions m_TouchActionsCallbackInterface;
    private readonly InputAction m_Touch_MoveLeft;
    private readonly InputAction m_Touch_MoveRight;
    public struct TouchActions
    {
        private @TouchAction m_Wrapper;
        public TouchActions(@TouchAction wrapper) { m_Wrapper = wrapper; }
        public InputAction @MoveLeft => m_Wrapper.m_Touch_MoveLeft;
        public InputAction @MoveRight => m_Wrapper.m_Touch_MoveRight;
        public InputActionMap Get() { return m_Wrapper.m_Touch; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(TouchActions set) { return set.Get(); }
        public void SetCallbacks(ITouchActions instance)
        {
            if (m_Wrapper.m_TouchActionsCallbackInterface != null)
            {
                @MoveLeft.started -= m_Wrapper.m_TouchActionsCallbackInterface.OnMoveLeft;
                @MoveLeft.performed -= m_Wrapper.m_TouchActionsCallbackInterface.OnMoveLeft;
                @MoveLeft.canceled -= m_Wrapper.m_TouchActionsCallbackInterface.OnMoveLeft;
                @MoveRight.started -= m_Wrapper.m_TouchActionsCallbackInterface.OnMoveRight;
                @MoveRight.performed -= m_Wrapper.m_TouchActionsCallbackInterface.OnMoveRight;
                @MoveRight.canceled -= m_Wrapper.m_TouchActionsCallbackInterface.OnMoveRight;
            }
            m_Wrapper.m_TouchActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MoveLeft.started += instance.OnMoveLeft;
                @MoveLeft.performed += instance.OnMoveLeft;
                @MoveLeft.canceled += instance.OnMoveLeft;
                @MoveRight.started += instance.OnMoveRight;
                @MoveRight.performed += instance.OnMoveRight;
                @MoveRight.canceled += instance.OnMoveRight;
            }
        }
    }
    public TouchActions @Touch => new TouchActions(this);
    public interface ITouchActions
    {
        void OnMoveLeft(InputAction.CallbackContext context);
        void OnMoveRight(InputAction.CallbackContext context);
    }
}
