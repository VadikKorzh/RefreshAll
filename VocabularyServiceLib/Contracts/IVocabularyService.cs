using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using VocabularyServiceLib.DataContracts;

namespace VocabularyServiceLib.Contracts
{
    [ServiceContract(Namespace = "VocabularyServiceLib.Contracts.IVocabularyService")]
    public interface IVocabularyService
    {
        [OperationContract]
        ThesaurusUnit GetWordInfo(String word);

        [OperationContract]
        void AddSynonym(String baseWord, String synonym);

        [OperationContract(Name = "AddAntonymAttrName")]
        void AddAntonym(String baseWord, String antonym);
    }
}
