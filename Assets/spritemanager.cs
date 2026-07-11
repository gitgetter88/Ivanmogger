using UnityEngine;
using UnityEngine.SceneManagement;
public class spritemanager : MonoBehaviour
{
    public Sprite def;
    public Sprite hover;
    public Sprite click;
    public SpriteRenderer spr2d;
    public bool mousedown;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spr2d.sprite = def;
        mousedown = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseOver(){
       if (mousedown == false){
        Debug.Log("mouse is over");
        spr2d.sprite = hover;}
    }
    void OnMouseDown(){
        spr2d.sprite = click;
        Debug.Log("clicked");
        mousedown = true;
        SceneManager.LoadScene("Play");
        Time.timeScale = 1;
        
    }
    void OnMouseExit(){
        if(mousedown == false){
        spr2d.sprite = def;}
    }
}
 