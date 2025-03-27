public interface IState
{
    public void Enter();
    public void Exit();

    public void HandleInput();
    public void Update();
    public void FixedUpdate();
}

public abstract class StateMachine
{
    protected IState currentState;

    public void ChangeState(IState state)
    {
        currentState?.Exit();
        currentState = state;
        currentState?.Enter();
    }

    public void HandleInput() => currentState?.HandleInput();
    public void Update() => currentState?.Update();
    public void FixedUpdate() => currentState?.FixedUpdate();
}