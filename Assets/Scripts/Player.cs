using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour 
{
    public float PlayerSpeed;
    public GameObject ProjectilePrefab;
	
	// Update is called once per frame
	void Update () 
    {
        float amtToMoveX = Input.GetAxisRaw("Horizontal") * PlayerSpeed * Time.deltaTime;
        float amtToMoveY = Input.GetAxisRaw("Vertical") * PlayerSpeed * Time.deltaTime;
        transform.Translate(Vector3.right * amtToMoveX);

        if (transform.position.y >= -3f)
        {

        }
        //if (transform.position.y <= 8 && transform.position.y >= -4)
        //{
        //    Vector3 ypos = Vector3.up * amtToMoveY;
        //    transform.Translate(ypos);
        //}
        //wrap
        if (transform.position.x <= -7.5f || transform.position.x >= 7.5f)
            transform.position = new Vector3(transform.position.x *-1, transform.position.y, transform.position.z);

        if (Input.GetKeyDown("space"))
        {
            //fire projectile
            Vector3 position = new Vector3(transform.position.x, transform.position.y + transform.localScale.y / 2, transform.position.z);
            Instantiate(ProjectilePrefab, position, Quaternion.identity);
        }

        //else if (transform.position.x >= 7.5f)
        //    transform.position = new Vector3(-7.4f, transform.position.y, transform.position.z);
	}

    
}
