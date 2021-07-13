using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CalcTest : MonoBehaviour
{
    public static int ansNum;
    public int QNum = 0;
    public Text QuizText;
    public static float timer = 0f;
    public Text timerText;

    (string Script, int Ans)[] quizList = new (string Script, int Ans)[]
    {
        ("1 + 1", 2),
        ("3 - 1", 2),
        ("7 - 2", 5),
        ("3 x 2", 6),
        ("13 - 8", 5),
        ("24 ÷ 6", 4),
        ("141 ÷ 47", 3),
        ("√64", 8),
        ("sin(2Π)", 0),
        ("cos(Π/2)", 0),
        ("cosh(0)", 1),
        ("sinh(0)", 0)
    };
    
    public void CheckAns() {
        if(quizList[QNum].Ans == ansNum) {
            QNum++;
            if(QNum == quizList.Length) {
                QNum = 0;
                SceneManager.LoadScene("ClearScene");
            }
        }
        this.SendMessage("ClearBuffer");
    }

    private void Update() {
        QuizText.text = quizList[QNum].Script;
        timer += Time.deltaTime;
        timerText.text = timer.ToString("F1");
    }
}
