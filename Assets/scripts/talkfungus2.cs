using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class talkfungus2 : MonoBehaviour
{
	public GameObject wayimage;
	public GameObject wayimage2;
	// Start is called before the first frame update
	void Start()
	{
		wayimage2.gameObject.SetActive(false);
	}

	// Update is called once per frame
	void Update()
	{
        if(wayimage.gameObject.activeSelf == false)
		{
			wayimage2.gameObject.SetActive(true);
		}
	}
	void OnTriggerEnter2D(Collider2D col)
	{
		Debug.Log(col.gameObject.name);

		if (!col.gameObject.CompareTag("Player") && !col.gameObject.CompareTag("ghost")) return;

		var messageReceived = GameObject.FindObjectsOfType<MessageReceived>();
		messageReceived?[1].OnSendFungusMessage("test2");
		wayimage2.gameObject.SetActive(false);
		Destroy(this.gameObject, 1.0f);
	}
}
