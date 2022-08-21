using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChooseAnswer : MonoBehaviour
{
    public GameObject answer1;
    public GameObject answer2;

    void Start()
    {
        this.answer1 = GameObject.Find("Answer1");
        this.answer2 = GameObject.Find("Answer2");
    }

    //ù��° �� ���� ��
    public void ShowAnswer1()
    {
        GameObject.Find("Canvas").transform.Find("Result1").gameObject.SetActive(true); //ù��° �� ���� ��Ÿ����
        answer1.GetComponent<Button>().interactable = false;//��ư ��Ȱ��ȭ
        answer2.GetComponent<Button>().interactable = false;
        MainDirector.money += 1; //�� +1
    }

    //�ι�° �� ���ý�
    public void ShowAnswer2()
    {
        GameObject.Find("Canvas").transform.Find("Result2").gameObject.SetActive(true); //�ι�° �� ���� ��Ÿ����
        answer1.GetComponent<Button>().interactable = false;
        answer2.GetComponent<Button>().interactable = false;
    }
}