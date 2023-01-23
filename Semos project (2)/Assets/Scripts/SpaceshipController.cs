using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpaceshipController : MonoBehaviour
{
    public float keyboardSpeed;
    public float mouseSpeed;
    public float endOfScreenX;
    public float endOfScreenY;
    public GameObject bulletPrefab;
    public GameObject BulletSpawnPosition;
    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;
    public GameObject explosion;

    private int lives = 3;


    private void Update()
    {
        if (GameController.isGameOver == true)
        {
            return;
        }
        Move1();
        MoveWithMouse();


        if (Input.GetButtonDown("Fire"))
        {
            //Vector2 spawnPosition = new Vector2(transform.position.x, transform.position.y + 0.6f);   //kade da se pojavuva kursumot od spaceshipot
            Instantiate(bulletPrefab, BulletSpawnPosition.transform.position, Quaternion.identity); //Quaternion.identity = 0,0,0 rotacija
        }
    }

    private void Move1()
    {
        float horizontalAxis = Input.GetAxis("Horizontal");
        float xIncrement = horizontalAxis * keyboardSpeed * Time.deltaTime;
        if (transform.position.x + xIncrement < endOfScreenX && transform.position.x + xIncrement > -endOfScreenX)
            transform.position += new Vector3(xIncrement, 0f);

        float verticalAxis = Input.GetAxis("Vertical");
        float yIncrement = verticalAxis * keyboardSpeed * Time.deltaTime;
        if (transform.position.y + yIncrement < endOfScreenY && transform.position.y + yIncrement > -endOfScreenY)
            transform.position += new Vector3(0f, yIncrement);
    }
    private void MoveWithMouse()
    {
        if (Input.GetMouseButton(0))
        {
            float screenWidth = Screen.width;
            float middleOfScreenX = screenWidth / 2f;

            if (Input.mousePosition.x < middleOfScreenX)
            {
                if (transform.position.x - mouseSpeed * Time.deltaTime > -endOfScreenX)
                    transform.position -= new Vector3(mouseSpeed * Time.deltaTime, 0f);
            }
            else
            {
                if (transform.position.x + mouseSpeed * Time.deltaTime < endOfScreenX)
                    transform.position += new Vector3(mouseSpeed * Time.deltaTime, 0f);
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (lives == 3)
        {
            heart3.SetActive(false);
        }
        else if (lives == 2)
        {
            heart2.SetActive(false);
        }
        else if (lives == 1)
        {
            heart1.SetActive(false);
        }

        lives--;

        if (lives == 0)
        {
            Instantiate(explosion, transform.position, Quaternion.identity);

            UIManager.Instance.ShowLosePanel();

            GameController.isGameOver = true;

            Destroy(gameObject);
        }
    }

    





}
