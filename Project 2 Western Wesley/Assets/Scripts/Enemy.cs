using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

    public int hp = 100;

    public void DealDamage(int damage)
    {
        hp -= damage;
        print(hp);
    }
	
	// Update is called once per frame
	void Update () {
	    if(hp <= 0)
        {
            Destroy(gameObject);
        }
	}
}
