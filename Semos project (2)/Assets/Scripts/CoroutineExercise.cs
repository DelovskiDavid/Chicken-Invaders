using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineExercise : MonoBehaviour
{
    private void Start()
    {
        //StartCoroutine(CoroutineExercise1());
        //StartCoroutine(CoroutineExercise2(5));
        //StartCoroutine(CoroutineExercise3());
        //StartCoroutine(CoroutineExercise4());
    }
    private IEnumerator CoroutineExercise1()
    {
        yield return new WaitForSeconds(2);
        Debug.Log("Hello, World!");
    }

    private IEnumerator CoroutineExercise2(int count)
    {
        while (count > 0)
        {
            Debug.Log("Hello, World!");
            yield return new WaitForSeconds(2);
            count--;
        }
    }

    private IEnumerator CoroutineExercise3()
    {
        for (int i = 2; i <= 100; i++)
        {
            Debug.Log("Hello, World!");
            yield return new WaitForSeconds(i);
        }
    }

    private IEnumerator CoroutineExercise4()
    {
        while (true)
        {
            Debug.Log("Hello, World!");
            float random = Random.Range(0f, 10f);
            yield return new WaitForSeconds(random);
        }
    }

}
