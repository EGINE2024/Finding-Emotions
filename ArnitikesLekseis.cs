using System.Collections.Generic;

namespace EvresiSunais8imatwn
{
    public class ArnitikesLekseisLists
    {
        public List<string> ArnitikesLekseis { get; }

        /// <summary>
        /// Λίστα με τις αρνητικές λέξεις
        /// </summary>
        public ArnitikesLekseisLists()
        {
            ArnitikesLekseis = new List<string> { "όχι", "μίσος", "απελπισία" };
        }
    }
}
