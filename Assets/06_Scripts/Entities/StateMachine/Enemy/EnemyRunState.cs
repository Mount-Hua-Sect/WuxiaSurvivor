public class EnemyRunState : EnemyBaseState
{
    public EnemyRunState(EnemyStateMachine stateMachine) : base(stateMachine) { }

    public override void Enter()
    {
        base.Enter();
        stateMachine.Controller.AnimationHandler.SetState(ActionState.Run);
    }
}