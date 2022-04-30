using System.Collections;
using UnityEngine;

public sealed class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _spawnable;
    [SerializeField] private float _delayX1, _delayX2;
    [SerializeField] private float _preSpawnDelay;
    [SerializeField] private float _borderLeft,_borderRight,_borderUp,_borderDown;
    private void Start()
    {
        StartCoroutine(SpawningRoutine());
    }
    private IEnumerator SpawningRoutine()
    {
        yield return new WaitForSeconds(_preSpawnDelay);
        while (true)
        {
            Instantiate(_spawnable, new Vector2(Random.Range(_borderLeft, _borderRight), Random.Range(_borderDown, _borderUp)), Quaternion.identity);
            yield return new WaitForSeconds(Random.Range(_delayX1, _delayX2));
        }
    }
}
