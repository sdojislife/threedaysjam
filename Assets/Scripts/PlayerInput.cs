using UnityEngine;
[RequireComponent(typeof(PlayerJump))]
[RequireComponent(typeof(Movement))]
public sealed class PlayerInput : MonoBehaviour
{
    private PlayerJump _jump;
    private Movement _movement;
    private void Awake()
    {
        _jump = GetComponent<PlayerJump>();
        _movement = GetComponent<Movement>();
    }
    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            _movement.Direction = Vector2.right;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            _movement.Direction = Vector2.left;
        }
        _movement.Move();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            _jump.Jump();
        }
    }
}
