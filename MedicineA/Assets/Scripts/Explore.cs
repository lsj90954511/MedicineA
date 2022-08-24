using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Explore : MonoBehaviour
{
    public void SceneChange()
    {
        int randomValue = Random.Range(1, 2);
        SceneManager.LoadScene(randomValue.ToString());
    }
}
