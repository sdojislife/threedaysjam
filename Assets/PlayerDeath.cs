using UnityEngine;
using System.Collections;
public sealed class PlayerDeath : MonoBehaviour
{
    [SerializeField] private GameObject _score;
    [SerializeField] private SceneLoader _sceneLoader;
    [SerializeField] private Animation _blackOut;
    private PlayerInput _input;
    private Movement _movement;
    private void Awake()
    {
        _input = GetComponent<PlayerInput>();
        _movement = GetComponent<Movement>();
    }
    public void Die()
    {
        Destroy(_input);
        _movement.Direction = new Vector2(0, -1f);
        StartCoroutine(DyingRoutine());
    }
    private IEnumerator DyingRoutine()
    {
        yield return new WaitForSeconds(1f);
        _blackOut.Play();
        Destroy(_score);
        yield return new WaitForSeconds(1.5f);
        _sceneLoader.Load();
    }
}
