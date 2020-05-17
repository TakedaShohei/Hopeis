using UnityEngine;
using System.Collections;

public class Item : GameManager
{
    [SerializeField] GameObject item_ = null;
    // トリガーとの接触時に呼ばれるコールバック
    void OnTriggerEnter(Collider hit)
    {
        // 接触対象はPlayerタグですか？
        if (hit.CompareTag("Player"))
        {

            count_++;

            Debug.Log(count_);
            //Debug.Log();
            item_.SetActive(false);

        }
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
