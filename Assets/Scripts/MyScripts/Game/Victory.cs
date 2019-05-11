using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Victory : MonoBehaviour
{
    public string _nextLevel;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        GameObject go = GameObject.Find("TextResultGameV");
        go.gameObject.GetComponent<Text>().text = "VICTORY";
        
        go = GameObject.Find("TextGradeV");
        go.gameObject.GetComponent<Text>().text = "Grade : " + scopeLogic._sp.getStatus();
        
        go = GameObject.Find("TextScopeV");
        go.gameObject.GetComponent<Text>().text = "Scope : " + gameManager.gm.score;
    }

    public void onClickNextLevel()
    {
        SceneManager.LoadScene(_nextLevel, LoadSceneMode.Single);
    }
}
