using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swing : MonoBehaviour
{
    public float speed = 5.0f;
    public float moveableRange = 4.0f;
    public float col = 1.0f;
    public float dir = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(dir * speed * Time.deltaTime, 0, 0);
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -moveableRange + col, moveableRange + col), transform.position.y, transform.position.z);
        if (transform.position.x == moveableRange + col) dir = -1.0f;
        if (transform.position.x == -moveableRange + col) dir = 1.0f;
    }
}
