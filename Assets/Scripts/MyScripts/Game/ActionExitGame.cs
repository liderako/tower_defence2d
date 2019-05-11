using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ActionExitGame : MonoBehaviour
{
    public int count;

    private void Update()
    {
        if (count == 2)
        {
            SceneManager.LoadScene("Menu", LoadSceneMode.Single);
        }
    }

    public void onClickAction()
    {
        GameObject.Find("TextResume").gameObject.GetComponent<Text>().text = "Resume play";
        GameObject.Find("TextExit").gameObject.GetComponent<Text>().text = "Are you sure?";
        count += 1;
    }
}