using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectController : MonoBehaviour
{
    float speed;
    
    void Start()
    {
        speed = Random.Range(3.0f, 7.0f);
    }

    
    void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);
        if (transform.position.y < -6.0f) Destroy(this.gameObject);
    }
}
