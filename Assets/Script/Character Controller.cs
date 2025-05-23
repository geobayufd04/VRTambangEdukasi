using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class VRPlayerCollisionFix : MonoBehaviour
{
    public GameObject xrOrigin;
    public CharacterController characterController;

    void Update()
    {
        Vector3 center = xrOrigin.transform.position;
        center.y = characterController.height / 2;
        characterController.center = center;
    }
}
