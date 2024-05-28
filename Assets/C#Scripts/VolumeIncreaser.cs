using UnityEngine;

public class VolumeIncreser : MonoBehaviour
{
    public AudioSource audioSource;
    public float increaseAmount = 0.1f;

    void Start()
    {
        // Проверяем, что AudioSource назначен
        if (audioSource == null)
        {
            Debug.LogError("AudioSource не назначен!");
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            IncreaseVolumeByAmount();
        }
    }

    void IncreaseVolumeByAmount()
    {
        audioSource.volume += increaseAmount;
    }
}