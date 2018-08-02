using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemyAndProjectile : MonoBehaviour
{
    public GameObject whiteExplosion;
    public GameObject greenExplosion;

    private ScoreLogic score;

	void Start () {
		
	}
	
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Collision")
        {
            score = GameObject.FindGameObjectWithTag("GUI").GetComponent<ScoreLogic>();
            score.AddToScore();
            Instantiate(whiteExplosion, new Vector3(collision.transform.position.x, collision.transform.position.y, 0), Quaternion.identity);
            Instantiate(greenExplosion, new Vector3(collision.transform.position.x, collision.transform.position.y, 0), Quaternion.identity);
            Destroy(collision.gameObject);
        }
        else if(collision.gameObject.tag == "Projectile")
        {
            Destroy(collision.gameObject);
        }
    }
}
