using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public static float time;
    public GameObject retrypanel;

    // Start is called before the first frame update
    void Start()
    {
        time = 90;
    }

    // Update is called once per frame
    void Update()
    {
        if(time > 0)
        {
            time -= Time.deltaTime;
        }
        else
        {
            time = 0;
            retrypanel.SetActive(true);
        }

        Text uiText = GetComponent<Text>();
        uiText.text = "Time: "+ Mathf.FloorToInt(time) + "s";
    }
}
