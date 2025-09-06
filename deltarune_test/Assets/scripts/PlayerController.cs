using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Rigidbody2D rb;
    private bool isColliding = false; // �浹 ���¸� ������ ����

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        // �浹 ���� �ƴ϶�� �̵� ������ ����
        if (!isColliding)
        {
            float horizontalInput = Input.GetAxisRaw("Horizontal");
            float verticalInput = Input.GetAxisRaw("Vertical");

            Vector2 movement = new Vector2(horizontalInput, verticalInput).normalized;

            Vector2 nextPosition = rb.position + movement * moveSpeed * Time.fixedDeltaTime;
            rb.MovePosition(nextPosition);
        }
    }

    // �浹 ���� �� ȣ��
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            isColliding = true;
            rb.linearVelocity = Vector2.zero; // �̵� �ӵ��� 0���� �����Ͽ� ����
        }
    }

    // �浹 ���� �� ȣ��
    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            isColliding = false;
        }
    }
}