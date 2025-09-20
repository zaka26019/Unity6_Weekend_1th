using UnityEngine;
using UnityEngine.EventSystems;

public class Enemy : MonoBehaviour
{
    Rigidbody2D rigidbody2d;
    [SerializeField] Vector2 moveDir;
    [SerializeField] float moveSpeed;
    [SerializeField] Vector2 dir;
    [SerializeField] private float Move_Power = 10.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();

        rigidbody2d.linearVelocity = moveDir.normalized * moveSpeed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            Debug.Log("플레이어가 충돌하여 게임이 종료됩니다.");
            rigidbody2d.AddForce(dir.normalized * Move_Power, ForceMode2D.Impulse);
        }
    }
}
