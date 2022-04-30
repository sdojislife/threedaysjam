using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfBordersDeath : MonoBehaviour
{
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.TryGetComponent(out Camera camera))
        {
            Destroy(gameObject);
        }
    }
}
