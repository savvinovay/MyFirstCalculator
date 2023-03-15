using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayExit : MonoBehaviour
{
    public void first()
    {
        SceneManager.LoadScene(1);
    }
    public void ExitPressed()
    {
        Application.Quit();
    }
    public void second()
    {
        SceneManager.LoadScene(2);
    }
    public void third()
    {
        SceneManager.LoadScene(3);
    }
    public void fourth()
    {
        SceneManager.LoadScene(4);
    }
    public void fifth()
    {
        SceneManager.LoadScene(5);
    }
    public void BackPressed()
    {
        SceneManager.LoadScene(0);
    }
    [SerializeField]
    GameObject objectToDestroy;
    public void WoodPressed()
    {
        Destroy (objectToDestroy);
    }
}
