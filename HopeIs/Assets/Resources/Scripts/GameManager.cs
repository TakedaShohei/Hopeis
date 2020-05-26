using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class GameManager : MonoBehaviour
{
    public enum GameState
    {
        Start,
        Prepare,
        Playing,
        End
    }

    GameState current_state_;
    public GameState CurrentState
    {
        get { return current_state_; }
        set { current_state_ = value; }
    }

    [SerializeField] int item_count_;
    public int ItemCount
    {
        get { return item_count_; }
        set { item_count_ = value; }
    }
    [SerializeField] GameObject goal_go_=null;
    GoalManager goal_manager_ = null;
   

    
  

    List<GameObject> item_list_ = new List<GameObject>();
    

    public int count_=0;

    //public GameObject[] object_count_=null;
    public void AddItem(GameObject item_)
    {
        item_count_++;
        item_list_.Add(item_);
        int list_count_ = item_list_.Count();
        Debug.Log(list_count_);
        if (list_count_ >= 2)
        {
            ImplementGoal();
            
        }
        /* foreach(GameObject item_count_s in item_list_)
          {
              Debug.Log(item_count_s);

          }
          */



    }
    public void ImplementGoal()
    {
        
        current_state_ = GameState.End;
       
        goal_go_.gameObject.SetActive(true);
        
    }




    // Use this for initialization
    void Start()
    {
        Setup();
        
    }

    // Update is called once per frame
   public void Update()
    {
        
       
       

    }

     void Setup()
    {
        current_state_ = GameState.Start;
        goal_manager_ = goal_go_.GetComponent<GoalManager>();
       

    }

  
    


}
