using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxisGet : MonoBehaviour
{
    public float range;
    public Text textOutput;
   
    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float xPos = h * range;

        transform.position = new Vector3(xPos, 2f, 0);
        textOutput.text = "Value Returned;" + h.ToString("F2");
    }
}
