using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollMove : MonoBehaviour
{
    public float scrollSpeed;
    
    private float targetOffset;
    private Renderer render;

    void Start()
    {
        render = GetComponent<Renderer>();
    }

    void Update()
    {
        targetOffset += Time.deltaTime * scrollSpeed;
        render.material.mainTextureOffset = new Vector2(targetOffset, 0);
    }
}
