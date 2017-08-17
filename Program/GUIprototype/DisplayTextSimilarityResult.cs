using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUIprototype
{
    class DisplayTextSimilarityResult
    {

        public string resultIsFalse;
        public string resultIsTrue;
        
        // Method for showing the correct information to the user when both similarity methods have been chosen. 
        public string BothSimilaritymethods(decimal jaccardFalseValue, decimal jaccardTrueValue, decimal cosineFalseValue, decimal cosineTrueValue)
        {
            string resultFalse = "True";

            if (jaccardFalseValue > jaccardTrueValue)
                resultFalse = "False";

            if (cosineFalseValue > cosineTrueValue)
                resultFalse = "False";

            return "Both similarity methods has been run, and the result is: " + resultFalse;
        }

        // Method for showing the correct information to the user when the jaccard similarity method has been chosen. 

        public void JaccardSimilaritymethod(decimal jaccardFalseValue, decimal jaccardTrueValue)
        {
            if (jaccardFalseValue >= (15.6m / 1000m))
                resultIsFalse = "Almost identical";
            else if (jaccardFalseValue >= (2.5m / 1000m))
                resultIsFalse = "Partially  identical";
            else
                resultIsFalse = "Completly different";

            if (jaccardTrueValue >= (15.6m / 1000m))
                resultIsTrue = "Almost identical";
            else if (jaccardTrueValue >= (2.5m / 1000m))
                resultIsTrue = "Partially  identical";
            else
                resultIsTrue = "Completly different";
        }

        // Method for showing the correct information to the user when the cosine similarity method has been chosen. 
        public void CosineSimilaritymethod(decimal cosineFalseValue, decimal cosineTrueValue)
        {
            if (cosineFalseValue >= 51)
                resultIsFalse = "Almost identical";
            else if (cosineFalseValue >= 25)
                resultIsFalse = "Partially  identical";
            else
                resultIsFalse = "Completly different";

            if (cosineTrueValue >= 51)
                resultIsTrue = "Almost identical";
            else if (cosineTrueValue >= 25)
                resultIsTrue = "Partially  identical";
            else
                resultIsTrue = "Completly different";
        }
    }
}
