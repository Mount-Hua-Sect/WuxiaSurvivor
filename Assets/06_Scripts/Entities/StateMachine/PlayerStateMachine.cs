public class PlayerStateMachine : StateMachine
{
    public PlayerController Controller { get; private set; }

    public PlayerIdleState Idle { get; private set; }

    public PlayerStateMachine(PlayerController controller)
    {
        Controller = controller;

        Idle = new(this);
    }
}