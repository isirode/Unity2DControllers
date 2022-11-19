using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranslateTargetMovementController : MonoBehaviour
{
    public string horizontalAxis = "Horizontal";
    public string verticalAxis = "Vertical";

    public float horizontalSpeed = 1f;
    public float verticalSpeed = 1f;

    public GameObject target;


    // Start is called before the first frame update
    void Start()
    {
        if (target == null)
        {
            Debug.LogWarning($"{nameof(target)} is not set, it is necessary for the {nameof(TranslateTargetMovementController)} to work.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (target == null)
        {
            return;
        }

        float horizontal = Input.GetAxis(horizontalAxis);
        float vertical = Input.GetAxis(verticalAxis);

        target.transform.Translate(Vector3.up * vertical * verticalSpeed * Time.deltaTime);
        target.transform.Translate(Vector3.right * horizontal * horizontalSpeed * Time.deltaTime);

    }
}
