using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryDirector : MonoBehaviour
{
    public static int aPoint, bPoint; //��������Ʈ
    public static bool num3 = false, num10 = false, num11 = false, num15 = false; //���� ��üx����, �������, ���ϻ���, �߸���

    GameObject slot1, slot2, slot3, slot4, slot5, name1, name2, name3, name4, name5;
    Queue<int> queue = new Queue<int>();
    int[] slotArray = new int[] {20, 20, 20, 20, 20}; //������ �� �ִ��� ���θ� Ȯ���� �迭. ���� ��� ��ȣ, ��� 20.
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
        //���� �����ϰ� �����
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
            //���� �����ϰ� �����
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

            //�ʱ�ȭ
            queue.Clear();
            slotArray = new int[] { 20, 20, 20, 20, 20 };

            PanelScript.reset = false;
        }
    }

    //���ο� ��� ����� ��.
    public void GetNewMeterial()
    {
        slot1 = GameObject.Find("Slot1");
        slot2 = GameObject.Find("Slot2");
        slot3 = GameObject.Find("Slot3");
        slot4 = GameObject.Find("Slot4");
        slot5 = GameObject.Find("Slot5");

        int randomValue = Random.Range(0, 20);
        //�ߺ� ���ϱ�
        for (int i = 0; i < 5; i++)
        {
            if (slotArray[i] == randomValue)
            {
                GetNewMeterial();
                return;
            }
        }
        int slotnum = 0; //��� �׸� ���� ���� ��ȣ
        if (queue.Count < 5) //ť�� �� ���� �ʾ��� ��
        {
            queue.Enqueue(randomValue); //��� ��ȣ ť�� ����
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
                    slot1.GetComponent<SpriteRenderer>().color = color1; //���� �������
                    slot1.GetComponent<SpriteRenderer>().sprite = sprites[randomValue];
                    name1.GetComponent<Text>().text = sprites[randomValue].name;
                    break;
                case 2:
                    Color color2 = slot2.GetComponent<SpriteRenderer>().color;
                    color2.a = 255;
                    slot2.GetComponent<SpriteRenderer>().color = color2; //���� �������
                    slot2.GetComponent<SpriteRenderer>().sprite = sprites[randomValue];
                    name2.GetComponent<Text>().text = sprites[randomValue].name;
                    break;
                case 3:
                    Color color3 = slot3.GetComponent<SpriteRenderer>().color;
                    color3.a = 255;
                    slot3.GetComponent<SpriteRenderer>().color = color3; //���� �������
                    slot3.GetComponent<SpriteRenderer>().sprite = sprites[randomValue];
                    name3.GetComponent<Text>().text = sprites[randomValue].name;
                    break;
                case 4:
                    Color color4 = slot4.GetComponent<SpriteRenderer>().color;
                    color4.a = 255;
                    slot4.GetComponent<SpriteRenderer>().color = color4; //���� �������
                    slot4.GetComponent<SpriteRenderer>().sprite = sprites[randomValue];
                    name4.GetComponent<Text>().text = sprites[randomValue].name;
                    break;
                case 5:
                    Color color5 = slot5.GetComponent<SpriteRenderer>().color;
                    color5.a = 255;
                    slot5.GetComponent<SpriteRenderer>().color = color5; //���� �������
                    slot5.GetComponent<SpriteRenderer>().sprite = sprites[randomValue];
                    name5.GetComponent<Text>().text = sprites[randomValue].name;
                    break;
            }
            
        }
        else //ť�� �� á�� ��
        {
            LoseMeterial();
            queue.Enqueue(randomValue); //��� ��ȣ ť�� ����
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
                    slot1.GetComponent<SpriteRenderer>().color = color1; //���� �������
                    slot1.GetComponent<SpriteRenderer>().sprite = sprites[randomValue];
                    name1.GetComponent<Text>().text = sprites[randomValue].name;
                    break;
                case 2:
                    Color color2 = slot2.GetComponent<SpriteRenderer>().color;
                    color2.a = 255;
                    slot2.GetComponent<SpriteRenderer>().color = color2; //���� �������
                    slot2.GetComponent<SpriteRenderer>().sprite = sprites[randomValue];
                    name2.GetComponent<Text>().text = sprites[randomValue].name;
                    break;
                case 3:
                    Color color3 = slot3.GetComponent<SpriteRenderer>().color;
                    color3.a = 255;
                    slot3.GetComponent<SpriteRenderer>().color = color3; //���� �������
                    slot3.GetComponent<SpriteRenderer>().sprite = sprites[randomValue];
                    name3.GetComponent<Text>().text = sprites[randomValue].name;
                    break;
                case 4:
                    Color color4 = slot4.GetComponent<SpriteRenderer>().color;
                    color4.a = 255;
                    slot4.GetComponent<SpriteRenderer>().color = color4; //���� �������
                    slot4.GetComponent<SpriteRenderer>().sprite = sprites[randomValue];
                    name4.GetComponent<Text>().text = sprites[randomValue].name;
                    break;
                case 5:
                    Color color5 = slot5.GetComponent<SpriteRenderer>().color;
                    color5.a = 255;
                    slot5.GetComponent<SpriteRenderer>().color = color5; //���� �������
                    slot5.GetComponent<SpriteRenderer>().sprite = sprites[randomValue];
                    name5.GetComponent<Text>().text = sprites[randomValue].name;
                    break;
            }
        }

        //��������Ʈ �ױ�
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

    //��� �Ҿ��� ��
    public void LoseMeterial()
    {
        slot1 = GameObject.Find("Slot1");
        slot2 = GameObject.Find("Slot2");
        slot3 = GameObject.Find("Slot3");
        slot4 = GameObject.Find("Slot4");
        slot5 = GameObject.Find("Slot5");

        int mNum = queue.Dequeue(); //���� ��� ��ȣ ����, ť���� ����
        int slotnum = 1; //���� ����� ���� ��ȣ
        for (int i = 0; i < 5; i++) //���� �迭 �ٽ� �� �ɷ� ����
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
                slot1.GetComponent<SpriteRenderer>().color = color1; //���� 0����
                name1.GetComponent<Text>().text = " ";
                break;
            case 2:
                Color color2 = slot2.GetComponent<SpriteRenderer>().color;
                color2.a = 0;
                slot2.GetComponent<SpriteRenderer>().color = color2; //���� 0����
                name2.GetComponent<Text>().text = " ";
                break;
            case 3:
                Color color3 = slot3.GetComponent<SpriteRenderer>().color;
                color3.a = 0;
                slot3.GetComponent<SpriteRenderer>().color = color3; //���� 0����
                name3.GetComponent<Text>().text = " ";
                break;
            case 4:
                Color color4 = slot4.GetComponent<SpriteRenderer>().color;
                color4.a = 0;
                slot4.GetComponent<SpriteRenderer>().color = color4; //���� 0����
                name4.GetComponent<Text>().text = " ";
                break;
            case 5:
                Color color5 = slot5.GetComponent<SpriteRenderer>().color;
                color5.a = 0;
                slot5.GetComponent<SpriteRenderer>().color = color5; //���� 0����
                name5.GetComponent<Text>().text = " ";
                break;
        }

        //��������Ʈ ����
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
