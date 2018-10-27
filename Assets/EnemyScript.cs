/*RogueBoy*/
/*Aimi Watanabe*/

/*Enemy Script*/

using UnityEngine;

class EnemyScript : Thing {
    [SerializeField] bool Shooting = false;

    private void Start()
    {
        StartThing();

    }

    private void Update()
    {
        MoveAtRandom();
        if (Shooting)
        {
            ShootBullet();
        }
    }



}
