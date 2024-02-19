using System.Collections;
using System.Collections.Generic;
using Unity.XR.CoreUtils;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthBar : MonoBehaviour
{
    private float MaxHealthBarLength = 1.0f;
    private float MaxPlayerHealth;
    private float CurrentPlayerHealth;
    private float HealthPercentage;
    private float CurrentHealthBarLength;

    private RectTransform rt;

    // Start is called before the first frame update
    void Start()
    {
        rt = GetComponent<RectTransform>();
        MaxPlayerHealth = transform.parent.parent.GetComponent<PlayerStats>().PlayerHealth;
        GetComponent<Image>().color = Color.green;
    }

    public void ChangeHealth(float PlayerHealth)
    {
        CurrentPlayerHealth = PlayerHealth;
        HealthPercentage = CurrentPlayerHealth / MaxPlayerHealth;
        CurrentHealthBarLength = MaxHealthBarLength * HealthPercentage;
        rt.sizeDelta = new Vector2(CurrentHealthBarLength, rt.sizeDelta.y);
        ImageHealthColor();
    }

    private void ImageHealthColor()
    {
        if (CurrentPlayerHealth > 15)
        {
            GetComponent<Image>().color = Color.green;
        }
        else if (CurrentPlayerHealth > 10)
        {
            GetComponent<Image>().color = Color.yellow;
        }
        else
        {
            GetComponent<Image>().color = Color.red;
        }
    }
}
