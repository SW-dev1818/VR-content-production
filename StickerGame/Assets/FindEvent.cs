using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FindEvent : MonoBehaviour
{
    string stickerName;
    bool check = false;
    private Vector2 startPos;
    private Vector2 holePos;
    public Button reBtn;

    public void Restart()
    {
        SceneManager.LoadScene("SampleScene");
    }

    private void OnMouseDown()
    {
        startPos = this.transform.position;
        stickerName = this.gameObject.name;
    }

    private void OnMouseDrag()
    {
        Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector2(Mathf.Clamp(cursorPos.x, -7.7f, 7.7f)
            , Mathf.Clamp(cursorPos.y, -4f, 4f));
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(stickerName == collision.gameObject.tag)
        {
            check = true;
            holePos = collision.gameObject.transform.position;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        check = false;
    }

    private void OnMouseUp()
    {
        if(check)
        {
            this.transform.position = holePos;
            this.gameObject.GetComponent<PolygonCollider2D>().enabled = false;
        }
        else
        {
            this.transform.position = startPos;
        }
    }

   
}
