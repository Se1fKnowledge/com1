using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Experimental.GraphView.GraphView;

public class Dialog : MonoBehaviour
{
    public string typeOfDialogue;
    public string[] lines;
    public float speedText;
    public Text DialogText;

    public GameObject CurrentLayer;
    public GameObject NextLayer;

    public GameObject ItemToAppear;

    public int index;

    private void Start()
    {
        DialogText.text = string.Empty;
        StartDialog();
    }

    void StartDialog()
    {
        index = 0;
        StartCoroutine(TypeLine());
    }

    IEnumerator TypeLine()
    {
        foreach(char c in lines[index].ToCharArray()) 
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
        }
    }

    private void NextLines()
    {
        if (index < lines.Length - 1)
        {
            index++;
            DialogText.text = string.Empty;
            StartCoroutine(TypeLine());
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
            if (typeOfDialogue == "Repetative")
            {
                
            }
        }
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
}
