using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChooseAnswer : MonoBehaviour
{
    public GameObject answer1;
    public GameObject answer2;
    public GameObject dontDestroy;

    void Start()
    {
        this.answer1 = GameObject.Find("Answer1");
        this.answer2 = GameObject.Find("Answer2");
        this.dontDestroy = GameObject.Find("DontDestroy");
    }

    //ù��° �� ���� ��. �� ����
    public void ShowAnswer1()
    {
        GameObject.Find("Canvas").transform.Find("Result1").gameObject.SetActive(true); //ù��° �� ���� ��Ÿ����
        answer1.GetComponent<Button>().interactable = false;//��ư ��Ȱ��ȭ
        answer2.GetComponent<Button>().interactable = false;
        MainDirector.money += 1; //�� +1
    }

    //�ι�° �� ���ý�. ���� ����
    public void ShowAnswer2()
    {
        GameObject.Find("Canvas").transform.Find("Result2").gameObject.SetActive(true); //�ι�° �� ���� ��Ÿ����
        answer1.GetComponent<Button>().interactable = false;
        answer2.GetComponent<Button>().interactable = false;
    }

    //2�� ù��° �� ���� ��. ��� ����
    public void ShowAnswer2_1()
    {
        GameObject.Find("Canvas").transform.Find("Result1").gameObject.SetActive(true); //ù��° �� ���� ��Ÿ����
        answer1.GetComponent<Button>().interactable = false;//��ư ��Ȱ��ȭ
        answer2.GetComponent<Button>().interactable = false;
        dontDestroy.GetComponent<InventoryDirector>().GetNewMeterial();
        MainDirector.meterial++;
    }

    //3�� ù��° �� ���ý�. ��� ����
    public void ShowAnswer3_1()
    {
        GameObject.Find("Canvas").transform.Find("Result1").gameObject.SetActive(true); //ù��° �� ���� ��Ÿ����
        answer1.GetComponent<Button>().interactable = false;//��ư ��Ȱ��ȭ
        answer2.GetComponent<Button>().interactable = false;
        if (MainDirector.meterial > 0)
        {
            dontDestroy.GetComponent<InventoryDirector>().LoseMeterial();
            MainDirector.meterial--;
        }
    }

    //3�� �ι�° �� ���� ��. �� ����
    public void ShowAnswer3_2()
    {
        GameObject.Find("Canvas").transform.Find("Result2").gameObject.SetActive(true); //ù��° �� ���� ��Ÿ����
        answer1.GetComponent<Button>().interactable = false;//��ư ��Ȱ��ȭ
        answer2.GetComponent<Button>().interactable = false;
        if (MainDirector.money > 0)
            MainDirector.money -= 1;
    }

    //4�� ù��° �� ���ý�. ���� ����
    public void ShowAnswer4_1()
    {
        GameObject.Find("Canvas").transform.Find("Result1").gameObject.SetActive(true); //ù��° �� ���� ��Ÿ����
        answer1.GetComponent<Button>().interactable = false;//��ư ��Ȱ��ȭ
        answer2.GetComponent<Button>().interactable = false;
        if (MainDirector.heart > 0)
            MainDirector.heart--;
    }

    //5�� ù��° �� ���ý�. �� ����, ��� ����
    public void ShowAnswer5_1()
    {
        GameObject.Find("Canvas").transform.Find("Result1").gameObject.SetActive(true); //ù��° �� ���� ��Ÿ����
        answer1.GetComponent<Button>().interactable = false;//��ư ��Ȱ��ȭ
        answer2.GetComponent<Button>().interactable = false;
        if (MainDirector.money > 0)
        {
            MainDirector.money -= 1;
            dontDestroy.GetComponent<InventoryDirector>().GetNewMeterial();
            MainDirector.meterial++;
        }
    }

    //8�� ù��° �� ���ý�. �� ����, ���� ����
    public void ShowAnswer8_1()
    {
        GameObject.Find("Canvas").transform.Find("Result1").gameObject.SetActive(true); //ù��° �� ���� ��Ÿ����
        answer1.GetComponent<Button>().interactable = false;//��ư ��Ȱ��ȭ
        answer2.GetComponent<Button>().interactable = false;
        if (MainDirector.money > 0)
        {
            MainDirector.money -= 1;
            MainDirector.heart++;
        }
    }
}
