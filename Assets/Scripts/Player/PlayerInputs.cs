using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerInputs : MonoBehaviour
{
    [SerializeField] private Rigidbody2D myRigidbody;
    [SerializeField] private Animator myAnimator;
    [SerializeField] private GameObject laserAmmo;
    [SerializeField] private GameObject bulletSpawnMiddle;
    [SerializeField] private GameObject bulletSpawnLeft;
    [SerializeField] private GameObject bulletSpawnRight;
    [SerializeField] private List<GameObject> spawnPoints;
    [SerializeField] private AudioSource soundEffects;
    [SerializeField] private AudioSource soundLasers;
    [SerializeField] private AudioSource soundPower;
    [SerializeField] private AudioClip wallImpactSound;
    [SerializeField] private AudioClip powerOff;
    [SerializeField] private AudioClip warningBeep;
    [SerializeField] private ProjectileSO laserSound;
    [SerializeField] private LaserPool laser;
    [SerializeField] private TextMeshProUGUI powerShotTime;

    private float currentHealth;
    private Vector3 myTransform;
    private float shipXPos;
    private float shipYPos;
    private float newXPos;
    private float newYPos;
    private float shootTimer;
    private float powerTimer;

    public float GetHealth => currentHealth;

    void Start()
    {
        currentHealth = 5;
        shootTimer = 0.3f;
        powerTimer = 5;
        myTransform = transform.position;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Confined;
    }

    void Update()
    {
        shootTimer += Time.deltaTime;
        powerTimer -= Time.deltaTime;

        if (Mathf.Floor(powerTimer) <= 0)
        {
            powerTimer = 0;
        }


        if (powerTimer == 0)
        {
            powerShotTime.text = "RDY";
        }
        else
        {
            powerShotTime.text = Mathf.Floor(powerTimer).ToString();
        }

        shipXPos = Input.mousePosition.x;
        shipYPos = Input.mousePosition.y;

        ChangeAnimations();

        KeepPlayerInBounds();

        ChangeWeapons();

        if (Input.GetMouseButton(0) && shootTimer >= 0.3f)
        {
            var newLaser = laser.GetLaserProjectile();
            if (newLaser != null)
            {
                newLaser.transform.position = bulletSpawnMiddle.transform.position;
            }

            for (int i = 0; i < laser.GetLaserProjectiles.Count; i++)
            {
                newLaser.SetActive(true);
            }
            soundLasers.PlayOneShot(laserSound.GetFireSound);
            shootTimer = 0;
        }
        if (Input.GetMouseButtonDown(1) && powerTimer <= 0)
        {
            GameObject[] newLaser = new GameObject[3];

            for (int i = 0; i < spawnPoints.Count; i++)
            {
                newLaser[i] = laser.GetLaserProjectile();

                if (newLaser[i] != null)
                {
                    newLaser[i].transform.position = spawnPoints[i].transform.position;
                }

                for (int j = 0; j < laser.GetLaserProjectiles.Count; j++)
                {
                    newLaser[i].SetActive(true);
                }
            }
            soundLasers.PlayOneShot(laserSound.GetFireSound);
            powerTimer = 5;
        }

        myRigidbody.position = Camera.main.ScreenToWorldPoint(new Vector3(newXPos, newYPos, -Camera.main.transform.position.z));

        if (currentHealth <= 0)
        {
            if (!soundPower.isPlaying)
            {
                soundPower.PlayOneShot(powerOff);
            }
      
            currentHealth = 5;
            Debug.Log("Game Over");
        }
    }

    private void KeepPlayerInBounds()
    {
        if (shipXPos <= (Screen.width - Screen.width) + 50)
        {
            newXPos = 50;
        }
        else if (shipXPos >= (Screen.width - 50))
        {
            newXPos = Screen.width - 50;
        }
        else
        {
            newXPos = Input.mousePosition.x;
        }
        if (shipYPos <= (Screen.height - Screen.height) + 120)
        {
            newYPos = 120;
        }
        else if (shipYPos >= (Screen.height - 400))
        {
            newYPos = Screen.height - 400;
        }
        else
        {
            newYPos = Input.mousePosition.y;
        }
    }

    private void ChangeAnimations()
    {
        if (Input.GetAxis("Mouse X") <= -0.1)
        {
            myAnimator.SetLayerWeight(1, 1);
            myAnimator.SetLayerWeight(2, 0);
        }

        if (Input.GetAxis("Mouse X") >= 0.1)
        {
            myAnimator.SetLayerWeight(1, 0);
            myAnimator.SetLayerWeight(2, 1);
        }

        if (Input.GetAxis("Mouse X") == 0)
        {
            myAnimator.SetLayerWeight(0, 1);
            myAnimator.SetLayerWeight(1, 0);
            myAnimator.SetLayerWeight(2, 0);
        }
    }

    public void ChangeWeapons()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 8)
        {
            currentHealth -= 1;
            collision.gameObject.SetActive(false);
        }
    }


    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "LeftWall")
        {
            if (!soundEffects.isPlaying)
            {
                soundEffects.PlayOneShot(wallImpactSound);
            }
        }

        if (collision.gameObject.tag == "RightWall")
        {
            if (!soundEffects.isPlaying)
            {
                soundEffects.PlayOneShot(wallImpactSound);
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "LeftWall")
        {
            currentHealth -= 1;

                soundEffects.PlayOneShot(warningBeep);
                soundEffects.PlayOneShot(wallImpactSound);

        }

        if (collision.gameObject.tag == "RightWall")
        {
            currentHealth -= 1;

                soundEffects.PlayOneShot(warningBeep);
                soundEffects.PlayOneShot(wallImpactSound);

        }
    }
}
