
#pragma warning disable 162

namespace DLAPDocument
{

    [System.SerializableAttribute]
    sealed public class __DocumentRetrievalDefinition_DocumentRetrievalRequest__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static DocumentRetrievalDefinition.DocumentRetrievalRequest _schema = new DocumentRetrievalDefinition.DocumentRetrievalRequest();

        public __DocumentRetrievalDefinition_DocumentRetrievalRequest__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eNone,
        "",
        new System.Type[]{
            typeof(DocumentRetrievalDefinition.DocumentRetrievalRequest)
        },
        new string[]{
            "MessagePart"
        },
        new System.Type[]{
            typeof(__DocumentRetrievalDefinition_DocumentRetrievalRequest__)
        },
        0,
        @"http://SBA.gov/DLAPDocumentRetrieval/RetrievalRequest#RetrievalRequest"
    )]
    [System.SerializableAttribute]
    sealed internal class DocumentRetrievalRequestType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __DocumentRetrievalDefinition_DocumentRetrievalRequest__ MessagePart;

        private void __CreatePartWrappers()
        {
            MessagePart = new __DocumentRetrievalDefinition_DocumentRetrievalRequest__(this, "MessagePart", 0);
            this.AddPart("MessagePart", 0, MessagePart);
        }

        public DocumentRetrievalRequestType(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __DocumentRetrievalDefinition_DocumentRetrievalResponse__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static DocumentRetrievalDefinition.DocumentRetrievalResponse _schema = new DocumentRetrievalDefinition.DocumentRetrievalResponse();

        public __DocumentRetrievalDefinition_DocumentRetrievalResponse__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eNone,
        "",
        new System.Type[]{
            typeof(DocumentRetrievalDefinition.DocumentRetrievalResponse)
        },
        new string[]{
            "MessagePart"
        },
        new System.Type[]{
            typeof(__DocumentRetrievalDefinition_DocumentRetrievalResponse__)
        },
        0,
        @"http://SBA.gov/DLAPDocumentRetrieval/RetrievalResponse#RetrievalResponse"
    )]
    [System.SerializableAttribute]
    sealed internal class DocumentRetrievalResponseType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __DocumentRetrievalDefinition_DocumentRetrievalResponse__ MessagePart;

        private void __CreatePartWrappers()
        {
            MessagePart = new __DocumentRetrievalDefinition_DocumentRetrievalResponse__(this, "MessagePart", 0);
            this.AddPart("MessagePart", 0, MessagePart);
        }

        public DocumentRetrievalResponseType(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __DocumentRetrievalDefinition_DocumentRetrievalFault__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static DocumentRetrievalDefinition.DocumentRetrievalFault _schema = new DocumentRetrievalDefinition.DocumentRetrievalFault();

        public __DocumentRetrievalDefinition_DocumentRetrievalFault__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eNone,
        "",
        new System.Type[]{
            typeof(DocumentRetrievalDefinition.DocumentRetrievalFault)
        },
        new string[]{
            "MessagePart"
        },
        new System.Type[]{
            typeof(__DocumentRetrievalDefinition_DocumentRetrievalFault__)
        },
        0,
        @"http://SBA.gov/DLAPDocumentRetrieval/RetrievalFault#Fault"
    )]
    [System.SerializableAttribute]
    sealed internal class DocumentRetrievalFaultResponeType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __DocumentRetrievalDefinition_DocumentRetrievalFault__ MessagePart;

        private void __CreatePartWrappers()
        {
            MessagePart = new __DocumentRetrievalDefinition_DocumentRetrievalFault__(this, "MessagePart", 0);
            this.AddPart("MessagePart", 0, MessagePart);
        }

        public DocumentRetrievalFaultResponeType(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __DLAPDocumentRetrievalSalesforceDefinition_Rest_RestContentDocument_Request__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static DLAPDocumentRetrievalSalesforceDefinition.Rest.RestContentDocument.Request _schema = new DLAPDocumentRetrievalSalesforceDefinition.Rest.RestContentDocument.Request();

        public __DLAPDocumentRetrievalSalesforceDefinition_Rest_RestContentDocument_Request__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eNone,
        "",
        new System.Type[]{
            typeof(DLAPDocumentRetrievalSalesforceDefinition.Rest.RestContentDocument.Request)
        },
        new string[]{
            "MessagePart"
        },
        new System.Type[]{
            typeof(__DLAPDocumentRetrievalSalesforceDefinition_Rest_RestContentDocument_Request__)
        },
        0,
        @"http://SBA.gov/DLAPDocumentRetrieval/REST/QUERY/ContentDocument#Request"
    )]
    [System.SerializableAttribute]
    sealed internal class RestContentVersionQueryRequestType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __DLAPDocumentRetrievalSalesforceDefinition_Rest_RestContentDocument_Request__ MessagePart;

        private void __CreatePartWrappers()
        {
            MessagePart = new __DLAPDocumentRetrievalSalesforceDefinition_Rest_RestContentDocument_Request__(this, "MessagePart", 0);
            this.AddPart("MessagePart", 0, MessagePart);
        }

        public RestContentVersionQueryRequestType(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __Microsoft_XLANGs_BaseTypes_Any__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static Microsoft.XLANGs.BaseTypes.Any _schema = new Microsoft.XLANGs.BaseTypes.Any();

        public __Microsoft_XLANGs_BaseTypes_Any__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eNone,
        "",
        new System.Type[]{
            typeof(Microsoft.XLANGs.BaseTypes.Any)
        },
        new string[]{
            "MessagePart"
        },
        new System.Type[]{
            typeof(__Microsoft_XLANGs_BaseTypes_Any__)
        },
        0,
        Microsoft.XLANGs.Core.XMessage.AnyMessageTypeName
    )]
    [System.SerializableAttribute]
    sealed internal class RestContentVersionDataQueryResponseType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __Microsoft_XLANGs_BaseTypes_Any__ MessagePart;

        private void __CreatePartWrappers()
        {
            MessagePart = new __Microsoft_XLANGs_BaseTypes_Any__(this, "MessagePart", 0);
            this.AddPart("MessagePart", 0, MessagePart);
        }

        public RestContentVersionDataQueryResponseType(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __DLAPDocumentRetrievalSalesforceDefinition_Rest_RestContentDocument_QueryResult__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static DLAPDocumentRetrievalSalesforceDefinition.Rest.RestContentDocument.QueryResult _schema = new DLAPDocumentRetrievalSalesforceDefinition.Rest.RestContentDocument.QueryResult();

        public __DLAPDocumentRetrievalSalesforceDefinition_Rest_RestContentDocument_QueryResult__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eNone,
        "",
        new System.Type[]{
            typeof(DLAPDocumentRetrievalSalesforceDefinition.Rest.RestContentDocument.QueryResult)
        },
        new string[]{
            "MessagePart"
        },
        new System.Type[]{
            typeof(__DLAPDocumentRetrievalSalesforceDefinition_Rest_RestContentDocument_QueryResult__)
        },
        0,
        @"http://SBA.gov/DLAPDocumentRetrieval/REST/QUERY/ContentDocument#QueryResult"
    )]
    [System.SerializableAttribute]
    sealed internal class RestContentVersionQueryResponseType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __DLAPDocumentRetrievalSalesforceDefinition_Rest_RestContentDocument_QueryResult__ MessagePart;

        private void __CreatePartWrappers()
        {
            MessagePart = new __DLAPDocumentRetrievalSalesforceDefinition_Rest_RestContentDocument_QueryResult__(this, "MessagePart", 0);
            this.AddPart("MessagePart", 0, MessagePart);
        }

        public RestContentVersionQueryResponseType(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __DLAPDocumentRetrievalSalesforceDefinition_Rest_RestEvent_SaveRequest__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static DLAPDocumentRetrievalSalesforceDefinition.Rest.RestEvent.SaveRequest _schema = new DLAPDocumentRetrievalSalesforceDefinition.Rest.RestEvent.SaveRequest();

        public __DLAPDocumentRetrievalSalesforceDefinition_Rest_RestEvent_SaveRequest__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eNone,
        "",
        new System.Type[]{
            typeof(DLAPDocumentRetrievalSalesforceDefinition.Rest.RestEvent.SaveRequest)
        },
        new string[]{
            "MessagePart"
        },
        new System.Type[]{
            typeof(__DLAPDocumentRetrievalSalesforceDefinition_Rest_RestEvent_SaveRequest__)
        },
        0,
        @"http://SBA.gov/DLAPDocumentRetrieval/REST/INSERT/EventRequest#SaveRequest"
    )]
    [System.SerializableAttribute]
    sealed internal class RestEventRequestType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __DLAPDocumentRetrievalSalesforceDefinition_Rest_RestEvent_SaveRequest__ MessagePart;

        private void __CreatePartWrappers()
        {
            MessagePart = new __DLAPDocumentRetrievalSalesforceDefinition_Rest_RestEvent_SaveRequest__(this, "MessagePart", 0);
            this.AddPart("MessagePart", 0, MessagePart);
        }

        public RestEventRequestType(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __DLAPDocumentRetrievalSalesforceDefinition_Rest_RestEvent_results__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static DLAPDocumentRetrievalSalesforceDefinition.Rest.RestEvent.results _schema = new DLAPDocumentRetrievalSalesforceDefinition.Rest.RestEvent.results();

        public __DLAPDocumentRetrievalSalesforceDefinition_Rest_RestEvent_results__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eNone,
        "",
        new System.Type[]{
            typeof(DLAPDocumentRetrievalSalesforceDefinition.Rest.RestEvent.results)
        },
        new string[]{
            "MessagePart"
        },
        new System.Type[]{
            typeof(__DLAPDocumentRetrievalSalesforceDefinition_Rest_RestEvent_results__)
        },
        0,
        @"http://SBA.gov/DLAPDocumentRetrieval/REST/INSERT/EventRequest#results"
    )]
    [System.SerializableAttribute]
    sealed internal class RestEventResponseType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __DLAPDocumentRetrievalSalesforceDefinition_Rest_RestEvent_results__ MessagePart;

        private void __CreatePartWrappers()
        {
            MessagePart = new __DLAPDocumentRetrievalSalesforceDefinition_Rest_RestEvent_results__(this, "MessagePart", 0);
            this.AddPart("MessagePart", 0, MessagePart);
        }

        public RestEventResponseType(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation",
        new System.Type[]{
            typeof(DLAPDocument.RestContentVersionQueryRequestType), 
            typeof(DLAPDocument.RestContentVersionQueryResponseType)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class RestContentVersionQueryPortType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public RestContentVersionQueryPortType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public RestContentVersionQueryPortType(RestContentVersionQueryPortType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            RestContentVersionQueryPortType p = new RestContentVersionQueryPortType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation",
            System.Web.Services.Description.OperationFlow.RequestResponse,
            typeof(RestContentVersionQueryPortType),
            typeof(RestContentVersionQueryRequestType),
            typeof(RestContentVersionQueryResponseType),
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "Operation" ] = Operation;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation",
        new System.Type[]{
            typeof(DLAPDocument.DocumentRetrievalRequestType), 
            typeof(DLAPDocument.DocumentRetrievalResponseType), 
            typeof(DLAPDocument.DocumentRetrievalFaultResponeType)
        },
        new string[]{
            "Fault"
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class DocumentRetrievalPortType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public DocumentRetrievalPortType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public DocumentRetrievalPortType(DocumentRetrievalPortType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            DocumentRetrievalPortType p = new DocumentRetrievalPortType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation",
            System.Web.Services.Description.OperationFlow.RequestResponse,
            typeof(DocumentRetrievalPortType),
            typeof(DocumentRetrievalRequestType),
            typeof(DocumentRetrievalResponseType),
            new System.Type[]{
                typeof(DocumentRetrievalFaultResponeType)
            },
            new string[]{
                "Fault"
            }
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "Operation" ] = Operation;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation",
        new System.Type[]{
            typeof(DLAPDocument.RestContentVersionQueryRequestType), 
            typeof(DLAPDocument.RestContentVersionDataQueryResponseType)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class RestContentVersionDataQueryPortType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public RestContentVersionDataQueryPortType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public RestContentVersionDataQueryPortType(RestContentVersionDataQueryPortType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            RestContentVersionDataQueryPortType p = new RestContentVersionDataQueryPortType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation",
            System.Web.Services.Description.OperationFlow.RequestResponse,
            typeof(RestContentVersionDataQueryPortType),
            typeof(RestContentVersionQueryRequestType),
            typeof(RestContentVersionDataQueryResponseType),
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "Operation" ] = Operation;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation",
        new System.Type[]{
            typeof(DLAPDocument.RestEventRequestType), 
            typeof(DLAPDocument.RestEventResponseType)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class RestEventPortType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public RestEventPortType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public RestEventPortType(RestEventPortType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            RestEventPortType p = new RestEventPortType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation",
            System.Web.Services.Description.OperationFlow.RequestResponse,
            typeof(RestEventPortType),
            typeof(RestEventRequestType),
            typeof(RestEventResponseType),
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "Operation" ] = Operation;
                return h;
            }
        }
        #endregion // port reflection support
    }
    //#line 867 "C:\Users\skyeniga\Source\Repos\Biztalk\DLAP Document Retrieval\Document Retrieval Logic\Retrieval Logic.odx"
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        0, "DocumentRetrievalPort", "Operation", -1, -1, true
    )]
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        },
        new System.Type[] {
            typeof(DLAPDocument.DocumentRetrievalPortType),
            typeof(DLAPDocument.RestContentVersionQueryPortType),
            typeof(DLAPDocument.RestContentVersionDataQueryPortType)
        },
        new System.String[] {
            "DocumentRetrievalPort",
            "RestContentVersionQueryPort",
            "RestContentVersionDataQueryPort"
        },
        new System.Type[] {
            null,
            null,
            null
        }
    )]
    [Microsoft.XLANGs.BaseTypes.ServiceCallTreeAttribute(
        new System.Type[] {
            typeof(DLAPDocument.RetrievalEventRequest),
            typeof(DLAPDocument.RetrievalEventRequest)
        },
        new System.Type[] {
        },
        new System.Type[] {
        }
    )]
    [Microsoft.XLANGs.BaseTypes.ServiceAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSServiceInfo.eNone
    )]
    [System.SerializableAttribute]
    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed internal class RetrievalLogic : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
    {
        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        public static readonly bool __execable = false;
        [Microsoft.XLANGs.BaseTypes.CallCompensationAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSCallCompensationInfo.eHasRequestResponse
,
            new System.String[] {
                "DLAPDocument.RetrievalEventRequest",
                "DLAPDocument.RetrievalEventRequest"
            },
            new System.String[] {
            }
        )]
        public static void __bodyProxy()
        {
        }
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(RetrievalLogic));
        private static volatile System.Guid[] _activationSubIds;

        private static new object _lockIdentity = new object();

        public static System.Guid UUID { get { return _serviceId; } }
        public override System.Guid ServiceId { get { return UUID; } }

        protected override System.Guid[] ActivationSubGuids
        {
            get { return _activationSubIds; }
            set { _activationSubIds = value; }
        }

        protected override object StaleStateLock
        {
            get { return _lockIdentity; }
        }

        protected override bool HasActivation { get { return true; } }

        internal bool IsExeced = false;

        static RetrievalLogic()
        {
            Microsoft.BizTalk.XLANGs.BTXEngine.BTXService.CacheStaticState( _serviceId );
        }

        private void ConstructorHelper()
        {
            _segments = new Microsoft.XLANGs.Core.Segment[] {
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment0), 0, 0, 0),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment1), 1, 1, 1),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment2), 1, 2, 2),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment3), 1, 2, 3)
            };

            _Locks = 0;
            _rootContext = new __RetrievalLogic_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[5];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public RetrievalLogic(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "RetrievalLogic", tracker)
        {
            ConstructorHelper();
        }

        public RetrievalLogic(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "RetrievalLogic")
        {
            ConstructorHelper();
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>95dcd9e8-e597-4b54-983d-fa38aa265cd4</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>d297f1d8-b13d-4b1e-857d-606b3a29373a</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Receive Document Retrieval Request</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>TaskShape</shapeType>      <ShapeID>03a14c44-0041-4bc5-b3ce-8086df74e5d7</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Document Retrieval Processing</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ScopeShape</shapeType>      <ShapeID>bd4b49c5-c4b6-43ad-85fb-07659d9f63e9</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Document Retrieval Processing Error Scope</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>77957e96-3e00-4588-b339-6b103aa76ece</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Validation</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionShape</shapeType>      <ShapeID>47438fb2-de62-4131-8367-f9604590c5d4</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Content Version ID Exists?</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>39a47f62-e3b0-4d65-8ac7-c720451c091d</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>Exists</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>ef317496-6a7e-4755-ae00-dbc0ac790925</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Construct Content Version Request Msg</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>314bcc89-eff6-43b4-a2cb-fae83b2c014e</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Make ContentVersion Request Msg</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>ed220e44-3dcd-4d33-9d97-1fc29291453a</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>1ad12a73-e0ae-467d-817f-8c9da45f58b0</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>fd7efeb4-f48b-4a23-949e-a0b1d6683f17</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Make SOQL</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>9d72a40d-afd0-401c-aeda-24c04e8389fd</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>bcda904c-0fb9-4e6b-ac9f-58d51237c345</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Send ContentVersion Request</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>b57f62af-3fac-4980-8458-ecbf12bf1fa9</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Receive ContentVersion Response</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>ac4930fe-855f-490e-9a8c-176062b498d9</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Construct Content Version Request Msg</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>c9a7a91f-a0b2-4b3d-a220-d64673b17301</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>4a60756a-e269-4892-831e-1637a93a5040</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Make ContentVersion Request Msg</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>3737dc55-5c2e-4c85-8f57-53d0230bf63d</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>201b8ffe-4ae2-4e6b-b01a-2f98546a28d6</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>dbcf7970-bb38-42a6-b3be-3cda9b64275a</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Make SOQL</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>67d1112b-799d-49d3-8f4b-8ddb139f3d6f</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Send ContentVersion Request</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>085faf9a-f30d-44e2-aa7c-96254e1ecdb2</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Receive ContentVersion Response</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>daa977ba-8ca4-417c-a2c5-1eafc90c2139</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Construct Document Retrieval Response Msg</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>df8bf63a-0c05-425b-b790-5978ef90f12a</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>c2e70145-fdfe-4b95-a3d2-da7dbaf41a4b</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Make Document Retrieval Response</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>7faa51a2-c9bf-4757-bb5e-6b79ace1c277</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_3</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>566ad007-9fd9-4c3d-b2b4-1839bc5f1ec3</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_4</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>0d785bef-2903-4dcf-a85e-383d0ebfd628</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Inject Content</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>dade47f9-f25a-4c2a-8ee3-0f2b08b930ac</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Flag</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>1372ce17-f7a2-43cb-b52f-083d2414f794</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>Else</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>23b1f29f-a2e1-4113-9a3b-951fa5c2ce14</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Construct Document Retrieval Error Response Msg</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>a9912b3d-7b3a-4292-b8d2-e96210c2e95c</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>974a19e8-4308-4e4b-a6f2-14481d4e9143</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Make Document Error Response</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionShape</shapeType>      <ShapeID>adef182e-2ab7-48e7-8245-6c2fb57f6b6d</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Success Response?</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>da4c7284-8c3f-4e23-ab60-25f6ea1d2748</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>Success</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>af518bbf-a7b6-4dcd-8d73-a42c86b597cc</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Set Success Values For Salesforce</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>6208627b-3e45-455d-8074-c736c91294f8</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>Error</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>02618de8-1e05-4ecf-b065-e7096a1e2569</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Set Error Values For Salesforce</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>CatchShape</shapeType>      <ShapeID>49b890ab-e5e8-4e11-a6b6-b84a61f775df</ShapeID>      <ParentLink>Scope_Catch</ParentLink>                <shapeText>System Exception</shapeText>                      <ExceptionType>System.SystemException</ExceptionType>            
<children>                          
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>65d79f22-e39b-44ee-9f98-0a5e03f6fc4a</ShapeID>      <ParentLink>Catch_Statement</ParentLink>                <shapeText>Set Error Values For Salesforce</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>8cd73496-eb82-444c-bf44-44ed264dbb55</ShapeID>      <ParentLink>Catch_Statement</ParentLink>                <shapeText>Construct Document Retrieval Fault Response</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>3ebc812f-752b-4908-895b-b5b96b7e307a</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Make Document Error Response</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>17058116-f756-441c-aaf0-72fec62f1b44</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>275ccecb-abca-48c5-ac88-53a9cd55901f</ShapeID>      <ParentLink>Catch_Statement</ParentLink>                <shapeText>Send Fault Response</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>CallShape</shapeType>      <ShapeID>ace15ead-b3f9-45ca-a110-705d13a29ea8</ShapeID>      <ParentLink>Catch_Statement</ParentLink>                <shapeText>Call SalesForce Event Logging Orchestration</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>094a0043-1a29-4c74-949a-61edcfe0def3</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>Application</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>a276aed8-9d8c-4843-8dc3-decedcf88708</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>SalesForceObjectId</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>404a0a0a-3b94-4685-a09a-b4af6e9b8c20</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>Message</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>9ad60eb8-20d5-4404-b797-89846f4e8ce5</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>SalesForceObjectName</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>70b3ae92-5d68-46cc-91ca-5d621f100077</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>Status</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>da64003f-6925-474f-b3ac-695a6feb8f94</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>Status</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>f2063d25-9007-43b8-b043-06465c037819</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>Empty</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>6a0cceae-e791-4849-b667-a0cea2b23d4c</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>OrchestrationInstanceId</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>TerminateShape</shapeType>      <ShapeID>382be502-eab5-4ca9-b41f-2ba96fa6d001</ShapeID>      <ParentLink>Catch_Statement</ParentLink>                <shapeText>Terminate</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>2ba8538d-c9e7-48be-a331-99829ed8ef68</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Send Document Error Response</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>CallShape</shapeType>      <ShapeID>f5be43e7-4177-4c04-b09a-087cdcb31e4e</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Call SalesForce Event Logging Orchestration</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>e9e76345-19eb-4e1e-ab1e-22d2ebe68833</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>Application</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>6eef7f2e-aaf3-496a-a674-56f9812a98f3</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>SalesForceObjectId</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>9aea2fdd-74a3-4a91-9d51-b50d7d1a71df</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>Message</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>ddf174c3-f857-43dc-9c54-9afc627293eb</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>SalesForceObjectName</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>cb48dc4c-00e2-499c-bbf8-2c74242401ed</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>Stage</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>8090ba90-ee6f-4bc5-867e-f3584abe5c3b</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>Status</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>013d5b7e-b341-46df-934a-23289bcd7459</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>Empty</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>8e19a8ad-6c14-4674-b391-486ce4635aa6</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>OrchestrationInstanceId</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow><Metadata>

<TrkMetadata>
<ActionName>'RetrievalLogic'</ActionName><IsAtomic>0</IsAtomic><Line>867</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
</TrkMetadata>

<TrkMetadata>
<Line>901</Line><Position>22</Position><ShapeID>'d297f1d8-b13d-4b1e-857d-606b3a29373a'</ShapeID>
<Messages>
	<MsgInfo><name>DocumentRetrievalRequestMsg</name><part>MessagePart</part><schema>DocumentRetrievalDefinition.DocumentRetrievalRequest</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<ActionName>'??__scope35'</ActionName><IsAtomic>0</IsAtomic><Line>918</Line><Position>13</Position><ShapeID>'bd4b49c5-c4b6-43ad-85fb-07659d9f63e9'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>923</Line><Position>38</Position><ShapeID>'77957e96-3e00-4588-b339-6b103aa76ece'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>930</Line><Position>21</Position><ShapeID>'47438fb2-de62-4131-8367-f9604590c5d4'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>933</Line><Position>25</Position><ShapeID>'ef317496-6a7e-4755-ae00-dbc0ac790925'</ShapeID>
<Messages>
	<MsgInfo><name>RestContentVersionQueryRequestMsg</name><part>MessagePart</part><schema>DLAPDocumentRetrievalSalesforceDefinition.Rest.RestContentDocument+Request</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>DocumentRetrievalRequestMsg</name><part>MessagePart</part><schema>DocumentRetrievalDefinition.DocumentRetrievalRequest</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>946</Line><Position>25</Position><ShapeID>'bcda904c-0fb9-4e6b-ac9f-58d51237c345'</ShapeID>
<Messages>
	<MsgInfo><name>RestContentVersionQueryRequestMsg</name><part>MessagePart</part><schema>DLAPDocumentRetrievalSalesforceDefinition.Rest.RestContentDocument+Request</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>948</Line><Position>25</Position><ShapeID>'b57f62af-3fac-4980-8458-ecbf12bf1fa9'</ShapeID>
<Messages>
	<MsgInfo><name>RestContentVersionQueryResponseMsg</name><part>MessagePart</part><schema>DLAPDocumentRetrievalSalesforceDefinition.Rest.RestContentDocument+QueryResult</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>950</Line><Position>25</Position><ShapeID>'ac4930fe-855f-490e-9a8c-176062b498d9'</ShapeID>
<Messages>
	<MsgInfo><name>RestContentVersionQueryRequestMsg</name><part>MessagePart</part><schema>DLAPDocumentRetrievalSalesforceDefinition.Rest.RestContentDocument+Request</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>DocumentRetrievalRequestMsg</name><part>MessagePart</part><schema>DocumentRetrievalDefinition.DocumentRetrievalRequest</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>965</Line><Position>25</Position><ShapeID>'67d1112b-799d-49d3-8f4b-8ddb139f3d6f'</ShapeID>
<Messages>
	<MsgInfo><name>RestContentVersionQueryRequestMsg</name><part>MessagePart</part><schema>DLAPDocumentRetrievalSalesforceDefinition.Rest.RestContentDocument+Request</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>967</Line><Position>25</Position><ShapeID>'085faf9a-f30d-44e2-aa7c-96254e1ecdb2'</ShapeID>
<Messages>
	<MsgInfo><name>RestContentVersionDataQueryResponseMsg</name><part>MessagePart</part><schema>Microsoft.XLANGs.BaseTypes.Any</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>969</Line><Position>25</Position><ShapeID>'daa977ba-8ca4-417c-a2c5-1eafc90c2139'</ShapeID>
<Messages>
	<MsgInfo><name>DocumentRetrievalResponseMsg</name><part>MessagePart</part><schema>DocumentRetrievalDefinition.DocumentRetrievalResponse</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>RestContentVersionQueryResponseMsg</name><part>MessagePart</part><schema>DLAPDocumentRetrievalSalesforceDefinition.Rest.RestContentDocument+QueryResult</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>977</Line><Position>30</Position><ShapeID>'dade47f9-f25a-4c2a-8ee3-0f2b08b930ac'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>984</Line><Position>25</Position><ShapeID>'23b1f29f-a2e1-4113-9a3b-951fa5c2ce14'</ShapeID>
<Messages>
	<MsgInfo><name>DocumentRetrievalResponseMsg</name><part>MessagePart</part><schema>DocumentRetrievalDefinition.DocumentRetrievalResponse</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>998</Line><Position>21</Position><ShapeID>'adef182e-2ab7-48e7-8245-6c2fb57f6b6d'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1002</Line><Position>49</Position><ShapeID>'af518bbf-a7b6-4dcd-8d73-a42c86b597cc'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1017</Line><Position>49</Position><ShapeID>'02618de8-1e05-4ecf-b065-e7096a1e2569'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1035</Line><Position>21</Position><ShapeID>'49b890ab-e5e8-4e11-a6b6-b84a61f775df'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1038</Line><Position>25</Position><ShapeID>'65d79f22-e39b-44ee-9f98-0a5e03f6fc4a'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1077</Line><Position>25</Position><ShapeID>'8cd73496-eb82-444c-bf44-44ed264dbb55'</ShapeID>
<Messages>
	<MsgInfo><name>DocumentRetrievalFaultResponeMsg</name><part>MessagePart</part><schema>DocumentRetrievalDefinition.DocumentRetrievalFault</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1087</Line><Position>25</Position><ShapeID>'275ccecb-abca-48c5-ac88-53a9cd55901f'</ShapeID>
<Messages>
	<MsgInfo><name>DocumentRetrievalFaultResponeMsg</name><part>MessagePart</part><schema>DocumentRetrievalDefinition.DocumentRetrievalFault</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1089</Line><Position>65</Position><ShapeID>'ace15ead-b3f9-45ca-a110-705d13a29ea8'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1091</Line><Position>25</Position><ShapeID>'382be502-eab5-4ca9-b41f-2ba96fa6d001'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1096</Line><Position>13</Position><ShapeID>'2ba8538d-c9e7-48be-a331-99829ed8ef68'</ShapeID>
<Messages>
	<MsgInfo><name>DocumentRetrievalResponseMsg</name><part>MessagePart</part><schema>DocumentRetrievalDefinition.DocumentRetrievalResponse</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1098</Line><Position>53</Position><ShapeID>'f5be43e7-4177-4c04-b09a-087cdcb31e4e'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='c12a95df-d107-4953-aedf-3771585dbe68' LowerBound='1.1' HigherBound='285.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='DLAPDocument' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='ServiceDeclaration' OID='bb043a5a-d1fa-43cd-944a-741d7420d8ff' ParentLink='Module_ServiceDeclaration' LowerBound='49.1' HigherBound='284.1'>
            <om:Property Name='InitializedTransactionType' Value='False' />
            <om:Property Name='IsInvokable' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='RetrievalLogic' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='VariableDeclaration' OID='5828b207-2b29-4dd1-813c-8320afd248d1' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='64.1' HigherBound='65.1'>
                <om:Property Name='UseDefaultConstructor' Value='True' />
                <om:Property Name='Type' Value='System.Xml.XmlDocument' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='TempErrorResponse' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='37f1fce5-62d9-4b72-9545-874e756240b4' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='65.1' HigherBound='66.1'>
                <om:Property Name='InitialValue' Value='true' />
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.Boolean' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ContentVersionIDStatus' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='1345cd33-7330-4065-ab4f-75750d08cce4' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='66.1' HigherBound='67.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ContentVersionID' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='22d7d7e8-b275-4972-967f-0d6081b1f74e' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='67.1' HigherBound='68.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.Guid' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='OrchestrationInstanceId' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='0175d1f2-b279-4018-a35d-992d17a5e33b' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='68.1' HigherBound='69.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Message' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='5cc0947a-cc38-418d-a428-bd1c2737d499' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='69.1' HigherBound='70.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SalesForceObjectName' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='4d78e0db-6be9-4ab6-a690-87b0d7686234' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='70.1' HigherBound='71.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Stage' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='30e02608-14d9-41b6-b217-c35801e3f088' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='71.1' HigherBound='72.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Status' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='9c5f6912-4e7f-4ee1-a36e-a3fb0ce451a7' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='72.1' HigherBound='73.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='MessageTemp' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='a642dd0e-952d-49a6-8f2f-ba96abbc1183' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='73.1' HigherBound='74.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SalesForceObjectId' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='a37ec4ba-6ecd-4ce2-bbc7-3f11e3d8e75e' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='74.1' HigherBound='75.1'>
                <om:Property Name='InitialValue' Value='true' />
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.Boolean' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Flag' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='9bbb7407-c1b0-4e12-9932-cf68b9d876b5' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='75.1' HigherBound='76.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ResponseStatus' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='7e7370d7-9a02-47e2-9c82-219fdfca2e2e' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='76.1' HigherBound='77.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Application' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='6e325e61-a805-4b81-bd34-6374b7e035a0' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='77.1' HigherBound='78.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SOQL_ContentVersion_QUERY' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='729f2d8a-a16c-4a57-b6b8-03b61854c85c' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='78.1' HigherBound='79.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.Byte' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ContentVersionBytes' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='ca1df1ee-101a-4ae7-9e03-cd7d5bfd2123' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='79.1' HigherBound='80.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Base64String' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='7d6cfdd7-451e-4555-b0f4-e34f694c722c' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='80.1' HigherBound='81.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Empty' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='b1f25fcd-67ff-41e2-90e2-70c3443344c7' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='58.1' HigherBound='59.1'>
                <om:Property Name='Type' Value='DLAPDocument.DocumentRetrievalRequestType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='DocumentRetrievalRequestMsg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='16a4b6c4-b6d2-4076-bc87-cf65e4bd56a0' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='59.1' HigherBound='60.1'>
                <om:Property Name='Type' Value='DLAPDocument.DocumentRetrievalResponseType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='DocumentRetrievalResponseMsg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='1dedf206-3925-47e6-80ab-6ac7ee556072' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='60.1' HigherBound='61.1'>
                <om:Property Name='Type' Value='DLAPDocument.DocumentRetrievalFaultResponeType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='DocumentRetrievalFaultResponeMsg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='c52f45a3-f398-4b68-a19f-affc69877c74' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='61.1' HigherBound='62.1'>
                <om:Property Name='Type' Value='DLAPDocument.RestContentVersionQueryRequestType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='RestContentVersionQueryRequestMsg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='3878c32b-1709-49e4-adb1-2e5fc587a090' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='62.1' HigherBound='63.1'>
                <om:Property Name='Type' Value='DLAPDocument.RestContentVersionDataQueryResponseType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='RestContentVersionDataQueryResponseMsg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='cf9a1a99-3010-4d17-88ac-893432e330d3' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='63.1' HigherBound='64.1'>
                <om:Property Name='Type' Value='DLAPDocument.RestContentVersionQueryResponseType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='RestContentVersionQueryResponseMsg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='ServiceBody' OID='95dcd9e8-e597-4b54-983d-fa38aa265cd4' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='Receive' OID='d297f1d8-b13d-4b1e-857d-606b3a29373a' ParentLink='ServiceBody_Statement' LowerBound='83.1' HigherBound='100.1'>
                    <om:Property Name='Activate' Value='True' />
                    <om:Property Name='PortName' Value='DocumentRetrievalPort' />
                    <om:Property Name='MessageName' Value='DocumentRetrievalRequestMsg' />
                    <om:Property Name='OperationName' Value='Operation' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Receive Document Retrieval Request' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Task' OID='03a14c44-0041-4bc5-b3ce-8086df74e5d7' ParentLink='ServiceBody_Statement' LowerBound='100.1' HigherBound='278.1'>
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Document Retrieval Processing' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='Scope' OID='bd4b49c5-c4b6-43ad-85fb-07659d9f63e9' ParentLink='ComplexStatement_Statement' LowerBound='100.1' HigherBound='278.1'>
                        <om:Property Name='InitializedTransactionType' Value='True' />
                        <om:Property Name='IsSynchronized' Value='False' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Document Retrieval Processing Error Scope' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='VariableAssignment' OID='77957e96-3e00-4588-b339-6b103aa76ece' ParentLink='ComplexStatement_Statement' LowerBound='105.1' HigherBound='112.1'>
                            <om:Property Name='Expression' Value='ContentVersionID = xpath(DocumentRetrievalRequestMsg.MessagePart,&quot;string(/*[local-name()=&apos;RetrievalRequest&apos; and namespace-uri()=&apos;http://SBA.gov/DLAPDocumentRetrieval/RetrievalRequest&apos;]/*[local-name()=&apos;SDCID&apos; and namespace-uri()=&apos;&apos;])&quot;);&#xD;&#xA;&#xD;&#xA;if(!System.String.IsNullOrWhiteSpace(ContentVersionID))&#xD;&#xA;{ContentVersionIDStatus = true;}&#xD;&#xA;else{ContentVersionIDStatus = false;}&#xD;&#xA;&#xD;&#xA;' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Validation' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                        <om:Element Type='Decision' OID='47438fb2-de62-4131-8367-f9604590c5d4' ParentLink='ComplexStatement_Statement' LowerBound='112.1' HigherBound='180.1'>
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Content Version ID Exists?' />
                            <om:Property Name='Signal' Value='True' />
                            <om:Element Type='DecisionBranch' OID='39a47f62-e3b0-4d65-8ac7-c720451c091d' ParentLink='ReallyComplexStatement_Branch' LowerBound='113.21' HigherBound='164.1'>
                                <om:Property Name='Expression' Value='ContentVersionIDStatus == true' />
                                <om:Property Name='IsGhostBranch' Value='True' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Exists' />
                                <om:Property Name='Signal' Value='True' />
                                <om:Element Type='Construct' OID='ef317496-6a7e-4755-ae00-dbc0ac790925' ParentLink='ComplexStatement_Statement' LowerBound='115.1' HigherBound='128.1'>
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='Construct Content Version Request Msg' />
                                    <om:Property Name='Signal' Value='True' />
                                    <om:Element Type='Transform' OID='314bcc89-eff6-43b4-a2cb-fae83b2c014e' ParentLink='ComplexStatement_Statement' LowerBound='118.1' HigherBound='120.1'>
                                        <om:Property Name='ClassName' Value='DocumentRetrievalLogic.MakeContentVersionRequestMsg' />
                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                        <om:Property Name='Name' Value='Make ContentVersion Request Msg' />
                                        <om:Property Name='Signal' Value='False' />
                                        <om:Element Type='MessagePartRef' OID='ed220e44-3dcd-4d33-9d97-1fc29291453a' ParentLink='Transform_InputMessagePartRef' LowerBound='119.142' HigherBound='119.181'>
                                            <om:Property Name='MessageRef' Value='DocumentRetrievalRequestMsg' />
                                            <om:Property Name='PartRef' Value='MessagePart' />
                                            <om:Property Name='ReportToAnalyst' Value='True' />
                                            <om:Property Name='Name' Value='MessagePartReference_1' />
                                            <om:Property Name='Signal' Value='False' />
                                        </om:Element>
                                        <om:Element Type='MessagePartRef' OID='1ad12a73-e0ae-467d-817f-8c9da45f58b0' ParentLink='Transform_OutputMessagePartRef' LowerBound='119.40' HigherBound='119.85'>
                                            <om:Property Name='MessageRef' Value='RestContentVersionQueryRequestMsg' />
                                            <om:Property Name='PartRef' Value='MessagePart' />
                                            <om:Property Name='ReportToAnalyst' Value='True' />
                                            <om:Property Name='Name' Value='MessagePartReference_2' />
                                            <om:Property Name='Signal' Value='False' />
                                        </om:Element>
                                    </om:Element>
                                    <om:Element Type='MessageAssignment' OID='fd7efeb4-f48b-4a23-949e-a0b1d6683f17' ParentLink='ComplexStatement_Statement' LowerBound='120.1' HigherBound='127.1'>
                                        <om:Property Name='Expression' Value='SOQL_ContentVersion_QUERY = @&quot;Select Id, LatestPublishedVersion.Id, LatestPublishedVersion.VersionData, LatestPublishedVersion.FileType from ContentDocument where LatestPublishedVersion.Id IN &quot;+&quot;(&quot;+&quot;&apos;&quot;+ContentVersionID+&quot;&apos;&quot;+&quot;)&quot;;&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;RestContentVersionQueryRequestMsg(DLAPDocumentRetrievalSalesforceDefinition.Rest.SOQL_ContentVersion_Query) = SOQL_ContentVersion_QUERY; &#xD;&#xA;&#xD;&#xA;&#xD;&#xA;' />
                                        <om:Property Name='ReportToAnalyst' Value='False' />
                                        <om:Property Name='Name' Value='Make SOQL' />
                                        <om:Property Name='Signal' Value='False' />
                                    </om:Element>
                                    <om:Element Type='MessageRef' OID='9d72a40d-afd0-401c-aeda-24c04e8389fd' ParentLink='Construct_MessageRef' LowerBound='116.35' HigherBound='116.68'>
                                        <om:Property Name='Ref' Value='RestContentVersionQueryRequestMsg' />
                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                        <om:Property Name='Signal' Value='False' />
                                    </om:Element>
                                </om:Element>
                                <om:Element Type='Send' OID='bcda904c-0fb9-4e6b-ac9f-58d51237c345' ParentLink='ComplexStatement_Statement' LowerBound='128.1' HigherBound='130.1'>
                                    <om:Property Name='PortName' Value='RestContentVersionQueryPort' />
                                    <om:Property Name='MessageName' Value='RestContentVersionQueryRequestMsg' />
                                    <om:Property Name='OperationName' Value='Operation' />
                                    <om:Property Name='OperationMessageName' Value='Request' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='Send ContentVersion Request' />
                                    <om:Property Name='Signal' Value='True' />
                                </om:Element>
                                <om:Element Type='Receive' OID='b57f62af-3fac-4980-8458-ecbf12bf1fa9' ParentLink='ComplexStatement_Statement' LowerBound='130.1' HigherBound='132.1'>
                                    <om:Property Name='Activate' Value='False' />
                                    <om:Property Name='PortName' Value='RestContentVersionQueryPort' />
                                    <om:Property Name='MessageName' Value='RestContentVersionQueryResponseMsg' />
                                    <om:Property Name='OperationName' Value='Operation' />
                                    <om:Property Name='OperationMessageName' Value='Response' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='Receive ContentVersion Response' />
                                    <om:Property Name='Signal' Value='True' />
                                </om:Element>
                                <om:Element Type='Construct' OID='ac4930fe-855f-490e-9a8c-176062b498d9' ParentLink='ComplexStatement_Statement' LowerBound='132.1' HigherBound='147.1'>
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='Construct Content Version Request Msg' />
                                    <om:Property Name='Signal' Value='True' />
                                    <om:Element Type='MessageRef' OID='c9a7a91f-a0b2-4b3d-a220-d64673b17301' ParentLink='Construct_MessageRef' LowerBound='133.35' HigherBound='133.68'>
                                        <om:Property Name='Ref' Value='RestContentVersionQueryRequestMsg' />
                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                        <om:Property Name='Signal' Value='False' />
                                    </om:Element>
                                    <om:Element Type='Transform' OID='4a60756a-e269-4892-831e-1637a93a5040' ParentLink='ComplexStatement_Statement' LowerBound='135.1' HigherBound='137.1'>
                                        <om:Property Name='ClassName' Value='DocumentRetrievalLogic.MakeContentVersionRequestMsg' />
                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                        <om:Property Name='Name' Value='Make ContentVersion Request Msg' />
                                        <om:Property Name='Signal' Value='False' />
                                        <om:Element Type='MessagePartRef' OID='3737dc55-5c2e-4c85-8f57-53d0230bf63d' ParentLink='Transform_InputMessagePartRef' LowerBound='136.142' HigherBound='136.181'>
                                            <om:Property Name='MessageRef' Value='DocumentRetrievalRequestMsg' />
                                            <om:Property Name='PartRef' Value='MessagePart' />
                                            <om:Property Name='ReportToAnalyst' Value='True' />
                                            <om:Property Name='Name' Value='MessagePartReference_1' />
                                            <om:Property Name='Signal' Value='False' />
                                        </om:Element>
                                        <om:Element Type='MessagePartRef' OID='201b8ffe-4ae2-4e6b-b01a-2f98546a28d6' ParentLink='Transform_OutputMessagePartRef' LowerBound='136.40' HigherBound='136.85'>
                                            <om:Property Name='MessageRef' Value='RestContentVersionQueryRequestMsg' />
                                            <om:Property Name='PartRef' Value='MessagePart' />
                                            <om:Property Name='ReportToAnalyst' Value='True' />
                                            <om:Property Name='Name' Value='MessagePartReference_2' />
                                            <om:Property Name='Signal' Value='False' />
                                        </om:Element>
                                    </om:Element>
                                    <om:Element Type='MessageAssignment' OID='dbcf7970-bb38-42a6-b3be-3cda9b64275a' ParentLink='ComplexStatement_Statement' LowerBound='137.1' HigherBound='146.1'>
                                        <om:Property Name='Expression' Value='SOQL_ContentVersion_QUERY = ContentVersionID;&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;RestContentVersionQueryRequestMsg(DLAPDocumentRetrievalSalesforceDefinition.Rest.SOQL_ContentVersionData_Query) = SOQL_ContentVersion_QUERY; &#xD;&#xA;&#xD;&#xA;&#xD;&#xA;' />
                                        <om:Property Name='ReportToAnalyst' Value='False' />
                                        <om:Property Name='Name' Value='Make SOQL' />
                                        <om:Property Name='Signal' Value='False' />
                                    </om:Element>
                                </om:Element>
                                <om:Element Type='Send' OID='67d1112b-799d-49d3-8f4b-8ddb139f3d6f' ParentLink='ComplexStatement_Statement' LowerBound='147.1' HigherBound='149.1'>
                                    <om:Property Name='PortName' Value='RestContentVersionDataQueryPort' />
                                    <om:Property Name='MessageName' Value='RestContentVersionQueryRequestMsg' />
                                    <om:Property Name='OperationName' Value='Operation' />
                                    <om:Property Name='OperationMessageName' Value='Request' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='Send ContentVersion Request' />
                                    <om:Property Name='Signal' Value='True' />
                                </om:Element>
                                <om:Element Type='Receive' OID='085faf9a-f30d-44e2-aa7c-96254e1ecdb2' ParentLink='ComplexStatement_Statement' LowerBound='149.1' HigherBound='151.1'>
                                    <om:Property Name='Activate' Value='False' />
                                    <om:Property Name='PortName' Value='RestContentVersionDataQueryPort' />
                                    <om:Property Name='MessageName' Value='RestContentVersionDataQueryResponseMsg' />
                                    <om:Property Name='OperationName' Value='Operation' />
                                    <om:Property Name='OperationMessageName' Value='Response' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='Receive ContentVersion Response' />
                                    <om:Property Name='Signal' Value='True' />
                                </om:Element>
                                <om:Element Type='Construct' OID='daa977ba-8ca4-417c-a2c5-1eafc90c2139' ParentLink='ComplexStatement_Statement' LowerBound='151.1' HigherBound='159.1'>
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='Construct Document Retrieval Response Msg' />
                                    <om:Property Name='Signal' Value='True' />
                                    <om:Element Type='MessageRef' OID='df8bf63a-0c05-425b-b790-5978ef90f12a' ParentLink='Construct_MessageRef' LowerBound='152.35' HigherBound='152.63'>
                                        <om:Property Name='Ref' Value='DocumentRetrievalResponseMsg' />
                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                        <om:Property Name='Signal' Value='False' />
                                    </om:Element>
                                    <om:Element Type='Transform' OID='c2e70145-fdfe-4b95-a3d2-da7dbaf41a4b' ParentLink='ComplexStatement_Statement' LowerBound='154.1' HigherBound='156.1'>
                                        <om:Property Name='ClassName' Value='DocumentRetrievalLogic.MakeDocumentRetrievalResponse' />
                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                        <om:Property Name='Name' Value='Make Document Retrieval Response' />
                                        <om:Property Name='Signal' Value='False' />
                                        <om:Element Type='MessagePartRef' OID='7faa51a2-c9bf-4757-bb5e-6b79ace1c277' ParentLink='Transform_InputMessagePartRef' LowerBound='155.138' HigherBound='155.184'>
                                            <om:Property Name='MessageRef' Value='RestContentVersionQueryResponseMsg' />
                                            <om:Property Name='PartRef' Value='MessagePart' />
                                            <om:Property Name='ReportToAnalyst' Value='True' />
                                            <om:Property Name='Name' Value='MessagePartReference_3' />
                                            <om:Property Name='Signal' Value='False' />
                                        </om:Element>
                                        <om:Element Type='MessagePartRef' OID='566ad007-9fd9-4c3d-b2b4-1839bc5f1ec3' ParentLink='Transform_OutputMessagePartRef' LowerBound='155.40' HigherBound='155.80'>
                                            <om:Property Name='MessageRef' Value='DocumentRetrievalResponseMsg' />
                                            <om:Property Name='PartRef' Value='MessagePart' />
                                            <om:Property Name='ReportToAnalyst' Value='True' />
                                            <om:Property Name='Name' Value='MessagePartReference_4' />
                                            <om:Property Name='Signal' Value='False' />
                                        </om:Element>
                                    </om:Element>
                                    <om:Element Type='MessageAssignment' OID='0d785bef-2903-4dcf-a85e-383d0ebfd628' ParentLink='ComplexStatement_Statement' LowerBound='156.1' HigherBound='158.1'>
                                        <om:Property Name='Expression' Value='xpath(DocumentRetrievalResponseMsg.MessagePart, &quot;/*[local-name()=&apos;RetrievalResponse&apos; and namespace-uri()=&apos;http://SBA.gov/DLAPDocumentRetrieval/RetrievalResponse&apos;]/*[local-name()=&apos;Document_content&apos; and namespace-uri()=&apos;&apos;]&quot;) = SBA.BizTalk.Shared.MessageHelper.XLANGMessageHelper.Instance.ConvertBinaryMessageToBase64(RestContentVersionDataQueryResponseMsg); &#xD;&#xA;' />
                                        <om:Property Name='ReportToAnalyst' Value='False' />
                                        <om:Property Name='Name' Value='Inject Content' />
                                        <om:Property Name='Signal' Value='False' />
                                    </om:Element>
                                </om:Element>
                                <om:Element Type='VariableAssignment' OID='dade47f9-f25a-4c2a-8ee3-0f2b08b930ac' ParentLink='ComplexStatement_Statement' LowerBound='159.1' HigherBound='163.1'>
                                    <om:Property Name='Expression' Value='Flag = true;&#xD;&#xA;&#xD;&#xA;ResponseStatus = xpath(DocumentRetrievalResponseMsg.MessagePart, &quot;string(/*[local-name()=&apos;RetrievalResponse&apos; and namespace-uri()=&apos;http://SBA.gov/DLAPDocumentRetrieval/RetrievalResponse&apos;]/*[local-name()=&apos;Doc_retrieve_status&apos; and namespace-uri()=&apos;&apos;])&quot;);' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='Flag' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                            </om:Element>
                            <om:Element Type='DecisionBranch' OID='1372ce17-f7a2-43cb-b52f-083d2414f794' ParentLink='ReallyComplexStatement_Branch'>
                                <om:Property Name='IsGhostBranch' Value='True' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Else' />
                                <om:Property Name='Signal' Value='False' />
                                <om:Element Type='Construct' OID='23b1f29f-a2e1-4113-9a3b-951fa5c2ce14' ParentLink='ComplexStatement_Statement' LowerBound='166.1' HigherBound='179.1'>
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='Construct Document Retrieval Error Response Msg' />
                                    <om:Property Name='Signal' Value='True' />
                                    <om:Element Type='MessageRef' OID='a9912b3d-7b3a-4292-b8d2-e96210c2e95c' ParentLink='Construct_MessageRef' LowerBound='167.35' HigherBound='167.63'>
                                        <om:Property Name='Ref' Value='DocumentRetrievalResponseMsg' />
                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                        <om:Property Name='Signal' Value='False' />
                                    </om:Element>
                                    <om:Element Type='MessageAssignment' OID='974a19e8-4308-4e4b-a6f2-14481d4e9143' ParentLink='ComplexStatement_Statement' LowerBound='169.1' HigherBound='178.1'>
                                        <om:Property Name='Expression' Value='TempErrorResponse = new System.Xml.XmlDocument();&#xD;&#xA;&#xD;&#xA;TempErrorResponse.LoadXml(@&quot;&lt;ns0:RetrievalResponse xmlns:ns0=&apos;http://SBA.gov/DLAPDocumentRetrieval.RetrievalResponse&apos;&gt;&lt;Doc_retrieve_status&gt;FAILED&lt;/Doc_retrieve_status&gt;&lt;Doc_retrieve_status_details&gt;Exception:ContentVersion Id couldn’t be found thus Document can&apos;t be retrieved&lt;/Doc_retrieve_status_details&gt;&lt;/ns0:RetrievalResponse&gt;&quot;);&#xD;&#xA;&#xD;&#xA;DocumentRetrievalResponseMsg.MessagePart = TempErrorResponse;&#xD;&#xA;&#xD;&#xA;Flag = false;&#xD;&#xA;&#xD;&#xA;' />
                                        <om:Property Name='ReportToAnalyst' Value='False' />
                                        <om:Property Name='Name' Value='Make Document Error Response' />
                                        <om:Property Name='Signal' Value='False' />
                                    </om:Element>
                                </om:Element>
                            </om:Element>
                        </om:Element>
                        <om:Element Type='Decision' OID='adef182e-2ab7-48e7-8245-6c2fb57f6b6d' ParentLink='ComplexStatement_Statement' LowerBound='180.1' HigherBound='214.1'>
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Success Response?' />
                            <om:Property Name='Signal' Value='True' />
                            <om:Element Type='DecisionBranch' OID='da4c7284-8c3f-4e23-ab60-25f6ea1d2748' ParentLink='ReallyComplexStatement_Branch' LowerBound='181.21' HigherBound='197.1'>
                                <om:Property Name='Expression' Value='(Flag == true)&amp;&amp;(ResponseStatus == &quot;SUCCESS&quot;)' />
                                <om:Property Name='IsGhostBranch' Value='True' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Success' />
                                <om:Property Name='Signal' Value='True' />
                                <om:Element Type='VariableAssignment' OID='af518bbf-a7b6-4dcd-8d73-a42c86b597cc' ParentLink='ComplexStatement_Statement' LowerBound='183.1' HigherBound='196.1'>
                                    <om:Property Name='Expression' Value='&#xD;&#xA;OrchestrationInstanceId = Microsoft.XLANGs.Core.Service.RootService.InstanceId;&#xD;&#xA;&#xD;&#xA;SalesForceObjectName=&quot;Appplication&quot;;&#xD;&#xA;&#xD;&#xA;SalesForceObjectId = ContentVersionID;&#xD;&#xA;&#xD;&#xA;Stage = &quot;Document Retrieved&quot;;&#xD;&#xA;&#xD;&#xA;Status = &quot;Success&quot;;&#xD;&#xA;&#xD;&#xA;Message = &quot;Successfully Retrieved Document&quot;;&#xD;&#xA;' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='Set Success Values For Salesforce' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                            </om:Element>
                            <om:Element Type='DecisionBranch' OID='6208627b-3e45-455d-8074-c736c91294f8' ParentLink='ReallyComplexStatement_Branch'>
                                <om:Property Name='IsGhostBranch' Value='True' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Error' />
                                <om:Property Name='Signal' Value='True' />
                                <om:Element Type='VariableAssignment' OID='02618de8-1e05-4ecf-b065-e7096a1e2569' ParentLink='ComplexStatement_Statement' LowerBound='199.1' HigherBound='213.1'>
                                    <om:Property Name='Expression' Value='OrchestrationInstanceId = Microsoft.XLANGs.Core.Service.RootService.InstanceId;&#xD;&#xA;&#xD;&#xA;Message = &quot;File not found matching…&quot;;&#xD;&#xA;&#xD;&#xA;SalesForceObjectName=&quot;Appplication&quot;;&#xD;&#xA;&#xD;&#xA;SalesForceObjectId = ContentVersionID;&#xD;&#xA;&#xD;&#xA;Stage = &quot;Document Retrieved&quot;;&#xD;&#xA;&#xD;&#xA;Status = &quot;Error&quot;;&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='Set Error Values For Salesforce' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                            </om:Element>
                        </om:Element>
                        <om:Element Type='Catch' OID='49b890ab-e5e8-4e11-a6b6-b84a61f775df' ParentLink='Scope_Catch' LowerBound='217.1' HigherBound='276.1'>
                            <om:Property Name='ExceptionName' Value='Ex' />
                            <om:Property Name='ExceptionType' Value='System.SystemException' />
                            <om:Property Name='IsFaultMessage' Value='False' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='System Exception' />
                            <om:Property Name='Signal' Value='True' />
                            <om:Element Type='VariableAssignment' OID='65d79f22-e39b-44ee-9f98-0a5e03f6fc4a' ParentLink='Catch_Statement' LowerBound='220.1' HigherBound='259.1'>
                                <om:Property Name='Expression' Value='if(Ex.InnerException != null)&#xD;&#xA;{&#xD;&#xA;MessageTemp = Ex.InnerException.ToString();&#xD;&#xA;&#xD;&#xA;Message = MessageTemp.Substring(0, System.Convert.ToInt32(System.Math.Min(900, MessageTemp.Length))) +&quot;Total String Length:&quot;+MessageTemp.Length.ToString();&#xD;&#xA;&#xD;&#xA;System.Diagnostics.EventLog.WriteEntry(&quot;DLAP Document Retrieval Exception&quot;,Message);&#xD;&#xA;&#xD;&#xA;}&#xD;&#xA;&#xD;&#xA;else&#xD;&#xA;{&#xD;&#xA;MessageTemp = Ex.Message.ToString();&#xD;&#xA;&#xD;&#xA;Message = MessageTemp.Substring(0, System.Convert.ToInt32(System.Math.Min(900, MessageTemp.Length))) +&quot;Total String Length:&quot;+MessageTemp.Length.ToString();&#xD;&#xA;&#xD;&#xA;System.Diagnostics.EventLog.WriteEntry(&quot;DLAP Document Retrieval Exception&quot;,Message);&#xD;&#xA;}&#xD;&#xA;&#xD;&#xA;OrchestrationInstanceId = Microsoft.XLANGs.Core.Service.RootService.InstanceId;&#xD;&#xA;&#xD;&#xA;SalesForceObjectName=&quot;Appplication&quot;;&#xD;&#xA;&#xD;&#xA;SalesForceObjectId = ContentVersionID;&#xD;&#xA;&#xD;&#xA;Stage = &quot;Document Retrieved&quot;;&#xD;&#xA;&#xD;&#xA;Status = &quot;Error&quot;;&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Set Error Values For Salesforce' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='Construct' OID='8cd73496-eb82-444c-bf44-44ed264dbb55' ParentLink='Catch_Statement' LowerBound='259.1' HigherBound='269.1'>
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Construct Document Retrieval Fault Response' />
                                <om:Property Name='Signal' Value='True' />
                                <om:Element Type='MessageAssignment' OID='3ebc812f-752b-4908-895b-b5b96b7e307a' ParentLink='ComplexStatement_Statement' LowerBound='262.1' HigherBound='268.1'>
                                    <om:Property Name='Expression' Value='TempErrorResponse = new System.Xml.XmlDocument();&#xD;&#xA;&#xD;&#xA;TempErrorResponse.LoadXml(@&quot;&lt;ns0:Fault xmlns:ns0=&apos;http://SBA.gov/DLAPDocumentRetrieval/RetrievalFault&apos;&gt;&lt;FaultString&gt;Exception:Internal Error&lt;/FaultString&gt;&lt;FaultCode&gt;An error occurred while processing the Document Retrieval&lt;/FaultCode&gt;&lt;/ns0:Fault&gt;&quot;);&#xD;&#xA;&#xD;&#xA;DocumentRetrievalFaultResponeMsg.MessagePart = TempErrorResponse;&#xD;&#xA;' />
                                    <om:Property Name='ReportToAnalyst' Value='False' />
                                    <om:Property Name='Name' Value='Make Document Error Response' />
                                    <om:Property Name='Signal' Value='True' />
                                </om:Element>
                                <om:Element Type='MessageRef' OID='17058116-f756-441c-aaf0-72fec62f1b44' ParentLink='Construct_MessageRef' LowerBound='260.35' HigherBound='260.67'>
                                    <om:Property Name='Ref' Value='DocumentRetrievalFaultResponeMsg' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                            </om:Element>
                            <om:Element Type='Send' OID='275ccecb-abca-48c5-ac88-53a9cd55901f' ParentLink='Catch_Statement' LowerBound='269.1' HigherBound='271.1'>
                                <om:Property Name='PortName' Value='DocumentRetrievalPort' />
                                <om:Property Name='MessageName' Value='DocumentRetrievalFaultResponeMsg' />
                                <om:Property Name='OperationName' Value='Operation' />
                                <om:Property Name='OperationMessageName' Value='Fault' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Send Fault Response' />
                                <om:Property Name='Signal' Value='True' />
                            </om:Element>
                            <om:Element Type='Call' OID='ace15ead-b3f9-45ca-a110-705d13a29ea8' ParentLink='Catch_Statement' LowerBound='271.1' HigherBound='273.1'>
                                <om:Property Name='Identifier' Value='SalesForceEventLogging_CallOrchestration' />
                                <om:Property Name='Invokee' Value='DLAPDocument.RetrievalEventRequest' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Call SalesForce Event Logging Orchestration' />
                                <om:Property Name='Signal' Value='False' />
                                <om:Element Type='Parameter' OID='094a0043-1a29-4c74-949a-61edcfe0def3' ParentLink='InvokeStatement_Parameter'>
                                    <om:Property Name='Direction' Value='In' />
                                    <om:Property Name='Name' Value='Application' />
                                    <om:Property Name='Type' Value='System.String' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                                <om:Element Type='Parameter' OID='a276aed8-9d8c-4843-8dc3-decedcf88708' ParentLink='InvokeStatement_Parameter'>
                                    <om:Property Name='Direction' Value='In' />
                                    <om:Property Name='Name' Value='SalesForceObjectId' />
                                    <om:Property Name='Type' Value='System.String' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                                <om:Element Type='Parameter' OID='404a0a0a-3b94-4685-a09a-b4af6e9b8c20' ParentLink='InvokeStatement_Parameter'>
                                    <om:Property Name='Direction' Value='In' />
                                    <om:Property Name='Name' Value='Message' />
                                    <om:Property Name='Type' Value='System.String' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                                <om:Element Type='Parameter' OID='9ad60eb8-20d5-4404-b797-89846f4e8ce5' ParentLink='InvokeStatement_Parameter'>
                                    <om:Property Name='Direction' Value='In' />
                                    <om:Property Name='Name' Value='SalesForceObjectName' />
                                    <om:Property Name='Type' Value='System.String' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                                <om:Element Type='Parameter' OID='70b3ae92-5d68-46cc-91ca-5d621f100077' ParentLink='InvokeStatement_Parameter'>
                                    <om:Property Name='Direction' Value='In' />
                                    <om:Property Name='Name' Value='Status' />
                                    <om:Property Name='Type' Value='System.String' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                                <om:Element Type='Parameter' OID='da64003f-6925-474f-b3ac-695a6feb8f94' ParentLink='InvokeStatement_Parameter'>
                                    <om:Property Name='Direction' Value='In' />
                                    <om:Property Name='Name' Value='Status' />
                                    <om:Property Name='Type' Value='System.String' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                                <om:Element Type='Parameter' OID='f2063d25-9007-43b8-b043-06465c037819' ParentLink='InvokeStatement_Parameter'>
                                    <om:Property Name='Direction' Value='In' />
                                    <om:Property Name='Name' Value='Empty' />
                                    <om:Property Name='Type' Value='System.String' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                                <om:Element Type='Parameter' OID='6a0cceae-e791-4849-b667-a0cea2b23d4c' ParentLink='InvokeStatement_Parameter'>
                                    <om:Property Name='Direction' Value='In' />
                                    <om:Property Name='Name' Value='OrchestrationInstanceId' />
                                    <om:Property Name='Type' Value='System.Guid' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                            </om:Element>
                            <om:Element Type='Terminate' OID='382be502-eab5-4ca9-b41f-2ba96fa6d001' ParentLink='Catch_Statement' LowerBound='273.1' HigherBound='275.1'>
                                <om:Property Name='ErrorMessage' Value='&quot;An error occurred while processing the DLAP Document Retrieval&quot;;' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Terminate' />
                                <om:Property Name='Signal' Value='True' />
                            </om:Element>
                        </om:Element>
                    </om:Element>
                </om:Element>
                <om:Element Type='Send' OID='2ba8538d-c9e7-48be-a331-99829ed8ef68' ParentLink='ServiceBody_Statement' LowerBound='278.1' HigherBound='280.1'>
                    <om:Property Name='PortName' Value='DocumentRetrievalPort' />
                    <om:Property Name='MessageName' Value='DocumentRetrievalResponseMsg' />
                    <om:Property Name='OperationName' Value='Operation' />
                    <om:Property Name='OperationMessageName' Value='Response' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Send Document Error Response' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Call' OID='f5be43e7-4177-4c04-b09a-087cdcb31e4e' ParentLink='ServiceBody_Statement' LowerBound='280.1' HigherBound='282.1'>
                    <om:Property Name='Identifier' Value='SalesForceEventLogging_CallOrchestration_1' />
                    <om:Property Name='Invokee' Value='DLAPDocument.RetrievalEventRequest' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Call SalesForce Event Logging Orchestration' />
                    <om:Property Name='Signal' Value='False' />
                    <om:Element Type='Parameter' OID='e9e76345-19eb-4e1e-ab1e-22d2ebe68833' ParentLink='InvokeStatement_Parameter'>
                        <om:Property Name='Direction' Value='In' />
                        <om:Property Name='Name' Value='Application' />
                        <om:Property Name='Type' Value='System.String' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                    <om:Element Type='Parameter' OID='6eef7f2e-aaf3-496a-a674-56f9812a98f3' ParentLink='InvokeStatement_Parameter'>
                        <om:Property Name='Direction' Value='In' />
                        <om:Property Name='Name' Value='SalesForceObjectId' />
                        <om:Property Name='Type' Value='System.String' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                    <om:Element Type='Parameter' OID='9aea2fdd-74a3-4a91-9d51-b50d7d1a71df' ParentLink='InvokeStatement_Parameter'>
                        <om:Property Name='Direction' Value='In' />
                        <om:Property Name='Name' Value='Message' />
                        <om:Property Name='Type' Value='System.String' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                    <om:Element Type='Parameter' OID='ddf174c3-f857-43dc-9c54-9afc627293eb' ParentLink='InvokeStatement_Parameter'>
                        <om:Property Name='Direction' Value='In' />
                        <om:Property Name='Name' Value='SalesForceObjectName' />
                        <om:Property Name='Type' Value='System.String' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                    <om:Element Type='Parameter' OID='cb48dc4c-00e2-499c-bbf8-2c74242401ed' ParentLink='InvokeStatement_Parameter'>
                        <om:Property Name='Direction' Value='In' />
                        <om:Property Name='Name' Value='Stage' />
                        <om:Property Name='Type' Value='System.String' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                    <om:Element Type='Parameter' OID='8090ba90-ee6f-4bc5-867e-f3584abe5c3b' ParentLink='InvokeStatement_Parameter'>
                        <om:Property Name='Direction' Value='In' />
                        <om:Property Name='Name' Value='Status' />
                        <om:Property Name='Type' Value='System.String' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                    <om:Element Type='Parameter' OID='013d5b7e-b341-46df-934a-23289bcd7459' ParentLink='InvokeStatement_Parameter'>
                        <om:Property Name='Direction' Value='In' />
                        <om:Property Name='Name' Value='Empty' />
                        <om:Property Name='Type' Value='System.String' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                    <om:Element Type='Parameter' OID='8e19a8ad-6c14-4674-b391-486ce4635aa6' ParentLink='InvokeStatement_Parameter'>
                        <om:Property Name='Direction' Value='In' />
                        <om:Property Name='Name' Value='OrchestrationInstanceId' />
                        <om:Property Name='Type' Value='System.Guid' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='8c71e632-117b-4a46-9df6-c3fad19ca8ba' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='52.1' HigherBound='54.1'>
                <om:Property Name='PortModifier' Value='Implements' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='DLAPDocument.DocumentRetrievalPortType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='DocumentRetrievalPort' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='baf2badc-26db-4ac4-9754-95e44d7134ef' ParentLink='PortDeclaration_CLRAttribute' LowerBound='52.1' HigherBound='53.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='0af99a8c-cf80-446a-b02b-9b004f4fa178' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='54.1' HigherBound='56.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='43' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='DLAPDocument.RestContentVersionQueryPortType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='RestContentVersionQueryPort' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='c2762706-db19-409a-afae-e191faf2baa9' ParentLink='PortDeclaration_CLRAttribute' LowerBound='54.1' HigherBound='55.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='c929c716-6936-4444-998e-a5e3015f49ea' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='56.1' HigherBound='58.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='DLAPDocument.RestContentVersionDataQueryPortType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='RestContentVersionDataQueryPort' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='ace97228-51e3-4bf7-b1c0-4d474c8b9837' ParentLink='PortDeclaration_CLRAttribute' LowerBound='56.1' HigherBound='57.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='MultipartMessageType' OID='19f58b6c-b5e0-48dc-a8f2-19b6536dfcc9' ParentLink='Module_MessageType' LowerBound='4.1' HigherBound='8.1'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='DocumentRetrievalRequestType' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='PartDeclaration' OID='9460d92f-a0d4-44c9-9b62-3d79a2b99774' ParentLink='MultipartMessageType_PartDeclaration' LowerBound='6.1' HigherBound='7.1'>
                <om:Property Name='ClassName' Value='DocumentRetrievalDefinition.DocumentRetrievalRequest' />
                <om:Property Name='IsBodyPart' Value='True' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='MessagePart' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
        </om:Element>
        <om:Element Type='MultipartMessageType' OID='ab8f558b-62d6-4ea7-9815-082f112ac5ff' ParentLink='Module_MessageType' LowerBound='8.1' HigherBound='12.1'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='DocumentRetrievalResponseType' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='PartDeclaration' OID='c2b74655-4f93-4622-94a4-65973ba7cdf2' ParentLink='MultipartMessageType_PartDeclaration' LowerBound='10.1' HigherBound='11.1'>
                <om:Property Name='ClassName' Value='DocumentRetrievalDefinition.DocumentRetrievalResponse' />
                <om:Property Name='IsBodyPart' Value='True' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='MessagePart' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
        </om:Element>
        <om:Element Type='MultipartMessageType' OID='503f8c03-afdd-4003-8178-efd4b31775ad' ParentLink='Module_MessageType' LowerBound='12.1' HigherBound='16.1'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='DocumentRetrievalFaultResponeType' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='PartDeclaration' OID='d7f99a7d-11be-4c24-9c3d-2044b50bf2fa' ParentLink='MultipartMessageType_PartDeclaration' LowerBound='14.1' HigherBound='15.1'>
                <om:Property Name='ClassName' Value='DocumentRetrievalDefinition.DocumentRetrievalFault' />
                <om:Property Name='IsBodyPart' Value='True' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='MessagePart' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
        </om:Element>
        <om:Element Type='MultipartMessageType' OID='56721a38-b68a-42f6-a4bd-798f77648537' ParentLink='Module_MessageType' LowerBound='16.1' HigherBound='20.1'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='RestContentVersionQueryRequestType' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='PartDeclaration' OID='e5685442-a4c2-4bde-b665-d26eb00f15f0' ParentLink='MultipartMessageType_PartDeclaration' LowerBound='18.1' HigherBound='19.1'>
                <om:Property Name='ClassName' Value='DLAPDocumentRetrievalSalesforceDefinition.Rest.RestContentDocument.Request' />
                <om:Property Name='IsBodyPart' Value='True' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='MessagePart' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
        </om:Element>
        <om:Element Type='MultipartMessageType' OID='d628be1f-c722-4814-891c-b8ae9e50999c' ParentLink='Module_MessageType' LowerBound='20.1' HigherBound='24.1'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='RestContentVersionDataQueryResponseType' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='PartDeclaration' OID='633be8fa-6cc7-4c0c-9c1b-3dff913db333' ParentLink='MultipartMessageType_PartDeclaration' LowerBound='22.1' HigherBound='23.1'>
                <om:Property Name='ClassName' Value='System.Xml.XmlDocument' />
                <om:Property Name='IsBodyPart' Value='True' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='MessagePart' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
        </om:Element>
        <om:Element Type='MultipartMessageType' OID='7eadbff3-8d05-44f6-aa81-431a01b759a4' ParentLink='Module_MessageType' LowerBound='24.1' HigherBound='28.1'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='RestContentVersionQueryResponseType' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='PartDeclaration' OID='c5357223-0f74-47da-807b-736e3225624d' ParentLink='MultipartMessageType_PartDeclaration' LowerBound='26.1' HigherBound='27.1'>
                <om:Property Name='ClassName' Value='DLAPDocumentRetrievalSalesforceDefinition.Rest.RestContentDocument.QueryResult' />
                <om:Property Name='IsBodyPart' Value='True' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='MessagePart' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='81c18889-979f-460b-a5f0-1d2283ed3b56' ParentLink='Module_PortType' LowerBound='28.1' HigherBound='35.1'>
            <om:Property Name='Synchronous' Value='True' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='RestContentVersionQueryPortType' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='OperationDeclaration' OID='cc2ed3d6-cb34-49a3-919e-b7a31b967a12' ParentLink='PortType_OperationDeclaration' LowerBound='30.1' HigherBound='34.1'>
                <om:Property Name='OperationType' Value='RequestResponse' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='cc2abb19-761f-4208-949e-b9099d378297' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='32.13' HigherBound='32.47'>
                    <om:Property Name='Ref' Value='DLAPDocument.RestContentVersionQueryRequestType' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='MessageRef' OID='38d675e3-90ff-4b7b-a86e-473ab3f70031' ParentLink='OperationDeclaration_ResponseMessageRef' LowerBound='32.49' HigherBound='32.84'>
                    <om:Property Name='Ref' Value='DLAPDocument.RestContentVersionQueryResponseType' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Response' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='3f312328-ed91-4836-8360-457997a21ba4' ParentLink='Module_PortType' LowerBound='35.1' HigherBound='42.1'>
            <om:Property Name='Synchronous' Value='True' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='DocumentRetrievalPortType' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='OperationDeclaration' OID='7fd81bb8-9fd5-4c28-8bb2-339ab1bfb79f' ParentLink='PortType_OperationDeclaration' LowerBound='37.1' HigherBound='41.1'>
                <om:Property Name='OperationType' Value='RequestResponse' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='8dbd8c76-fa43-4282-8ff7-db6959350672' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='39.13' HigherBound='39.41'>
                    <om:Property Name='Ref' Value='DLAPDocument.DocumentRetrievalRequestType' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='MessageRef' OID='ac863cd6-428f-4fda-8079-6c7b05e1de0e' ParentLink='OperationDeclaration_FaultMessageRef' LowerBound='39.74' HigherBound='39.115'>
                    <om:Property Name='Ref' Value='DLAPDocument.DocumentRetrievalFaultResponeType' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Fault' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='MessageRef' OID='174c91e7-d5ef-4d58-9d25-4603a33553db' ParentLink='OperationDeclaration_ResponseMessageRef' LowerBound='39.43' HigherBound='39.72'>
                    <om:Property Name='Ref' Value='DLAPDocument.DocumentRetrievalResponseType' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Response' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='898c69ce-a6d2-4a0c-a430-cc675d25ef17' ParentLink='Module_PortType' LowerBound='42.1' HigherBound='49.1'>
            <om:Property Name='Synchronous' Value='True' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='RestContentVersionDataQueryPortType' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='OperationDeclaration' OID='2f0d7585-7665-4fe8-a89c-6ec39129b1ec' ParentLink='PortType_OperationDeclaration' LowerBound='44.1' HigherBound='48.1'>
                <om:Property Name='OperationType' Value='RequestResponse' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='d95e8008-40eb-4e52-9941-85b0d8fd29d3' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='46.13' HigherBound='46.47'>
                    <om:Property Name='Ref' Value='DLAPDocument.RestContentVersionQueryRequestType' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
                <om:Element Type='MessageRef' OID='1b9932f2-87b9-4f04-8e8f-feccbf9630bc' ParentLink='OperationDeclaration_ResponseMessageRef' LowerBound='46.49' HigherBound='46.88'>
                    <om:Property Name='Ref' Value='DLAPDocument.RestContentVersionDataQueryResponseType' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Response' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
    </om:Element>
</om:MetaModel>
";

        [System.SerializableAttribute]
        public class __RetrievalLogic_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __RetrievalLogic_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "RetrievalLogic")
            {
            }

            public override int Index { get { return 0; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[0]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[0]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Finally();
                return false;
            }

            public override void Finally()
            {
                RetrievalLogic __svc__ = (RetrievalLogic)_service;
                __RetrievalLogic_root_0 __ctx0__ = (__RetrievalLogic_root_0)(__svc__._stateMgrs[0]);

                if (__svc__.DocumentRetrievalPort != null)
                {
                    __svc__.DocumentRetrievalPort.Close(this, null);
                    __svc__.DocumentRetrievalPort = null;
                }
                if (__svc__.RestContentVersionQueryPort != null)
                {
                    __svc__.RestContentVersionQueryPort.Close(this, null);
                    __svc__.RestContentVersionQueryPort = null;
                }
                if (__svc__.RestContentVersionDataQueryPort != null)
                {
                    __svc__.RestContentVersionDataQueryPort.Close(this, null);
                    __svc__.RestContentVersionDataQueryPort = null;
                }
                base.Finally();
            }

            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper0;
            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper1;
            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper2;
        }


        [System.SerializableAttribute]
        public class __RetrievalLogic_1 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public __RetrievalLogic_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "RetrievalLogic")
            {
            }

            public override int Index { get { return 1; } }

            public override bool CombineParentCommit { get { return true; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[1]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[1]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Finally();
                return false;
            }

            public override void Finally()
            {
                RetrievalLogic __svc__ = (RetrievalLogic)_service;
                __RetrievalLogic_1 __ctx1__ = (__RetrievalLogic_1)(__svc__._stateMgrs[1]);

                if (__ctx1__ != null)
                    __ctx1__.__Empty = null;
                if (__ctx1__ != null)
                    __ctx1__.__ContentVersionID = null;
                if (__ctx1__ != null)
                    __ctx1__.__Message = null;
                if (__ctx1__ != null)
                    __ctx1__.__SalesForceObjectName = null;
                if (__ctx1__ != null && __ctx1__.__DocumentRetrievalResponseMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__DocumentRetrievalResponseMsg);
                    __ctx1__.__DocumentRetrievalResponseMsg = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__MessageTemp = null;
                if (__ctx1__ != null)
                    __ctx1__.__Status = null;
                if (__ctx1__ != null)
                    __ctx1__.__TempErrorResponse = null;
                if (__ctx1__ != null)
                    __ctx1__.__Stage = null;
                if (__ctx1__ != null)
                    __ctx1__.__Application = null;
                if (__ctx1__ != null)
                    __ctx1__.__SalesForceObjectId = null;
                if (__ctx1__ != null)
                    __ctx1__.__SOQL_ContentVersion_QUERY = null;
                if (__ctx1__ != null)
                    __ctx1__.__Base64String = null;
                if (__ctx1__ != null)
                    __ctx1__.__ResponseStatus = null;
                if (__ctx1__ != null && __ctx1__.__DocumentRetrievalRequestMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__DocumentRetrievalRequestMsg);
                    __ctx1__.__DocumentRetrievalRequestMsg = null;
                }
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("DocumentRetrievalRequestMsg")]
            internal DocumentRetrievalRequestType __DocumentRetrievalRequestMsg;
            [Microsoft.XLANGs.Core.UserVariableAttribute("DocumentRetrievalResponseMsg")]
            internal DocumentRetrievalResponseType __DocumentRetrievalResponseMsg;
            [Microsoft.XLANGs.Core.UserVariableAttribute("DocumentRetrievalFaultResponeMsg")]
            internal DocumentRetrievalFaultResponeType __DocumentRetrievalFaultResponeMsg;
            [Microsoft.XLANGs.Core.UserVariableAttribute("RestContentVersionQueryRequestMsg")]
            internal RestContentVersionQueryRequestType __RestContentVersionQueryRequestMsg;
            [Microsoft.XLANGs.Core.UserVariableAttribute("RestContentVersionDataQueryResponseMsg")]
            internal RestContentVersionDataQueryResponseType __RestContentVersionDataQueryResponseMsg;
            [Microsoft.XLANGs.Core.UserVariableAttribute("RestContentVersionQueryResponseMsg")]
            internal RestContentVersionQueryResponseType __RestContentVersionQueryResponseMsg;
            [Microsoft.XLANGs.Core.UserVariableAttribute("TempErrorResponse")]
            internal Microsoft.XLANGs.RuntimeTypes.XmlDocumentSerializationProxy __TempErrorResponse;
            [Microsoft.XLANGs.Core.UserVariableAttribute("ContentVersionIDStatus")]
            internal System.Boolean __ContentVersionIDStatus;
            [Microsoft.XLANGs.Core.UserVariableAttribute("ContentVersionID")]
            internal System.String __ContentVersionID;
            [Microsoft.XLANGs.Core.UserVariableAttribute("OrchestrationInstanceId")]
            internal System.Guid __OrchestrationInstanceId;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Message")]
            internal System.String __Message;
            [Microsoft.XLANGs.Core.UserVariableAttribute("SalesForceObjectName")]
            internal System.String __SalesForceObjectName;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Stage")]
            internal System.String __Stage;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Status")]
            internal System.String __Status;
            [Microsoft.XLANGs.Core.UserVariableAttribute("MessageTemp")]
            internal System.String __MessageTemp;
            [Microsoft.XLANGs.Core.UserVariableAttribute("SalesForceObjectId")]
            internal System.String __SalesForceObjectId;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Flag")]
            internal System.Boolean __Flag;
            [Microsoft.XLANGs.Core.UserVariableAttribute("ResponseStatus")]
            internal System.String __ResponseStatus;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Application")]
            internal System.String __Application;
            [Microsoft.XLANGs.Core.UserVariableAttribute("SOQL_ContentVersion_QUERY")]
            internal System.String __SOQL_ContentVersion_QUERY;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Base64String")]
            internal System.String __Base64String;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Empty")]
            internal System.String __Empty;
        }


        [System.SerializableAttribute]
        public class ____scope35_2 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public ____scope35_2(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "??__scope35")
            {
            }

            public override int Index { get { return 2; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[2]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[2]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Microsoft.XLANGs.Core.Segment __seg__;
                Microsoft.XLANGs.Core.FaultReceiveException __fault__;

                __exv__ = _exception;
                if (!(__exv__ is Microsoft.XLANGs.Core.UnknownException))
                {
                    __fault__ = __exv__ as Microsoft.XLANGs.Core.FaultReceiveException;
                    if ((__fault__ == null) && (__exv__ is System.SystemException))
                    {
                        __seg__ = _service._segments[3];
                        __seg__.Reset(1);
                        __seg__.PredecessorDone(_service);
                        return true;
                    }
                }

                Finally();
                return false;
            }

            public override void Finally()
            {
                RetrievalLogic __svc__ = (RetrievalLogic)_service;
                __RetrievalLogic_root_0 __ctx0__ = (__RetrievalLogic_root_0)(__svc__._stateMgrs[0]);
                __RetrievalLogic_1 __ctx1__ = (__RetrievalLogic_1)(__svc__._stateMgrs[1]);
                ____scope35_2 __ctx2__ = (____scope35_2)(__svc__._stateMgrs[2]);

                if (__ctx2__ != null)
                    __ctx2__.__Ex_0 = null;
                if (__ctx1__ != null && __ctx1__.__DocumentRetrievalFaultResponeMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__DocumentRetrievalFaultResponeMsg);
                    __ctx1__.__DocumentRetrievalFaultResponeMsg = null;
                }
                if (__ctx1__ != null && __ctx1__.__RestContentVersionDataQueryResponseMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__RestContentVersionDataQueryResponseMsg);
                    __ctx1__.__RestContentVersionDataQueryResponseMsg = null;
                }
                if (__ctx1__ != null && __ctx1__.__RestContentVersionQueryRequestMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__RestContentVersionQueryRequestMsg);
                    __ctx1__.__RestContentVersionQueryRequestMsg = null;
                }
                if (__ctx1__ != null && __ctx1__.__RestContentVersionQueryResponseMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__RestContentVersionQueryResponseMsg);
                    __ctx1__.__RestContentVersionQueryResponseMsg = null;
                }
                if (__ctx0__ != null && __ctx0__.__subWrapper1 != null)
                {
                    __ctx0__.__subWrapper1.Destroy(__svc__, __ctx0__);
                    __ctx0__.__subWrapper1 = null;
                }
                if (__ctx0__ != null && __ctx0__.__subWrapper2 != null)
                {
                    __ctx0__.__subWrapper2.Destroy(__svc__, __ctx0__);
                    __ctx0__.__subWrapper2 = null;
                }
                base.Finally();
            }

            internal object __exv__;
            internal System.SystemException __Ex_0
            {
                get { return (System.SystemException)__exv__; }
                set { __exv__ = value; }
            }
        }

        private static Microsoft.XLANGs.Core.CorrelationType[] _correlationTypes = null;
        public override Microsoft.XLANGs.Core.CorrelationType[] CorrelationTypes { get { return _correlationTypes; } }

        private static System.Guid[] _convoySetIds;

        public override System.Guid[] ConvoySetGuids
        {
            get { return _convoySetIds; }
            set { _convoySetIds = value; }
        }

        public static object[] StaticConvoySetInformation
        {
            get {
                return null;
            }
        }

        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("DocumentRetrievalPort")]
        internal DocumentRetrievalPortType DocumentRetrievalPort;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("RestContentVersionQueryPort")]
        internal RestContentVersionQueryPortType RestContentVersionQueryPort;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("RestContentVersionDataQueryPort")]
        internal RestContentVersionDataQueryPortType RestContentVersionDataQueryPort;

        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {DocumentRetrievalPortType.Operation},
                                               typeof(RetrievalLogic).GetField("DocumentRetrievalPort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.implements,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(RetrievalLogic), "DocumentRetrievalPort"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {RestContentVersionQueryPortType.Operation},
                                               typeof(RetrievalLogic).GetField("RestContentVersionQueryPort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(RetrievalLogic), "RestContentVersionQueryPort"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {RestContentVersionDataQueryPortType.Operation},
                                               typeof(RetrievalLogic).GetField("RestContentVersionDataQueryPort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(RetrievalLogic), "RestContentVersionDataQueryPort"),
                                               null)
        };

        public override Microsoft.XLANGs.Core.PortInfo[] PortInformation
        {
            get { return _portInfo; }
        }

        static public System.Collections.Hashtable PortsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[_portInfo[0].Name] = _portInfo[0];
                h[_portInfo[1].Name] = _portInfo[1];
                h[_portInfo[2].Name] = _portInfo[2];
                return h;
            }
        }

        public static System.Type[] InvokedServicesTypes
        {
            get
            {
                return new System.Type[] {
                    // type of each service invoked by this service
                };
            }
        }

        public static System.Type[] CalledServicesTypes
        {
            get
            {
                return new System.Type[] {
                    typeof(DLAPDocument.RetrievalEventRequest)                    
                };
            }
        }

        public static System.Type[] ExecedServicesTypes
        {
            get
            {
                return new System.Type[] {
                };
            }
        }

        public static object[] StaticSubscriptionsInformation {
            get {
                return new object[1]{
                     new object[5] { _portInfo[0], 0, null , -1, true }
                };
            }
        }

        public static Microsoft.XLANGs.RuntimeTypes.Location[] __eventLocations = new Microsoft.XLANGs.RuntimeTypes.Location[] {
            new Microsoft.XLANGs.RuntimeTypes.Location(0, "00000000-0000-0000-0000-000000000000", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "d297f1d8-b13d-4b1e-857d-606b3a29373a", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "d297f1d8-b13d-4b1e-857d-606b3a29373a", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "00000000-0000-0000-0000-000000000000", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "bd4b49c5-c4b6-43ad-85fb-07659d9f63e9", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "00000000-0000-0000-0000-000000000000", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(6, "77957e96-3e00-4588-b339-6b103aa76ece", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(7, "77957e96-3e00-4588-b339-6b103aa76ece", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(8, "00000000-0000-0000-0000-000000000000", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(9, "47438fb2-de62-4131-8367-f9604590c5d4", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(10, "ef317496-6a7e-4755-ae00-dbc0ac790925", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(11, "ef317496-6a7e-4755-ae00-dbc0ac790925", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(12, "bcda904c-0fb9-4e6b-ac9f-58d51237c345", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(13, "bcda904c-0fb9-4e6b-ac9f-58d51237c345", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(14, "b57f62af-3fac-4980-8458-ecbf12bf1fa9", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(15, "b57f62af-3fac-4980-8458-ecbf12bf1fa9", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(16, "ac4930fe-855f-490e-9a8c-176062b498d9", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(17, "ac4930fe-855f-490e-9a8c-176062b498d9", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(18, "67d1112b-799d-49d3-8f4b-8ddb139f3d6f", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(19, "67d1112b-799d-49d3-8f4b-8ddb139f3d6f", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(20, "085faf9a-f30d-44e2-aa7c-96254e1ecdb2", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(21, "085faf9a-f30d-44e2-aa7c-96254e1ecdb2", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(22, "daa977ba-8ca4-417c-a2c5-1eafc90c2139", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(23, "daa977ba-8ca4-417c-a2c5-1eafc90c2139", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(24, "dade47f9-f25a-4c2a-8ee3-0f2b08b930ac", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(25, "dade47f9-f25a-4c2a-8ee3-0f2b08b930ac", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(26, "23b1f29f-a2e1-4113-9a3b-951fa5c2ce14", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(27, "23b1f29f-a2e1-4113-9a3b-951fa5c2ce14", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(28, "47438fb2-de62-4131-8367-f9604590c5d4", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(29, "adef182e-2ab7-48e7-8245-6c2fb57f6b6d", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(30, "af518bbf-a7b6-4dcd-8d73-a42c86b597cc", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(31, "af518bbf-a7b6-4dcd-8d73-a42c86b597cc", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(32, "02618de8-1e05-4ecf-b065-e7096a1e2569", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(33, "02618de8-1e05-4ecf-b065-e7096a1e2569", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(34, "adef182e-2ab7-48e7-8245-6c2fb57f6b6d", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(35, "49b890ab-e5e8-4e11-a6b6-b84a61f775df", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(36, "65d79f22-e39b-44ee-9f98-0a5e03f6fc4a", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(37, "00000000-0000-0000-0000-000000000000", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(38, "00000000-0000-0000-0000-000000000000", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(39, "65d79f22-e39b-44ee-9f98-0a5e03f6fc4a", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(40, "8cd73496-eb82-444c-bf44-44ed264dbb55", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(41, "8cd73496-eb82-444c-bf44-44ed264dbb55", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(42, "275ccecb-abca-48c5-ac88-53a9cd55901f", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(43, "275ccecb-abca-48c5-ac88-53a9cd55901f", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(44, "ace15ead-b3f9-45ca-a110-705d13a29ea8", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(45, "ace15ead-b3f9-45ca-a110-705d13a29ea8", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(46, "382be502-eab5-4ca9-b41f-2ba96fa6d001", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(47, "49b890ab-e5e8-4e11-a6b6-b84a61f775df", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(48, "bd4b49c5-c4b6-43ad-85fb-07659d9f63e9", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(49, "2ba8538d-c9e7-48be-a331-99829ed8ef68", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(50, "2ba8538d-c9e7-48be-a331-99829ed8ef68", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(51, "f5be43e7-4177-4c04-b09a-087cdcb31e4e", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(52, "f5be43e7-4177-4c04-b09a-087cdcb31e4e", 1, false)
        };

        public override Microsoft.XLANGs.RuntimeTypes.Location[] EventLocations
        {
            get { return __eventLocations; }
        }

        public static Microsoft.XLANGs.RuntimeTypes.EventData[] __eventData = new Microsoft.XLANGs.RuntimeTypes.EventData[] {
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Body),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Receive),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Scope),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Expression),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Expression),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.If),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.If),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Construct),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Send),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Catch),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Call),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Call),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Terminate),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Catch),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Scope),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Body)
        };

        public static int[] __progressLocation0 = new int[] { 0,0,0,3,3,};
        public static int[] __progressLocation1 = new int[] { 0,0,1,1,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,4,4,4,48,49,49,49,50,51,51,52,3,3,3,3,};
        public static int[] __progressLocation2 = new int[] { 6,6,6,7,7,7,7,7,7,7,9,9,10,10,11,12,12,12,13,14,14,15,16,16,17,18,18,18,19,20,20,21,22,22,23,24,24,25,25,9,26,26,27,28,29,29,30,30,31,31,31,31,31,31,29,32,32,33,33,33,33,33,33,34,34,34,34,};
        public static int[] __progressLocation3 = new int[] { 35,35,36,36,36,36,36,36,36,36,36,39,39,39,39,39,39,40,40,41,42,42,42,43,44,44,45,46,46,47,47,};

        public static int[][] __progressLocations = new int[4] [] {__progressLocation0,__progressLocation1,__progressLocation2,__progressLocation3};
        public override int[][] ProgressLocations {get {return __progressLocations;} }

        public Microsoft.XLANGs.Core.StopConditions segment0(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[0];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[0];
            __RetrievalLogic_root_0 __ctx0__ = (__RetrievalLogic_root_0)_stateMgrs[0];
            __RetrievalLogic_1 __ctx1__ = (__RetrievalLogic_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                DocumentRetrievalPort = new DocumentRetrievalPortType(0, this);
                RestContentVersionQueryPort = new RestContentVersionQueryPortType(1, this);
                RestContentVersionDataQueryPort = new RestContentVersionDataQueryPortType(2, this);
                __ctx__.PrologueCompleted = true;
                __ctx0__.__subWrapper0 = new Microsoft.XLANGs.Core.SubscriptionWrapper(ActivationSubGuids[0], DocumentRetrievalPort, this);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.Initialized) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.Initialized;
                goto case 1;
            case 1:
                __ctx1__ = new __RetrievalLogic_1(this);
                _stateMgrs[1] = __ctx1__;
                if ( !PostProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 2;
            case 2:
                __ctx0__.StartContext(__seg__, __ctx1__);
                if ( !PostProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 3:
                if (!__ctx0__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                __ctx1__.Finally();
                ServiceDone(__seg__, (Microsoft.XLANGs.Core.Context)_stateMgrs[0]);
                __ctx0__.OnCommit();
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment1(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Envelope __msgEnv__ = null;
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[1];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[1];
            __RetrievalLogic_root_0 __ctx0__ = (__RetrievalLogic_root_0)_stateMgrs[0];
            __RetrievalLogic_1 __ctx1__ = (__RetrievalLogic_1)_stateMgrs[1];
            ____scope35_2 __ctx2__ = (____scope35_2)_stateMgrs[2];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx1__.__TempErrorResponse = new Microsoft.XLANGs.RuntimeTypes.XmlDocumentSerializationProxy();
                __ctx1__.__ContentVersionIDStatus = default(System.Boolean);
                __ctx1__.__ContentVersionID = default(System.String);
                __ctx1__.__OrchestrationInstanceId = default(System.Guid);
                __ctx1__.__Message = default(System.String);
                __ctx1__.__SalesForceObjectName = default(System.String);
                __ctx1__.__Stage = default(System.String);
                __ctx1__.__Status = default(System.String);
                __ctx1__.__MessageTemp = default(System.String);
                __ctx1__.__SalesForceObjectId = default(System.String);
                __ctx1__.__Flag = default(System.Boolean);
                __ctx1__.__ResponseStatus = default(System.String);
                __ctx1__.__Application = default(System.String);
                __ctx1__.__SOQL_ContentVersion_QUERY = default(System.String);
                __ctx1__.__Base64String = default(System.String);
                __ctx1__.__Empty = default(System.String);
                __ctx__.PrologueCompleted = true;
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 1;
            case 1:
                if ( !PreProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[0],__eventData[0],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[1],__eventData[1],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 3;
            case 3:
                if (!DocumentRetrievalPort.GetMessageId(__ctx0__.__subWrapper0.getSubscription(this), __seg__, __ctx1__, out __msgEnv__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx1__.__DocumentRetrievalRequestMsg != null)
                    __ctx1__.UnrefMessage(__ctx1__.__DocumentRetrievalRequestMsg);
                __ctx1__.__DocumentRetrievalRequestMsg = new DocumentRetrievalRequestType("DocumentRetrievalRequestMsg", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__DocumentRetrievalRequestMsg);
                DocumentRetrievalPort.ReceiveMessage(0, __msgEnv__, __ctx1__.__DocumentRetrievalRequestMsg, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__DocumentRetrievalRequestMsg);
                    __edata.PortName = @"DocumentRetrievalPort";
                    Tracker.FireEvent(__eventLocations[2],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                __ctx1__.__TempErrorResponse.UnderlyingXmlDocument = new System.Xml.XmlDocument();
                if ( !PostProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 6;
            case 6:
                __ctx1__.__ContentVersionIDStatus = true;
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                __ctx1__.__ContentVersionID = "";
                if ( !PostProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 8;
            case 8:
                __ctx1__.__Message = "";
                if ( !PostProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 9;
            case 9:
                __ctx1__.__SalesForceObjectName = "";
                if ( !PostProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 10;
            case 10:
                __ctx1__.__Stage = "";
                if ( !PostProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 11;
            case 11:
                __ctx1__.__Status = "";
                if ( !PostProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 12;
            case 12:
                __ctx1__.__MessageTemp = "";
                if ( !PostProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 13;
            case 13:
                __ctx1__.__SalesForceObjectId = "";
                if ( !PostProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 14;
            case 14:
                __ctx1__.__Flag = true;
                if ( !PostProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 15;
            case 15:
                __ctx1__.__ResponseStatus = "";
                if ( !PostProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 16;
            case 16:
                __ctx1__.__Application = "";
                if ( !PostProgressInc( __seg__, __ctx__, 17 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 17;
            case 17:
                __ctx1__.__SOQL_ContentVersion_QUERY = "";
                if ( !PostProgressInc( __seg__, __ctx__, 18 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 18;
            case 18:
                __ctx1__.__Base64String = "";
                if (__ctx1__ != null)
                    __ctx1__.__Base64String = null;
                if ( !PostProgressInc( __seg__, __ctx__, 19 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 19;
            case 19:
                __ctx1__.__Empty = "";
                if ( !PostProgressInc( __seg__, __ctx__, 20 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 20;
            case 20:
                if ( !PreProgressInc( __seg__, __ctx__, 21 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[4],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 21;
            case 21:
                __ctx2__ = new ____scope35_2(this);
                _stateMgrs[2] = __ctx2__;
                if ( !PostProgressInc( __seg__, __ctx__, 22 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 22;
            case 22:
                __ctx1__.StartContext(__seg__, __ctx2__);
                if ( !PostProgressInc( __seg__, __ctx__, 23 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 23:
                if ( !PreProgressInc( __seg__, __ctx__, 24 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if (__ctx1__ != null)
                    __ctx1__.__SOQL_ContentVersion_QUERY = null;
                if (__ctx1__ != null)
                    __ctx1__.__ResponseStatus = null;
                if (__ctx1__ != null)
                    __ctx1__.__MessageTemp = null;
                if (__ctx1__ != null)
                    __ctx1__.__ContentVersionID = null;
                if (__ctx1__ != null)
                    __ctx1__.__TempErrorResponse = null;
                if (__ctx1__ != null && __ctx1__.__DocumentRetrievalRequestMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__DocumentRetrievalRequestMsg);
                    __ctx1__.__DocumentRetrievalRequestMsg = null;
                }
                if (RestContentVersionDataQueryPort != null)
                {
                    RestContentVersionDataQueryPort.Close(__ctx1__, __seg__);
                    RestContentVersionDataQueryPort = null;
                }
                if (RestContentVersionQueryPort != null)
                {
                    RestContentVersionQueryPort.Close(__ctx1__, __seg__);
                    RestContentVersionQueryPort = null;
                }
                Tracker.FireEvent(__eventLocations[48],__eventData[14],_stateMgrs[1].TrackDataStream );
                __ctx2__.Finally();
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 24;
            case 24:
                if ( !PreProgressInc( __seg__, __ctx__, 25 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[49],__eventData[8],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 25;
            case 25:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 26 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 26;
            case 26:
                if ( !PreProgressInc( __seg__, __ctx__, 27 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                DocumentRetrievalPort.SendMessage(0, __ctx1__.__DocumentRetrievalResponseMsg, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.None );
                if (DocumentRetrievalPort != null)
                {
                    DocumentRetrievalPort.Close(__ctx1__, __seg__);
                    DocumentRetrievalPort = null;
                }
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingResp) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingResp;
                goto case 27;
            case 27:
                if ( !PreProgressInc( __seg__, __ctx__, 28 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__DocumentRetrievalResponseMsg);
                    __edata.PortName = @"DocumentRetrievalPort";
                    Tracker.FireEvent(__eventLocations[50],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__DocumentRetrievalResponseMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__DocumentRetrievalResponseMsg);
                    __ctx1__.__DocumentRetrievalResponseMsg = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 28;
            case 28:
                if ( !PreProgressInc( __seg__, __ctx__, 29 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[51],__eventData[10],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 29;
            case 29:
                {
                    Microsoft.XLANGs.Core.Service svc = new DLAPDocument.RetrievalEventRequest(4, InstanceId, this);
                    _stateMgrs[4] = svc;
                    __ctx1__.StartCall(__seg__, svc, __eventLocations[51],new object[] {__ctx1__.__Application, __ctx1__.__SalesForceObjectId, __ctx1__.__Message, __ctx1__.__SalesForceObjectName, __ctx1__.__Stage, __ctx1__.__Status, __ctx1__.__Empty, __ctx1__.__OrchestrationInstanceId});
                }
                if ( !PostProgressInc( __seg__, __ctx__, 30 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 30:
                if ( !PreProgressInc( __seg__, __ctx__, 31 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    object[] args = ((Microsoft.XLANGs.Core.Service)_stateMgrs[4]).Args;
                }
                if (__ctx1__ != null)
                    __ctx1__.__Empty = null;
                if (__ctx1__ != null)
                    __ctx1__.__Application = null;
                if (__ctx1__ != null)
                    __ctx1__.__SalesForceObjectId = null;
                if (__ctx1__ != null)
                    __ctx1__.__Status = null;
                if (__ctx1__ != null)
                    __ctx1__.__Stage = null;
                if (__ctx1__ != null)
                    __ctx1__.__SalesForceObjectName = null;
                if (__ctx1__ != null)
                    __ctx1__.__Message = null;
                Tracker.FireEvent(__eventLocations[52],__eventData[11],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 31;
            case 31:
                if ( !PreProgressInc( __seg__, __ctx__, 32 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[3],__eventData[15],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 32;
            case 32:
                if (!__ctx1__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 33 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 33;
            case 33:
                if ( !PreProgressInc( __seg__, __ctx__, 34 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx1__.OnCommit();
                goto case 34;
            case 34:
                __seg__.SegmentDone();
                _segments[0].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment2(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Envelope __msgEnv__ = null;
            bool __condition__;
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[2];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[2];
            __RetrievalLogic_root_0 __ctx0__ = (__RetrievalLogic_root_0)_stateMgrs[0];
            __RetrievalLogic_1 __ctx1__ = (__RetrievalLogic_1)_stateMgrs[1];
            ____scope35_2 __ctx2__ = (____scope35_2)_stateMgrs[2];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx__.PrologueCompleted = true;
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 1;
            case 1:
                if ( !PreProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[6],__eventData[3],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 2;
            case 2:
                __ctx1__.__ContentVersionID = (System.String)Microsoft.XLANGs.Core.Part.XPathLoad(__ctx1__.__DocumentRetrievalRequestMsg.MessagePart, "string(/*[local-name()='RetrievalRequest' and namespace-uri()='http://SBA.gov/DLAPDocumentRetrieval/RetrievalRequest']/*[local-name()='SDCID' and namespace-uri()=''])", typeof(System.String));
                if ( !PostProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 3;
            case 3:
                if ( !PreProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[7],__eventData[4],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[5],__eventData[5],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                __condition__ = !System.String.IsNullOrWhiteSpace(__ctx1__.__ContentVersionID);
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 8 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 8;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 6;
            case 6:
                __ctx1__.__ContentVersionIDStatus = true;
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                if ( !PostProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 9;
            case 8:
                __ctx1__.__ContentVersionIDStatus = false;
                if ( !PostProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 9;
            case 9:
                if ( !PreProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[8],__eventData[6],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 10;
            case 10:
                if ( !PreProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[9],__eventData[5],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 11;
            case 11:
                __condition__ = __ctx1__.__ContentVersionIDStatus;
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 40 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 40;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 12;
            case 12:
                if ( !PreProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[10],__eventData[7],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 13;
            case 13:
                {
                    RestContentVersionQueryRequestType __RestContentVersionQueryRequestMsg = new RestContentVersionQueryRequestType("RestContentVersionQueryRequestMsg", __ctx1__);

                    ApplyTransform(typeof(DocumentRetrievalLogic.MakeContentVersionRequestMsg), new object[] {__RestContentVersionQueryRequestMsg.MessagePart}, new object[] {__ctx1__.__DocumentRetrievalRequestMsg.MessagePart});
                    __ctx1__.__SOQL_ContentVersion_QUERY = @"Select Id, LatestPublishedVersion.Id, LatestPublishedVersion.VersionData, LatestPublishedVersion.FileType from ContentDocument where LatestPublishedVersion.Id IN " + "(" + "'" + __ctx1__.__ContentVersionID + "'" + ")";
                    __RestContentVersionQueryRequestMsg.SetPropertyValue(typeof(DLAPDocumentRetrievalSalesforceDefinition.Rest.SOQL_ContentVersion_Query), __ctx1__.__SOQL_ContentVersion_QUERY);

                    if (__ctx1__.__RestContentVersionQueryRequestMsg != null)
                        __ctx1__.UnrefMessage(__ctx1__.__RestContentVersionQueryRequestMsg);
                    __ctx1__.__RestContentVersionQueryRequestMsg = __RestContentVersionQueryRequestMsg;
                    __ctx1__.RefMessage(__ctx1__.__RestContentVersionQueryRequestMsg);
                }
                __ctx1__.__RestContentVersionQueryRequestMsg.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 14;
            case 14:
                if ( !PreProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__RestContentVersionQueryRequestMsg);
                    __edata.Messages.Add(__ctx1__.__DocumentRetrievalRequestMsg);
                    Tracker.FireEvent(__eventLocations[11],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 15;
            case 15:
                if ( !PreProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[12],__eventData[8],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 16;
            case 16:
                if (!__ctx2__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 17 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 17;
            case 17:
                if ( !PreProgressInc( __seg__, __ctx__, 18 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                RestContentVersionQueryPort.SendMessage(0, __ctx1__.__RestContentVersionQueryRequestMsg, null, null, out __ctx0__.__subWrapper1, __ctx2__, __seg__ );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 18;
            case 18:
                if ( !PreProgressInc( __seg__, __ctx__, 19 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__RestContentVersionQueryRequestMsg);
                    __edata.PortName = @"RestContentVersionQueryPort";
                    Tracker.FireEvent(__eventLocations[13],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 19;
            case 19:
                if ( !PreProgressInc( __seg__, __ctx__, 20 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[14],__eventData[1],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 20;
            case 20:
                if (!RestContentVersionQueryPort.GetMessageId(__ctx0__.__subWrapper1.getSubscription(this), __seg__, __ctx1__, out __msgEnv__, _locations[0]))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx0__ != null && __ctx0__.__subWrapper1 != null)
                {
                    __ctx0__.__subWrapper1.Destroy(this, __ctx0__);
                    __ctx0__.__subWrapper1 = null;
                }
                if (__ctx1__.__RestContentVersionQueryResponseMsg != null)
                    __ctx1__.UnrefMessage(__ctx1__.__RestContentVersionQueryResponseMsg);
                __ctx1__.__RestContentVersionQueryResponseMsg = new RestContentVersionQueryResponseType("RestContentVersionQueryResponseMsg", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__RestContentVersionQueryResponseMsg);
                RestContentVersionQueryPort.ReceiveMessage(0, __msgEnv__, __ctx1__.__RestContentVersionQueryResponseMsg, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[2], __seg__);
                if ( !PostProgressInc( __seg__, __ctx__, 21 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 21;
            case 21:
                if ( !PreProgressInc( __seg__, __ctx__, 22 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__RestContentVersionQueryResponseMsg);
                    __edata.PortName = @"RestContentVersionQueryPort";
                    Tracker.FireEvent(__eventLocations[15],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 22;
            case 22:
                if ( !PreProgressInc( __seg__, __ctx__, 23 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[16],__eventData[7],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 23;
            case 23:
                {
                    RestContentVersionQueryRequestType __RestContentVersionQueryRequestMsg = new RestContentVersionQueryRequestType("RestContentVersionQueryRequestMsg", __ctx1__);

                    ApplyTransform(typeof(DocumentRetrievalLogic.MakeContentVersionRequestMsg), new object[] {__RestContentVersionQueryRequestMsg.MessagePart}, new object[] {__ctx1__.__DocumentRetrievalRequestMsg.MessagePart});
                    __ctx1__.__SOQL_ContentVersion_QUERY = __ctx1__.__ContentVersionID;
                    __RestContentVersionQueryRequestMsg.SetPropertyValue(typeof(DLAPDocumentRetrievalSalesforceDefinition.Rest.SOQL_ContentVersionData_Query), __ctx1__.__SOQL_ContentVersion_QUERY);

                    if (__ctx1__.__RestContentVersionQueryRequestMsg != null)
                        __ctx1__.UnrefMessage(__ctx1__.__RestContentVersionQueryRequestMsg);
                    __ctx1__.__RestContentVersionQueryRequestMsg = __RestContentVersionQueryRequestMsg;
                    __ctx1__.RefMessage(__ctx1__.__RestContentVersionQueryRequestMsg);
                }
                __ctx1__.__RestContentVersionQueryRequestMsg.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 24 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 24;
            case 24:
                if ( !PreProgressInc( __seg__, __ctx__, 25 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__RestContentVersionQueryRequestMsg);
                    __edata.Messages.Add(__ctx1__.__DocumentRetrievalRequestMsg);
                    Tracker.FireEvent(__eventLocations[17],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 25;
            case 25:
                if ( !PreProgressInc( __seg__, __ctx__, 26 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[18],__eventData[8],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 26;
            case 26:
                if (!__ctx2__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 27 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 27;
            case 27:
                if ( !PreProgressInc( __seg__, __ctx__, 28 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                RestContentVersionDataQueryPort.SendMessage(0, __ctx1__.__RestContentVersionQueryRequestMsg, null, null, out __ctx0__.__subWrapper2, __ctx2__, __seg__ );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 28;
            case 28:
                if ( !PreProgressInc( __seg__, __ctx__, 29 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__RestContentVersionQueryRequestMsg);
                    __edata.PortName = @"RestContentVersionDataQueryPort";
                    Tracker.FireEvent(__eventLocations[19],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__RestContentVersionQueryRequestMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__RestContentVersionQueryRequestMsg);
                    __ctx1__.__RestContentVersionQueryRequestMsg = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 29;
            case 29:
                if ( !PreProgressInc( __seg__, __ctx__, 30 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[20],__eventData[1],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 30;
            case 30:
                if (!RestContentVersionDataQueryPort.GetMessageId(__ctx0__.__subWrapper2.getSubscription(this), __seg__, __ctx1__, out __msgEnv__, _locations[1]))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx0__ != null && __ctx0__.__subWrapper2 != null)
                {
                    __ctx0__.__subWrapper2.Destroy(this, __ctx0__);
                    __ctx0__.__subWrapper2 = null;
                }
                if (__ctx1__.__RestContentVersionDataQueryResponseMsg != null)
                    __ctx1__.UnrefMessage(__ctx1__.__RestContentVersionDataQueryResponseMsg);
                __ctx1__.__RestContentVersionDataQueryResponseMsg = new RestContentVersionDataQueryResponseType("RestContentVersionDataQueryResponseMsg", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__RestContentVersionDataQueryResponseMsg);
                RestContentVersionDataQueryPort.ReceiveMessage(0, __msgEnv__, __ctx1__.__RestContentVersionDataQueryResponseMsg, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[2], __seg__);
                if ( !PostProgressInc( __seg__, __ctx__, 31 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 31;
            case 31:
                if ( !PreProgressInc( __seg__, __ctx__, 32 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__RestContentVersionDataQueryResponseMsg);
                    __edata.PortName = @"RestContentVersionDataQueryPort";
                    Tracker.FireEvent(__eventLocations[21],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 32;
            case 32:
                if ( !PreProgressInc( __seg__, __ctx__, 33 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[22],__eventData[7],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 33;
            case 33:
                {
                    DocumentRetrievalResponseType __DocumentRetrievalResponseMsg = new DocumentRetrievalResponseType("DocumentRetrievalResponseMsg", __ctx1__);

                    ApplyTransform(typeof(DocumentRetrievalLogic.MakeDocumentRetrievalResponse), new object[] {__DocumentRetrievalResponseMsg.MessagePart}, new object[] {__ctx1__.__RestContentVersionQueryResponseMsg.MessagePart});
                    __DocumentRetrievalResponseMsg.MessagePart.XPathStore(SBA.BizTalk.Shared.MessageHelper.XLANGMessageHelper.Instance.ConvertBinaryMessageToBase64(CreateMessageWrapperForUserCode(__ctx1__.__RestContentVersionDataQueryResponseMsg)), "/*[local-name()='RetrievalResponse' and namespace-uri()='http://SBA.gov/DLAPDocumentRetrieval/RetrievalResponse']/*[local-name()='Document_content' and namespace-uri()='']");
                    if (__ctx1__ != null && __ctx1__.__RestContentVersionDataQueryResponseMsg != null)
                    {
                        __ctx1__.UnrefMessage(__ctx1__.__RestContentVersionDataQueryResponseMsg);
                        __ctx1__.__RestContentVersionDataQueryResponseMsg = null;
                    }

                    if (__ctx1__.__DocumentRetrievalResponseMsg != null)
                        __ctx1__.UnrefMessage(__ctx1__.__DocumentRetrievalResponseMsg);
                    __ctx1__.__DocumentRetrievalResponseMsg = __DocumentRetrievalResponseMsg;
                    __ctx1__.RefMessage(__ctx1__.__DocumentRetrievalResponseMsg);
                }
                __ctx1__.__DocumentRetrievalResponseMsg.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 34 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 34;
            case 34:
                if ( !PreProgressInc( __seg__, __ctx__, 35 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__DocumentRetrievalResponseMsg);
                    __edata.Messages.Add(__ctx1__.__RestContentVersionQueryResponseMsg);
                    Tracker.FireEvent(__eventLocations[23],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__RestContentVersionQueryResponseMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__RestContentVersionQueryResponseMsg);
                    __ctx1__.__RestContentVersionQueryResponseMsg = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 35;
            case 35:
                if ( !PreProgressInc( __seg__, __ctx__, 36 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[24],__eventData[3],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 36;
            case 36:
                __ctx1__.__Flag = true;
                if ( !PostProgressInc( __seg__, __ctx__, 37 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 37;
            case 37:
                if ( !PreProgressInc( __seg__, __ctx__, 38 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[25],__eventData[4],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 38;
            case 38:
                __ctx1__.__ResponseStatus = (System.String)Microsoft.XLANGs.Core.Part.XPathLoad(__ctx1__.__DocumentRetrievalResponseMsg.MessagePart, "string(/*[local-name()='RetrievalResponse' and namespace-uri()='http://SBA.gov/DLAPDocumentRetrieval/RetrievalResponse']/*[local-name()='Doc_retrieve_status' and namespace-uri()=''])", typeof(System.String));
                if ( !PostProgressInc( __seg__, __ctx__, 39 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 39;
            case 39:
                if ( !PostProgressInc( __seg__, __ctx__, 43 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 43;
            case 40:
                if ( !PreProgressInc( __seg__, __ctx__, 41 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[26],__eventData[7],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 41;
            case 41:
                {
                    DocumentRetrievalResponseType __DocumentRetrievalResponseMsg = new DocumentRetrievalResponseType("DocumentRetrievalResponseMsg", __ctx1__);

                    __ctx1__.__TempErrorResponse.UnderlyingXmlDocument = new System.Xml.XmlDocument();
                    __ctx1__.__TempErrorResponse.UnderlyingXmlDocument.LoadXml(@"<ns0:RetrievalResponse xmlns:ns0='http://SBA.gov/DLAPDocumentRetrieval.RetrievalResponse'><Doc_retrieve_status>FAILED</Doc_retrieve_status><Doc_retrieve_status_details>Exception:ContentVersion Id couldn’t be found thus Document can't be retrieved</Doc_retrieve_status_details></ns0:RetrievalResponse>");
                    __DocumentRetrievalResponseMsg.MessagePart.LoadFrom((System.Xml.XmlDocument)__ctx1__.__TempErrorResponse.UnderlyingXmlDocument);
                    __ctx1__.__Flag = false;

                    if (__ctx1__.__DocumentRetrievalResponseMsg != null)
                        __ctx1__.UnrefMessage(__ctx1__.__DocumentRetrievalResponseMsg);
                    __ctx1__.__DocumentRetrievalResponseMsg = __DocumentRetrievalResponseMsg;
                    __ctx1__.RefMessage(__ctx1__.__DocumentRetrievalResponseMsg);
                }
                __ctx1__.__DocumentRetrievalResponseMsg.ConstructionCompleteEvent(false);
                if ( !PostProgressInc( __seg__, __ctx__, 42 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 42;
            case 42:
                if ( !PreProgressInc( __seg__, __ctx__, 43 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__DocumentRetrievalResponseMsg);
                    Tracker.FireEvent(__eventLocations[27],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 43;
            case 43:
                if ( !PreProgressInc( __seg__, __ctx__, 44 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[28],__eventData[6],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 44;
            case 44:
                if ( !PreProgressInc( __seg__, __ctx__, 45 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[29],__eventData[5],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 45;
            case 45:
                __condition__ = (__ctx1__.__Flag) && (__ctx1__.__ResponseStatus == "SUCCESS");
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 55 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 55;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 46 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 46;
            case 46:
                if ( !PreProgressInc( __seg__, __ctx__, 47 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[30],__eventData[3],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 47;
            case 47:
                __ctx1__.__OrchestrationInstanceId = Microsoft.XLANGs.Core.Service.RootService.InstanceId;
                if ( !PostProgressInc( __seg__, __ctx__, 48 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 48;
            case 48:
                if ( !PreProgressInc( __seg__, __ctx__, 49 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[31],__eventData[4],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 49;
            case 49:
                __ctx1__.__SalesForceObjectName = "Appplication";
                if ( !PostProgressInc( __seg__, __ctx__, 50 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 50;
            case 50:
                __ctx1__.__SalesForceObjectId = __ctx1__.__ContentVersionID;
                if ( !PostProgressInc( __seg__, __ctx__, 51 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 51;
            case 51:
                __ctx1__.__Stage = "Document Retrieved";
                if ( !PostProgressInc( __seg__, __ctx__, 52 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 52;
            case 52:
                __ctx1__.__Status = "Success";
                if ( !PostProgressInc( __seg__, __ctx__, 53 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 53;
            case 53:
                __ctx1__.__Message = "Successfully Retrieved Document";
                if ( !PostProgressInc( __seg__, __ctx__, 54 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 54;
            case 54:
                if ( !PostProgressInc( __seg__, __ctx__, 63 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 63;
            case 55:
                if ( !PreProgressInc( __seg__, __ctx__, 56 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[32],__eventData[3],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 56;
            case 56:
                __ctx1__.__OrchestrationInstanceId = Microsoft.XLANGs.Core.Service.RootService.InstanceId;
                if ( !PostProgressInc( __seg__, __ctx__, 57 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 57;
            case 57:
                if ( !PreProgressInc( __seg__, __ctx__, 58 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[33],__eventData[4],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 58;
            case 58:
                __ctx1__.__Message = "File not found matching…";
                if ( !PostProgressInc( __seg__, __ctx__, 59 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 59;
            case 59:
                __ctx1__.__SalesForceObjectName = "Appplication";
                if ( !PostProgressInc( __seg__, __ctx__, 60 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 60;
            case 60:
                __ctx1__.__SalesForceObjectId = __ctx1__.__ContentVersionID;
                if ( !PostProgressInc( __seg__, __ctx__, 61 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 61;
            case 61:
                __ctx1__.__Stage = "Document Retrieved";
                if ( !PostProgressInc( __seg__, __ctx__, 62 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 62;
            case 62:
                __ctx1__.__Status = "Error";
                if ( !PostProgressInc( __seg__, __ctx__, 63 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 63;
            case 63:
                if ( !PreProgressInc( __seg__, __ctx__, 64 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[34],__eventData[6],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 64;
            case 64:
                if (!__ctx2__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 65 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 65;
            case 65:
                if ( !PreProgressInc( __seg__, __ctx__, 66 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx2__.OnCommit();
                goto case 66;
            case 66:
                __seg__.SegmentDone();
                _segments[1].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment3(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            bool __condition__;
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[3];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[2];
            __RetrievalLogic_root_0 __ctx0__ = (__RetrievalLogic_root_0)_stateMgrs[0];
            __RetrievalLogic_1 __ctx1__ = (__RetrievalLogic_1)_stateMgrs[1];
            ____scope35_2 __ctx2__ = (____scope35_2)_stateMgrs[2];

            switch (__seg__.Progress)
            {
            case 0:
                OnBeginCatchHandler(2);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 1;
            case 1:
                if ( !PreProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[35],__eventData[9],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[36],__eventData[5],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 3;
            case 3:
                __condition__ = __ctx2__.__Ex_0.InnerException != null;
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 8 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 8;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                __ctx1__.__MessageTemp = __ctx2__.__Ex_0.InnerException.ToString();
                if ( !PostProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 5;
            case 5:
                __ctx1__.__Message = __ctx1__.__MessageTemp.Substring(0, System.Convert.ToInt32(System.Math.Min(900U, __ctx1__.__MessageTemp.Length))) + "Total String Length:" + __ctx1__.__MessageTemp.Length.ToString();
                if ( !PostProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 6;
            case 6:
                System.Diagnostics.EventLog.WriteEntry("DLAP Document Retrieval Exception", __ctx1__.__Message);
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                if ( !PostProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 11;
            case 8:
                __ctx1__.__MessageTemp = __ctx2__.__Ex_0.Message.ToString();
                if ( !PostProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 9;
            case 9:
                __ctx1__.__Message = __ctx1__.__MessageTemp.Substring(0, System.Convert.ToInt32(System.Math.Min(900U, __ctx1__.__MessageTemp.Length))) + "Total String Length:" + __ctx1__.__MessageTemp.Length.ToString();
                if ( !PostProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 10;
            case 10:
                System.Diagnostics.EventLog.WriteEntry("DLAP Document Retrieval Exception", __ctx1__.__Message);
                if ( !PostProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 11;
            case 11:
                if ( !PreProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if (__ctx2__ != null)
                    __ctx2__.__Ex_0 = null;
                Tracker.FireEvent(__eventLocations[39],__eventData[6],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 12;
            case 12:
                __ctx1__.__OrchestrationInstanceId = Microsoft.XLANGs.Core.Service.RootService.InstanceId;
                if ( !PostProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 13;
            case 13:
                __ctx1__.__SalesForceObjectName = "Appplication";
                if ( !PostProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 14;
            case 14:
                __ctx1__.__SalesForceObjectId = __ctx1__.__ContentVersionID;
                if ( !PostProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 15;
            case 15:
                __ctx1__.__Stage = "Document Retrieved";
                if ( !PostProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 16;
            case 16:
                __ctx1__.__Status = "Error";
                if ( !PostProgressInc( __seg__, __ctx__, 17 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 17;
            case 17:
                if ( !PreProgressInc( __seg__, __ctx__, 18 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[40],__eventData[7],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 18;
            case 18:
                {
                    DocumentRetrievalFaultResponeType __DocumentRetrievalFaultResponeMsg = new DocumentRetrievalFaultResponeType("DocumentRetrievalFaultResponeMsg", __ctx1__);

                    __ctx1__.__TempErrorResponse.UnderlyingXmlDocument = new System.Xml.XmlDocument();
                    __ctx1__.__TempErrorResponse.UnderlyingXmlDocument.LoadXml(@"<ns0:Fault xmlns:ns0='http://SBA.gov/DLAPDocumentRetrieval/RetrievalFault'><FaultString>Exception:Internal Error</FaultString><FaultCode>An error occurred while processing the Document Retrieval</FaultCode></ns0:Fault>");
                    __DocumentRetrievalFaultResponeMsg.MessagePart.LoadFrom((System.Xml.XmlDocument)__ctx1__.__TempErrorResponse.UnderlyingXmlDocument);

                    if (__ctx1__.__DocumentRetrievalFaultResponeMsg != null)
                        __ctx1__.UnrefMessage(__ctx1__.__DocumentRetrievalFaultResponeMsg);
                    __ctx1__.__DocumentRetrievalFaultResponeMsg = __DocumentRetrievalFaultResponeMsg;
                    __ctx1__.RefMessage(__ctx1__.__DocumentRetrievalFaultResponeMsg);
                }
                __ctx1__.__DocumentRetrievalFaultResponeMsg.ConstructionCompleteEvent(false);
                if ( !PostProgressInc( __seg__, __ctx__, 19 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 19;
            case 19:
                if ( !PreProgressInc( __seg__, __ctx__, 20 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__DocumentRetrievalFaultResponeMsg);
                    Tracker.FireEvent(__eventLocations[41],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 20;
            case 20:
                if ( !PreProgressInc( __seg__, __ctx__, 21 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[42],__eventData[8],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 21;
            case 21:
                if (!__ctx2__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 22 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 22;
            case 22:
                if ( !PreProgressInc( __seg__, __ctx__, 23 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                DocumentRetrievalPort.SendFault(0, 0, __ctx1__.__DocumentRetrievalFaultResponeMsg, null, null, __ctx2__, __seg__);
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingResp) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingResp;
                goto case 23;
            case 23:
                if ( !PreProgressInc( __seg__, __ctx__, 24 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__DocumentRetrievalFaultResponeMsg);
                    __edata.PortName = @"DocumentRetrievalPort";
                    Tracker.FireEvent(__eventLocations[43],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__DocumentRetrievalFaultResponeMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__DocumentRetrievalFaultResponeMsg);
                    __ctx1__.__DocumentRetrievalFaultResponeMsg = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 24;
            case 24:
                if ( !PreProgressInc( __seg__, __ctx__, 25 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[44],__eventData[10],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 25;
            case 25:
                {
                    Microsoft.XLANGs.Core.Service svc = new DLAPDocument.RetrievalEventRequest(3, InstanceId, this);
                    _stateMgrs[3] = svc;
                    __ctx2__.StartCall(__seg__, svc, __eventLocations[44],new object[] {__ctx1__.__Application, __ctx1__.__SalesForceObjectId, __ctx1__.__Message, __ctx1__.__SalesForceObjectName, __ctx1__.__Status, __ctx1__.__Status, __ctx1__.__Empty, __ctx1__.__OrchestrationInstanceId});
                }
                if ( !PostProgressInc( __seg__, __ctx__, 26 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 26:
                if ( !PreProgressInc( __seg__, __ctx__, 27 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    object[] args = ((Microsoft.XLANGs.Core.Service)_stateMgrs[3]).Args;
                }
                Tracker.FireEvent(__eventLocations[45],__eventData[11],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 27;
            case 27:
                if ( !PreProgressInc( __seg__, __ctx__, 28 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[46],__eventData[12],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 28;
            case 28:
                RequestTerminate(__ctx2__,"An error occurred while processing the DLAP Document Retrieval");
                __seg__.SegmentDone();
                break;
            case 29:
                if ( !PreProgressInc( __seg__, __ctx__, 30 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[47],__eventData[13],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 30;
            case 30:
                __ctx2__.__exv__ = null;
                OnEndCatchHandler(2, __seg__);
                __seg__.SegmentDone();
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }
        private static Microsoft.XLANGs.Core.CachedObject[] _locations = new Microsoft.XLANGs.Core.CachedObject[] {
            new Microsoft.XLANGs.Core.CachedObject(new System.Guid("{1F3F6979-448C-4692-82BF-99C1120076C4}")),
            new Microsoft.XLANGs.Core.CachedObject(new System.Guid("{F5A764B6-DA6C-43FD-996A-354D26759076}"))
        };

    }
    //#line 298 "C:\Users\skyeniga\Source\Repos\Biztalk\DLAP Document Retrieval\Document Retrieval Logic\RetrievalEventRequest.odx"
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        },
        new System.Type[] {
            typeof(DLAPDocument.RestEventPortType)
        },
        new System.String[] {
            "RestEventPort"
        },
        new System.Type[] {
            null
        }
    )]
    [Microsoft.XLANGs.BaseTypes.ServiceCallTreeAttribute(
        new System.Type[] {
        },
        new System.Type[] {
        },
        new System.Type[] {
        }
    )]
    [Microsoft.XLANGs.BaseTypes.ServiceAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSServiceInfo.eCallable|Microsoft.XLANGs.BaseTypes.EXLangSServiceInfo.eExecable
    )]
    [System.SerializableAttribute]
    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed internal class RetrievalEventRequest : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
    {
        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        public static readonly bool __execable = true;
        [Microsoft.XLANGs.BaseTypes.CallCompensationAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSCallCompensationInfo.eHasRequestResponse
,
            new System.String[] {
            },
            new System.String[] {
            }
        )]
        public static void __bodyProxy(
            [ Microsoft.XLANGs.BaseTypes.ServiceParameterAttribute(Microsoft.XLANGs.BaseTypes.EXLangSParameter.eVariable, "") ] System.String Application_Number__c,
            [ Microsoft.XLANGs.BaseTypes.ServiceParameterAttribute(Microsoft.XLANGs.BaseTypes.EXLangSParameter.eVariable, "") ] System.String SObject_ID__c,
            [ Microsoft.XLANGs.BaseTypes.ServiceParameterAttribute(Microsoft.XLANGs.BaseTypes.EXLangSParameter.eVariable, "") ] System.String Log_Message__c,
            [ Microsoft.XLANGs.BaseTypes.ServiceParameterAttribute(Microsoft.XLANGs.BaseTypes.EXLangSParameter.eVariable, "") ] System.String SObject_Name__c,
            [ Microsoft.XLANGs.BaseTypes.ServiceParameterAttribute(Microsoft.XLANGs.BaseTypes.EXLangSParameter.eVariable, "") ] System.String Stage__c,
            [ Microsoft.XLANGs.BaseTypes.ServiceParameterAttribute(Microsoft.XLANGs.BaseTypes.EXLangSParameter.eVariable, "") ] System.String Status__c,
            [ Microsoft.XLANGs.BaseTypes.ServiceParameterAttribute(Microsoft.XLANGs.BaseTypes.EXLangSParameter.eVariable, "") ] System.String Auto_Decline_Reason__c,
            [ Microsoft.XLANGs.BaseTypes.ServiceParameterAttribute(Microsoft.XLANGs.BaseTypes.EXLangSParameter.eVariable, "") ] System.Guid OrchestrationInstanceId)
        {
        }
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(RetrievalEventRequest));
        private static volatile System.Guid[] _activationSubIds;

        private static new object _lockIdentity = new object();

        public static System.Guid UUID { get { return _serviceId; } }
        public override System.Guid ServiceId { get { return UUID; } }

        protected override System.Guid[] ActivationSubGuids
        {
            get { return _activationSubIds; }
            set { _activationSubIds = value; }
        }

        protected override object StaleStateLock
        {
            get { return _lockIdentity; }
        }

        protected override bool HasActivation { get { return false; } }

        internal bool IsExeced = false;

        static RetrievalEventRequest()
        {
            Microsoft.BizTalk.XLANGs.BTXEngine.BTXService.CacheStaticState( _serviceId );
        }

        private void ConstructorHelper()
        {
            _segments = new Microsoft.XLANGs.Core.Segment[] {
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment0), 0, 0, 0),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment1), 1, 1, 1)
            };

            _Locks = 0;
            _rootContext = new __RetrievalEventRequest_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[2];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public RetrievalEventRequest(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "RetrievalEventRequest", tracker)
        {
            ConstructorHelper();
        }

        public RetrievalEventRequest(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "RetrievalEventRequest")
        {
            ConstructorHelper();
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>2ee6dff8-07f1-4535-87b4-ca35f04552ce</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>VariableDeclarationShape</shapeType>      <ShapeID>a676f29c-3ad3-441a-9f17-93e93bcf3594</ShapeID>      <ParentLink>ServiceBody_Declaration</ParentLink>                <shapeText>Application_Number__c</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableDeclarationShape</shapeType>      <ShapeID>2cc70f21-fb1e-44c1-aa0a-270226a1cb6b</ShapeID>      <ParentLink>ServiceBody_Declaration</ParentLink>                <shapeText>SObject_ID__c</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableDeclarationShape</shapeType>      <ShapeID>abf6e77a-f970-4150-8b96-a18764dee685</ShapeID>      <ParentLink>ServiceBody_Declaration</ParentLink>                <shapeText>Log_Message__c</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableDeclarationShape</shapeType>      <ShapeID>9c3da375-0e18-4100-93a5-95e54e96444f</ShapeID>      <ParentLink>ServiceBody_Declaration</ParentLink>                <shapeText>SObject_Name__c</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableDeclarationShape</shapeType>      <ShapeID>5ea50e81-ba95-40b0-b919-e29bb55068a1</ShapeID>      <ParentLink>ServiceBody_Declaration</ParentLink>                <shapeText>Stage__c</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableDeclarationShape</shapeType>      <ShapeID>6037bce8-4a3d-4cbd-981d-a85a9a4bd78c</ShapeID>      <ParentLink>ServiceBody_Declaration</ParentLink>                <shapeText>Status__c</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableDeclarationShape</shapeType>      <ShapeID>180e5926-6764-420e-bc34-850c915c92de</ShapeID>      <ParentLink>ServiceBody_Declaration</ParentLink>                <shapeText>Auto_Decline_Reason__c</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableDeclarationShape</shapeType>      <ShapeID>8f5afe28-20b3-40a6-be0e-e3c5f9e35113</ShapeID>      <ParentLink>ServiceBody_Declaration</ParentLink>                <shapeText>OrchestrationInstanceId</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>f84d8b89-0605-4efc-a0fa-b6bca8404099</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Construct Rest Event Request Msg</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>7c03b257-1f9d-4a02-b591-aea5f1667fe7</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Make Request Msg</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>e7aaa676-ad3b-4b9b-a092-1ae10c02d9bb</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>6d47e91d-bd62-40ed-9a49-af24cec37cc9</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Send Rest Event Request</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>6e81659d-4305-431e-a67a-e169f0f4aabe</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Receive Rest Event Response</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>9158f587-ec12-486b-bd82-6c1bcab8b47e</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Extract Values</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionShape</shapeType>      <ShapeID>6b1d035d-d610-4c90-af71-267a9a0a5129</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Valid Response</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>7d48d2d0-06a2-4413-a260-052a231c2896</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>Error</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>39f3c870-1aa8-4c00-950b-0e1611a58029</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Rest Exception</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ThrowShape</shapeType>      <ShapeID>62204449-a1eb-4fc8-b1bf-0121af48e99d</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Rest Error </shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>103f3149-950d-40b4-aad1-5c4f7df5fc69</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>Else</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow><Metadata>

<TrkMetadata>
<ActionName>'RetrievalEventRequest'</ActionName><IsAtomic>0</IsAtomic><Line>298</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>317</Line><Position>13</Position><ShapeID>'f84d8b89-0605-4efc-a0fa-b6bca8404099'</ShapeID>
<Messages>
	<MsgInfo><name>RestEventRequestMsg</name><part>MessagePart</part><schema>DLAPDocumentRetrievalSalesforceDefinition.Rest.RestEvent+SaveRequest</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>344</Line><Position>13</Position><ShapeID>'6d47e91d-bd62-40ed-9a49-af24cec37cc9'</ShapeID>
<Messages>
	<MsgInfo><name>RestEventRequestMsg</name><part>MessagePart</part><schema>DLAPDocumentRetrievalSalesforceDefinition.Rest.RestEvent+SaveRequest</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>346</Line><Position>13</Position><ShapeID>'6e81659d-4305-431e-a67a-e169f0f4aabe'</ShapeID>
<Messages>
	<MsgInfo><name>RestEventResponseMsg</name><part>MessagePart</part><schema>DLAPDocumentRetrievalSalesforceDefinition.Rest.RestEvent+results</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>348</Line><Position>30</Position><ShapeID>'9158f587-ec12-486b-bd82-6c1bcab8b47e'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>352</Line><Position>13</Position><ShapeID>'6b1d035d-d610-4c90-af71-267a9a0a5129'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>355</Line><Position>36</Position><ShapeID>'39f3c870-1aa8-4c00-950b-0e1611a58029'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>357</Line><Position>17</Position><ShapeID>'62204449-a1eb-4fc8-b1bf-0121af48e99d'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='bbcbebda-889c-43dd-8d4b-e041fb1ae986' LowerBound='1.1' HigherBound='84.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='DLAPDocument' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='PortType' OID='07b579c5-839a-4e4d-a217-7913da78764d' ParentLink='Module_PortType' LowerBound='12.1' HigherBound='19.1'>
            <om:Property Name='Synchronous' Value='True' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='RestEventPortType' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='OperationDeclaration' OID='36a52f52-fb4b-4e31-a633-efdd4af743a9' ParentLink='PortType_OperationDeclaration' LowerBound='14.1' HigherBound='18.1'>
                <om:Property Name='OperationType' Value='RequestResponse' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='425e8e1f-f6d6-4ae9-9ee4-9e16e783be00' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='16.13' HigherBound='16.33'>
                    <om:Property Name='Ref' Value='DLAPDocument.RestEventRequestType' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
                <om:Element Type='MessageRef' OID='d5e4a510-d20b-4445-a7b8-b6dab9dd707d' ParentLink='OperationDeclaration_ResponseMessageRef' LowerBound='16.35' HigherBound='16.56'>
                    <om:Property Name='Ref' Value='DLAPDocument.RestEventResponseType' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Response' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='MultipartMessageType' OID='ef8a0adb-5611-46ed-b4e2-b0d6fdede31d' ParentLink='Module_MessageType' LowerBound='4.1' HigherBound='8.1'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='RestEventRequestType' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='PartDeclaration' OID='043cbdb6-b282-4738-81d9-208829dc2e67' ParentLink='MultipartMessageType_PartDeclaration' LowerBound='6.1' HigherBound='7.1'>
                <om:Property Name='ClassName' Value='DLAPDocumentRetrievalSalesforceDefinition.Rest.RestEvent.SaveRequest' />
                <om:Property Name='IsBodyPart' Value='True' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='MessagePart' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
        </om:Element>
        <om:Element Type='MultipartMessageType' OID='73fe28fb-8f44-4787-a6e3-d0761df92d6e' ParentLink='Module_MessageType' LowerBound='8.1' HigherBound='12.1'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='RestEventResponseType' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='PartDeclaration' OID='eb73e6ae-3df9-4856-9b63-37e17334d5f3' ParentLink='MultipartMessageType_PartDeclaration' LowerBound='10.1' HigherBound='11.1'>
                <om:Property Name='ClassName' Value='DLAPDocumentRetrievalSalesforceDefinition.Rest.RestEvent.results' />
                <om:Property Name='IsBodyPart' Value='True' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='MessagePart' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
        </om:Element>
        <om:Element Type='ServiceDeclaration' OID='337f13cb-d5ce-4a15-be06-bbf4dd36692c' ParentLink='Module_ServiceDeclaration' LowerBound='19.1' HigherBound='83.1'>
            <om:Property Name='InitializedTransactionType' Value='False' />
            <om:Property Name='IsInvokable' Value='True' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='RetrievalEventRequest' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='VariableDeclaration' OID='8fdeac09-2c4f-4ce7-8adb-ac78e1512acd' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='26.1' HigherBound='27.1'>
                <om:Property Name='UseDefaultConstructor' Value='True' />
                <om:Property Name='Type' Value='System.Xml.XmlDocument' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='TempXml' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='a95680b5-d687-4fa0-9f64-730e1fe273ca' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='27.1' HigherBound='28.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='GUID' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='034db045-a866-4f9c-b63e-9dfcdd93bd71' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='28.1' HigherBound='29.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='RestEventMessage' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='4cb16eb8-b513-4ffb-863a-7e9fd6b86d9f' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='29.1' HigherBound='30.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='RestEventSFID' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='655bc5ef-bb88-414d-82b9-8a08a169cfba' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='30.1' HigherBound='31.1'>
                <om:Property Name='UseDefaultConstructor' Value='True' />
                <om:Property Name='Type' Value='System.Exception' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='RestEventException' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='6e7fe960-d5a3-4467-b7ea-c1cd8a4a3046' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='24.1' HigherBound='25.1'>
                <om:Property Name='Type' Value='DLAPDocument.RestEventRequestType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='RestEventRequestMsg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='ea9f32f2-a444-40e6-a63a-fdc3f7748aec' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='25.1' HigherBound='26.1'>
                <om:Property Name='Type' Value='DLAPDocument.RestEventResponseType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='RestEventResponseMsg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='ServiceBody' OID='2ee6dff8-07f1-4535-87b4-ca35f04552ce' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='VariableDeclaration' OID='a676f29c-3ad3-441a-9f17-93e93bcf3594' ParentLink='ServiceBody_Declaration' LowerBound='31.15' HigherBound='31.50'>
                    <om:Property Name='UseDefaultConstructor' Value='False' />
                    <om:Property Name='Type' Value='System.String' />
                    <om:Property Name='ParamDirection' Value='In' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Application_Number__c' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='VariableDeclaration' OID='2cc70f21-fb1e-44c1-aa0a-270226a1cb6b' ParentLink='ServiceBody_Declaration' LowerBound='31.52' HigherBound='31.79'>
                    <om:Property Name='UseDefaultConstructor' Value='False' />
                    <om:Property Name='Type' Value='System.String' />
                    <om:Property Name='ParamDirection' Value='In' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='SObject_ID__c' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='VariableDeclaration' OID='abf6e77a-f970-4150-8b96-a18764dee685' ParentLink='ServiceBody_Declaration' LowerBound='31.81' HigherBound='31.109'>
                    <om:Property Name='UseDefaultConstructor' Value='False' />
                    <om:Property Name='Type' Value='System.String' />
                    <om:Property Name='ParamDirection' Value='In' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Log_Message__c' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='VariableDeclaration' OID='9c3da375-0e18-4100-93a5-95e54e96444f' ParentLink='ServiceBody_Declaration' LowerBound='31.111' HigherBound='31.140'>
                    <om:Property Name='UseDefaultConstructor' Value='False' />
                    <om:Property Name='Type' Value='System.String' />
                    <om:Property Name='ParamDirection' Value='In' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='SObject_Name__c' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='VariableDeclaration' OID='5ea50e81-ba95-40b0-b919-e29bb55068a1' ParentLink='ServiceBody_Declaration' LowerBound='31.142' HigherBound='31.164'>
                    <om:Property Name='UseDefaultConstructor' Value='False' />
                    <om:Property Name='Type' Value='System.String' />
                    <om:Property Name='ParamDirection' Value='In' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Stage__c' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='VariableDeclaration' OID='6037bce8-4a3d-4cbd-981d-a85a9a4bd78c' ParentLink='ServiceBody_Declaration' LowerBound='31.166' HigherBound='31.189'>
                    <om:Property Name='UseDefaultConstructor' Value='False' />
                    <om:Property Name='Type' Value='System.String' />
                    <om:Property Name='ParamDirection' Value='In' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Status__c' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='VariableDeclaration' OID='180e5926-6764-420e-bc34-850c915c92de' ParentLink='ServiceBody_Declaration' LowerBound='31.191' HigherBound='31.227'>
                    <om:Property Name='UseDefaultConstructor' Value='False' />
                    <om:Property Name='Type' Value='System.String' />
                    <om:Property Name='ParamDirection' Value='In' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Auto_Decline_Reason__c' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='VariableDeclaration' OID='8f5afe28-20b3-40a6-be0e-e3c5f9e35113' ParentLink='ServiceBody_Declaration' LowerBound='31.229' HigherBound='31.264'>
                    <om:Property Name='UseDefaultConstructor' Value='False' />
                    <om:Property Name='Type' Value='System.Guid' />
                    <om:Property Name='ParamDirection' Value='In' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='OrchestrationInstanceId' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Construct' OID='f84d8b89-0605-4efc-a0fa-b6bca8404099' ParentLink='ServiceBody_Statement' LowerBound='38.1' HigherBound='65.1'>
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Construct Rest Event Request Msg' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='MessageAssignment' OID='7c03b257-1f9d-4a02-b591-aea5f1667fe7' ParentLink='ComplexStatement_Statement' LowerBound='41.1' HigherBound='64.1'>
                        <om:Property Name='Expression' Value='TempXml = new System.Xml.XmlDocument();&#xD;&#xA;&#xD;&#xA;Status__c = System.Security.SecurityElement.Escape(Status__c); &#xD;&#xA;&#xD;&#xA;Stage__c = System.Security.SecurityElement.Escape(Stage__c);&#xD;&#xA; &#xD;&#xA;Application_Number__c = System.Security.SecurityElement.Escape(Application_Number__c); &#xD;&#xA;&#xD;&#xA;SObject_Name__c = System.Security.SecurityElement.Escape(SObject_Name__c); &#xD;&#xA;&#xD;&#xA;SObject_ID__c= System.Security.SecurityElement.Escape(SObject_ID__c); &#xD;&#xA;&#xD;&#xA;Log_Message__c = System.Security.SecurityElement.Escape(Log_Message__c); &#xD;&#xA;&#xD;&#xA;GUID = System.DateTime.Now.ToString(&quot;yyyyMMddHHmmssfffffff&quot;)+&quot;--&quot;+System.Convert.ToString(OrchestrationInstanceId);&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;TempXml.LoadXml(System.String.Format(&quot;&lt;ns0:SaveRequest xmlns:ns0=&apos;http://SBA.gov/DLAPDocumentRetrieval/REST/INSERT/EventRequest&apos;&gt;&lt;ns0:allOrNone&gt;true&lt;/ns0:allOrNone&gt;&lt;ns0:records type=&apos;Event_Request__c&apos;&gt;&lt;ns0:Application_Number__c&gt;{0}&lt;/ns0:Application_Number__c&gt;&lt;ns0:SObject_ID__c&gt;{1}&lt;/ns0:SObject_ID__c&gt;&lt;ns0:Log_Message__c&gt;{2}&lt;/ns0:Log_Message__c&gt;&lt;ns0:SObject_Name__c&gt;{3}&lt;/ns0:SObject_Name__c&gt;&lt;ns0:Stage__c&gt;{4}&lt;/ns0:Stage__c&gt;&lt;ns0:Status__c&gt;{5}&lt;/ns0:Status__c&gt;&lt;ns0:Auto_Decline_Reason__c&gt;{6}&lt;/ns0:Auto_Decline_Reason__c&gt;&lt;ns0:GUID__c&gt;{7}&lt;/ns0:GUID__c&gt;&lt;/ns0:records&gt;&lt;/ns0:SaveRequest&gt;&quot;,Application_Number__c,SObject_ID__c,Log_Message__c,SObject_Name__c,Stage__c,Status__c,Auto_Decline_Reason__c,GUID));&#xD;&#xA;&#xD;&#xA;RestEventRequestMsg.MessagePart = TempXml;&#xD;&#xA;&#xD;&#xA;' />
                        <om:Property Name='ReportToAnalyst' Value='False' />
                        <om:Property Name='Name' Value='Make Request Msg' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                    <om:Element Type='MessageRef' OID='e7aaa676-ad3b-4b9b-a092-1ae10c02d9bb' ParentLink='Construct_MessageRef' LowerBound='39.23' HigherBound='39.42'>
                        <om:Property Name='Ref' Value='RestEventRequestMsg' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                </om:Element>
                <om:Element Type='Send' OID='6d47e91d-bd62-40ed-9a49-af24cec37cc9' ParentLink='ServiceBody_Statement' LowerBound='65.1' HigherBound='67.1'>
                    <om:Property Name='PortName' Value='RestEventPort' />
                    <om:Property Name='MessageName' Value='RestEventRequestMsg' />
                    <om:Property Name='OperationName' Value='Operation' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Send Rest Event Request' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Receive' OID='6e81659d-4305-431e-a67a-e169f0f4aabe' ParentLink='ServiceBody_Statement' LowerBound='67.1' HigherBound='69.1'>
                    <om:Property Name='Activate' Value='False' />
                    <om:Property Name='PortName' Value='RestEventPort' />
                    <om:Property Name='MessageName' Value='RestEventResponseMsg' />
                    <om:Property Name='OperationName' Value='Operation' />
                    <om:Property Name='OperationMessageName' Value='Response' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Receive Rest Event Response' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='VariableAssignment' OID='9158f587-ec12-486b-bd82-6c1bcab8b47e' ParentLink='ServiceBody_Statement' LowerBound='69.1' HigherBound='73.1'>
                    <om:Property Name='Expression' Value='RestEventMessage =  xpath(RestEventResponseMsg.MessagePart,&quot;string(/*[local-name()=&apos;results&apos; and namespace-uri()=&apos;http://SBA.gov/DLAPDocumentRetrieval/REST/INSERT/EventRequest&apos;]/*[local-name()=&apos;result&apos; and namespace-uri()=&apos;http://SBA.gov/DLAPDocumentRetrieval/REST/INSERT/EventRequest&apos;]/*[local-name()=&apos;errors&apos; and namespace-uri()=&apos;http://SBA.gov/DLAPDocumentRetrieval/REST/INSERT/EventRequest&apos;]/*[local-name()=&apos;message&apos; and namespace-uri()=&apos;http://SBA.gov/DLAPDocumentUpload/REST/INSERT/EventResponse&apos;])&quot;);&#xD;&#xA;&#xD;&#xA;RestEventSFID = xpath(RestEventResponseMsg.MessagePart,&quot;string(/*[local-name()=&apos;results&apos; and namespace-uri()=&apos;http://SBA.gov/DLAPDocumentRetrieval/REST/INSERT/EventRequest&apos;]/*[local-name()=&apos;result&apos; and namespace-uri()=&apos;http://SBA.gov/DLAPDocumentRetrieval/REST/INSERT/EventRequest&apos;]/*[local-name()=&apos;id&apos; and namespace-uri()=&apos;http://SBA.gov/DLAPDocumentRetrieval/REST/INSERT/EventRequest&apos;])&quot;);' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Extract Values' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Decision' OID='6b1d035d-d610-4c90-af71-267a9a0a5129' ParentLink='ServiceBody_Statement' LowerBound='73.1' HigherBound='81.1'>
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Valid Response' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='DecisionBranch' OID='7d48d2d0-06a2-4413-a260-052a231c2896' ParentLink='ReallyComplexStatement_Branch' LowerBound='74.13' HigherBound='81.1'>
                        <om:Property Name='Expression' Value='!System.String.IsNullOrWhiteSpace(RestEventMessage) &amp;&amp; (RestEventSFID.Length == 0)' />
                        <om:Property Name='IsGhostBranch' Value='True' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Error' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='VariableAssignment' OID='39f3c870-1aa8-4c00-950b-0e1611a58029' ParentLink='ComplexStatement_Statement' LowerBound='76.1' HigherBound='78.1'>
                            <om:Property Name='Expression' Value='RestEventException = new System.Exception(&quot;DLAP Document Retrieval Event Request Rest Exception  -  &quot; + RestEventMessage);' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Rest Exception' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                        <om:Element Type='Throw' OID='62204449-a1eb-4fc8-b1bf-0121af48e99d' ParentLink='ComplexStatement_Statement' LowerBound='78.1' HigherBound='80.1'>
                            <om:Property Name='ThrownReference' Value='RestEventException' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Rest Error ' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='DecisionBranch' OID='103f3149-950d-40b4-aad1-5c4f7df5fc69' ParentLink='ReallyComplexStatement_Branch'>
                        <om:Property Name='IsGhostBranch' Value='True' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Else' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='e730237c-d203-49ea-aabb-c5922f587297' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='22.1' HigherBound='24.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='DLAPDocument.RestEventPortType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='RestEventPort' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='cb8f9576-30e9-40b2-8d5e-878631c8bbfd' ParentLink='PortDeclaration_CLRAttribute' LowerBound='22.1' HigherBound='23.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
    </om:Element>
</om:MetaModel>
";

        [System.SerializableAttribute]
        public class __RetrievalEventRequest_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __RetrievalEventRequest_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "RetrievalEventRequest")
            {
            }

            public override int Index { get { return 0; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[0]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[0]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Finally();
                return false;
            }

            public override void Finally()
            {
                RetrievalEventRequest __svc__ = (RetrievalEventRequest)_service;
                __RetrievalEventRequest_root_0 __ctx0__ = (__RetrievalEventRequest_root_0)(__svc__._stateMgrs[0]);

                if (__svc__.RestEventPort != null)
                {
                    __svc__.RestEventPort.Close(this, null);
                    __svc__.RestEventPort = null;
                }
                base.Finally();
            }

            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper0;
        }


        [System.SerializableAttribute]
        public class __RetrievalEventRequest_1 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public __RetrievalEventRequest_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "RetrievalEventRequest")
            {
            }

            public override int Index { get { return 1; } }

            public override bool CombineParentCommit { get { return true; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[1]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[1]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Finally();
                return false;
            }

            public override void Finally()
            {
                RetrievalEventRequest __svc__ = (RetrievalEventRequest)_service;
                __RetrievalEventRequest_1 __ctx1__ = (__RetrievalEventRequest_1)(__svc__._stateMgrs[1]);
                __RetrievalEventRequest_root_0 __ctx0__ = (__RetrievalEventRequest_root_0)(__svc__._stateMgrs[0]);

                if (__ctx1__ != null)
                    __ctx1__.__RestEventSFID = null;
                if (__ctx1__ != null && __ctx1__.__RestEventRequestMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__RestEventRequestMsg);
                    __ctx1__.__RestEventRequestMsg = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__SObject_Name__c = null;
                if (__ctx1__ != null && __ctx1__.__RestEventResponseMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__RestEventResponseMsg);
                    __ctx1__.__RestEventResponseMsg = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__GUID = null;
                if (__ctx1__ != null)
                    __ctx1__.__RestEventMessage = null;
                if (__ctx1__ != null)
                    __ctx1__.__SObject_ID__c = null;
                if (__ctx1__ != null)
                    __ctx1__.__TempXml = null;
                if (__ctx1__ != null)
                    __ctx1__.__RestEventException = null;
                if (__ctx1__ != null)
                    __ctx1__.__Application_Number__c = null;
                if (__ctx1__ != null)
                    __ctx1__.__Log_Message__c = null;
                if (__ctx0__ != null && __ctx0__.__subWrapper0 != null)
                {
                    __ctx0__.__subWrapper0.Destroy(__svc__, __ctx0__);
                    __ctx0__.__subWrapper0 = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__Stage__c = null;
                if (__ctx1__ != null)
                    __ctx1__.__Status__c = null;
                if (__ctx1__ != null)
                    __ctx1__.__Auto_Decline_Reason__c = null;
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("RestEventRequestMsg")]
            internal RestEventRequestType __RestEventRequestMsg;
            [Microsoft.XLANGs.Core.UserVariableAttribute("RestEventResponseMsg")]
            internal RestEventResponseType __RestEventResponseMsg;
            [Microsoft.XLANGs.Core.UserVariableAttribute("TempXml")]
            internal Microsoft.XLANGs.RuntimeTypes.XmlDocumentSerializationProxy __TempXml;
            [Microsoft.XLANGs.Core.UserVariableAttribute("GUID")]
            internal System.String __GUID;
            [Microsoft.XLANGs.Core.UserVariableAttribute("RestEventMessage")]
            internal System.String __RestEventMessage;
            [Microsoft.XLANGs.Core.UserVariableAttribute("RestEventSFID")]
            internal System.String __RestEventSFID;
            [Microsoft.XLANGs.Core.UserVariableAttribute("RestEventException")]
            internal System.Exception __RestEventException;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Application_Number__c")]
            internal System.String __Application_Number__c;
            [Microsoft.XLANGs.Core.UserVariableAttribute("SObject_ID__c")]
            internal System.String __SObject_ID__c;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Log_Message__c")]
            internal System.String __Log_Message__c;
            [Microsoft.XLANGs.Core.UserVariableAttribute("SObject_Name__c")]
            internal System.String __SObject_Name__c;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Stage__c")]
            internal System.String __Stage__c;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Status__c")]
            internal System.String __Status__c;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Auto_Decline_Reason__c")]
            internal System.String __Auto_Decline_Reason__c;
            [Microsoft.XLANGs.Core.UserVariableAttribute("OrchestrationInstanceId")]
            internal System.Guid __OrchestrationInstanceId;
        }

        private static Microsoft.XLANGs.Core.CorrelationType[] _correlationTypes = null;
        public override Microsoft.XLANGs.Core.CorrelationType[] CorrelationTypes { get { return _correlationTypes; } }

        private static System.Guid[] _convoySetIds;

        public override System.Guid[] ConvoySetGuids
        {
            get { return _convoySetIds; }
            set { _convoySetIds = value; }
        }

        public static object[] StaticConvoySetInformation
        {
            get {
                return null;
            }
        }

        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("RestEventPort")]
        internal RestEventPortType RestEventPort;

        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {RestEventPortType.Operation},
                                               typeof(RetrievalEventRequest).GetField("RestEventPort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(RetrievalEventRequest), "RestEventPort"),
                                               null)
        };

        public override Microsoft.XLANGs.Core.PortInfo[] PortInformation
        {
            get { return _portInfo; }
        }

        static public System.Collections.Hashtable PortsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[_portInfo[0].Name] = _portInfo[0];
                return h;
            }
        }

        public static System.Type[] InvokedServicesTypes
        {
            get
            {
                return new System.Type[] {
                    // type of each service invoked by this service
                };
            }
        }

        public static System.Type[] CalledServicesTypes
        {
            get
            {
                return new System.Type[] {
                };
            }
        }

        public static System.Type[] ExecedServicesTypes
        {
            get
            {
                return new System.Type[] {
                };
            }
        }


        public static Microsoft.XLANGs.RuntimeTypes.Location[] __eventLocations = new Microsoft.XLANGs.RuntimeTypes.Location[] {
            new Microsoft.XLANGs.RuntimeTypes.Location(0, "00000000-0000-0000-0000-000000000000", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "00000000-0000-0000-0000-000000000000", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "f84d8b89-0605-4efc-a0fa-b6bca8404099", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "f84d8b89-0605-4efc-a0fa-b6bca8404099", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "6d47e91d-bd62-40ed-9a49-af24cec37cc9", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "6d47e91d-bd62-40ed-9a49-af24cec37cc9", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(6, "6e81659d-4305-431e-a67a-e169f0f4aabe", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(7, "6e81659d-4305-431e-a67a-e169f0f4aabe", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(8, "9158f587-ec12-486b-bd82-6c1bcab8b47e", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(9, "9158f587-ec12-486b-bd82-6c1bcab8b47e", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(10, "6b1d035d-d610-4c90-af71-267a9a0a5129", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(11, "39f3c870-1aa8-4c00-950b-0e1611a58029", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(12, "39f3c870-1aa8-4c00-950b-0e1611a58029", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(13, "62204449-a1eb-4fc8-b1bf-0121af48e99d", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(14, "6b1d035d-d610-4c90-af71-267a9a0a5129", 1, false)
        };

        public override Microsoft.XLANGs.RuntimeTypes.Location[] EventLocations
        {
            get { return __eventLocations; }
        }

        public static Microsoft.XLANGs.RuntimeTypes.EventData[] __eventData = new Microsoft.XLANGs.RuntimeTypes.EventData[] {
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Body),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Body),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Construct),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Send),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Receive),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Expression),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Expression),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.If),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Throw),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.If)
        };

        public static int[] __progressLocation0 = new int[] { 0,0,0,1,1,};
        public static int[] __progressLocation1 = new int[] { 0,0,1,1,1,1,1,1,2,2,3,4,4,4,5,6,6,7,8,8,9,9,10,10,11,11,12,13,13,14,1,1,1,1,};

        public static int[][] __progressLocations = new int[2] [] {__progressLocation0,__progressLocation1};
        public override int[][] ProgressLocations {get {return __progressLocations;} }

        public Microsoft.XLANGs.Core.StopConditions segment0(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[0];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[0];
            __RetrievalEventRequest_1 __ctx1__ = (__RetrievalEventRequest_1)_stateMgrs[1];
            __RetrievalEventRequest_root_0 __ctx0__ = (__RetrievalEventRequest_root_0)_stateMgrs[0];

            switch (__seg__.Progress)
            {
            case 0:
                RestEventPort = new RestEventPortType(0, this);
                __ctx__.PrologueCompleted = true;
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.Initialized) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.Initialized;
                goto case 1;
            case 1:
                __ctx1__ = new __RetrievalEventRequest_1(this);
                _stateMgrs[1] = __ctx1__;
                if ( !PostProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 2;
            case 2:
                __ctx0__.StartContext(__seg__, __ctx1__);
                if ( !PostProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 3:
                if (!__ctx0__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                __ctx1__.Finally();
                ServiceDone(__seg__, (Microsoft.XLANGs.Core.Context)_stateMgrs[0]);
                __ctx0__.OnCommit();
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment1(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Envelope __msgEnv__ = null;
            bool __condition__;
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[1];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[1];
            __RetrievalEventRequest_1 __ctx1__ = (__RetrievalEventRequest_1)_stateMgrs[1];
            __RetrievalEventRequest_root_0 __ctx0__ = (__RetrievalEventRequest_root_0)_stateMgrs[0];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx1__.__Application_Number__c = (System.String)Args[0];
                __ctx1__.__SObject_ID__c = (System.String)Args[1];
                __ctx1__.__Log_Message__c = (System.String)Args[2];
                __ctx1__.__SObject_Name__c = (System.String)Args[3];
                __ctx1__.__Stage__c = (System.String)Args[4];
                __ctx1__.__Status__c = (System.String)Args[5];
                __ctx1__.__Auto_Decline_Reason__c = (System.String)Args[6];
                __ctx1__.__OrchestrationInstanceId = (System.Guid)Args[7];
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 1;
            case 1:
                __ctx1__.__TempXml = new Microsoft.XLANGs.RuntimeTypes.XmlDocumentSerializationProxy();
                __ctx1__.__GUID = default(System.String);
                __ctx1__.__RestEventMessage = default(System.String);
                __ctx1__.__RestEventSFID = default(System.String);
                __ctx1__.__RestEventException = default(System.Exception);
                __ctx__.PrologueCompleted = true;
                if ( !PostProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[1],__eventData[1],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 3;
            case 3:
                __ctx1__.__TempXml.UnderlyingXmlDocument = new System.Xml.XmlDocument();
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                __ctx1__.__GUID = "";
                if ( !PostProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 5;
            case 5:
                __ctx1__.__RestEventMessage = "";
                if ( !PostProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 6;
            case 6:
                __ctx1__.__RestEventSFID = "";
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                __ctx1__.__RestEventException = new System.Exception();
                if ( !PostProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 8;
            case 8:
                if ( !PreProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[2],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 9;
            case 9:
                {
                    RestEventRequestType __RestEventRequestMsg = new RestEventRequestType("RestEventRequestMsg", __ctx1__);

                    __ctx1__.__TempXml.UnderlyingXmlDocument = new System.Xml.XmlDocument();
                    __ctx1__.__Status__c = System.Security.SecurityElement.Escape(__ctx1__.__Status__c);
                    __ctx1__.__Stage__c = System.Security.SecurityElement.Escape(__ctx1__.__Stage__c);
                    __ctx1__.__Application_Number__c = System.Security.SecurityElement.Escape(__ctx1__.__Application_Number__c);
                    __ctx1__.__SObject_Name__c = System.Security.SecurityElement.Escape(__ctx1__.__SObject_Name__c);
                    __ctx1__.__SObject_ID__c = System.Security.SecurityElement.Escape(__ctx1__.__SObject_ID__c);
                    __ctx1__.__Log_Message__c = System.Security.SecurityElement.Escape(__ctx1__.__Log_Message__c);
                    __ctx1__.__GUID = System.DateTime.Now.ToString("yyyyMMddHHmmssfffffff") + "--" + System.Convert.ToString(__ctx1__.__OrchestrationInstanceId);
                    __ctx1__.__TempXml.UnderlyingXmlDocument.LoadXml(System.String.Format("<ns0:SaveRequest xmlns:ns0='http://SBA.gov/DLAPDocumentRetrieval/REST/INSERT/EventRequest'><ns0:allOrNone>true</ns0:allOrNone><ns0:records type='Event_Request__c'><ns0:Application_Number__c>{0}</ns0:Application_Number__c><ns0:SObject_ID__c>{1}</ns0:SObject_ID__c><ns0:Log_Message__c>{2}</ns0:Log_Message__c><ns0:SObject_Name__c>{3}</ns0:SObject_Name__c><ns0:Stage__c>{4}</ns0:Stage__c><ns0:Status__c>{5}</ns0:Status__c><ns0:Auto_Decline_Reason__c>{6}</ns0:Auto_Decline_Reason__c><ns0:GUID__c>{7}</ns0:GUID__c></ns0:records></ns0:SaveRequest>", __ctx1__.__Application_Number__c, __ctx1__.__SObject_ID__c, __ctx1__.__Log_Message__c, __ctx1__.__SObject_Name__c, __ctx1__.__Stage__c, __ctx1__.__Status__c, __ctx1__.__Auto_Decline_Reason__c, __ctx1__.__GUID));
                    if (__ctx1__ != null)
                        __ctx1__.__Auto_Decline_Reason__c = null;
                    if (__ctx1__ != null)
                        __ctx1__.__Status__c = null;
                    if (__ctx1__ != null)
                        __ctx1__.__Stage__c = null;
                    if (__ctx1__ != null)
                        __ctx1__.__SObject_Name__c = null;
                    if (__ctx1__ != null)
                        __ctx1__.__Log_Message__c = null;
                    if (__ctx1__ != null)
                        __ctx1__.__SObject_ID__c = null;
                    if (__ctx1__ != null)
                        __ctx1__.__Application_Number__c = null;
                    if (__ctx1__ != null)
                        __ctx1__.__GUID = null;
                    __RestEventRequestMsg.MessagePart.LoadFrom((System.Xml.XmlDocument)__ctx1__.__TempXml.UnderlyingXmlDocument);
                    if (__ctx1__ != null)
                        __ctx1__.__TempXml = null;

                    if (__ctx1__.__RestEventRequestMsg != null)
                        __ctx1__.UnrefMessage(__ctx1__.__RestEventRequestMsg);
                    __ctx1__.__RestEventRequestMsg = __RestEventRequestMsg;
                    __ctx1__.RefMessage(__ctx1__.__RestEventRequestMsg);
                }
                __ctx1__.__RestEventRequestMsg.ConstructionCompleteEvent(false);
                if ( !PostProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 10;
            case 10:
                if ( !PreProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__RestEventRequestMsg);
                    Tracker.FireEvent(__eventLocations[3],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 11;
            case 11:
                if ( !PreProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[4],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 12;
            case 12:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 13;
            case 13:
                if ( !PreProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                RestEventPort.SendMessage(0, __ctx1__.__RestEventRequestMsg, null, null, out __ctx0__.__subWrapper0, __ctx1__, __seg__ );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 14;
            case 14:
                if ( !PreProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__RestEventRequestMsg);
                    __edata.PortName = @"RestEventPort";
                    Tracker.FireEvent(__eventLocations[5],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__RestEventRequestMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__RestEventRequestMsg);
                    __ctx1__.__RestEventRequestMsg = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 15;
            case 15:
                if ( !PreProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[6],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 16;
            case 16:
                if (!RestEventPort.GetMessageId(__ctx0__.__subWrapper0.getSubscription(this), __seg__, __ctx1__, out __msgEnv__, _locations[0]))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx0__ != null && __ctx0__.__subWrapper0 != null)
                {
                    __ctx0__.__subWrapper0.Destroy(this, __ctx0__);
                    __ctx0__.__subWrapper0 = null;
                }
                if (__ctx1__.__RestEventResponseMsg != null)
                    __ctx1__.UnrefMessage(__ctx1__.__RestEventResponseMsg);
                __ctx1__.__RestEventResponseMsg = new RestEventResponseType("RestEventResponseMsg", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__RestEventResponseMsg);
                RestEventPort.ReceiveMessage(0, __msgEnv__, __ctx1__.__RestEventResponseMsg, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if (RestEventPort != null)
                {
                    RestEventPort.Close(__ctx1__, __seg__);
                    RestEventPort = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 17 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 17;
            case 17:
                if ( !PreProgressInc( __seg__, __ctx__, 18 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__RestEventResponseMsg);
                    __edata.PortName = @"RestEventPort";
                    Tracker.FireEvent(__eventLocations[7],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 18;
            case 18:
                if ( !PreProgressInc( __seg__, __ctx__, 19 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[8],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 19;
            case 19:
                __ctx1__.__RestEventMessage = (System.String)Microsoft.XLANGs.Core.Part.XPathLoad(__ctx1__.__RestEventResponseMsg.MessagePart, "string(/*[local-name()='results' and namespace-uri()='http://SBA.gov/DLAPDocumentRetrieval/REST/INSERT/EventRequest']/*[local-name()='result' and namespace-uri()='http://SBA.gov/DLAPDocumentRetrieval/REST/INSERT/EventRequest']/*[local-name()='errors' and namespace-uri()='http://SBA.gov/DLAPDocumentRetrieval/REST/INSERT/EventRequest']/*[local-name()='message' and namespace-uri()='http://SBA.gov/DLAPDocumentUpload/REST/INSERT/EventResponse'])", typeof(System.String));
                if ( !PostProgressInc( __seg__, __ctx__, 20 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 20;
            case 20:
                if ( !PreProgressInc( __seg__, __ctx__, 21 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[9],__eventData[6],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 21;
            case 21:
                __ctx1__.__RestEventSFID = (System.String)Microsoft.XLANGs.Core.Part.XPathLoad(__ctx1__.__RestEventResponseMsg.MessagePart, "string(/*[local-name()='results' and namespace-uri()='http://SBA.gov/DLAPDocumentRetrieval/REST/INSERT/EventRequest']/*[local-name()='result' and namespace-uri()='http://SBA.gov/DLAPDocumentRetrieval/REST/INSERT/EventRequest']/*[local-name()='id' and namespace-uri()='http://SBA.gov/DLAPDocumentRetrieval/REST/INSERT/EventRequest'])", typeof(System.String));
                if (__ctx1__ != null && __ctx1__.__RestEventResponseMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__RestEventResponseMsg);
                    __ctx1__.__RestEventResponseMsg = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 22 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 22;
            case 22:
                if ( !PreProgressInc( __seg__, __ctx__, 23 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[10],__eventData[7],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 23;
            case 23:
                __condition__ = !System.String.IsNullOrWhiteSpace(__ctx1__.__RestEventMessage) && (__ctx1__.__RestEventSFID.Length == 0);
                if (__ctx1__ != null)
                    __ctx1__.__RestEventSFID = null;
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 29 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 29;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 24 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 24;
            case 24:
                if ( !PreProgressInc( __seg__, __ctx__, 25 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[11],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 25;
            case 25:
                __ctx1__.__RestEventException = new System.Exception("DLAP Document Retrieval Event Request Rest Exception  -  " + __ctx1__.__RestEventMessage);
                if ( !PostProgressInc( __seg__, __ctx__, 26 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 26;
            case 26:
                if ( !PreProgressInc( __seg__, __ctx__, 27 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[12],__eventData[6],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 27;
            case 27:
                if ( !PreProgressInc( __seg__, __ctx__, 28 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[13],__eventData[8],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 28;
            case 28:
                throw __ctx1__.__RestEventException;
            case 29:
                if ( !PreProgressInc( __seg__, __ctx__, 30 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if (__ctx1__ != null)
                    __ctx1__.__RestEventException = null;
                if (__ctx1__ != null)
                    __ctx1__.__RestEventMessage = null;
                Tracker.FireEvent(__eventLocations[14],__eventData[9],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 30;
            case 30:
                if ( !PreProgressInc( __seg__, __ctx__, 31 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[0],__eventData[0],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 31;
            case 31:
                if (!__ctx1__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 32 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 32;
            case 32:
                if ( !PreProgressInc( __seg__, __ctx__, 33 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx1__.OnCommit();
                goto case 33;
            case 33:
                __seg__.SegmentDone();
                _segments[0].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }
        private static Microsoft.XLANGs.Core.CachedObject[] _locations = new Microsoft.XLANGs.Core.CachedObject[] {
            new Microsoft.XLANGs.Core.CachedObject(new System.Guid("{8F8736B6-4133-4C23-AE5B-31F6FA98CC85}"))
        };

    }

    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed public class _MODULE_PROXY_ { }
}
