using UnityEngine;
using UnityEngine.InputSystem;

public abstract class PlayerBaseState : IState
{
    protected Vector2 moveDirection;

    protected readonly PlayerStateMachine stateMachine;

    public PlayerBaseState(PlayerStateMachine stateMachine)
    {
        this.stateMachine = stateMachine;
    }

    public virtual void Enter()
    {
        PlayerInputSystem.PlayerActions @event = stateMachine.Controller.InputSystem.Player;
        @event.Move.performed += OnMovementPerformed;
        @event.Move.canceled += OnMovementCanceled;
    }

    public virtual void Exit()
    {
        PlayerInputSystem.PlayerActions @event = stateMachine.Controller.InputSystem.Player;
        @event.Move.performed -= OnMovementPerformed;
        @event.Move.canceled -= OnMovementCanceled;
    }

    public virtual void Update() { }

    public virtual void FixedUpdate()
    {
        Debug.Log(moveDirection);
    }

    private void OnMovementPerformed(InputAction.CallbackContext context)
    {
        Vector2 direction = context.ReadValue<Vector2>();
        moveDirection = stateMachine.Controller.StatHandler.MoveSpeed * direction;
    }

    private void OnMovementCanceled(InputAction.CallbackContext context)
    {
        moveDirection = Vector2.zero;
    }
}