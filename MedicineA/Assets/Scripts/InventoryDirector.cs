using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryDirector : MonoBehaviour
{
    GameObject slot1, slot2, slot3, slot4, slot5;
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

    //���ο� ��� ����� ��.
    public void GetNewMeterial()
    {
        slot1 = GameObject.Find("Slot1");
        slot2 = GameObject.Find("Slot2");
        slot3 = GameObject.Find("Slot3");
        slot4 = GameObject.Find("Slot4");
        slot5 = GameObject.Find("Slot5");

        int randomValue = Random.Range(0, 20);
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
                    break;
                case 2:
                    Color color2 = slot2.GetComponent<SpriteRenderer>().color;
                    color2.a = 255;
                    slot2.GetComponent<SpriteRenderer>().color = color2; //���� �������
                    slot2.GetComponent<SpriteRenderer>().sprite = sprites[randomValue];
                    break;
                case 3:
                    Color color3 = slot3.GetComponent<SpriteRenderer>().color;
                    color3.a = 255;
                    slot3.GetComponent<SpriteRenderer>().color = color3; //���� �������
                    slot3.GetComponent<SpriteRenderer>().sprite = sprites[randomValue];
                    break;
                case 4:
                    Color color4 = slot4.GetComponent<SpriteRenderer>().color;
                    color4.a = 255;
                    slot4.GetComponent<SpriteRenderer>().color = color4; //���� �������
                    slot4.GetComponent<SpriteRenderer>().sprite = sprites[randomValue];
                    break;
                case 5:
                    Color color5 = slot5.GetComponent<SpriteRenderer>().color;
                    color5.a = 255;
                    slot5.GetComponent<SpriteRenderer>().color = color5; //���� �������
                    slot5.GetComponent<SpriteRenderer>().sprite = sprites[randomValue];
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
                    break;
                case 2:
                    Color color2 = slot2.GetComponent<SpriteRenderer>().color;
                    color2.a = 255;
                    slot2.GetComponent<SpriteRenderer>().color = color2; //���� �������
                    slot2.GetComponent<SpriteRenderer>().sprite = sprites[randomValue];
                    break;
                case 3:
                    Color color3 = slot3.GetComponent<SpriteRenderer>().color;
                    color3.a = 255;
                    slot3.GetComponent<SpriteRenderer>().color = color3; //���� �������
                    slot3.GetComponent<SpriteRenderer>().sprite = sprites[randomValue];
                    break;
                case 4:
                    Color color4 = slot4.GetComponent<SpriteRenderer>().color;
                    color4.a = 255;
                    slot4.GetComponent<SpriteRenderer>().color = color4; //���� �������
                    slot4.GetComponent<SpriteRenderer>().sprite = sprites[randomValue];
                    break;
                case 5:
                    Color color5 = slot5.GetComponent<SpriteRenderer>().color;
                    color5.a = 255;
                    slot5.GetComponent<SpriteRenderer>().color = color5; //���� �������
                    slot5.GetComponent<SpriteRenderer>().sprite = sprites[randomValue];
                    break;
            }
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
                break;
            case 2:
                Color color2 = slot2.GetComponent<SpriteRenderer>().color;
                color2.a = 0;
                slot2.GetComponent<SpriteRenderer>().color = color2; //���� 0����
                break;
            case 3:
                Color color3 = slot3.GetComponent<SpriteRenderer>().color;
                color3.a = 0;
                slot3.GetComponent<SpriteRenderer>().color = color3; //���� 0����
                break;
            case 4:
                Color color4 = slot4.GetComponent<SpriteRenderer>().color;
                color4.a = 0;
                slot4.GetComponent<SpriteRenderer>().color = color4; //���� 0����
                break;
            case 5:
                Color color5 = slot5.GetComponent<SpriteRenderer>().color;
                color5.a = 0;
                slot5.GetComponent<SpriteRenderer>().color = color5; //���� 0����
                break;
        }
    }
}
