using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioConroller1: MonoBehaviour
{
    public Slider slider;
    public void Awake()
    {
        slider.value = PlayerPrefs.GetFloat("SliderValueVoice", 0.5f);
    }
    public void Update()
    {
        SaveSliderValue();
    }
    public void SaveSliderValue()
    {
        PlayerPrefs.SetFloat("SliderValueVoice", slider.value);
        PlayerPrefs.Save();
    }
}