// GENERATED AUTOMATICALLY FROM 'Assets/Input Map.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputMap : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputMap()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Input Map"",
    ""maps"": [
        {
            ""name"": ""Movement"",
            ""id"": ""ab5ea85b-d219-48da-88b7-773348e61ab0"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""dfcf080a-bf56-437f-b483-cdd8bd403bb6"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Test"",
                    ""type"": ""Button"",
                    ""id"": ""0ef32e6d-ea65-4376-9587-8ec0fd2c4083"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DeployTower"",
                    ""type"": ""Button"",
                    ""id"": ""51740159-c510-4935-8101-5fac224a070e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""4a2bb752-51ab-47bd-a492-856160d87473"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""40660d0e-0dd7-4a54-bed8-6c152457c468"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Test"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e0f78dc0-9efe-4656-be16-8f00ed246fbd"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DeployTower"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Resource"",
            ""id"": ""667cd741-5f47-44f8-a74c-b47879a4382a"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""3f9eddc1-60b4-4385-9713-1da6ef3b775f"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Harvest"",
                    ""type"": ""Button"",
                    ""id"": ""1ef25522-2e59-4157-aa78-2be99b6fa17a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""ed34c08e-974d-4930-b8e0-e9b3f523f315"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Harvest"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0d0b39af-889b-4e63-9f63-6b1e57ba1665"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Tower"",
            ""id"": ""5f12a07a-fdfb-4e4f-b0e7-76c14956f9b5"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""06cba9c9-2872-4533-aeaf-61e925d8c444"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Reload"",
                    ""type"": ""Button"",
                    ""id"": ""48363919-7c3f-431e-acfc-728d3dffbd45"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""0ce38f44-4c63-4484-9874-a9ddc5fb90e2"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Reload"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""372ad132-0160-442c-9742-233cea538fe7"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Base"",
            ""id"": ""b41fa9b0-c389-4525-ba0b-47c388d90219"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""cddcd746-fd19-44ca-beac-f9de3363eb4f"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""718e2e65-508c-40d3-bcf7-c5c43f3573e0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""3b225fe8-d41b-4f56-9d50-a93b8753de7b"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""72980f51-20b0-4362-b6f4-73baf61cf36d"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Movement
        m_Movement = asset.FindActionMap("Movement", throwIfNotFound: true);
        m_Movement_Move = m_Movement.FindAction("Move", throwIfNotFound: true);
        m_Movement_Test = m_Movement.FindAction("Test", throwIfNotFound: true);
        m_Movement_DeployTower = m_Movement.FindAction("DeployTower", throwIfNotFound: true);
        // Resource
        m_Resource = asset.FindActionMap("Resource", throwIfNotFound: true);
        m_Resource_Move = m_Resource.FindAction("Move", throwIfNotFound: true);
        m_Resource_Harvest = m_Resource.FindAction("Harvest", throwIfNotFound: true);
        // Tower
        m_Tower = asset.FindActionMap("Tower", throwIfNotFound: true);
        m_Tower_Move = m_Tower.FindAction("Move", throwIfNotFound: true);
        m_Tower_Reload = m_Tower.FindAction("Reload", throwIfNotFound: true);
        // Base
        m_Base = asset.FindActionMap("Base", throwIfNotFound: true);
        m_Base_Move = m_Base.FindAction("Move", throwIfNotFound: true);
        m_Base_Newaction = m_Base.FindAction("New action", throwIfNotFound: true);
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

    // Movement
    private readonly InputActionMap m_Movement;
    private IMovementActions m_MovementActionsCallbackInterface;
    private readonly InputAction m_Movement_Move;
    private readonly InputAction m_Movement_Test;
    private readonly InputAction m_Movement_DeployTower;
    public struct MovementActions
    {
        private @InputMap m_Wrapper;
        public MovementActions(@InputMap wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Movement_Move;
        public InputAction @Test => m_Wrapper.m_Movement_Test;
        public InputAction @DeployTower => m_Wrapper.m_Movement_DeployTower;
        public InputActionMap Get() { return m_Wrapper.m_Movement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MovementActions set) { return set.Get(); }
        public void SetCallbacks(IMovementActions instance)
        {
            if (m_Wrapper.m_MovementActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnMove;
                @Test.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnTest;
                @Test.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnTest;
                @Test.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnTest;
                @DeployTower.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnDeployTower;
                @DeployTower.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnDeployTower;
                @DeployTower.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnDeployTower;
            }
            m_Wrapper.m_MovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Test.started += instance.OnTest;
                @Test.performed += instance.OnTest;
                @Test.canceled += instance.OnTest;
                @DeployTower.started += instance.OnDeployTower;
                @DeployTower.performed += instance.OnDeployTower;
                @DeployTower.canceled += instance.OnDeployTower;
            }
        }
    }
    public MovementActions @Movement => new MovementActions(this);

    // Resource
    private readonly InputActionMap m_Resource;
    private IResourceActions m_ResourceActionsCallbackInterface;
    private readonly InputAction m_Resource_Move;
    private readonly InputAction m_Resource_Harvest;
    public struct ResourceActions
    {
        private @InputMap m_Wrapper;
        public ResourceActions(@InputMap wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Resource_Move;
        public InputAction @Harvest => m_Wrapper.m_Resource_Harvest;
        public InputActionMap Get() { return m_Wrapper.m_Resource; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ResourceActions set) { return set.Get(); }
        public void SetCallbacks(IResourceActions instance)
        {
            if (m_Wrapper.m_ResourceActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_ResourceActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_ResourceActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_ResourceActionsCallbackInterface.OnMove;
                @Harvest.started -= m_Wrapper.m_ResourceActionsCallbackInterface.OnHarvest;
                @Harvest.performed -= m_Wrapper.m_ResourceActionsCallbackInterface.OnHarvest;
                @Harvest.canceled -= m_Wrapper.m_ResourceActionsCallbackInterface.OnHarvest;
            }
            m_Wrapper.m_ResourceActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Harvest.started += instance.OnHarvest;
                @Harvest.performed += instance.OnHarvest;
                @Harvest.canceled += instance.OnHarvest;
            }
        }
    }
    public ResourceActions @Resource => new ResourceActions(this);

    // Tower
    private readonly InputActionMap m_Tower;
    private ITowerActions m_TowerActionsCallbackInterface;
    private readonly InputAction m_Tower_Move;
    private readonly InputAction m_Tower_Reload;
    public struct TowerActions
    {
        private @InputMap m_Wrapper;
        public TowerActions(@InputMap wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Tower_Move;
        public InputAction @Reload => m_Wrapper.m_Tower_Reload;
        public InputActionMap Get() { return m_Wrapper.m_Tower; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(TowerActions set) { return set.Get(); }
        public void SetCallbacks(ITowerActions instance)
        {
            if (m_Wrapper.m_TowerActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_TowerActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_TowerActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_TowerActionsCallbackInterface.OnMove;
                @Reload.started -= m_Wrapper.m_TowerActionsCallbackInterface.OnReload;
                @Reload.performed -= m_Wrapper.m_TowerActionsCallbackInterface.OnReload;
                @Reload.canceled -= m_Wrapper.m_TowerActionsCallbackInterface.OnReload;
            }
            m_Wrapper.m_TowerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Reload.started += instance.OnReload;
                @Reload.performed += instance.OnReload;
                @Reload.canceled += instance.OnReload;
            }
        }
    }
    public TowerActions @Tower => new TowerActions(this);

    // Base
    private readonly InputActionMap m_Base;
    private IBaseActions m_BaseActionsCallbackInterface;
    private readonly InputAction m_Base_Move;
    private readonly InputAction m_Base_Newaction;
    public struct BaseActions
    {
        private @InputMap m_Wrapper;
        public BaseActions(@InputMap wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Base_Move;
        public InputAction @Newaction => m_Wrapper.m_Base_Newaction;
        public InputActionMap Get() { return m_Wrapper.m_Base; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(BaseActions set) { return set.Get(); }
        public void SetCallbacks(IBaseActions instance)
        {
            if (m_Wrapper.m_BaseActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_BaseActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_BaseActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_BaseActionsCallbackInterface.OnMove;
                @Newaction.started -= m_Wrapper.m_BaseActionsCallbackInterface.OnNewaction;
                @Newaction.performed -= m_Wrapper.m_BaseActionsCallbackInterface.OnNewaction;
                @Newaction.canceled -= m_Wrapper.m_BaseActionsCallbackInterface.OnNewaction;
            }
            m_Wrapper.m_BaseActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Newaction.started += instance.OnNewaction;
                @Newaction.performed += instance.OnNewaction;
                @Newaction.canceled += instance.OnNewaction;
            }
        }
    }
    public BaseActions @Base => new BaseActions(this);
    public interface IMovementActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnTest(InputAction.CallbackContext context);
        void OnDeployTower(InputAction.CallbackContext context);
    }
    public interface IResourceActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnHarvest(InputAction.CallbackContext context);
    }
    public interface ITowerActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnReload(InputAction.CallbackContext context);
    }
    public interface IBaseActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnNewaction(InputAction.CallbackContext context);
    }
}
