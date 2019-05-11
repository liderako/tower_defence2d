using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActionPause : MonoBehaviour
{
    public GameObject _backgroundPanel;

    public GameObject _resume;
    
    public GameObject _exit;
        
    // Start is called before the first frame update
    void Start()
    {
        _backgroundPanel.SetActive(false);
        _resume.SetActive(false);
        _exit.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            gameManager.gm.pause(true);
            _backgroundPanel.SetActive(true);
            _resume.SetActive(true);
            _exit.SetActive(true);
            GameObject.Find("TextResume").gameObject.GetComponent<Text>().text = "Resume";
            GameObject.Find("TextExit").gameObject.GetComponent<Text>().text = "Exit";
        }
    }
}
