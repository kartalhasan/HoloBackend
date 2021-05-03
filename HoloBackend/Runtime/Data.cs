using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "User", menuName = "NewUser")]
public class Data : ScriptableObject
{
    public Sprite sprite;
    public string PersonName;
    public string id;
    public string password;
    public string userName;
}
