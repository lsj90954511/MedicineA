using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class AdManager : MonoBehaviour, IUnityAdsInitializationListener
{
    public string gameId = "4901971";
    public bool testMode = false;

    private void Awake()
    {
        Advertisement.Initialize(gameId, testMode, this);
    }

    public void OnInitializationComplete()
    {
        Debug.Log("Unity Ads init completed");
    }

    public void OnInitializationFailed(UnityAdsInitializationError error, string message)
    {
        Debug.LogFormat("[Unity Ads init failed]\n error: {0}\n message: {1}", error, message);
    }

}