using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class camera_mausebottonright : MonoBehaviour
{
    public GameObject Camera1;

    public GameObject Camera2;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            Camera1.SetActive(false);
            Camera2.SetActive(true);
        }
        if (Input.GetKeyUp(KeyCode.Mouse1))
        {
            Camera1.SetActive(true);
            Camera2.SetActive(false);
        }

    }
}