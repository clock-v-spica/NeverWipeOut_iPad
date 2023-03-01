using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate2 : MonoBehaviour
{
    public float deg = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Transform myTransform = gameObject.transform;
        Vector3 val = Input.acceleration;
        deg = Mathf.Rad2Deg * Mathf.Atan2(val.y, val.x) + 90.0f;
        Vector3 rot = Vector3.zero;
        rot.y = 0;
        rot.z = -deg;
        myTransform.eulerAngles = rot;
    }
}
