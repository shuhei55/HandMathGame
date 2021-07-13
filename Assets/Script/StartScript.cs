using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScript : MonoBehaviour
{
    public void PushedButton() {
        SceneManager.LoadScene("Main");
    }
}
