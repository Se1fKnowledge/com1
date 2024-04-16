using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Dialog : MonoBehaviour
{
    public string typeOfDialogue;
    public string[] lines;
    public AudioSource[] audioSources;
    private AudioSource currentAudioSource;
    public string[] linesName;

    public float speedNameText;
    public float speedText;

    public Text DialogText;
    public Text DialogNameText;

    public GameObject CurrentLayer;
    public GameObject NextLayer;

    public GameObject ItemToAppear;
    public GameObject ItemToAppear2;

    public int index;

    private void Start()
    {
        DialogText.text = string.Empty;
        DialogNameText.text= string.Empty;
        StartDialog();
    }

    void StartDialog()
    {
        index = 0;
        StartCoroutine(TypeLine());
        if (index < audioSources.Length)
        {
            PlayAudio(audioSources[index]);
        }
    }

    IEnumerator TypeLine()
    {
        foreach (char c in linesName[index].ToCharArray())
        {
            DialogNameText.text += c;
            yield return new WaitForSeconds(speedNameText);
        }
        foreach (char c in lines[index].ToCharArray()) 
        {
            DialogText.text += c;
            yield return new WaitForSeconds(speedText);
        }
    }

    public void SkipText()
    {
        if(DialogText.text == lines[index])
        {
            NextLines();
        }
        else
        {
            StopAllCoroutines();
            DialogText.text = lines[index];
            DialogNameText.text = linesName[index];
        }
    }

    private void NextLines()
    {
        if (index < lines.Length - 1)
        {
            index++;
            DialogText.text = string.Empty;
            DialogNameText.text = string.Empty;
            StartCoroutine(TypeLine());

            if (currentAudioSource != null)
            {
                currentAudioSource.Stop();
            }

            if (index < audioSources.Length)
            {
                PlayAudio(audioSources[index]);
            }
        }
        else
        {
            gameObject.SetActive(false);
            if (typeOfDialogue == "NextFrame")
            {
                NextFrame();
            }
            if (typeOfDialogue == "ItemAppearance")
            {
                ItemAppearance();
            }
            if (typeOfDialogue == "ItemAppearance2")
            {
                ItemAppearance2();
            }
            if (typeOfDialogue == "Repetative")
            {
                
            }
        }
    }
    private void PlayAudio(AudioSource audioSource)
    {
        currentAudioSource = audioSource;
        audioSource.Play();
    }


    public void NextFrame()
    {
        if (CurrentLayer.activeInHierarchy == true && NextLayer.activeInHierarchy == false)
        {
            CurrentLayer.SetActive(false);
            NextLayer.SetActive(true);
        }
    }

    public void ItemAppearance()
    {
        if (ItemToAppear.activeInHierarchy == false )
        {
            ItemToAppear.SetActive(true);
        }
    }
    public void ItemAppearance2()
    {
        if (ItemToAppear.activeInHierarchy == false && ItemToAppear2.activeInHierarchy == false)
        {
            ItemToAppear.SetActive(true);
            ItemToAppear2.SetActive(true);
        }
    }
}
