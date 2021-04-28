using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    Renderer rend;
    public float speed = 2f;
    int collisions = 0;
    int colorPicker = 0;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        transform.position = Vector3.zero;
        transform.rotation = Quaternion.Euler(0, 90, 0);

        GameObject leftWall = GameObject.CreatePrimitive(PrimitiveType.Cube);
        GameObject rightWall = GameObject.CreatePrimitive(PrimitiveType.Cube);

        leftWall.transform.position = new Vector3(-10, 0, 0);
        rightWall.transform.position = new Vector3(10, 0, 0);

        leftWall.transform.localScale = new Vector3(1, 1, 2);
        rightWall.transform.localScale = new Vector3(1, 1, 2);

        leftWall.AddComponent<Rigidbody>();
        rightWall.AddComponent<Rigidbody();

        GetComponent<Collider>().isTrigger = false;
    }
             

    // Update is called once per frame
    void Update()
    {
        transfrom.Translate(Vector3.forward * Time.deltaTime * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        speed = speed * -1;
        collisions++;
        print("collision:" + collisions);
        colorPicker = Random.Range(0, 3);
    }

    private void OnTriggerExit(Collider other)
    {
        switch (colorPicker)
        {
            case 0: rend.material.color = Color.white; break;
            case 1: rend.material.color = Color.cyan; break;
            case 2: rend.material.color = Color.green; break;
            case 3: rend.material.color = Color.yellow; break;
        }
    }
}
