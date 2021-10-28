// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/PeripheriqueEntree.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PeripheriqueEntree : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PeripheriqueEntree()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PeripheriqueEntree"",
    ""maps"": [
        {
            ""name"": ""JoueurAuSol"",
            ""id"": ""2f51db60-28ce-4c0a-b41f-e31ffe4b8b89"",
            ""actions"": [
                {
                    ""name"": ""Deplacer"",
                    ""type"": ""Value"",
                    ""id"": ""8498f97a-afe6-4972-8240-e08cc5f4d79a"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Sauter"",
                    ""type"": ""Button"",
                    ""id"": ""a95b7c5d-2cea-4565-84ea-6dda20584593"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Regarder"",
                    ""type"": ""Value"",
                    ""id"": ""5ec7c32f-e235-408c-96dd-fa8a109022fa"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Cliquer"",
                    ""type"": ""Button"",
                    ""id"": ""459abfff-37c5-46d6-b0de-9a34dbcc89f0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Courrir"",
                    ""type"": ""Button"",
                    ""id"": ""4ef5014f-4637-421c-8bc2-b873ee508c71"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ChangementCamera"",
                    ""type"": ""Button"",
                    ""id"": ""ce3426f8-13ea-4868-be87-5d07fb7236bc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""ecd185d6-f282-4555-83a8-4be618d19383"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Deplacer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""944f8cb6-1286-4aa7-8aae-e6ba3e32ade2"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Deplacer"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""3df0465f-8864-4cd3-abd3-8889faef39b9"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Deplacer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""3a864e6f-2d09-4bf9-8e37-0aa1432a5d05"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Deplacer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""11c03937-6c44-42d9-8488-fe5ad61ca2d3"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Deplacer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""d59f73a1-8a1b-41e9-8cc7-9ed722aa7ec3"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Deplacer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Fleches"",
                    ""id"": ""6b3fc52f-736d-4c76-b608-7e588c7e13af"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Deplacer"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""f3a9f2ee-a397-4949-afc6-112e09b768a1"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Deplacer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""cd752176-afac-4b97-9c19-92f3e7812c9a"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Deplacer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""470b8b4f-0f28-4df0-81ad-f4e40f299fe0"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Deplacer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""c55d23f8-13be-408e-a061-cc8d64502d36"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Deplacer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""d2f6b216-2751-4983-b6bb-bf2581cdd193"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Sauter"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f244b637-973e-42a1-b800-c592e2e57327"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Sauter"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""af7ad525-47f3-49e7-9163-ebfaac17ba99"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Regarder"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""94cea915-4f70-4972-9d4b-c2de636f7dcb"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Regarder"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""904f906f-d873-43ef-8caf-d788934837b7"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cliquer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""798d9f48-a236-44f2-b725-bd1e7c8c2de9"",
                    ""path"": ""<Keyboard>/leftCtrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cliquer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""467dc0f8-35ce-435f-9ced-e85ef8c8d950"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cliquer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""19f676a6-2187-4a98-b2ca-c73cbe129b82"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Courrir"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""514a9aa2-1e54-41c0-8329-5a8a30d557a7"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChangementCamera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""JoueuDansEau"",
            ""id"": ""fbce2ea9-c54d-4159-bd52-bdd8839fc44c"",
            ""actions"": [
                {
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""fc83bec9-7f84-47c3-b12e-9e1da03ade96"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""007716d9-51d4-4bfe-a701-821299d70cc8"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""SacADos"",
            ""id"": ""1b65c5b0-5a9d-402d-9a24-b217ab0e8ddd"",
            ""actions"": [
                {
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""94037c87-a9b4-4426-9bb8-ea5b12fbf235"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""665ec70b-8584-4611-b86f-2f08510c246a"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // JoueurAuSol
        m_JoueurAuSol = asset.FindActionMap("JoueurAuSol", throwIfNotFound: true);
        m_JoueurAuSol_Deplacer = m_JoueurAuSol.FindAction("Deplacer", throwIfNotFound: true);
        m_JoueurAuSol_Sauter = m_JoueurAuSol.FindAction("Sauter", throwIfNotFound: true);
        m_JoueurAuSol_Regarder = m_JoueurAuSol.FindAction("Regarder", throwIfNotFound: true);
        m_JoueurAuSol_Cliquer = m_JoueurAuSol.FindAction("Cliquer", throwIfNotFound: true);
        m_JoueurAuSol_Courrir = m_JoueurAuSol.FindAction("Courrir", throwIfNotFound: true);
        m_JoueurAuSol_ChangementCamera = m_JoueurAuSol.FindAction("ChangementCamera", throwIfNotFound: true);
        // JoueuDansEau
        m_JoueuDansEau = asset.FindActionMap("JoueuDansEau", throwIfNotFound: true);
        m_JoueuDansEau_Newaction = m_JoueuDansEau.FindAction("New action", throwIfNotFound: true);
        // SacADos
        m_SacADos = asset.FindActionMap("SacADos", throwIfNotFound: true);
        m_SacADos_Newaction = m_SacADos.FindAction("New action", throwIfNotFound: true);
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

    // JoueurAuSol
    private readonly InputActionMap m_JoueurAuSol;
    private IJoueurAuSolActions m_JoueurAuSolActionsCallbackInterface;
    private readonly InputAction m_JoueurAuSol_Deplacer;
    private readonly InputAction m_JoueurAuSol_Sauter;
    private readonly InputAction m_JoueurAuSol_Regarder;
    private readonly InputAction m_JoueurAuSol_Cliquer;
    private readonly InputAction m_JoueurAuSol_Courrir;
    private readonly InputAction m_JoueurAuSol_ChangementCamera;
    public struct JoueurAuSolActions
    {
        private @PeripheriqueEntree m_Wrapper;
        public JoueurAuSolActions(@PeripheriqueEntree wrapper) { m_Wrapper = wrapper; }
        public InputAction @Deplacer => m_Wrapper.m_JoueurAuSol_Deplacer;
        public InputAction @Sauter => m_Wrapper.m_JoueurAuSol_Sauter;
        public InputAction @Regarder => m_Wrapper.m_JoueurAuSol_Regarder;
        public InputAction @Cliquer => m_Wrapper.m_JoueurAuSol_Cliquer;
        public InputAction @Courrir => m_Wrapper.m_JoueurAuSol_Courrir;
        public InputAction @ChangementCamera => m_Wrapper.m_JoueurAuSol_ChangementCamera;
        public InputActionMap Get() { return m_Wrapper.m_JoueurAuSol; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(JoueurAuSolActions set) { return set.Get(); }
        public void SetCallbacks(IJoueurAuSolActions instance)
        {
            if (m_Wrapper.m_JoueurAuSolActionsCallbackInterface != null)
            {
                @Deplacer.started -= m_Wrapper.m_JoueurAuSolActionsCallbackInterface.OnDeplacer;
                @Deplacer.performed -= m_Wrapper.m_JoueurAuSolActionsCallbackInterface.OnDeplacer;
                @Deplacer.canceled -= m_Wrapper.m_JoueurAuSolActionsCallbackInterface.OnDeplacer;
                @Sauter.started -= m_Wrapper.m_JoueurAuSolActionsCallbackInterface.OnSauter;
                @Sauter.performed -= m_Wrapper.m_JoueurAuSolActionsCallbackInterface.OnSauter;
                @Sauter.canceled -= m_Wrapper.m_JoueurAuSolActionsCallbackInterface.OnSauter;
                @Regarder.started -= m_Wrapper.m_JoueurAuSolActionsCallbackInterface.OnRegarder;
                @Regarder.performed -= m_Wrapper.m_JoueurAuSolActionsCallbackInterface.OnRegarder;
                @Regarder.canceled -= m_Wrapper.m_JoueurAuSolActionsCallbackInterface.OnRegarder;
                @Cliquer.started -= m_Wrapper.m_JoueurAuSolActionsCallbackInterface.OnCliquer;
                @Cliquer.performed -= m_Wrapper.m_JoueurAuSolActionsCallbackInterface.OnCliquer;
                @Cliquer.canceled -= m_Wrapper.m_JoueurAuSolActionsCallbackInterface.OnCliquer;
                @Courrir.started -= m_Wrapper.m_JoueurAuSolActionsCallbackInterface.OnCourrir;
                @Courrir.performed -= m_Wrapper.m_JoueurAuSolActionsCallbackInterface.OnCourrir;
                @Courrir.canceled -= m_Wrapper.m_JoueurAuSolActionsCallbackInterface.OnCourrir;
                @ChangementCamera.started -= m_Wrapper.m_JoueurAuSolActionsCallbackInterface.OnChangementCamera;
                @ChangementCamera.performed -= m_Wrapper.m_JoueurAuSolActionsCallbackInterface.OnChangementCamera;
                @ChangementCamera.canceled -= m_Wrapper.m_JoueurAuSolActionsCallbackInterface.OnChangementCamera;
            }
            m_Wrapper.m_JoueurAuSolActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Deplacer.started += instance.OnDeplacer;
                @Deplacer.performed += instance.OnDeplacer;
                @Deplacer.canceled += instance.OnDeplacer;
                @Sauter.started += instance.OnSauter;
                @Sauter.performed += instance.OnSauter;
                @Sauter.canceled += instance.OnSauter;
                @Regarder.started += instance.OnRegarder;
                @Regarder.performed += instance.OnRegarder;
                @Regarder.canceled += instance.OnRegarder;
                @Cliquer.started += instance.OnCliquer;
                @Cliquer.performed += instance.OnCliquer;
                @Cliquer.canceled += instance.OnCliquer;
                @Courrir.started += instance.OnCourrir;
                @Courrir.performed += instance.OnCourrir;
                @Courrir.canceled += instance.OnCourrir;
                @ChangementCamera.started += instance.OnChangementCamera;
                @ChangementCamera.performed += instance.OnChangementCamera;
                @ChangementCamera.canceled += instance.OnChangementCamera;
            }
        }
    }
    public JoueurAuSolActions @JoueurAuSol => new JoueurAuSolActions(this);

    // JoueuDansEau
    private readonly InputActionMap m_JoueuDansEau;
    private IJoueuDansEauActions m_JoueuDansEauActionsCallbackInterface;
    private readonly InputAction m_JoueuDansEau_Newaction;
    public struct JoueuDansEauActions
    {
        private @PeripheriqueEntree m_Wrapper;
        public JoueuDansEauActions(@PeripheriqueEntree wrapper) { m_Wrapper = wrapper; }
        public InputAction @Newaction => m_Wrapper.m_JoueuDansEau_Newaction;
        public InputActionMap Get() { return m_Wrapper.m_JoueuDansEau; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(JoueuDansEauActions set) { return set.Get(); }
        public void SetCallbacks(IJoueuDansEauActions instance)
        {
            if (m_Wrapper.m_JoueuDansEauActionsCallbackInterface != null)
            {
                @Newaction.started -= m_Wrapper.m_JoueuDansEauActionsCallbackInterface.OnNewaction;
                @Newaction.performed -= m_Wrapper.m_JoueuDansEauActionsCallbackInterface.OnNewaction;
                @Newaction.canceled -= m_Wrapper.m_JoueuDansEauActionsCallbackInterface.OnNewaction;
            }
            m_Wrapper.m_JoueuDansEauActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Newaction.started += instance.OnNewaction;
                @Newaction.performed += instance.OnNewaction;
                @Newaction.canceled += instance.OnNewaction;
            }
        }
    }
    public JoueuDansEauActions @JoueuDansEau => new JoueuDansEauActions(this);

    // SacADos
    private readonly InputActionMap m_SacADos;
    private ISacADosActions m_SacADosActionsCallbackInterface;
    private readonly InputAction m_SacADos_Newaction;
    public struct SacADosActions
    {
        private @PeripheriqueEntree m_Wrapper;
        public SacADosActions(@PeripheriqueEntree wrapper) { m_Wrapper = wrapper; }
        public InputAction @Newaction => m_Wrapper.m_SacADos_Newaction;
        public InputActionMap Get() { return m_Wrapper.m_SacADos; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(SacADosActions set) { return set.Get(); }
        public void SetCallbacks(ISacADosActions instance)
        {
            if (m_Wrapper.m_SacADosActionsCallbackInterface != null)
            {
                @Newaction.started -= m_Wrapper.m_SacADosActionsCallbackInterface.OnNewaction;
                @Newaction.performed -= m_Wrapper.m_SacADosActionsCallbackInterface.OnNewaction;
                @Newaction.canceled -= m_Wrapper.m_SacADosActionsCallbackInterface.OnNewaction;
            }
            m_Wrapper.m_SacADosActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Newaction.started += instance.OnNewaction;
                @Newaction.performed += instance.OnNewaction;
                @Newaction.canceled += instance.OnNewaction;
            }
        }
    }
    public SacADosActions @SacADos => new SacADosActions(this);
    public interface IJoueurAuSolActions
    {
        void OnDeplacer(InputAction.CallbackContext context);
        void OnSauter(InputAction.CallbackContext context);
        void OnRegarder(InputAction.CallbackContext context);
        void OnCliquer(InputAction.CallbackContext context);
        void OnCourrir(InputAction.CallbackContext context);
        void OnChangementCamera(InputAction.CallbackContext context);
    }
    public interface IJoueuDansEauActions
    {
        void OnNewaction(InputAction.CallbackContext context);
    }
    public interface ISacADosActions
    {
        void OnNewaction(InputAction.CallbackContext context);
    }
}
