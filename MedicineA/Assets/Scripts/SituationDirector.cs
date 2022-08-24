using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SituationDirector : MonoBehaviour
{
    GameObject heart1;
    GameObject heart2;
    GameObject heart3;
    GameObject nowmoney;
    GameObject answer1;
    GameObject answer2;
    public GameObject result1;
    public GameObject result2;

    void Start()
    {
        //��Ʈ ã��
        this.heart1 = GameObject.Find("Heart1");
        this.heart2 = GameObject.Find("Heart2");
        this.heart3 = GameObject.Find("Heart3");

        //�� �ؽ�Ʈ ã��
        this.nowmoney = GameObject.Find("Money");

        //���� ��� ���� ��Ȱ��ȭ
        this.result1 = GameObject.Find("Result1");
        this.result2 = GameObject.Find("Result2");
        result1.SetActive(false);
        result2.SetActive(false);

        //������ ��ư ã��
        this.answer1 = GameObject.Find("Answer1");
        this.answer2 = GameObject.Find("Answer2");
    }

    void Update()
    {
        //��Ʈ ������ ���� �̹��� ��Ÿ����
        if (MainDirector.heart == 2)
        {
            heart3.GetComponent<HeartChange>().ChangeHeart();
        }
        else if (MainDirector.heart == 1)
        {
            heart3.GetComponent<HeartChange>().ChangeHeart();
            heart2.GetComponent<HeartChange>().ChangeHeart();
        }
        else if (MainDirector.heart == 0)
        {
            heart3.GetComponent<HeartChange>().ChangeHeart();
            heart2.GetComponent<HeartChange>().ChangeHeart();
            heart1.GetComponent<HeartChange>().ChangeHeart();
        }

        //�� ��Ÿ����
        nowmoney.GetComponent<Text>().text = MainDirector.money.ToString();

        //������ �� �Ŀ� ȭ�� ��ġ�ϸ� ���� ������ �̵�
        if (answer1.GetComponent<Button>().interactable == false && answer2.GetComponent<Button>().interactable == false)
        {
            if (Input.GetMouseButtonDown(0))
                SceneManager.LoadScene("Main");
        }
    }
}
