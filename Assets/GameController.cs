using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject goalObject;
    public TMPro.TextMeshProUGUI scoreLabel;

    void Update()
    {
        int count = GameObject.FindGameObjectsWithTag("Item").Length;
        scoreLabel.text = count.ToString();

        if (count == 0)
        {
            goalObject.SetActive(true);
        }
    }
}
