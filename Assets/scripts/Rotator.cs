using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {
    private float maxVal;
    private float minVal;
    private float distance;

    void Start()
    {
        distance = 1.5f;
        maxVal = transform.position.x + distance;
        minVal = transform.position.x - distance;
    }

    // Update is called once per frame
    void Update() {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
        transform.position = new Vector3(Mathf.PingPong(Time.time * 2, maxVal - minVal) + minVal,
                                                        transform.position.y,
                                                        transform.position.z);
	}
}
