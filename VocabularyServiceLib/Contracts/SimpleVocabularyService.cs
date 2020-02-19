using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VocabularyServiceLib.DataContracts;

namespace VocabularyServiceLib.Contracts
{
    public class SimpleVocabularyService : IVocabularyService
    {
        private static readonly List<ThesaurusUnit> _wordInfoList = new List<ThesaurusUnit>();

        public ThesaurusUnit GetWordInfo(string word)
        {
            return _wordInfoList.FirstOrDefault(wi => wi.BaseWord.Equals(word, StringComparison.OrdinalIgnoreCase));
        }

        public void AddAntonym(string baseWord, string antonym)
        {
            if (_wordInfoList.Any(wi => wi.BaseWord.Equals(baseWord, StringComparison.OrdinalIgnoreCase)))
            {
                _wordInfoList.First(wi => wi.BaseWord.Equals(baseWord, StringComparison.OrdinalIgnoreCase)).Antonyms.Add(antonym);
            }
            else
            {
                _wordInfoList.Add(
                    new ThesaurusUnit
                    {
                        BaseWord = baseWord,
                        Synonyms = new List<string>(),
                        Antonyms = new List<string> { antonym }
                    }
                    );
            }
        }

        public void AddSynonym(string baseWord, string synonym)
        {
            if (_wordInfoList.Any(wi => wi.BaseWord.Equals(baseWord, StringComparison.OrdinalIgnoreCase)))
            {
                _wordInfoList.First(wi => wi.BaseWord.Equals(baseWord, StringComparison.OrdinalIgnoreCase)).Synonyms.Add(synonym);
            }
            else
            {
                _wordInfoList.Add(
                    new ThesaurusUnit
                    {
                        BaseWord = baseWord,
                        Synonyms = new List<string> { synonym },
                        Antonyms = new List<string>()
                    }
                    );
            }
        }
    }
}
