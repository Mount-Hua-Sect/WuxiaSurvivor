public class PlayerController : BaseController
{
    private PlayerStateMachine stateMachine;

    protected override void Initialize()
    {
        base.Initialize();

        stateMachine = new(this);
    }
}