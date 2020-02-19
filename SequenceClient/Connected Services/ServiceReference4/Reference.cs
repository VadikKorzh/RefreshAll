﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SequenceClient.ServiceReference4 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ThesaurusUnit", Namespace="http://schemas.datacontract.org/2004/07/VocabularyServiceLib.DataContracts")]
    [System.SerializableAttribute()]
    public partial class ThesaurusUnit : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string[] AntonymsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string BaseWordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string[] SynonymsField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string[] Antonyms {
            get {
                return this.AntonymsField;
            }
            set {
                if ((object.ReferenceEquals(this.AntonymsField, value) != true)) {
                    this.AntonymsField = value;
                    this.RaisePropertyChanged("Antonyms");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string BaseWord {
            get {
                return this.BaseWordField;
            }
            set {
                if ((object.ReferenceEquals(this.BaseWordField, value) != true)) {
                    this.BaseWordField = value;
                    this.RaisePropertyChanged("BaseWord");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string[] Synonyms {
            get {
                return this.SynonymsField;
            }
            set {
                if ((object.ReferenceEquals(this.SynonymsField, value) != true)) {
                    this.SynonymsField = value;
                    this.RaisePropertyChanged("Synonyms");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="VocabularyServiceLib.Contracts.IVocabularyService", ConfigurationName="ServiceReference4.IVocabularyService")]
    public interface IVocabularyService {
        
        [System.ServiceModel.OperationContractAttribute(Action="VocabularyServiceLib.Contracts.IVocabularyService/IVocabularyService/GetWordInfo", ReplyAction="VocabularyServiceLib.Contracts.IVocabularyService/IVocabularyService/GetWordInfoR" +
            "esponse")]
        SequenceClient.ServiceReference4.ThesaurusUnit GetWordInfo(string word);
        
        [System.ServiceModel.OperationContractAttribute(Action="VocabularyServiceLib.Contracts.IVocabularyService/IVocabularyService/GetWordInfo", ReplyAction="VocabularyServiceLib.Contracts.IVocabularyService/IVocabularyService/GetWordInfoR" +
            "esponse")]
        System.Threading.Tasks.Task<SequenceClient.ServiceReference4.ThesaurusUnit> GetWordInfoAsync(string word);
        
        [System.ServiceModel.OperationContractAttribute(Action="VocabularyServiceLib.Contracts.IVocabularyService/IVocabularyService/AddSynonym", ReplyAction="VocabularyServiceLib.Contracts.IVocabularyService/IVocabularyService/AddSynonymRe" +
            "sponse")]
        void AddSynonym(string baseWord, string synonym);
        
        [System.ServiceModel.OperationContractAttribute(Action="VocabularyServiceLib.Contracts.IVocabularyService/IVocabularyService/AddSynonym", ReplyAction="VocabularyServiceLib.Contracts.IVocabularyService/IVocabularyService/AddSynonymRe" +
            "sponse")]
        System.Threading.Tasks.Task AddSynonymAsync(string baseWord, string synonym);
        
        [System.ServiceModel.OperationContractAttribute(Action="VocabularyServiceLib.Contracts.IVocabularyService/IVocabularyService/AddAntonymAt" +
            "trName", ReplyAction="VocabularyServiceLib.Contracts.IVocabularyService/IVocabularyService/AddAntonymAt" +
            "trNameResponse")]
        void AddAntonymAttrName(string baseWord, string antonym);
        
        [System.ServiceModel.OperationContractAttribute(Action="VocabularyServiceLib.Contracts.IVocabularyService/IVocabularyService/AddAntonymAt" +
            "trName", ReplyAction="VocabularyServiceLib.Contracts.IVocabularyService/IVocabularyService/AddAntonymAt" +
            "trNameResponse")]
        System.Threading.Tasks.Task AddAntonymAttrNameAsync(string baseWord, string antonym);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IVocabularyServiceChannel : SequenceClient.ServiceReference4.IVocabularyService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class VocabularyServiceClient : System.ServiceModel.ClientBase<SequenceClient.ServiceReference4.IVocabularyService>, SequenceClient.ServiceReference4.IVocabularyService {
        
        public VocabularyServiceClient() {
        }
        
        public VocabularyServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public VocabularyServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public VocabularyServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public VocabularyServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SequenceClient.ServiceReference4.ThesaurusUnit GetWordInfo(string word) {
            return base.Channel.GetWordInfo(word);
        }
        
        public System.Threading.Tasks.Task<SequenceClient.ServiceReference4.ThesaurusUnit> GetWordInfoAsync(string word) {
            return base.Channel.GetWordInfoAsync(word);
        }
        
        public void AddSynonym(string baseWord, string synonym) {
            base.Channel.AddSynonym(baseWord, synonym);
        }
        
        public System.Threading.Tasks.Task AddSynonymAsync(string baseWord, string synonym) {
            return base.Channel.AddSynonymAsync(baseWord, synonym);
        }
        
        public void AddAntonymAttrName(string baseWord, string antonym) {
            base.Channel.AddAntonymAttrName(baseWord, antonym);
        }
        
        public System.Threading.Tasks.Task AddAntonymAttrNameAsync(string baseWord, string antonym) {
            return base.Channel.AddAntonymAttrNameAsync(baseWord, antonym);
        }
    }
}