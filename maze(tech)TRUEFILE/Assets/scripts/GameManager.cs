using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{      
    public bool IsLevelComplete()
        {
            Box[] boxes = FindObjectsOfType<Box>();
            foreach(var box in boxes)
            {
                if (!box.m_OnCross)
                {
                    return false;
                }

            }
            return true;
        }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        IsLevelComplete();
    }
}
