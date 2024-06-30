using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButtonScript : MonoBehaviour
{
    public void SwitchScene(string SampleScene)
    {
        SceneManager.LoadScene(SampleScene);
    }
}