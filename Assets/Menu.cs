using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    [SerializeField] private SceneLoader _loader;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            _loader.Load();
        }
    }
}
