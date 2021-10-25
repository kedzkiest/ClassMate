using UnityEngine;
using UnityEngine.UI;

public class BlackController : MonoBehaviour
{
    Image img;
    public int black;
    float alpha = 1f;
    
    // Start is called before the first frame update
    void Start()
    {
        img = GetComponent<Image>();
        img.color = Color.clear;
        black = 0;
    }

    public void All_black_ON(){
        black = 1;
        alpha = 0;
    }

    public void All_black_OFF(){
        black = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(black == 1){
            alpha += 0.01f;
            img.color = new Color(0, 0, 0, alpha);
            if(alpha >= 1f){
                black = -1;
            }
        }
        else if(black == 0){
            alpha -= 0.01f;
            img.color = new Color(0, 0, 0, alpha);
            if(alpha <= 0){
                black = -1;
            }
        }
        
    }
}
