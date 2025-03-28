public class EnemyController : BaseController
{
    private EnemyStateMachine stateMachine;

    protected override void Initialize()
    {
        base.Initialize();

        stateMachine = new(this);
    }
}