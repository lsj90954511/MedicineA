using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrologueScript : MonoBehaviour
{
    GameObject prologue;
    GameObject prologueText;
    static public int x = 0;

    void Start()
    {
        prologue = GameObject.Find("Prologue");
        prologueText = GameObject.Find("PrologueText");
        if (x == 1)
        {
            Destroy(prologue);
        }
    }
    
    void Update()
    {
        if (x == 1 && Input.GetMouseButtonDown(0))
        {
            //prologue.SetActive(false);
            Destroy(prologue);
            /*x++;
            if (Input.GetMouseButtonDown(0) && x == 2)
            {
               
            }*/
        }
        if (Input.GetMouseButtonDown(0))
        {
            //prologueText.GetComponent<Typing>().enabled = false;
            Destroy(prologueText.GetComponent<Typing>());
            prologueText.GetComponent<Text>().text = "20xx년.... 인류는 멸종할 위기에 처했습니다. 정체모를 전염병이 지구를 덮친 것이죠.\n\n모두가 죽어가는 세상에서 믿을 것은 당신 하나 뿐입니다.\n\n당신은 세계 제일의 연구원!\n\n부디 치료제를 개발해 인류를 구해주세요.";
            x = 1;
        }
        
    }
}
