using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public CharacterController controller;
 public AudioSource JumpSound;
  public GameObject footstep;
public AudioSource footstepe;

 public Transform orientation;
    public float speed = 12f;

    public float gravity = -9.81f;

    public float jumpHeight = 3f;

public Animator anim;


    public Transform GroundCheck;

    public float groundDistance = 0.4f;

    public LayerMask groundMask;

 private bool isJumping;

    Vector3 velocity;

    bool isGrounded;


private void jump(){
   if(!isJumping){
      isJumping = true;
       velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
JumpSound = GetComponent<AudioSource>();
JumpSound.Play(0);
      Invoke("resetIsJumping", 1.5f);
   }
 }
 
 private void resetIsJumping(){
   isJumping=false;
 }

void Start()
{
   
}




    // Update is called once per frame

    void Update()

    {

        isGrounded = Physics.CheckSphere(GroundCheck.position, groundDistance, groundMask);



       




        float x = Input.GetAxis("Horizontal");

        float z = Input.GetAxis("Vertical");



        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * speed * Time.deltaTime);

if(isGrounded) {




        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D)) {
        anim.SetBool("isRunning", true);
          anim.SetBool("Midair", false);
        footstepe = footstep.GetComponent<AudioSource>();
        if (!footstepe.isPlaying)
        {
            footstepe.Play();
        }


        
       
         } else {
              anim.SetBool("isRunning", false);
                anim.SetBool("Midair", false);
        
        footstepe.Stop();
        }
}
if(!isGrounded) {
    anim.SetBool("isRunning", false);
    anim.SetBool("Midair", true);
     
        footstepe.Stop();
} else {
      anim.SetBool("Midair", false);

}
  if(Input.GetButtonDown("Jump") && isGrounded)

        {
        
        footstepe.Stop();
jump();
       

        }

        velocity.y += gravity * Time.deltaTime;



        controller.Move(velocity * Time.deltaTime);





    }

}
