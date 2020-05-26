using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class GoalManager:MonoBehaviour {
    [SerializeField] GameObject goal_go_ =null;
    [SerializeField] GameObject game_go_ = null;

    private GameManager game_manager_ = null;

    public string scene_name = null;
    AsyncOperation async_ = null;

    private bool wait_for_load_;

    private float timer_ = 0;
    private float timer_wait_ = 0;

    private void Start()
    {
        game_manager_ = game_go_.GetComponent<GameManager>();
        wait_for_load_ = false;
        timer_wait_ = 5.0f;
        goal_go_.SetActive(false);
    }

    void OnCollisionEnter(Collision hit_)
    {
        string your_tag_ = hit_.gameObject.tag;
        GameObject hit_object_ = hit_.gameObject;

        // 接触対象はPlayerタグですか？
        if (your_tag_ == "Player")
        {
            wait_for_load_ = true;
            async_ = SceneManager.LoadSceneAsync(scene_name);
            async_.allowSceneActivation = false;
        }
    }

    void Update()
    {

        if (wait_for_load_)
        {
            timer_ += Time.deltaTime;
            if (timer_ > timer_wait_ /* || async.progress >= 0.9f*/)
            {
                wait_for_load_ = false;
                async_.allowSceneActivation = true;
            }

        }
    }
}
