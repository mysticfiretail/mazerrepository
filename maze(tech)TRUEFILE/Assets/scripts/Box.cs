using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Box : MonoBehaviour
{
    public bool m_OnCross;
    void TestForOnCross()
    {
        GameObject[] crosses = GameObject.FindGameObjectsWithTag("Cross");
        foreach(var cross in crosses)
        {
            if (transform.position.x==cross.transform.position.x &&transform.position.y == cross.transform.position.y)
            {
                //GetComponent < SpriteRenderer().color = Color.red;
                m_OnCross = true;
                return;
            }
        }
        //GetComponent < SpriteRenderer().color = Color.white;
        m_OnCross = false;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TestForOnCross();
    }
}
