using UnityEngine;

public class SliderValueLoader : MonoBehaviour
{
    public AudioSource audioSource;

    void Start()
    {
        // �������� ������������ �������� �������� ��� ������������� �������� �� ���������
        float savedValue = PlayerPrefs.GetFloat("SliderValue", 0.5f);
        audioSource.volume = savedValue;
    }
}