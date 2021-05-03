using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;
[ExecuteInEditMode]
public class DataEditor : EditorWindow 
{
    public string m_name;
    public string id;
    public string password;
    public string userName;
    public Sprite image;

    [MenuItem("Window/Create User")]
    public static void ShowWindow ()
    {
        GetWindow<DataEditor>("User");
    }

    private void OnGUI ()
    {
        GUILayout.Space(10f);
        m_name = EditorGUILayout.TextField("Name :", m_name);
        GUILayout.Space(5f);
        id = EditorGUILayout.TextField("ID :", id);
        GUILayout.Space(5f);
        password = EditorGUILayout.TextField("Password :", password);
        GUILayout.Space(5f);
        userName = EditorGUILayout.TextField("User Name :", userName);
        GUILayout.Space(6f);

        
        EditorGUILayout.BeginHorizontal();
        EditorGUILayout.PrefixLabel("Photo :");
        image = (Sprite)EditorGUILayout.ObjectField(image, typeof(Sprite), false);
        EditorGUILayout.EndHorizontal();
        GUILayout.Space(10f);
        

        if (GUILayout.Button("Create User"))
        {
            if(!Directory.Exists("Assets/Users"))
                AssetDatabase.CreateFolder("Assets", "Users");

            Data data = ScriptableObject.CreateInstance<Data>();
            data.PersonName = m_name;
            data.password = password;
            data.sprite = image;
            data.userName = userName;
            data.id = id;

            string dataName = UnityEditor.AssetDatabase.GenerateUniqueAssetPath("Assets/Users/User.asset");
            AssetDatabase.CreateAsset(data, dataName);
            AssetDatabase.SaveAssets();
            EditorUtility.FocusProjectWindow();
            Selection.activeObject = data;

            m_name = "";
            password = "";
            image = null;
            userName = "";
            id = "";
        } 
    }
}
