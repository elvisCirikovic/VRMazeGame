using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hide : MonoBehaviour
{
    public GameObject hide_ui;
    // Start is called before the first frame update
    void Start()
    {
        hide_ui.SetActive(false);
    }
}
