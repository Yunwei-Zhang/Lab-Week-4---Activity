using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    int count=3;
    public Renderer rend;
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

        if(gameObject.tag=="Red" && count==100){
            gameObject.SetActive(false);
        }
        if(gameObject.tag=="Blue"){
            if(count>=200 && count<=250)
            rend.enabled=false;
            else
            rend.enabled=true;
        }
    }
}
