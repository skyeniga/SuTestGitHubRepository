namespace DLAPEventsOracleDefinition {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"EVENT_NOTIFICATION_DCMSRECORDINSERT", @"ArrayOfEVENT_NOTIFICATION_DCMSRECORDINSERT", @"Insert", @"InsertResponse"})]
    public sealed class OracleEventNotification : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:tns=""http://Microsoft.LobServices.OracleDB/2007/03/DCMS_INT/View/EVENT_NOTIFICATION_DCMS"" elementFormDefault=""qualified"" targetNamespace=""http://Microsoft.LobServices.OracleDB/2007/03/DCMS_INT/View/EVENT_NOTIFICATION_DCMS"" version=""1.0"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <fileNameHint xmlns=""http://schemas.microsoft.com/servicemodel/adapters/metadata/xsd"">DCMS_INT.View.EVENT_NOTIFICATION_DCMS</fileNameHint>
    </xs:appinfo>
  </xs:annotation>
  <xs:complexType name=""EVENT_NOTIFICATION_DCMSRECORDINSERT"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ID"" nillable=""true"" type=""tns:ID__COMPLEX_TYPE"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""APP_NBR"" nillable=""true"" type=""tns:APP_NBR__COMPLEX_TYPE"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""EVENT_TYPE"" nillable=""true"" type=""tns:EVENT_TYPE__COMPLEX_TYPE"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""EVENT_STATUS"" nillable=""true"" type=""tns:EVENT_STATUS__COMPLEX_TYPE"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""EVENT_DATA"" nillable=""true"" type=""tns:EVENT_DATA__COMPLEX_TYPE"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""CREATED_BY"" nillable=""true"" type=""tns:CREATED_BY__COMPLEX_TYPE"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""CREATION_DATE"" nillable=""true"" type=""tns:CREATION_DATE__COMPLEX_TYPE"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""LAST_UPDATED_BY"" nillable=""true"" type=""tns:LAST_UPDATED_BY__COMPLEX_TYPE"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""LAST_UPDATE_DATE"" nillable=""true"" type=""tns:LAST_UPDATE_DATE__COMPLEX_TYPE"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""EVENT_NOTIFICATION_DCMSRECORDINSERT"" nillable=""true"" type=""tns:EVENT_NOTIFICATION_DCMSRECORDINSERT"" />
  <xs:simpleType name=""ID__SIMPLE_TYPE"">
    <xs:restriction base=""xs:string"">
      <xs:maxLength value=""4000"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:complexType name=""ID__COMPLEX_TYPE"">
    <xs:simpleContent>
      <xs:extension base=""tns:ID__SIMPLE_TYPE"">
        <xs:attribute name=""InlineValue"" type=""xs:string"" use=""optional"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:simpleType name=""APP_NBR__SIMPLE_TYPE"">
    <xs:restriction base=""xs:string"">
      <xs:maxLength value=""30"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:complexType name=""APP_NBR__COMPLEX_TYPE"">
    <xs:simpleContent>
      <xs:extension base=""tns:APP_NBR__SIMPLE_TYPE"">
        <xs:attribute name=""InlineValue"" type=""xs:string"" use=""optional"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:simpleType name=""EVENT_TYPE__SIMPLE_TYPE"">
    <xs:restriction base=""xs:string"">
      <xs:maxLength value=""30"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:complexType name=""EVENT_TYPE__COMPLEX_TYPE"">
    <xs:simpleContent>
      <xs:extension base=""tns:EVENT_TYPE__SIMPLE_TYPE"">
        <xs:attribute name=""InlineValue"" type=""xs:string"" use=""optional"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:simpleType name=""EVENT_STATUS__SIMPLE_TYPE"">
    <xs:restriction base=""xs:string"">
      <xs:maxLength value=""30"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:complexType name=""EVENT_STATUS__COMPLEX_TYPE"">
    <xs:simpleContent>
      <xs:extension base=""tns:EVENT_STATUS__SIMPLE_TYPE"">
        <xs:attribute name=""InlineValue"" type=""xs:string"" use=""optional"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:simpleType name=""EVENT_DATA__SIMPLE_TYPE"">
    <xs:restriction base=""xs:string"">
      <xs:maxLength value=""64"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:complexType name=""EVENT_DATA__COMPLEX_TYPE"">
    <xs:simpleContent>
      <xs:extension base=""tns:EVENT_DATA__SIMPLE_TYPE"">
        <xs:attribute name=""InlineValue"" type=""xs:string"" use=""optional"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:simpleType name=""CREATED_BY__SIMPLE_TYPE"">
    <xs:restriction base=""xs:string"">
      <xs:maxLength value=""30"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:complexType name=""CREATED_BY__COMPLEX_TYPE"">
    <xs:simpleContent>
      <xs:extension base=""tns:CREATED_BY__SIMPLE_TYPE"">
        <xs:attribute name=""InlineValue"" type=""xs:string"" use=""optional"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:complexType name=""CREATION_DATE__COMPLEX_TYPE"">
    <xs:simpleContent>
      <xs:extension base=""xs:dateTime"">
        <xs:attribute name=""InlineValue"" type=""xs:string"" use=""optional"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:simpleType name=""LAST_UPDATED_BY__SIMPLE_TYPE"">
    <xs:restriction base=""xs:string"">
      <xs:maxLength value=""30"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:complexType name=""LAST_UPDATED_BY__COMPLEX_TYPE"">
    <xs:simpleContent>
      <xs:extension base=""tns:LAST_UPDATED_BY__SIMPLE_TYPE"">
        <xs:attribute name=""InlineValue"" type=""xs:string"" use=""optional"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:complexType name=""LAST_UPDATE_DATE__COMPLEX_TYPE"">
    <xs:simpleContent>
      <xs:extension base=""xs:dateTime"">
        <xs:attribute name=""InlineValue"" type=""xs:string"" use=""optional"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:complexType name=""ArrayOfEVENT_NOTIFICATION_DCMSRECORDINSERT"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""EVENT_NOTIFICATION_DCMSRECORDINSERT"" type=""tns:EVENT_NOTIFICATION_DCMSRECORDINSERT"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfEVENT_NOTIFICATION_DCMSRECORDINSERT"" nillable=""true"" type=""tns:ArrayOfEVENT_NOTIFICATION_DCMSRECORDINSERT"" />
  <xs:element name=""Insert"">
    <xs:annotation>
      <xs:documentation>
        <doc:action xmlns:doc=""http://schemas.microsoft.com/servicemodel/adapters/metadata/documentation"">http://Microsoft.LobServices.OracleDB/2007/03/DCMS_INT/View/EVENT_NOTIFICATION_DCMS/Insert</doc:action>
      </xs:documentation>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""RECORDSET"" nillable=""true"" type=""tns:ArrayOfEVENT_NOTIFICATION_DCMSRECORDINSERT"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""COLUMN_NAMES"" nillable=""true"" type=""xs:string"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""QUERY"" nillable=""true"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""InsertResponse"">
    <xs:annotation>
      <xs:documentation>
        <doc:action xmlns:doc=""http://schemas.microsoft.com/servicemodel/adapters/metadata/documentation"">http://Microsoft.LobServices.OracleDB/2007/03/DCMS_INT/View/EVENT_NOTIFICATION_DCMS/Insert/response</doc:action>
      </xs:documentation>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""1"" maxOccurs=""1"" name=""InsertResult"" type=""xs:integer"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public OracleEventNotification() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [4];
                _RootElements[0] = "EVENT_NOTIFICATION_DCMSRECORDINSERT";
                _RootElements[1] = "ArrayOfEVENT_NOTIFICATION_DCMSRECORDINSERT";
                _RootElements[2] = "Insert";
                _RootElements[3] = "InsertResponse";
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
        
        [Schema(@"http://Microsoft.LobServices.OracleDB/2007/03/DCMS_INT/View/EVENT_NOTIFICATION_DCMS",@"EVENT_NOTIFICATION_DCMSRECORDINSERT")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"EVENT_NOTIFICATION_DCMSRECORDINSERT"})]
        public sealed class EVENT_NOTIFICATION_DCMSRECORDINSERT : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public EVENT_NOTIFICATION_DCMSRECORDINSERT() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "EVENT_NOTIFICATION_DCMSRECORDINSERT";
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
        
        [Schema(@"http://Microsoft.LobServices.OracleDB/2007/03/DCMS_INT/View/EVENT_NOTIFICATION_DCMS",@"ArrayOfEVENT_NOTIFICATION_DCMSRECORDINSERT")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfEVENT_NOTIFICATION_DCMSRECORDINSERT"})]
        public sealed class ArrayOfEVENT_NOTIFICATION_DCMSRECORDINSERT : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfEVENT_NOTIFICATION_DCMSRECORDINSERT() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfEVENT_NOTIFICATION_DCMSRECORDINSERT";
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
        
        [Schema(@"http://Microsoft.LobServices.OracleDB/2007/03/DCMS_INT/View/EVENT_NOTIFICATION_DCMS",@"Insert")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"Insert"})]
        public sealed class Insert : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public Insert() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "Insert";
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
        
        [Schema(@"http://Microsoft.LobServices.OracleDB/2007/03/DCMS_INT/View/EVENT_NOTIFICATION_DCMS",@"InsertResponse")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"InsertResponse"})]
        public sealed class InsertResponse : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public InsertResponse() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "InsertResponse";
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
