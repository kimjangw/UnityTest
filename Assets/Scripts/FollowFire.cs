using UnityEngine;
using System.Collections;
public class FollowFire : MonoBehaviour
{

    public GameObject bulletFollow;
    public Transform followFirePoint;

    GameObject bullet;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(BulletShot());
    }

    // Update is called once per frame
    void Update()
    {
       

    }

    IEnumerator BulletShot()
    {
       

        while(true)
        {
            bullet = Instantiate(bulletFollow);
            //총알 오브젝트 비활성화

            bullet.SetActive(true);
            bullet.transform.position = followFirePoint.position;
            bullet.transform.up = followFirePoint.up;
            yield return new WaitForSeconds(1f);
        }
        
    }

    public void brokenBullet()
    {
        Destroy(bullet);
    }



}
