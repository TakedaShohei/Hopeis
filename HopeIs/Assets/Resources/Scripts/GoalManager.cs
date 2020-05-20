using UnityEngine;
using System.Collections;

public class GoalManager : MonoBehaviour
{
    
   
    [SerializeField]  GameObject goal_transform_ = null;
    public GameObject GoalTransform
    {
        get { return goal_transform_; }
        protected set { goal_transform_ = value; }
    }
    // Use this for initialization
    void Start()
    {
        goal_transform_.SetActive(false);
    }

    private void OnTriggerEnter(Collider hit)
    {
        if (hit.CompareTag("player")){

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
