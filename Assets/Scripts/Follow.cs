using UnityEngine;
using UnityEngine.UIElements;

public class Follow : MonoBehaviour
{
    public Transform Player;
    private Vector3 targetPosition;     //목표 위치
    private Vector3 followCuvbe;
    private float moveSpeed = 4f;

    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        targetPosition = Player.transform.position;
   
      
       
        Vector3 targetDir = new Vector3(targetPosition.x, targetPosition.y-2, 0f);
        //dir.Normalize();

      

        transform.position = Vector3.MoveTowards(
           transform.position,
           targetDir,
           moveSpeed*Time.deltaTime);
    }


}
