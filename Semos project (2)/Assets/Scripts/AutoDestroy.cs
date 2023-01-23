using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDestroy : MonoBehaviour
{
    private void Start()
    {
        Invoke("SelfDestroy", 2f);
    }

    private void SelfDestroy()
    {
        Destroy(gameObject);
    }
}

