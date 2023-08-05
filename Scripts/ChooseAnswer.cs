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

    //첫번째 답 선택 시. 돈 얻음
    public void ShowAnswer1()
    {
        GameObject.Find("Canvas").transform.Find("Result1").gameObject.SetActive(true); //첫번째 답 지문 나타내기
        answer1.GetComponent<Button>().interactable = false;//버튼 비활성화
        answer2.GetComponent<Button>().interactable = false;
        MainDirector.money += 1; //돈 +1
    }

    //두번째 답 선택시. 변동 없음
    public void ShowAnswer2()
    {
        GameObject.Find("Canvas").transform.Find("Result2").gameObject.SetActive(true); //두번째 답 지문 나타내기
        answer1.GetComponent<Button>().interactable = false;
        answer2.GetComponent<Button>().interactable = false;
    }

    //2씬 첫번째 답 선택 시. 재료 얻음
    public void ShowAnswer2_1()
    {
        GameObject.Find("Canvas").transform.Find("Result1").gameObject.SetActive(true); //첫번째 답 지문 나타내기
        answer1.GetComponent<Button>().interactable = false;//버튼 비활성화
        answer2.GetComponent<Button>().interactable = false;
        dontDestroy.GetComponent<InventoryDirector>().GetNewMeterial();
        MainDirector.meterial++;
    }

    //3씬 첫번째 답 선택시. 재료 잃음
    public void ShowAnswer3_1()
    {
        GameObject.Find("Canvas").transform.Find("Result1").gameObject.SetActive(true); //첫번째 답 지문 나타내기
        answer1.GetComponent<Button>().interactable = false;//버튼 비활성화
        answer2.GetComponent<Button>().interactable = false;
        if (MainDirector.meterial > 0)
        {
            dontDestroy.GetComponent<InventoryDirector>().LoseMeterial();
            MainDirector.meterial--;
        }
    }

    //3씬 두번째 답 선택 시. 돈 잃음
    public void ShowAnswer3_2()
    {
        GameObject.Find("Canvas").transform.Find("Result2").gameObject.SetActive(true); //첫번째 답 지문 나타내기
        answer1.GetComponent<Button>().interactable = false;//버튼 비활성화
        answer2.GetComponent<Button>().interactable = false;
        if (MainDirector.money > 0)
            MainDirector.money -= 1;
    }

    //4씬 첫번째 답 선택시. 생명 잃음
    public void ShowAnswer4_1()
    {
        GameObject.Find("Canvas").transform.Find("Result1").gameObject.SetActive(true); //첫번째 답 지문 나타내기
        answer1.GetComponent<Button>().interactable = false;//버튼 비활성화
        answer2.GetComponent<Button>().interactable = false;
        if (MainDirector.heart > 0)
            MainDirector.heart--;
    }

    //5씬 첫번째 답 선택시. 돈 잃음, 재료 얻음
    public void ShowAnswer5_1()
    {
        GameObject.Find("Canvas").transform.Find("Result1").gameObject.SetActive(true); //첫번째 답 지문 나타내기
        answer1.GetComponent<Button>().interactable = false;//버튼 비활성화
        answer2.GetComponent<Button>().interactable = false;
        if (MainDirector.money > 0)
        {
            MainDirector.money -= 1;
            dontDestroy.GetComponent<InventoryDirector>().GetNewMeterial();
            MainDirector.meterial++;
        }
    }

    //8씬 첫번째 답 선택시. 돈 잃음, 생명 얻음
    public void ShowAnswer8_1()
    {
        GameObject.Find("Canvas").transform.Find("Result1").gameObject.SetActive(true); //첫번째 답 지문 나타내기
        answer1.GetComponent<Button>().interactable = false;//버튼 비활성화
        answer2.GetComponent<Button>().interactable = false;
        if (MainDirector.money > 0)
        {
            MainDirector.money -= 1;
            MainDirector.heart++;
        }
    }
}
