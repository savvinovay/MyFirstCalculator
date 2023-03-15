using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectControl : MonoBehaviour
{
    public Text objectText;

    void Start()
    {
        
    }

    // Update is called once per frame
    void OnMouseDown()
    {
        if(gameObject.name == objectText.name)
        {
            Destroy(gameObject);
            objectText.color = new Color(0,0,0,0);
        }
    }
}
