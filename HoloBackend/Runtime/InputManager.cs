using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public DataManager dataManager;

    void Start()
    {
        if (dataManager == null)
            Debug.LogError("Data Manager is NULL");
        DontDestroyOnLoad(gameObject);
    }

    public bool SignInCheck(string userName, string password)
    {
        if (userName.Length == 0 || password.Length == 0)
            return false;

        if (!dataManager.dataMap.ContainsKey(userName))
            return false;

        if (password == dataManager.dataMap[userName].password)
            return true;
        else
            return false;
    }
}
