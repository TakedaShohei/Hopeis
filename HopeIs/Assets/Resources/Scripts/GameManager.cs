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

    [SerializeField] private int item_count_;
    public int ItemCount
    {
        get { return item_count_; }
        set { item_count_ = value; }
    }

    GoalManager goal_manager_ = null;
    public GoalManager GoalManager
    {
        get { return goal_manager_; }
        set { goal_manager_ = value; }
    }


    List<GameObject> item_list_ = new List<GameObject>();

    public int count_=0;

    //public GameObject[] object_count_=null;
    





    // Use this for initialization
    void Start()
    {
        
        Setup();

    }

    // Update is called once per frame
    void Update()
    {
        
        
       //  goal_manager_.GoalTransform.SetActive(true);
        
    }

    public void Setup()
    {
        current_state_ = GameState.Start;
        
        
       
    }

    public void AddItem(GameObject item_)
    {
        item_count_ = item_list_.Count();
        item_list_.Add(item_);
        
        foreach(GameObject item_count_s in item_list_)
        {
            Debug.Log(item_count_s);
            
        }
        Debug.Log(item_count_);



    }
    


}
