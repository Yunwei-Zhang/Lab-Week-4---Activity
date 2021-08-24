using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    int count=3;
    int a;
    public Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        count=3;
        a=Random.Range(200,251);
    }

    // Update is called once per frame
    void Update()
    {
        count++;
        Debug.Log(gameObject.name + ":" +count);

        if(gameObject.tag=="Red" && count==100){
            gameObject.SetActive(false);
        }
        if(gameObject.tag=="Blue" && count==a){
            rend.enabled=false;
        }
    }
}
