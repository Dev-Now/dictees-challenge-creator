using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DicteeSChallengeCreator
{
    class ExerciceModel
    {
        public string Answer { get; set; }
        public string Question { get; set; } // path to audio file
        public string Noise { get; set; } // Noise pattern
        public string Hint { get; set; } // path to hint image file
        public string AnswerIntro { get; set; } // Introductory text showing before answer: "This is a "[...ANSWER_HERE...]

        public int Score { get; set; } // score points given for correct answer
        public int Time { get; set; } // Max time in seconds to enter correct answer
        public int AttemptsLimit { get; set; } // Max number of attempts allowed
        public bool ShowKeyboard { get; set; } // TRUE: Show the answer letters buttons mixed with noise
    }
}
