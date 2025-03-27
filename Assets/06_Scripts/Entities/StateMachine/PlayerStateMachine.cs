public class PlayerStateMachine : StateMachine
{
    public PlayerController Player { get; private set; }

    public PlayerStateMachine(PlayerController player)
    {
        Player = player;
    }
}