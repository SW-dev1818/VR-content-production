using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetMove : MonoBehaviour
{
    bool is_up = true;
    public float targetSpeed;

    void Start()
    {
        targetSpeed = 3.0f;
    }

    void Update()
    {
            if (is_up) transform.Translate(Vector3.up * targetSpeed * Time.deltaTime);
            else transform.Translate(Vector3.down * targetSpeed * Time.deltaTime);

            if (transform.position.y > 3) is_up = false;
            if (transform.position.y < -3) is_up = true;
        }
    }

