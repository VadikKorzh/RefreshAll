using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace VocabularyServiceLib.DataContracts
{
    public class ThesaurusUnit
    {
        public String BaseWord { get; set; }

        public List<String> Synonyms { get; set; }

        public List<String> Antonyms { get; set; }
    }
}
