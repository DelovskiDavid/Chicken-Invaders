using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public ScoreController scoreController;
    public float speed = 1f;

    public static int ChickensKilledCount = 0;

    private void Update()
    {
        transform.position += new Vector3(0f, speed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Chicken")
        {
            ChickensKilledCount++;
            if (ChickensKilledCount == GameController.totalChickenCount)
            {
                UIManager.Instance.ShowWinPanel();
                ChickensKilledCount = 0;
                GameController.isGameOver = true;
            }
            IncreaseScore();
            Destroy(other.gameObject);
            Destroy(gameObject);
        }

    }

    private IEnumerator ShowWinPanelWithDelay()
    {
        yield return new WaitForSeconds(0.5f);

        GameObject winPanel = GameObject.FindGameObjectWithTag("WinPanel");
        winPanel.transform.localScale = Vector3.one;
    }

    private void IncreaseScore()
    {
        ScoreController.Instance.UpdateScore();
    }

}
