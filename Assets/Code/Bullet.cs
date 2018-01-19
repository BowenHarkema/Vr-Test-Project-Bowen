using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour 
{
    [SerializeField]
    private float _ShootinSpeed;


	/// <summary>
    ///	Script entry point.
    /// </summary>
	private void Start () 
	{
        GetComponent<Rigidbody>().AddForce(Vector3.forward, ForceMode.Force);
	}
}
