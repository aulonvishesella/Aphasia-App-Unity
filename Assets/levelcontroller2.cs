
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Windows.Speech;
using System.Linq;
using System;
using UnityEngine.Audio;

public class levelcontroller2: MonoBehaviour
{
    //set of game objects declared
    public GameObject Obj01;
    public GameObject Obj02;
    public GameObject Obj03;
    public GameObject Obj04;
    public GameObject Player;
    public float distanceFromFirstObject;
    public float distanceFromSecondObject;
    public float distanceFromThirdObject;
    public float distanceFromFourthObject;
    public Text Text;
    public Text WellDoneTextLevel2;
    private KeywordRecognizer recognitionOfWord;
    private Dictionary<string, Action> arrayOfWords = new Dictionary<string, Action>();
    public float time = 5;
    public GameObject ContinueButton;
    public GameObject ReplayButton;
    public GameObject coffeeImage;
    public GameObject sunImage;
    public GameObject jumperImage;
    public GameObject milkImage2;
    public GameObject coffeeSpeechTextBubble;
    public GameObject sunSpeechTextBubble;
    public GameObject jumperSpeechTextBubble;
    public GameObject milkSpeechTextBubble;
    public bool alreadyPlayedCoffeeAudio = false;
    public bool alreadyPlayedSunAudio = false;
    public bool alreadyPlayedJumperAudio = false;
    public bool alreadyPlayedMilkAudio = false;
    public bool alreadyanimate = false;
 
    public GameObject playAudioButton;


    public ObjectiveData2 ObjectiveData2 { get; private set; }

    private void OnEnable()
    {
        ObjectiveData2 = ObjectivePersistenceLevel2.LoadData();

    }

    private void OnDisable()
    {
        ObjectivePersistenceLevel2.SaveData(this);
    }






    void Start()
    {
        //add to the array of words, e.g. Coffee. If they say coffee correctly for example, call the function 'WellDoneCoffee'
        arrayOfWords.Add("Coffee", WellDoneCoffee);
        arrayOfWords.Add("Sun", WellDoneSun);
        arrayOfWords.Add("Jumper", WellDoneJumper);
        arrayOfWords.Add("Milk", WellDoneMilk);
        //hide continue button and replay button.
        ContinueButton.SetActive(false);
        ReplayButton.SetActive(false);
        //all the images set to false
        coffeeImage.SetActive(false);
        sunImage.SetActive(false);
        jumperImage.SetActive(false);
        milkImage2.SetActive(false);
        //all the speech buttons set to false
        coffeeSpeechTextBubble.SetActive(true);
        sunSpeechTextBubble.SetActive(true);
        jumperSpeechTextBubble.SetActive(true);
        milkSpeechTextBubble.SetActive(true);
        //play audio button set to false
        playAudioButton.SetActive(false);



     
        recognitionOfWord = new KeywordRecognizer(arrayOfWords.Keys.ToArray());
        recognitionOfWord.OnPhraseRecognized += RecognizedSpeech;
        recognitionOfWord.Start();

    }

    private void RecognizedSpeech(PhraseRecognizedEventArgs speech)
    {
       
        arrayOfWords[speech.text].Invoke();
    }


  

  
    //function called if they say the word coffee correctly
    public void WellDoneCoffee()
    {
        //only say welldone if the first object is active on play.
        if (Obj01.active && distanceFromFirstObject < 2)
        {
            //set the welldone text to output WELLDONE!
            WellDoneTextLevel2.text = "WELL DONE!";
            //clapping audio is played for a sense of reward.
            FindObjectOfType<AudioManager>().AudioStart("clapping");
            //Text.text = "";
            //allow the buttons 'continue' and 'restart' button to appear.
            ContinueButton.SetActive(true);
            ReplayButton.SetActive(true);
            //allow the score for level 2 to be incremented by 10
            scoreforlevel2.level2currentscore += 10;
            //increment the number of times repeated coffee by 1
            Object1RepeatLevel2.scorerepeatobj1L2 += 1;
            //the button to play the audio is set to false
            playAudioButton.SetActive(false);
            ObjectiveData2.ObjectiveLevel2 += 1;

        }



    }

  
    //function called if they say the word sun correctly
    public void WellDoneSun()
    {
        //only say welldone if the second object is active on play.
        if (Obj02.active && distanceFromSecondObject< 2)
        {
            //set the welldone text to output WELLDONE!
            WellDoneTextLevel2.text = "WELL DONE!";
            //clapping audio is played for a sense of reward.
            FindObjectOfType<AudioManager>().AudioStart("clapping");
        
            //allow the buttons 'continue' and 'restart' to appear.
            ContinueButton.SetActive(true);
            ReplayButton.SetActive(true);
            //increment current score by 10
            scoreforlevel2.level2currentscore += 10;
            //set the play audio button false
            playAudioButton.SetActive(false);
            //increment number of times repeated sun by 1
            Object2RepeatLevel2.scorerepeatobj2L2 += 1;
            ObjectiveData2.Objective2Level2 += 1;
        }


    }

    //function called if they say the word jumper correctly
    public void WellDoneJumper()
    {
        //only say welldone if the third object is on play
        if (Obj03.active && distanceFromThirdObject< 2)
        {
            //set the welldone text to output WELLDONE!
            WellDoneTextLevel2.text = "WELL DONE!";
            //clapping audio is played for a sense of reward.
            FindObjectOfType<AudioManager>().AudioStart("clapping");
            //allow the buttons 'continue' and 'replay' to appear.
            ContinueButton.SetActive(true);
            ReplayButton.SetActive(true);
            //increment the current score by 10
            scoreforlevel2.level2currentscore += 10;
            //set the play audio button to false
            playAudioButton.SetActive(false);
            //increment the number of times repeated the word 'jumper' by 1
            Object3RepeatLevel2.scorerepeatobj3L2 += 1;

            ObjectiveData2.Objective3Level2 += 1;
        }


    }
    //function called if they say the word milk correctly
    public void WellDoneMilk()
    {
        //only say welldone if the fourth object is active on play.
        if (Obj04.active && distanceFromFourthObject< 2)
        {
            //set the welldone text to output WELLDONE!
            WellDoneTextLevel2.text = "WELL DONE!";
            //clapping audio is played for a sense of reward.
            FindObjectOfType<AudioManager>().AudioStart("clapping");
         
            //allow the buttons 'continue' and 'replay' to appear.
            ContinueButton.SetActive(true);
            ReplayButton.SetActive(true);
            //increment the current score for level 2 to 10
            scoreforlevel2.level2currentscore += 10;
            //set the audio button to play to false
            playAudioButton.SetActive(false);
            //increment the number of times repeated the word 'Milk' by 1
            Object4RepeatLevel2.scorerepeatobj4L2 += 1;

            ObjectiveData2.Objective4Level2 += 1;
        }


    }

    private void updateitlevel2()
    {
        FindObjectOfType<ObjectiveText2>().returnText().text = ObjectiveData2.ObjectiveLevel2.ToString();

    }
    private void updateit2level2()
    {
        FindObjectOfType<ObjectiveText2>().returnText2().text = ObjectiveData2.Objective2Level2.ToString();

    }
    private void updateit3level2()
    {
        FindObjectOfType<ObjectiveText2>().returnText3().text = ObjectiveData2.Objective3Level2.ToString();

    }
    private void updateit4level2()
    {
        FindObjectOfType<ObjectiveText2>().returnText4().text = ObjectiveData2.Objective4Level2.ToString();

    }
    // Update is called once per frame

    void FixedUpdate()
    {
        updateitlevel2();
        updateit2level2();
        updateit3level2();
        updateit4level2();
        //calculate distances between objectives and the player
        distanceFromFirstObject = Vector3.Distance(Player.transform.position, FindObjectOfType<objectiveController>().RetrieveObjective("CoffeeObjective").transform.position);
        distanceFromSecondObject = Vector3.Distance(Player.transform.position, FindObjectOfType<objectiveController>().RetrieveObjective("SunObjective").transform.position);
        distanceFromThirdObject = Vector3.Distance(Player.transform.position, FindObjectOfType<objectiveController>().RetrieveObjective("JumperObjective").transform.position);
        distanceFromFourthObject = Vector3.Distance(Player.transform.position, FindObjectOfType<objectiveController>().RetrieveObjective("MilkObjective").transform.position);
        //if the distance between the first object is less than 2 and the object is active, show properties
        if (distanceFromFirstObject < 2 && FindObjectOfType<objectiveController>().RetrieveObjective("CoffeeObjective").active)
        {
            
            Text.text = "COFFEE";
            //set the text to the name for objective
            Text.text = FindObjectOfType<objectiveController>().RetrieveName("CoffeeObjective");
            //show speech bubble
            coffeeSpeechTextBubble.SetActive(true);
         
         
            Text.color = Color.black;
            FindObjectOfType<objectiveController>().showImage("CoffeeObjective");

            //if the played coffee audio is false, show the button to play the audio
            if (alreadyPlayedCoffeeAudio == false)
            {
                playAudioButton.SetActive(true);
            }
          



        }
        //if the distance between the second object is less than 2 and it is active
        if (distanceFromSecondObject < 2 && FindObjectOfType<objectiveController>().RetrieveObjective("SunObjective").active)
        {
            Text.text = "SUN";
            Text.color = Color.yellow;
            //set the text to the sun objective
            Text.text = FindObjectOfType<objectiveController>().RetrieveName("SunObjective");
            //Text.color = Color.yellow;
            //show image for the sun objective
            FindObjectOfType<objectiveController>().showImage("SunObjective");
            //show speech bubble
            sunSpeechTextBubble.SetActive(true);
            //if the played sun audio is false, show the button to play the audio

            if (alreadyPlayedSunAudio == false)
            {
                playAudioButton.SetActive(true);
            }


        }
        //if the distance between the thrd object is less than 2 and it is active

        if (distanceFromThirdObject < 2 && FindObjectOfType<objectiveController>().RetrieveObjective("JumperObjective").active)
        {
            //set the text to the jumper objective
            Text.text = FindObjectOfType<objectiveController>().RetrieveName("JumperObjective");
            Text.color = Color.red;
            //show image for the jumper objective
            FindObjectOfType<objectiveController>().showImage("JumperObjective");
            //set active the speech bubble
            jumperSpeechTextBubble.SetActive(true);
            //if the played jumper audio is false, show the button to play the audio

            if (alreadyPlayedJumperAudio == false)
            {
                playAudioButton.SetActive(true);
            }
        }
        //if the distance between the last object is less than 2 and it is active

        if (distanceFromFourthObject < 2 && FindObjectOfType<objectiveController>().RetrieveObjective("MilkObjective").active)
        {
            //set the text to the milk objective
            Text.text = FindObjectOfType<objectiveController>().RetrieveName("MilkObjective");
            Text.color = Color.white;
            milkImage2.SetActive(true);
            //show image
            FindObjectOfType<objectiveController>().showImage("MilkObjective");
            //show speech bubble text
            milkSpeechTextBubble.SetActive(true);
            //if the played milk audio is false, show the button to play the audio

            if (alreadyPlayedMilkAudio == false)
            {
                playAudioButton.SetActive(true);
            }
        }

        //if the avatar not next to the objective for coffee
        if (distanceFromFirstObject > 2 && FindObjectOfType<objectiveController>().RetrieveObjective("CoffeeObjective").active && Text.text == "COFFEE")
        {
            
            //set the variable to check if it has played the audio to false so next time returned, can play it again
            alreadyPlayedCoffeeAudio = false;
            playAudioButton.SetActive(false);

            //incase they complete the objective and try repeat but want to then move away, need to hide the button and text.
            ContinueButton.SetActive(false);
            ReplayButton.SetActive(false);
            WellDoneTextLevel2.text = "";
            
            Text.text = "";
           
            //hide image and stop playing the audio
            FindObjectOfType<objectiveController>().hideImage("CoffeeObjective");
            FindObjectOfType<objectiveController>().stopAudio("CoffeeObjective");


        }
        //if the avatar not next to the objective for sun

        if (distanceFromSecondObject > 2 && FindObjectOfType<objectiveController>().RetrieveObjective("SunObjective").active && Text.text == "SUN")
        {

            //set the variable to check if it has played the audio to false so next time returned, can play it again
            alreadyPlayedSunAudio = false;
            playAudioButton.SetActive(false);
            Text.text = "";
       
            // hide image and stop audio
            FindObjectOfType<objectiveController>().hideImage("SunObjective");
            FindObjectOfType<objectiveController>().stopAudio("SunObjective");

            //incase they complete the objective and try repeat but want to then move away, need to hide the button and text.
            ContinueButton.SetActive(false);
            ReplayButton.SetActive(false);
            WellDoneTextLevel2.text = "";
        }
        //if the avatar not next to the objective for jumper

        if (distanceFromThirdObject > 2 && FindObjectOfType<objectiveController>().RetrieveObjective("JumperObjective").active && Text.text == "JUMPER")
        {
            //set the variable to check if it has played the audio to false so next time returned, can play it again
            alreadyPlayedJumperAudio = false;
            playAudioButton.SetActive(false);
            Text.text = "";
            //hide image and stop playing the audio
            FindObjectOfType<objectiveController>().hideImage("JumperObjective");
            FindObjectOfType<objectiveController>().stopAudio("JumperObjective");
           
            //incase they complete the objective and try repeat but want to then move away, need to hide the button and text.
            ContinueButton.SetActive(false);
            ReplayButton.SetActive(false);
            WellDoneTextLevel2.text = "";

        }
        //if the avatar not next to the objective for milk

        if (distanceFromFourthObject > 2 && FindObjectOfType<objectiveController>().RetrieveObjective("MilkObjective").active && Text.text == "MILK")
        {
            //set the variable to check if it has played the audio to false so next time returned, can play it again
            alreadyPlayedMilkAudio = false;
            playAudioButton.SetActive(false);
            Text.text = "";
            //hide image, stop audio and hide speech bubble
            FindObjectOfType<objectiveController>().hideImage("MilkObjective");
            FindObjectOfType<objectiveController>().stopAudio("MilkObjective");
       
            //incase they complete the objective and try repeat but want to then move away, need to hide the button and text.
            ContinueButton.SetActive(false);
            ReplayButton.SetActive(false);
            WellDoneTextLevel2.text = "";
        }

    }
    //method to play the audio when the button is clcked
    public void PlayAudio()
    {
        //make sure that the audio voice has not played and is next to the coffee objective
        if ( alreadyPlayedCoffeeAudio == false && distanceFromFirstObject<2 )
        {
            //play the audio voice for coffee
            FindObjectOfType<objectiveController>().playAudio("CoffeeObjective");
  
            //hide the audio button
            playAudioButton.SetActive(false);
            //this boolean statement ensures that it has played so prevents loops of audio.
            alreadyPlayedCoffeeAudio = true;
     




        }
        //make sure that the audio voice has not played and is next to the sun objective
        if (alreadyPlayedSunAudio == false && distanceFromSecondObject < 2)
        {
            //play the audio voice sun
            FindObjectOfType<objectiveController>().playAudio("SunObjective");
            //hide the audio button
            playAudioButton.SetActive(false);
            //this boolean statement ensures that it has played so prevents loops of audio.
            alreadyPlayedSunAudio = true;

        }
        //make sure that the audio voice has not played and is next to the jumper objective
        if (alreadyPlayedJumperAudio == false && distanceFromThirdObject < 2)
        {
            //play the audio voice jumper
            FindObjectOfType<objectiveController>().playAudio("JumperObjective");
            //hide the audio button

            playAudioButton.SetActive(false);
            //this boolean statement ensures that it has played so prevents loops of audio.

            alreadyPlayedJumperAudio = true;

        }
        //make sure that the audio voice has not played and is next to the milk objective

        if (alreadyPlayedMilkAudio == false && distanceFromFourthObject < 2)
        {
            //play the audio voice milk
            FindObjectOfType<objectiveController>().playAudio("MilkObjective");
            //hide the audio button

            playAudioButton.SetActive(false);
            //this boolean statement ensures that it has played so prevents loops of audio.

            alreadyPlayedMilkAudio = true;

        }
    }

    

    //this method removes the objective 
    public void NextObjective()
    {
        //checks that the word is for the objective 'coffee'
        if (Text.text == "COFFEE")
        {
            //hide the continue button,replay button and speech bubble.
            ContinueButton.SetActive(false);
            ReplayButton.SetActive(false);
         
            //hide the image for the coffee objective
            FindObjectOfType<objectiveController>().hideImage("CoffeeObjective");

            WellDoneTextLevel2.text = "";
            //nudges player away from objective
            Player.transform.position = new Vector3(3, (int)1, -81);
            Text.text = "";
            //set the audio button to false
            playAudioButton.SetActive(false);
       


        }
      


        //checks that the objective word is sun
        if (Text.text == "SUN")
        {
            //set the continue button and restart button to false as well as the speech bubble
            ContinueButton.SetActive(false);
            ReplayButton.SetActive(false);
            
            //hide annimations and the image
            FindObjectOfType<objectiveController>().hideImage("SunObjective");
            //nudges player away from objective
            Player.transform.position = new Vector3(27, (int)0.2, -53);
            WellDoneTextLevel2.text = "";
           
            Text.text = "";
            //hide the 'play audio' button
            playAudioButton.SetActive(false);
        
        }
        //checks that the objective word is jumper

        if (Text.text == "JUMPER")
        {
            //hide the continue button,replay button, jumper image,speech bubble, the objective,the aimation and the button to play the audio
            ContinueButton.SetActive(false);
            ReplayButton.SetActive(false);
            jumperImage.SetActive(false);
          
            //nudges player away from objective
            Player.transform.position = new Vector3(-21, 2, -28);
            WellDoneTextLevel2.text = "";
            Text.text = "";
            playAudioButton.SetActive(false);
        
        }
        //checks that the objective word is milk

        if (Text.text == "MILK")
        {
            //hide the continue button,replay button, jumper image,speech bubble, the objective,the aimation and the button to play the audio

            //nudges player away from objective
            Player.transform.position = new Vector3(3, 2, -7);
          
            ContinueButton.SetActive(false);
            ReplayButton.SetActive(false);
            milkImage2.SetActive(false);
            WellDoneTextLevel2.text = "";
         
            Text.text = "";
            playAudioButton.SetActive(false);
        }
    }
    //allows the user to play the word again.
    public void PlayAgain()
    {
        //checks that the objective word is coffee
        if (Text.text == "COFFEE")
        {

            //hide the continue and replay button.Show the image for coffee, the speech text bubble. 
            ContinueButton.SetActive(false);
            ReplayButton.SetActive(false);
            FindObjectOfType<objectiveController>().showImage("CoffeeObjective");
            coffeeSpeechTextBubble.SetActive(true);
            WellDoneTextLevel2.text = "";
            //this will mute the clapping volume when the user restarts. This is to ensure the 'coffee' audio is not played whilst the 'clapping' audio is still playing
            FindObjectOfType<AudioManager>().Mute("clapping");
            Text.text = "COFFEE";
            //set the audio to play coffee to false therefore can be played again
            alreadyPlayedCoffeeAudio = false;
          
        }

        //checks that the objective word is sun
        if (Text.text == "SUN")
        {           
            //hide the continue and replay button.Show the image for sun and the speech text bubble. 
            ContinueButton.SetActive(false);
            ReplayButton.SetActive(false);
            sunSpeechTextBubble.SetActive(true);
            FindObjectOfType<objectiveController>().showImage("SunObjective");
            WellDoneTextLevel2.text = "";
            //this will mute the clapping volume when the user restarts. This is to ensure the 'sun' audio is not played whilst the 'clapping' audio is still playing
            FindObjectOfType<AudioManager>().Mute("clapping");
            Text.text = "SUN";
            Text.color = Color.yellow;
            //set alreadyplayed back to false therefore audio can be played again.
            alreadyPlayedSunAudio = false;
            
        }
        //checks that the objective word is jumper
        if (Text.text == "JUMPER")
        {
            //hide the continue and replay button.Show the image for jumper andthe speech text bubble.
            ContinueButton.SetActive(false);
            ReplayButton.SetActive(false);
            FindObjectOfType<objectiveController>().showImage("JumperObjective");
            jumperSpeechTextBubble.SetActive(true);
            WellDoneTextLevel2.text = "";
            
            //this will mute the clapping volume when the user restarts. This is to ensure the 'jumper  ' audio is not played whilst the 'clapping' audio is still playings
            FindObjectOfType<AudioManager>().Mute("clapping");
           
            Text.text = "JUMPER";
            Text.color = Color.red;
            //set alreadyplayed back to false therefore audio can be played again.
            alreadyPlayedJumperAudio = false;
           

        }
        //checks that the objective word is milk
        if (Text.text == "MILK")
        {
            //hide the continue and replay button.Show the image for jumper qnd the speech text bubble.

            ContinueButton.SetActive(false);
            ReplayButton.SetActive(false);
            FindObjectOfType<objectiveController>().showImage("MilkObjective");
            milkSpeechTextBubble.SetActive(true);
            WellDoneTextLevel2.text = "";
            
            //this will mute the clapping volume when the user restarts. This is to ensure the 'milk' audio is not played whilst the 'clapping' audio is still playing
            FindObjectOfType<AudioManager>().Mute("clapping");
            
            Text.text = "MILK";
            Text.color = Color.white;
            //set alreadyplayed back to false therefore audio can be played again.
            alreadyPlayedMilkAudio = false;
         

        }


    }
}



