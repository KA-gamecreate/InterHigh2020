using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class fungus3 : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log(col.gameObject.name);

        if (!col.gameObject.CompareTag("Player") && !col.gameObject.CompareTag("ghost")) return;

        var messageReceived = GameObject.FindObjectsOfType<MessageReceived>();
        messageReceived[0]?.OnSendFungusMessage("test3");
        Destroy(this.gameObject, 1.0f);
    }
}