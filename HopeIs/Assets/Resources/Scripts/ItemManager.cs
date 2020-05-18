using UnityEngine;
using System.Collections;

public class ItemManager : MonoBehaviour
{ 
    [SerializeField] GameObject item_ = null;
    // トリガーとの接触時に呼ばれるコールバック
    GameManager game_manager_ = null;
    void OnTriggerEnter(Collider hit)
    {
        // 接触対象はPlayerタグですか？
        if (hit.CompareTag("Player"))
        {
            // object_count_ = GameObject.FindGameObjectsWithTag("item");
            // Debug.Log(object_count_.Length);
            game_manager_.AddItem(item_);
            Debug.Log(game_manager_.ItemCount);

            item_.SetActive(false);

        }
    }
    // Use this for initialization
    void Start()
    {
        game_manager_ = new GameManager();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
