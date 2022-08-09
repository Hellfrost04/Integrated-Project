using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform teleportTarget;
    public GameObject playerController;

    void OnTriggerEnter(Collider other)
    {
        playerController.transform.position = teleportTarget.transform.position;
        playerController.transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles - new Vector3(0f, 90f, 0f));
    }
}
