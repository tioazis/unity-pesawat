using UnityEngine;
using System.Collections;

public class VirtualButton : MonoBehaviour {

    // Use this for initialization

    bool PencetKiri = false;
    bool PencetAtas = false;
    bool PencetKanan = false;
    bool PencetBawah = false;
    bool PencetTembak = false;

    Pesawat pesawat;

    public void AtasDipencet()
    {
        PencetAtas = true;
    }

    public void AtasDilepas()
    {
        PencetAtas = false;
    }

    public void KananDipencet()
    {
        PencetKanan = true;
    }

    public void KananDilepas()
    {
        PencetKanan = false;
    }

    public void KiriDipencet()
    {
        PencetKiri = true;
    }

    public void KiriDilepas()
    {
        PencetKiri = false;
    }

    public void BawahDipencet()
    {
        PencetBawah = true;
    }

    public void BawahDilepas()
    {
        PencetBawah = false;
    }
    public void TembakDipencet()
    {
        PencetTembak = true;
    }

    public void TembakDilepas()
    {
        PencetTembak = false;
    }
    void Start () {

        pesawat = FindObjectOfType<Pesawat>();
	
	}
	
	// Update is called once per frame
	void Update () {

        if (PencetAtas)
            pesawat.MoveUp();
        if (PencetBawah)
            pesawat.MoveDown();
        if (PencetKanan)
            pesawat.MoveRight();
        if (PencetKiri)
            pesawat.MoveLeft();
        if (PencetTembak)
            pesawat.Attack();
	}

    
}
