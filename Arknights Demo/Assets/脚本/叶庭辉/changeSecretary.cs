using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeSecretary : MonoBehaviour
{
    bool b = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        Debug.Log("看板娘切换v1.0水的一批版（作者：憨包小叶）");
        if (b) 
        {
            for (int i = 0; i < 15; i++)
            {
                SpriteRenderer srSecretary = GameObject.Find("secretary").GetComponent<SpriteRenderer>();
                Texture2D texture2d = (Texture2D)Resources.Load("立绘_阿米娅_skin1");
                Sprite sp = Sprite.Create(texture2d, srSecretary.sprite.textureRect, new Vector2(0.5f, 0.5f));
                srSecretary.sprite = sp;
            }
            b = false;
        }
        else
        {
            for (int i = 0; i < 15; i++)
            {
                SpriteRenderer srSecretary = GameObject.Find("secretary").GetComponent<SpriteRenderer>();
                Texture2D texture2d = (Texture2D)Resources.Load("立绘_阿米娅_1");
                Sprite sp = Sprite.Create(texture2d, srSecretary.sprite.textureRect, new Vector2(0.5f, 0.5f));
                srSecretary.sprite = sp;
            }
            b = true;
        }
        
    }
}
