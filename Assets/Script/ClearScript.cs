using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ClearScript : MonoBehaviour
{
    public Text timerText;
    
    void Start() {
        timerText.text = CalcTest.timer.ToString("f1") + "秒";
    }

    public void pushedButton() {
        SceneManager.LoadScene("StartScene");
    }

}
