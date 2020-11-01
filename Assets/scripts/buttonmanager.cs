using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class buttonmanager : MonoBehaviour
{

    public GameObject left;
    public GameObject right;
    public GameObject way1;
    public GameObject way2;
    public GameObject way3;
    public GameObject wayall;
    public GameObject hoge;
    public GameObject hogehoge;

    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Stage1()
    {
        SceneManager.LoadScene("Tutorial");
    }
    public void Back()
    {
        SceneManager.LoadScene("title");
    }

    public void Select()
    {
        SceneManager.LoadScene("select");
    }
    public void Stage2()
    {
        SceneManager.LoadScene("Tutorial2");
    }
    public void Stage3()
    {
        SceneManager.LoadScene("Stage1");
    }
    public void Stage4()
    {
        SceneManager.LoadScene("Stage2");
    }
    public void Stage5()
    {
        SceneManager.LoadScene("Stage3");
    }
    public void Stage6()
    {
        SceneManager.LoadScene("Stage4");
    }
    public void Stage7()
    {
        SceneManager.LoadScene("Stage5");
    }
    public void Stage8()
    {
        SceneManager.LoadScene("Stage6");
    }
    public void Stage9()
    {
        SceneManager.LoadScene("Stage7");
    }
    public void Stage10()
    {
        SceneManager.LoadScene("Stage8");
    }
    public void Stage11()
    {
        SceneManager.LoadScene("Stage9");
    }
    public void Stage12()
    {
        SceneManager.LoadScene("Stage10");
    }
    public void Go()
    {
        SceneManager.LoadScene("select2");
    }
    public void destroy()
	{
		Destroy(this.gameObject, 1.0f);
	}

    public void leftbutton()
    {
        left.gameObject.SetActive(false);
        right.gameObject.SetActive(true);
    }
    public void rightbutton()
    {
        left.gameObject.SetActive(true);
        right.gameObject.SetActive(false);
    }
    public void setumei1()
    {
        way1.gameObject.SetActive(true);
        way2.gameObject.SetActive(false);
        way3.gameObject.SetActive(false);
    }
    public void setumei2()
    {
        way1.gameObject.SetActive(false);
        way2.gameObject.SetActive(true);
        way3.gameObject.SetActive(false);
    }
    public void setumei3()
    {
        way1.gameObject.SetActive(false);
        way2.gameObject.SetActive(false);
        way3.gameObject.SetActive(true);

    }
    public void setumei4()
    {
        wayall.gameObject.SetActive(false);
        way1.gameObject.SetActive(false);
        way2.gameObject.SetActive(false);
        way3.gameObject.SetActive(false);
    }
    public void setumei0()
    {
        hoge.gameObject.SetActive(true);
    }
    public void settei()
    {
        hogehoge.gameObject.SetActive(true);
    }
    public void endless()
    {
        SceneManager.LoadScene("endless");
    }
}

