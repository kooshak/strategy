using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour {
    private int screenWidth;
    private int screenHeight;

    public float speed;
    public bool useCamMove = false;

    // Start is called before the first frame update
    void Start()
    {
        screenWidth = Screen.width;
        screenHeight = Screen.height;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 cameraPos = transform.position;

        if(Input.mousePosition.x <= 20)
        {
            cameraPos.x -= Time.deltaTime * speed;
            cameraPos.z += Time.deltaTime * speed;
        }
        else if(Input.mousePosition.x >= screenWidth - 20)
        {
            cameraPos.x += Time.deltaTime * speed;
            cameraPos.z -= Time.deltaTime * speed;
        }
        else if (Input.mousePosition.y <= 20)
        {
            cameraPos.x -= Time.deltaTime * speed;
            cameraPos.z -= Time.deltaTime * speed;
        }
        else if (Input.mousePosition.y >= screenHeight - 20)
        {
            cameraPos.x += Time.deltaTime * speed;
            cameraPos.z += Time.deltaTime * speed;
        }
        if (useCamMove = true)
        {
            transform.position = cameraPos;
        }
    }
}
