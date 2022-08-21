using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeartChange : MonoBehaviour
{
    public Sprite change_img; //바꿀 이미지
    Image now_img; //현재 이미지

    void Start()
    {
        now_img = GetComponent<Image>();
    }

    public void ChangeHeart()
    {
        now_img.sprite = change_img;
    }
}
