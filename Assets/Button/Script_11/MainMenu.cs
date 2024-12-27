using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
    public void PlayGame() {
        SceneManager.LoadScene("SampleScene");
    }

    public void ExitGame() {
#if UNITY_EDITOR
        // Завершение игры в редакторе Unity
        UnityEditor.EditorApplication.isPlaying = false;
#else
        // Завершение игры в сборке
        Application.Quit();
#endif
        Debug.Log("Игра завершена");
    }
}