using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class playerHealth : MonoBehaviour {
    public float fullHealth;
    public GameObject deathFx;
    float currentHealth;
    playerController controlMovement;

    //Canvas variables
    public Slider healthSlider;
    public Image damageScreen;
  //  public AudioClip playerHurt;

    bool damaged= false;
  //  AudioSource playerAS;

    Color damageColor = new Color(0f, 0f, 0f, 0.5f);
    float smoothColor = 5f;
    // Use this for initialization
    void Start() {
        currentHealth = fullHealth;
        controlMovement = GetComponent<playerController>();
        //Inicializando
       healthSlider.maxValue = fullHealth;
        healthSlider.value = fullHealth;
        damaged= false;
     //   playerAS = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update() {
if (damaged){
            damageScreen.color = damageColor;
        }
        else {
            damageScreen.color = Color.Lerp(damageScreen.color, Color.clear, smoothColor * Time.deltaTime);
        }
        damaged= false;
    }
    public void addHealth (float healthAmount)
    {
        currentHealth += healthAmount;
        if (currentHealth > fullHealth){
            currentHealth = fullHealth;
        }
            healthSlider.value = currentHealth;
       }
    public void addDamage(float damage)
    {
        if (damage <= 0) return;
        currentHealth -= damage;

      //  playerAS.clip = playerHurt;
       // playerAS.Play();
          

        healthSlider.value = currentHealth;
        damaged= true;

        if (currentHealth <= 0)    {
            makeDead();
        }
    }
    public void makeDead(){
        Instantiate(deathFx, transform.position, transform.rotation);
        Destroy(gameObject);
        SceneManager.LoadScene("Lose Screen");
    }
    
}
