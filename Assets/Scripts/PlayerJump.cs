using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Movement))]
public sealed class PlayerJump : MonoBehaviour
{
    [SerializeField] private float _jumpHeight;
    private Rigidbody2D _rigidbody;
    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }
    public void Jump() => _rigidbody.velocity = Vector2.up * _jumpHeight;
}
