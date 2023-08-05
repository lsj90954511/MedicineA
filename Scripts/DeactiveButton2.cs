using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeactiveButton2 : MonoBehaviour
{
    public GameObject answer1;

    void Start()
    {
        this.answer1 = GameObject.Find("Answer1");
        if (MainDirector.money <= 0)
            answer1.GetComponent<Button>().interactable = false;
    }
}
