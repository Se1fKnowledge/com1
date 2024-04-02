using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vstavka : MonoBehaviour
{
    public string[] lines;
    public float speedText;
    public Text DialogText;

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
}
