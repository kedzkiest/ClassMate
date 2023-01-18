using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rotate_string : MonoBehaviour
{
   float theta = 0;
    // Start is called before the first frame update
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {
        theta += 1f;
        transform.eulerAngles = new Vector3(0, theta, 0);
    }
}