using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapRotation : MonoBehaviour
{
    private float speed = 10f;
    //Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        //var rot = transform.rotation;
        //transform.Rotate(rot.x, rot.y + a, rot.z);

        transform.Rotate(Vector3.up * speed * Time.deltaTime);
    }
}
