using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

    private new Transform transform;
    private new Rigidbody rigidbody;
    private new AudioSource audio;
    void Awake()
    {
        transform = GetComponent<Transform>(); 
        rigidbody = GetComponent<Rigidbody>();
        audio = GetComponent<AudioSource>();
    }


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        
        
	}
}
