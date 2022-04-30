using UnityEngine;
[RequireComponent(typeof(RotationType))]
public sealed class Movement : MonoBehaviour
{
    private RotationType _rotationType;
    [SerializeField] private float _speed;
    [SerializeField] private Vector2 _direction;
    public Vector2 Direction
    {
        get => _direction;
        set
        {
            _direction = value;
            _rotationType.RotateToSight(value);
        }
    }
    private void Awake()
    {
        _rotationType = GetComponent<RotationType>();
    }
    public void Move() => transform.Translate(_speed * _direction * Time.deltaTime);
}
