using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goingUp : MonoBehaviour {

    public GameObject player;
    float timer = 0.0f;

    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        if (timer > 10 && timer < 11f)  // 위쪽
        {
            this.transform.RotateAround(player.transform.position, -player.transform.right, 45f * Time.deltaTime);
        }
        else if (timer > 14 && timer < 16)
        {
            this.transform.RotateAround(player.transform.position, player.transform.right, 22f * Time.deltaTime);
        }
        else if (timer > 20 && timer < 22)  // 왼쪽
        {
            this.transform.RotateAround(player.transform.position, -player.transform.up, 45f * Time.deltaTime);
        }
        else if (timer > 26 && timer < 29)
        {
            this.transform.RotateAround(player.transform.position, player.transform.up, 30f * Time.deltaTime);
        }
        else if (timer > 33 && timer < 35)  // 오른쪽
        {
            this.transform.RotateAround(player.transform.position, player.transform.up, 45f * Time.deltaTime);
        }
        else if (timer > 39 && timer < 42)
        {
            this.transform.RotateAround(player.transform.position, -player.transform.up, 30f * Time.deltaTime);
        }
        else if (timer > 42)
        {
            timer = 0.0f;
        }

    }
}
