using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleSceneManager : MonoBehaviour
{
    public void OnClickStartButton()
    {
        SceneManager.LoadScene("GameScene");
    }
}
