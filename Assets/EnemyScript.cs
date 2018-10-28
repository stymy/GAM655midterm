/*RogueBoy*/
/*Aimi Watanabe*/

/*Enemy Script*/

using UnityEngine;

class EnemyScript : Thing {

    [SerializeField] bool Shooting = false;
    [SerializeField] MoveState thisState = MoveState.Random;
    [SerializeField] float thisLOSRadius = 0;
    [SerializeField] GameObject[] thisPathWaypoints;

    private void Start()
    {
        StartThing();

    }

    private void Update()
    {
        if (Shooting)
        {
            ShootBullet();
        }

        switch (thisState)
        {

            case (MoveState.Random):
                {
                    MoveAtRandom();
                }
                break;

            case (MoveState.Follow):
                {
                    float aDistance = DistancetoHero();
                    if (aDistance < thisLOSRadius)
                    {
                        FollowHero();
                    }
                }
                break;

            case (MoveState.Run):
                {
                    float aDistance = DistancetoHero();
                    if (aDistance < thisLOSRadius)
                    {
                        RunFromHero();
                    }
                }
                break;

            case (MoveState.Path):
                {
                    FollowPath(thisPathWaypoints);
                }
                break;
        }
    }



}
