using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public float jumpDistance = 0.32f;
    private bool jumped;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float horizontalMovement = Input.GetAxis("Horizontal");
        float verticalMovement = Input.GetAxis("Vertical");

        if (!jumped)
        {
            if (horizontalMovement != 0)
            {
                transform.position = new Vector2(
                    transform.position.x + (horizontalMovement > 0 ? jumpDistance : -jumpDistance),
                    transform.position.y
                );
                jumped = true;
            }

            if (verticalMovement != 0)
            {
                transform.position = new Vector2(
                    transform.position.x,
                    transform.position.y + (verticalMovement > 0 ? jumpDistance : -jumpDistance)
                );
                jumped = true;
            }
        } else
        {
            if (horizontalMovement == 0 && verticalMovement == 0)
            {
                jumped = false;
            }
        }
	}
}
