using System.Collections.Generic;

namespace SecMon.Guild
{
    [System.Serializable]
    public class Secret
    {
        public string Name { get; private set; }
        public SecretAttribute Attribute { get; private set; }
        public Security Security { get; private set; }
        public float Knowledge { get; private set; }
        public List<GeographicLocation> RemainingLocations => new List<GeographicLocation>(_remainingLocations);

        private List<GeographicLocation> _remainingLocations;

        public Secret(string name, SecretAttribute attribute, Security security, float knowlege, List<GeographicLocation> locations)
        {
            Name = name;
            Attribute = attribute;
            Security = security;
            Knowledge = knowlege;
            _remainingLocations = locations;
        }

        public void AlterAttribute(SecretAttribute attribute)
        {
            Attribute = attribute;
        }

        public void AlterSecurityLevel(Security security)
        {
            Security = security;
        }

        public void UpdateLocations(GeographicLocation location, bool add)
        {
            if (add && !_remainingLocations.Contains(location))
            {
                _remainingLocations.Add(location);
            }
            else
            {
                _remainingLocations.Remove(location);
            }
        }
    }
}