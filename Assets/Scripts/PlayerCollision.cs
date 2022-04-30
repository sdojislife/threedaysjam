using UnityEngine;
using UnityEngine.Events;
public sealed class PlayerCollision : MonoBehaviour
{
    public bool HasWorm { get => _hasWorm; }
    [SerializeField] private bool _hasWorm = false;
    [SerializeField] private UnityEvent _onWormRapted,_onDied;
    private Animator _currentAnimator;
    private void Awake()
    {
        _currentAnimator = GetComponent<Animator>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.TryGetComponent(out Worm worm) && !_hasWorm)
        {
            _hasWorm = true;
            _currentAnimator.SetBool("withWorm",true);
            Destroy(worm.gameObject);
        }
        if(collision.gameObject.TryGetComponent(out Nest nest) && _hasWorm)
        {
            _hasWorm = false;
            _currentAnimator.SetBool("withWorm", false);
            _onWormRapted.Invoke();
        }
        if(collision.gameObject.TryGetComponent(out MovementBehaviour movementBehaviour))
        {
            _onDied.Invoke();
        }
    }
}
