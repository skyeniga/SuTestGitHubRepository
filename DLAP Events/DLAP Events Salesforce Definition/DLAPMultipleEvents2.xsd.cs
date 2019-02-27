namespace DLAPEventsSalesforceDefinition {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"fieldsToNull", @"Id", @"Application_Number__c", @"Log_Message__c", @"SObject_ID__c", @"SObject_Name__c"})]
    public sealed class DLAPMultipleEvents2 : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:tns=""urn:sobject.enterprise.soap.sforce.com"" attributeFormDefault=""unqualified"" elementFormDefault=""qualified"" targetNamespace=""urn:sobject.enterprise.soap.sforce.com"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""fieldsToNull"" type=""xs:string"" />
  <xs:element name=""Id"" type=""xs:string"" />
  <xs:element name=""Application_Number__c"" type=""xs:string"" />
  <xs:element name=""Log_Message__c"" type=""xs:string"" />
  <xs:element name=""SObject_ID__c"" type=""xs:string"" />
  <xs:element name=""SObject_Name__c"" type=""xs:string"" />
</xs:schema>";
        
        public DLAPMultipleEvents2() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [6];
                _RootElements[0] = "fieldsToNull";
                _RootElements[1] = "Id";
                _RootElements[2] = "Application_Number__c";
                _RootElements[3] = "Log_Message__c";
                _RootElements[4] = "SObject_ID__c";
                _RootElements[5] = "SObject_Name__c";
                return _RootElements;
            }
        }
        
        protected override object RawSchema {
            get {
                return _rawSchema;
            }
            set {
                _rawSchema = value;
            }
        }
        
        [Schema(@"urn:sobject.enterprise.soap.sforce.com",@"fieldsToNull")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"fieldsToNull"})]
        public sealed class fieldsToNull : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public fieldsToNull() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "fieldsToNull";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
        
        [Schema(@"urn:sobject.enterprise.soap.sforce.com",@"Id")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"Id"})]
        public sealed class Id : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public Id() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "Id";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
        
        [Schema(@"urn:sobject.enterprise.soap.sforce.com",@"Application_Number__c")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"Application_Number__c"})]
        public sealed class Application_Number__c : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public Application_Number__c() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "Application_Number__c";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
        
        [Schema(@"urn:sobject.enterprise.soap.sforce.com",@"Log_Message__c")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"Log_Message__c"})]
        public sealed class Log_Message__c : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public Log_Message__c() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "Log_Message__c";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
        
        [Schema(@"urn:sobject.enterprise.soap.sforce.com",@"SObject_ID__c")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"SObject_ID__c"})]
        public sealed class SObject_ID__c : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public SObject_ID__c() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "SObject_ID__c";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
        
        [Schema(@"urn:sobject.enterprise.soap.sforce.com",@"SObject_Name__c")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"SObject_Name__c"})]
        public sealed class SObject_Name__c : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public SObject_Name__c() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "SObject_Name__c";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
    }
}
