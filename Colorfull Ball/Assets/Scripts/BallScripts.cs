using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class BallScripts : MonoBehaviour
{
    private Touch touch;
    [SerializeField]
    int speed;

    [SerializeField]
    Rigidbody rb;

    private void Update()
    {
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Moved)
            {
                rb.velocity = new Vector3(touch.deltaPosition.x * speed * Time.deltaTime,
                                          transform.position.y,
                                          touch.deltaPosition.y * speed * Time.deltaTime);
            }
        }
    }
}
