using UnityEngine;

public class Player : MonoBehaviour
{
    private Controls controls;
    private Rigidbody2D rigidbody2D;
    [Header("Speed Attribute")]
    public float speed;
    [SerializeField] private float moveSpeed;

    private void Awake()
    {
        controls = new Controls();

        controls.Player.Enable();

        rigidbody2D = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    private void Update()
    {
        Vector2 dir = controls.Player.Move.ReadValue<Vector2>();
        rigidbody2D.linearVelocity = dir * moveSpeed;
    }
}
