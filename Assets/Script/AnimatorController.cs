using UnityEngine;

public class AnimatorController : MonoBehaviour
{

    public Animator anim;
    public CharacterController CharacterController;
    public float moveSpeed = 2f;
    public float maxTurnSpeed = 150f;
    public float horizontal;  //������ ������ ���°�.
    public float vertical;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>(); //�� GameObject���� ã�´ٴ°���
        CharacterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        /*
                //getKeyDown�� �� ó���� �������� �ѹ�.
                if (Input.GetKey(KeyCode.W))  //getKey�� ������ ������ ��� ȣ��.
                {
                    //iswalk �Ķ���͸� true�� ��ȯ ���ش�.
                    anim.SetBool("isWalk", true); //�̷��� ��Ʈ������ ���� ã�� ������ ������ animator������ ������ ���� �ҹ��ڷ� �Ѵٰ� ��.  Ʋ���� ������ ���ϴ�


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

        //�̰� �ϸ� ���� ���ϵǳ� -> ���̽�ƽ�� ���� ������ (�ٵ� Ű���嵵 ������ ���� ��.  �¿� ���Ʒ�)
        horizontal = Input.GetAxis("Horizontal"); //A�� D
        //�� �Ʒ�
        vertical = Input.GetAxis("Vertical");//W S
                                             //��� �ڵ����� ������ �Ǵ°���..?

        anim.SetFloat("posx", horizontal);
        anim.SetFloat("posy", vertical);

        Vector3 direction = new Vector3(horizontal, 0, vertical);
        direction *= moveSpeed;
        CharacterController.SimpleMove(direction);

/*
        if (Input.GetKey(KeyCode.W))  //getKey�� ������ ������ ��� ȣ��.
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
