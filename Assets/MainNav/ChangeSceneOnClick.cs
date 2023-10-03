using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneOnClick : MonoBehaviour
{
    public string targetSceneName;

    public void ChangeScene()
    {
        SceneManager.LoadScene(targetSceneName);
    }
}
