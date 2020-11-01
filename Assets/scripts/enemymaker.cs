using UnityEngine;
using System.Collections;
public class enemymaker : MonoBehaviour
{
	public GameObject[] Train;
    public GameObject playerObj;
    float timer;
    float instantiateInterval;

    void Start()
	{
        timer = 2;
        instantiateInterval = 5;

	}
    private void Update()
    {
        enemygenerate();
    }
    void enemygenerate()
    {
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            int number = Random.Range(0, Train.Length);
            Instantiate(Train[number], new Vector3(playerObj.transform.position.x + 36, 0, 0), transform.rotation);
            timer = 2;

        }
    }
}