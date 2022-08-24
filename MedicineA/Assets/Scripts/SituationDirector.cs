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
        //하트 찾기
        this.heart1 = GameObject.Find("Heart1");
        this.heart2 = GameObject.Find("Heart2");
        this.heart3 = GameObject.Find("Heart3");

        //돈 텍스트 찾기
        this.nowmoney = GameObject.Find("Money");

        //선택 결과 지문 비활성화
        this.result1 = GameObject.Find("Result1");
        this.result2 = GameObject.Find("Result2");
        result1.SetActive(false);
        result2.SetActive(false);

        //선택지 버튼 찾기
        this.answer1 = GameObject.Find("Answer1");
        this.answer2 = GameObject.Find("Answer2");
    }

    void Update()
    {
        //하트 개수에 따라 이미지 나타내기
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

        //돈 나타내기
        nowmoney.GetComponent<Text>().text = MainDirector.money.ToString();

        //선택지 고른 후에 화면 터치하면 메인 씬으로 이동
        if (answer1.GetComponent<Button>().interactable == false && answer2.GetComponent<Button>().interactable == false)
        {
            if (Input.GetMouseButtonDown(0))
                SceneManager.LoadScene("Main");
        }
    }
}
