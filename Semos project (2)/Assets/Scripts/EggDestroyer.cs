using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggDestroyer : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Spaceship")
        {
            //Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
