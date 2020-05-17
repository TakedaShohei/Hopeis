using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum GameState
{
    Start,
    Prepare,
    Playing,
    End
}


public class GameManager : MonoBehaviour
{
    public static GameManager instance_;
    PlayerManager player_manager_ = null;
    // 現在の状態
    private GameState currentGameState;
    public GameObject[] object_ =new GameObject[3];
    public GameObject[] object_count_ = GameObject.FindGameObjectsWithTag("item");
    public int count_=0;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void Setup()
    {
        if (count_ > 2)
        {

        }

    }


}
