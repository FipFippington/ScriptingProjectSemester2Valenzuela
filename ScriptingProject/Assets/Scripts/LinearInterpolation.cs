using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinearInterpolation : MonoBehaviour
{/*
    *  Math.Lerp takes two numbers and finds the number that is a precentage away
    *  for example in this line 50% of the way between 3 and 5 is 4
    *  In this case, result = 4 
    float result = Mathf.Lerp(3f,5f, 0.5f);
    *  These lines set up multiple three instaances of linear interpolation
    *  this alows you to calculate multiple diffrent things at the same time
    *  This could be usef for thinggs like calculating x,y,z cordinate/
    Vector3 from = new Vector3(1f, 2f, 3f);
    Vector3 to = new Vector3(5f, 6f, 7f);
    // This line is what calculates the paramaters set up in the previous ones
    // Here result = (4,5,6)/
    Vector3 result = new Vector3.Lerp(from, to, .75f);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // This line runs every frame
        light.intensity = Mathf.Lerp(light.intensity, 8f, .5f);
        // but if you add Time.deltaTime it runs every second
        light.intensity = Mathf.Lerp(light.intensity, 8f, .5f * Time.deltaTime);
    }*/
}
