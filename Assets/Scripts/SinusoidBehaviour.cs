using UnityEngine;

public sealed class SinusoidBehaviour : MovementBehaviour
{
    [SerializeField] private float _angleStep;
    private float _angle;
    protected override void SelectDirection()
    {
        _movement.Direction = new Vector2(_movement.Direction.x,Mathf.Sin(_angle));
        _angle += _angleStep * Time.deltaTime;
        if(_angle >= 360)
        {
            _angle = 0;
        }
    }
}
