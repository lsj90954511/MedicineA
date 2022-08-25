using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PanelScript : MonoBehaviour
{
    public static bool reset = false;
    GameObject panel;

    void Start()
    {
        this.panel = GameObject.Find("Panel");
    }

    public void GoMain()
    {
        reset = true;
        MainDirector.heart = 3;
        MainDirector.money = 0;
        MainDirector.meterial = 0;
        SceneManager.LoadScene("Main");
        panel.SetActive(false);
    }
}
