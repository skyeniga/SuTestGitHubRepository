namespace SBA.DLAPDocumentUpload.Definition {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"DOCUMENT", @"DOCUMENTRESPONSE"})]
    public sealed class DocumentUpload : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://DocumentUploadDefinition.DocumentUpload"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://DocumentUploadDefinition.DocumentUpload"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""DOCUMENT"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""APPLICATION_NUMBER"" type=""xs:string"" />
        <xs:element name=""DOCUMENT_CONTENT"" type=""xs:string"" />
        <xs:element name=""CONTENT_TYPE"" type=""xs:string"" />
        <xs:element name=""FILE_NAME"" type=""xs:string"" />
        <xs:element name=""ACTION_ID"" type=""xs:string"" />
        <xs:element name=""USER_ID"" type=""xs:string"" />
        <xs:element name=""DOCUMENT_TYPE"" type=""xs:string"" />
        <xs:element name=""DOCUMENT_METADATA"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""DOCUMENTRESPONSE"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""Upload_Status"" type=""xs:string"" />
        <xs:element name=""Upload_Status_Details"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public DocumentUpload() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [2];
                _RootElements[0] = "DOCUMENT";
                _RootElements[1] = "DOCUMENTRESPONSE";
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
        
        [Schema(@"http://DocumentUploadDefinition.DocumentUpload",@"DOCUMENT")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"DOCUMENT"})]
        public sealed class DOCUMENT : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public DOCUMENT() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "DOCUMENT";
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
        
        [Schema(@"http://DocumentUploadDefinition.DocumentUpload",@"DOCUMENTRESPONSE")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"DOCUMENTRESPONSE"})]
        public sealed class DOCUMENTRESPONSE : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public DOCUMENTRESPONSE() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "DOCUMENTRESPONSE";
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
