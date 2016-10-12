using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class PlayerScript : MonoBehaviour {

    private int speed = 15;

    private Vector3 dir;

    [SerializeField]
    private GameObject ps;

    private bool isDead;

    [SerializeField]
    private GameObject resetBtn;


	// Use this for initialization
	void Start ()
    {
        isDead = false;
        dir = Vector3.zero;
	}
	
	// Update is called once per frame
	void Update ()
    {
	if (Input.GetMouseButtonDown(0) && !isDead)
        {
            ScoreScript.score++;

            if (dir == Vector3.forward)
            {
                dir = Vector3.left;
            }
            else
            {
                dir = Vector3.forward;
            }
        }

        float amountToMove = speed * Time.deltaTime;

        transform.Translate(dir * amountToMove);
	}

    void OnTriggerEnter (Collider other)
    {
        if(other.tag == "Pickup")
        {
            other.gameObject.SetActive(false);
            Instantiate(ps, transform.position, Quaternion.identity);
            ScoreScript.score += 3;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Tile")
        {
            RaycastHit hit;

            Ray downRay = new Ray(transform.position, -Vector3.up);

            if (!Physics.Raycast(downRay, out hit))
            {
                //Kill player!
                isDead = true;
                resetBtn.SetActive(true);
                if(transform.childCount > 0)
                {
                    transform.GetChild(0).transform.parent = null;
                }
                
            }

        }
    }
}
