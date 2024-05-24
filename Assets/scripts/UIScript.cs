using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIScript : MonoBehaviour
{
   public AudioSource loopIntro;
   public void Jugar()
   {
      SceneManager.LoadScene(1);
   }
   public void Exit()
   {
      Application.Quit();

   }

   public void PauseMusic()
   {
      if (loopIntro.isPlaying){
         loopIntro.Pause();
      } else {
         loopIntro.UnPause();
      }




   }

}
