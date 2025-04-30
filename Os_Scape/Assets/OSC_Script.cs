using System.Collections;
using System.Collections.Generic;
using extOSC;
using UnityEngine;


    public class OSCScript : MonoBehaviour
    {
        public OSCReceiver oscReceiver;
        public OSCTransmitter oscTransmitter;
    private int maValeur;
    private float myChrono;


    private void LateUpdate()
    {
        // Si 100 millisecondes se sont écoulées depuis le dernier envoi :
        if (Time.realtimeSinceStartup - myChrono >= 0.1f)
        {
            myChrono = Time.realtimeSinceStartup;

            // Créer le message
            var myOscMessage = new OSCMessage("/adresse");

            // Ajouter une valeur au message, maValeur doit être remplacé par le int de votre jeu que vous souhaitez envoyer.
            myOscMessage.AddValue(OSCValue.Int((int)maValeur)); // Le (int) entre parenthèses convertit le type.

            // Envoyer le message
            oscTransmitter.Send(myOscMessage);


        }
    }

    void TraiterMessageOSC(OSCMessage oscMessage)
    {
        float value;
        if (oscMessage.Values[0].Type == OSCValueType.Int)
        {       
            value = oscMessage.Values[0].IntValue;     
        }        else if (oscMessage.Values[0].Type == OSCValueType.Float)        
        {  
            value = oscMessage.Values[0].FloatValue;    
        }       
        else  
        {  
            return;  
        } 
    }
    private void Start()
    {
        oscReceiver.Bind("*", TraiterMessageOSC);
    }
}

