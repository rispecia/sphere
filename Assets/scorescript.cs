using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class scorescript : MonoBehaviour
{
    public Text scoreText; //Text用変数
    private int score = 0; //スコア計算用変数

    void Start()
    {
        score = 0;
        SetScore();   //初期スコアを代入して表示
    }

    //cube同士での衝突＋100 cube以外との衝突＋100
    void OnCollisionEnter(Collision collision)
    {
        string yourTag = collision.gameObject.tag;

        if (yourTag == "Sphere")
        {
            score += 150;
        }
        else
        {
            score += 100;
        }

        SetScore();
    }

    void SetScore()
    {
        scoreText.text = string.Format("Score:{0}", score);
    }
}
 