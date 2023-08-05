using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Manufacture : MonoBehaviour
{
    public GameObject manufacture;

    void Start()
    {
        this.manufacture = GameObject.Find("Manufacture");
    }

    void Update()
    {
        if (MainDirector.meterial != 5)
        {
            this.manufacture.GetComponent<Button>().interactable = false;
        }
        else
        {
            this.manufacture.GetComponent<Button>().interactable = true;
        }
    }

    public void GoEnding()
    {
        if (MainDirector.meterial == 5)
        {
            PanelScript.reset = true;
            MainDirector.heart = 3;
            MainDirector.money = 0;
            MainDirector.meterial = 0;

            //탈모
            if (InventoryDirector.num15)
            {
                SceneManager.LoadScene("Result6");
            }
            //완성된 치료제
            else if (InventoryDirector.aPoint >= 30 && InventoryDirector.aPoint <= 40 && InventoryDirector.bPoint >= 70 && InventoryDirector.bPoint <= 80 && InventoryDirector.num3)
            {
                SceneManager.LoadScene("Result1");
            }
            //각성제
            else if (InventoryDirector.aPoint >= 80 && InventoryDirector.bPoint >= 80 && InventoryDirector.num11)
            {
                SceneManager.LoadScene("Result4");
            }
            //좀비
            else if (InventoryDirector.aPoint <= 20 && InventoryDirector.bPoint <= 20 && InventoryDirector.num10)
            {
                SceneManager.LoadScene("Result5");
            }
            //미완성 치료제
            else if (InventoryDirector.aPoint >= 30 && InventoryDirector.aPoint <= 40 || InventoryDirector.bPoint >= 70 && InventoryDirector.bPoint <= 80)
            {
                SceneManager.LoadScene("Result2");
            }
            else
            {
                SceneManager.LoadScene("Result3");
            }
        }
    }
}
