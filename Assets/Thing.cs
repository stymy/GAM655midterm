/*RogueBoy*/
/*Aimi Watanabe*/

/*Thing Script*/

using UnityEngine;

class Thing : MonoBehaviour
{
    [SerializeField] float thisSpeed = 0;
    protected Vector3 thisDir = Vector3.zero;
    protected Rigidbody2D RB = null;
    [SerializeField] float ChangeDirCooldown;
    private float ChangeDirTimer;

    [SerializeField] GameObject thisBullet = null;
    [SerializeField] float thisBulletCooldown = 0;
    private float thisBulletTimer = 0;

    private GameObject HeroObject = null;

    protected void StartThing()
    {
        HeroObject = GameObject.Find("Hero");
        RB = gameObject.GetComponent<Rigidbody2D>();
        ChangeDirTimer = Time.time;
    }

    protected void MoveThing()
    {
        RB.velocity = thisDir * thisSpeed;
    }

    protected Vector3 RollRandomVector3()
    {
        Vector3 aDir = Vector3.zero;
        aDir.x = Random.Range(-1f, 1f);
        aDir.y = Random.Range(-1f, 1f);
        aDir.Normalize();
        return aDir;
    }

    protected void ShootBullet()
    {
        thisBulletTimer--;
        if (thisBulletTimer <=0)
        {
            Instantiate(thisBullet, this.transform);
            thisBulletTimer = thisBulletCooldown;
        }

    }

    protected void MoveAtRandom()
    {
        if (ChangeDirTimer + ChangeDirCooldown <= Time.time)
        {
            thisDir = RollRandomVector3();
            ChangeDirTimer = Time.time;
        }

        MoveThing();
    }

    protected void FollowHero()
    {
        Vector3 aTarget = HeroObject.transform.position;
        Vector3 aDir = aTarget - this.transform.position;
        aDir.z = 0;
        thisDir = aDir;
        MoveThing();
    }
}