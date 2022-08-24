using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryDirector : MonoBehaviour
{
    GameObject slot1, slot2, slot3, slot4, slot5;
    Queue<int> queue = new Queue<int>();
    int[] slotArray = new int[] {20, 20, 20, 20, 20}; //슬롯이 차 있는지 여부를 확인할 배열. 차면 재료 번호, 비면 20.
    public Sprite[] sprites = new Sprite[20];

    void Start()
    {
        slot1 = GameObject.Find("Slot1");
        slot2 = GameObject.Find("Slot2");
        slot3 = GameObject.Find("Slot3");
        slot4 = GameObject.Find("Slot4");
        slot5 = GameObject.Find("Slot5");
        //슬롯 투명하게 만들기
        Color color1 = slot1.GetComponent<SpriteRenderer>().color;
        Color color2 = slot2.GetComponent<SpriteRenderer>().color;
        Color color3 = slot3.GetComponent<SpriteRenderer>().color;
        Color color4 = slot4.GetComponent<SpriteRenderer>().color;
        Color color5 = slot5.GetComponent<SpriteRenderer>().color;
        color1.a = 0;
        color2.a = 0;
        color3.a = 0;
        color4.a = 0;
        color5.a = 0;
        slot1.GetComponent<SpriteRenderer>().color = color1;
        slot2.GetComponent<SpriteRenderer>().color = color2;
        slot3.GetComponent<SpriteRenderer>().color = color3;
        slot4.GetComponent<SpriteRenderer>().color = color4;
        slot5.GetComponent<SpriteRenderer>().color = color5;
    }

    //새로운 재료 얻었을 때.
    public void GetNewMeterial()
    {
        slot1 = GameObject.Find("Slot1");
        slot2 = GameObject.Find("Slot2");
        slot3 = GameObject.Find("Slot3");
        slot4 = GameObject.Find("Slot4");
        slot5 = GameObject.Find("Slot5");

        int randomValue = Random.Range(0, 20);
        int slotnum = 0; //재료 그림 넣을 슬롯 번호
        if (queue.Count < 5) //큐가 꽉 차지 않았을 때
        {
            queue.Enqueue(randomValue); //재료 번호 큐에 넣음
            for (int i = 0; i < 5; i++)
            {
                if (slotArray[i] == 20)
                {
                    slotnum = i + 1;
                    slotArray[i] = randomValue;
                    break;
                }
            }
            switch (slotnum)
            {
                case 1:
                    Color color1 = slot1.GetComponent<SpriteRenderer>().color;
                    color1.a = 255;
                    slot1.GetComponent<SpriteRenderer>().color = color1; //투명도 원래대로
                    slot1.GetComponent<SpriteRenderer>().sprite = sprites[randomValue];
                    break;
                case 2:
                    Color color2 = slot2.GetComponent<SpriteRenderer>().color;
                    color2.a = 255;
                    slot2.GetComponent<SpriteRenderer>().color = color2; //투명도 원래대로
                    slot2.GetComponent<SpriteRenderer>().sprite = sprites[randomValue];
                    break;
                case 3:
                    Color color3 = slot3.GetComponent<SpriteRenderer>().color;
                    color3.a = 255;
                    slot3.GetComponent<SpriteRenderer>().color = color3; //투명도 원래대로
                    slot3.GetComponent<SpriteRenderer>().sprite = sprites[randomValue];
                    break;
                case 4:
                    Color color4 = slot4.GetComponent<SpriteRenderer>().color;
                    color4.a = 255;
                    slot4.GetComponent<SpriteRenderer>().color = color4; //투명도 원래대로
                    slot4.GetComponent<SpriteRenderer>().sprite = sprites[randomValue];
                    break;
                case 5:
                    Color color5 = slot5.GetComponent<SpriteRenderer>().color;
                    color5.a = 255;
                    slot5.GetComponent<SpriteRenderer>().color = color5; //투명도 원래대로
                    slot5.GetComponent<SpriteRenderer>().sprite = sprites[randomValue];
                    break;
            }
        }
        else //큐가 꽉 찼을 때
        {
            LoseMeterial();
            queue.Enqueue(randomValue); //재료 번호 큐에 넣음
            for (int i = 0; i < 5; i++)
            {
                if (slotArray[i] == 20)
                {
                    slotnum = i + 1;
                    slotArray[i] = randomValue;
                    break;
                }
            }
            switch (slotnum)
            {
                case 1:
                    Color color1 = slot1.GetComponent<SpriteRenderer>().color;
                    color1.a = 255;
                    slot1.GetComponent<SpriteRenderer>().color = color1; //투명도 원래대로
                    slot1.GetComponent<SpriteRenderer>().sprite = sprites[randomValue];
                    break;
                case 2:
                    Color color2 = slot2.GetComponent<SpriteRenderer>().color;
                    color2.a = 255;
                    slot2.GetComponent<SpriteRenderer>().color = color2; //투명도 원래대로
                    slot2.GetComponent<SpriteRenderer>().sprite = sprites[randomValue];
                    break;
                case 3:
                    Color color3 = slot3.GetComponent<SpriteRenderer>().color;
                    color3.a = 255;
                    slot3.GetComponent<SpriteRenderer>().color = color3; //투명도 원래대로
                    slot3.GetComponent<SpriteRenderer>().sprite = sprites[randomValue];
                    break;
                case 4:
                    Color color4 = slot4.GetComponent<SpriteRenderer>().color;
                    color4.a = 255;
                    slot4.GetComponent<SpriteRenderer>().color = color4; //투명도 원래대로
                    slot4.GetComponent<SpriteRenderer>().sprite = sprites[randomValue];
                    break;
                case 5:
                    Color color5 = slot5.GetComponent<SpriteRenderer>().color;
                    color5.a = 255;
                    slot5.GetComponent<SpriteRenderer>().color = color5; //투명도 원래대로
                    slot5.GetComponent<SpriteRenderer>().sprite = sprites[randomValue];
                    break;
            }
        }
    }

    //재료 잃었을 때
    public void LoseMeterial()
    {
        slot1 = GameObject.Find("Slot1");
        slot2 = GameObject.Find("Slot2");
        slot3 = GameObject.Find("Slot3");
        slot4 = GameObject.Find("Slot4");
        slot5 = GameObject.Find("Slot5");

        int mNum = queue.Dequeue(); //잃은 재료 번호 저장, 큐에서 제거
        int slotnum = 1; //잃은 재료의 슬롯 번호
        for (int i = 0; i < 5; i++) //슬롯 배열 다시 빈 걸로 설정
        {
            if (slotArray[i] == mNum)
            {
                slotArray[i] = 20;
                slotnum = i + 1;
                break;
            }
        }

        switch (slotnum)
        {
            case 1:
                Color color1 = slot1.GetComponent<SpriteRenderer>().color;
                color1.a = 0;
                slot1.GetComponent<SpriteRenderer>().color = color1; //투명도 0으로
                break;
            case 2:
                Color color2 = slot2.GetComponent<SpriteRenderer>().color;
                color2.a = 0;
                slot2.GetComponent<SpriteRenderer>().color = color2; //투명도 0으로
                break;
            case 3:
                Color color3 = slot3.GetComponent<SpriteRenderer>().color;
                color3.a = 0;
                slot3.GetComponent<SpriteRenderer>().color = color3; //투명도 0으로
                break;
            case 4:
                Color color4 = slot4.GetComponent<SpriteRenderer>().color;
                color4.a = 0;
                slot4.GetComponent<SpriteRenderer>().color = color4; //투명도 0으로
                break;
            case 5:
                Color color5 = slot5.GetComponent<SpriteRenderer>().color;
                color5.a = 0;
                slot5.GetComponent<SpriteRenderer>().color = color5; //투명도 0으로
                break;
        }
    }
}
