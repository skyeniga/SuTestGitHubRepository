namespace Application_Import_Definition {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"POLLINGSTMTRECORD", @"ArrayOfPOLLINGSTMTRECORD", @"POLLINGSTMT"})]
    public sealed class OraclePollingMultipleApplications : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:tns=""http://Microsoft.LobServices.OracleDB/2007/03/POLLINGSTMTdlap_files_for_transfer"" elementFormDefault=""qualified"" targetNamespace=""http://Microsoft.LobServices.OracleDB/2007/03/POLLINGSTMTdlap_files_for_transfer"" version=""1.0"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <fileNameHint xmlns=""http://schemas.microsoft.com/servicemodel/adapters/metadata/xsd"">POLLINGSTMTdlap_files_for_transfer</fileNameHint>
    </xs:appinfo>
  </xs:annotation>
  <xs:complexType name=""POLLINGSTMTRECORD"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""APP_DATA_FINAL_XML"" nillable=""true"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""2147483647"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""POLLINGSTMTRECORD"" nillable=""true"" type=""tns:POLLINGSTMTRECORD"" />
  <xs:complexType name=""ArrayOfPOLLINGSTMTRECORD"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""POLLINGSTMTRECORD"" type=""tns:POLLINGSTMTRECORD"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfPOLLINGSTMTRECORD"" nillable=""true"" type=""tns:ArrayOfPOLLINGSTMTRECORD"" />
  <xs:element name=""POLLINGSTMT"">
    <xs:annotation>
      <xs:documentation>
        <doc:action xmlns:doc=""http://schemas.microsoft.com/servicemodel/adapters/metadata/documentation"">http://Microsoft.LobServices.OracleDB/2007/03/POLLINGSTMT</doc:action>
      </xs:documentation>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""POLLINGSTMTRECORD"" nillable=""true"" type=""tns:ArrayOfPOLLINGSTMTRECORD"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public OraclePollingMultipleApplications() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [3];
                _RootElements[0] = "POLLINGSTMTRECORD";
                _RootElements[1] = "ArrayOfPOLLINGSTMTRECORD";
                _RootElements[2] = "POLLINGSTMT";
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
        
        [Schema(@"http://Microsoft.LobServices.OracleDB/2007/03/POLLINGSTMTdlap_files_for_transfer",@"POLLINGSTMTRECORD")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"POLLINGSTMTRECORD"})]
        public sealed class POLLINGSTMTRECORD : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public POLLINGSTMTRECORD() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "POLLINGSTMTRECORD";
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
        
        [Schema(@"http://Microsoft.LobServices.OracleDB/2007/03/POLLINGSTMTdlap_files_for_transfer",@"ArrayOfPOLLINGSTMTRECORD")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfPOLLINGSTMTRECORD"})]
        public sealed class ArrayOfPOLLINGSTMTRECORD : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfPOLLINGSTMTRECORD() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfPOLLINGSTMTRECORD";
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
        
        [Schema(@"http://Microsoft.LobServices.OracleDB/2007/03/POLLINGSTMTdlap_files_for_transfer",@"POLLINGSTMT")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"POLLINGSTMT"})]
        public sealed class POLLINGSTMT : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public POLLINGSTMT() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "POLLINGSTMT";
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
