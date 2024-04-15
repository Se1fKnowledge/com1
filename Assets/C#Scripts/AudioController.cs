using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioConroller: MonoBehaviour
{
    public Slider slider;
    public void Awake()
    {
        slider.value = PlayerPrefs.GetFloat("SliderValue", 0.5f);
    }
    public void Update()
    {
        SaveSliderValue();
    }
    public void SaveSliderValue()
    {
        PlayerPrefs.SetFloat("SliderValue", slider.value);
        PlayerPrefs.Save();
    }
}