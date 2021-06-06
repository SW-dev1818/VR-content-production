using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickEvent : MonoBehaviour
{
    private SpriteRenderer m_SpriteRenderer;
    private Sprite circle;
    string objectName;

    void Start()
    {
        m_SpriteRenderer = GetComponent<SpriteRenderer>();
        circle = Resources.Load<Sprite>("circle");
    }

    private void OnMouseDown()
    {
        objectName = this.gameObject.name + "-1";
        m_SpriteRenderer.sprite = circle;

        GameObject.Find("Hide").transform.Find(objectName).gameObject.SetActive(true);
    }
}
