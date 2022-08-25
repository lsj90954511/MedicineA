using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeactiveButton : MonoBehaviour
{
    public GameObject answer2;

    void Start()
    {
        this.answer2 = GameObject.Find("Answer2");
        if (MainDirector.money <= 0)
            answer2.GetComponent<Button>().interactable = false;
    }

}
