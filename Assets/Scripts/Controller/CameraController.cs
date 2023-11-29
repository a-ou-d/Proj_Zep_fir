using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float cameraSpeed = 5.0f;

    public GameObject player;

    private void Update()
    {
        Vector3 direction = player.transform.position - this.transform.position;
        Vector3 moveVector = new Vector3(direction.x * cameraSpeed * Time.deltaTime, direction.y * cameraSpeed * Time.deltaTime, 0.0f);
        this.transform.Translate(moveVector);
    }
}
