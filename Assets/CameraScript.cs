/*RogueBoy*/
/*Aimi Watanabe*/

/*Camera Script*/

using UnityEngine;

class CameraScript : Thing
{

    private void Start()
    {
        StartThing();
    }

    private void Update()
    {
        FollowHero();
    }



}
