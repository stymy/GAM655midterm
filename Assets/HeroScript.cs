/* RogueBoy */
/* Aimi Watanabe */

/* Hero Script */

using UnityEngine;

class HeroScript : Thing
{
    private void Start()
    {
        StartThing();
    }

    private void Update()
    {
        UpdateMovement();
        UpdateWeapon();
    }

    void UpdateMovement()
    {
        thisDir = Vector3.zero;

        if (Input.GetKey(KeyCode.DownArrow))
        {
            thisDir += Vector3.down;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            thisDir += Vector3.left;
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            thisDir += Vector3.up;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            thisDir += Vector3.right;
        }

        MoveThing();
    }

    void UpdateWeapon()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            ShootBullet();
        }
    }

}