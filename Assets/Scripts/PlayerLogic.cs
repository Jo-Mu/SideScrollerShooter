using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLogic : MonoBehaviour
{
    public GameObject projectile;

    private const float playerSpeed = .75f;
    private const float maxPlayerY = 8.75f;
    private const float maxPlayerX = 19.0f;
    private const float projectileSpawnOffset = 2.0f;

    private bool leftButtonPressed = false;
    private bool rightButtonPressed = false;
    private bool upButtonPressed = false;
    private bool downButtonPressed = false;
    private bool shootingButtonPressedDown = false;

    void Start ()
    {
		
	}

    void FixedUpdate()
    {
        upButtonPressed = Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow);
        downButtonPressed = Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow);
        leftButtonPressed = Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow);
        rightButtonPressed = Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow);
        shootingButtonPressedDown = Input.GetKeyDown(KeyCode.Space);
    }

    void Update ()
    {
        PlayerMovement();
        OnKeySpawnProjectile();
	}

    void PlayerMovement()
    {
        if(upButtonPressed && transform.position.y <= maxPlayerY)
        {
            transform.Translate(0, playerSpeed, 0);
        }
        if (downButtonPressed && transform.position.y >= -maxPlayerY)
        {
            transform.Translate(0, -playerSpeed, 0);
        }
        if (leftButtonPressed && transform.position.x >= -maxPlayerX)
        {
            transform.Translate(-playerSpeed, 0, 0);
        }
        if (rightButtonPressed && transform.position.x <= maxPlayerX)
        {
            transform.Translate(playerSpeed, 0, 0);
        }
    }

    void OnKeySpawnProjectile()
    {
        if (shootingButtonPressedDown)
        {
            SpawnProjectile();
        }
    }

    void SpawnProjectile()
    {
        Instantiate(projectile, new Vector3(transform.position.x + projectileSpawnOffset, transform.position.y, 0), Quaternion.identity);
    }
}
