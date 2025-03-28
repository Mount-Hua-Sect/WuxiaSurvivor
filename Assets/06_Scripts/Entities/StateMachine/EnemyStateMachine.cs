public class EnemyStateMachine : StateMachine
{
    public EnemyController Controller { get; private set; }

    public EnemyStateMachine(EnemyController controller)
    {
        Controller = controller;
    }
}