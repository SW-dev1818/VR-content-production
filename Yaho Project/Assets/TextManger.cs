using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextManger : MonoBehaviour
{
    public TextMesh _3dText;
    public TextMeshPro _tmp;
    
    void Start()
    {
        _3dText.text = "���½ð��� ����?";
        _tmp.text = "NO hangel";
    }

    void Update()
    {
        
    }
}
