using UnityEngine;
[RequireComponent(typeof(Movement))]
public abstract class MovementBehaviour : MonoBehaviour
{
    protected Movement _movement;
    private void Awake()
    {
        _movement = GetComponent<Movement>();
    }
    private void Update()
    {
        _movement.Move();
        SelectDirection();
    }
    protected abstract void SelectDirection();
}
