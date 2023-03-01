using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject obj;
    public float interval = 20.0f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObj", 0.1f, interval);
    }

    // Update is called once per frame
    void Update()
    {
        if(Timer.time < 10)
        {
            CancelInvoke();
        }
    }

    void SpawnObj()
    {
        Instantiate(obj, transform.position, transform.rotation);
    }
}
