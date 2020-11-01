using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class endless_player : MonoBehaviour
{
	float speed = 5.0f;
	public bool gameover = false;
	public bool gameclear = false;
	bool down = false;
	bool enemy = false;
	public GameObject resultcanvas;
    public GameObject score_object = null; 
    public int score_num = 0;
    public Text highScoreText; //ハイスコアを表示するText
    private int highScore; //ハイスコア用変数
    private string key = "HIGH SCORE"; //ハイスコアの保存先キー
    public Text totalScoreText;
    public Text totalHighScoreText;
    public GameObject maincamera;






    // Start is called before the first frame update
    void Start()
	{
		resultcanvas.SetActive(false);
        score_num = 0;
        highScore = PlayerPrefs.GetInt(key, 0);
        PlayerPrefs.Save();
        highScoreText.text = "HighScore: " + highScore.ToString();
        //ハイスコアを表示
    }

    // Update is called once per frame
    void Update()
	{


		if (!gameover)
		{
				transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
            Text score_text = score_object.GetComponent<Text>();
         
            score_text.text = "Score:" + score_num;

            score_num += 1; 
            if (score_num > highScore)
            {

                highScore = score_num;
       

                PlayerPrefs.SetInt(key, highScore);
     

                highScoreText.text = "HighScore: " + highScore.ToString();
                Debug.Log("高いよ");
 
            }
        }


	}
	
	private IEnumerator TurnSurfaceArc(GameObject obj)
	{
		yield return new WaitForSeconds(1.0f);
		obj.GetComponent<PlatformEffector2D>().surfaceArc = 180;
	}






    public void Gameover()
    {
        gameover = true;
        resultcanvas.SetActive(true);
        Text score_text = score_object.GetComponent<Text>();
        totalScoreText.text = score_text.text = "Score:" + score_num;
        totalHighScoreText.text = highScoreText.text = "HighScore: " + highScore.ToString();
        maincamera.SetActive(false);
    }
}

