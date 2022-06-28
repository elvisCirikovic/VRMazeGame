using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class interactWithNPC : MonoBehaviour
{
    public GameObject Ui;
    int count = 0;

    public void toggleUi()
    {
        if (count == 0)
        {
            Ui.SetActive(true);
            count++;
        }
        else
        {
            Ui.SetActive(false);
            count = 0;
        }
    }
}
