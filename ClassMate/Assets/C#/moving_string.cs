using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class moving_string : MonoBehaviour
{
   float theta = 0;
   public float gap = 0;
    // Start is called before the first frame update
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {
        Transform mytransform = this.transform;
        Vector3 worldPos = mytransform.position;
        theta += 0.1f;
        worldPos.y += Mathf.Sin(theta + gap);
        mytransform.position = worldPos;


    }
}
