using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainDirector : MonoBehaviour
{
    GameObject heart1;
    GameObject heart2;
    GameObject heart3;
    GameObject nowmoney;

    public static int heart = 3; //���� �� �����ϴ� ���� ����
    public static int money = 0; //�� �����ϴ� ���� ����

    void Start()
    {
        this.heart1 = GameObject.Find("Heart1");
        this.heart2 = GameObject.Find("Heart2");
        this.heart3 = GameObject.Find("Heart3");

        //�� �ؽ�Ʈ ã��
        this.nowmoney = GameObject.Find("Money");
    }

    void Update()
    {
        //���� ���� ���� �̹��� ��Ÿ����
        if (heart == 2)
        {
            heart3.GetComponent<HeartChange>().ChangeHeart();
        }
        else if (heart == 1)
        {
            heart3.GetComponent<HeartChange>().ChangeHeart();
            heart2.GetComponent<HeartChange>().ChangeHeart();
        }
        else if (heart == 0)
        {
            heart3.GetComponent<HeartChange>().ChangeHeart();
            heart2.GetComponent<HeartChange>().ChangeHeart();
            heart1.GetComponent<HeartChange>().ChangeHeart();
        }

        //�� ��Ÿ����
        nowmoney.GetComponent<Text>().text = money.ToString();
    }
}