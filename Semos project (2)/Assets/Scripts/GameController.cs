using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static int totalChickenCount;

    public static bool isGameOver = false;
    private void Start()
    {
        Bullet.ChickensKilledCount = 0;
        Chicken[] allChickens = FindObjectsOfType<Chicken>();
        totalChickenCount = allChickens.Length;
        isGameOver = false;
    }
}
