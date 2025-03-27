public class PlayerController : BaseController
{
    public PlayerInputSystem InputSystem { get; private set; }
    public PlayerStatHandler StatHandler { get; private set; }

    private PlayerStateMachine stateMachine;

    protected override void Initialize()
    {
        base.Initialize();

        InputSystem = new();
        StatHandler = GetComponent<PlayerStatHandler>();

        stateMachine = new(this);
    }

    private void Start()
    {
        stateMachine.ChangeState(stateMachine.Idle);
    }

    private void OnEnable()
    {
        InputSystem.Enable();
    }

    private void OnDisable()
    {
        InputSystem.Disable();
    }

    private void Update()
    {
        stateMachine.Update();
    }

    private void FixedUpdate()
    {
        stateMachine.FixedUpdate();
    }
}