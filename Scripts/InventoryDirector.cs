using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryDirector : MonoBehaviour
{
    public static int aPoint, bPoint; //스택포인트
    public static bool num3 = false, num10 = false, num11 = false, num15 = false; //각각 정체x물질, 검은장미, 박하사탕, 발모제

    GameObject slot1, slot2, slot3, slot4, slot5, name1, name2, name3, name4, name5;
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
        name1 = GameObject.Find("Name1");
        name2 = GameObject.Find("Name2");
        name3 = GameObject.Find("Name3");
        name4 = GameObject.Find("Name4");
        name5 = GameObject.Find("Name5");
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

    void Update()
    {
        if (PanelScript.reset)
        {
            aPoint = 0;
            bPoint = 0;
            num3 = false;
            num10 = false;
            num11 = false;
            num15 = false;
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
            name1.GetComponent<Text>().text = " ";
            name2.GetComponent<Text>().text = " ";
            name3.GetComponent<Text>().text = " ";
            name4.GetComponent<Text>().text = " ";
            name5.GetComponent<Text>().text = " ";

            //초기화
            queue.Clear();
            slotArray = new int[] { 20, 20, 20, 20, 20 };

            PanelScript.reset = false;
        }
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
        //중복 피하기
        for (int i = 0; i < 5; i++)
        {
            if (slotArray[i] == randomValue)
            {
                GetNewMeterial();
                return;
            }
        }
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
                    name1.GetComponent<Text>().text = sprites[randomValue].name;
                    break;
                case 2:
                    Color color2 = slot2.GetComponent<SpriteRenderer>().color;
                    color2.a = 255;
                    slot2.GetComponent<SpriteRenderer>().color = color2; //투명도 원래대로
                    slot2.GetComponent<SpriteRenderer>().sprite = sprites[randomValue];
                    name2.GetComponent<Text>().text = sprites[randomValue].name;
                    break;
                case 3:
                    Color color3 = slot3.GetComponent<SpriteRenderer>().color;
                    color3.a = 255;
                    slot3.GetComponent<SpriteRenderer>().color = color3; //투명도 원래대로
                    slot3.GetComponent<SpriteRenderer>().sprite = sprites[randomValue];
                    name3.GetComponent<Text>().text = sprites[randomValue].name;
                    break;
                case 4:
                    Color color4 = slot4.GetComponent<SpriteRenderer>().color;
                    color4.a = 255;
                    slot4.GetComponent<SpriteRenderer>().color = color4; //투명도 원래대로
                    slot4.GetComponent<SpriteRenderer>().sprite = sprites[randomValue];
                    name4.GetComponent<Text>().text = sprites[randomValue].name;
                    break;
                case 5:
                    Color color5 = slot5.GetComponent<SpriteRenderer>().color;
                    color5.a = 255;
                    slot5.GetComponent<SpriteRenderer>().color = color5; //투명도 원래대로
                    slot5.GetComponent<SpriteRenderer>().sprite = sprites[randomValue];
                    name5.GetComponent<Text>().text = sprites[randomValue].name;
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
                    name1.GetComponent<Text>().text = sprites[randomValue].name;
                    break;
                case 2:
                    Color color2 = slot2.GetComponent<SpriteRenderer>().color;
                    color2.a = 255;
                    slot2.GetComponent<SpriteRenderer>().color = color2; //투명도 원래대로
                    slot2.GetComponent<SpriteRenderer>().sprite = sprites[randomValue];
                    name2.GetComponent<Text>().text = sprites[randomValue].name;
                    break;
                case 3:
                    Color color3 = slot3.GetComponent<SpriteRenderer>().color;
                    color3.a = 255;
                    slot3.GetComponent<SpriteRenderer>().color = color3; //투명도 원래대로
                    slot3.GetComponent<SpriteRenderer>().sprite = sprites[randomValue];
                    name3.GetComponent<Text>().text = sprites[randomValue].name;
                    break;
                case 4:
                    Color color4 = slot4.GetComponent<SpriteRenderer>().color;
                    color4.a = 255;
                    slot4.GetComponent<SpriteRenderer>().color = color4; //투명도 원래대로
                    slot4.GetComponent<SpriteRenderer>().sprite = sprites[randomValue];
                    name4.GetComponent<Text>().text = sprites[randomValue].name;
                    break;
                case 5:
                    Color color5 = slot5.GetComponent<SpriteRenderer>().color;
                    color5.a = 255;
                    slot5.GetComponent<SpriteRenderer>().color = color5; //투명도 원래대로
                    slot5.GetComponent<SpriteRenderer>().sprite = sprites[randomValue];
                    name5.GetComponent<Text>().text = sprites[randomValue].name;
                    break;
            }
        }

        //스택포인트 쌓기
        switch (randomValue)
        {
            case 0:
                aPoint += 6;
                bPoint += 10;
                break;
            case 1:
                aPoint += 1;
                bPoint += 15;
                break;
            case 2:
                aPoint += 2;
                bPoint += 3;
                break;
            case 3:
                aPoint += 11;
                bPoint += 20;
                num3 = true;
                break;
            case 4:
                aPoint += 10;
                bPoint += 22;
                break;
            case 5:
                aPoint += 10;
                bPoint += 9;
                break;
            case 6:
                aPoint += 5;
                bPoint += 11;
                break;
            case 7:
                aPoint += 25;
                bPoint += 23;
                break;
            case 8:
                aPoint += 32;
                bPoint += 10;
                break;
            case 9:
                aPoint += 8;
                bPoint += 27;
                break;
            case 10:
                aPoint += 1;
                bPoint += 3;
                num10 = true;
                break;
            case 11:
                aPoint += 3;
                bPoint += 1;
                num11 = true;
                break;
            case 12:
                aPoint += 5;
                bPoint += 2;
                break;
            case 13:
                aPoint += 2;
                bPoint += 3;
                break;
            case 14:
                aPoint += 4;
                bPoint += 1;
                break;
            case 15:
                aPoint += 1;
                bPoint += 1;
                num15 = true;
                break;
            case 16:
                aPoint += 25;
                bPoint += 25;
                break;
            case 17:
                aPoint += 20;
                bPoint += 21;
                break;
            case 18:
                aPoint -= 30;
                bPoint -= 30;
                break;
            case 19:
                aPoint -= 20;
                bPoint -= 25;
                break;
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
                name1.GetComponent<Text>().text = " ";
                break;
            case 2:
                Color color2 = slot2.GetComponent<SpriteRenderer>().color;
                color2.a = 0;
                slot2.GetComponent<SpriteRenderer>().color = color2; //투명도 0으로
                name2.GetComponent<Text>().text = " ";
                break;
            case 3:
                Color color3 = slot3.GetComponent<SpriteRenderer>().color;
                color3.a = 0;
                slot3.GetComponent<SpriteRenderer>().color = color3; //투명도 0으로
                name3.GetComponent<Text>().text = " ";
                break;
            case 4:
                Color color4 = slot4.GetComponent<SpriteRenderer>().color;
                color4.a = 0;
                slot4.GetComponent<SpriteRenderer>().color = color4; //투명도 0으로
                name4.GetComponent<Text>().text = " ";
                break;
            case 5:
                Color color5 = slot5.GetComponent<SpriteRenderer>().color;
                color5.a = 0;
                slot5.GetComponent<SpriteRenderer>().color = color5; //투명도 0으로
                name5.GetComponent<Text>().text = " ";
                break;
        }

        //스택포인트 빼기
        switch (mNum)
        {
            case 0:
                aPoint -= 6;
                bPoint -= 10;
                break;
            case 1:
                aPoint -= 1;
                bPoint -= 15;
                break;
            case 2:
                aPoint -= 2;
                bPoint -= 3;
                break;
            case 3:
                aPoint -= 11;
                bPoint -= 20;
                num3 = false;
                break;
            case 4:
                aPoint -= 10;
                bPoint -= 22;
                break;
            case 5:
                aPoint -= 10;
                bPoint -= 9;
                break;
            case 6:
                aPoint -= 5;
                bPoint -= 11;
                break;
            case 7:
                aPoint -= 25;
                bPoint -= 23;
                break;
            case 8:
                aPoint -= 32;
                bPoint -= 10;
                break;
            case 9:
                aPoint -= 8;
                bPoint -= 27;
                break;
            case 10:
                aPoint -= 1;
                bPoint -= 3;
                num10 = false;
                break;
            case 11:
                aPoint -= 3;
                bPoint -= 1;
                num11 = false;
                break;
            case 12:
                aPoint -= 5;
                bPoint -= 2;
                break;
            case 13:
                aPoint -= 2;
                bPoint -= 3;
                break;
            case 14:
                aPoint -= 4;
                bPoint -= 1;
                break;
            case 15:
                aPoint -= 1;
                bPoint -= 1;
                num15 = false;
                break;
            case 16:
                aPoint -= 25;
                bPoint -= 25;
                break;
            case 17:
                aPoint -= 20;
                bPoint -= 21;
                break;
            case 18:
                aPoint += 30;
                bPoint += 30;
                break;
            case 19:
                aPoint += 20;
                bPoint += 25;
                break;
        }
    }
}
