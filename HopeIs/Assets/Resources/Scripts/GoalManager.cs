using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GoalManager:MonoBehaviour {
    [SerializeField] GameObject goal_go_ =null;
    private void Start()
    {
        goal_go_.SetActive(false);
    }

}
