using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ItemManager : MonoBehaviour
{


    [SerializeField] GameObject game_manager_go = null;
    // トリガーとの接触時に呼ばれるコールバック
    GameManager game_manager_ = null;

    void OnCollisionEnter(Collision hit_)
    {
        string your_tag_ = hit_.gameObject.tag;
        GameObject hit_object_ = hit_.gameObject;
        
        // 接触対象はPlayerタグですか？
        if (your_tag_ == "item")
        {
          
            game_manager_.AddItem(hit_object_);
            //game_manager_.ItemCount ++;
            hit_object_.gameObject.SetActive(false);
        }
    }
    // Use this for initialization
    void Start()
    {
        Setup();
    }

    void Setup()
    {
        game_manager_ =game_manager_go.GetComponent<GameManager>();
        Debug.Log(game_manager_);
        // game_manager_.Setup();
       
    }
    private void Update()
    {
        if (game_manager_ == null) return;
    }
}
/*
 
      	string[] input = Console.ReadLine().Split(' ');
	int a = int.Parse(input[0]);
	int b = int.Parse(input[1]);
      if((a*b)%2==0){
          Console.WriteLine("even");
      }else{
          Console.WriteLine("odd");
     
     
     */

