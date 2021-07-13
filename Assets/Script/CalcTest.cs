using UnityEngine.UI;
using UnityEngine;

public class CalcTest : MonoBehaviour
{
    public static int ansNum;
    public int QNum = 0;
    public Text QuizText;

    (string Script, int Ans)[] quizList = new (string Script, int Ans)[]
    {
        ("1 + 1", 2),
        ("3 - 1", 2),
        ("7 - 2", 5)
    };
    
    public void CheckAns() {
        if(quizList[QNum].Ans == ansNum) {
            QNum++;
            if(QNum == quizList.Length) {
                QNum = 0;
            }
        }
        this.SendMessage("ClearBuffer");
    }

    private void Update() {
        QuizText.text = quizList[QNum].Script;
    }
}
