using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destoyer : MonoBehaviour
{
    private void OnTriggerExit(Collider collision)
    {
        if (collision.TryGetComponent(out GridObject gridObject))
        {
            gridObject.Die();
        }
    }
}
