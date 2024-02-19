using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour
{
    public int PlayerHealth = 20;

    void Update()
    {
        if (PlayerHealth <= 0)
        {
            Died();
        }
    }

    public void TakeDamage(int damage)
    {
        PlayerHealth -= damage;

        GameObject CanvasChild = transform.GetChild(0).gameObject;
        GameObject HealthBarChild = CanvasChild.transform.GetChild(0).gameObject;
        HealthBarChild.GetComponent<PlayerHealthBar>().ChangeHealth(PlayerHealth);
    }

    private void Died()
    {
        SceneManager.LoadScene("GameOver");
    }
}
