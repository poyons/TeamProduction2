using UnityEngine;
using UnityEngine.SceneManagement;

public class GamePlay : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("Game1");
        Debug.Log("GameStart");
    }
}
