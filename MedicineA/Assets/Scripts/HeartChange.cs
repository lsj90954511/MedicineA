using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeartChange : MonoBehaviour
{
    public Sprite change_img; //�ٲ� �̹���
    Image now_img; //���� �̹���

    void Start()
    {
        now_img = GetComponent<Image>();
    }

    public void ChangeHeart()
    {
        now_img.sprite = change_img;
    }
}
