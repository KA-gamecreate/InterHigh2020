using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stagecreate : MonoBehaviour
{

	//[SerializeField]
	public GameObject enemyObj;
	// プレイヤーオブジェクトの入れ物
	public GameObject playerObj;
	// 敵を生成するまでの時間
	float timer;
	// 敵を生成するまでの閾値
	float instantiateInterval;
	// 敵の最大生成数
	//int maxInstanceValue;
	void Start()
	{
		timer = 2;
		instantiateInterval = 5;
		//maxInstanceValue = 5;
		// プレイヤーオブジェクトを取得

	}
	void Update()
	{
		GenerateEnemy();
	}

	void GenerateEnemy()
	{
		// カウンタ
		timer -= Time.deltaTime;
		if (timer < 0)
		{

				Instantiate(enemyObj, new Vector3(playerObj.transform.position.x +36, 0, 0), transform.rotation) ;


				timer = 2;

		}
	}
}