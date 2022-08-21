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

    public static int heart = 3; //생명 수 저장하는 전역 변수
    public static int money = 0; //돈 저장하는 전역 변수

    void Start()
    {
        this.heart1 = GameObject.Find("Heart1");
        this.heart2 = GameObject.Find("Heart2");
        this.heart3 = GameObject.Find("Heart3");

        //돈 텍스트 찾기
        this.nowmoney = GameObject.Find("Money");
    }

    void Update()
    {
        //생명 수에 따라 이미지 나타내기
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

        //돈 나타내기
        nowmoney.GetComponent<Text>().text = money.ToString();
    }
}
