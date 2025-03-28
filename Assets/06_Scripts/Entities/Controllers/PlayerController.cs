using UnityEngine;

public class PlayerController : BaseController
{
    public AnimationHandler AnimationHandler { get; private set; }
    public PlayerInputSystem InputSystem { get; private set; }
    public PlayerStatHandler StatHandler { get; private set; }
    public Rigidbody2D Rigidbody { get; private set; }
    public SpriteRenderer Body { get; private set; }

    private PlayerStateMachine stateMachine;

    protected override void Initialize()
    {
        base.Initialize();

        AnimationHandler = GetComponent<AnimationHandler>();
        StatHandler = GetComponent<PlayerStatHandler>();
        Rigidbody = GetComponent<Rigidbody2D>();
        Body = gameObject.FindComponent<SpriteRenderer>(nameof(Body));

        InputSystem = new();
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