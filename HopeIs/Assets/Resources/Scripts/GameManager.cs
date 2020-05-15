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
    public static GameManager Instance;

    // 現在の状態
    private GameState currentGameState;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
