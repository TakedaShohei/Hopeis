using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ItemManager : MonoBehaviour
{ 
   
    private int count_ = 0;
    
    // トリガーとの接触時に呼ばれるコールバック
    GameManager game_manager_ = null;
    void OnCollisionEnter(Collision hit_)
    {
        string your_tag_ = hit_.gameObject.tag;
        GameObject hit_object_ = hit_.gameObject;
        int count_ = 1;
        // 接触対象はPlayerタグですか？
        if (your_tag_ == "item")
        {
            // object_count_ = GameObject.FindGameObjectsWithTag("item");
            // Debug.Log(object_count_.Length);
            game_manager_.AddItem(hit_object_);

           // game_manager_.ItemCount += count_;
            //Debug.Log(game_manager_.ItemCount);
            hit_object_.gameObject.SetActive(false);
        }
    }
    // Use this for initialization
    void Start()
    {
        Setup();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void Setup()
    {
        game_manager_ = new GameManager();
       // game_manager_.Setup();
    }
}
