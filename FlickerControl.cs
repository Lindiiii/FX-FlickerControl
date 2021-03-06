using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlickerControl : MonoBehaviour
{
    public bool isFlickering = false;
    public float timeDelay;
    //public Renderer rend;

    void Update()
    {
        if (isFlickering == false)
        {
            StartCoroutine(FlickeringLight());//minTime, maxTime
        }
    }

    IEnumerator FlickeringLight() //float minWaitTime, float maxWaitTime
    {
        for (; ; )
        {
            //rend.enabled = false;
            GetComponent<MeshRenderer>().enabled = false; //on
            yield return new WaitForSeconds(0.4f);
            GetComponent<MeshRenderer>().enabled = true; //off
            yield return new WaitForSeconds(3.0f);
        }


    }
}
