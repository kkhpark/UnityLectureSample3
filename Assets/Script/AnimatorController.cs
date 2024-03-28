using UnityEngine;

public class AnimatorController : MonoBehaviour
{

    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>(); //내 GameObject에서 찾는다는거지

    }

    // Update is called once per frame
    void Update()
    {
        
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
                }

        /*
        if (Input.GetKey(KeyCode.W))  //getKey는 누르는 동안은 계속 호출.
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
