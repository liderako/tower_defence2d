using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    public void actionOnClick()
    {
        SceneManager.LoadScene("Level0", LoadSceneMode.Single);
    }
}
