using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {

    public float ProjectileSpeed;
    private Transform _transform;
	// Use this for initialization
	void Start () {
        _transform = transform;
	}
	
	// Update is called once per frame
	void Update () {
        float amtToMove = ProjectileSpeed * Time.deltaTime;
        _transform.Translate(Vector3.up * amtToMove);
        if (_transform.position.y > 6.4f)
        {
            Destroy(this.gameObject);
        }
	}
}
