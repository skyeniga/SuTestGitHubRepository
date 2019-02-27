namespace Oracle_Application_Import_Definition {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"ReadLOB", @"ReadLOBResponse", @"Select", @"SUBMITTED_DOCUMENTS_DCMS2RECORDSELECT", @"ArrayOfSUBMITTED_DOCUMENTS_DCMS2RECORDSELECT", @"SelectResponse"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Oracle_Application_Import_Definition.DLAPOracle_Message", typeof(global::Oracle_Application_Import_Definition.DLAPOracle_Message))]
    public sealed class DLAPOracle_SUBMITTED_DOCUMENTS_DCMS2 : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns3=""http://schemas.microsoft.com/Message"" elementFormDefault=""qualified"" targetNamespace=""http://Microsoft.LobServices.OracleDB/2007/03/ELA_DB/View/SUBMITTED_DOCUMENTS_DCMS2"" version=""1.0"" xmlns=""http://www.w3.org/2001/XMLSchema"">
  <import schemaLocation=""Oracle_Application_Import_Definition.DLAPOracle_Message"" namespace=""http://schemas.microsoft.com/Message"" />
  <annotation>
    <appinfo>
      <fileNameHint xmlns=""http://schemas.microsoft.com/servicemodel/adapters/metadata/xsd"">ELA_DB.View.SUBMITTED_DOCUMENTS_DCMS2</fileNameHint>
      <references xmlns=""http://schemas.microsoft.com/BizTalk/2003"">
        <reference targetNamespace=""http://schemas.microsoft.com/Message"" />
      </references>
    </appinfo>
  </annotation>
  <element name=""ReadLOB"">
    <annotation>
      <documentation>
        <doc:action xmlns:doc=""http://schemas.microsoft.com/servicemodel/adapters/metadata/documentation"">http://Microsoft.LobServices.OracleDB/2007/03/ELA_DB/View/SUBMITTED_DOCUMENTS_DCMS2/ReadLOB</doc:action>
      </documentation>
    </annotation>
    <complexType>
      <sequence>
        <element minOccurs=""0"" maxOccurs=""1"" name=""LOB_COLUMN"" nillable=""true"" type=""string"" />
        <element minOccurs=""0"" maxOccurs=""1"" name=""FILTER"" nillable=""true"" type=""string"" />
      </sequence>
    </complexType>
  </element>
  <element name=""ReadLOBResponse"">
    <annotation>
      <documentation>
        <doc:action xmlns:doc=""http://schemas.microsoft.com/servicemodel/adapters/metadata/documentation"">http://Microsoft.LobServices.OracleDB/2007/03/ELA_DB/View/SUBMITTED_DOCUMENTS_DCMS2/ReadLOB/response</doc:action>
      </documentation>
    </annotation>
    <complexType>
      <sequence>
        <element minOccurs=""1"" maxOccurs=""1"" name=""ReadLOBResult"" type=""ns3:StreamBody"" />
      </sequence>
    </complexType>
  </element>
  <element name=""Select"">
    <annotation>
      <documentation>
        <doc:action xmlns:doc=""http://schemas.microsoft.com/servicemodel/adapters/metadata/documentation"">http://Microsoft.LobServices.OracleDB/2007/03/ELA_DB/View/SUBMITTED_DOCUMENTS_DCMS2/Select</doc:action>
      </documentation>
    </annotation>
    <complexType>
      <sequence>
        <element minOccurs=""1"" maxOccurs=""1"" name=""COLUMN_NAMES"" nillable=""true"" type=""string"" />
        <element minOccurs=""0"" maxOccurs=""1"" name=""FILTER"" nillable=""true"" type=""string"" />
      </sequence>
    </complexType>
  </element>
  <complexType name=""SUBMITTED_DOCUMENTS_DCMS2RECORDSELECT"">
    <sequence>
      <element minOccurs=""0"" maxOccurs=""1"" name=""APP_REFERENCE_NUMBER"" nillable=""true"">
        <simpleType>
          <restriction base=""string"">
            <maxLength value=""4000"" />
          </restriction>
        </simpleType>
      </element>
      <element minOccurs=""0"" maxOccurs=""1"" name=""DOC_ID"" nillable=""true"">
        <simpleType>
          <restriction base=""string"">
            <maxLength value=""4000"" />
          </restriction>
        </simpleType>
      </element>
      <element minOccurs=""0"" maxOccurs=""1"" name=""DOC_TYPE"" nillable=""true"">
        <simpleType>
          <restriction base=""string"">
            <maxLength value=""50"" />
          </restriction>
        </simpleType>
      </element>
      <element minOccurs=""0"" maxOccurs=""1"" name=""LKC_DESC"" nillable=""true"">
        <simpleType>
          <restriction base=""string"">
            <maxLength value=""2000"" />
          </restriction>
        </simpleType>
      </element>
      <element minOccurs=""0"" maxOccurs=""1"" name=""DOC_CONTENTS"" nillable=""true"" type=""base64Binary"" />
      <element minOccurs=""0"" maxOccurs=""1"" name=""DOC_CONTENT_TYPE"" nillable=""true"">
        <simpleType>
          <restriction base=""string"">
            <maxLength value=""255"" />
          </restriction>
        </simpleType>
      </element>
      <element minOccurs=""0"" maxOccurs=""1"" name=""DOC_INSTANCE_NAME"" nillable=""true"">
        <simpleType>
          <restriction base=""string"">
            <maxLength value=""100"" />
          </restriction>
        </simpleType>
      </element>
      <element minOccurs=""0"" maxOccurs=""1"" name=""DOC_SOURCE"" nillable=""true"">
        <simpleType>
          <restriction base=""string"">
            <maxLength value=""100"" />
          </restriction>
        </simpleType>
      </element>
      <element minOccurs=""0"" maxOccurs=""1"" name=""DOC_APPLICANT_ID"" nillable=""true"">
        <simpleType>
          <restriction base=""string"">
            <maxLength value=""4000"" />
          </restriction>
        </simpleType>
      </element>
      <element minOccurs=""0"" maxOccurs=""1"" name=""DOC_AFFILIATE_ID"" nillable=""true"">
        <simpleType>
          <restriction base=""string"">
            <maxLength value=""4000"" />
          </restriction>
        </simpleType>
      </element>
      <element minOccurs=""0"" maxOccurs=""1"" name=""DOC_ORIGIN"" nillable=""true"">
        <simpleType>
          <restriction base=""string"">
            <maxLength value=""30"" />
          </restriction>
        </simpleType>
      </element>
      <element minOccurs=""0"" maxOccurs=""1"" name=""DOC_USR_ID"" nillable=""true"">
        <simpleType>
          <restriction base=""string"">
            <maxLength value=""4000"" />
          </restriction>
        </simpleType>
      </element>
    </sequence>
  </complexType>
  <element xmlns:q1=""http://Microsoft.LobServices.OracleDB/2007/03/ELA_DB/View/SUBMITTED_DOCUMENTS_DCMS2"" name=""SUBMITTED_DOCUMENTS_DCMS2RECORDSELECT"" nillable=""true"" type=""q1:SUBMITTED_DOCUMENTS_DCMS2RECORDSELECT"" />
  <complexType name=""ArrayOfSUBMITTED_DOCUMENTS_DCMS2RECORDSELECT"">
    <sequence>
      <element xmlns:q2=""http://Microsoft.LobServices.OracleDB/2007/03/ELA_DB/View/SUBMITTED_DOCUMENTS_DCMS2"" minOccurs=""0"" maxOccurs=""unbounded"" name=""SUBMITTED_DOCUMENTS_DCMS2RECORDSELECT"" type=""q2:SUBMITTED_DOCUMENTS_DCMS2RECORDSELECT"" />
    </sequence>
  </complexType>
  <element xmlns:q3=""http://Microsoft.LobServices.OracleDB/2007/03/ELA_DB/View/SUBMITTED_DOCUMENTS_DCMS2"" name=""ArrayOfSUBMITTED_DOCUMENTS_DCMS2RECORDSELECT"" nillable=""true"" type=""q3:ArrayOfSUBMITTED_DOCUMENTS_DCMS2RECORDSELECT"" />
  <element name=""SelectResponse"">
    <annotation>
      <documentation>
        <doc:action xmlns:doc=""http://schemas.microsoft.com/servicemodel/adapters/metadata/documentation"">http://Microsoft.LobServices.OracleDB/2007/03/ELA_DB/View/SUBMITTED_DOCUMENTS_DCMS2/Select/response</doc:action>
      </documentation>
    </annotation>
    <complexType>
      <sequence>
        <element xmlns:q4=""http://Microsoft.LobServices.OracleDB/2007/03/ELA_DB/View/SUBMITTED_DOCUMENTS_DCMS2"" minOccurs=""0"" maxOccurs=""1"" name=""SelectResult"" nillable=""true"" type=""q4:ArrayOfSUBMITTED_DOCUMENTS_DCMS2RECORDSELECT"" />
      </sequence>
    </complexType>
  </element>
</schema>";
        
        public DLAPOracle_SUBMITTED_DOCUMENTS_DCMS2() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [6];
                _RootElements[0] = "ReadLOB";
                _RootElements[1] = "ReadLOBResponse";
                _RootElements[2] = "Select";
                _RootElements[3] = "SUBMITTED_DOCUMENTS_DCMS2RECORDSELECT";
                _RootElements[4] = "ArrayOfSUBMITTED_DOCUMENTS_DCMS2RECORDSELECT";
                _RootElements[5] = "SelectResponse";
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
        
        [Schema(@"http://Microsoft.LobServices.OracleDB/2007/03/ELA_DB/View/SUBMITTED_DOCUMENTS_DCMS2",@"ReadLOB")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ReadLOB"})]
        public sealed class ReadLOB : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ReadLOB() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ReadLOB";
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
        
        [Schema(@"http://Microsoft.LobServices.OracleDB/2007/03/ELA_DB/View/SUBMITTED_DOCUMENTS_DCMS2",@"ReadLOBResponse")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ReadLOBResponse"})]
        public sealed class ReadLOBResponse : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ReadLOBResponse() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ReadLOBResponse";
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
        
        [Schema(@"http://Microsoft.LobServices.OracleDB/2007/03/ELA_DB/View/SUBMITTED_DOCUMENTS_DCMS2",@"Select")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"Select"})]
        public sealed class Select : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public Select() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "Select";
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
        
        [Schema(@"http://Microsoft.LobServices.OracleDB/2007/03/ELA_DB/View/SUBMITTED_DOCUMENTS_DCMS2",@"SUBMITTED_DOCUMENTS_DCMS2RECORDSELECT")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"SUBMITTED_DOCUMENTS_DCMS2RECORDSELECT"})]
        public sealed class SUBMITTED_DOCUMENTS_DCMS2RECORDSELECT : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public SUBMITTED_DOCUMENTS_DCMS2RECORDSELECT() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "SUBMITTED_DOCUMENTS_DCMS2RECORDSELECT";
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
        
        [Schema(@"http://Microsoft.LobServices.OracleDB/2007/03/ELA_DB/View/SUBMITTED_DOCUMENTS_DCMS2",@"ArrayOfSUBMITTED_DOCUMENTS_DCMS2RECORDSELECT")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfSUBMITTED_DOCUMENTS_DCMS2RECORDSELECT"})]
        public sealed class ArrayOfSUBMITTED_DOCUMENTS_DCMS2RECORDSELECT : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfSUBMITTED_DOCUMENTS_DCMS2RECORDSELECT() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfSUBMITTED_DOCUMENTS_DCMS2RECORDSELECT";
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
        
        [Schema(@"http://Microsoft.LobServices.OracleDB/2007/03/ELA_DB/View/SUBMITTED_DOCUMENTS_DCMS2",@"SelectResponse")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"SelectResponse"})]
        public sealed class SelectResponse : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public SelectResponse() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "SelectResponse";
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
