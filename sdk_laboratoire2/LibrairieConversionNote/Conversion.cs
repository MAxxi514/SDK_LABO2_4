///« ALPHA» => Note vers alphabétique

﻿namespace LibrairieConversionNote
{
    public class ConversionAlphabetiqueToNote
    {
        public string Transformer(string Alpha) { 
        
if (Alpha == "LA")

            {
             return "A"; 
            }
if (Alpha == "SI")
            {
                return "B";
            }
if (Alpha == "DO")
            {
                return "C";
            }
if (Alpha == "RE")
            {
                return "D";
            }
if (Alpha == "MI")
            {
                return "E";
            }
if (Alpha == "FA")
            {
                return "F";
            }
if (Alpha == "SOL")
            {
                return "G";
            }
else return "Erreur, entrer une Note LA,SI,DO,RE,MI,FA ou SOL";
        }
    }
}
