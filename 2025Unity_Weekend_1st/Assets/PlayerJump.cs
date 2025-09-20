using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerJump : MonoBehaviour
{

    Rigidbody2D rigidbody2D;

    [SerializeField] private float Move_Power = 10.0f;
    [SerializeField] Vector2 dir;
    [SerializeField] LayerMask groundLayer;
    [SerializeField] float Check_Distance = 2f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded())
        {
            rigidbody2D.AddForce(dir.normalized * Move_Power, ForceMode2D.Impulse);
        }
    }

    bool IsGrounded()
    {
        return Physics2D.Raycast(transform.position, Vector2.down, Check_Distance, groundLayer);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawLine(transform.position,transform.position + (Vector3)Vector2.down * Check_Distance);
    }
}
