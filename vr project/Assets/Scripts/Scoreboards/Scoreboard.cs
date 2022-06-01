using System.IO;
using UnityEngine;
using UnityEngine.UI;

namespace HYK.Scoreboards
{
    public class Scoreboard : MonoBehaviour
    {
         public Button yourButton;
 public GameObject stage4song;
public AudioSource stage4songe;
public Text entryNameA;
 public GameObject sendtext;
public Text entryScoreA;
public string entryNameB;
public string entryNameAtext;
public string entryScoreB;
public double entryScoreC;

        [SerializeField] private int maxScoreboardEntries = 5;
        [SerializeField] private Transform highscoresHolderTransform = null;
        [SerializeField] private GameObject scoreboardEntryObject = null;

        [Header("Test")]
        [SerializeField] private string testEntryName = "New Name";
        [SerializeField] private double testEntryScore = 0;

        private string SavePath => $"{Application.persistentDataPath}/highscores.json";

        private void Start()
        {
        Button btn = yourButton.GetComponent<Button>();
		btn.onClick.AddListener(AddTestEntry);
         ScoreboardSaveData savedScores = GetSavedScores();
    
            UpdateUI(savedScores);

            SaveScores(savedScores);
        }


         void AddTestEntry()
        {
             stage4songe = stage4song.GetComponent<AudioSource>();
 stage4songe.Play();
       yourButton.interactable  = false;
         sendtext.SetActive(true);
   entryNameB = entryNameA.text;
        entryNameAtext = entryScoreA.text;
        entryScoreB = entryScoreA.text;

            AddEntry(new ScoreboardEntryData()
            {
                entryName =  entryNameB,
                entryScore = entryScoreB
            });
        }

        void EnterPlayer()
        {

        }

        public void AddEntry(ScoreboardEntryData scoreboardEntryData)
        {
            ScoreboardSaveData savedScores = GetSavedScores();

            bool scoreAdded = false;

            
            for (int i = 0; i < savedScores.highscores.Count; i++)
            {
                    savedScores.highscores.Insert(i, scoreboardEntryData);
                    scoreAdded = true;
                    break;
                
            }

            
            if (!scoreAdded && savedScores.highscores.Count < maxScoreboardEntries)
            {
                savedScores.highscores.Add(scoreboardEntryData);
            }

          
            if (savedScores.highscores.Count > maxScoreboardEntries)
            {
                savedScores.highscores.RemoveRange(maxScoreboardEntries, savedScores.highscores.Count - maxScoreboardEntries);
            }

            UpdateUI(savedScores);

            SaveScores(savedScores);
        }

        private void UpdateUI(ScoreboardSaveData savedScores)
        {
            foreach (Transform child in highscoresHolderTransform)
            {
                Destroy(child.gameObject);
            }

            foreach (ScoreboardEntryData highscore in savedScores.highscores)
            {
                Instantiate(scoreboardEntryObject, highscoresHolderTransform).GetComponent<ScoreboardEntryUI>().Initialise(highscore);
            }
        }

        private ScoreboardSaveData GetSavedScores()
        {
            if (!File.Exists(SavePath))
            {
                File.Create(SavePath).Dispose();
                return new ScoreboardSaveData();
            }

            using (StreamReader stream = new StreamReader(SavePath))
            {
                string json = stream.ReadToEnd();

                return JsonUtility.FromJson<ScoreboardSaveData>(json);
            }
        }

        private void SaveScores(ScoreboardSaveData scoreboardSaveData)
        {
            using (StreamWriter stream = new StreamWriter(SavePath))
            {
                string json = JsonUtility.ToJson(scoreboardSaveData, true);
                stream.Write(json);
            }
        }
    }
}
