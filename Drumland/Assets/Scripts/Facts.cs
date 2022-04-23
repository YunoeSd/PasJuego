using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

// Rodrigo Alfredo Mendoza España
// Asignar al texto en loading un texto aleatorio de facts
public class Facts : MonoBehaviour
{
    public TextMeshProUGUI facts;


    string[] arrayFacts = { "Percussion instruments are consider the oldest musical instruments",
    "Some percussion instruments are tuned and can sound different notes, like the xylophone, timpani or piano",
    "Some percussion instruments are untuned with no definite pitch, like the bass drum, cymbals or castanets."};

    private void Start()
    {
        int index = Random.Range(0, arrayFacts.Length);
        facts.text = arrayFacts[index];
    }

}
