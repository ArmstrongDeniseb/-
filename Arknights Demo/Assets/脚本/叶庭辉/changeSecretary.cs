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
        //���׵Ŀ������л����ܣ�ֻ���й�ȥ�������л�����
        Debug.Log("���ڿ����У�");
        SpriteRenderer srSecretary = GameObject.Find("secretary").GetComponent<SpriteRenderer>();
        Texture2D texture2d = (Texture2D)Resources.Load("����_�����_skin1");
        Sprite sp = Sprite.Create(texture2d, srSecretary.sprite.textureRect, new Vector2(0.5f, 0.5f));
        srSecretary.sprite = sp;
    }
}
