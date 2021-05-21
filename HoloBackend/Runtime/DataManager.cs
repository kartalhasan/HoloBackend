using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataManager : MonoBehaviour
{
    public List<Data> dataList;
    public Dictionary<string, Data> dataMap = new Dictionary<string, Data>();

    public void Awake()
    {
        for (int i = 0; i < dataList.Count; i++)
            dataMap.Add(dataList[i].name, dataList[i]);
    }

    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    public List<Data> GetDataList()
    {
        if (dataList == null)
            Debug.LogError("Data List is Null");
        return dataList;
    }

    public Dictionary<string, Data> GetDataMapWithUserName()
    {
        if (dataMap == null)
            Debug.LogError("Data Map is Null");
        return dataMap;
    }
}
