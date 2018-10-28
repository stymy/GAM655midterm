/*RogueBoy*/
/*Aimi Watanabe*/

/*Beast Script*/

using UnityEngine;

class BeastScript : Thing
{

    [SerializeField] MoveState thisState = MoveState.Random;
    [SerializeField] float thisLOSRadius = 0;
    [SerializeField] GameObject[] thisPathWaypoints;

    private void Start()
    {
        StartThing();

    }

    private void Update()
    {
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

