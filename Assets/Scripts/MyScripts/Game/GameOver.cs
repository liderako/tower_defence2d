using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public string _currentScene;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        GameObject go = GameObject.Find("TextResultGame");
        go.gameObject.GetComponent<Text>().text = "Game Over";
        
        go = GameObject.Find("TextGrade");
        go.gameObject.GetComponent<Text>().text = "Grade : " + scopeLogic._sp.getStatus();
        
        go = GameObject.Find("TextScope");
        go.gameObject.GetComponent<Text>().text = "Scope : " + gameManager.gm.score;
    }

    public void onClickRetry()
    {
        SceneManager.LoadScene(_currentScene, LoadSceneMode.Single);
    }
}
