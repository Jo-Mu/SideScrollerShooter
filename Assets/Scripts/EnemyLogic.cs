using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLogic : MonoBehaviour
{
    private const float enemySpeed = 1.2f;

	void Start ()
    {
		
	}
	
	void Update ()
    {
        MoveEnemyLeft();
	}

    void MoveEnemyLeft()
    {
        transform.Translate(-enemySpeed, 0, 0);
    }
}
