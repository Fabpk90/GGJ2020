// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Controls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""SelectionPart"",
            ""id"": ""2821cf1c-38ba-425c-8780-6fa25bb8591c"",
            ""actions"": [
                {
                    ""name"": ""Direction"",
                    ""type"": ""Button"",
                    ""id"": ""13297a27-0790-4266-be60-8bb3142049c4"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Selection"",
                    ""type"": ""Button"",
                    ""id"": ""01725839-7f5e-494f-866b-fa1127dcd323"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""DPad"",
                    ""id"": ""2b2c73dd-a0c9-4710-9b45-5a107b90915a"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Direction"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""14ea46a7-11fa-4d5c-939b-4ef0bf55e924"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Direction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""f71d06b1-ace0-4f74-8e54-de07efef1a1a"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Direction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""ff28b3b2-65ec-4c6f-aa16-c2b0ac2ae675"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Direction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""112c8701-b377-4a41-85c2-104bbfc36484"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Direction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""0c1e2c43-705f-4cf0-9d1b-209a8c48844a"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Selection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""SelectionWallet"",
            ""id"": ""54830b05-a902-45a6-ac4a-8a817a16cb23"",
            ""actions"": [
                {
                    ""name"": ""Direction"",
                    ""type"": ""Button"",
                    ""id"": ""5c0b6875-1d7c-4912-9d34-5dcdf9bbd4ae"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Selection"",
                    ""type"": ""Button"",
                    ""id"": ""474c30d9-03b2-400e-a873-55055e35b1b7"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""DPad"",
                    ""id"": ""047c18b1-b639-42ce-bf4b-13f7e33a2cbb"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Direction"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""956644a3-6644-4c7d-822c-bdca4d51ccc4"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Direction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""222f9f39-7d3c-428d-bd76-6b99aa03bbe1"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Direction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""535fdd50-09c1-476e-a9ac-a7af26f3568a"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Direction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""6b39a8ea-7673-4b5c-8dc8-38f74b098db0"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Direction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""1c834a2f-6037-44fa-96c1-dc2300864be5"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Selection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Fight"",
            ""id"": ""3e5d5dd9-7613-4fe2-b3da-f3cc6a150661"",
            ""actions"": [
                {
                    ""name"": ""Weapon1"",
                    ""type"": ""Button"",
                    ""id"": ""3f9cf016-eaa3-46fd-b821-f04b6863d346"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Weapon2"",
                    ""type"": ""Button"",
                    ""id"": ""ebc5a7fe-6f1f-4931-abef-90fd461728de"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Direction"",
                    ""type"": ""Value"",
                    ""id"": ""173b96a9-09e8-48b8-98c1-a8cd68c39cc8"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""166e3cf9-aa48-4e70-bd5a-4d30ffbabd5e"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Weapon1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4526b3ee-02fc-445d-ad97-a03dda6a9658"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Weapon2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""1f025863-3aef-404d-971d-f5acc9ac9e93"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Direction"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""c6826e53-2074-4d81-a281-52d826526d25"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Direction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""0d2b2f6f-9c37-4659-b7af-ff20aa8e9c03"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Direction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""b819752a-af20-41b9-849f-01bef9c92b2c"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Direction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""38c460de-2cf9-4dbd-befb-ed1cdc3217a9"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Direction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // SelectionPart
        m_SelectionPart = asset.FindActionMap("SelectionPart", throwIfNotFound: true);
        m_SelectionPart_Direction = m_SelectionPart.FindAction("Direction", throwIfNotFound: true);
        m_SelectionPart_Selection = m_SelectionPart.FindAction("Selection", throwIfNotFound: true);
        // SelectionWallet
        m_SelectionWallet = asset.FindActionMap("SelectionWallet", throwIfNotFound: true);
        m_SelectionWallet_Direction = m_SelectionWallet.FindAction("Direction", throwIfNotFound: true);
        m_SelectionWallet_Selection = m_SelectionWallet.FindAction("Selection", throwIfNotFound: true);
        // Fight
        m_Fight = asset.FindActionMap("Fight", throwIfNotFound: true);
        m_Fight_Weapon1 = m_Fight.FindAction("Weapon1", throwIfNotFound: true);
        m_Fight_Weapon2 = m_Fight.FindAction("Weapon2", throwIfNotFound: true);
        m_Fight_Direction = m_Fight.FindAction("Direction", throwIfNotFound: true);
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

    // SelectionPart
    private readonly InputActionMap m_SelectionPart;
    private ISelectionPartActions m_SelectionPartActionsCallbackInterface;
    private readonly InputAction m_SelectionPart_Direction;
    private readonly InputAction m_SelectionPart_Selection;
    public struct SelectionPartActions
    {
        private @Controls m_Wrapper;
        public SelectionPartActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Direction => m_Wrapper.m_SelectionPart_Direction;
        public InputAction @Selection => m_Wrapper.m_SelectionPart_Selection;
        public InputActionMap Get() { return m_Wrapper.m_SelectionPart; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(SelectionPartActions set) { return set.Get(); }
        public void SetCallbacks(ISelectionPartActions instance)
        {
            if (m_Wrapper.m_SelectionPartActionsCallbackInterface != null)
            {
                @Direction.started -= m_Wrapper.m_SelectionPartActionsCallbackInterface.OnDirection;
                @Direction.performed -= m_Wrapper.m_SelectionPartActionsCallbackInterface.OnDirection;
                @Direction.canceled -= m_Wrapper.m_SelectionPartActionsCallbackInterface.OnDirection;
                @Selection.started -= m_Wrapper.m_SelectionPartActionsCallbackInterface.OnSelection;
                @Selection.performed -= m_Wrapper.m_SelectionPartActionsCallbackInterface.OnSelection;
                @Selection.canceled -= m_Wrapper.m_SelectionPartActionsCallbackInterface.OnSelection;
            }
            m_Wrapper.m_SelectionPartActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Direction.started += instance.OnDirection;
                @Direction.performed += instance.OnDirection;
                @Direction.canceled += instance.OnDirection;
                @Selection.started += instance.OnSelection;
                @Selection.performed += instance.OnSelection;
                @Selection.canceled += instance.OnSelection;
            }
        }
    }
    public SelectionPartActions @SelectionPart => new SelectionPartActions(this);

    // SelectionWallet
    private readonly InputActionMap m_SelectionWallet;
    private ISelectionWalletActions m_SelectionWalletActionsCallbackInterface;
    private readonly InputAction m_SelectionWallet_Direction;
    private readonly InputAction m_SelectionWallet_Selection;
    public struct SelectionWalletActions
    {
        private @Controls m_Wrapper;
        public SelectionWalletActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Direction => m_Wrapper.m_SelectionWallet_Direction;
        public InputAction @Selection => m_Wrapper.m_SelectionWallet_Selection;
        public InputActionMap Get() { return m_Wrapper.m_SelectionWallet; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(SelectionWalletActions set) { return set.Get(); }
        public void SetCallbacks(ISelectionWalletActions instance)
        {
            if (m_Wrapper.m_SelectionWalletActionsCallbackInterface != null)
            {
                @Direction.started -= m_Wrapper.m_SelectionWalletActionsCallbackInterface.OnDirection;
                @Direction.performed -= m_Wrapper.m_SelectionWalletActionsCallbackInterface.OnDirection;
                @Direction.canceled -= m_Wrapper.m_SelectionWalletActionsCallbackInterface.OnDirection;
                @Selection.started -= m_Wrapper.m_SelectionWalletActionsCallbackInterface.OnSelection;
                @Selection.performed -= m_Wrapper.m_SelectionWalletActionsCallbackInterface.OnSelection;
                @Selection.canceled -= m_Wrapper.m_SelectionWalletActionsCallbackInterface.OnSelection;
            }
            m_Wrapper.m_SelectionWalletActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Direction.started += instance.OnDirection;
                @Direction.performed += instance.OnDirection;
                @Direction.canceled += instance.OnDirection;
                @Selection.started += instance.OnSelection;
                @Selection.performed += instance.OnSelection;
                @Selection.canceled += instance.OnSelection;
            }
        }
    }
    public SelectionWalletActions @SelectionWallet => new SelectionWalletActions(this);

    // Fight
    private readonly InputActionMap m_Fight;
    private IFightActions m_FightActionsCallbackInterface;
    private readonly InputAction m_Fight_Weapon1;
    private readonly InputAction m_Fight_Weapon2;
    private readonly InputAction m_Fight_Direction;
    public struct FightActions
    {
        private @Controls m_Wrapper;
        public FightActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Weapon1 => m_Wrapper.m_Fight_Weapon1;
        public InputAction @Weapon2 => m_Wrapper.m_Fight_Weapon2;
        public InputAction @Direction => m_Wrapper.m_Fight_Direction;
        public InputActionMap Get() { return m_Wrapper.m_Fight; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(FightActions set) { return set.Get(); }
        public void SetCallbacks(IFightActions instance)
        {
            if (m_Wrapper.m_FightActionsCallbackInterface != null)
            {
                @Weapon1.started -= m_Wrapper.m_FightActionsCallbackInterface.OnWeapon1;
                @Weapon1.performed -= m_Wrapper.m_FightActionsCallbackInterface.OnWeapon1;
                @Weapon1.canceled -= m_Wrapper.m_FightActionsCallbackInterface.OnWeapon1;
                @Weapon2.started -= m_Wrapper.m_FightActionsCallbackInterface.OnWeapon2;
                @Weapon2.performed -= m_Wrapper.m_FightActionsCallbackInterface.OnWeapon2;
                @Weapon2.canceled -= m_Wrapper.m_FightActionsCallbackInterface.OnWeapon2;
                @Direction.started -= m_Wrapper.m_FightActionsCallbackInterface.OnDirection;
                @Direction.performed -= m_Wrapper.m_FightActionsCallbackInterface.OnDirection;
                @Direction.canceled -= m_Wrapper.m_FightActionsCallbackInterface.OnDirection;
            }
            m_Wrapper.m_FightActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Weapon1.started += instance.OnWeapon1;
                @Weapon1.performed += instance.OnWeapon1;
                @Weapon1.canceled += instance.OnWeapon1;
                @Weapon2.started += instance.OnWeapon2;
                @Weapon2.performed += instance.OnWeapon2;
                @Weapon2.canceled += instance.OnWeapon2;
                @Direction.started += instance.OnDirection;
                @Direction.performed += instance.OnDirection;
                @Direction.canceled += instance.OnDirection;
            }
        }
    }
    public FightActions @Fight => new FightActions(this);
    public interface ISelectionPartActions
    {
        void OnDirection(InputAction.CallbackContext context);
        void OnSelection(InputAction.CallbackContext context);
    }
    public interface ISelectionWalletActions
    {
        void OnDirection(InputAction.CallbackContext context);
        void OnSelection(InputAction.CallbackContext context);
    }
    public interface IFightActions
    {
        void OnWeapon1(InputAction.CallbackContext context);
        void OnWeapon2(InputAction.CallbackContext context);
        void OnDirection(InputAction.CallbackContext context);
    }
}
