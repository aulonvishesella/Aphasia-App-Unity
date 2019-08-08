
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Windows.Speech;
using System.Linq;
using System;
using UnityEngine.Audio;

public class controllerforlevel3 : MonoBehaviour
{
    //decleration of a varierty of game objects used in the virtual world.

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
    public Text WellDoneText;

    private KeywordRecognizer recognitionOfWords;
    private Dictionary<string, Action> wordArray = new Dictionary<string, Action>();
    public float time = 5;
    public GameObject ContinueButton;
    public GameObject ReplayButton;
    public GameObject coffeeImage;
    public GameObject sunImage;
    public GameObject jumperImage;
    public GameObject milkImage;
    public GameObject coffeeSpeechTextBubble;
    public GameObject sunSpeechTextBubble;
    public GameObject jumperSpeechTextBubble;
    public GameObject milkSpeechTextBubble;
    public bool alreadyPlayedCoffeeAudio = false;
    public bool alreadyPlayedSunAudio = false;
    public bool alreadyPlayedJumperAudio = false;
    public bool alreadyPlayedMilkAudio = false;
    public bool alreadyShownCoffeeImage = false;
    public bool alreadyShownSunImage = false;
    public bool alreadyShownJumperImage = false;
    public bool alreadyShownMilkImage = false;
    public GameObject playAudioButton;
    public GameObject showImageButton;

    public ObjectiveData3 ObjectiveData3 { get; private set; }

    private void OnEnable()
    {
        ObjectiveData3 = ObjectivePersistence3.LoadData();

    }

    private void OnDisable()
    {
        ObjectivePersistence3.SaveData(this);
    }



    // Use this for initialization
    void Start()
    {
        //add to the array of words, e.g. Coffee. If they say coffee correctly for example, call the function 'WellDoneCoffee'

        wordArray.Add("Coffee", WellDoneCoffee);
        wordArray.Add("Sun", WellDoneSun);
        wordArray.Add("Jumper", WellDoneJumper);
        wordArray.Add("Milk", WellDoneMilk);
        //hide continue button and replay button.
        ContinueButton.SetActive(false);
        ReplayButton.SetActive(false);
        //hide the images
        coffeeImage.SetActive(false);
        sunImage.SetActive(false);
        jumperImage.SetActive(false);
        milkImage.SetActive(false);
        //hide the speech bubbles
        coffeeSpeechTextBubble.SetActive(true);
        sunSpeechTextBubble.SetActive(true);
        jumperSpeechTextBubble.SetActive(true);
        milkSpeechTextBubble.SetActive(true);
        //hide the play audio button and show image button
        playAudioButton.SetActive(false);
        showImageButton.SetActive(false);




        //code inspired from h/ttps://www.youtube.com/watch?v=29vyEOgsW8s 
        recognitionOfWords = new KeywordRecognizer(wordArray.Keys.ToArray());
        recognitionOfWords.OnPhraseRecognized += RecognizedSpeech;
        recognitionOfWords.Start();

    }

    private void RecognizedSpeech(PhraseRecognizedEventArgs speech)
    {

        //code inspired from h/ttps://www.youtube.com/watch?v=29vyEOgsW8s 
        //allows the speech recongiser to recognise speech through invoke
        wordArray[speech.text].Invoke();
    }




    //function called if they say the word 'coffee'
    public void WellDoneCoffee()
    {
        //only say welldone if the first object is active on play.
        if (Obj01.active && distanceFromFirstObject < 2)
        {
            //set the welldone text to output WELLDONE!
            WellDoneText.text = "WELL DONE!";
            //clapping audio is played for a sense of reward.
            FindObjectOfType<AudioManager>().AudioStart("clapping");
        
            //allow the buttons 'continue' and 'restart' to appear.
            ContinueButton.SetActive(true);
            ReplayButton.SetActive(true);

            //increment the current score by 10 in level 3
            scoreforlevel3.currentscoreforlevel3 += 10;
            //set the play audio button to not be seen
            playAudioButton.SetActive(false);
            //increment the number of times said the word coffee by 1
            Obj1Level3Score.scorerepeatobj1L3 += 1;
            //set the 'show image' button to not be seen
            showImageButton.SetActive(false);
            ObjectiveData3.ObjectiveLevel3 += 1;
        }


    }
    //function called when the word sun is said correctly.
    public void WellDoneSun()
    {
        //only say welldone if the first object is active on play.
        if (Obj02.active && distanceFromSecondObject < 2)
        {
            //set the welldone text to output WELLDONE!
            WellDoneText.text = "WELL DONE!";
            //clapping audio is played for a sense of reward.
            FindObjectOfType<AudioManager>().AudioStart("clapping");
            
            //allow the buttons 'continue' and 'restart' to appear.
            ContinueButton.SetActive(true);
            ReplayButton.SetActive(true);
            //increment the current score in level 3 by 10
            scoreforlevel3.currentscoreforlevel3 += 10;
            // set the button to play the audio to false.
            playAudioButton.SetActive(false);
            //increment the number of times a particular objective was repeated by 1
            Obj2Level3Score.scorerepeatobj2L3 += 1;
            //set the button to show the image to false.
            showImageButton.SetActive(false);
            ObjectiveData3.Objective2Level3 += 1;
        }


    }

    //function called when the word jumper is said correctly
    public void WellDoneJumper()
    {
        //only say welldone if the first object is active on play.
        if (Obj03.active && distanceFromThirdObject < 2)
        {
            //set the welldone text to output WELLDONE!
            WellDoneText.text = "WELL DONE!";
            //clapping audio is played for a sense of reward.
            FindObjectOfType<AudioManager>().AudioStart("clapping");
           
            //allow the buttons 'continue' and 'restart' to appear.
            ContinueButton.SetActive(true);
            ReplayButton.SetActive(true);
            //increment the current score in level 3 by 10
            scoreforlevel3.currentscoreforlevel3 += 10;
            //show the button 'Play Audio'
            playAudioButton.SetActive(false);
            //increment the number of times repeated the objective by 1
            Obj3Level3Score.scorerepeatobj3L3 += 1;
            //set the button to 'show image' to false
            showImageButton.SetActive(false);
            ObjectiveData3.Objective3Level3 += 1;
        }


    }
    //function called when the user correctly repeats the word 'milk'
    public void WellDoneMilk()
    {
        //only say welldone if the first object is active on play.
        if (Obj04.active && distanceFromFourthObject < 2)
        {
            //set the welldone text to output WELLDONE!
            WellDoneText.text = "WELL DONE!";
            //clapping audio is played for a sense of reward.
            FindObjectOfType<AudioManager>().AudioStart("clapping");
          
            //allow the buttons 'continue' and 'restart' to appear.
            ContinueButton.SetActive(true);
            ReplayButton.SetActive(true);
            //set the current score for level 3 to be incremented by 10
            scoreforlevel3.currentscoreforlevel3 += 10;
            //set the audio of 'Play Audio' to be false
            playAudioButton.SetActive(false);
            //set the button 'show image' to be false
            showImageButton.SetActive(false);
            //increment the number of times a particular objective is repeated by 1.
            Obj4Level3Score.scorerepeatobj4L3 += 1;

            ObjectiveData3.Objective4Level3 += 1;
        }

    }


    private void updateitlevel3()
    {
        FindObjectOfType<ObjectiveText3>().returnText().text = ObjectiveData3.ObjectiveLevel3.ToString();

    }
    private void updateit2level3()
    {
        FindObjectOfType<ObjectiveText3>().returnText2().text = ObjectiveData3.Objective2Level3.ToString();

    }
    private void updateit3level3()
    {
        FindObjectOfType<ObjectiveText3>().returnText3().text = ObjectiveData3.Objective3Level3.ToString();

    }
    private void updateit4level3()
    {
        FindObjectOfType<ObjectiveText3>().returnText4().text = ObjectiveData3.Objective4Level3.ToString();

    }





    void FixedUpdate()
    {
        updateitlevel3();
        updateit2level3();
        updateit3level3();
        updateit4level3();

        //compute the distance between 4 objectives and the player moving.
        distanceFromFirstObject = Vector3.Distance(Player.transform.position, FindObjectOfType<objectiveController>().RetrieveObjective("CoffeeObjective").transform.position);
        distanceFromSecondObject = Vector3.Distance(Player.transform.position, FindObjectOfType<objectiveController>().RetrieveObjective("SunObjective").transform.position);
        distanceFromThirdObject = Vector3.Distance(Player.transform.position, FindObjectOfType<objectiveController>().RetrieveObjective("JumperObjective").transform.position);
        distanceFromFourthObject = Vector3.Distance(Player.transform.position, FindObjectOfType<objectiveController>().RetrieveObjective("MilkObjective").transform.position);
        //if the distance is less than two and the first object is still active(Seen on the screen).
        if (distanceFromFirstObject < 2 && FindObjectOfType<objectiveController>().RetrieveObjective("CoffeeObjective").active)
        {
            
            Text.text = "COFFEE";
            //set the text to the text used for the objective 'coffee'
            Text.text = FindObjectOfType<objectiveController>().RetrieveName("CoffeeObjective");

            
            Text.color = Color.black;
      
            //if the audio for coffee has not been played
            if (alreadyPlayedCoffeeAudio == false)
            {
                //present the user with the option to reveal the audio
                playAudioButton.SetActive(true);
            }
            //if the image for coffee has not been revealed
            if (alreadyShownCoffeeImage == false)
            {
                //present the user with the option to reveal the image
               showImageButton.SetActive(true);
            }

        }
        //if the distance for the second object is less than two and the objective is in the screen
        if (distanceFromSecondObject < 2 && FindObjectOfType<objectiveController>().RetrieveObjective("SunObjective").active)
        {
            Text.text = "SUN";
            Text.color = Color.yellow;
           //get the text for the sun objective
            Text.text = FindObjectOfType<objectiveController>().RetrieveName("SunObjective");
           //set the speech bubble to false
            sunSpeechTextBubble.SetActive(true);
            //if the audio for sun has not been played
            if (alreadyPlayedSunAudio == false)
            {
                //show the button to play it
                playAudioButton.SetActive(true);
            }
            //if the image has not been shown
            if (alreadyShownSunImage == false)
            {
                //show the button to display the image.
                showImageButton.SetActive(true);
            }

        }
        //if the distance for the third object is less than two and the objective is in the screen
        if (distanceFromThirdObject < 2 && FindObjectOfType<objectiveController>().RetrieveObjective("JumperObjective").active)
        {
            //set the text to the text of jumper.
            Text.text = FindObjectOfType<objectiveController>().RetrieveName("JumperObjective");
            Text.color = Color.red;
            //set the speech bubble for jumper to active
            jumperSpeechTextBubble.SetActive(true);
            //if the audio for jumper has not been played

            if (alreadyPlayedJumperAudio == false)
            {
                //show the button to play the audio
                playAudioButton.SetActive(true);
            }
            //if the image for jumper has not been shown

            if (alreadyShownJumperImage == false)
            {
                //show the button to display the image button

                showImageButton.SetActive(true);
            }
        }
        //if the distance for the 'milk' object is less than two and the objective is in the screen

        if (distanceFromFourthObject < 2 && FindObjectOfType<objectiveController>().RetrieveObjective("MilkObjective").active)
        {
            //set the text to be milk
            Text.text = FindObjectOfType<objectiveController>().RetrieveName("MilkObjective");
            Text.color = Color.white;
          
            //show speech bubble
            milkSpeechTextBubble.SetActive(true);

            //if not played the audio
            if (alreadyPlayedMilkAudio == false)
            {
                //show play audio button
                playAudioButton.SetActive(true);
            }
            //if not shown image
            if (alreadyShownMilkImage == false)
            {
                //show button to reveal image
                showImageButton.SetActive(true);
            }
        }


        //if the distance from the first object is greater than two and it is active
        if (distanceFromFirstObject > 2 && FindObjectOfType<objectiveController>().RetrieveObjective("CoffeeObjective").active && Text.text == "COFFEE")
        {
            //set the variable boolean of audio to false so that when they come back to the objective, the audio can be played.
            alreadyPlayedCoffeeAudio = false;
            playAudioButton.SetActive(false);
           //set the variable boolean of image to false so that when they come back to the objective, the image can be shown.
            alreadyShownCoffeeImage = false;
            showImageButton.SetActive(false);
            //hide button to continue,restart. Hide the text of well done.
            ContinueButton.SetActive(false);
            ReplayButton.SetActive(false);
            WellDoneText.text = "";


            Text.text = "";
            
            //hide image and stop playing the audio for the given objective.
            FindObjectOfType<objectiveController>().hideImage("CoffeeObjective");
            FindObjectOfType<objectiveController>().stopAudio("CoffeeObjective");


        }
        //when distance from second objective greater than 2 and the objective is still active
        if (distanceFromSecondObject > 2 && FindObjectOfType<objectiveController>().RetrieveObjective("SunObjective").active && Text.text == "SUN")
        {
            //set the variable boolean of audio to false so that when they come back to the objective, the audio can be played.
            alreadyPlayedSunAudio = false;
            playAudioButton.SetActive(false);
            //set the variable boolean of image to false so that when they come back to the objective, the image can be shown.
            alreadyShownSunImage = false;
            showImageButton.SetActive(false);
            Text.text = "";
 
            //hide the image and stop playing the audio for sun
            FindObjectOfType<objectiveController>().hideImage("SunObjective");
            FindObjectOfType<objectiveController>().stopAudio("SunObjective");
            //hide button to continue,restart. Hide the text of well done.
            ContinueButton.SetActive(false);
            ReplayButton.SetActive(false);
            WellDoneText.text = "";
        }
        //when distance from third objective greater than 2 and the objective is still active

        if (distanceFromThirdObject > 2 && FindObjectOfType<objectiveController>().RetrieveObjective("JumperObjective").active && Text.text == "JUMPER")
        {
            //set the variable boolean of audio to false so that when they come back to the objective, the audio can be played.
            alreadyPlayedJumperAudio = false;
            playAudioButton.SetActive(false);
            //set the variable boolean of image to false so that when they come back to the objective, the image can be shown.
            alreadyShownJumperImage = false;
            showImageButton.SetActive(false);
            Text.text = "";
            //hide image and stop playing he audio for jumper.
            FindObjectOfType<objectiveController>().hideImage("JumperObjective");
            FindObjectOfType<objectiveController>().stopAudio("JumperObjective");
        
            //hide button to continue,restart. Hide the text of well done.
            ContinueButton.SetActive(false);
            ReplayButton.SetActive(false);
            WellDoneText.text = "";

        }
        //when distance from fourth objective greater than 2 and the objective is still active

        if (distanceFromFourthObject > 2 && FindObjectOfType<objectiveController>().RetrieveObjective("MilkObjective").active && Text.text == "MILK")
        {
            //set the variable boolean of audio to false so that when they come back to the objective, the audio can be played.
            alreadyPlayedMilkAudio = false;
            playAudioButton.SetActive(false);
            //set the variable boolean of image to false so that when they come back to the objective, the image can be shown.
            alreadyShownMilkImage = false;
            showImageButton.SetActive(false);
            Text.text = "";
            //hide the image and stop playing the audio
            FindObjectOfType<objectiveController>().hideImage("MilkObjective");
            FindObjectOfType<objectiveController>().stopAudio("MilkObjective");
           
            //hide button to continue,restart. Hide the text of well done.
            ContinueButton.SetActive(false);
            ReplayButton.SetActive(false);
            WellDoneText.text = "";
        }

    }
    //function is called when the user wishes to play a specific audio
    public void PlayAudio()
    {
        //make sure that the audio voice for coffee has not played and the distance between the coffee objective less than 2
        if (alreadyPlayedCoffeeAudio == false && distanceFromFirstObject < 2)
        {
            //play the audio voice for coffee
            FindObjectOfType<objectiveController>().playAudio("CoffeeObjective");
            //set the audio button false so can't be replayed
            playAudioButton.SetActive(false);
            //this boolean statement ensures that it has played so prevents loops of audio.
            alreadyPlayedCoffeeAudio = true;

        }
        //make sure that the audio voice for sun has not played and the distance between the sun objective less than 2
        if (alreadyPlayedSunAudio == false && distanceFromSecondObject < 2)
        {
            //play the audio voice for sun
            FindObjectOfType<objectiveController>().playAudio("SunObjective");
            //set the audio button false so can't be replayed
            playAudioButton.SetActive(false);
            //this boolean statement ensures that it has played so prevents loops of audio.
            alreadyPlayedSunAudio = true;

        }
        //make sure that the audio voice for jumper has not played and the distance between the jumper objective less than 2
        if (alreadyPlayedJumperAudio == false && distanceFromThirdObject < 2)
        {   //play the audio voice for jumper
            FindObjectOfType<objectiveController>().playAudio("JumperObjective");
            //set the audio button false so can't be replayed
            playAudioButton.SetActive(false);
            //this boolean statement ensures that it has played so prevents loops of audio.
            alreadyPlayedJumperAudio = true;

        }
        //make sure that the audio voice for milk has not played and the distance between the milk objective less than 2
        if (alreadyPlayedMilkAudio == false && distanceFromFourthObject < 2)
        {
            //play the audio voice for milk
            FindObjectOfType<objectiveController>().playAudio("MilkObjective");
            //set the audio button false so can't be replayed
            playAudioButton.SetActive(false);
            //this boolean statement ensures that it has played so prevents loops of audio.
            alreadyPlayedMilkAudio = true;

        }
    }

    //called function when you want to show the image for the specific objective.
    public void ShowImage()
    {
        //make sure that the image has not been shown and distance between the first objective is less than 2
        if (alreadyShownCoffeeImage == false && distanceFromFirstObject < 2)
        {
            //show the image for the objective coffee
            FindObjectOfType<objectiveController>().showImage("CoffeeObjective");
            //set the show image button false so can't be replayed
            showImageButton.SetActive(false);
            //this boolean statement ensures that it has shown

            alreadyShownCoffeeImage = true;

        }
        //make sure that the image has not been shown and distance between the second objective is less than 2
        if (alreadyShownSunImage == false && distanceFromSecondObject < 2)
        {
            //show the image for the objective sun
            FindObjectOfType<objectiveController>().showImage("SunObjective");
            //set the show image button false so can't be replayed
            showImageButton.SetActive(false);
            //this boolean statement ensures that it has shown
            alreadyShownSunImage = true;

        }
        //make sure that the image has not been shown and distance between the third objective is less than 2

        if (alreadyShownJumperImage == false && distanceFromThirdObject < 2)
        {
            //show the image for the objective jumper
             FindObjectOfType<objectiveController>().showImage("JumperObjective");
            //set the show image button false so can't be replayed
            showImageButton.SetActive(false);
            //this boolean statement ensures that it has shown
            alreadyShownJumperImage = true;

        }
        //make sure that the image has not been shown and distance between the fourth objective is less than 2

        if (alreadyShownMilkImage == false && distanceFromFourthObject < 2)
        {
            //show the image for the objective milk
            FindObjectOfType<objectiveController>().showImage("MilkObjective");
            //set the show image button false so can't be replayed
            showImageButton.SetActive(false);
            //this boolean statement ensures that it has shown
            alreadyShownMilkImage = true;
        }
    }



    //this method removes the objective 
    public void NextObjective()
    {
        //for the coffee objective
        if (Text.text == "COFFEE")
        {
            //hide buttons like continue
            ContinueButton.SetActive(false);
            ReplayButton.SetActive(false);
           
            FindObjectOfType<objectiveController>().hideImage("CoffeeObjective");
            Player.transform.position = new Vector3((int)3.4, (int)0.1, -83);
            WellDoneText.text = "";

            Text.text = "";
            //hide play audio button and show image button
            playAudioButton.SetActive(false);
            showImageButton.SetActive(false);
      


        }
        //for the sun objective
        if (Text.text == "SUN")
        {
            //hide the buttons like continue
            ContinueButton.SetActive(false);
            ReplayButton.SetActive(false);
            //hide the speech bubble
            //hide image and animation
            FindObjectOfType<objectiveController>().hideImage("SunObjective");
            WellDoneText.text = "";

            
            Text.text = "";
            //hide play audio button and show image button
            playAudioButton.SetActive(false);
            showImageButton.SetActive(false);
    
        }
        //jumper objective
        if (Text.text == "JUMPER")
        {
            //continue button hidden
            ContinueButton.SetActive(false);
            //restart button hidden
            ReplayButton.SetActive(false);
            //jumper image hideen
            jumperImage.SetActive(false);
            //hide speech bubble
            //hide animation and object
          
            //set both well done text and normal text to nothing
            WellDoneText.text = "";
            Text.text = "";
            //hide the play audio and show image button
            playAudioButton.SetActive(false);
            showImageButton.SetActive(false);
    
        }
        //for the milk objective
        if (Text.text == "MILK")
        {
 

            //hide continue button
            ContinueButton.SetActive(false);
            //hide restart button
            ReplayButton.SetActive(false);
            //hide image
            milkImage.SetActive(false);
            WellDoneText.text = "";
            Text.text = "";
            //hide button to show image/play audio
            playAudioButton.SetActive(false);
            showImageButton.SetActive(false);
           
        }
    }
    //allows the user to play the word again.
    public void PlayAgain()
    {
        //for the coffee objective
        if (Text.text == "COFFEE")
        {
            //set the continue button and restart button to false (HIDDEN)
            ContinueButton.SetActive(false);
            ReplayButton.SetActive(false);
            //show speech bubble
            coffeeSpeechTextBubble.SetActive(true);
            WellDoneText.text = "";
            //this will mute the clapping volume when the user restarts. This is to ensure the 'coffee' audio is not played whilst the 'clapping' audio is still playing
            FindObjectOfType<AudioManager>().Mute("clapping");
            
            Text.text = "COFFEE";
            //set alreadyplayed back to false therefore audio can be played again and the image can be shown again
            alreadyPlayedCoffeeAudio = false;
            alreadyShownCoffeeImage = false;
            //hide image of the objective for coffee
            FindObjectOfType<objectiveController>().hideImage("CoffeeObjective");

        }

        //for the sun objective
        if (Text.text == "SUN")
        {
            //hide the button to continue to next objective
            ContinueButton.SetActive(false);
            //hide button to replay objective
            ReplayButton.SetActive(false);
            //hide the speech bubble
            sunSpeechTextBubble.SetActive(true);
            WellDoneText.text = "";
            //this will mute the clapping volume when the user restarts. This is to ensure the 'sun' audio is not played whilst the 'clapping' audio is still playing
            FindObjectOfType<AudioManager>().Mute("clapping");
            Text.text = "SUN";
            Text.color = Color.yellow;
            //hide the image for sun
            FindObjectOfType<objectiveController>().hideImage("SunObjective");
            //set alreadyplayed back to false therefore audio can be played again and the image can be shown again
            alreadyPlayedSunAudio = false;
            alreadyShownSunImage = false;

        }
        //for the jumper image
        if (Text.text == "JUMPER")
        {
            //hide the button to continue
            ContinueButton.SetActive(false);
            //hide the button to replay
            ReplayButton.SetActive(false);
            //hide image
            jumperImage.SetActive(true);
            //hide speech bubble text
            jumperSpeechTextBubble.SetActive(true);
            WellDoneText.text = "";
            //this will mute the clapping volume when the user restarts. This is to ensure the 'jumper' audio is not played whilst the 'clapping' audio is still playings
            FindObjectOfType<AudioManager>().Mute("clapping");
            Text.text = "JUMPER";
            Text.color = Color.red;
            //set alreadyplayed back to false therefore audio can be played again as well as the image to be shown again.
            alreadyPlayedJumperAudio = false;
            alreadyShownJumperImage = false;
            //hide jumper image
            FindObjectOfType<objectiveController>().hideImage("JumperObjective");


        }
        //for the milk objective
        if (Text.text == "MILK")
        {
            //hide button to continue
            ContinueButton.SetActive(false);
            //hide the replay button
            ReplayButton.SetActive(false);
            milkImage.SetActive(true);
            //hide speech bubble
            milkSpeechTextBubble.SetActive(true);
            WellDoneText.text = "";
            //this will mute the clapping volume when the user restarts. This is to ensure the 'milk' audio is not played whilst the 'clapping' audio is still playing
            FindObjectOfType<AudioManager>().Mute("clapping");
            //set the text back to SAY HELLO
            Text.text = "MILK";
            Text.color = Color.white;
            //set alreadyplayed back to false therefore audio can be played again as well as showing the image for milk
            alreadyPlayedMilkAudio = false;
            alreadyShownMilkImage = false;
            //hide milk image
            FindObjectOfType<objectiveController>().hideImage("MilkObjective");


        }


    }
}



