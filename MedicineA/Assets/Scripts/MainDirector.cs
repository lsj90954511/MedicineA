using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainDirector : MonoBehaviour
{
    GameObject heart1;
    GameObject heart2;
    GameObject heart3;

    public static int heart = 3;
    // Start is called before the first frame update
    void Start()
    {
        this.heart1 = GameObject.Find("Heart1");
        this.heart2 = GameObject.Find("Heart2");
        this.heart3 = GameObject.Find("Heart3");
    }

    // Update is called once per frame
    void Update()
    {
        if (heart == 2)
        {
            heart3.GetComponent<HeartChange>().ChangeHeart();
        }
        else if (heart == 1)
        {
            heart3.GetComponent<HeartChange>().ChangeHeart();
            heart2.GetComponent<HeartChange>().ChangeHeart();
        }
        else if (heart == 0)
        {
            heart3.GetComponent<HeartChange>().ChangeHeart();
            heart2.GetComponent<HeartChange>().ChangeHeart();
            heart1.GetComponent<HeartChange>().ChangeHeart();
        }
    }
}
