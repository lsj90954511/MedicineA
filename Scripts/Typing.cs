using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Typing : MonoBehaviour
{
    Text prologueText;
    string story;

    void Awake()
    {
        prologueText = GetComponent<Text>();
        story = prologueText.text;
        prologueText.text = "";

        StartCoroutine("PlayText");
    }

    IEnumerator PlayText()
    {
        foreach (char c in story)
        {
            prologueText.text += c;
            yield return new WaitForSeconds(0.125f);
        }
    }
}