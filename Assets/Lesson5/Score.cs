using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    //スコア表示
    public Text scoreText;
    //スコア
    private int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        //得点を0にする
        score = 0;
        //オブジェクトを取得する
        GameObject obj = GameObject.Find("ScoreText");
        scoreText = obj.GetComponent<Text>();     
    }

    // 衝突時に呼ばれる関数
    void OnCollisionEnter(Collision collision)
    {
        string yourTag = collision.gameObject.tag;

　　　　　Debug.Log(score);

        //タグによって点数を変える
        if (yourTag == "SmallStarTag")
        {
            score += 10;
            Debug.Log(score);
        }
        else if (yourTag == "LargeStarTag")
        {
            score += 20;
        }
        else if (yourTag == "SmallCloudTag")
        {
            score += 30;
        }
        else if (yourTag == "LargeCloudTag")
        {
            score += 40;
        }
        //ScoreTextの文字をScore:Scoreの値にする
        scoreText.text = "score:" + score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
         
    }
}
