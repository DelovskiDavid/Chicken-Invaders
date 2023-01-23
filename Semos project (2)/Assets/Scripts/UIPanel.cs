using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIPanel : MonoBehaviour
{
    public void GoToStartScreen()
    {
        SceneManager.LoadScene("StartScreen");
    }

    public void GoToNextLevel()
    {
        int level = PlayerPrefs.GetInt("Level ", 1);
        level++;
        if (level > 3)
        {
            int random = Random.Range(1, 3);
            SceneManager.LoadScene("Level " + random);
            Debug.Log(random);
        }
        else
        {
            PlayerPrefs.SetInt("Level ", level);
            SceneManager.LoadScene("Level " + level);
        }




    }

    public void PlayAgain()
    {
        int level = PlayerPrefs.GetInt("Level ", 1);
        SceneManager.LoadScene("Level " + level);
    }

}
