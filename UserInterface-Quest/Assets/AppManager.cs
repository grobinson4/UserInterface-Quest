using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppManager : MonoBehaviour
{
    private GameObject messageText;

    private void Awake()
    {
        messageText = GameObject.Find("MessageText");
    }
    // Start is called before the first frame update
    void Start()
    {
        messageText.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
