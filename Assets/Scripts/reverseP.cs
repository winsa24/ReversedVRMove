using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class reverseP : MonoBehaviour
{
    public GameObject camera;
    public GameObject tracking;

    public Vector3 offset;

    public TextMeshPro position;
    public TextMeshPro rotation;

    // Start is called before the first frame update
    void Start()
    {
        //camera.transform.position = new Vector3(0, 1, 0);
        camera.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        position.text = "camera: " + camera.transform.position.ToString();
        rotation.text = "tracking: " + tracking.transform.position.ToString();

        //transform.position = Vector3.Lerp(transform.position, target.transform.position + offset, Time.deltaTime);
        //transform.position = target.transform.position * -1f;
        //transform.position = transform.InverseTransformPoint(target.transform.position);
        //transform.rotation = Quaternion.Inverse(target.transform.rotation);
        //transform.position = tracking.transform.position;
        //transform.Translate(Vector3.left * Time.deltaTime);
        transform.position = tracking.transform.position * -1;
    }
}
