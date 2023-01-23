using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsPanel : MonoBehaviour
{
    public Slider slider;

    private void OnDisable()
    {
        PlayerPrefs.SetFloat("Speed", slider.value);
    }


}
