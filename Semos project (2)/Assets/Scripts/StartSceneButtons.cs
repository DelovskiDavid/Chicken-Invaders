using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartSceneButtons : MonoBehaviour
{
    //public GameObject OptionsPanel;

    public void Play()
    {
        PlayerPrefs.SetInt("Level ", 1);
        SceneManager.LoadScene("Level 1");
    }
    public void Continue()
    {
        int level = PlayerPrefs.GetInt("Level ", 1);
        SceneManager.LoadScene("Level " + level); 
    }

    public void QuitGame()
    {
        Application.Quit();

        UnityEditor.EditorApplication.isPlaying = false;
    }

    //public void OpenOptionsPanel()
    //{
    //    OptionsPanel.SetActive(true);
    //}

    //public void CloseOptionsPanel()
    //{
    //    OptionsPanel.SetActive(false);
    //}

}
