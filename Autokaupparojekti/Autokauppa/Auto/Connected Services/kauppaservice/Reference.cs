﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Auto.kauppaservice {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Kulkuneuvo", Namespace="http://schemas.datacontract.org/2004/07/WcfAutokauppa")]
    [System.SerializableAttribute()]
    public partial class Kulkuneuvo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AutonMalliIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AutonMerkkiIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal HintaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int MittarilukemaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal MoottorintilavuusField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PolttoaineIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime Rekisteröiti_päivämääräField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int VaritIDField;
        
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
        public int AutonMalliID {
            get {
                return this.AutonMalliIDField;
            }
            set {
                if ((this.AutonMalliIDField.Equals(value) != true)) {
                    this.AutonMalliIDField = value;
                    this.RaisePropertyChanged("AutonMalliID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int AutonMerkkiID {
            get {
                return this.AutonMerkkiIDField;
            }
            set {
                if ((this.AutonMerkkiIDField.Equals(value) != true)) {
                    this.AutonMerkkiIDField = value;
                    this.RaisePropertyChanged("AutonMerkkiID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Hinta {
            get {
                return this.HintaField;
            }
            set {
                if ((this.HintaField.Equals(value) != true)) {
                    this.HintaField = value;
                    this.RaisePropertyChanged("Hinta");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Mittarilukema {
            get {
                return this.MittarilukemaField;
            }
            set {
                if ((this.MittarilukemaField.Equals(value) != true)) {
                    this.MittarilukemaField = value;
                    this.RaisePropertyChanged("Mittarilukema");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Moottorintilavuus {
            get {
                return this.MoottorintilavuusField;
            }
            set {
                if ((this.MoottorintilavuusField.Equals(value) != true)) {
                    this.MoottorintilavuusField = value;
                    this.RaisePropertyChanged("Moottorintilavuus");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int PolttoaineID {
            get {
                return this.PolttoaineIDField;
            }
            set {
                if ((this.PolttoaineIDField.Equals(value) != true)) {
                    this.PolttoaineIDField = value;
                    this.RaisePropertyChanged("PolttoaineID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Rekisteröiti_päivämäärä {
            get {
                return this.Rekisteröiti_päivämääräField;
            }
            set {
                if ((this.Rekisteröiti_päivämääräField.Equals(value) != true)) {
                    this.Rekisteröiti_päivämääräField = value;
                    this.RaisePropertyChanged("Rekisteröiti_päivämäärä");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int VaritID {
            get {
                return this.VaritIDField;
            }
            set {
                if ((this.VaritIDField.Equals(value) != true)) {
                    this.VaritIDField = value;
                    this.RaisePropertyChanged("VaritID");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Autonmerkki", Namespace="http://schemas.datacontract.org/2004/07/WcfAutokauppa")]
    [System.SerializableAttribute()]
    public partial class Autonmerkki : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MerkkiNimiField;
        
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
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MerkkiNimi {
            get {
                return this.MerkkiNimiField;
            }
            set {
                if ((object.ReferenceEquals(this.MerkkiNimiField, value) != true)) {
                    this.MerkkiNimiField = value;
                    this.RaisePropertyChanged("MerkkiNimi");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Autonmallit", Namespace="http://schemas.datacontract.org/2004/07/WcfAutokauppa")]
    [System.SerializableAttribute()]
    public partial class Autonmallit : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MalliNimiField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int MerkkiIdField;
        
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
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MalliNimi {
            get {
                return this.MalliNimiField;
            }
            set {
                if ((object.ReferenceEquals(this.MalliNimiField, value) != true)) {
                    this.MalliNimiField = value;
                    this.RaisePropertyChanged("MalliNimi");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int MerkkiId {
            get {
                return this.MerkkiIdField;
            }
            set {
                if ((this.MerkkiIdField.Equals(value) != true)) {
                    this.MerkkiIdField = value;
                    this.RaisePropertyChanged("MerkkiId");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Vari", Namespace="http://schemas.datacontract.org/2004/07/WcfAutokauppa")]
    [System.SerializableAttribute()]
    public partial class Vari : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string VaritField;
        
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
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Varit {
            get {
                return this.VaritField;
            }
            set {
                if ((object.ReferenceEquals(this.VaritField, value) != true)) {
                    this.VaritField = value;
                    this.RaisePropertyChanged("Varit");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Polttoaine", Namespace="http://schemas.datacontract.org/2004/07/WcfAutokauppa")]
    [System.SerializableAttribute()]
    public partial class Polttoaine : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PolttoaineetField;
        
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
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Polttoaineet {
            get {
                return this.PolttoaineetField;
            }
            set {
                if ((object.ReferenceEquals(this.PolttoaineetField, value) != true)) {
                    this.PolttoaineetField = value;
                    this.RaisePropertyChanged("Polttoaineet");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="kauppaservice.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/connectDatabase", ReplyAction="http://tempuri.org/IService1/connectDatabaseResponse")]
        bool connectDatabase();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/connectDatabase", ReplyAction="http://tempuri.org/IService1/connectDatabaseResponse")]
        System.Threading.Tasks.Task<bool> connectDatabaseAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/saveAutoIntoDatabase", ReplyAction="http://tempuri.org/IService1/saveAutoIntoDatabaseResponse")]
        bool saveAutoIntoDatabase(Auto.kauppaservice.Kulkuneuvo tallenne);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/saveAutoIntoDatabase", ReplyAction="http://tempuri.org/IService1/saveAutoIntoDatabaseResponse")]
        System.Threading.Tasks.Task<bool> saveAutoIntoDatabaseAsync(Auto.kauppaservice.Kulkuneuvo tallenne);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllAutoMakersFromDatabase", ReplyAction="http://tempuri.org/IService1/GetAllAutoMakersFromDatabaseResponse")]
        System.Collections.Generic.List<Auto.kauppaservice.Autonmerkki> GetAllAutoMakersFromDatabase();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllAutoMakersFromDatabase", ReplyAction="http://tempuri.org/IService1/GetAllAutoMakersFromDatabaseResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Auto.kauppaservice.Autonmerkki>> GetAllAutoMakersFromDatabaseAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/HaeValmisMalli", ReplyAction="http://tempuri.org/IService1/HaeValmisMalliResponse")]
        Auto.kauppaservice.Autonmallit HaeValmisMalli(int malliID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/HaeValmisMalli", ReplyAction="http://tempuri.org/IService1/HaeValmisMalliResponse")]
        System.Threading.Tasks.Task<Auto.kauppaservice.Autonmallit> HaeValmisMalliAsync(int malliID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/HaeValittuVäri", ReplyAction="http://tempuri.org/IService1/HaeValittuVäriResponse")]
        Auto.kauppaservice.Vari HaeValittuVäri(int VariID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/HaeValittuVäri", ReplyAction="http://tempuri.org/IService1/HaeValittuVäriResponse")]
        System.Threading.Tasks.Task<Auto.kauppaservice.Vari> HaeValittuVäriAsync(int VariID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/HaeValittuPolttoaine", ReplyAction="http://tempuri.org/IService1/HaeValittuPolttoaineResponse")]
        Auto.kauppaservice.Polttoaine HaeValittuPolttoaine(int PolttoaineID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/HaeValittuPolttoaine", ReplyAction="http://tempuri.org/IService1/HaeValittuPolttoaineResponse")]
        System.Threading.Tasks.Task<Auto.kauppaservice.Polttoaine> HaeValittuPolttoaineAsync(int PolttoaineID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAutoModelsByMakerId", ReplyAction="http://tempuri.org/IService1/GetAutoModelsByMakerIdResponse")]
        System.Collections.Generic.List<Auto.kauppaservice.Autonmallit> GetAutoModelsByMakerId(int makerId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAutoModelsByMakerId", ReplyAction="http://tempuri.org/IService1/GetAutoModelsByMakerIdResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Auto.kauppaservice.Autonmallit>> GetAutoModelsByMakerIdAsync(int makerId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/HaeValmisMerkki", ReplyAction="http://tempuri.org/IService1/HaeValmisMerkkiResponse")]
        Auto.kauppaservice.Autonmerkki HaeValmisMerkki(int merkkiID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/HaeValmisMerkki", ReplyAction="http://tempuri.org/IService1/HaeValmisMerkkiResponse")]
        System.Threading.Tasks.Task<Auto.kauppaservice.Autonmerkki> HaeValmisMerkkiAsync(int merkkiID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/HaePolttoaine", ReplyAction="http://tempuri.org/IService1/HaePolttoaineResponse")]
        System.Collections.Generic.List<Auto.kauppaservice.Polttoaine> HaePolttoaine();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/HaePolttoaine", ReplyAction="http://tempuri.org/IService1/HaePolttoaineResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Auto.kauppaservice.Polttoaine>> HaePolttoaineAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/haeVari", ReplyAction="http://tempuri.org/IService1/haeVariResponse")]
        System.Collections.Generic.List<Auto.kauppaservice.Vari> haeVari();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/haeVari", ReplyAction="http://tempuri.org/IService1/haeVariResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Auto.kauppaservice.Vari>> haeVariAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SeuraavaAutoTietokannassa", ReplyAction="http://tempuri.org/IService1/SeuraavaAutoTietokannassaResponse")]
        Auto.kauppaservice.Kulkuneuvo SeuraavaAutoTietokannassa(int nykyinen);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SeuraavaAutoTietokannassa", ReplyAction="http://tempuri.org/IService1/SeuraavaAutoTietokannassaResponse")]
        System.Threading.Tasks.Task<Auto.kauppaservice.Kulkuneuvo> SeuraavaAutoTietokannassaAsync(int nykyinen);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/EdellinenAutoTietokannassa", ReplyAction="http://tempuri.org/IService1/EdellinenAutoTietokannassaResponse")]
        Auto.kauppaservice.Kulkuneuvo EdellinenAutoTietokannassa(int nykyinen);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/EdellinenAutoTietokannassa", ReplyAction="http://tempuri.org/IService1/EdellinenAutoTietokannassaResponse")]
        System.Threading.Tasks.Task<Auto.kauppaservice.Kulkuneuvo> EdellinenAutoTietokannassaAsync(int nykyinen);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/disconnectDatabase", ReplyAction="http://tempuri.org/IService1/disconnectDatabaseResponse")]
        void disconnectDatabase();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/disconnectDatabase", ReplyAction="http://tempuri.org/IService1/disconnectDatabaseResponse")]
        System.Threading.Tasks.Task disconnectDatabaseAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : Auto.kauppaservice.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<Auto.kauppaservice.IService1>, Auto.kauppaservice.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool connectDatabase() {
            return base.Channel.connectDatabase();
        }
        
        public System.Threading.Tasks.Task<bool> connectDatabaseAsync() {
            return base.Channel.connectDatabaseAsync();
        }
        
        public bool saveAutoIntoDatabase(Auto.kauppaservice.Kulkuneuvo tallenne) {
            return base.Channel.saveAutoIntoDatabase(tallenne);
        }
        
        public System.Threading.Tasks.Task<bool> saveAutoIntoDatabaseAsync(Auto.kauppaservice.Kulkuneuvo tallenne) {
            return base.Channel.saveAutoIntoDatabaseAsync(tallenne);
        }
        
        public System.Collections.Generic.List<Auto.kauppaservice.Autonmerkki> GetAllAutoMakersFromDatabase() {
            return base.Channel.GetAllAutoMakersFromDatabase();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<Auto.kauppaservice.Autonmerkki>> GetAllAutoMakersFromDatabaseAsync() {
            return base.Channel.GetAllAutoMakersFromDatabaseAsync();
        }
        
        public Auto.kauppaservice.Autonmallit HaeValmisMalli(int malliID) {
            return base.Channel.HaeValmisMalli(malliID);
        }
        
        public System.Threading.Tasks.Task<Auto.kauppaservice.Autonmallit> HaeValmisMalliAsync(int malliID) {
            return base.Channel.HaeValmisMalliAsync(malliID);
        }
        
        public Auto.kauppaservice.Vari HaeValittuVäri(int VariID) {
            return base.Channel.HaeValittuVäri(VariID);
        }
        
        public System.Threading.Tasks.Task<Auto.kauppaservice.Vari> HaeValittuVäriAsync(int VariID) {
            return base.Channel.HaeValittuVäriAsync(VariID);
        }
        
        public Auto.kauppaservice.Polttoaine HaeValittuPolttoaine(int PolttoaineID) {
            return base.Channel.HaeValittuPolttoaine(PolttoaineID);
        }
        
        public System.Threading.Tasks.Task<Auto.kauppaservice.Polttoaine> HaeValittuPolttoaineAsync(int PolttoaineID) {
            return base.Channel.HaeValittuPolttoaineAsync(PolttoaineID);
        }
        
        public System.Collections.Generic.List<Auto.kauppaservice.Autonmallit> GetAutoModelsByMakerId(int makerId) {
            return base.Channel.GetAutoModelsByMakerId(makerId);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<Auto.kauppaservice.Autonmallit>> GetAutoModelsByMakerIdAsync(int makerId) {
            return base.Channel.GetAutoModelsByMakerIdAsync(makerId);
        }
        
        public Auto.kauppaservice.Autonmerkki HaeValmisMerkki(int merkkiID) {
            return base.Channel.HaeValmisMerkki(merkkiID);
        }
        
        public System.Threading.Tasks.Task<Auto.kauppaservice.Autonmerkki> HaeValmisMerkkiAsync(int merkkiID) {
            return base.Channel.HaeValmisMerkkiAsync(merkkiID);
        }
        
        public System.Collections.Generic.List<Auto.kauppaservice.Polttoaine> HaePolttoaine() {
            return base.Channel.HaePolttoaine();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<Auto.kauppaservice.Polttoaine>> HaePolttoaineAsync() {
            return base.Channel.HaePolttoaineAsync();
        }
        
        public System.Collections.Generic.List<Auto.kauppaservice.Vari> haeVari() {
            return base.Channel.haeVari();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<Auto.kauppaservice.Vari>> haeVariAsync() {
            return base.Channel.haeVariAsync();
        }
        
        public Auto.kauppaservice.Kulkuneuvo SeuraavaAutoTietokannassa(int nykyinen) {
            return base.Channel.SeuraavaAutoTietokannassa(nykyinen);
        }
        
        public System.Threading.Tasks.Task<Auto.kauppaservice.Kulkuneuvo> SeuraavaAutoTietokannassaAsync(int nykyinen) {
            return base.Channel.SeuraavaAutoTietokannassaAsync(nykyinen);
        }
        
        public Auto.kauppaservice.Kulkuneuvo EdellinenAutoTietokannassa(int nykyinen) {
            return base.Channel.EdellinenAutoTietokannassa(nykyinen);
        }
        
        public System.Threading.Tasks.Task<Auto.kauppaservice.Kulkuneuvo> EdellinenAutoTietokannassaAsync(int nykyinen) {
            return base.Channel.EdellinenAutoTietokannassaAsync(nykyinen);
        }
        
        public void disconnectDatabase() {
            base.Channel.disconnectDatabase();
        }
        
        public System.Threading.Tasks.Task disconnectDatabaseAsync() {
            return base.Channel.disconnectDatabaseAsync();
        }
    }
}
