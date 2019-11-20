using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{


    [SerializeField] float spped = 1.0f;
    [SerializeField] float startPosition;
    [SerializeField] float endPosition;





    // Update is called once per frame
    void Update()
    {

        transform.Translate(-1 * spped * Time.deltaTime, 0, 0);
        if (transform.position.x <= endPosition)
        {
            transform.Translate(-1 * (endPosition - startPosition), 0, 0);

            SendMessage("ChangePosition", SendMessageOptions.DontRequireReceiver);
        }

    }




}
