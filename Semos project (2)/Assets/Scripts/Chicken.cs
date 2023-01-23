using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chicken : MonoBehaviour
{
    public float speed = 1f;
    public GameObject eggPrefab;
    public GameObject SpawnPositionObject;
    private bool isMovingRight = true;
    public SpriteRenderer spriteRenderer;
    public float endOfScreenX;
    private void Start()
    {
        //InvokeRepeating("SpawnEgg", 2f, 4f);
        StartCoroutine(SpawnEggsCoroutine());
    }

    private void SpawnEgg()
    {
        Instantiate(eggPrefab, SpawnPositionObject.transform.position, Quaternion.identity);
    }

    private IEnumerator SpawnEggsCoroutine()
    {
        //Debug.Log("Test");
        //pocekaj 2 sekundi
        //yield return new WaitForSeconds(2f);
        //Debug.Log("Test 2");

        while (true)
        {
            float random = Random.Range(2f, 6f);
            yield return new WaitForSeconds(random);
            SpawnEgg();
        }

    }

    private void Update()
    {
        LeftRight();
    }

    private void LeftRight()
    {
        if (isMovingRight)
        {
            transform.position += new Vector3(speed * Time.deltaTime, 0f);
        }
        else
        {
            transform.position -= new Vector3(speed * Time.deltaTime, 0f);
        }
        if (transform.position.x > endOfScreenX)
        {
            isMovingRight = false;
            spriteRenderer.flipX = false;
        }
        else if (transform.position.x < -endOfScreenX)
        {
            isMovingRight = true;
            spriteRenderer.flipX = true;
        }
    }
}
