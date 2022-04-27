using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class SavesJson : MonoBehaviour
{
    private Save sv = new Save();
    private string path;
    void Start()
    {
        path = Path.Combine(Application.dataPath, "Save.json");

        if (File.Exists(path))
        {
            sv = JsonUtility.FromJson<Save>(File.ReadAllText(path));
            Debug.Log("Done " + sv.HP+ "  "+ sv.cord);
        }
        else
        {
            Debug.Log("Not Done ");
        }
    }


    private void OnApplicationQuit()
    {
        sv.cord = transform.position;
       File.WriteAllText(path, JsonUtility.ToJson(sv));
    }

    [Serializable]
    public class Save
    {
        public int HP=10;
        public Vector3 cord;
    }
}
