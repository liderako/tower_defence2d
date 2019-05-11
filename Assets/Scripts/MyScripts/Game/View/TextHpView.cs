using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextHpView : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        GameObject.Find("TextHp").gameObject.GetComponent<Text>().text = gameManager.gm.playerHp.ToString();
    }
}