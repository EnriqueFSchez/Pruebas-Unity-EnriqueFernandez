using UnityEngine;
using UnityEngine.InputSystem;

public class playerManager : MonoBehaviour
{


    [SerializeField] float speedZ;
    [SerializeField] float speedX;
    [SerializeField] float rotSpeed;

    float moveZ;
    float moveX;


    [SerializeField] float smoothTime = 0.3f;
    private Vector3 velocity = Vector3.zero;
    Vector3 currentRot;


    private void Awake()
    {

        Inputtions = new InputPlayer_Acciones();



    }
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }





}
