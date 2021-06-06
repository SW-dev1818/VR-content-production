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
        _3dText.text = "쉬는시간은 언제?";
        _tmp.text = "NO hangel";
    }

    void Update()
    {
        
    }
}
