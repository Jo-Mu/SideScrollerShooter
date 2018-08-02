using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileLogic : MonoBehaviour
{
    private const float projectileSpeed = 1.2f;

	void Start ()
    {
		
	}
	
	void Update ()
    {
        MoveProjectileRight();
	}

    void MoveProjectileRight()
    {
        transform.Translate(projectileSpeed, 0, 0);
    }
}
