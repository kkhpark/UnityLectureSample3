using UnityEngine;

public class AnimatorController : MonoBehaviour
{

    public Animator anim;
    public CharacterController CharacterController;
    public float moveSpeed = 2f;
    public float maxTurnSpeed = 150f;
    public float horizontal;  //여따가 무엇이 들어가는가.
    public float vertical;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>(); //내 GameObject에서 찾는다는거지
        CharacterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        /*
                //getKeyDown은 딱 처음에 눌렸을때 한번.
                if (Input.GetKey(KeyCode.W))  //getKey는 누르는 동안은 계속 호출.
                {
                    //iswalk 파라미터를 true로 변환 해준다.
                    anim.SetBool("isWalk", true); //이렇게 스트링으로 값을 찾기 때문에 보통은 animator에서는 변수를 전부 소문자로 한다고 함.  틀리면 동작을 안하니


                }
                else if (Input.GetKey(KeyCode.S))
                {
                    anim.SetBool("isWalkBack", true);
                }
                else
                {
                    anim.SetBool("isWalk", false);
                    anim.SetBool("isWalkBack", false);
                }*/

        //이거 하면 뭐가 리턴되냐 -> 조이스틱의 왼쪽 오른쪽 (근데 키보드도 적용이 같이 됨.  좌우 위아래)
        horizontal = Input.GetAxis("Horizontal"); //A와 D
        //위 아래
        vertical = Input.GetAxis("Vertical");//W S
                                             //어떻게 자동으로 맵핑이 되는거지..?

        anim.SetFloat("posx", horizontal);
        anim.SetFloat("posy", vertical);

        Vector3 direction = new Vector3(horizontal, 0, vertical);
        direction *= moveSpeed;
        CharacterController.SimpleMove(direction);

/*
        if (Input.GetKey(KeyCode.W))  //getKey는 누르는 동안은 계속 호출.
        {
            anim.SetFloat("posy", 1f);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            anim.SetFloat("posy", -1f);
        }
        else
        {
            anim.SetFloat("posy", 0f);
        }


        if (Input.GetKey(KeyCode.D))
        {
            anim.SetFloat("posx", 1f);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            anim.SetFloat("posx", -1f);
        }
        else
        {
            anim.SetFloat("posx", 0f);
        }*/
    }
}
