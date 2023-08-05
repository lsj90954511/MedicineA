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
    GameObject panel;

    public static int heart = 3; //생명 수 저장하는 전역 변수
    public static int money = 0; //돈 저장하는 전역 변수
    public static int meterial = 0; //재료 수 저장하는 전역변수

    public Sprite[] heartSprites = new Sprite[2];

    void Start()
    {
        this.heart1 = GameObject.Find("Heart1");
        this.heart2 = GameObject.Find("Heart2");
        this.heart3 = GameObject.Find("Heart3");

        //돈 텍스트 찾기
        this.nowmoney = GameObject.Find("Money");

        //패널 찾고 비활성화
        this.panel = GameObject.Find("Panel");
        panel.SetActive(false);
    }

    void Update()
    {
        //생명 수에 따라 이미지 나타내기
        if (heart == 2)
        {
            heart2.GetComponent<Image>().sprite = heartSprites[1];
            heart1.GetComponent<Image>().sprite = heartSprites[1];
            heart3.GetComponent<Image>().sprite = heartSprites[0];
        }
        else if (heart == 1)
        {
            heart1.GetComponent<Image>().sprite = heartSprites[1];
            heart3.GetComponent<Image>().sprite = heartSprites[0];
            heart2.GetComponent<Image>().sprite = heartSprites[0];
        }
        else if (heart == 0)
        {
            heart3.GetComponent<Image>().sprite = heartSprites[0];
            heart2.GetComponent<Image>().sprite = heartSprites[0];
            heart1.GetComponent<Image>().sprite = heartSprites[0];
            GameObject.Find("Canvas2").transform.Find("Panel").gameObject.SetActive(true);
        }
        else if (heart >= 3)
        {
            heart3.GetComponent<Image>().sprite = heartSprites[1];
            heart2.GetComponent<Image>().sprite = heartSprites[1];
            heart1.GetComponent<Image>().sprite = heartSprites[1];
        }

        //돈 나타내기
        nowmoney.GetComponent<Text>().text = money.ToString();
    }
}
