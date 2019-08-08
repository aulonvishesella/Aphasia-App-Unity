
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Windows.Speech;
using System.Linq;
using System;
using UnityEngine.Audio;

public class Level1Controller : MonoBehaviour
{
    //decleration of many game objects
    public Rigidbody rb;
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
    private KeywordRecognizer recongnitionOfWords;
    private Dictionary<string, Action> arrayOfWOrds = new Dictionary<string, Action>();
    public float time = 5;
    public Text WellDoneText;
    public GameObject ContinueButton;
    public GameObject ReplayButton;
    public GameObject coffeeImage;
    public GameObject sunImage;
    public GameObject jumperImage;
    public GameObject milkImage;
    public bool alreadyPlayedCoffee = false;
    public bool alreadyPlayedSun = false;
    public bool alreadyPlayedJumper = false;
    public bool alreadyPlayedMilk = false;
    public GameObject coffeeSpeechTextBubble;
    public GameObject sunSpeechTextBubble;
    public GameObject jumperSpeechTextBubble;
    public GameObject milkSpeechTextBubble;

    public ObjectiveData ObjectiveData { get; private set; }

    private void OnEnable()
    {
        ObjectiveData = ObjectivePersistence.LoadData();

    }

    private void OnDisable()
    {
        ObjectivePersistence.SaveData(this);
    }





    // Use this for initialization
    void Start()
    {
        //add to the array of words, e.g. Coffee. If they say coffee correctly for example, call the function 'WellDoneCoffee'
        arrayOfWOrds.Add("Coffee", WellDoneCoffee);
        arrayOfWOrds.Add("Sun", WellDoneSun);
        arrayOfWOrds.Add("Jumper", WellDoneJumper);
        arrayOfWOrds.Add("Milk", WellDoneMilk);
        //hide continue button and replay button.
        ContinueButton.SetActive(false);
        ReplayButton.SetActive(false);
        //hide all the images at the start
        coffeeImage.SetActive(false);
        sunImage.SetActive(false);
        jumperImage.SetActive(false);
        milkImage.SetActive(false);
        coffeeSpeechTextBubble.SetActive(true);
        sunSpeechTextBubble.SetActive(true);
        jumperSpeechTextBubble.SetActive(true);
        milkSpeechTextBubble.SetActive(true);



        //code inspired from h/ttps://www.youtube.com/watch?v=29vyEOgsW8s 
        recongnitionOfWords = new KeywordRecognizer(arrayOfWOrds.Keys.ToArray());
        recongnitionOfWords.OnPhraseRecognized += RecognizedSpeech;
        recongnitionOfWords.Start();

    }

    //code inspired from h/ttps://www.youtube.com/watch?v=29vyEOgsW8s 
    private void RecognizedSpeech(PhraseRecognizedEventArgs speech)
    {
        //this allows the speech recongiser to actually recognise speech from an invoke.
        arrayOfWOrds[speech.text].Invoke();
    }




    //function called if they say the word coffee correctly
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

            //Call the script scoreboard, if they say the correct word, increase the score value by 10
            ScoreBoard.theCurrentScore += 10;
            //call the script 'obj1score' and increase value by 1
            obj1score.scorerepeatobj1 += 1;


            ObjectiveData.Objective += 1;
        }


    }
    //function called if they say the word sun correctly
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
            //Call the script scoreboard, if they say the correct word, increase the score value by 10
            ScoreBoard.theCurrentScore += 10;
            //call the script 'repeatobj2level1' and increase value by 1
            repeatobj2level1.scorerepeatobj2 += 1;
            ObjectiveData.Objective2 += 1;
        }


    }

    //function called if they say the word jumper correctly
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
            //Call the script 'ScoreBoard', if they say the correct word, increase the score value by 10
            ScoreBoard.theCurrentScore += 10;
            //call the script 'repeatobj3score' and increase value by 1
            obj3score.scorerepeatobj3 += 1;
            ObjectiveData.Objective3 += 1;

        }


    }
    //function called if they say the word milk correctly
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
            //Call the script 'ScoreBoard', if they say the correct word, increase the score value by 10
            ScoreBoard.theCurrentScore += 10;
            //call the script 'obj4score' and increase value by 1
            obj4score.scorerepeatobj4 += 1;
            ObjectiveData.Objective4 += 1;

        }


    }

   private void updateit()
    {
        FindObjectOfType<ObjectieText>().returnText().text = ObjectiveData.Objective.ToString();
    
    }

    private void update2()
    {
        FindObjectOfType<ObjectieText>().returnText2().text = ObjectiveData.Objective2.ToString();
    }

    private void update3()
    {
        FindObjectOfType<ObjectieText>().returnText3().text = ObjectiveData.Objective3.ToString();
    }
    private void update4()
    {
        FindObjectOfType<ObjectieText>().returnText4().text = ObjectiveData.Objective4.ToString();
    }


    void FixedUpdate()
    {

        
        updateit();
        update2();
        update3();
        update4();
        //calulates the distance between an objectice and a player
        distanceFromFirstObject = Vector3.Distance(Player.transform.position, FindObjectOfType<objectiveController>().RetrieveObjective("CoffeeObjective").transform.position);
        distanceFromSecondObject = Vector3.Distance(Player.transform.position, FindObjectOfType<objectiveController>().RetrieveObjective("SunObjective").transform.position);
        distanceFromThirdObject = Vector3.Distance(Player.transform.position, FindObjectOfType<objectiveController>().RetrieveObjective("JumperObjective").transform.position);
        distanceFromFourthObject = Vector3.Distance(Player.transform.position, FindObjectOfType<objectiveController>().RetrieveObjective("MilkObjective").transform.position);
        //if the distance is less than two and the first object is still active(Seen on the screen).
        if (distanceFromFirstObject < 2 && FindObjectOfType<objectiveController>().RetrieveObjective("CoffeeObjective").active)
        {
            
            //apply the text coffee to show
            Text.text = "COFFEE";
            Text.text = FindObjectOfType<objectiveController>().RetrieveName("CoffeeObjective");
            //show speech bubble for coffee
            coffeeSpeechTextBubble.SetActive(true);
            Text.color = Color.black;
            FindObjectOfType<objectiveController>().showImage("CoffeeObjective");
            //if the user has not aimated -> animate.
          //  if (animationcomplete == false)
            //{
              //  FindObjectOfType<LonnyTalk>().LonnySpeak();
               // animationcomplete = true;
            //}
          

                      //make sure that the audio voice has not played
            if (alreadyPlayedCoffee == false)
            {
                //play the audio voice Coffee
                FindObjectOfType<objectiveController>().playAudio("CoffeeObjective");

                //this boolean statement ensures that it has played so prevents loops of audio.
                alreadyPlayedCoffee = true;

            }
        }
        //if distance between the sun objective and player is less than 2 and the objective is active
        if (distanceFromSecondObject < 2 && FindObjectOfType<objectiveController>().RetrieveObjective("SunObjective").active)
        {

            //text set to sun and is colour yellow
            Text.text = "SUN";
            Text.color = Color.yellow;
            Text.text = FindObjectOfType<objectiveController>().RetrieveName("SunObjective");

            //show image of the sun
            FindObjectOfType<objectiveController>().showImage("SunObjective");
            //show the speech bubble text
            sunSpeechTextBubble.SetActive(true);


            //make sure that the audio voice has not played
            if (alreadyPlayedSun == false)
            {
                //play the audio voice SUN
                FindObjectOfType<objectiveController>().playAudio("SunObjective");
                //sun audio has now been played - prevents looping of audio
                alreadyPlayedSun = true;

            }
        }
        //if distance between the jumper objective and player is less than 2 and the objective is active
        if (distanceFromThirdObject < 2 && FindObjectOfType<objectiveController>().RetrieveObjective("JumperObjective").active)
        {
            //retrieve the text to be the jumper objective
            Text.text = FindObjectOfType<objectiveController>().RetrieveName("JumperObjective");
            Text.color = Color.red;
            // show the image for the jumper objective
            FindObjectOfType<objectiveController>().showImage("JumperObjective");
            //set the jumper speech bubble to appear to the user
            jumperSpeechTextBubble.SetActive(true);
            Text.text = "JUMPER";

            //make sure that the audio voice has not played
            if (alreadyPlayedJumper == false)
            {
                //play the audio voice HELLO 
                FindObjectOfType<objectiveController>().playAudio("JumperObjective");

                //the voice has now been played - prevent looping of audio
                alreadyPlayedJumper = true;

            }
        }
        //if distance between the milk objective and player is less than 2 and the objective is active

        if (distanceFromFourthObject < 2 && FindObjectOfType<objectiveController>().RetrieveObjective("MilkObjective").active)
        {
            Text.text = "MILK";
            //all the properties for the milk appears (text,image
            Text.text = FindObjectOfType<objectiveController>().RetrieveName("MilkObjective");
            Text.color = Color.white;
            FindObjectOfType<objectiveController>().showImage("MilkObjective");
            milkSpeechTextBubble.SetActive(true);

            //make sure that the audio voice has not played
            if (alreadyPlayedMilk == false)
            {
                //play the audio voice for milk
                FindObjectOfType<objectiveController>().playAudio("MilkObjective");
                //set this now to true so does not play in a loop
                alreadyPlayedMilk = true;

            }
        }


        //if they wallk away from the objective
        if (distanceFromFirstObject > 2 && FindObjectOfType<objectiveController>().RetrieveObjective("CoffeeObjective").active && Text.text == "COFFEE")
        {
            //set this to false so when they go back to the objective they can hear the audio again
            alreadyPlayedCoffee = false;
            //text becomes blank as they are not in the objective
            Text.text = "";
            //hide the image and stop the audio
            FindObjectOfType<objectiveController>().hideImage("CoffeeObjective");
            FindObjectOfType<objectiveController>().stopAudio("CoffeeObjective");
            //hide the continue,replay button incase they move away after completing the objective. Make the well done text to empty
            ContinueButton.SetActive(false);
            ReplayButton.SetActive(false);
            WellDoneText.text = "";
            //animationcomplete = false;


        }
        //if they wallk away from the objective
        if (distanceFromSecondObject > 2 && FindObjectOfType<objectiveController>().RetrieveObjective("SunObjective").active && Text.text == "SUN")
        {
            //set this to false so when they go back to the objective they can hear the audio again
            alreadyPlayedSun = false;
            Text.text = "";
            //hide the image and stop the audio
            FindObjectOfType<objectiveController>().hideImage("SunObjective");
            FindObjectOfType<objectiveController>().stopAudio("SunObjective");
            //hide the continue,replay button incase they move away after completing the objective. Make the well done text to empty
            ContinueButton.SetActive(false);
            ReplayButton.SetActive(false);
            WellDoneText.text = "";


        }
        //if they wallk away from the objective
        if (distanceFromThirdObject > 2 && FindObjectOfType<objectiveController>().RetrieveObjective("JumperObjective").active && Text.text == "JUMPER")
        {
            //set this to false so when they go back to the objective they can hear the audio again
            alreadyPlayedJumper = false;
            Text.text = "";
            //hide the image and stop the audio from playing
            FindObjectOfType<objectiveController>().hideImage("JumperObjective");
            FindObjectOfType<objectiveController>().stopAudio("JumperObjective");
           
            //hide the continue button and restart button. make the well done text to nothing.
            ContinueButton.SetActive(false);
            ReplayButton.SetActive(false);
            WellDoneText.text = "";

        }
        //if they wallk away from the objective

        if (distanceFromFourthObject > 2 && FindObjectOfType<objectiveController>().RetrieveObjective("MilkObjective").active && Text.text == "MILK")
        {
            //set this to false so when they go back to the objective they can hear the audio again

            alreadyPlayedMilk = false;
            Text.text = "";
            //hide the image and stop the audio from playing
            FindObjectOfType<objectiveController>().hideImage("MilkObjective");
            FindObjectOfType<objectiveController>().stopAudio("MilkObjective");
        
            //hide the continue button and restart button. make the well done text to nothing.
            ContinueButton.SetActive(false);
            ReplayButton.SetActive(false);
            WellDoneText.text = "";
        }

    }


    //this method removes the objective. This is called when they click on 'continue' button.
    public void NextObjective()
    {
        //checks that the word is for the 'COFFEE' to ensure the correct properties are hidden
        if (Text.text == "COFFEE")
        {
            //hide continue button and replay button
            ContinueButton.SetActive(false);
            ReplayButton.SetActive(false);
            WellDoneText.text = "";
            //image,object and animation are all hidden for the coffee.
            FindObjectOfType<objectiveController>().hideImage("CoffeeObjective");
            //nudge the player away from the objective
            Player.transform.position = new Vector3(3, 2, 0);
           // animationcomplete = false;
            alreadyPlayedCoffee = false;
            Text.text = "";


        }


        //checks that the word is for the 'SUN' so the correct properties are hidden.
        if (Text.text == "SUN")
        {
            //continue and restart button is set to false
            ContinueButton.SetActive(false);
            ReplayButton.SetActive(false);
           
            //image,object and animation are all hidden for the sun.
            FindObjectOfType<objectiveController>().hideImage("SunObjective");
            //nudge the player away from the objectivw
            Player.transform.position = new Vector3(17, 2, 42);
            WellDoneText.text = "";
            Text.text = "";


        }
        //checks that the word is for the 'JUMPER', so correct properties are hidden.
        if (Text.text == "JUMPER")
        {
            //continue and restart button is hidden
            ContinueButton.SetActive(false);
            ReplayButton.SetActive(false);


            //image,object and animation are all hidden for the jumper.

            Player.transform.position = new Vector3(3, 2, 0);

            FindObjectOfType<objectiveController>().hideImage("JumperObjective");
            WellDoneText.text = "";

            Text.text = "";

        }
        //checks that the word is for the 'MILK', so correct properties are hidden.
        if (Text.text == "MILK")
        {
            //image,object and animation are all hidden for the jumper.
            FindObjectOfType<objectiveController>().hideImage("MilkObjective");
            //nudge player away from objective
            Player.transform.position = new Vector3(3, 2, 0);

            //continue button hidden
            ContinueButton.SetActive(false);
            //restart button is hidden
            ReplayButton.SetActive(false);
            milkImage.SetActive(false);
            WellDoneText.text = "";
            Text.text = "";

        }
    }
    //allows the user to play the word again.
    public void PlayAgain()
    {
        //if the word is coffee
        if (Text.text == "COFFEE")
        {
            //set the continue and replay button back to false
            ContinueButton.SetActive(false);
            ReplayButton.SetActive(false);
            //show the image of coffee again
            FindObjectOfType<objectiveController>().showImage("CoffeeObjective");
            coffeeSpeechTextBubble.SetActive(true);
            WellDoneText.text = "";
            //play the voice again
            FindObjectOfType<objectiveController>().playAudio("CoffeeObjective");
            //this will mute the clapping volume when the user restarts. This is to ensure the 'coffee' audio is not played whilst the 'clapping' audio is still playing
            FindObjectOfType<AudioManager>().Mute("clapping");
            //set the text back to COFFEE
            Text.text = "COFFEE";
            //set alreadyplayed back to false therefore audio can be played again.
            alreadyPlayedCoffee = false;
            FindObjectOfType<LonnyTalk>().LonnySpeak();
            

           
        }

        //if the text is sun
        if (Text.text == "SUN")
        {
            //continue and restart button set to false
            ContinueButton.SetActive(false);
            ReplayButton.SetActive(false);
            //sun speech text bubble is set back to true
            sunSpeechTextBubble.SetActive(true);
            //the image for the sun is showed
            FindObjectOfType<objectiveController>().showImage("SunObjective");
            WellDoneText.text = "";
            //play the voice again
            FindObjectOfType<objectiveController>().playAudio("SunObjective");
            //this will mute the clapping volume when the user restarts. This is to ensure the 'sun' audio is not played whilst the 'clapping' audio is still playing
            FindObjectOfType<AudioManager>().Mute("clapping");

            Text.text = "SUN";
            Text.color = Color.yellow;

            //set alreadyplayed back to false therefore audio can be played again.
            alreadyPlayedSun = false;

          
        }
        //if it is in the jumper objective
        if (Text.text == "JUMPER")
        {
            //continue button and restart button is set to false
            ContinueButton.SetActive(false);
            ReplayButton.SetActive(false);
            jumperImage.SetActive(true);
            //jumper speech text bubble set to false
            jumperSpeechTextBubble.SetActive(true);
            WellDoneText.text = "";
            //show image for the jumper
            FindObjectOfType<objectiveController>().showImage("JumperObjective");
            //play the voice again for the word 'jumper'

            FindObjectOfType<objectiveController>().playAudio("JumperObjective");
            //this will mute the clapping volume when the user restarts. This is to ensure the 'milk' audio is not played whilst the 'clapping' audio is still playings
            FindObjectOfType<AudioManager>().Mute("clapping");

            Text.text = "JUMPER";
            Text.color = Color.red;
            //set alreadyplayed back to false therefore audio can be played again.
            alreadyPlayedJumper = false;


        }
        //if it is milk
        if (Text.text == "MILK")
        {
            //continue button and restart button is set to false
            ContinueButton.SetActive(false);
            ReplayButton.SetActive(false);
            milkImage.SetActive(true);
            milkSpeechTextBubble.SetActive(true);
            WellDoneText.text = "";
            //show the image again
            FindObjectOfType<objectiveController>().showImage("MilkObjective");
            //play the audio again
            FindObjectOfType<objectiveController>().playAudio("MilkObjective");
            //this will mute the clapping volume when the user restarts. This is to ensure the 'milk' audio is not played whilst the 'clapping' audio is still playing
            FindObjectOfType<AudioManager>().Mute("clapping");
            Text.text = "MILK";
            Text.color = Color.white;
            //set alreadyplayed back to false therefore audio can be played again.
            alreadyPlayedMilk = false;


        }

    }
}
