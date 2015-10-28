using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class MainMenuSoundManager : MonoBehaviour {

    GameObject OptionsMenu;
    protected static float MasterSound;
    protected static float OldMasterSound;
    protected static float InterfaceSound;
    protected static float EffectsSound;
    protected static float BackgroundSound;

    //public float hSbarValue;
    private bool guiOn = false;
    void OnGUI()
    {
        if (guiOn)
        {
            MasterSound = GUI.HorizontalScrollbar(new Rect(OptionsMenu.transform.position.x, OptionsMenu.transform.position.y + 5, 200, 30), MasterSound, 1.0F, 0.0F, 11.0F);
            BackgroundSound  = GUI.HorizontalScrollbar(new Rect(OptionsMenu.transform.position.x, OptionsMenu.transform.position.y + 40, 200, 30), BackgroundSound, 1.0F, 0.0F, 11.0F);
            EffectsSound = GUI.HorizontalScrollbar(new Rect(OptionsMenu.transform.position.x, OptionsMenu.transform.position.y + 80, 200, 30), EffectsSound, 1.0F, 0.0F, 11.0F);
            InterfaceSound  = GUI.HorizontalScrollbar(new Rect(OptionsMenu.transform.position.x, OptionsMenu.transform.position.y + 115, 200, 30), InterfaceSound, 1.0F, 0.0F, 11.0F);
            //hSbarValue = float.Parse(GUI.TextField(new Rect(130, 20, 50, 20), hSbarValue.ToString()));
        }
    }

    public void setOn()
    {
        if (guiOn)
        {
            guiOn = false;
        }
        else
        {
            guiOn = true;
        }
    }
    // Use this for initialization
    void Start () {
        OptionsMenu = GameObject.FindGameObjectWithTag("OptionsMenu");
       
        MasterSound = 5f;
        OldMasterSound = MasterSound;
        InterfaceSound = 5f;
        EffectsSound = 5f;
        BackgroundSound = 5f;
    }

    // Update is called once per frame
    void Update () {
        EnterSound.volume = (InterfaceSound / 10f);
        HoverSound.volume = (InterfaceSound / 10f);
        if (MasterSound != OldMasterSound)
        {
            InterfaceSound = MasterSound;
            EffectsSound = MasterSound;
            BackgroundSound = MasterSound;
            OldMasterSound = MasterSound;
        }     
    }

    public AudioSource EnterSound;
    public AudioSource HoverSound;

    public AudioSource shootSound;
    public AudioSource swapSound;
    public AudioSource grenadeSound;
    public AudioSource grenadeFallSound;
    public AudioSource runSound;
    public AudioSource damageSound;

    public AudioSource Enemy1Sound;
    public AudioSource Enemy2Sound;
    public AudioSource CrateSound;
    public AudioSource JumpSound;
    public AudioSource JumpLandSound;

    public void PlaySoundHover()
    {
        HoverSound.Play();
    }

    public void PlaySoundEnter()
    {
        EnterSound.Play();
    }

    public void playShoot()
    {
        shootSound.Play();
    }

    public void playSwap()
    {
        swapSound.Play();
    }

    public void playGrenade()
    {
        grenadeSound.Play();
    }

    public void playGrenadeFall()
    {
        grenadeFallSound.Play();
    }

    public void playGrenadeFallStop()
    {
        grenadeFallSound.Stop();
    }

    public void playRun()
    {
        runSound.Play();
    }

    public void playRunStop()
    {
        runSound.Stop();
    }

    public void playDamage()
    {
        damageSound.Play();
    }

    public void playEnemy1()
    {
        Enemy1Sound.Play();
    }

    public void playEnemy2()
    {
        Enemy2Sound.Play();
    }

    public void playCrate()
    {
        CrateSound.Play();
    }
    public void playJump()
    {
        JumpSound.Play();
    }
    public void playJumpLand()
    {
        JumpLandSound.Play();
    }
}
