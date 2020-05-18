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
        protected set { item_count_ = value; }
    }

    List<GameObject> item_list_ = new List<GameObject>();

    
   
    //public GameObject[] object_count_=null;
    [SerializeField] GameObject goal_transform_ = null;
    

    


    // Use this for initialization
    void Start()
    {
       
       

    }

    // Update is called once per frame
    void Update()
    {
        
        
            goal_transform_.SetActive(true);
        
    }

    void Setup()
    {
        current_state_ = GameState.Start;
        item_count_ = item_list_.Count();
        goal_transform_.SetActive(false);
       
    }

    public void AddItem(GameObject item_)
    {

    }


}
