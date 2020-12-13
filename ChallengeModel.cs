using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DicteeSChallengeCreator
{
    class ChallengeModel
    {
        public List<ExerciceModel> Exs { get; set; }
        public string Language { get; set; } // AR, EN, FR

        // Challenge logic
        public bool PassAlways { get; set; } // TRUE: Pass Always / FALSE: Pass only for correct answer
        public bool EnableScore { get; set; }
        public bool EnableTimer { get; set; }
        public bool ScoreWithTiming { get; set; } // When TRUE: the time left in timer for each exercice is added to the score
        public bool EnableCorrection { get; set; } // Show correction for each exercice when unanswered
        public int AttemptsLimit { get; set; } // Max number of attempts allowed per exercice
        public bool ShowKeyboard { get; set; } // TRUE: Show the answer letters buttons mixed with noise
    }
}
