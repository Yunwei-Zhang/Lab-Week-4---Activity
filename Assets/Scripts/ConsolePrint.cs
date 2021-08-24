using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConsolePrint : MonoBehaviour
{
    int count=3;
    // Start is called before the first frame update
    void Start()
    {
        count=3;
    }

    // Update is called once per frame
    void Update()
    {
        count++;
        Debug.Log(gameObject.name + ":" +count);
    }
}
