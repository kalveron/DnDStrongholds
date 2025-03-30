namespace SecMon.Guild
{
    [System.Serializable]
    public class Clue
    {
        public ClueAttribute Attribute { get; private set; }
        public ClueSource Source { get; private set; }
        public ClueResult Result { get; private set; }
        public int Detail { get; private set; }
        public Security Security { get; private set; }

        public Clue(ClueAttribute attribute, ClueSource source, ClueResult result, int detail, Security security)
        {
            Attribute = attribute;
            Source = source;
            Result = result;
            Detail = detail;
            Security = security;
        }

        //Calculated from Security and Knowledge
        public bool IsLocated()
        {
            return false;
        }

        //Calculated from the Knowledge Level of the Location or Stronghold where the clue is hidden
        public int GetKnowledge()
        {
            return 0;
        }
    }
}