using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Loading_string : MonoBehaviour
{
    public Text text;
    float alpha = 0;
    int flag = -1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Fadein(){
        flag = 1;
    }

    public void Fadeout(){
        flag = 0;
        alpha = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        if(flag == 1){
            alpha += 0.01f;
            text.color = new Color(text.color.r, text.color.g, text.color.b, alpha);
            if(alpha >= 1f){
                flag = -1;
            }
        }
        
        if(flag == 0){
            alpha -= 0.01f;
            text.color = new Color(text.color.r, text.color.g, text.color.b, alpha);
            if(alpha <= 0){
                flag = -1;
            }
        }
    }
}
