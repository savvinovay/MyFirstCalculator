using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public int time = 10;

    public Image winI;
    public Image goI;
    public Text text;
    public Image audioController;

    void Start()
    {
        InvokeRepeating("Timer", 0, 1);
        audioController.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
  
    }

    public void Timer()
    {
        time--;
        if (time == 0)
        {
            winI.gameObject.SetActive(false);
            Time.timeScale = 1;
            goI.gameObject.SetActive(true);
        }
        else if (time == -10)
        {
            winI.gameObject.SetActive(true);
            Time.timeScale = 1;
            goI.gameObject.SetActive(false);
        }
        else if (time == -20)
        {
            winI.gameObject.SetActive(false);
            goI.gameObject.SetActive(false);
            text.gameObject.SetActive(true);
            Time.timeScale = 0;
            audioController.gameObject.SetActive(false);
        }
        else if (time == 9)
        {
            Time.timeScale = 1;
            audioController.gameObject.SetActive(true);
        }

    }
}
