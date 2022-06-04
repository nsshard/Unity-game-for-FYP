using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace HYK.Scoreboards
{
    public class ScoreboardEntryUI : MonoBehaviour
    {
        [SerializeField] private Text entryNameText = null;
        [SerializeField] private Text entryScoreText = null;
        [SerializeField] private Text entryGradeText = null;
        [SerializeField] private Text entryAddText = null;
        [SerializeField] private Text entryMinusText = null;
        [SerializeField] private Text entryMultiplyText = null;
        [SerializeField] private Text entryDivisionText = null;
        public void Initialise(ScoreboardEntryData scoreboardEntryData)
        {
            entryNameText.text = scoreboardEntryData.entryName;
            entryScoreText.text = scoreboardEntryData.entryScore.ToString();
             entryGradeText.text = scoreboardEntryData.entryGrade.ToString();
              entryAddText.text = scoreboardEntryData.entryAdd.ToString();
               entryMinusText.text = scoreboardEntryData.entryMinus.ToString();
                entryMultiplyText.text = scoreboardEntryData.entryMultiply.ToString();
                   entryDivisionText.text = scoreboardEntryData.entryDivision.ToString();
        }
    }
}
