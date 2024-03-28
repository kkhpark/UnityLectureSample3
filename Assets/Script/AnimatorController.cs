using UnityEngine;

public class AnimatorController : MonoBehaviour
{

    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>(); //�� GameObject���� ã�´ٴ°���

    }

    // Update is called once per frame
    void Update()
    {
        
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
                }

        /*
        if (Input.GetKey(KeyCode.W))  //getKey�� ������ ������ ��� ȣ��.
        {
            anim.SetFloat("posy", 1f);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            anim.SetFloat("posy", -1f);
        }
        else if (Input.GetKey(KeyCode.D))
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
            anim.SetFloat("posy", 0f);
        }*/
    }
}
