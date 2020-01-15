using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class PlayerController : MonoBehaviour
{
    public GameObject MainRigidBody;
    public FixedJoystick MoveJoystick;
    public FixedTouchField TouchField;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var fps = MainRigidBody.GetComponent<RigidbodyFirstPersonController>();
        fps.RunAxis = MoveJoystick.Direction;
        fps.mouseLook.LookAxis = TouchField.TouchDist;

        
    }
}
