using UnityEngine;

public sealed class CurvingBehaviour : MovementBehaviour
{
    [SerializeField] private float _y1, _y2;
    private float _curving;
    private void Start()
    {
        _curving = Random.Range(_y1, _y2);
    }
    protected override void SelectDirection()
    {
        _movement.Direction += new Vector2(0,_curving);
    }
}
