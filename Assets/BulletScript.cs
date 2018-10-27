/*RogueBoy*/
/*Aimi Watanabe*/

/*Bullet Script*/

using UnityEngine;

class BulletScript: Thing
{
    [SerializeField] float Lifetime;

    private void Start()
    {
        StartThing();
        thisDir = transform.right;
        Destroy(this.gameObject, Lifetime);
    }
    private void Update()
    {
        MoveThing();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(this.gameObject);
    }
}