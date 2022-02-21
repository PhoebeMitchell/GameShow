using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

namespace Input
{
    public class Input : MonoBehaviour, InputActions.IPlayerActions
    {
        [SerializeField] private UnityEvent<Vector2> _onMove;

        private InputActions _inputActions;

        public void OnEnable()
        {
            _inputActions ??= new InputActions();
            _inputActions.Enable();
            _inputActions.Player.SetCallbacks(this);
        }

        public void OnDisable()
        {
            _inputActions.Disable();
            _inputActions.Player.SetCallbacks(null);
        }

        public void OnArrowKeys(InputAction.CallbackContext context)
        {
            _onMove.Invoke(context.ReadValue<Vector2>());
        }
    }
}
