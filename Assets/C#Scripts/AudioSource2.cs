using UnityEngine;

public class SliderValueLoader1 : MonoBehaviour
{
    public AudioSource audioSource;

    void Start()
    {
        // Загрузка сохраненного значения слайдера или использование значения по умолчанию
        float savedValue = PlayerPrefs.GetFloat("SliderValue", 0.5f);
        audioSource.volume = savedValue;
    }
}