using System.Security.Cryptography;
using UnityEngine.SceneManagement;

using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] private float maxHealth;

    private float currentHealth;
    public HealthBar healthBar;
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetSliderMax(maxHealth);
    }

    public void TakeDamage(float amount)
    {
        currentHealth -= amount;
        healthBar.SetSlider(currentHealth);

        if(currentHealth <= 0)
        {
            SceneManager.LoadScene("ReloadGame"); //restart the level
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            TakeDamage(10f);
        }
    }
}
