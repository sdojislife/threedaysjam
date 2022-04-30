using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] private int _index;
    public void Load() => SceneManager.LoadSceneAsync(_index);
}
