using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaundsScripts : MonoBehaviour
{

    public Transform rightVector;
    public Transform leftVector;
    public Transform forwardVector;
    public Transform backVector;



    private void LateUpdate()
    {
        Vector3 viewPos = transform.position;
        viewPos.z = Mathf.Clamp(viewPos.z, backVector.position.z, forwardVector.position.z);
        viewPos.x = Mathf.Clamp(viewPos.x, leftVector.position.x, rightVector.position.x);
        transform.position = viewPos;


    }
}
