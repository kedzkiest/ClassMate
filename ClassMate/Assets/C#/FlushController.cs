using UnityEngine;
using UnityEngine.UI;

public class FlushController : MonoBehaviour
{
    Image img;
    public int flush;
    float alpha = 1f;
    
    // Start is called before the first frame update
    void Start()
    {
        img = GetComponent<Image>();
        img.color = Color.clear;
        flush = 0;
    }

    public void FlushOn(){
        flush = 1;
        alpha = 0;
    }

    public void FlushOff(){
        flush = 0;
    }

    public void All_white_ON(){
        flush = 2;
        alpha = 0;
    }

    public void All_white_OFF(){
        flush = 3;
        alpha = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        if(flush == 1){
            alpha += 0.01f;
            img.color = new Color(1f, 1f, 1f, Mathf.Sin(4 * alpha) / 2 + 0.5f);
        }
        else if(flush == 0){
            img.color = Color.clear;
        }
        else if(flush == 2){
            alpha += 0.01f;
            img.color = new Color(1f, 1f, 1f, alpha);
            if(alpha >= 1f){
                flush = -1;
            }
        }
        else if(flush == 3){
            alpha -= 0.01f;
            img.color = new Color(1f, 1f, 1f, alpha);
            if(alpha <= 0){
                flush = -1;
            }
        }
    }
}
