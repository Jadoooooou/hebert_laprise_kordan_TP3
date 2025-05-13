using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script_interactions_nv3 : MonoBehaviour
{
    public HingeJoint hinge1;
    public HingeJoint hinge2;
    public HingeJoint hinge3;
    public HingeJoint hinge4;
    public HingeJoint hinge5;
    public HingeJoint hinge6;

    public GameObject porte1Gauche;
    public GameObject porte1Droite;
    public GameObject porte2;
    public GameObject porte3Gauche;
    public GameObject porte3Droite;
    public GameObject porte4;

    public GameObject porte02;
    public GameObject porte03;

    void Start()
    {

    }

    void Update()
    {
        //premier levier
        float angle1 = hinge1.angle;
        if (angle1 < -30f)
        {
            porte1Droite.SetActive(false);
            porte1Gauche.SetActive(true);
            BoxCollider colDroite1 = porte1Droite.GetComponent<BoxCollider>();
            if (colDroite1 != null) colDroite1.enabled = false;
            MeshRenderer rendDroite1 = porte1Droite.GetComponent<MeshRenderer>();
            if (rendDroite1 != null) rendDroite1.enabled = false;

        }
        else if (angle1 > 30f)
        {
            porte1Gauche.SetActive(false);
            porte1Droite.SetActive(true);
            BoxCollider colGauche1 = porte1Gauche.GetComponent<BoxCollider>();
            if (colGauche1 != null) colGauche1.enabled = false;
            MeshRenderer rendGauche1 = porte1Gauche.GetComponent<MeshRenderer>();
            if (rendGauche1 != null) rendGauche1.enabled = false;

        }

        //deuxieme levier
        float angle2 = hinge2.angle;
        if (angle2 < -30f)
        {
            porte2.SetActive(false);
            porte1Droite.SetActive(true);
            BoxCollider colporte2 = porte2.GetComponent<BoxCollider>();
            if (colporte2 != null) colporte2.enabled = false;
            MeshRenderer rendporte2 = porte2.GetComponent<MeshRenderer>();
            if (rendporte2 != null) rendporte2.enabled = false;
            BoxCollider colDroite1 = porte1Droite.GetComponent<BoxCollider>();
            if (colDroite1 != null) colDroite1.enabled = true;
            MeshRenderer rendDroite1 = porte1Droite.GetComponent<MeshRenderer>();
            if (rendDroite1 != null) rendDroite1.enabled = true;

        }
        else if (angle2 > 30f)
        {
            porte2.SetActive(true);
            porte1Droite.SetActive(true);
            BoxCollider colporte2 = porte2.GetComponent<BoxCollider>();
            if (colporte2 != null) colporte2.enabled = true;
            MeshRenderer rendporte2 = porte2.GetComponent<MeshRenderer>();
            if (rendporte2 != null) rendporte2.enabled = true;
            BoxCollider colDroite1 = porte1Droite.GetComponent<BoxCollider>();
            if (colDroite1 != null) colDroite1.enabled = true;
            MeshRenderer rendDroite1 = porte1Droite.GetComponent<MeshRenderer>();
            if (rendDroite1 != null) rendDroite1.enabled = true;

        }

        //troisieme levier
        float angle3 = hinge3.angle;
        if (angle3 < -30f)
        {
            porte3Droite.SetActive(false);
            porte3Gauche.SetActive(true);
            BoxCollider colDroite3 = porte3Droite.GetComponent<BoxCollider>();
            if (colDroite3 != null) colDroite3.enabled = false;
            MeshRenderer rendDroite3 = porte3Droite.GetComponent<MeshRenderer>();
            if (rendDroite3 != null) rendDroite3.enabled = false;

        }
        else if (angle3 > 30f)
        {
            porte3Gauche.SetActive(false);
            porte3Droite.SetActive(true);
            BoxCollider colGauche3 = porte3Gauche.GetComponent<BoxCollider>();
            if (colGauche3 != null) colGauche3.enabled = false;
            MeshRenderer rendGauche3 = porte3Gauche.GetComponent<MeshRenderer>();
            if (rendGauche3 != null) rendGauche3.enabled = false;

        }

        //quatrieme levier
        float angle4 = hinge4.angle;
        if (angle4 < -30f)
        {
            porte4.SetActive(false);
            porte3Gauche.SetActive(true);
            BoxCollider colporte4 = porte4.GetComponent<BoxCollider>();
            if (colporte4 != null) colporte4.enabled = false;
            MeshRenderer rendporte4 = porte4.GetComponent<MeshRenderer>();
            if (rendporte4 != null) rendporte4.enabled = false;
            BoxCollider colDroite3 = porte3Gauche.GetComponent<BoxCollider>();
            if (colDroite3 != null) colDroite3.enabled = true;
            MeshRenderer rendDroite3 = porte3Gauche.GetComponent<MeshRenderer>();
            if (rendDroite3 != null) rendDroite3.enabled = true;

        }
        else if (angle4 > 30f)
        {
            porte4.SetActive(true);
            porte3Gauche.SetActive(true);
            BoxCollider colporte4 = porte4.GetComponent<BoxCollider>();
            if (colporte4 != null) colporte4.enabled = true;
            MeshRenderer rendporte4 = porte4.GetComponent<MeshRenderer>();
            if (rendporte4 != null) rendporte4.enabled = true;
            BoxCollider colDroite3 = porte3Gauche.GetComponent<BoxCollider>();
            if (colDroite3 != null) colDroite3.enabled = true;
            MeshRenderer rendDroite3 = porte3Gauche.GetComponent<MeshRenderer>();
            if (rendDroite3 != null) rendDroite3.enabled = true;

        }

        //cinquieme levier
        float angle5 = hinge5.angle;  

        if (angle5 < -30f)
        {
            porte02.SetActive(false);
        }
        else if (angle5 > 30f)
        {
            porte02.SetActive(false);
        }

        //sixieme levier
        float angle6 = hinge6.angle;

        if (angle6 < -30f)
        {
            porte03.SetActive(false);
        }
        else if (angle6 > 30f)
        {
            porte03.SetActive(false);
        }
    }
}
