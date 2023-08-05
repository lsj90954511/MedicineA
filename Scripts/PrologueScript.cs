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
            prologueText.GetComponent<Text>().text = "20xx��.... �η��� ������ ���⿡ ó�߽��ϴ�. ��ü�� �������� ������ ��ģ ������.\n\n��ΰ� �׾�� ���󿡼� ���� ���� ��� �ϳ� ���Դϴ�.\n\n����� ���� ������ ������!\n\n�ε� ġ������ ������ �η��� �����ּ���.";
            x = 1;
        }
        
    }
}
