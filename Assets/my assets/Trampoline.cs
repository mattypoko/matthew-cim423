using UnityEngine;
using System.Collections;

public class Trampoline : MonoBehaviour
{
    public float launchSpeed = 6f;
    public float gravity = -9.81f;

    private void OnTriggerEnter(Collider other)
    {
        CharacterController cc = other.GetComponentInParent<CharacterController>();

        if (cc != null)
        {
            StartCoroutine(Launch(cc));
        }
    }

    private IEnumerator Launch(CharacterController cc)
    {
        float yVelocity = launchSpeed;

        while (!cc.isGrounded || yVelocity > 0)
        {
            yVelocity += gravity * Time.deltaTime;
            Vector3 move = new Vector3(0, yVelocity, 0);
            cc.Move(move * Time.deltaTime);
            yield return null;
        }
    }
}