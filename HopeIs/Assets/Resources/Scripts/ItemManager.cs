using UnityEngine;
using System.Collections;

public class ItemManager : GameManager
{
    [SerializeField] GameObject item_ = null;
    public void GetItem()
    {
        count_++;
        
        Debug.Log(count_);
        //Debug.Log();
        item_.SetActive(false);

       
    }
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
