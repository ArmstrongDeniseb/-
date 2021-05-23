using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeSecretary : MonoBehaviour
{
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
        //简易的看板娘切换功能（只能切过去，不能切回来）
        Debug.Log("还在开发中！");
        SpriteRenderer srSecretary = GameObject.Find("secretary").GetComponent<SpriteRenderer>();
        Texture2D texture2d = (Texture2D)Resources.Load("立绘_阿米娅_skin1");
        Sprite sp = Sprite.Create(texture2d, srSecretary.sprite.textureRect, new Vector2(0.5f, 0.5f));
        srSecretary.sprite = sp;
    }
}
