using UnityEngine;

public abstract class EnemyBaseState : IState
{
    protected Vector2 moveDirection;

    protected readonly EnemyStateMachine stateMachine;

    private readonly SpriteRenderer body;
    private readonly StatHandler statHandler;

    public EnemyBaseState(EnemyStateMachine stateMachine)
    {
        this.stateMachine = stateMachine;

        body = stateMachine.Controller.Body;
        statHandler = stateMachine.Controller.StatHandler;
    }

    public virtual void Enter() { }
    public virtual void Exit() { }
    public virtual void Update() { }
    public virtual void FixedUpdate() { }
}