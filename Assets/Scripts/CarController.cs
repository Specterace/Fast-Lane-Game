using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour {

    public float carSpeed;
    public float maxPos = 1.9f;
    public UIManager ui;
    public GameObject explosion;

    Vector3 position;

	// Use this for initialization
	void Start () {
        //ui = GetComponent<UIManager>();
        position = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        position.x += Input.GetAxis("Horizontal") * carSpeed * Time.deltaTime;
        position.x = Mathf.Clamp(position.x, -maxPos, maxPos);
        transform.position = position;
	}

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "EnemyCar")
        {
            Instantiate(explosion, transform.position, transform.rotation);
            Destroy(gameObject);
            ui.gameOverActivated();
        }

        else if (col.gameObject.tag == "Goal")
        {
            ui.gameWonActivated();
        }
    }
}
