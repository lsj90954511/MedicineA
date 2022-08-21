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

    //첫번째 답 선택 시
    public void ShowAnswer1()
    {
        GameObject.Find("Canvas").transform.Find("Result1").gameObject.SetActive(true); //첫번째 답 지문 나타내기
        answer1.GetComponent<Button>().interactable = false;//버튼 비활성화
        answer2.GetComponent<Button>().interactable = false;
        MainDirector.money += 1; //돈 +1
    }

    //두번째 답 선택시
    public void ShowAnswer2()
    {
        GameObject.Find("Canvas").transform.Find("Result2").gameObject.SetActive(true); //두번째 답 지문 나타내기
        answer1.GetComponent<Button>().interactable = false;
        answer2.GetComponent<Button>().interactable = false;
    }
}
