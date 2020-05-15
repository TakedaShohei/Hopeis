using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
public class MazeStick : MonoBehaviour
{
    public int max_z; //フィールドの縦幅。5以上の奇数にすること。
    public int max_x; //フィールドの横幅。5以上の奇数にすること。
    int z; //フィールド配列の縦の要素番号
    int x; //フィールド配列の横の要素番号
    int r; //乱数の値
    Object wall; //壁オブジェクト
    GameObject wallgo; //壁のゲームオブジェクト

    // Use this for initialization
    void Start()
    {
        int[,] field = new int[max_z, max_x]; //フィールド（0が通路で、1が壁。）
        wall = Resources.Load("Wall"); //壁オブジェクトを読み込む。

        //通路（0）の生成
        for (z = 0; z < max_z; z = z + 1) //フィールドの縦幅の分だけループする。
        {
            for (x = 0; x < max_x; x = x + 1) //フィールドの横幅の分だけループする。
            {
                field[z, x] = 0;
            }
        }
        //上下の外壁（1）の生成
        for (x = 0; x < max_x; x = x + 1) //フィールドの横幅の分だけループする。
        {
            field[0, x] = 1;
            field[max_z - 1, x] = 1;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
