using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MObileHealthController : MonoBehaviour
{
    public float playerHealth;

    [SerializeField] private Text HealthText;

    private void Start()
    {
        UpdateHealth();
    }
    public void UpdateHealth()
    {
        HealthText.text = playerHealth.ToString("0");
    }

}
