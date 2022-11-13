using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// ��ġ�� �� ���� ��ũ��Ʈ
public class Tutorial1game_1 : MonoBehaviour
{
    public int count = 0; // �� ������Ʈ ���� ������ �ѱ�� ���� �Լ�

    private string testName;
    public Transform testcube;
    public Vector3 pos;

    public string[] InputList = new string[5];
    public string InputTag; // �浹�� �±� �����ص�

    public Rigidbody HamPrefab;
    public Transform HamTrans;
    public Rigidbody PaPrefab;
    public Transform PaTrans;
    public Rigidbody PapricPrefab;
    public Transform PapricTrans;
    public Rigidbody MushPrefab;
    public Transform MushTrans;
    public Rigidbody GesalPrefab;
    public Transform GesalTrans;
    public GameObject[] Tags;
    public ButtonScript Bts;

    public Rigidbody GuestPrefab;
    public Transform GuestTrans;

    private string[] Foodtags = { "Ham", "Mush", "pa", "Gesal", "Papric" };



    public void OnCollisionEnter(Collision collision)
    {
        if (count < 5) // 5������ �ִ�� ����, �� �̻��� �ȵ�
        {
            if (collision.gameObject.tag == "Ham" || collision.gameObject.tag == "Gesal" || collision.gameObject.tag == "Mush" || collision.gameObject.tag == "Papric" || collision.gameObject.tag == "pa")
            {
                InputTag = collision.gameObject.tag; // �浹�� ������Ʈ �±װ��� ����
                InputList[count] = InputTag;
                count = count + 1; // �������� �Ѿ �� �ְ� ��

                testcube.transform.Find("T" + collision.gameObject.tag + count.ToString()).gameObject.SetActive(true);

                pos = GameObject.Find("PosEmpty").transform.position;
                collision.gameObject.transform.position = pos;

                Destroy(collision.gameObject, 3);  // �浹�� ���� ������Ʈ ����
            }
        }
    }

    void Start()
    {

    }

    void Update()
    {

    }
}