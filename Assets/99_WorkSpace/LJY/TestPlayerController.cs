using UnityEngine;
/// <summary>
/// 테스트 코드이므로 나중에 삭제
/// </summary>
public class TestPlayerController : MonoBehaviour
{
    public float Speed;
    private Rigidbody2D rb;
    public Vector2 MoveVelocity;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        MoveVelocity = moveInput.normalized * Speed;
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + MoveVelocity * Time.fixedDeltaTime);
    }
}
