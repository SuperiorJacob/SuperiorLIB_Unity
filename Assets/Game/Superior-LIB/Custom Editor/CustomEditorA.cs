using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This is 100% required.
[System.Serializable]
public struct Info
{
    public string name; // Inspector name.
    public int id;
    public Texture2D text;
}

public class CustomEditorA : MonoBehaviour
{
    [SerializeField] private Info[] infos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
