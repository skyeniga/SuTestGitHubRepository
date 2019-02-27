
#pragma warning disable 162

namespace DLAPDocument
{

    [System.SerializableAttribute]
    sealed public class __DocumentListDefinition_DocumentListRequest__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static DocumentListDefinition.DocumentListRequest _schema = new DocumentListDefinition.DocumentListRequest();

        public __DocumentListDefinition_DocumentListRequest__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eNone,
        "",
        new System.Type[]{
            typeof(DocumentListDefinition.DocumentListRequest)
        },
        new string[]{
            "MessagePart"
        },
        new System.Type[]{
            typeof(__DocumentListDefinition_DocumentListRequest__)
        },
        0,
        @"http://SBA.gov/DLAPDocumentList/DocumentListRequest#DocumentListRequest"
    )]
    [System.SerializableAttribute]
    sealed internal class DocumentListRequestType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __DocumentListDefinition_DocumentListRequest__ MessagePart;

        private void __CreatePartWrappers()
        {
            MessagePart = new __DocumentListDefinition_DocumentListRequest__(this, "MessagePart", 0);
            this.AddPart("MessagePart", 0, MessagePart);
        }

        public DocumentListRequestType(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __DocumentListDefinition_DocumentListResponse__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static DocumentListDefinition.DocumentListResponse _schema = new DocumentListDefinition.DocumentListResponse();

        public __DocumentListDefinition_DocumentListResponse__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eNone,
        "",
        new System.Type[]{
            typeof(DocumentListDefinition.DocumentListResponse)
        },
        new string[]{
            "MessagePart"
        },
        new System.Type[]{
            typeof(__DocumentListDefinition_DocumentListResponse__)
        },
        0,
        @"http://SBA.gov/DLAPDocumentList/DocumentListResponse#DOCUMENT"
    )]
    [System.SerializableAttribute]
    sealed internal class DocumentListResponseType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __DocumentListDefinition_DocumentListResponse__ MessagePart;

        private void __CreatePartWrappers()
        {
            MessagePart = new __DocumentListDefinition_DocumentListResponse__(this, "MessagePart", 0);
            this.AddPart("MessagePart", 0, MessagePart);
        }

        public DocumentListResponseType(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __DocumentSalesforceListDefinition_SalesforceQuery_Application_Info__c_Request__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static DocumentSalesforceListDefinition.SalesforceQuery_Application_Info__c.Request _schema = new DocumentSalesforceListDefinition.SalesforceQuery_Application_Info__c.Request();

        public __DocumentSalesforceListDefinition_SalesforceQuery_Application_Info__c_Request__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eNone,
        "",
        new System.Type[]{
            typeof(DocumentSalesforceListDefinition.SalesforceQuery_Application_Info__c.Request)
        },
        new string[]{
            "MessagePart"
        },
        new System.Type[]{
            typeof(__DocumentSalesforceListDefinition_SalesforceQuery_Application_Info__c_Request__)
        },
        0,
        @"http://SBA.gov/DLAPDocumentList/Application_Info__c#Request"
    )]
    [System.SerializableAttribute]
    sealed internal class SalesforceQueryApplicationInfoRequestType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __DocumentSalesforceListDefinition_SalesforceQuery_Application_Info__c_Request__ MessagePart;

        private void __CreatePartWrappers()
        {
            MessagePart = new __DocumentSalesforceListDefinition_SalesforceQuery_Application_Info__c_Request__(this, "MessagePart", 0);
            this.AddPart("MessagePart", 0, MessagePart);
        }

        public SalesforceQueryApplicationInfoRequestType(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __DocumentSalesforceListDefinition_SalesforceQuery_Application_Info__c_Response__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static DocumentSalesforceListDefinition.SalesforceQuery_Application_Info__c.Response _schema = new DocumentSalesforceListDefinition.SalesforceQuery_Application_Info__c.Response();

        public __DocumentSalesforceListDefinition_SalesforceQuery_Application_Info__c_Response__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eNone,
        "",
        new System.Type[]{
            typeof(DocumentSalesforceListDefinition.SalesforceQuery_Application_Info__c.Response)
        },
        new string[]{
            "MessagePart"
        },
        new System.Type[]{
            typeof(__DocumentSalesforceListDefinition_SalesforceQuery_Application_Info__c_Response__)
        },
        0,
        @"http://SBA.gov/DLAPDocumentList/Application_Info__c#Response"
    )]
    [System.SerializableAttribute]
    sealed internal class SalesforceQueryApplicationInfoResponseType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __DocumentSalesforceListDefinition_SalesforceQuery_Application_Info__c_Response__ MessagePart;

        private void __CreatePartWrappers()
        {
            MessagePart = new __DocumentSalesforceListDefinition_SalesforceQuery_Application_Info__c_Response__(this, "MessagePart", 0);
            this.AddPart("MessagePart", 0, MessagePart);
        }

        public SalesforceQueryApplicationInfoResponseType(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __DocumentSalesforceListDefinition_SalesforceQuery_ContentVersion__c_Request__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static DocumentSalesforceListDefinition.SalesforceQuery_ContentVersion__c.Request _schema = new DocumentSalesforceListDefinition.SalesforceQuery_ContentVersion__c.Request();

        public __DocumentSalesforceListDefinition_SalesforceQuery_ContentVersion__c_Request__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eNone,
        "",
        new System.Type[]{
            typeof(DocumentSalesforceListDefinition.SalesforceQuery_ContentVersion__c.Request)
        },
        new string[]{
            "MessagePart"
        },
        new System.Type[]{
            typeof(__DocumentSalesforceListDefinition_SalesforceQuery_ContentVersion__c_Request__)
        },
        0,
        @"http://SBA.gov/DLAPDocumentList/ContentVersion__c#Request"
    )]
    [System.SerializableAttribute]
    sealed internal class SalesforceQueryContentVersionRequestType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __DocumentSalesforceListDefinition_SalesforceQuery_ContentVersion__c_Request__ MessagePart;

        private void __CreatePartWrappers()
        {
            MessagePart = new __DocumentSalesforceListDefinition_SalesforceQuery_ContentVersion__c_Request__(this, "MessagePart", 0);
            this.AddPart("MessagePart", 0, MessagePart);
        }

        public SalesforceQueryContentVersionRequestType(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __DocumentSalesforceListDefinition_SalesforceQuery_ContentVersion__c_Response__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static DocumentSalesforceListDefinition.SalesforceQuery_ContentVersion__c.Response _schema = new DocumentSalesforceListDefinition.SalesforceQuery_ContentVersion__c.Response();

        public __DocumentSalesforceListDefinition_SalesforceQuery_ContentVersion__c_Response__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eNone,
        "",
        new System.Type[]{
            typeof(DocumentSalesforceListDefinition.SalesforceQuery_ContentVersion__c.Response)
        },
        new string[]{
            "MessagePart"
        },
        new System.Type[]{
            typeof(__DocumentSalesforceListDefinition_SalesforceQuery_ContentVersion__c_Response__)
        },
        0,
        @"http://SBA.gov/DLAPDocumentList/ContentVersion__c#Response"
    )]
    [System.SerializableAttribute]
    sealed internal class SalesforceQueryContentVersionResponseType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __DocumentSalesforceListDefinition_SalesforceQuery_ContentVersion__c_Response__ MessagePart;

        private void __CreatePartWrappers()
        {
            MessagePart = new __DocumentSalesforceListDefinition_SalesforceQuery_ContentVersion__c_Response__(this, "MessagePart", 0);
            this.AddPart("MessagePart", 0, MessagePart);
        }

        public SalesforceQueryContentVersionResponseType(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __DocumentSalesforceListDefinition_MultipleDocumentDetails__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static DocumentSalesforceListDefinition.MultipleDocumentDetails _schema = new DocumentSalesforceListDefinition.MultipleDocumentDetails();

        public __DocumentSalesforceListDefinition_MultipleDocumentDetails__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eNone,
        "",
        new System.Type[]{
            typeof(DocumentSalesforceListDefinition.MultipleDocumentDetails)
        },
        new string[]{
            "MessagePart"
        },
        new System.Type[]{
            typeof(__DocumentSalesforceListDefinition_MultipleDocumentDetails__)
        },
        0,
        @"http://SBA.gov/DLAP/DocumentList#DocumentList"
    )]
    [System.SerializableAttribute]
    sealed internal class MultipleDocumentListDetailsResponseType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __DocumentSalesforceListDefinition_MultipleDocumentDetails__ MessagePart;

        private void __CreatePartWrappers()
        {
            MessagePart = new __DocumentSalesforceListDefinition_MultipleDocumentDetails__(this, "MessagePart", 0);
            this.AddPart("MessagePart", 0, MessagePart);
        }

        public MultipleDocumentListDetailsResponseType(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __DocumentListDefinition_DocumentListFault__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static DocumentListDefinition.DocumentListFault _schema = new DocumentListDefinition.DocumentListFault();

        public __DocumentListDefinition_DocumentListFault__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eNone,
        "",
        new System.Type[]{
            typeof(DocumentListDefinition.DocumentListFault)
        },
        new string[]{
            "MessagePart"
        },
        new System.Type[]{
            typeof(__DocumentListDefinition_DocumentListFault__)
        },
        0,
        @"http://SBA.gov/DLAPDocumentList/DocumentListFault#Fault"
    )]
    [System.SerializableAttribute]
    sealed internal class DocumentListFaultResponseType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __DocumentListDefinition_DocumentListFault__ MessagePart;

        private void __CreatePartWrappers()
        {
            MessagePart = new __DocumentListDefinition_DocumentListFault__(this, "MessagePart", 0);
            this.AddPart("MessagePart", 0, MessagePart);
        }

        public DocumentListFaultResponseType(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __DocumentSalesforceListDefinition_SalesforceQuery_Checklist_Item__c_Request__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static DocumentSalesforceListDefinition.SalesforceQuery_Checklist_Item__c.Request _schema = new DocumentSalesforceListDefinition.SalesforceQuery_Checklist_Item__c.Request();

        public __DocumentSalesforceListDefinition_SalesforceQuery_Checklist_Item__c_Request__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eNone,
        "",
        new System.Type[]{
            typeof(DocumentSalesforceListDefinition.SalesforceQuery_Checklist_Item__c.Request)
        },
        new string[]{
            "MessagePart"
        },
        new System.Type[]{
            typeof(__DocumentSalesforceListDefinition_SalesforceQuery_Checklist_Item__c_Request__)
        },
        0,
        @"http://SBA.gov/DLAPDocumentList/Checklist_Item__c#Request"
    )]
    [System.SerializableAttribute]
    sealed internal class SalesforceQueryChecklistItemRequestType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __DocumentSalesforceListDefinition_SalesforceQuery_Checklist_Item__c_Request__ MessagePart;

        private void __CreatePartWrappers()
        {
            MessagePart = new __DocumentSalesforceListDefinition_SalesforceQuery_Checklist_Item__c_Request__(this, "MessagePart", 0);
            this.AddPart("MessagePart", 0, MessagePart);
        }

        public SalesforceQueryChecklistItemRequestType(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __DocumentSalesforceListDefinition_SalesforceQuery_Checklist_Item__c_Response__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static DocumentSalesforceListDefinition.SalesforceQuery_Checklist_Item__c.Response _schema = new DocumentSalesforceListDefinition.SalesforceQuery_Checklist_Item__c.Response();

        public __DocumentSalesforceListDefinition_SalesforceQuery_Checklist_Item__c_Response__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eNone,
        "",
        new System.Type[]{
            typeof(DocumentSalesforceListDefinition.SalesforceQuery_Checklist_Item__c.Response)
        },
        new string[]{
            "MessagePart"
        },
        new System.Type[]{
            typeof(__DocumentSalesforceListDefinition_SalesforceQuery_Checklist_Item__c_Response__)
        },
        0,
        @"http://SBA.gov/DLAPDocumentList/Checklist_Item__c#Response"
    )]
    [System.SerializableAttribute]
    sealed internal class SalesforceQueryChecklistItemResponseType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __DocumentSalesforceListDefinition_SalesforceQuery_Checklist_Item__c_Response__ MessagePart;

        private void __CreatePartWrappers()
        {
            MessagePart = new __DocumentSalesforceListDefinition_SalesforceQuery_Checklist_Item__c_Response__(this, "MessagePart", 0);
            this.AddPart("MessagePart", 0, MessagePart);
        }

        public SalesforceQueryChecklistItemResponseType(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __DLAPDocumentListSalesforceDefinition_ChecklistItemDocumentDetails__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static DLAPDocumentListSalesforceDefinition.ChecklistItemDocumentDetails _schema = new DLAPDocumentListSalesforceDefinition.ChecklistItemDocumentDetails();

        public __DLAPDocumentListSalesforceDefinition_ChecklistItemDocumentDetails__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eNone,
        "",
        new System.Type[]{
            typeof(DLAPDocumentListSalesforceDefinition.ChecklistItemDocumentDetails)
        },
        new string[]{
            "MessagePart"
        },
        new System.Type[]{
            typeof(__DLAPDocumentListSalesforceDefinition_ChecklistItemDocumentDetails__)
        },
        0,
        @"http://SBA.gov/DLAP/DocumentListClosingDocument#ChecklistItemDocumentList"
    )]
    [System.SerializableAttribute]
    sealed internal class MultipleChecklistItemDocumentListsResponseType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __DLAPDocumentListSalesforceDefinition_ChecklistItemDocumentDetails__ MessagePart;

        private void __CreatePartWrappers()
        {
            MessagePart = new __DLAPDocumentListSalesforceDefinition_ChecklistItemDocumentDetails__(this, "MessagePart", 0);
            this.AddPart("MessagePart", 0, MessagePart);
        }

        public MultipleChecklistItemDocumentListsResponseType(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __DLAPDocumentListSalesforceDefinition_Rest_Schemas_Rest_CheckListItem_Document_Details_Request__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static DLAPDocumentListSalesforceDefinition.Rest_Schemas.Rest_CheckListItem_Document_Details.Request _schema = new DLAPDocumentListSalesforceDefinition.Rest_Schemas.Rest_CheckListItem_Document_Details.Request();

        public __DLAPDocumentListSalesforceDefinition_Rest_Schemas_Rest_CheckListItem_Document_Details_Request__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eNone,
        "",
        new System.Type[]{
            typeof(DLAPDocumentListSalesforceDefinition.Rest_Schemas.Rest_CheckListItem_Document_Details.Request)
        },
        new string[]{
            "MessagePart"
        },
        new System.Type[]{
            typeof(__DLAPDocumentListSalesforceDefinition_Rest_Schemas_Rest_CheckListItem_Document_Details_Request__)
        },
        0,
        @"http://SBA.gov/REST/ClosingDocumentsDocumentList#Request"
    )]
    [System.SerializableAttribute]
    sealed internal class RestCheckListItemDocumentDetailsRequestType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __DLAPDocumentListSalesforceDefinition_Rest_Schemas_Rest_CheckListItem_Document_Details_Request__ MessagePart;

        private void __CreatePartWrappers()
        {
            MessagePart = new __DLAPDocumentListSalesforceDefinition_Rest_Schemas_Rest_CheckListItem_Document_Details_Request__(this, "MessagePart", 0);
            this.AddPart("MessagePart", 0, MessagePart);
        }

        public RestCheckListItemDocumentDetailsRequestType(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __DLAPDocumentListSalesforceDefinition_Rest_Schemas_Rest_CheckListItem_Document_Details_QueryResult__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static DLAPDocumentListSalesforceDefinition.Rest_Schemas.Rest_CheckListItem_Document_Details.QueryResult _schema = new DLAPDocumentListSalesforceDefinition.Rest_Schemas.Rest_CheckListItem_Document_Details.QueryResult();

        public __DLAPDocumentListSalesforceDefinition_Rest_Schemas_Rest_CheckListItem_Document_Details_QueryResult__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eNone,
        "",
        new System.Type[]{
            typeof(DLAPDocumentListSalesforceDefinition.Rest_Schemas.Rest_CheckListItem_Document_Details.QueryResult)
        },
        new string[]{
            "MessagePart"
        },
        new System.Type[]{
            typeof(__DLAPDocumentListSalesforceDefinition_Rest_Schemas_Rest_CheckListItem_Document_Details_QueryResult__)
        },
        0,
        @"http://SBA.gov/REST/ClosingDocumentsDocumentList#QueryResult"
    )]
    [System.SerializableAttribute]
    sealed internal class RestCheckListItemDocumentDetailsResponseType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __DLAPDocumentListSalesforceDefinition_Rest_Schemas_Rest_CheckListItem_Document_Details_QueryResult__ MessagePart;

        private void __CreatePartWrappers()
        {
            MessagePart = new __DLAPDocumentListSalesforceDefinition_Rest_Schemas_Rest_CheckListItem_Document_Details_QueryResult__(this, "MessagePart", 0);
            this.AddPart("MessagePart", 0, MessagePart);
        }

        public RestCheckListItemDocumentDetailsResponseType(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __DLAPDocumentListSalesforceDefinition_Rest_Schemas_Rest_Document_Details_Request__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static DLAPDocumentListSalesforceDefinition.Rest_Schemas.Rest_Document_Details.Request _schema = new DLAPDocumentListSalesforceDefinition.Rest_Schemas.Rest_Document_Details.Request();

        public __DLAPDocumentListSalesforceDefinition_Rest_Schemas_Rest_Document_Details_Request__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eNone,
        "",
        new System.Type[]{
            typeof(DLAPDocumentListSalesforceDefinition.Rest_Schemas.Rest_Document_Details.Request)
        },
        new string[]{
            "MessagePart"
        },
        new System.Type[]{
            typeof(__DLAPDocumentListSalesforceDefinition_Rest_Schemas_Rest_Document_Details_Request__)
        },
        0,
        @"http://SBA.gov/REST/AppDocumentList#Request"
    )]
    [System.SerializableAttribute]
    sealed internal class RestDocumentDetailsRequestType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __DLAPDocumentListSalesforceDefinition_Rest_Schemas_Rest_Document_Details_Request__ MessagePart;

        private void __CreatePartWrappers()
        {
            MessagePart = new __DLAPDocumentListSalesforceDefinition_Rest_Schemas_Rest_Document_Details_Request__(this, "MessagePart", 0);
            this.AddPart("MessagePart", 0, MessagePart);
        }

        public RestDocumentDetailsRequestType(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __DLAPDocumentListSalesforceDefinition_Rest_Schemas_Rest_Document_Details_QueryResult__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static DLAPDocumentListSalesforceDefinition.Rest_Schemas.Rest_Document_Details.QueryResult _schema = new DLAPDocumentListSalesforceDefinition.Rest_Schemas.Rest_Document_Details.QueryResult();

        public __DLAPDocumentListSalesforceDefinition_Rest_Schemas_Rest_Document_Details_QueryResult__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eNone,
        "",
        new System.Type[]{
            typeof(DLAPDocumentListSalesforceDefinition.Rest_Schemas.Rest_Document_Details.QueryResult)
        },
        new string[]{
            "MessagePart"
        },
        new System.Type[]{
            typeof(__DLAPDocumentListSalesforceDefinition_Rest_Schemas_Rest_Document_Details_QueryResult__)
        },
        0,
        @"http://SBA.gov/REST/AppDocumentList#QueryResult"
    )]
    [System.SerializableAttribute]
    sealed internal class RestDocumentDetailsResponseType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __DLAPDocumentListSalesforceDefinition_Rest_Schemas_Rest_Document_Details_QueryResult__ MessagePart;

        private void __CreatePartWrappers()
        {
            MessagePart = new __DLAPDocumentListSalesforceDefinition_Rest_Schemas_Rest_Document_Details_QueryResult__(this, "MessagePart", 0);
            this.AddPart("MessagePart", 0, MessagePart);
        }

        public RestDocumentDetailsResponseType(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __DLAPDocumentListSalesforceDefinition_Rest_Schemas_Rest_Multiple_ChecklistItem_Document_Details__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static DLAPDocumentListSalesforceDefinition.Rest_Schemas.Rest_Multiple_ChecklistItem_Document_Details _schema = new DLAPDocumentListSalesforceDefinition.Rest_Schemas.Rest_Multiple_ChecklistItem_Document_Details();

        public __DLAPDocumentListSalesforceDefinition_Rest_Schemas_Rest_Multiple_ChecklistItem_Document_Details__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eNone,
        "",
        new System.Type[]{
            typeof(DLAPDocumentListSalesforceDefinition.Rest_Schemas.Rest_Multiple_ChecklistItem_Document_Details)
        },
        new string[]{
            "MessagePart"
        },
        new System.Type[]{
            typeof(__DLAPDocumentListSalesforceDefinition_Rest_Schemas_Rest_Multiple_ChecklistItem_Document_Details__)
        },
        0,
        @"http://SBA.gov/DLAP/DocumentList#ChecklistItemDocumentList"
    )]
    [System.SerializableAttribute]
    sealed internal class RestMultipleChecklistItemDocumentDetailsResponseType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __DLAPDocumentListSalesforceDefinition_Rest_Schemas_Rest_Multiple_ChecklistItem_Document_Details__ MessagePart;

        private void __CreatePartWrappers()
        {
            MessagePart = new __DLAPDocumentListSalesforceDefinition_Rest_Schemas_Rest_Multiple_ChecklistItem_Document_Details__(this, "MessagePart", 0);
            this.AddPart("MessagePart", 0, MessagePart);
        }

        public RestMultipleChecklistItemDocumentDetailsResponseType(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __DLAPDocumentListSalesforceDefinition_Rest_Schemas_Rest_Multiple_Document_Details__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static DLAPDocumentListSalesforceDefinition.Rest_Schemas.Rest_Multiple_Document_Details _schema = new DLAPDocumentListSalesforceDefinition.Rest_Schemas.Rest_Multiple_Document_Details();

        public __DLAPDocumentListSalesforceDefinition_Rest_Schemas_Rest_Multiple_Document_Details__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eNone,
        "",
        new System.Type[]{
            typeof(DLAPDocumentListSalesforceDefinition.Rest_Schemas.Rest_Multiple_Document_Details)
        },
        new string[]{
            "MessagePart"
        },
        new System.Type[]{
            typeof(__DLAPDocumentListSalesforceDefinition_Rest_Schemas_Rest_Multiple_Document_Details__)
        },
        0,
        @"http://SBA.gov/DLAP/DocumentList#AppDocumentList"
    )]
    [System.SerializableAttribute]
    sealed internal class RestMultipleDocumentDetailsResponseType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __DLAPDocumentListSalesforceDefinition_Rest_Schemas_Rest_Multiple_Document_Details__ MessagePart;

        private void __CreatePartWrappers()
        {
            MessagePart = new __DLAPDocumentListSalesforceDefinition_Rest_Schemas_Rest_Multiple_Document_Details__(this, "MessagePart", 0);
            this.AddPart("MessagePart", 0, MessagePart);
        }

        public RestMultipleDocumentDetailsResponseType(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __DLAPDocumentListSalesforceDefinition_Rest_Schemas_Checklistitem_ClosingDocs_SFID__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static DLAPDocumentListSalesforceDefinition.Rest_Schemas.Checklistitem_ClosingDocs_SFID _schema = new DLAPDocumentListSalesforceDefinition.Rest_Schemas.Checklistitem_ClosingDocs_SFID();

        public __DLAPDocumentListSalesforceDefinition_Rest_Schemas_Checklistitem_ClosingDocs_SFID__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eNone,
        "",
        new System.Type[]{
            typeof(DLAPDocumentListSalesforceDefinition.Rest_Schemas.Checklistitem_ClosingDocs_SFID)
        },
        new string[]{
            "MessagePart"
        },
        new System.Type[]{
            typeof(__DLAPDocumentListSalesforceDefinition_Rest_Schemas_Checklistitem_ClosingDocs_SFID__)
        },
        0,
        @"http://DLAPDocumentListDefinition.ClosingDocsSFID#SFIDValues"
    )]
    [System.SerializableAttribute]
    sealed internal class ChecklistitemClosingDocsSFIDValuesType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __DLAPDocumentListSalesforceDefinition_Rest_Schemas_Checklistitem_ClosingDocs_SFID__ MessagePart;

        private void __CreatePartWrappers()
        {
            MessagePart = new __DLAPDocumentListSalesforceDefinition_Rest_Schemas_Checklistitem_ClosingDocs_SFID__(this, "MessagePart", 0);
            this.AddPart("MessagePart", 0, MessagePart);
        }

        public ChecklistitemClosingDocsSFIDValuesType(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __DLAPDocumentListSalesforceDefinition_Rest_Schemas_RestApplicationInfoRequestResponse_Request__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static DLAPDocumentListSalesforceDefinition.Rest_Schemas.RestApplicationInfoRequestResponse.Request _schema = new DLAPDocumentListSalesforceDefinition.Rest_Schemas.RestApplicationInfoRequestResponse.Request();

        public __DLAPDocumentListSalesforceDefinition_Rest_Schemas_RestApplicationInfoRequestResponse_Request__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eNone,
        "",
        new System.Type[]{
            typeof(DLAPDocumentListSalesforceDefinition.Rest_Schemas.RestApplicationInfoRequestResponse.Request)
        },
        new string[]{
            "MessagePart"
        },
        new System.Type[]{
            typeof(__DLAPDocumentListSalesforceDefinition_Rest_Schemas_RestApplicationInfoRequestResponse_Request__)
        },
        0,
        @"http://SBA.gov/REST/Query/DLAPDocumentList/ApplicationInfo#Request"
    )]
    [System.SerializableAttribute]
    sealed internal class RestApplicationInfoRequestType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __DLAPDocumentListSalesforceDefinition_Rest_Schemas_RestApplicationInfoRequestResponse_Request__ MessagePart;

        private void __CreatePartWrappers()
        {
            MessagePart = new __DLAPDocumentListSalesforceDefinition_Rest_Schemas_RestApplicationInfoRequestResponse_Request__(this, "MessagePart", 0);
            this.AddPart("MessagePart", 0, MessagePart);
        }

        public RestApplicationInfoRequestType(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __DLAPDocumentListSalesforceDefinition_Rest_Schemas_RestApplicationInfoRequestResponse_QueryResult__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static DLAPDocumentListSalesforceDefinition.Rest_Schemas.RestApplicationInfoRequestResponse.QueryResult _schema = new DLAPDocumentListSalesforceDefinition.Rest_Schemas.RestApplicationInfoRequestResponse.QueryResult();

        public __DLAPDocumentListSalesforceDefinition_Rest_Schemas_RestApplicationInfoRequestResponse_QueryResult__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eNone,
        "",
        new System.Type[]{
            typeof(DLAPDocumentListSalesforceDefinition.Rest_Schemas.RestApplicationInfoRequestResponse.QueryResult)
        },
        new string[]{
            "MessagePart"
        },
        new System.Type[]{
            typeof(__DLAPDocumentListSalesforceDefinition_Rest_Schemas_RestApplicationInfoRequestResponse_QueryResult__)
        },
        0,
        @"http://SBA.gov/REST/Query/DLAPDocumentList/ApplicationInfo#QueryResult"
    )]
    [System.SerializableAttribute]
    sealed internal class RestApplicationInfoResponseType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __DLAPDocumentListSalesforceDefinition_Rest_Schemas_RestApplicationInfoRequestResponse_QueryResult__ MessagePart;

        private void __CreatePartWrappers()
        {
            MessagePart = new __DLAPDocumentListSalesforceDefinition_Rest_Schemas_RestApplicationInfoRequestResponse_QueryResult__(this, "MessagePart", 0);
            this.AddPart("MessagePart", 0, MessagePart);
        }

        public RestApplicationInfoResponseType(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation",
        new System.Type[]{
            typeof(DLAPDocument.DocumentListRequestType), 
            typeof(DLAPDocument.DocumentListResponseType), 
            typeof(DLAPDocument.DocumentListFaultResponseType)
        },
        new string[]{
            "Fault"
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class DocumentListPortType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public DocumentListPortType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public DocumentListPortType(DocumentListPortType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            DocumentListPortType p = new DocumentListPortType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation",
            System.Web.Services.Description.OperationFlow.RequestResponse,
            typeof(DocumentListPortType),
            typeof(DocumentListRequestType),
            typeof(DocumentListResponseType),
            new System.Type[]{
                typeof(DocumentListFaultResponseType)
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
            typeof(DLAPDocument.RestApplicationInfoRequestType), 
            typeof(DLAPDocument.RestApplicationInfoResponseType)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class RestQueryApplicationInfoPortType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public RestQueryApplicationInfoPortType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public RestQueryApplicationInfoPortType(RestQueryApplicationInfoPortType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            RestQueryApplicationInfoPortType p = new RestQueryApplicationInfoPortType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation",
            System.Web.Services.Description.OperationFlow.RequestResponse,
            typeof(RestQueryApplicationInfoPortType),
            typeof(RestApplicationInfoRequestType),
            typeof(RestApplicationInfoResponseType),
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
            typeof(DLAPDocument.RestCheckListItemDocumentDetailsRequestType), 
            typeof(DLAPDocument.RestCheckListItemDocumentDetailsResponseType)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class RestQueryClosingDocumentsPortType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public RestQueryClosingDocumentsPortType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public RestQueryClosingDocumentsPortType(RestQueryClosingDocumentsPortType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            RestQueryClosingDocumentsPortType p = new RestQueryClosingDocumentsPortType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation",
            System.Web.Services.Description.OperationFlow.RequestResponse,
            typeof(RestQueryClosingDocumentsPortType),
            typeof(RestCheckListItemDocumentDetailsRequestType),
            typeof(RestCheckListItemDocumentDetailsResponseType),
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
            typeof(DLAPDocument.RestDocumentDetailsRequestType), 
            typeof(DLAPDocument.RestDocumentDetailsResponseType)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class RestQueryApplicantandApplicationDocumentsPortType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public RestQueryApplicantandApplicationDocumentsPortType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public RestQueryApplicantandApplicationDocumentsPortType(RestQueryApplicantandApplicationDocumentsPortType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            RestQueryApplicantandApplicationDocumentsPortType p = new RestQueryApplicantandApplicationDocumentsPortType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation",
            System.Web.Services.Description.OperationFlow.RequestResponse,
            typeof(RestQueryApplicantandApplicationDocumentsPortType),
            typeof(RestDocumentDetailsRequestType),
            typeof(RestDocumentDetailsResponseType),
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
    //#line 1685 "C:\Users\skyeniga\Source\Repos\Biztalk\DLAP Document List\Document List Logic\Document List Logic.odx"
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        0, "DocumentListPort", "Operation", -1, -1, true
    )]
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        },
        new System.Type[] {
            typeof(DLAPDocument.DocumentListPortType),
            typeof(DLAPDocument.RestQueryApplicationInfoPortType),
            typeof(DLAPDocument.RestQueryClosingDocumentsPortType),
            typeof(DLAPDocument.RestQueryApplicantandApplicationDocumentsPortType)
        },
        new System.String[] {
            "DocumentListPort",
            "RestQueryApplicationInfoPort",
            "RestQueryClosingDocumentsPort",
            "RestQueryApplicantandApplicationDocumentsPort"
        },
        new System.Type[] {
            null,
            null,
            null,
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
        Microsoft.XLANGs.BaseTypes.EXLangSServiceInfo.eNone
    )]
    [System.SerializableAttribute]
    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed internal class ListLogic : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
    {
        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        public static readonly bool __execable = false;
        [Microsoft.XLANGs.BaseTypes.CallCompensationAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSCallCompensationInfo.eHasRequestResponse
,
            new System.String[] {
            },
            new System.String[] {
            }
        )]
        public static void __bodyProxy()
        {
        }
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(ListLogic));
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

        static ListLogic()
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
            _rootContext = new __ListLogic_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[3];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public ListLogic(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "ListLogic", tracker)
        {
            ConstructorHelper();
        }

        public ListLogic(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "ListLogic")
        {
            ConstructorHelper();
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>1eb1cf06-6eb7-4809-bdc8-cbc4be0f8ce3</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>2d3f5d4a-ab0e-4320-846b-34340ef83643</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Receive DoucumentList Request</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ScopeShape</shapeType>      <ShapeID>98f222a9-ffe5-4235-9744-a85f9cb79122</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Document List Processing Error Scope</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>TaskShape</shapeType>      <ShapeID>87be290a-8a5b-4b00-9264-43aeef720f9e</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Document List Processing</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>TaskShape</shapeType>      <ShapeID>af0d3d2a-aa76-4113-a81f-2b0266bf45fc</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Application Info Processing</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>8f83ea7f-a80c-46d0-8851-c0c131d73101</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Construct Application Info Request Msg</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>da61cc9d-6d43-4b2e-920c-dcc08d374b64</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Make Rest Application Info Request</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>e43d6ccf-1ce7-40cc-a785-14743ef2d90a</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_19</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>8565f8cf-b314-4e59-80d7-bc6f16132ded</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_20</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>67402021-bc39-40b5-a02c-0b10e3d09519</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Make SOQL</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>a4334be7-2023-43c1-89e6-1d53bdcabca5</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>772a9197-1db1-4c5c-b84e-c8b655ecf94b</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Send Application Info Request</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>3c1a3fcf-01ed-49bf-a234-e95854cb082f</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Receive Application Info Response</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>098be654-5f03-44b9-bbab-06d1a136e7cd</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Construct Salesforce Application Response</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>591b1656-0f56-4a7e-91e8-1076fea283ec</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Make Salesforce Application Response</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>310b2b07-7a64-40ba-801a-ec7ccf42dc45</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>265e547e-44af-4dbc-9a08-b019f38c6de1</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>abaa584c-8f92-4b31-9f10-5a9ad08e989b</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>a1e14e43-2a08-4237-a6ef-257a424f1752</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>ApplicationID Validation Applicant Count and Extracting DLAPUser ID</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionShape</shapeType>      <ShapeID>8d5278d0-4552-488f-9843-66f61001de5a</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Application ID Exists?</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>5487f94a-503c-43a4-ab15-5cd22c762a81</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText> Exists</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>TaskShape</shapeType>      <ShapeID>a0a9f2a9-240a-42e6-ae5f-addf4602184a</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText> CheckList Item Processing</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>8e45db39-6552-4089-aad7-a7586e8fc97d</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Construct CheckList Item Request Msg</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>679a7e87-13b2-4f48-a170-28b8d8de27be</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Make Salesforce CheckList Item Response</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>247a1112-7e66-48ca-bdf6-336473f3584b</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_10</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>9fb27468-a6a4-45af-b1e9-b557215fd2eb</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_11</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>a1b9c1ba-984f-41de-b9b5-1862b0f066da</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>db93f657-6ff5-45ed-86db-1be111c8ca4e</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>CheckList Item Count</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>81e05aee-f6ad-44e6-bb67-1db0809553ef</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Construct Concatenated CheckList Item SFID Values Message</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>2ab83668-0f7e-4c96-af3c-06c1438ef4d8</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>ba3364a6-5f1a-40fb-bd68-7a322dd435b5</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Make SFID String Values</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>ee073a25-f3be-4bc8-b385-4dd6a7e43093</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_18</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>5882737d-84f1-49f1-9b6c-e3955cb28e4b</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_15</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>25c6beb5-4278-4f62-adee-cd6d0302170a</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Extract Concatenate SFID</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionShape</shapeType>      <ShapeID>b2276229-b41c-4d3d-9e54-954c3a92895d</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>ChecklistItem Contain Closing Document SFID?</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>9c200a1e-597b-49da-b159-1fdd865b52fb</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>Closing Document</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>c7f17b3c-dac7-4bf1-9217-61e52b7340f2</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Construct Rest CheckListItem Document Request Msg</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>78fa5794-c442-455e-a917-daf0ee3a5893</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>MakeSalesforceContentVersionRequest</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>47e6aaf6-27a1-453d-9aab-5f2dc4048e98</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_22</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>2c0482ec-a4c2-4e95-be03-593c6f61bf5a</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_21</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>7a7ce393-c3cb-441b-a994-6863a3d32795</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Make SOQL</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>ec7f7b52-05cb-43a9-9296-dd773e6501ad</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>6a91403d-7712-46ec-b96c-1112d8ac960c</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Send Rest CheckListItem Document Request</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>83f4e829-b53e-4497-a3ce-f27c36fa752a</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Receive Rest CheckListItem Document Response</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>4919eaec-68f9-429d-97ce-35b3a64194c1</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Aggregate Multipe Applicants Documents Info</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>41800f59-fe27-431c-9793-edd33d42a75d</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>Else</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>120bc076-e250-42c0-a144-1c094cebd535</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Construct Rest Closing Document Response Msg</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>0574e75c-eae3-4f75-b767-571c79728dd0</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>997c6dae-4c16-4fde-9847-048354a99725</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Make Rest Multiple Checklistitem Document Response Msg</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>TaskShape</shapeType>      <ShapeID>b3038bdf-7c8b-467c-a2a0-522a3cd11bf9</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Applicant Document Processing</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>WhileShape</shapeType>      <ShapeID>38b29dd6-3a59-4b49-b8f5-68c75cb8e7dc</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Loop Through Applicants</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>78bfbdc5-081c-48e4-8000-097e3b0c23e5</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Construct Rest Applicant Document Request Msg</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>38064b0b-4b13-4ddc-8df3-c8432ae695ed</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Make Rest Applicant Document Request</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>9ab28779-acaf-4958-ad90-8acc9e03052d</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_14</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>4067f490-c73a-4eb4-9181-b75c1246c6e1</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_13</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>c92cc31a-432b-47e2-9b90-11ee09a0250f</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Make SOQL</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>0cfc550d-bf8b-47bb-9504-4785139fe6d9</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>263f2660-59d3-499d-b506-5774a8e6c571</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Send Rest Document Request</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>e520e8ce-21d3-487e-9aff-526f9830f806</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Receive Rest Document Response</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>71014f46-c75b-4732-a469-8bd9c4e6e40f</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Aggregate Multipe Applicants Documents Info</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>36b07477-0e85-4a5f-8102-aaabfa5d760c</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Construct Appplicant Document Response Msg</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>67ae039a-0125-429b-a3e9-ca35a1fc3a35</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>c8df7609-b3d0-46d7-b804-eac30b771d42</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Make Multiple Document Response Msg</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>TaskShape</shapeType>      <ShapeID>1b8bf771-9a2d-4367-9744-c534f597b445</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Application Document Processing</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>13501ce2-919d-4582-9271-708703cfc462</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Construct Rest Application Document Request Msg</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>216a32df-2a9b-4f56-b327-e8582a4b4ef4</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>ccd1f3b2-d8ee-4b15-b222-74c4fc10a830</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Make Rest Application Document Request</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>6f1fa583-7582-4798-ae31-6cffefb88366</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_17</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>d5821b38-f848-4f65-a89e-188b6380f7a7</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_16</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>c369d0dd-2123-4e7e-94e4-c6671efdbf36</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Make SOQL</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>9a47ce8e-47d3-4e22-b7db-be88d8195348</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Send Rest Document Request</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>f9b6f9b7-5a99-4b7c-ba86-e3a55d2d919f</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Receive Rest Document Response</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>6d2712b5-2af5-4536-a313-80e81760193c</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Construct Document List Response Msg</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>90fed697-cd32-4991-b327-649282695f09</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Make DocumentList Response</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>fadeb5d6-01a7-450b-9e76-cb49c593d950</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_6</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>9f0e2a05-7cba-4728-bcf0-1484b864155b</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_3</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>d6549a08-201f-40c3-bd4e-a3741752250f</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_4</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>3e6586ae-b8fd-43e5-90ef-ffd840507a10</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_5</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>337215ea-7f23-486d-b641-f4568e1f56e9</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_7</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>f654b77f-4eee-40c3-91a3-39f7fd7f7457</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_12</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>8d574427-d2f2-47f4-921d-28079463e4e8</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>72703219-3e4f-4471-92f2-356234cebfa8</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>Else</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>98d57495-1f9b-4eff-8b86-ae20189197f1</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Construct Document List Error Response Msg</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>ff141df0-b21b-453e-b568-329dd1caafd9</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Make DocumentList Error Response Msg</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>18effa2c-0597-47d1-a0aa-cafebe95b283</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_8</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>bae9f0f0-0c54-4a31-8080-a5e19e6051e3</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_9</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>f4807b82-02f3-400a-a308-b711b68008a8</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>CatchShape</shapeType>      <ShapeID>87cf9771-2732-4e9a-bf17-e3357f1a9c40</ShapeID>      <ParentLink>Scope_Catch</ParentLink>                <shapeText>System Exception</shapeText>                      <ExceptionType>System.Exception</ExceptionType>            
<children>                          
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>8b269fa2-3dce-4dec-a260-3f651fc15139</ShapeID>      <ParentLink>Catch_Statement</ParentLink>                <shapeText>Construct Document List Fault Response Msg</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>a84275e1-99ef-4c73-afa8-838fc1ee05d9</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Document List Fault Response</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>5ae70ef2-72e8-40eb-bf09-fab5359a6098</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>e3b346c1-6a2c-4c96-8b56-581aba0241fb</ShapeID>      <ParentLink>Catch_Statement</ParentLink>                <shapeText>Send Fault Response</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>TerminateShape</shapeType>      <ShapeID>e78564f7-8ab3-49af-bbd0-54f4dad13a0b</ShapeID>      <ParentLink>Catch_Statement</ParentLink>                <shapeText>Terminate</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>8bae0a73-0994-4ce1-ab42-b6ff905c5507</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Send DocumentList Response</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow><Metadata>

<TrkMetadata>
<ActionName>'ListLogic'</ActionName><IsAtomic>0</IsAtomic><Line>1685</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
</TrkMetadata>

<TrkMetadata>
<Line>1766</Line><Position>22</Position><ShapeID>'2d3f5d4a-ab0e-4320-846b-34340ef83643'</ShapeID>
<Messages>
	<MsgInfo><name>DocumentListRequestMsg</name><part>MessagePart</part><schema>DocumentListDefinition.DocumentListRequest</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<ActionName>'??__scope35'</ActionName><IsAtomic>0</IsAtomic><Line>1812</Line><Position>13</Position><ShapeID>'98f222a9-ffe5-4235-9744-a85f9cb79122'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1817</Line><Position>21</Position><ShapeID>'8f83ea7f-a80c-46d0-8851-c0c131d73101'</ShapeID>
<Messages>
	<MsgInfo><name>RestApplicationInfoRequestMsg</name><part>MessagePart</part><schema>DLAPDocumentListSalesforceDefinition.Rest_Schemas.RestApplicationInfoRequestResponse+Request</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>DocumentListRequestMsg</name><part>MessagePart</part><schema>DocumentListDefinition.DocumentListRequest</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1839</Line><Position>21</Position><ShapeID>'772a9197-1db1-4c5c-b84e-c8b655ecf94b'</ShapeID>
<Messages>
	<MsgInfo><name>RestApplicationInfoRequestMsg</name><part>MessagePart</part><schema>DLAPDocumentListSalesforceDefinition.Rest_Schemas.RestApplicationInfoRequestResponse+Request</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1841</Line><Position>21</Position><ShapeID>'3c1a3fcf-01ed-49bf-a234-e95854cb082f'</ShapeID>
<Messages>
	<MsgInfo><name>RestApplicationInfoResponseMsg</name><part>MessagePart</part><schema>DLAPDocumentListSalesforceDefinition.Rest_Schemas.RestApplicationInfoRequestResponse+QueryResult</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1843</Line><Position>21</Position><ShapeID>'098be654-5f03-44b9-bbab-06d1a136e7cd'</ShapeID>
<Messages>
	<MsgInfo><name>SalesforceQueryApplicationInfoResponseMsg</name><part>MessagePart</part><schema>DocumentSalesforceListDefinition.SalesforceQuery_Application_Info__c+Response</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>RestApplicationInfoResponseMsg</name><part>MessagePart</part><schema>DLAPDocumentListSalesforceDefinition.Rest_Schemas.RestApplicationInfoRequestResponse+QueryResult</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1850</Line><Position>36</Position><ShapeID>'a1e14e43-2a08-4237-a6ef-257a424f1752'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1863</Line><Position>21</Position><ShapeID>'8d5278d0-4552-488f-9843-66f61001de5a'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1866</Line><Position>25</Position><ShapeID>'8e45db39-6552-4089-aad7-a7586e8fc97d'</ShapeID>
<Messages>
	<MsgInfo><name>SalesforceQueryChecklistItemResponseMsg</name><part>MessagePart</part><schema>DocumentSalesforceListDefinition.SalesforceQuery_Checklist_Item__c+Response</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>RestApplicationInfoResponseMsg</name><part>MessagePart</part><schema>DLAPDocumentListSalesforceDefinition.Rest_Schemas.RestApplicationInfoRequestResponse+QueryResult</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1872</Line><Position>44</Position><ShapeID>'db93f657-6ff5-45ed-86db-1be111c8ca4e'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1874</Line><Position>25</Position><ShapeID>'81e05aee-f6ad-44e6-bb67-1db0809553ef'</ShapeID>
<Messages>
	<MsgInfo><name>ChecklistitemClosingDocsSFIDValuesMsg</name><part>MessagePart</part><schema>DLAPDocumentListSalesforceDefinition.Rest_Schemas.Checklistitem_ClosingDocs_SFID</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>SalesforceQueryChecklistItemResponseMsg</name><part>MessagePart</part><schema>DocumentSalesforceListDefinition.SalesforceQuery_Checklist_Item__c+Response</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1880</Line><Position>44</Position><ShapeID>'25c6beb5-4278-4f62-adee-cd6d0302170a'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1882</Line><Position>25</Position><ShapeID>'b2276229-b41c-4d3d-9e54-954c3a92895d'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1885</Line><Position>29</Position><ShapeID>'c7f17b3c-dac7-4bf1-9217-61e52b7340f2'</ShapeID>
<Messages>
	<MsgInfo><name>RestCheckListItemDocumentDetailsRequestMsg</name><part>MessagePart</part><schema>DLAPDocumentListSalesforceDefinition.Rest_Schemas.Rest_CheckListItem_Document_Details+Request</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>SalesforceQueryApplicationInfoResponseMsg</name><part>MessagePart</part><schema>DocumentSalesforceListDefinition.SalesforceQuery_Application_Info__c+Response</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1899</Line><Position>29</Position><ShapeID>'6a91403d-7712-46ec-b96c-1112d8ac960c'</ShapeID>
<Messages>
	<MsgInfo><name>RestCheckListItemDocumentDetailsRequestMsg</name><part>MessagePart</part><schema>DLAPDocumentListSalesforceDefinition.Rest_Schemas.Rest_CheckListItem_Document_Details+Request</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1901</Line><Position>29</Position><ShapeID>'83f4e829-b53e-4497-a3ce-f27c36fa752a'</ShapeID>
<Messages>
	<MsgInfo><name>RestCheckListItemDocumentDetailsResponseMsg</name><part>MessagePart</part><schema>DLAPDocumentListSalesforceDefinition.Rest_Schemas.Rest_CheckListItem_Document_Details+QueryResult</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1909</Line><Position>50</Position><ShapeID>'4919eaec-68f9-429d-97ce-35b3a64194c1'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1918</Line><Position>25</Position><ShapeID>'120bc076-e250-42c0-a144-1c094cebd535'</ShapeID>
<Messages>
	<MsgInfo><name>RestMultipleChecklistItemDocumentDetailsResponseMsg</name><part>MessagePart</part><schema>DLAPDocumentListSalesforceDefinition.Rest_Schemas.Rest_Multiple_ChecklistItem_Document_Details</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1932</Line><Position>25</Position><ShapeID>'38b29dd6-3a59-4b49-b8f5-68c75cb8e7dc'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1936</Line><Position>29</Position><ShapeID>'78bfbdc5-081c-48e4-8000-097e3b0c23e5'</ShapeID>
<Messages>
	<MsgInfo><name>RestDocumentDetailsRequestMsg</name><part>MessagePart</part><schema>DLAPDocumentListSalesforceDefinition.Rest_Schemas.Rest_Document_Details+Request</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>SalesforceQueryApplicationInfoResponseMsg</name><part>MessagePart</part><schema>DocumentSalesforceListDefinition.SalesforceQuery_Application_Info__c+Response</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1957</Line><Position>29</Position><ShapeID>'263f2660-59d3-499d-b506-5774a8e6c571'</ShapeID>
<Messages>
	<MsgInfo><name>RestDocumentDetailsRequestMsg</name><part>MessagePart</part><schema>DLAPDocumentListSalesforceDefinition.Rest_Schemas.Rest_Document_Details+Request</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1959</Line><Position>29</Position><ShapeID>'e520e8ce-21d3-487e-9aff-526f9830f806'</ShapeID>
<Messages>
	<MsgInfo><name>RestDocumentDetailsResponseMsg</name><part>MessagePart</part><schema>DLAPDocumentListSalesforceDefinition.Rest_Schemas.Rest_Document_Details+QueryResult</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1963</Line><Position>39</Position><ShapeID>'71014f46-c75b-4732-a469-8bd9c4e6e40f'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1983</Line><Position>25</Position><ShapeID>'36b07477-0e85-4a5f-8102-aaabfa5d760c'</ShapeID>
<Messages>
	<MsgInfo><name>RestMultipleDocumentDetailsResponseMsg</name><part>MessagePart</part><schema>DLAPDocumentListSalesforceDefinition.Rest_Schemas.Rest_Multiple_Document_Details</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1999</Line><Position>25</Position><ShapeID>'13501ce2-919d-4582-9271-708703cfc462'</ShapeID>
<Messages>
	<MsgInfo><name>RestDocumentDetailsRequestMsg</name><part>MessagePart</part><schema>DLAPDocumentListSalesforceDefinition.Rest_Schemas.Rest_Document_Details+Request</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>SalesforceQueryApplicationInfoResponseMsg</name><part>MessagePart</part><schema>DocumentSalesforceListDefinition.SalesforceQuery_Application_Info__c+Response</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>2012</Line><Position>25</Position><ShapeID>'9a47ce8e-47d3-4e22-b7db-be88d8195348'</ShapeID>
<Messages>
	<MsgInfo><name>RestDocumentDetailsRequestMsg</name><part>MessagePart</part><schema>DLAPDocumentListSalesforceDefinition.Rest_Schemas.Rest_Document_Details+Request</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>2014</Line><Position>25</Position><ShapeID>'f9b6f9b7-5a99-4b7c-ba86-e3a55d2d919f'</ShapeID>
<Messages>
	<MsgInfo><name>RestDocumentDetailsResponseMsg</name><part>MessagePart</part><schema>DLAPDocumentListSalesforceDefinition.Rest_Schemas.Rest_Document_Details+QueryResult</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>2016</Line><Position>25</Position><ShapeID>'6d2712b5-2af5-4536-a313-80e81760193c'</ShapeID>
<Messages>
	<MsgInfo><name>DocumentListResponseMsg</name><part>MessagePart</part><schema>DocumentListDefinition.DocumentListResponse</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>RestMultipleDocumentDetailsResponseMsg</name><part>MessagePart</part><schema>DLAPDocumentListSalesforceDefinition.Rest_Schemas.Rest_Multiple_Document_Details</schema><direction>In</direction></MsgInfo>
	<MsgInfo><name>RestDocumentDetailsResponseMsg</name><part>MessagePart</part><schema>DLAPDocumentListSalesforceDefinition.Rest_Schemas.Rest_Document_Details+QueryResult</schema><direction>In</direction></MsgInfo>
	<MsgInfo><name>SalesforceQueryApplicationInfoResponseMsg</name><part>MessagePart</part><schema>DocumentSalesforceListDefinition.SalesforceQuery_Application_Info__c+Response</schema><direction>In</direction></MsgInfo>
	<MsgInfo><name>SalesforceQueryChecklistItemResponseMsg</name><part>MessagePart</part><schema>DocumentSalesforceListDefinition.SalesforceQuery_Checklist_Item__c+Response</schema><direction>In</direction></MsgInfo>
	<MsgInfo><name>RestMultipleChecklistItemDocumentDetailsResponseMsg</name><part>MessagePart</part><schema>DLAPDocumentListSalesforceDefinition.Rest_Schemas.Rest_Multiple_ChecklistItem_Document_Details</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>2025</Line><Position>25</Position><ShapeID>'98d57495-1f9b-4eff-8b86-ae20189197f1'</ShapeID>
<Messages>
	<MsgInfo><name>DocumentListResponseMsg</name><part>MessagePart</part><schema>DocumentListDefinition.DocumentListResponse</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>DocumentListRequestMsg</name><part>MessagePart</part><schema>DocumentListDefinition.DocumentListRequest</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>2035</Line><Position>21</Position><ShapeID>'87cf9771-2732-4e9a-bf17-e3357f1a9c40'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>2038</Line><Position>25</Position><ShapeID>'8b269fa2-3dce-4dec-a260-3f651fc15139'</ShapeID>
<Messages>
	<MsgInfo><name>DocumentListFaultResponseMsg</name><part>MessagePart</part><schema>DocumentListDefinition.DocumentListFault</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>2050</Line><Position>25</Position><ShapeID>'e3b346c1-6a2c-4c96-8b56-581aba0241fb'</ShapeID>
<Messages>
	<MsgInfo><name>DocumentListFaultResponseMsg</name><part>MessagePart</part><schema>DocumentListDefinition.DocumentListFault</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>2052</Line><Position>25</Position><ShapeID>'e78564f7-8ab3-49af-bbd0-54f4dad13a0b'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>2057</Line><Position>13</Position><ShapeID>'8bae0a73-0994-4ce1-ab42-b6ff905c5507'</ShapeID>
<Messages>
	<MsgInfo><name>DocumentListResponseMsg</name><part>MessagePart</part><schema>DocumentListDefinition.DocumentListResponse</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='515b0b22-9de2-44b3-a2fc-8552b3b736eb' LowerBound='1.1' HigherBound='489.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='DLAPDocument' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='PortType' OID='c7fc5deb-fbde-401d-a860-395746a572c9' ParentLink='Module_PortType' LowerBound='84.1' HigherBound='91.1'>
            <om:Property Name='Synchronous' Value='True' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='DocumentListPortType' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='OperationDeclaration' OID='1286a419-ac38-45eb-9aaa-eeada6e06ddd' ParentLink='PortType_OperationDeclaration' LowerBound='86.1' HigherBound='90.1'>
                <om:Property Name='OperationType' Value='RequestResponse' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='a4eeec13-c015-417e-94ac-caeb5b179da5' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='88.13' HigherBound='88.36'>
                    <om:Property Name='Ref' Value='DLAPDocument.DocumentListRequestType' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
                <om:Element Type='MessageRef' OID='0a943559-782d-4200-be0d-5ea3877cd435' ParentLink='OperationDeclaration_ResponseMessageRef' LowerBound='88.38' HigherBound='88.62'>
                    <om:Property Name='Ref' Value='DLAPDocument.DocumentListResponseType' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Response' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='MessageRef' OID='e8a68c2d-6495-490b-b5c3-e857cf65e230' ParentLink='OperationDeclaration_FaultMessageRef' LowerBound='88.64' HigherBound='88.101'>
                    <om:Property Name='Ref' Value='DLAPDocument.DocumentListFaultResponseType' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Fault' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='82ef03ad-667b-4ca2-9f56-3f6ab879322f' ParentLink='Module_PortType' LowerBound='91.1' HigherBound='98.1'>
            <om:Property Name='Synchronous' Value='True' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='RestQueryApplicationInfoPortType' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='OperationDeclaration' OID='aaafd7a7-8ea6-49a5-9bf7-89fec14d3b05' ParentLink='PortType_OperationDeclaration' LowerBound='93.1' HigherBound='97.1'>
                <om:Property Name='OperationType' Value='RequestResponse' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='d21dcb63-a75c-4750-9fa1-0ca5235995fb' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='95.13' HigherBound='95.43'>
                    <om:Property Name='Ref' Value='DLAPDocument.RestApplicationInfoRequestType' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='MessageRef' OID='d2665c65-5788-4f78-aebb-55c5a7c7b19b' ParentLink='OperationDeclaration_ResponseMessageRef' LowerBound='95.45' HigherBound='95.76'>
                    <om:Property Name='Ref' Value='DLAPDocument.RestApplicationInfoResponseType' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Response' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='a181ec72-9ab3-474c-872f-0a47b5c65df4' ParentLink='Module_PortType' LowerBound='98.1' HigherBound='105.1'>
            <om:Property Name='Synchronous' Value='True' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='RestQueryClosingDocumentsPortType' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='OperationDeclaration' OID='92055816-30cf-4b85-adea-c1e2524ecbbb' ParentLink='PortType_OperationDeclaration' LowerBound='100.1' HigherBound='104.1'>
                <om:Property Name='OperationType' Value='RequestResponse' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='98400856-f820-49fa-93bd-e1c94b9f77db' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='102.13' HigherBound='102.56'>
                    <om:Property Name='Ref' Value='DLAPDocument.RestCheckListItemDocumentDetailsRequestType' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
                <om:Element Type='MessageRef' OID='19f0a162-5455-4227-917e-c4b799426482' ParentLink='OperationDeclaration_ResponseMessageRef' LowerBound='102.58' HigherBound='102.102'>
                    <om:Property Name='Ref' Value='DLAPDocument.RestCheckListItemDocumentDetailsResponseType' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Response' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='6fb778d4-13c6-40c6-aa2e-f977d892cb6a' ParentLink='Module_PortType' LowerBound='105.1' HigherBound='112.1'>
            <om:Property Name='Synchronous' Value='True' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='RestQueryApplicantandApplicationDocumentsPortType' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='OperationDeclaration' OID='838db2fa-b152-4204-a566-222043863951' ParentLink='PortType_OperationDeclaration' LowerBound='107.1' HigherBound='111.1'>
                <om:Property Name='OperationType' Value='RequestResponse' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='ea79df15-0d4a-4cf2-a3b1-ca558e4d0f01' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='109.13' HigherBound='109.43'>
                    <om:Property Name='Ref' Value='DLAPDocument.RestDocumentDetailsRequestType' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
                <om:Element Type='MessageRef' OID='5dba065a-f3fc-48c8-a7ea-e1c2aaf843f2' ParentLink='OperationDeclaration_ResponseMessageRef' LowerBound='109.45' HigherBound='109.76'>
                    <om:Property Name='Ref' Value='DLAPDocument.RestDocumentDetailsResponseType' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Response' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='MultipartMessageType' OID='a0338a11-7de8-402a-9275-3879259e10be' ParentLink='Module_MessageType' LowerBound='4.1' HigherBound='8.1'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='DocumentListRequestType' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='PartDeclaration' OID='b81ee884-817c-422e-ab2e-4ff23b4c715b' ParentLink='MultipartMessageType_PartDeclaration' LowerBound='6.1' HigherBound='7.1'>
                <om:Property Name='ClassName' Value='DocumentListDefinition.DocumentListRequest' />
                <om:Property Name='IsBodyPart' Value='True' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='MessagePart' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
        </om:Element>
        <om:Element Type='MultipartMessageType' OID='8a349fe5-625a-4de5-91eb-ff2ffa4dcbeb' ParentLink='Module_MessageType' LowerBound='8.1' HigherBound='12.1'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='DocumentListResponseType' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='PartDeclaration' OID='311ff200-fbce-48c6-aff7-0f92679b2f75' ParentLink='MultipartMessageType_PartDeclaration' LowerBound='10.1' HigherBound='11.1'>
                <om:Property Name='ClassName' Value='DocumentListDefinition.DocumentListResponse' />
                <om:Property Name='IsBodyPart' Value='True' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='MessagePart' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
        </om:Element>
        <om:Element Type='MultipartMessageType' OID='48d70919-4b30-41bd-94ee-4420384b74bf' ParentLink='Module_MessageType' LowerBound='12.1' HigherBound='16.1'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='SalesforceQueryApplicationInfoRequestType' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='PartDeclaration' OID='2c1d96e7-0fc9-46cd-86cd-61853c2ce142' ParentLink='MultipartMessageType_PartDeclaration' LowerBound='14.1' HigherBound='15.1'>
                <om:Property Name='ClassName' Value='DocumentSalesforceListDefinition.SalesforceQuery_Application_Info__c.Request' />
                <om:Property Name='IsBodyPart' Value='True' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='MessagePart' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
        </om:Element>
        <om:Element Type='MultipartMessageType' OID='4b09a16b-0824-4e26-8992-2c50fca304b4' ParentLink='Module_MessageType' LowerBound='16.1' HigherBound='20.1'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='SalesforceQueryApplicationInfoResponseType' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='PartDeclaration' OID='ffa201ae-7c11-4e37-a22a-58dd062bf2f6' ParentLink='MultipartMessageType_PartDeclaration' LowerBound='18.1' HigherBound='19.1'>
                <om:Property Name='ClassName' Value='DocumentSalesforceListDefinition.SalesforceQuery_Application_Info__c.Response' />
                <om:Property Name='IsBodyPart' Value='True' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='MessagePart' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
        </om:Element>
        <om:Element Type='MultipartMessageType' OID='2688541f-1796-4e35-a8c7-762121798518' ParentLink='Module_MessageType' LowerBound='20.1' HigherBound='24.1'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='SalesforceQueryContentVersionRequestType' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='PartDeclaration' OID='fe772467-df2c-448b-9e8a-43a534adf7f3' ParentLink='MultipartMessageType_PartDeclaration' LowerBound='22.1' HigherBound='23.1'>
                <om:Property Name='ClassName' Value='DocumentSalesforceListDefinition.SalesforceQuery_ContentVersion__c.Request' />
                <om:Property Name='IsBodyPart' Value='True' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='MessagePart' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
        </om:Element>
        <om:Element Type='MultipartMessageType' OID='6cdc7594-77eb-466d-8fe5-af8716de2dd7' ParentLink='Module_MessageType' LowerBound='24.1' HigherBound='28.1'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='SalesforceQueryContentVersionResponseType' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='PartDeclaration' OID='7bd0677e-97df-44bc-ae67-c3f4ffadbc8b' ParentLink='MultipartMessageType_PartDeclaration' LowerBound='26.1' HigherBound='27.1'>
                <om:Property Name='ClassName' Value='DocumentSalesforceListDefinition.SalesforceQuery_ContentVersion__c.Response' />
                <om:Property Name='IsBodyPart' Value='True' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='MessagePart' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
        </om:Element>
        <om:Element Type='MultipartMessageType' OID='012d05d5-3edf-4b9d-8a1f-bade9711c78b' ParentLink='Module_MessageType' LowerBound='28.1' HigherBound='32.1'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='MultipleDocumentListDetailsResponseType' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='PartDeclaration' OID='6bc30b73-fbda-458a-ae60-dfbc6e5c7f16' ParentLink='MultipartMessageType_PartDeclaration' LowerBound='30.1' HigherBound='31.1'>
                <om:Property Name='ClassName' Value='DocumentSalesforceListDefinition.MultipleDocumentDetails' />
                <om:Property Name='IsBodyPart' Value='True' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='MessagePart' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
        </om:Element>
        <om:Element Type='MultipartMessageType' OID='1c66373b-9cd1-4017-95f8-72c539141aa3' ParentLink='Module_MessageType' LowerBound='32.1' HigherBound='36.1'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='DocumentListFaultResponseType' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='PartDeclaration' OID='e8dbbd65-ce53-4bd5-b1a9-aa98dd290668' ParentLink='MultipartMessageType_PartDeclaration' LowerBound='34.1' HigherBound='35.1'>
                <om:Property Name='ClassName' Value='DocumentListDefinition.DocumentListFault' />
                <om:Property Name='IsBodyPart' Value='True' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='MessagePart' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
        </om:Element>
        <om:Element Type='MultipartMessageType' OID='ee0d28f9-b298-46df-a727-b99a541e9390' ParentLink='Module_MessageType' LowerBound='36.1' HigherBound='40.1'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='SalesforceQueryChecklistItemRequestType' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='PartDeclaration' OID='84b5fa4c-d975-4ef0-912a-0b37f8993b2d' ParentLink='MultipartMessageType_PartDeclaration' LowerBound='38.1' HigherBound='39.1'>
                <om:Property Name='ClassName' Value='DocumentSalesforceListDefinition.SalesforceQuery_Checklist_Item__c.Request' />
                <om:Property Name='IsBodyPart' Value='True' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='MessagePart' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
        </om:Element>
        <om:Element Type='MultipartMessageType' OID='7ec7312e-e01a-42b8-9791-896f105a8700' ParentLink='Module_MessageType' LowerBound='40.1' HigherBound='44.1'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='SalesforceQueryChecklistItemResponseType' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='PartDeclaration' OID='4e87336a-a71b-4ee0-868d-a98bff22fa05' ParentLink='MultipartMessageType_PartDeclaration' LowerBound='42.1' HigherBound='43.1'>
                <om:Property Name='ClassName' Value='DocumentSalesforceListDefinition.SalesforceQuery_Checklist_Item__c.Response' />
                <om:Property Name='IsBodyPart' Value='True' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='MessagePart' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
        </om:Element>
        <om:Element Type='MultipartMessageType' OID='d585adc4-fd16-4076-a386-b9c741935ee3' ParentLink='Module_MessageType' LowerBound='44.1' HigherBound='48.1'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='MultipleChecklistItemDocumentListsResponseType' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='PartDeclaration' OID='190b4432-55be-48fe-a1fe-167ba4d5c2cf' ParentLink='MultipartMessageType_PartDeclaration' LowerBound='46.1' HigherBound='47.1'>
                <om:Property Name='ClassName' Value='DLAPDocumentListSalesforceDefinition.ChecklistItemDocumentDetails' />
                <om:Property Name='IsBodyPart' Value='True' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='MessagePart' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
        </om:Element>
        <om:Element Type='MultipartMessageType' OID='028b3e69-fa58-4c2c-bd26-946142cfd5f3' ParentLink='Module_MessageType' LowerBound='48.1' HigherBound='52.1'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='RestCheckListItemDocumentDetailsRequestType' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='PartDeclaration' OID='a21278a2-816e-4a1e-8353-1f5336a4cb3c' ParentLink='MultipartMessageType_PartDeclaration' LowerBound='50.1' HigherBound='51.1'>
                <om:Property Name='ClassName' Value='DLAPDocumentListSalesforceDefinition.Rest_Schemas.Rest_CheckListItem_Document_Details.Request' />
                <om:Property Name='IsBodyPart' Value='True' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='MessagePart' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
        </om:Element>
        <om:Element Type='MultipartMessageType' OID='413383ff-60af-4386-971e-e5ee3e3dd16c' ParentLink='Module_MessageType' LowerBound='52.1' HigherBound='56.1'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='RestCheckListItemDocumentDetailsResponseType' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='PartDeclaration' OID='8288eb71-0a62-43ff-a0b8-b4af90f88aab' ParentLink='MultipartMessageType_PartDeclaration' LowerBound='54.1' HigherBound='55.1'>
                <om:Property Name='ClassName' Value='DLAPDocumentListSalesforceDefinition.Rest_Schemas.Rest_CheckListItem_Document_Details.QueryResult' />
                <om:Property Name='IsBodyPart' Value='True' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='MessagePart' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
        </om:Element>
        <om:Element Type='MultipartMessageType' OID='6404a266-5a4f-45ec-9a74-0b10b5b4ac47' ParentLink='Module_MessageType' LowerBound='56.1' HigherBound='60.1'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='RestDocumentDetailsRequestType' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='PartDeclaration' OID='7ac1cb85-f45e-40e1-b617-47dd49bd9b57' ParentLink='MultipartMessageType_PartDeclaration' LowerBound='58.1' HigherBound='59.1'>
                <om:Property Name='ClassName' Value='DLAPDocumentListSalesforceDefinition.Rest_Schemas.Rest_Document_Details.Request' />
                <om:Property Name='IsBodyPart' Value='True' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='MessagePart' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
        </om:Element>
        <om:Element Type='MultipartMessageType' OID='ff0d47bb-8087-48d9-954a-12d647041348' ParentLink='Module_MessageType' LowerBound='60.1' HigherBound='64.1'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='RestDocumentDetailsResponseType' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='PartDeclaration' OID='a9aa5b49-f6dc-46fe-878f-8d4b815be983' ParentLink='MultipartMessageType_PartDeclaration' LowerBound='62.1' HigherBound='63.1'>
                <om:Property Name='ClassName' Value='DLAPDocumentListSalesforceDefinition.Rest_Schemas.Rest_Document_Details.QueryResult' />
                <om:Property Name='IsBodyPart' Value='True' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='MessagePart' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
        </om:Element>
        <om:Element Type='MultipartMessageType' OID='64087bce-22f7-45a3-804e-975da976169a' ParentLink='Module_MessageType' LowerBound='64.1' HigherBound='68.1'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='RestMultipleChecklistItemDocumentDetailsResponseType' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='PartDeclaration' OID='d0ff47bf-56fe-40a5-b72f-28e767e68843' ParentLink='MultipartMessageType_PartDeclaration' LowerBound='66.1' HigherBound='67.1'>
                <om:Property Name='ClassName' Value='DLAPDocumentListSalesforceDefinition.Rest_Schemas.Rest_Multiple_ChecklistItem_Document_Details' />
                <om:Property Name='IsBodyPart' Value='True' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='MessagePart' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
        </om:Element>
        <om:Element Type='MultipartMessageType' OID='dc190808-a194-4f4f-b4e3-730943e644ad' ParentLink='Module_MessageType' LowerBound='68.1' HigherBound='72.1'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='RestMultipleDocumentDetailsResponseType' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='PartDeclaration' OID='7eb4562d-b879-4250-9986-4f24da9156e9' ParentLink='MultipartMessageType_PartDeclaration' LowerBound='70.1' HigherBound='71.1'>
                <om:Property Name='ClassName' Value='DLAPDocumentListSalesforceDefinition.Rest_Schemas.Rest_Multiple_Document_Details' />
                <om:Property Name='IsBodyPart' Value='True' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='MessagePart' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
        </om:Element>
        <om:Element Type='MultipartMessageType' OID='47d9a87a-7ef5-4720-8501-3e4ff9022bed' ParentLink='Module_MessageType' LowerBound='72.1' HigherBound='76.1'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='ChecklistitemClosingDocsSFIDValuesType' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='PartDeclaration' OID='8e0d0399-e28e-4105-ae75-ab17c0053d3b' ParentLink='MultipartMessageType_PartDeclaration' LowerBound='74.1' HigherBound='75.1'>
                <om:Property Name='ClassName' Value='DLAPDocumentListSalesforceDefinition.Rest_Schemas.Checklistitem_ClosingDocs_SFID' />
                <om:Property Name='IsBodyPart' Value='True' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='MessagePart' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
        </om:Element>
        <om:Element Type='MultipartMessageType' OID='a4b10c23-e9b3-4aa9-a5ae-1ae9eeca9b22' ParentLink='Module_MessageType' LowerBound='76.1' HigherBound='80.1'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='RestApplicationInfoRequestType' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='PartDeclaration' OID='69990a38-bde7-4d53-b11a-ba4d8530a888' ParentLink='MultipartMessageType_PartDeclaration' LowerBound='78.1' HigherBound='79.1'>
                <om:Property Name='ClassName' Value='DLAPDocumentListSalesforceDefinition.Rest_Schemas.RestApplicationInfoRequestResponse.Request' />
                <om:Property Name='IsBodyPart' Value='True' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='MessagePart' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
        </om:Element>
        <om:Element Type='MultipartMessageType' OID='64608d52-4b86-4c7f-9313-d9bdca3eded7' ParentLink='Module_MessageType' LowerBound='80.1' HigherBound='84.1'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='RestApplicationInfoResponseType' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='PartDeclaration' OID='e9fb09cf-5d41-4295-b9b6-7f779f6fecc3' ParentLink='MultipartMessageType_PartDeclaration' LowerBound='82.1' HigherBound='83.1'>
                <om:Property Name='ClassName' Value='DLAPDocumentListSalesforceDefinition.Rest_Schemas.RestApplicationInfoRequestResponse.QueryResult' />
                <om:Property Name='IsBodyPart' Value='True' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='MessagePart' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
        </om:Element>
        <om:Element Type='ServiceDeclaration' OID='18be587d-3630-491c-b629-f695b3bd4b28' ParentLink='Module_ServiceDeclaration' LowerBound='112.1' HigherBound='488.1'>
            <om:Property Name='InitializedTransactionType' Value='False' />
            <om:Property Name='IsInvokable' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='ListLogic' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='VariableDeclaration' OID='2cd444e9-d8d7-4298-9e7f-136827c363c9' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='143.1' HigherBound='144.1'>
                <om:Property Name='UseDefaultConstructor' Value='True' />
                <om:Property Name='Type' Value='System.Xml.XmlDocument' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='TempClosingDocList' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='329d4033-82b9-4aab-9b63-2331e4cbb620' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='144.1' HigherBound='145.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ClosingDocStrTempEmpty' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='18b5708e-af4a-41f3-bb07-65fa36308a8e' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='145.1' HigherBound='146.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ChecklistStrTempEmpty' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='6e9a5a2c-8e24-4915-924d-95c0e8df72a4' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='146.1' HigherBound='147.1'>
                <om:Property Name='UseDefaultConstructor' Value='True' />
                <om:Property Name='Type' Value='System.Xml.XmlDocument' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ChecklistItemTempDoc' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='8e23c0fb-f5e5-4628-8a1e-97170b89d329' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='147.1' HigherBound='148.1'>
                <om:Property Name='InitialValue' Value='1' />
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.Int32' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ChecklistItemLoopCount' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='28987162-dc18-4886-b5d8-78489dcc68b0' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='148.1' HigherBound='149.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.Int32' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ApplicantCount' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='3f343671-21e3-4360-9ea3-d3c9e9f401c4' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='149.1' HigherBound='150.1'>
                <om:Property Name='InitialValue' Value='1' />
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.Int32' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='LoopCount' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='2eb2733f-6d63-40c8-8b66-c20fd994912d' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='150.1' HigherBound='151.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ApplicantSFID' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='2e9cd841-bead-4c71-bdf4-f35628c73b38' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='151.1' HigherBound='152.1'>
                <om:Property Name='UseDefaultConstructor' Value='True' />
                <om:Property Name='Type' Value='System.Text.StringBuilder' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='StrTemp' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='badf62ae-39b9-4d69-bb5e-7d04395fcf9b' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='152.1' HigherBound='153.1'>
                <om:Property Name='UseDefaultConstructor' Value='True' />
                <om:Property Name='Type' Value='System.Xml.XmlDocument' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='TempDoc' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='ef4f4448-c01f-48f1-b855-b0f8006407ef' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='153.1' HigherBound='154.1'>
                <om:Property Name='UseDefaultConstructor' Value='True' />
                <om:Property Name='Type' Value='System.Xml.XmlDocument' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='TempApplicationDocList' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='4d900f50-1887-4b6c-a628-031911750c6e' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='154.1' HigherBound='155.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ApplicantSFIDXpath' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='645f0a67-9923-4494-8b29-2dcfe3a9067d' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='155.1' HigherBound='156.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='StrTempEmpty' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='929f7b1a-4d99-494e-be49-183e694e56a5' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='156.1' HigherBound='157.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ApplicationID' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='d3cc8c26-3399-4782-bc58-e6ba3179361c' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='157.1' HigherBound='158.1'>
                <om:Property Name='InitialValue' Value='true' />
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.Boolean' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ApplicationIDStatus' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='43454f37-3050-4fd8-8482-46037d3496d4' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='158.1' HigherBound='159.1'>
                <om:Property Name='InitialValue' Value='true' />
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.Boolean' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Flag' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='4d21ce63-4f97-460a-98b2-e08c304ecf93' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='159.1' HigherBound='160.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.Guid' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='OrchestrationInstanceId' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='95067938-22ec-48da-b64d-0f1d62a3d9c8' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='160.1' HigherBound='161.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Status' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='3d65d316-0033-4407-a266-b7fe931b278c' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='161.1' HigherBound='162.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ApplicationNumber' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='acd1fb1d-3acf-43c4-92d6-0cc7be9bf236' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='162.1' HigherBound='163.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Stage' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='f8ce8bdc-36f7-449d-bcf5-7f3fb247e914' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='163.1' HigherBound='164.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SalesForceObjectName' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='74724fa7-9cc0-477c-9b17-3f27ef3af3e3' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='164.1' HigherBound='165.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SalesForceObjectId' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='13dee505-d6d8-4f47-abda-ce74bc58c517' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='165.1' HigherBound='166.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Message' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='292d58a1-b1ba-48a6-9bd3-91e6bf747c4a' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='166.1' HigherBound='167.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ApplicationSFID' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='b0f6d023-401a-4964-8235-c8471eb75897' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='167.1' HigherBound='168.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ExMessageTemp' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='f1f9004f-38d7-413b-b944-3b85361780fe' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='168.1' HigherBound='169.1'>
                <om:Property Name='UseDefaultConstructor' Value='True' />
                <om:Property Name='Type' Value='System.Xml.XmlDocument' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='TempFaultResponse' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='eebe236b-8b36-42fd-bfab-67f15e62873b' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='169.1' HigherBound='170.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='DLAPUserID' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='f5527f23-5a47-44df-aedc-e6a88a349e89' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='170.1' HigherBound='171.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ApplicationStrTempEmpty' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='5ba1f22c-50d5-47cb-9943-0363ebeff82e' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='171.1' HigherBound='172.1'>
                <om:Property Name='UseDefaultConstructor' Value='True' />
                <om:Property Name='Type' Value='System.Xml.XmlDocument' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ApplicationTempDoc' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='32a0b844-b761-4524-a67b-67ee8e4b6ebc' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='172.1' HigherBound='173.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ApplicantNameXpath' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='f6fed40a-6664-4667-a98b-f7c100573b3b' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='173.1' HigherBound='174.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ApplicantName' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='be926fe3-0b2f-491f-b76a-f3ac296cb11b' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='174.1' HigherBound='175.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.Int32' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ApplicantDocCount' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='dc3adfeb-cc7b-47d2-8b28-b1b49922bea4' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='175.1' HigherBound='176.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.Int32' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ChecklistItemCount' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='8cc7ddf3-2dbc-4d1e-a3de-5c05dfba1cef' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='176.1' HigherBound='177.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ChecklistItemClosingDocSFIDxpath' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='2353bb50-f762-48ac-83a8-ebe6a0977a39' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='177.1' HigherBound='178.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ChecklistItemClosingDocSFID' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='31dce73f-0ff9-43b6-93fd-ce0edc7b8eee' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='178.1' HigherBound='179.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ClosingDocApplicantSFIDxpath' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='7ef9b597-32ec-419a-8750-55e967b11f61' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='179.1' HigherBound='180.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ClosingDocApplicantSFID' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='0ae4d163-d8bf-46e7-9dfc-3d0cab76a5e0' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='180.1' HigherBound='181.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ClosingDocChecklistItemStatusxPath' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='fabc81c6-821f-48cc-ba28-0bc134af785a' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='181.1' HigherBound='182.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ClosingDocChecklistItemStatus' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='25203929-b17b-4cae-b54f-a80fec63cd9c' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='182.1' HigherBound='183.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='DocumentMasterCheckListNamexPath' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='919fbfb2-c8bb-4c8b-8b43-c99f515f6840' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='183.1' HigherBound='184.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='DocumentMasterCheckListDescxPath' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='0700b579-9a62-46a4-bed0-e5b7ed3e64a1' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='184.1' HigherBound='185.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='DocumentMasterCheckListDesc' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='15dcb78d-0f83-4921-9119-133e4c2edd3a' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='185.1' HigherBound='186.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='DocumentMasterCheckListName' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='988550d4-8efc-4c0a-a89c-85654130b97f' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='186.1' HigherBound='187.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ChecklistItemSFIDS' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='76c4308d-cac2-4655-86ad-ddd9673bf008' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='187.1' HigherBound='188.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='CHECKLISTITEM_SOQL_QUERY' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='20283bab-4475-468e-a630-dcbf3128c6c5' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='188.1' HigherBound='189.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='DOCUMENT_SOQL_QUERY' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='a93aa9b5-e97d-4b2f-a291-f5fbe4fa8012' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='189.1' HigherBound='190.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ApplicationNumberList' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='227f6b8f-0e57-4075-b857-7968c9e3dc8b' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='190.1' HigherBound='191.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='APPLICATION_INFO_SOQL_QUERY' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='efff2f22-a44c-4c70-89ee-aca3d2204773' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='123.1' HigherBound='124.1'>
                <om:Property Name='Type' Value='DLAPDocument.DocumentListRequestType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='DocumentListRequestMsg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='acf3661d-5f2e-4cce-9760-86d02af2ec53' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='124.1' HigherBound='125.1'>
                <om:Property Name='Type' Value='DLAPDocument.DocumentListResponseType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='DocumentListResponseMsg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='92806f14-366f-4b1c-8934-2cca22b9c17c' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='125.1' HigherBound='126.1'>
                <om:Property Name='Type' Value='DLAPDocument.SalesforceQueryApplicationInfoRequestType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SalesforceQueryApplicationInfoRequestMsg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='ec8e8fe9-c7ad-4461-8220-65eb171174b0' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='126.1' HigherBound='127.1'>
                <om:Property Name='Type' Value='DLAPDocument.SalesforceQueryApplicationInfoResponseType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SalesforceQueryApplicationInfoResponseMsg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='dbcdb911-9324-4c8a-947e-8bcb3888ba4f' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='127.1' HigherBound='128.1'>
                <om:Property Name='Type' Value='DLAPDocument.SalesforceQueryContentVersionRequestType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SalesforceQueryContentVersionRequestMsg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='d353fa83-73de-4c95-a359-804ecd43bb80' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='128.1' HigherBound='129.1'>
                <om:Property Name='Type' Value='DLAPDocument.SalesforceQueryContentVersionResponseType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SalesforceQueryContentVersionResponseMsg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='220d5e6e-9568-4c02-a9a1-67f88c099914' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='129.1' HigherBound='130.1'>
                <om:Property Name='Type' Value='DLAPDocument.MultipleDocumentListDetailsResponseType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='MultipleDocumentListDetailsResponseMsg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='a77d5b1b-4cc7-4d86-bf45-6527eb593f31' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='130.1' HigherBound='131.1'>
                <om:Property Name='Type' Value='DLAPDocument.DocumentListFaultResponseType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='DocumentListFaultResponseMsg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='f9a5c425-12f3-4c5e-9089-6795e3f08575' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='131.1' HigherBound='132.1'>
                <om:Property Name='Type' Value='DLAPDocument.SalesforceQueryChecklistItemRequestType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SalesforceQueryChecklistItemRequestMsg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='c8d1ff41-7761-4543-9dd5-4797c5e7c76b' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='132.1' HigherBound='133.1'>
                <om:Property Name='Type' Value='DLAPDocument.SalesforceQueryChecklistItemResponseType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SalesforceQueryChecklistItemResponseMsg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='13e76703-f824-4b12-864a-3f34bb1c4d38' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='133.1' HigherBound='134.1'>
                <om:Property Name='Type' Value='DLAPDocument.MultipleChecklistItemDocumentListsResponseType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='MultipleChecklistItemDocumentListsResponseMsg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='f9478fad-d3aa-42e4-a70b-ebbcfb46c627' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='134.1' HigherBound='135.1'>
                <om:Property Name='Type' Value='DLAPDocument.RestCheckListItemDocumentDetailsRequestType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='RestCheckListItemDocumentDetailsRequestMsg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='8945a424-490b-411f-9372-7bd6b5a1aeca' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='135.1' HigherBound='136.1'>
                <om:Property Name='Type' Value='DLAPDocument.RestCheckListItemDocumentDetailsResponseType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='RestCheckListItemDocumentDetailsResponseMsg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='3a01379f-b0d5-4753-998f-1f0cc8bbc466' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='136.1' HigherBound='137.1'>
                <om:Property Name='Type' Value='DLAPDocument.RestDocumentDetailsRequestType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='RestDocumentDetailsRequestMsg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='f37965a1-9cea-40c2-870b-a853b196f7f9' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='137.1' HigherBound='138.1'>
                <om:Property Name='Type' Value='DLAPDocument.RestDocumentDetailsResponseType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='RestDocumentDetailsResponseMsg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='6143a74e-5f64-497f-8455-26d631d3a6eb' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='138.1' HigherBound='139.1'>
                <om:Property Name='Type' Value='DLAPDocument.RestMultipleChecklistItemDocumentDetailsResponseType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='RestMultipleChecklistItemDocumentDetailsResponseMsg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='4251fc85-805b-4126-9d4d-9e6fd9b32c53' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='139.1' HigherBound='140.1'>
                <om:Property Name='Type' Value='DLAPDocument.RestMultipleDocumentDetailsResponseType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='RestMultipleDocumentDetailsResponseMsg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='929fe5ba-f653-4490-8ea7-cd480ab69669' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='140.1' HigherBound='141.1'>
                <om:Property Name='Type' Value='DLAPDocument.ChecklistitemClosingDocsSFIDValuesType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ChecklistitemClosingDocsSFIDValuesMsg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='197972ac-01be-4659-9301-ad5d3ef68990' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='141.1' HigherBound='142.1'>
                <om:Property Name='Type' Value='DLAPDocument.RestApplicationInfoRequestType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='RestApplicationInfoRequestMsg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='28629ba4-9e7a-4a89-b1b7-fa0f5dc0c499' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='142.1' HigherBound='143.1'>
                <om:Property Name='Type' Value='DLAPDocument.RestApplicationInfoResponseType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='RestApplicationInfoResponseMsg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='ServiceBody' OID='1eb1cf06-6eb7-4809-bdc8-cbc4be0f8ce3' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='Receive' OID='2d3f5d4a-ab0e-4320-846b-34340ef83643' ParentLink='ServiceBody_Statement' LowerBound='193.1' HigherBound='239.1'>
                    <om:Property Name='Activate' Value='True' />
                    <om:Property Name='PortName' Value='DocumentListPort' />
                    <om:Property Name='MessageName' Value='DocumentListRequestMsg' />
                    <om:Property Name='OperationName' Value='Operation' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Receive DoucumentList Request' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Scope' OID='98f222a9-ffe5-4235-9744-a85f9cb79122' ParentLink='ServiceBody_Statement' LowerBound='239.1' HigherBound='484.1'>
                    <om:Property Name='InitializedTransactionType' Value='True' />
                    <om:Property Name='IsSynchronized' Value='False' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Document List Processing Error Scope' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='Task' OID='87be290a-8a5b-4b00-9264-43aeef720f9e' ParentLink='ComplexStatement_Statement' LowerBound='244.1' HigherBound='459.1'>
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Document List Processing' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='Task' OID='af0d3d2a-aa76-4113-a81f-2b0266bf45fc' ParentLink='ComplexStatement_Statement' LowerBound='244.1' HigherBound='290.1'>
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Application Info Processing' />
                            <om:Property Name='Signal' Value='True' />
                            <om:Element Type='Construct' OID='8f83ea7f-a80c-46d0-8851-c0c131d73101' ParentLink='ComplexStatement_Statement' LowerBound='244.1' HigherBound='266.1'>
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Construct Application Info Request Msg' />
                                <om:Property Name='Signal' Value='True' />
                                <om:Element Type='Transform' OID='da61cc9d-6d43-4b2e-920c-dcc08d374b64' ParentLink='ComplexStatement_Statement' LowerBound='247.1' HigherBound='249.1'>
                                    <om:Property Name='ClassName' Value='DLAPDocumentListLogic.MakeRestApplicationInfoRequest' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='Make Rest Application Info Request' />
                                    <om:Property Name='Signal' Value='False' />
                                    <om:Element Type='MessagePartRef' OID='e43d6ccf-1ce7-40cc-a785-14743ef2d90a' ParentLink='Transform_InputMessagePartRef' LowerBound='248.135' HigherBound='248.169'>
                                        <om:Property Name='MessageRef' Value='DocumentListRequestMsg' />
                                        <om:Property Name='PartRef' Value='MessagePart' />
                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                        <om:Property Name='Name' Value='MessagePartReference_19' />
                                        <om:Property Name='Signal' Value='False' />
                                    </om:Element>
                                    <om:Element Type='MessagePartRef' OID='8565f8cf-b314-4e59-80d7-bc6f16132ded' ParentLink='Transform_OutputMessagePartRef' LowerBound='248.36' HigherBound='248.77'>
                                        <om:Property Name='MessageRef' Value='RestApplicationInfoRequestMsg' />
                                        <om:Property Name='PartRef' Value='MessagePart' />
                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                        <om:Property Name='Name' Value='MessagePartReference_20' />
                                        <om:Property Name='Signal' Value='False' />
                                    </om:Element>
                                </om:Element>
                                <om:Element Type='MessageAssignment' OID='67402021-bc39-40b5-a02c-0b10e3d09519' ParentLink='ComplexStatement_Statement' LowerBound='249.1' HigherBound='265.1'>
                                    <om:Property Name='Expression' Value='//Extract DLAPUserID and Application Number from the DocumentList Request&#xD;&#xA;DLAPUserID = xpath(DocumentListRequestMsg.MessagePart,&quot;string(/*[local-name()=&apos;DocumentListRequest&apos; and namespace-uri()=&apos;http://SBA.gov/DLAPDocumentList/DocumentListRequest&apos;]/*[local-name()=&apos;UserID&apos; and namespace-uri()=&apos;&apos;])&quot;);&#xD;&#xA;&#xD;&#xA;ApplicationNumberList = xpath(DocumentListRequestMsg.MessagePart,&quot;string(/*[local-name()=&apos;DocumentListRequest&apos; and namespace-uri()=&apos;http://SBA.gov/DLAPDocumentList/DocumentListRequest&apos;]/*[local-name()=&apos;ApplicationNumber&apos; and namespace-uri()=&apos;&apos;])&quot;);&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;//SOQL Query For Rest&#xD;&#xA;&#xD;&#xA;APPLICATION_INFO_SOQL_QUERY = @&quot;Select Id, Name, Loan_Type__c, DLAP_Status_Description__c, DLAP_Status__c, Disaster_Declaration__r.Name,Disaster_Declaration__r.Disaster_Description__c, Disaster_Declaration__r.Disaster_Deadline_Date__c,(Select Id, External_ID__c, Name, Applicant_Relation_Type__c, Trade_Name__c, Contact__r.LastName, Contact__r.FirstName,Account__r.Name, Account__r.Business_Type__c from Applicants__r),(Select Id, Name, Case__c, Applicant__c, Application__c, Checklist_Item_Status__c, Checklist_Item_Text__c, Type__c, DocumentType__c, Verified_Date__c, CreatedDate, Checklist_Item_Due_Date__c, Applicant__r.External_ID__c, Master_Checklist__r.Name, Master_Checklist__r.Checklist_Description__c FROM Checklist_Items__r WHERE ((Type__c != &apos;Interface&apos; AND Checklist_Item_Status__c = &apos;Requested&apos;) OR (((Type__c = &apos;Closing Documents&apos;) AND ((( Checklist_Item_Status__c =&apos;Finalized&apos;) AND (Document_Generated__c = true)) OR (Checklist_Item_Status__c = &apos;Pending Borrower\&apos;s Verification&apos;))))) AND Id != NULL) FROM Application__c WHERE Name IN &quot;+&quot;(&apos;&quot;+ApplicationNumberList+&quot;&apos;) AND Name != NULL&quot;;&#xD;&#xA;&#xD;&#xA"+
@";&#xD;&#xA;RestApplicationInfoRequestMsg(DLAPDocumentListSalesforceDefinition.Rest_Schemas.APPLICATION_INFO_SOQL_QUERY) = APPLICATION_INFO_SOQL_QUERY; &#xD;&#xA;&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;' />
                                    <om:Property Name='ReportToAnalyst' Value='False' />
                                    <om:Property Name='Name' Value='Make SOQL' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                                <om:Element Type='MessageRef' OID='a4334be7-2023-43c1-89e6-1d53bdcabca5' ParentLink='Construct_MessageRef' LowerBound='245.31' HigherBound='245.60'>
                                    <om:Property Name='Ref' Value='RestApplicationInfoRequestMsg' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                            </om:Element>
                            <om:Element Type='Send' OID='772a9197-1db1-4c5c-b84e-c8b655ecf94b' ParentLink='ComplexStatement_Statement' LowerBound='266.1' HigherBound='268.1'>
                                <om:Property Name='PortName' Value='RestQueryApplicationInfoPort' />
                                <om:Property Name='MessageName' Value='RestApplicationInfoRequestMsg' />
                                <om:Property Name='OperationName' Value='Operation' />
                                <om:Property Name='OperationMessageName' Value='Request' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Send Application Info Request' />
                                <om:Property Name='Signal' Value='True' />
                            </om:Element>
                            <om:Element Type='Receive' OID='3c1a3fcf-01ed-49bf-a234-e95854cb082f' ParentLink='ComplexStatement_Statement' LowerBound='268.1' HigherBound='270.1'>
                                <om:Property Name='Activate' Value='False' />
                                <om:Property Name='PortName' Value='RestQueryApplicationInfoPort' />
                                <om:Property Name='MessageName' Value='RestApplicationInfoResponseMsg' />
                                <om:Property Name='OperationName' Value='Operation' />
                                <om:Property Name='OperationMessageName' Value='Response' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Receive Application Info Response' />
                                <om:Property Name='Signal' Value='True' />
                            </om:Element>
                            <om:Element Type='Construct' OID='098be654-5f03-44b9-bbab-06d1a136e7cd' ParentLink='ComplexStatement_Statement' LowerBound='270.1' HigherBound='276.1'>
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Construct Salesforce Application Response' />
                                <om:Property Name='Signal' Value='True' />
                                <om:Element Type='Transform' OID='591b1656-0f56-4a7e-91e8-1076fea283ec' ParentLink='ComplexStatement_Statement' LowerBound='273.1' HigherBound='275.1'>
                                    <om:Property Name='ClassName' Value='DLAPDocumentListLogic.MakeSalesforceApplicationResponse' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='Make Salesforce Application Response' />
                                    <om:Property Name='Signal' Value='False' />
                                    <om:Element Type='MessagePartRef' OID='310b2b07-7a64-40ba-801a-ec7ccf42dc45' ParentLink='Transform_InputMessagePartRef' LowerBound='274.150' HigherBound='274.192'>
                                        <om:Property Name='MessageRef' Value='RestApplicationInfoResponseMsg' />
                                        <om:Property Name='PartRef' Value='MessagePart' />
                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                        <om:Property Name='Name' Value='MessagePartReference_1' />
                                        <om:Property Name='Signal' Value='False' />
                                    </om:Element>
                                    <om:Element Type='MessagePartRef' OID='265e547e-44af-4dbc-9a08-b019f38c6de1' ParentLink='Transform_OutputMessagePartRef' LowerBound='274.36' HigherBound='274.89'>
                                        <om:Property Name='MessageRef' Value='SalesforceQueryApplicationInfoResponseMsg' />
                                        <om:Property Name='PartRef' Value='MessagePart' />
                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                        <om:Property Name='Name' Value='MessagePartReference_2' />
                                        <om:Property Name='Signal' Value='False' />
                                    </om:Element>
                                </om:Element>
                                <om:Element Type='MessageRef' OID='abaa584c-8f92-4b31-9f10-5a9ad08e989b' ParentLink='Construct_MessageRef' LowerBound='271.31' HigherBound='271.72'>
                                    <om:Property Name='Ref' Value='SalesforceQueryApplicationInfoResponseMsg' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                            </om:Element>
                            <om:Element Type='VariableAssignment' OID='a1e14e43-2a08-4237-a6ef-257a424f1752' ParentLink='ComplexStatement_Statement' LowerBound='276.1' HigherBound='290.1'>
                                <om:Property Name='Expression' Value='//Counting Number of Applicants on Application&#xD;&#xA;ApplicantCount = System.Convert.ToInt32(xpath(SalesforceQueryApplicationInfoResponseMsg.MessagePart, &quot;count(/*[local-name()=&apos;Response&apos; and namespace-uri()=&apos;http://SBA.gov/DLAPDocumentList/Application_Info__c&apos;]/*[local-name()=&apos;row&apos; and namespace-uri()=&apos;http://SBA.gov/DLAPDocumentList/Application_Info__c&apos;]/*[local-name()=&apos;ApplicantId&apos; and namespace-uri()=&apos;http://SBA.gov/DLAPDocumentList/Application_Info__c&apos;])&quot;));&#xD;&#xA;&#xD;&#xA;//Applicant Temp&#xD;&#xA;StrTempEmpty = System.String.Empty;&#xD;&#xA;&#xD;&#xA;//Application Temp&#xD;&#xA;ApplicationStrTempEmpty = System.String.Empty;&#xD;&#xA;&#xD;&#xA;//Extract Application SFID Value From Response&#xD;&#xA;ApplicationSFID = xpath(SalesforceQueryApplicationInfoResponseMsg.MessagePart,&quot;string(/*[local-name()=&apos;Response&apos; and namespace-uri()=&apos;http://SBA.gov/DLAPDocumentList/Application_Info__c&apos;]/*[local-name()=&apos;row&apos; and namespace-uri()=&apos;http://SBA.gov/DLAPDocumentList/Application_Info__c&apos;][1]/*[local-name()=&apos;ApplicationId&apos; and namespace-uri()=&apos;http://SBA.gov/DLAPDocumentList/Application_Info__c&apos;])&quot;);&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='ApplicationID Validation Applicant Count and Extracting DLAPUser ID' />
                                <om:Property Name='Signal' Value='True' />
                            </om:Element>
                        </om:Element>
                        <om:Element Type='Decision' OID='8d5278d0-4552-488f-9843-66f61001de5a' ParentLink='ComplexStatement_Statement' LowerBound='290.1' HigherBound='459.1'>
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Application ID Exists?' />
                            <om:Property Name='Signal' Value='True' />
                            <om:Element Type='DecisionBranch' OID='5487f94a-503c-43a4-ab15-5cd22c762a81' ParentLink='ReallyComplexStatement_Branch' LowerBound='291.21' HigherBound='450.1'>
                                <om:Property Name='Expression' Value='(ApplicantCount &gt; 0)||(!System.String.IsNullOrEmpty(ApplicationSFID))' />
                                <om:Property Name='IsGhostBranch' Value='True' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value=' Exists' />
                                <om:Property Name='Signal' Value='True' />
                                <om:Element Type='Task' OID='a0a9f2a9-240a-42e6-ae5f-addf4602184a' ParentLink='ComplexStatement_Statement' LowerBound='293.1' HigherBound='359.1'>
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value=' CheckList Item Processing' />
                                    <om:Property Name='Signal' Value='True' />
                                    <om:Element Type='Construct' OID='8e45db39-6552-4089-aad7-a7586e8fc97d' ParentLink='ComplexStatement_Statement' LowerBound='293.1' HigherBound='299.1'>
                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                        <om:Property Name='Name' Value='Construct CheckList Item Request Msg' />
                                        <om:Property Name='Signal' Value='True' />
                                        <om:Element Type='Transform' OID='679a7e87-13b2-4f48-a170-28b8d8de27be' ParentLink='ComplexStatement_Statement' LowerBound='296.1' HigherBound='298.1'>
                                            <om:Property Name='ClassName' Value='DLAPDocumentListLogic.MakeSalesforceCheckListItemResponse' />
                                            <om:Property Name='ReportToAnalyst' Value='True' />
                                            <om:Property Name='Name' Value='Make Salesforce CheckList Item Response' />
                                            <om:Property Name='Signal' Value='True' />
                                            <om:Element Type='MessagePartRef' OID='247a1112-7e66-48ca-bdf6-336473f3584b' ParentLink='Transform_InputMessagePartRef' LowerBound='297.154' HigherBound='297.196'>
                                                <om:Property Name='MessageRef' Value='RestApplicationInfoResponseMsg' />
                                                <om:Property Name='PartRef' Value='MessagePart' />
                                                <om:Property Name='ReportToAnalyst' Value='True' />
                                                <om:Property Name='Name' Value='MessagePartReference_10' />
                                                <om:Property Name='Signal' Value='False' />
                                            </om:Element>
                                            <om:Element Type='MessagePartRef' OID='9fb27468-a6a4-45af-b1e9-b557215fd2eb' ParentLink='Transform_OutputMessagePartRef' LowerBound='297.40' HigherBound='297.91'>
                                                <om:Property Name='MessageRef' Value='SalesforceQueryChecklistItemResponseMsg' />
                                                <om:Property Name='PartRef' Value='MessagePart' />
                                                <om:Property Name='ReportToAnalyst' Value='True' />
                                                <om:Property Name='Name' Value='MessagePartReference_11' />
                                                <om:Property Name='Signal' Value='False' />
                                            </om:Element>
                                        </om:Element>
                                        <om:Element Type='MessageRef' OID='a1b9c1ba-984f-41de-b9b5-1862b0f066da' ParentLink='Construct_MessageRef' LowerBound='294.35' HigherBound='294.74'>
                                            <om:Property Name='Ref' Value='SalesforceQueryChecklistItemResponseMsg' />
                                            <om:Property Name='ReportToAnalyst' Value='True' />
                                            <om:Property Name='Signal' Value='False' />
                                        </om:Element>
                                    </om:Element>
                                    <om:Element Type='VariableAssignment' OID='db93f657-6ff5-45ed-86db-1be111c8ca4e' ParentLink='ComplexStatement_Statement' LowerBound='299.1' HigherBound='301.1'>
                                        <om:Property Name='Expression' Value='ChecklistItemCount = xpath(SalesforceQueryChecklistItemResponseMsg.MessagePart,&quot;count(/*[local-name()=&apos;Response&apos; and namespace-uri()=&apos;http://SBA.gov/DLAPDocumentList/Checklist_Item__c&apos;]/*[local-name()=&apos;row&apos; and namespace-uri()=&apos;http://SBA.gov/DLAPDocumentList/Checklist_Item__c&apos;]/*[local-name()=&apos;Id&apos; and namespace-uri()=&apos;http://SBA.gov/DLAPDocumentList/Checklist_Item__c&apos;])&quot;);' />
                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                        <om:Property Name='Name' Value='CheckList Item Count' />
                                        <om:Property Name='Signal' Value='True' />
                                    </om:Element>
                                    <om:Element Type='Construct' OID='81e05aee-f6ad-44e6-bb67-1db0809553ef' ParentLink='ComplexStatement_Statement' LowerBound='301.1' HigherBound='307.1'>
                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                        <om:Property Name='Name' Value='Construct Concatenated CheckList Item SFID Values Message' />
                                        <om:Property Name='Signal' Value='True' />
                                        <om:Element Type='MessageRef' OID='2ab83668-0f7e-4c96-af3c-06c1438ef4d8' ParentLink='Construct_MessageRef' LowerBound='302.35' HigherBound='302.72'>
                                            <om:Property Name='Ref' Value='ChecklistitemClosingDocsSFIDValuesMsg' />
                                            <om:Property Name='ReportToAnalyst' Value='True' />
                                            <om:Property Name='Signal' Value='False' />
                                        </om:Element>
                                        <om:Element Type='Transform' OID='ba3364a6-5f1a-40fb-bd68-7a322dd435b5' ParentLink='ComplexStatement_Statement' LowerBound='304.1' HigherBound='306.1'>
                                            <om:Property Name='ClassName' Value='DLAPDocumentListLogic.MakeConcatenatedCheckListItemSFIDValues' />
                                            <om:Property Name='ReportToAnalyst' Value='True' />
                                            <om:Property Name='Name' Value='Make SFID String Values' />
                                            <om:Property Name='Signal' Value='True' />
                                            <om:Element Type='MessagePartRef' OID='ee073a25-f3be-4bc8-b385-4dd6a7e43093' ParentLink='Transform_OutputMessagePartRef' LowerBound='305.40' HigherBound='305.89'>
                                                <om:Property Name='MessageRef' Value='ChecklistitemClosingDocsSFIDValuesMsg' />
                                                <om:Property Name='PartRef' Value='MessagePart' />
                                                <om:Property Name='ReportToAnalyst' Value='True' />
                                                <om:Property Name='Name' Value='MessagePartReference_18' />
                                                <om:Property Name='Signal' Value='False' />
                                            </om:Element>
                                            <om:Element Type='MessagePartRef' OID='5882737d-84f1-49f1-9b6c-e3955cb28e4b' ParentLink='Transform_InputMessagePartRef' LowerBound='305.156' HigherBound='305.207'>
                                                <om:Property Name='MessageRef' Value='SalesforceQueryChecklistItemResponseMsg' />
                                                <om:Property Name='PartRef' Value='MessagePart' />
                                                <om:Property Name='ReportToAnalyst' Value='True' />
                                                <om:Property Name='Name' Value='MessagePartReference_15' />
                                                <om:Property Name='Signal' Value='False' />
                                            </om:Element>
                                        </om:Element>
                                    </om:Element>
                                    <om:Element Type='VariableAssignment' OID='25c6beb5-4278-4f62-adee-cd6d0302170a' ParentLink='ComplexStatement_Statement' LowerBound='307.1' HigherBound='309.1'>
                                        <om:Property Name='Expression' Value='ChecklistItemSFIDS = xpath(ChecklistitemClosingDocsSFIDValuesMsg.MessagePart, &quot;string(/*[local-name()=&apos;SFIDValues&apos; and namespace-uri()=&apos;http://DLAPDocumentListDefinition.ClosingDocsSFID&apos;]/*[local-name()=&apos;Multiple_Checklistitem_SFID_Values&apos; and namespace-uri()=&apos;&apos;])&quot;);' />
                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                        <om:Property Name='Name' Value='Extract Concatenate SFID' />
                                        <om:Property Name='Signal' Value='True' />
                                    </om:Element>
                                    <om:Element Type='Decision' OID='b2276229-b41c-4d3d-9e54-954c3a92895d' ParentLink='ComplexStatement_Statement' LowerBound='309.1' HigherBound='345.1'>
                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                        <om:Property Name='Name' Value='ChecklistItem Contain Closing Document SFID?' />
                                        <om:Property Name='Signal' Value='True' />
                                        <om:Element Type='DecisionBranch' OID='9c200a1e-597b-49da-b159-1fdd865b52fb' ParentLink='ReallyComplexStatement_Branch' LowerBound='310.25' HigherBound='345.1'>
                                            <om:Property Name='Expression' Value='(!System.String.IsNullOrWhiteSpace(ChecklistItemSFIDS))' />
                                            <om:Property Name='IsGhostBranch' Value='True' />
                                            <om:Property Name='ReportToAnalyst' Value='True' />
                                            <om:Property Name='Name' Value='Closing Document' />
                                            <om:Property Name='Signal' Value='True' />
                                            <om:Element Type='Construct' OID='c7f17b3c-dac7-4bf1-9217-61e52b7340f2' ParentLink='ComplexStatement_Statement' LowerBound='312.1' HigherBound='326.1'>
                                                <om:Property Name='ReportToAnalyst' Value='True' />
                                                <om:Property Name='Name' Value='Construct Rest CheckListItem Document Request Msg' />
                                                <om:Property Name='Signal' Value='True' />
                                                <om:Element Type='Transform' OID='78fa5794-c442-455e-a917-daf0ee3a5893' ParentLink='ComplexStatement_Statement' LowerBound='315.1' HigherBound='317.1'>
                                                    <om:Property Name='ClassName' Value='DLAPDocumentListLogic.MakeRestCheckListItemDocumentRequest' />
                                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                                    <om:Property Name='Name' Value='MakeSalesforceContentVersionRequest' />
                                                    <om:Property Name='Signal' Value='True' />
                                                    <om:Element Type='MessagePartRef' OID='47e6aaf6-27a1-453d-9aab-5f2dc4048e98' ParentLink='Transform_OutputMessagePartRef' LowerBound='316.44' HigherBound='316.98'>
                                                        <om:Property Name='MessageRef' Value='RestCheckListItemDocumentDetailsRequestMsg' />
                                                        <om:Property Name='PartRef' Value='MessagePart' />
                                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                                        <om:Property Name='Name' Value='MessagePartReference_22' />
                                                        <om:Property Name='Signal' Value='False' />
                                                    </om:Element>
                                                    <om:Element Type='MessagePartRef' OID='2c0482ec-a4c2-4e95-be03-593c6f61bf5a' ParentLink='Transform_InputMessagePartRef' LowerBound='316.162' HigherBound='316.215'>
                                                        <om:Property Name='MessageRef' Value='SalesforceQueryApplicationInfoResponseMsg' />
                                                        <om:Property Name='PartRef' Value='MessagePart' />
                                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                                        <om:Property Name='Name' Value='MessagePartReference_21' />
                                                        <om:Property Name='Signal' Value='False' />
                                                    </om:Element>
                                                </om:Element>
                                                <om:Element Type='MessageAssignment' OID='7a7ce393-c3cb-441b-a994-6863a3d32795' ParentLink='ComplexStatement_Statement' LowerBound='317.1' HigherBound='325.1'>
                                                    <om:Property Name='Expression' Value='//SOQL Query For Rest&#xD;&#xA;&#xD;&#xA;CHECKLISTITEM_SOQL_QUERY = @&quot;SELECT ContentDocument.LatestPublishedVersion.DLAP_Document_Type__c,ContentDocument.LatestPublishedVersion.Title,ContentDocument.LatestPublishedVersion.Id,ContentDocument.LatestPublishedVersion.Description,ContentDocument.LatestPublishedVersion.Document_Validity__c,ContentDocument.LatestPublishedVersion.CreatedDate,ContentDocument.LatestPublishedVersion.Document_Type__c,LinkedEntityId FROM ContentDocumentLink WHERE LinkedEntityId IN&quot;+&quot;(&quot;+ChecklistItemSFIDS+&quot;)&quot;;&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;RestCheckListItemDocumentDetailsRequestMsg(DLAPDocumentListSalesforceDefinition.Rest_Schemas.SF_CHECKLISTITEM_QUERY) = CHECKLISTITEM_SOQL_QUERY; &#xD;&#xA;&#xD;&#xA;' />
                                                    <om:Property Name='ReportToAnalyst' Value='False' />
                                                    <om:Property Name='Name' Value='Make SOQL' />
                                                    <om:Property Name='Signal' Value='True' />
                                                </om:Element>
                                                <om:Element Type='MessageRef' OID='ec7f7b52-05cb-43a9-9296-dd773e6501ad' ParentLink='Construct_MessageRef' LowerBound='313.39' HigherBound='313.81'>
                                                    <om:Property Name='Ref' Value='RestCheckListItemDocumentDetailsRequestMsg' />
                                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                                    <om:Property Name='Signal' Value='False' />
                                                </om:Element>
                                            </om:Element>
                                            <om:Element Type='Send' OID='6a91403d-7712-46ec-b96c-1112d8ac960c' ParentLink='ComplexStatement_Statement' LowerBound='326.1' HigherBound='328.1'>
                                                <om:Property Name='PortName' Value='RestQueryClosingDocumentsPort' />
                                                <om:Property Name='MessageName' Value='RestCheckListItemDocumentDetailsRequestMsg' />
                                                <om:Property Name='OperationName' Value='Operation' />
                                                <om:Property Name='OperationMessageName' Value='Request' />
                                                <om:Property Name='ReportToAnalyst' Value='True' />
                                                <om:Property Name='Name' Value='Send Rest CheckListItem Document Request' />
                                                <om:Property Name='Signal' Value='True' />
                                            </om:Element>
                                            <om:Element Type='Receive' OID='83f4e829-b53e-4497-a3ce-f27c36fa752a' ParentLink='ComplexStatement_Statement' LowerBound='328.1' HigherBound='330.1'>
                                                <om:Property Name='Activate' Value='False' />
                                                <om:Property Name='PortName' Value='RestQueryClosingDocumentsPort' />
                                                <om:Property Name='MessageName' Value='RestCheckListItemDocumentDetailsResponseMsg' />
                                                <om:Property Name='OperationName' Value='Operation' />
                                                <om:Property Name='OperationMessageName' Value='Response' />
                                                <om:Property Name='ReportToAnalyst' Value='True' />
                                                <om:Property Name='Name' Value='Receive Rest CheckListItem Document Response' />
                                                <om:Property Name='Signal' Value='True' />
                                            </om:Element>
                                            <om:Element Type='VariableAssignment' OID='4919eaec-68f9-429d-97ce-35b3a64194c1' ParentLink='ComplexStatement_Statement' LowerBound='330.1' HigherBound='344.1'>
                                                <om:Property Name='Expression' Value='&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;//Aggregate multiple applicants douments Info into single message&#xD;&#xA;&#xD;&#xA;ChecklistItemTempDoc = RestCheckListItemDocumentDetailsResponseMsg.MessagePart;&#xD;&#xA;ChecklistStrTempEmpty =  ChecklistStrTempEmpty + @&quot;&lt;Responses&gt;&quot;+ChecklistItemTempDoc.InnerXml+&quot;&lt;/Responses&gt;&quot;;&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;' />
                                                <om:Property Name='ReportToAnalyst' Value='True' />
                                                <om:Property Name='Name' Value='Aggregate Multipe Applicants Documents Info' />
                                                <om:Property Name='Signal' Value='False' />
                                            </om:Element>
                                        </om:Element>
                                        <om:Element Type='DecisionBranch' OID='41800f59-fe27-431c-9793-edd33d42a75d' ParentLink='ReallyComplexStatement_Branch'>
                                            <om:Property Name='IsGhostBranch' Value='True' />
                                            <om:Property Name='ReportToAnalyst' Value='True' />
                                            <om:Property Name='Name' Value='Else' />
                                            <om:Property Name='Signal' Value='False' />
                                        </om:Element>
                                    </om:Element>
                                    <om:Element Type='Construct' OID='120bc076-e250-42c0-a144-1c094cebd535' ParentLink='ComplexStatement_Statement' LowerBound='345.1' HigherBound='359.1'>
                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                        <om:Property Name='Name' Value='Construct Rest Closing Document Response Msg' />
                                        <om:Property Name='Signal' Value='True' />
                                        <om:Element Type='MessageRef' OID='0574e75c-eae3-4f75-b767-571c79728dd0' ParentLink='Construct_MessageRef' LowerBound='346.35' HigherBound='346.86'>
                                            <om:Property Name='Ref' Value='RestMultipleChecklistItemDocumentDetailsResponseMsg' />
                                            <om:Property Name='ReportToAnalyst' Value='True' />
                                            <om:Property Name='Signal' Value='False' />
                                        </om:Element>
                                        <om:Element Type='MessageAssignment' OID='997c6dae-4c16-4fde-9847-048354a99725' ParentLink='ComplexStatement_Statement' LowerBound='348.1' HigherBound='358.1'>
                                            <om:Property Name='Expression' Value='&#xD;&#xA;ClosingDocStrTempEmpty = @&quot;&lt;ChecklistItemDocumentList xmlns=&apos;http://SBA.gov/DLAP/DocumentList&apos;&gt;&quot;+ChecklistStrTempEmpty+&quot;&lt;/ChecklistItemDocumentList&gt;&quot;;&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;//Load batched message&#xD;&#xA;&#xD;&#xA;TempClosingDocList.LoadXml(ClosingDocStrTempEmpty);&#xD;&#xA;&#xD;&#xA;RestMultipleChecklistItemDocumentDetailsResponseMsg.MessagePart = TempClosingDocList;&#xD;&#xA;' />
                                            <om:Property Name='ReportToAnalyst' Value='False' />
                                            <om:Property Name='Name' Value='Make Rest Multiple Checklistitem Document Response Msg' />
                                            <om:Property Name='Signal' Value='True' />
                                        </om:Element>
                                    </om:Element>
                                </om:Element>
                                <om:Element Type='Task' OID='b3038bdf-7c8b-467c-a2a0-522a3cd11bf9' ParentLink='ComplexStatement_Statement' LowerBound='359.1' HigherBound='426.1'>
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='Applicant Document Processing' />
                                    <om:Property Name='Signal' Value='True' />
                                    <om:Element Type='While' OID='38b29dd6-3a59-4b49-b8f5-68c75cb8e7dc' ParentLink='ComplexStatement_Statement' LowerBound='359.1' HigherBound='410.1'>
                                        <om:Property Name='Expression' Value='LoopCount &lt;= ApplicantCount&#xD;&#xA;&#xD;&#xA;' />
                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                        <om:Property Name='Name' Value='Loop Through Applicants' />
                                        <om:Property Name='Signal' Value='False' />
                                        <om:Element Type='Construct' OID='78bfbdc5-081c-48e4-8000-097e3b0c23e5' ParentLink='ComplexStatement_Statement' LowerBound='363.1' HigherBound='384.1'>
                                            <om:Property Name='ReportToAnalyst' Value='True' />
                                            <om:Property Name='Name' Value='Construct Rest Applicant Document Request Msg' />
                                            <om:Property Name='Signal' Value='True' />
                                            <om:Element Type='Transform' OID='38064b0b-4b13-4ddc-8df3-c8432ae695ed' ParentLink='ComplexStatement_Statement' LowerBound='366.1' HigherBound='368.1'>
                                                <om:Property Name='ClassName' Value='DLAPDocumentListLogic.MakeRestDocumentRequest' />
                                                <om:Property Name='ReportToAnalyst' Value='True' />
                                                <om:Property Name='Name' Value='Make Rest Applicant Document Request' />
                                                <om:Property Name='Signal' Value='False' />
                                                <om:Element Type='MessagePartRef' OID='9ab28779-acaf-4958-ad90-8acc9e03052d' ParentLink='Transform_OutputMessagePartRef' LowerBound='367.44' HigherBound='367.85'>
                                                    <om:Property Name='MessageRef' Value='RestDocumentDetailsRequestMsg' />
                                                    <om:Property Name='PartRef' Value='MessagePart' />
                                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                                    <om:Property Name='Name' Value='MessagePartReference_14' />
                                                    <om:Property Name='Signal' Value='False' />
                                                </om:Element>
                                                <om:Element Type='MessagePartRef' OID='4067f490-c73a-4eb4-9181-b75c1246c6e1' ParentLink='Transform_InputMessagePartRef' LowerBound='367.136' HigherBound='367.189'>
                                                    <om:Property Name='MessageRef' Value='SalesforceQueryApplicationInfoResponseMsg' />
                                                    <om:Property Name='PartRef' Value='MessagePart' />
                                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                                    <om:Property Name='Name' Value='MessagePartReference_13' />
                                                    <om:Property Name='Signal' Value='False' />
                                                </om:Element>
                                            </om:Element>
                                            <om:Element Type='MessageAssignment' OID='c92cc31a-432b-47e2-9b90-11ee09a0250f' ParentLink='ComplexStatement_Statement' LowerBound='368.1' HigherBound='383.1'>
                                                <om:Property Name='Expression' Value='//Extracting Applicant SFID&#xD;&#xA;ApplicantSFIDXpath = System.String.Format(&quot;string(/*[local-name()=&apos;Response&apos; and namespace-uri()=&apos;http://SBA.gov/DLAPDocumentList/Application_Info__c&apos;]/*[local-name()=&apos;row&apos; and namespace-uri()=&apos;http://SBA.gov/DLAPDocumentList/Application_Info__c&apos;][{0}]/*[local-name()=&apos;ApplicantId&apos; and namespace-uri()=&apos;http://SBA.gov/DLAPDocumentList/Application_Info__c&apos;])&quot;,LoopCount);&#xD;&#xA;ApplicantSFID = (System.String)xpath(SalesforceQueryApplicationInfoResponseMsg.MessagePart, ApplicantSFIDXpath);&#xD;&#xA;&#xD;&#xA;//Exracting Applicant External Id&#xD;&#xA;ApplicantNameXpath = System.String.Format(&quot;string(/*[local-name()=&apos;Response&apos; and namespace-uri()=&apos;http://SBA.gov/DLAPDocumentList/Application_Info__c&apos;]/*[local-name()=&apos;row&apos; and namespace-uri()=&apos;http://SBA.gov/DLAPDocumentList/Application_Info__c&apos;][{0}]/*[local-name()=&apos;ApplicantExternalID&apos; and namespace-uri()=&apos;http://SBA.gov/DLAPDocumentList/Application_Info__c&apos;])&quot;,LoopCount);&#xD;&#xA;ApplicantName = (System.String)xpath(SalesforceQueryApplicationInfoResponseMsg.MessagePart, ApplicantNameXpath);&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;//Injecting SOQL Query&#xD;&#xA;DOCUMENT_SOQL_QUERY = @&quot;SELECT ContentDocument.LatestPublishedVersion.DLAP_Document_Type__c,ContentDocument.LatestPublishedVersion.Title,ContentDocument.LatestPublishedVersion.Id,ContentDocument.LatestPublishedVersion.Description,ContentDocument.LatestPublishedVersion.Document_Validity__c,ContentDocument.LatestPublishedVersion.CreatedDate,ContentDocument.LatestPublishedVersion.Document_Type__c FROM ContentDocumentLink WHERE LinkedEntityId =&quot;+&quot;&apos;&quot;+ApplicantSFID+&quot;&apos; AND ContentDocument.LatestPublishedVersion.DLAPUserID__c =&quot;+&quot;&apos;&quot;+DLAPUserID+&quot;&apos;&quot;; &#xD;&#xA;RestDocumentDetailsRe"+
@"questMsg(DLAPDocumentListSalesforceDefinition.Rest_Schemas.SF_DOCUMENT_QUERY) = DOCUMENT_SOQL_QUERY; &#xD;&#xA;&#xD;&#xA;' />
                                                <om:Property Name='ReportToAnalyst' Value='False' />
                                                <om:Property Name='Name' Value='Make SOQL' />
                                                <om:Property Name='Signal' Value='True' />
                                            </om:Element>
                                            <om:Element Type='MessageRef' OID='0cfc550d-bf8b-47bb-9504-4785139fe6d9' ParentLink='Construct_MessageRef' LowerBound='364.39' HigherBound='364.68'>
                                                <om:Property Name='Ref' Value='RestDocumentDetailsRequestMsg' />
                                                <om:Property Name='ReportToAnalyst' Value='True' />
                                                <om:Property Name='Signal' Value='False' />
                                            </om:Element>
                                        </om:Element>
                                        <om:Element Type='Send' OID='263f2660-59d3-499d-b506-5774a8e6c571' ParentLink='ComplexStatement_Statement' LowerBound='384.1' HigherBound='386.1'>
                                            <om:Property Name='PortName' Value='RestQueryApplicantandApplicationDocumentsPort' />
                                            <om:Property Name='MessageName' Value='RestDocumentDetailsRequestMsg' />
                                            <om:Property Name='OperationName' Value='Operation' />
                                            <om:Property Name='OperationMessageName' Value='Request' />
                                            <om:Property Name='ReportToAnalyst' Value='True' />
                                            <om:Property Name='Name' Value='Send Rest Document Request' />
                                            <om:Property Name='Signal' Value='True' />
                                        </om:Element>
                                        <om:Element Type='Receive' OID='e520e8ce-21d3-487e-9aff-526f9830f806' ParentLink='ComplexStatement_Statement' LowerBound='386.1' HigherBound='388.1'>
                                            <om:Property Name='Activate' Value='False' />
                                            <om:Property Name='PortName' Value='RestQueryApplicantandApplicationDocumentsPort' />
                                            <om:Property Name='MessageName' Value='RestDocumentDetailsResponseMsg' />
                                            <om:Property Name='OperationName' Value='Operation' />
                                            <om:Property Name='OperationMessageName' Value='Response' />
                                            <om:Property Name='ReportToAnalyst' Value='True' />
                                            <om:Property Name='Name' Value='Receive Rest Document Response' />
                                            <om:Property Name='Signal' Value='True' />
                                        </om:Element>
                                        <om:Element Type='VariableAssignment' OID='71014f46-c75b-4732-a469-8bd9c4e6e40f' ParentLink='ComplexStatement_Statement' LowerBound='388.1' HigherBound='409.1'>
                                            <om:Property Name='Expression' Value='&#xD;&#xA;//Loop Increment&#xD;&#xA;LoopCount = LoopCount + 1;&#xD;&#xA;&#xD;&#xA;//Aggregate multiple applicants douments Info into single message&#xD;&#xA;&#xD;&#xA;TempDoc = RestDocumentDetailsResponseMsg.MessagePart;&#xD;&#xA;&#xD;&#xA;ApplicantDocCount = System.Convert.ToInt32(xpath(RestDocumentDetailsResponseMsg.MessagePart, &quot;count(/*[local-name()=&apos;QueryResult&apos; and namespace-uri()=&apos;http://SBA.gov/REST/AppDocumentList&apos;])&quot;));&#xD;&#xA;if(ApplicantDocCount&gt;0)&#xD;&#xA;{&#xD;&#xA;&#xD;&#xA;StrTempEmpty = StrTempEmpty + @&quot;&lt;Responses&gt;&quot;+TempDoc.InnerXml+&quot;&lt;DocumentApplicantId&gt;&quot;+ApplicantName+&quot;&lt;/DocumentApplicantId&gt;&lt;/Responses&gt;&quot;;&#xD;&#xA;}&#xD;&#xA;else{StrTempEmpty = StrTempEmpty;}&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;' />
                                            <om:Property Name='ReportToAnalyst' Value='True' />
                                            <om:Property Name='Name' Value='Aggregate Multipe Applicants Documents Info' />
                                            <om:Property Name='Signal' Value='True' />
                                        </om:Element>
                                    </om:Element>
                                    <om:Element Type='Construct' OID='36b07477-0e85-4a5f-8102-aaabfa5d760c' ParentLink='ComplexStatement_Statement' LowerBound='410.1' HigherBound='426.1'>
                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                        <om:Property Name='Name' Value='Construct Appplicant Document Response Msg' />
                                        <om:Property Name='Signal' Value='True' />
                                        <om:Element Type='MessageRef' OID='67ae039a-0125-429b-a3e9-ca35a1fc3a35' ParentLink='Construct_MessageRef' LowerBound='411.35' HigherBound='411.73'>
                                            <om:Property Name='Ref' Value='RestMultipleDocumentDetailsResponseMsg' />
                                            <om:Property Name='ReportToAnalyst' Value='True' />
                                            <om:Property Name='Signal' Value='False' />
                                        </om:Element>
                                        <om:Element Type='MessageAssignment' OID='c8df7609-b3d0-46d7-b804-eac30b771d42' ParentLink='ComplexStatement_Statement' LowerBound='413.1' HigherBound='425.1'>
                                            <om:Property Name='Expression' Value='&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;ApplicationStrTempEmpty = @&quot;&lt;AppDocumentList xmlns=&apos;http://SBA.gov/DLAP/DocumentList&apos;&gt;&quot;+StrTempEmpty+&quot;&lt;/AppDocumentList&gt;&quot;;&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;//Load batched message&#xD;&#xA;&#xD;&#xA;TempApplicationDocList.LoadXml(ApplicationStrTempEmpty);&#xD;&#xA;&#xD;&#xA;RestMultipleDocumentDetailsResponseMsg.MessagePart = TempApplicationDocList;' />
                                            <om:Property Name='ReportToAnalyst' Value='False' />
                                            <om:Property Name='Name' Value='Make Multiple Document Response Msg' />
                                            <om:Property Name='Signal' Value='False' />
                                        </om:Element>
                                    </om:Element>
                                </om:Element>
                                <om:Element Type='Task' OID='1b8bf771-9a2d-4367-9744-c534f597b445' ParentLink='ComplexStatement_Statement' LowerBound='426.1' HigherBound='443.1'>
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='Application Document Processing' />
                                    <om:Property Name='Signal' Value='True' />
                                    <om:Element Type='Construct' OID='13501ce2-919d-4582-9271-708703cfc462' ParentLink='ComplexStatement_Statement' LowerBound='426.1' HigherBound='439.1'>
                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                        <om:Property Name='Name' Value='Construct Rest Application Document Request Msg' />
                                        <om:Property Name='Signal' Value='True' />
                                        <om:Element Type='MessageRef' OID='216a32df-2a9b-4f56-b327-e8582a4b4ef4' ParentLink='Construct_MessageRef' LowerBound='427.35' HigherBound='427.64'>
                                            <om:Property Name='Ref' Value='RestDocumentDetailsRequestMsg' />
                                            <om:Property Name='ReportToAnalyst' Value='True' />
                                            <om:Property Name='Signal' Value='False' />
                                        </om:Element>
                                        <om:Element Type='Transform' OID='ccd1f3b2-d8ee-4b15-b222-74c4fc10a830' ParentLink='ComplexStatement_Statement' LowerBound='429.1' HigherBound='431.1'>
                                            <om:Property Name='ClassName' Value='DLAPDocumentListLogic.MakeRestDocumentRequest' />
                                            <om:Property Name='ReportToAnalyst' Value='True' />
                                            <om:Property Name='Name' Value='Make Rest Application Document Request' />
                                            <om:Property Name='Signal' Value='True' />
                                            <om:Element Type='MessagePartRef' OID='6f1fa583-7582-4798-ae31-6cffefb88366' ParentLink='Transform_OutputMessagePartRef' LowerBound='430.40' HigherBound='430.81'>
                                                <om:Property Name='MessageRef' Value='RestDocumentDetailsRequestMsg' />
                                                <om:Property Name='PartRef' Value='MessagePart' />
                                                <om:Property Name='ReportToAnalyst' Value='True' />
                                                <om:Property Name='Name' Value='MessagePartReference_17' />
                                                <om:Property Name='Signal' Value='False' />
                                            </om:Element>
                                            <om:Element Type='MessagePartRef' OID='d5821b38-f848-4f65-a89e-188b6380f7a7' ParentLink='Transform_InputMessagePartRef' LowerBound='430.132' HigherBound='430.185'>
                                                <om:Property Name='MessageRef' Value='SalesforceQueryApplicationInfoResponseMsg' />
                                                <om:Property Name='PartRef' Value='MessagePart' />
                                                <om:Property Name='ReportToAnalyst' Value='True' />
                                                <om:Property Name='Name' Value='MessagePartReference_16' />
                                                <om:Property Name='Signal' Value='False' />
                                            </om:Element>
                                        </om:Element>
                                        <om:Element Type='MessageAssignment' OID='c369d0dd-2123-4e7e-94e4-c6671efdbf36' ParentLink='ComplexStatement_Statement' LowerBound='431.1' HigherBound='438.1'>
                                            <om:Property Name='Expression' Value='&#xD;&#xA;&#xD;&#xA;//Injecting SOQL Query&#xD;&#xA;DOCUMENT_SOQL_QUERY = @&quot;SELECT ContentDocument.LatestPublishedVersion.DLAP_Document_Type__c,ContentDocument.LatestPublishedVersion.Title,ContentDocument.LatestPublishedVersion.Id,ContentDocument.LatestPublishedVersion.Description,ContentDocument.LatestPublishedVersion.Document_Validity__c,ContentDocument.LatestPublishedVersion.CreatedDate,ContentDocument.LatestPublishedVersion.Document_Type__c FROM ContentDocumentLink WHERE LinkedEntityId =&quot;+&quot;&apos;&quot;+ApplicationSFID+&quot;&apos; AND ContentDocument.LatestPublishedVersion.DLAPUserID__c =&quot;+&quot;&apos;&quot;+DLAPUserID+&quot;&apos;&quot;; &#xD;&#xA;RestDocumentDetailsRequestMsg(DLAPDocumentListSalesforceDefinition.Rest_Schemas.SF_DOCUMENT_QUERY) = DOCUMENT_SOQL_QUERY; &#xD;&#xA;&#xD;&#xA;' />
                                            <om:Property Name='ReportToAnalyst' Value='False' />
                                            <om:Property Name='Name' Value='Make SOQL' />
                                            <om:Property Name='Signal' Value='True' />
                                        </om:Element>
                                    </om:Element>
                                    <om:Element Type='Send' OID='9a47ce8e-47d3-4e22-b7db-be88d8195348' ParentLink='ComplexStatement_Statement' LowerBound='439.1' HigherBound='441.1'>
                                        <om:Property Name='PortName' Value='RestQueryApplicantandApplicationDocumentsPort' />
                                        <om:Property Name='MessageName' Value='RestDocumentDetailsRequestMsg' />
                                        <om:Property Name='OperationName' Value='Operation' />
                                        <om:Property Name='OperationMessageName' Value='Request' />
                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                        <om:Property Name='Name' Value='Send Rest Document Request' />
                                        <om:Property Name='Signal' Value='True' />
                                    </om:Element>
                                    <om:Element Type='Receive' OID='f9b6f9b7-5a99-4b7c-ba86-e3a55d2d919f' ParentLink='ComplexStatement_Statement' LowerBound='441.1' HigherBound='443.1'>
                                        <om:Property Name='Activate' Value='False' />
                                        <om:Property Name='PortName' Value='RestQueryApplicantandApplicationDocumentsPort' />
                                        <om:Property Name='MessageName' Value='RestDocumentDetailsResponseMsg' />
                                        <om:Property Name='OperationName' Value='Operation' />
                                        <om:Property Name='OperationMessageName' Value='Response' />
                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                        <om:Property Name='Name' Value='Receive Rest Document Response' />
                                        <om:Property Name='Signal' Value='True' />
                                    </om:Element>
                                </om:Element>
                                <om:Element Type='Construct' OID='6d2712b5-2af5-4536-a313-80e81760193c' ParentLink='ComplexStatement_Statement' LowerBound='443.1' HigherBound='449.1'>
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='Construct Document List Response Msg' />
                                    <om:Property Name='Signal' Value='True' />
                                    <om:Element Type='Transform' OID='90fed697-cd32-4991-b327-649282695f09' ParentLink='ComplexStatement_Statement' LowerBound='446.1' HigherBound='448.1'>
                                        <om:Property Name='ClassName' Value='DocumentListLogic.MakeDocumentListResponse' />
                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                        <om:Property Name='Name' Value='Make DocumentList Response' />
                                        <om:Property Name='Signal' Value='True' />
                                        <om:Element Type='MessagePartRef' OID='fadeb5d6-01a7-450b-9e76-cb49c593d950' ParentLink='Transform_OutputMessagePartRef' LowerBound='447.40' HigherBound='447.75'>
                                            <om:Property Name='MessageRef' Value='DocumentListResponseMsg' />
                                            <om:Property Name='PartRef' Value='MessagePart' />
                                            <om:Property Name='ReportToAnalyst' Value='True' />
                                            <om:Property Name='Name' Value='MessagePartReference_6' />
                                            <om:Property Name='Signal' Value='False' />
                                        </om:Element>
                                        <om:Element Type='MessagePartRef' OID='9f0e2a05-7cba-4728-bcf0-1484b864155b' ParentLink='Transform_InputMessagePartRef' LowerBound='447.123' HigherBound='447.173'>
                                            <om:Property Name='MessageRef' Value='RestMultipleDocumentDetailsResponseMsg' />
                                            <om:Property Name='PartRef' Value='MessagePart' />
                                            <om:Property Name='ReportToAnalyst' Value='True' />
                                            <om:Property Name='Name' Value='MessagePartReference_3' />
                                            <om:Property Name='Signal' Value='False' />
                                        </om:Element>
                                        <om:Element Type='MessagePartRef' OID='d6549a08-201f-40c3-bd4e-a3741752250f' ParentLink='Transform_InputMessagePartRef' LowerBound='447.175' HigherBound='447.217'>
                                            <om:Property Name='MessageRef' Value='RestDocumentDetailsResponseMsg' />
                                            <om:Property Name='PartRef' Value='MessagePart' />
                                            <om:Property Name='ReportToAnalyst' Value='True' />
                                            <om:Property Name='Name' Value='MessagePartReference_4' />
                                            <om:Property Name='Signal' Value='False' />
                                        </om:Element>
                                        <om:Element Type='MessagePartRef' OID='3e6586ae-b8fd-43e5-90ef-ffd840507a10' ParentLink='Transform_InputMessagePartRef' LowerBound='447.219' HigherBound='447.272'>
                                            <om:Property Name='MessageRef' Value='SalesforceQueryApplicationInfoResponseMsg' />
                                            <om:Property Name='PartRef' Value='MessagePart' />
                                            <om:Property Name='ReportToAnalyst' Value='True' />
                                            <om:Property Name='Name' Value='MessagePartReference_5' />
                                            <om:Property Name='Signal' Value='False' />
                                        </om:Element>
                                        <om:Element Type='MessagePartRef' OID='337215ea-7f23-486d-b641-f4568e1f56e9' ParentLink='Transform_InputMessagePartRef' LowerBound='447.274' HigherBound='447.325'>
                                            <om:Property Name='MessageRef' Value='SalesforceQueryChecklistItemResponseMsg' />
                                            <om:Property Name='PartRef' Value='MessagePart' />
                                            <om:Property Name='ReportToAnalyst' Value='True' />
                                            <om:Property Name='Name' Value='MessagePartReference_7' />
                                            <om:Property Name='Signal' Value='False' />
                                        </om:Element>
                                        <om:Element Type='MessagePartRef' OID='f654b77f-4eee-40c3-91a3-39f7fd7f7457' ParentLink='Transform_InputMessagePartRef' LowerBound='447.327' HigherBound='447.390'>
                                            <om:Property Name='MessageRef' Value='RestMultipleChecklistItemDocumentDetailsResponseMsg' />
                                            <om:Property Name='PartRef' Value='MessagePart' />
                                            <om:Property Name='ReportToAnalyst' Value='True' />
                                            <om:Property Name='Name' Value='MessagePartReference_12' />
                                            <om:Property Name='Signal' Value='False' />
                                        </om:Element>
                                    </om:Element>
                                    <om:Element Type='MessageRef' OID='8d574427-d2f2-47f4-921d-28079463e4e8' ParentLink='Construct_MessageRef' LowerBound='444.35' HigherBound='444.58'>
                                        <om:Property Name='Ref' Value='DocumentListResponseMsg' />
                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                        <om:Property Name='Signal' Value='False' />
                                    </om:Element>
                                </om:Element>
                            </om:Element>
                            <om:Element Type='DecisionBranch' OID='72703219-3e4f-4471-92f2-356234cebfa8' ParentLink='ReallyComplexStatement_Branch'>
                                <om:Property Name='IsGhostBranch' Value='True' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Else' />
                                <om:Property Name='Signal' Value='False' />
                                <om:Element Type='Construct' OID='98d57495-1f9b-4eff-8b86-ae20189197f1' ParentLink='ComplexStatement_Statement' LowerBound='452.1' HigherBound='458.1'>
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='Construct Document List Error Response Msg' />
                                    <om:Property Name='Signal' Value='True' />
                                    <om:Element Type='Transform' OID='ff141df0-b21b-453e-b568-329dd1caafd9' ParentLink='ComplexStatement_Statement' LowerBound='455.1' HigherBound='457.1'>
                                        <om:Property Name='ClassName' Value='DocumentListLogic.MakeDocumentListErrorResponse' />
                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                        <om:Property Name='Name' Value='Make DocumentList Error Response Msg' />
                                        <om:Property Name='Signal' Value='False' />
                                        <om:Element Type='MessagePartRef' OID='18effa2c-0597-47d1-a0aa-cafebe95b283' ParentLink='Transform_InputMessagePartRef' LowerBound='456.128' HigherBound='456.162'>
                                            <om:Property Name='MessageRef' Value='DocumentListRequestMsg' />
                                            <om:Property Name='PartRef' Value='MessagePart' />
                                            <om:Property Name='ReportToAnalyst' Value='True' />
                                            <om:Property Name='Name' Value='MessagePartReference_8' />
                                            <om:Property Name='Signal' Value='False' />
                                        </om:Element>
                                        <om:Element Type='MessagePartRef' OID='bae9f0f0-0c54-4a31-8080-a5e19e6051e3' ParentLink='Transform_OutputMessagePartRef' LowerBound='456.40' HigherBound='456.75'>
                                            <om:Property Name='MessageRef' Value='DocumentListResponseMsg' />
                                            <om:Property Name='PartRef' Value='MessagePart' />
                                            <om:Property Name='ReportToAnalyst' Value='True' />
                                            <om:Property Name='Name' Value='MessagePartReference_9' />
                                            <om:Property Name='Signal' Value='False' />
                                        </om:Element>
                                    </om:Element>
                                    <om:Element Type='MessageRef' OID='f4807b82-02f3-400a-a308-b711b68008a8' ParentLink='Construct_MessageRef' LowerBound='453.35' HigherBound='453.58'>
                                        <om:Property Name='Ref' Value='DocumentListResponseMsg' />
                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                        <om:Property Name='Signal' Value='False' />
                                    </om:Element>
                                </om:Element>
                            </om:Element>
                        </om:Element>
                    </om:Element>
                    <om:Element Type='Catch' OID='87cf9771-2732-4e9a-bf17-e3357f1a9c40' ParentLink='Scope_Catch' LowerBound='462.1' HigherBound='482.1'>
                        <om:Property Name='ExceptionName' Value='Ex' />
                        <om:Property Name='ExceptionType' Value='System.Exception' />
                        <om:Property Name='IsFaultMessage' Value='False' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='System Exception' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='Construct' OID='8b269fa2-3dce-4dec-a260-3f651fc15139' ParentLink='Catch_Statement' LowerBound='465.1' HigherBound='477.1'>
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Construct Document List Fault Response Msg' />
                            <om:Property Name='Signal' Value='True' />
                            <om:Element Type='MessageAssignment' OID='a84275e1-99ef-4c73-afa8-838fc1ee05d9' ParentLink='ComplexStatement_Statement' LowerBound='468.1' HigherBound='476.1'>
                                <om:Property Name='Expression' Value='TempFaultResponse = new System.Xml.XmlDocument();&#xD;&#xA;&#xD;&#xA;TempFaultResponse.LoadXml(@&quot;&lt;ns0:Fault xmlns:ns0=&apos;http://SBA.gov/DLAPDocumentList/DocumentListFault&apos;&gt;&lt;FaultString&gt;Exception:Internal Error&lt;/FaultString&gt;&lt;FaultCode&gt;An error occurred while processing the Document Retrieval&lt;/FaultCode&gt;&lt;/ns0:Fault&gt;&quot;);&#xD;&#xA;&#xD;&#xA;DocumentListFaultResponseMsg.MessagePart = TempFaultResponse;&#xD;&#xA;&#xD;&#xA;System.Diagnostics.EventLog.WriteEntry(&quot;DLAP Document List Exception&quot;,Ex.Message);' />
                                <om:Property Name='ReportToAnalyst' Value='False' />
                                <om:Property Name='Name' Value='Document List Fault Response' />
                                <om:Property Name='Signal' Value='True' />
                            </om:Element>
                            <om:Element Type='MessageRef' OID='5ae70ef2-72e8-40eb-bf09-fab5359a6098' ParentLink='Construct_MessageRef' LowerBound='466.35' HigherBound='466.63'>
                                <om:Property Name='Ref' Value='DocumentListFaultResponseMsg' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                        </om:Element>
                        <om:Element Type='Send' OID='e3b346c1-6a2c-4c96-8b56-581aba0241fb' ParentLink='Catch_Statement' LowerBound='477.1' HigherBound='479.1'>
                            <om:Property Name='PortName' Value='DocumentListPort' />
                            <om:Property Name='MessageName' Value='DocumentListFaultResponseMsg' />
                            <om:Property Name='OperationName' Value='Operation' />
                            <om:Property Name='OperationMessageName' Value='Fault' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Send Fault Response' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                        <om:Element Type='Terminate' OID='e78564f7-8ab3-49af-bbd0-54f4dad13a0b' ParentLink='Catch_Statement' LowerBound='479.1' HigherBound='481.1'>
                            <om:Property Name='ErrorMessage' Value='&quot;An error occurred while processing the DLAP Document List&quot;;' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Terminate' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                    </om:Element>
                </om:Element>
                <om:Element Type='Send' OID='8bae0a73-0994-4ce1-ab42-b6ff905c5507' ParentLink='ServiceBody_Statement' LowerBound='484.1' HigherBound='486.1'>
                    <om:Property Name='PortName' Value='DocumentListPort' />
                    <om:Property Name='MessageName' Value='DocumentListResponseMsg' />
                    <om:Property Name='OperationName' Value='Operation' />
                    <om:Property Name='OperationMessageName' Value='Response' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Send DocumentList Response' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='b6137c3e-5cef-4e02-a432-289089b5c684' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='115.1' HigherBound='117.1'>
                <om:Property Name='PortModifier' Value='Implements' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='DLAPDocument.DocumentListPortType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='DocumentListPort' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='ec7300e6-8a50-4e1e-9a04-8873c17a8b26' ParentLink='PortDeclaration_CLRAttribute' LowerBound='115.1' HigherBound='116.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='5318f6f9-8487-4330-9926-770a8360becb' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='117.1' HigherBound='119.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='35' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='DLAPDocument.RestQueryApplicationInfoPortType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='RestQueryApplicationInfoPort' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='56379247-173e-46be-a756-441bdff0f6fb' ParentLink='PortDeclaration_CLRAttribute' LowerBound='117.1' HigherBound='118.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='96540f8e-e257-457c-b9a1-58b2f89dfe46' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='119.1' HigherBound='121.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='127' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='DLAPDocument.RestQueryClosingDocumentsPortType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='RestQueryClosingDocumentsPort' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='LogicalBindingAttribute' OID='4a840268-4f37-4404-b766-8c8e73a142a0' ParentLink='PortDeclaration_CLRAttribute' LowerBound='119.1' HigherBound='120.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='39f9ae50-f588-433e-a5c0-ac57c32041ae' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='121.1' HigherBound='123.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='199' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='DLAPDocument.RestQueryApplicantandApplicationDocumentsPortType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='RestQueryApplicantandApplicationDocumentsPort' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='LogicalBindingAttribute' OID='193a42c1-d190-4940-b917-abb6e0ff7794' ParentLink='PortDeclaration_CLRAttribute' LowerBound='121.1' HigherBound='122.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
    </om:Element>
</om:MetaModel>
";

        [System.SerializableAttribute]
        public class __ListLogic_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __ListLogic_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "ListLogic")
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
                ListLogic __svc__ = (ListLogic)_service;
                __ListLogic_root_0 __ctx0__ = (__ListLogic_root_0)(__svc__._stateMgrs[0]);

                if (__svc__.DocumentListPort != null)
                {
                    __svc__.DocumentListPort.Close(this, null);
                    __svc__.DocumentListPort = null;
                }
                if (__svc__.RestQueryApplicantandApplicationDocumentsPort != null)
                {
                    __svc__.RestQueryApplicantandApplicationDocumentsPort.Close(this, null);
                    __svc__.RestQueryApplicantandApplicationDocumentsPort = null;
                }
                if (__svc__.RestQueryApplicationInfoPort != null)
                {
                    __svc__.RestQueryApplicationInfoPort.Close(this, null);
                    __svc__.RestQueryApplicationInfoPort = null;
                }
                if (__svc__.RestQueryClosingDocumentsPort != null)
                {
                    __svc__.RestQueryClosingDocumentsPort.Close(this, null);
                    __svc__.RestQueryClosingDocumentsPort = null;
                }
                base.Finally();
            }

            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper0;
            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper1;
            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper2;
            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper3;
            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper4;
        }


        [System.SerializableAttribute]
        public class __ListLogic_1 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public __ListLogic_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "ListLogic")
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
                ListLogic __svc__ = (ListLogic)_service;
                __ListLogic_1 __ctx1__ = (__ListLogic_1)(__svc__._stateMgrs[1]);

                if (__ctx1__ != null)
                    __ctx1__.__ApplicantSFID = null;
                if (__ctx1__ != null)
                    __ctx1__.__StrTemp = null;
                if (__ctx1__ != null)
                    __ctx1__.__TempDoc = null;
                if (__ctx1__ != null)
                    __ctx1__.__ChecklistItemTempDoc = null;
                if (__ctx1__ != null && __ctx1__.__DocumentListResponseMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__DocumentListResponseMsg);
                    __ctx1__.__DocumentListResponseMsg = null;
                }
                if (__ctx1__ != null && __ctx1__.__DocumentListRequestMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__DocumentListRequestMsg);
                    __ctx1__.__DocumentListRequestMsg = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__TempClosingDocList = null;
                if (__ctx1__ != null)
                    __ctx1__.__ClosingDocStrTempEmpty = null;
                if (__ctx1__ != null)
                    __ctx1__.__ChecklistStrTempEmpty = null;
                if (__ctx1__ != null)
                    __ctx1__.__StrTempEmpty = null;
                if (__ctx1__ != null)
                    __ctx1__.__Status = null;
                if (__ctx1__ != null)
                    __ctx1__.__Stage = null;
                if (__ctx1__ != null)
                    __ctx1__.__Message = null;
                if (__ctx1__ != null)
                    __ctx1__.__SalesForceObjectId = null;
                if (__ctx1__ != null)
                    __ctx1__.__ApplicationNumber = null;
                if (__ctx1__ != null)
                    __ctx1__.__ExMessageTemp = null;
                if (__ctx1__ != null)
                    __ctx1__.__ApplicantSFIDXpath = null;
                if (__ctx1__ != null)
                    __ctx1__.__TempFaultResponse = null;
                if (__ctx1__ != null)
                    __ctx1__.__ApplicationSFID = null;
                if (__ctx1__ != null)
                    __ctx1__.__TempApplicationDocList = null;
                if (__ctx1__ != null)
                    __ctx1__.__SalesForceObjectName = null;
                if (__ctx1__ != null)
                    __ctx1__.__DLAPUserID = null;
                if (__ctx1__ != null)
                    __ctx1__.__ApplicationStrTempEmpty = null;
                if (__ctx1__ != null)
                    __ctx1__.__ApplicationID = null;
                if (__ctx1__ != null)
                    __ctx1__.__ChecklistItemSFIDS = null;
                if (__ctx1__ != null)
                    __ctx1__.__CHECKLISTITEM_SOQL_QUERY = null;
                if (__ctx1__ != null)
                    __ctx1__.__ApplicationNumberList = null;
                if (__ctx1__ != null)
                    __ctx1__.__DOCUMENT_SOQL_QUERY = null;
                if (__ctx1__ != null)
                    __ctx1__.__APPLICATION_INFO_SOQL_QUERY = null;
                if (__ctx1__ != null)
                    __ctx1__.__ApplicantName = null;
                if (__ctx1__ != null)
                    __ctx1__.__DocumentMasterCheckListDesc = null;
                if (__ctx1__ != null)
                    __ctx1__.__ClosingDocChecklistItemStatusxPath = null;
                if (__ctx1__ != null)
                    __ctx1__.__DocumentMasterCheckListName = null;
                if (__ctx1__ != null)
                    __ctx1__.__ChecklistItemClosingDocSFID = null;
                if (__ctx1__ != null)
                    __ctx1__.__ClosingDocApplicantSFIDxpath = null;
                if (__ctx1__ != null)
                    __ctx1__.__ChecklistItemClosingDocSFIDxpath = null;
                if (__ctx1__ != null)
                    __ctx1__.__ApplicationTempDoc = null;
                if (__ctx1__ != null)
                    __ctx1__.__ApplicantNameXpath = null;
                if (__ctx1__ != null)
                    __ctx1__.__ClosingDocApplicantSFID = null;
                if (__ctx1__ != null)
                    __ctx1__.__ClosingDocChecklistItemStatus = null;
                if (__ctx1__ != null)
                    __ctx1__.__DocumentMasterCheckListDescxPath = null;
                if (__ctx1__ != null)
                    __ctx1__.__DocumentMasterCheckListNamexPath = null;
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("DocumentListRequestMsg")]
            internal DocumentListRequestType __DocumentListRequestMsg;
            [Microsoft.XLANGs.Core.UserVariableAttribute("DocumentListResponseMsg")]
            internal DocumentListResponseType __DocumentListResponseMsg;
            [Microsoft.XLANGs.Core.UserVariableAttribute("SalesforceQueryApplicationInfoResponseMsg")]
            internal SalesforceQueryApplicationInfoResponseType __SalesforceQueryApplicationInfoResponseMsg;
            [Microsoft.XLANGs.Core.UserVariableAttribute("DocumentListFaultResponseMsg")]
            internal DocumentListFaultResponseType __DocumentListFaultResponseMsg;
            [Microsoft.XLANGs.Core.UserVariableAttribute("SalesforceQueryChecklistItemResponseMsg")]
            internal SalesforceQueryChecklistItemResponseType __SalesforceQueryChecklistItemResponseMsg;
            [Microsoft.XLANGs.Core.UserVariableAttribute("RestCheckListItemDocumentDetailsRequestMsg")]
            internal RestCheckListItemDocumentDetailsRequestType __RestCheckListItemDocumentDetailsRequestMsg;
            [Microsoft.XLANGs.Core.UserVariableAttribute("RestCheckListItemDocumentDetailsResponseMsg")]
            internal RestCheckListItemDocumentDetailsResponseType __RestCheckListItemDocumentDetailsResponseMsg;
            [Microsoft.XLANGs.Core.UserVariableAttribute("RestDocumentDetailsRequestMsg")]
            internal RestDocumentDetailsRequestType __RestDocumentDetailsRequestMsg;
            [Microsoft.XLANGs.Core.UserVariableAttribute("RestDocumentDetailsResponseMsg")]
            internal RestDocumentDetailsResponseType __RestDocumentDetailsResponseMsg;
            [Microsoft.XLANGs.Core.UserVariableAttribute("RestMultipleChecklistItemDocumentDetailsResponseMsg")]
            internal RestMultipleChecklistItemDocumentDetailsResponseType __RestMultipleChecklistItemDocumentDetailsResponseMsg;
            [Microsoft.XLANGs.Core.UserVariableAttribute("RestMultipleDocumentDetailsResponseMsg")]
            internal RestMultipleDocumentDetailsResponseType __RestMultipleDocumentDetailsResponseMsg;
            [Microsoft.XLANGs.Core.UserVariableAttribute("ChecklistitemClosingDocsSFIDValuesMsg")]
            internal ChecklistitemClosingDocsSFIDValuesType __ChecklistitemClosingDocsSFIDValuesMsg;
            [Microsoft.XLANGs.Core.UserVariableAttribute("RestApplicationInfoRequestMsg")]
            internal RestApplicationInfoRequestType __RestApplicationInfoRequestMsg;
            [Microsoft.XLANGs.Core.UserVariableAttribute("RestApplicationInfoResponseMsg")]
            internal RestApplicationInfoResponseType __RestApplicationInfoResponseMsg;
            [Microsoft.XLANGs.Core.UserVariableAttribute("TempClosingDocList")]
            internal Microsoft.XLANGs.RuntimeTypes.XmlDocumentSerializationProxy __TempClosingDocList;
            [Microsoft.XLANGs.Core.UserVariableAttribute("ClosingDocStrTempEmpty")]
            internal System.String __ClosingDocStrTempEmpty;
            [Microsoft.XLANGs.Core.UserVariableAttribute("ChecklistStrTempEmpty")]
            internal System.String __ChecklistStrTempEmpty;
            [Microsoft.XLANGs.Core.UserVariableAttribute("ChecklistItemTempDoc")]
            internal Microsoft.XLANGs.RuntimeTypes.XmlDocumentSerializationProxy __ChecklistItemTempDoc;
            [Microsoft.XLANGs.Core.UserVariableAttribute("ChecklistItemLoopCount")]
            internal System.Int32 __ChecklistItemLoopCount;
            [Microsoft.XLANGs.Core.UserVariableAttribute("ApplicantCount")]
            internal System.Int32 __ApplicantCount;
            [Microsoft.XLANGs.Core.UserVariableAttribute("LoopCount")]
            internal System.Int32 __LoopCount;
            [Microsoft.XLANGs.Core.UserVariableAttribute("ApplicantSFID")]
            internal System.String __ApplicantSFID;
            [Microsoft.XLANGs.Core.UserVariableAttribute("StrTemp")]
            internal System.Text.StringBuilder __StrTemp;
            [Microsoft.XLANGs.Core.UserVariableAttribute("TempDoc")]
            internal Microsoft.XLANGs.RuntimeTypes.XmlDocumentSerializationProxy __TempDoc;
            [Microsoft.XLANGs.Core.UserVariableAttribute("TempApplicationDocList")]
            internal Microsoft.XLANGs.RuntimeTypes.XmlDocumentSerializationProxy __TempApplicationDocList;
            [Microsoft.XLANGs.Core.UserVariableAttribute("ApplicantSFIDXpath")]
            internal System.String __ApplicantSFIDXpath;
            [Microsoft.XLANGs.Core.UserVariableAttribute("StrTempEmpty")]
            internal System.String __StrTempEmpty;
            [Microsoft.XLANGs.Core.UserVariableAttribute("ApplicationID")]
            internal System.String __ApplicationID;
            [Microsoft.XLANGs.Core.UserVariableAttribute("ApplicationIDStatus")]
            internal System.Boolean __ApplicationIDStatus;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Flag")]
            internal System.Boolean __Flag;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Status")]
            internal System.String __Status;
            [Microsoft.XLANGs.Core.UserVariableAttribute("ApplicationNumber")]
            internal System.String __ApplicationNumber;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Stage")]
            internal System.String __Stage;
            [Microsoft.XLANGs.Core.UserVariableAttribute("SalesForceObjectName")]
            internal System.String __SalesForceObjectName;
            [Microsoft.XLANGs.Core.UserVariableAttribute("SalesForceObjectId")]
            internal System.String __SalesForceObjectId;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Message")]
            internal System.String __Message;
            [Microsoft.XLANGs.Core.UserVariableAttribute("ApplicationSFID")]
            internal System.String __ApplicationSFID;
            [Microsoft.XLANGs.Core.UserVariableAttribute("ExMessageTemp")]
            internal System.String __ExMessageTemp;
            [Microsoft.XLANGs.Core.UserVariableAttribute("TempFaultResponse")]
            internal Microsoft.XLANGs.RuntimeTypes.XmlDocumentSerializationProxy __TempFaultResponse;
            [Microsoft.XLANGs.Core.UserVariableAttribute("DLAPUserID")]
            internal System.String __DLAPUserID;
            [Microsoft.XLANGs.Core.UserVariableAttribute("ApplicationStrTempEmpty")]
            internal System.String __ApplicationStrTempEmpty;
            [Microsoft.XLANGs.Core.UserVariableAttribute("ApplicationTempDoc")]
            internal Microsoft.XLANGs.RuntimeTypes.XmlDocumentSerializationProxy __ApplicationTempDoc;
            [Microsoft.XLANGs.Core.UserVariableAttribute("ApplicantNameXpath")]
            internal System.String __ApplicantNameXpath;
            [Microsoft.XLANGs.Core.UserVariableAttribute("ApplicantName")]
            internal System.String __ApplicantName;
            [Microsoft.XLANGs.Core.UserVariableAttribute("ApplicantDocCount")]
            internal System.Int32 __ApplicantDocCount;
            [Microsoft.XLANGs.Core.UserVariableAttribute("ChecklistItemCount")]
            internal System.Int32 __ChecklistItemCount;
            [Microsoft.XLANGs.Core.UserVariableAttribute("ChecklistItemClosingDocSFIDxpath")]
            internal System.String __ChecklistItemClosingDocSFIDxpath;
            [Microsoft.XLANGs.Core.UserVariableAttribute("ChecklistItemClosingDocSFID")]
            internal System.String __ChecklistItemClosingDocSFID;
            [Microsoft.XLANGs.Core.UserVariableAttribute("ClosingDocApplicantSFIDxpath")]
            internal System.String __ClosingDocApplicantSFIDxpath;
            [Microsoft.XLANGs.Core.UserVariableAttribute("ClosingDocApplicantSFID")]
            internal System.String __ClosingDocApplicantSFID;
            [Microsoft.XLANGs.Core.UserVariableAttribute("ClosingDocChecklistItemStatusxPath")]
            internal System.String __ClosingDocChecklistItemStatusxPath;
            [Microsoft.XLANGs.Core.UserVariableAttribute("ClosingDocChecklistItemStatus")]
            internal System.String __ClosingDocChecklistItemStatus;
            [Microsoft.XLANGs.Core.UserVariableAttribute("DocumentMasterCheckListNamexPath")]
            internal System.String __DocumentMasterCheckListNamexPath;
            [Microsoft.XLANGs.Core.UserVariableAttribute("DocumentMasterCheckListDescxPath")]
            internal System.String __DocumentMasterCheckListDescxPath;
            [Microsoft.XLANGs.Core.UserVariableAttribute("DocumentMasterCheckListDesc")]
            internal System.String __DocumentMasterCheckListDesc;
            [Microsoft.XLANGs.Core.UserVariableAttribute("DocumentMasterCheckListName")]
            internal System.String __DocumentMasterCheckListName;
            [Microsoft.XLANGs.Core.UserVariableAttribute("ChecklistItemSFIDS")]
            internal System.String __ChecklistItemSFIDS;
            [Microsoft.XLANGs.Core.UserVariableAttribute("CHECKLISTITEM_SOQL_QUERY")]
            internal System.String __CHECKLISTITEM_SOQL_QUERY;
            [Microsoft.XLANGs.Core.UserVariableAttribute("DOCUMENT_SOQL_QUERY")]
            internal System.String __DOCUMENT_SOQL_QUERY;
            [Microsoft.XLANGs.Core.UserVariableAttribute("ApplicationNumberList")]
            internal System.String __ApplicationNumberList;
            [Microsoft.XLANGs.Core.UserVariableAttribute("APPLICATION_INFO_SOQL_QUERY")]
            internal System.String __APPLICATION_INFO_SOQL_QUERY;
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
                    if ((__fault__ == null) && (__exv__ is System.Exception))
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
                ListLogic __svc__ = (ListLogic)_service;
                ____scope35_2 __ctx2__ = (____scope35_2)(__svc__._stateMgrs[2]);
                __ListLogic_1 __ctx1__ = (__ListLogic_1)(__svc__._stateMgrs[1]);
                __ListLogic_root_0 __ctx0__ = (__ListLogic_root_0)(__svc__._stateMgrs[0]);

                if (__ctx1__ != null && __ctx1__.__ChecklistitemClosingDocsSFIDValuesMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__ChecklistitemClosingDocsSFIDValuesMsg);
                    __ctx1__.__ChecklistitemClosingDocsSFIDValuesMsg = null;
                }
                if (__ctx1__ != null && __ctx1__.__DocumentListFaultResponseMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__DocumentListFaultResponseMsg);
                    __ctx1__.__DocumentListFaultResponseMsg = null;
                }
                if (__ctx1__ != null && __ctx1__.__RestCheckListItemDocumentDetailsRequestMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__RestCheckListItemDocumentDetailsRequestMsg);
                    __ctx1__.__RestCheckListItemDocumentDetailsRequestMsg = null;
                }
                if (__ctx1__ != null && __ctx1__.__RestCheckListItemDocumentDetailsResponseMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__RestCheckListItemDocumentDetailsResponseMsg);
                    __ctx1__.__RestCheckListItemDocumentDetailsResponseMsg = null;
                }
                if (__ctx1__ != null && __ctx1__.__SalesforceQueryApplicationInfoResponseMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__SalesforceQueryApplicationInfoResponseMsg);
                    __ctx1__.__SalesforceQueryApplicationInfoResponseMsg = null;
                }
                if (__ctx1__ != null && __ctx1__.__SalesforceQueryChecklistItemResponseMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__SalesforceQueryChecklistItemResponseMsg);
                    __ctx1__.__SalesforceQueryChecklistItemResponseMsg = null;
                }
                if (__ctx1__ != null && __ctx1__.__RestDocumentDetailsResponseMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__RestDocumentDetailsResponseMsg);
                    __ctx1__.__RestDocumentDetailsResponseMsg = null;
                }
                if (__ctx1__ != null && __ctx1__.__RestMultipleDocumentDetailsResponseMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__RestMultipleDocumentDetailsResponseMsg);
                    __ctx1__.__RestMultipleDocumentDetailsResponseMsg = null;
                }
                if (__ctx1__ != null && __ctx1__.__RestApplicationInfoRequestMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__RestApplicationInfoRequestMsg);
                    __ctx1__.__RestApplicationInfoRequestMsg = null;
                }
                if (__ctx1__ != null && __ctx1__.__RestDocumentDetailsRequestMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__RestDocumentDetailsRequestMsg);
                    __ctx1__.__RestDocumentDetailsRequestMsg = null;
                }
                if (__ctx1__ != null && __ctx1__.__RestMultipleChecklistItemDocumentDetailsResponseMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__RestMultipleChecklistItemDocumentDetailsResponseMsg);
                    __ctx1__.__RestMultipleChecklistItemDocumentDetailsResponseMsg = null;
                }
                if (__ctx1__ != null && __ctx1__.__RestApplicationInfoResponseMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__RestApplicationInfoResponseMsg);
                    __ctx1__.__RestApplicationInfoResponseMsg = null;
                }
                if (__ctx0__ != null && __ctx0__.__subWrapper4 != null)
                {
                    __ctx0__.__subWrapper4.Destroy(__svc__, __ctx0__);
                    __ctx0__.__subWrapper4 = null;
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
                if (__ctx0__ != null && __ctx0__.__subWrapper3 != null)
                {
                    __ctx0__.__subWrapper3.Destroy(__svc__, __ctx0__);
                    __ctx0__.__subWrapper3 = null;
                }
                if (__ctx2__ != null)
                    __ctx2__.__Ex_0 = null;
                base.Finally();
            }

            internal object __exv__;
            internal System.Exception __Ex_0
            {
                get { return (System.Exception)__exv__; }
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
        [Microsoft.XLANGs.Core.UserVariableAttribute("DocumentListPort")]
        internal DocumentListPortType DocumentListPort;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("RestQueryApplicationInfoPort")]
        internal RestQueryApplicationInfoPortType RestQueryApplicationInfoPort;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("RestQueryClosingDocumentsPort")]
        internal RestQueryClosingDocumentsPortType RestQueryClosingDocumentsPort;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("RestQueryApplicantandApplicationDocumentsPort")]
        internal RestQueryApplicantandApplicationDocumentsPortType RestQueryApplicantandApplicationDocumentsPort;

        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {DocumentListPortType.Operation},
                                               typeof(ListLogic).GetField("DocumentListPort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.implements,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(ListLogic), "DocumentListPort"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {RestQueryApplicationInfoPortType.Operation},
                                               typeof(ListLogic).GetField("RestQueryApplicationInfoPort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(ListLogic), "RestQueryApplicationInfoPort"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {RestQueryClosingDocumentsPortType.Operation},
                                               typeof(ListLogic).GetField("RestQueryClosingDocumentsPort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(ListLogic), "RestQueryClosingDocumentsPort"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {RestQueryApplicantandApplicationDocumentsPortType.Operation},
                                               typeof(ListLogic).GetField("RestQueryApplicantandApplicationDocumentsPort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(ListLogic), "RestQueryApplicantandApplicationDocumentsPort"),
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
                h[_portInfo[3].Name] = _portInfo[3];
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

        public static object[] StaticSubscriptionsInformation {
            get {
                return new object[1]{
                     new object[5] { _portInfo[0], 0, null , -1, true }
                };
            }
        }

        public static Microsoft.XLANGs.RuntimeTypes.Location[] __eventLocations = new Microsoft.XLANGs.RuntimeTypes.Location[] {
            new Microsoft.XLANGs.RuntimeTypes.Location(0, "00000000-0000-0000-0000-000000000000", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "2d3f5d4a-ab0e-4320-846b-34340ef83643", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "2d3f5d4a-ab0e-4320-846b-34340ef83643", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "00000000-0000-0000-0000-000000000000", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "98f222a9-ffe5-4235-9744-a85f9cb79122", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "00000000-0000-0000-0000-000000000000", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(6, "8f83ea7f-a80c-46d0-8851-c0c131d73101", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(7, "8f83ea7f-a80c-46d0-8851-c0c131d73101", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(8, "772a9197-1db1-4c5c-b84e-c8b655ecf94b", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(9, "772a9197-1db1-4c5c-b84e-c8b655ecf94b", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(10, "3c1a3fcf-01ed-49bf-a234-e95854cb082f", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(11, "3c1a3fcf-01ed-49bf-a234-e95854cb082f", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(12, "098be654-5f03-44b9-bbab-06d1a136e7cd", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(13, "098be654-5f03-44b9-bbab-06d1a136e7cd", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(14, "a1e14e43-2a08-4237-a6ef-257a424f1752", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(15, "a1e14e43-2a08-4237-a6ef-257a424f1752", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(16, "00000000-0000-0000-0000-000000000000", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(17, "8d5278d0-4552-488f-9843-66f61001de5a", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(18, "8e45db39-6552-4089-aad7-a7586e8fc97d", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(19, "8e45db39-6552-4089-aad7-a7586e8fc97d", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(20, "db93f657-6ff5-45ed-86db-1be111c8ca4e", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(21, "db93f657-6ff5-45ed-86db-1be111c8ca4e", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(22, "81e05aee-f6ad-44e6-bb67-1db0809553ef", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(23, "81e05aee-f6ad-44e6-bb67-1db0809553ef", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(24, "25c6beb5-4278-4f62-adee-cd6d0302170a", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(25, "25c6beb5-4278-4f62-adee-cd6d0302170a", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(26, "b2276229-b41c-4d3d-9e54-954c3a92895d", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(27, "c7f17b3c-dac7-4bf1-9217-61e52b7340f2", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(28, "c7f17b3c-dac7-4bf1-9217-61e52b7340f2", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(29, "6a91403d-7712-46ec-b96c-1112d8ac960c", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(30, "6a91403d-7712-46ec-b96c-1112d8ac960c", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(31, "83f4e829-b53e-4497-a3ce-f27c36fa752a", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(32, "83f4e829-b53e-4497-a3ce-f27c36fa752a", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(33, "4919eaec-68f9-429d-97ce-35b3a64194c1", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(34, "4919eaec-68f9-429d-97ce-35b3a64194c1", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(35, "b2276229-b41c-4d3d-9e54-954c3a92895d", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(36, "120bc076-e250-42c0-a144-1c094cebd535", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(37, "120bc076-e250-42c0-a144-1c094cebd535", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(38, "38b29dd6-3a59-4b49-b8f5-68c75cb8e7dc", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(39, "78bfbdc5-081c-48e4-8000-097e3b0c23e5", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(40, "78bfbdc5-081c-48e4-8000-097e3b0c23e5", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(41, "263f2660-59d3-499d-b506-5774a8e6c571", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(42, "263f2660-59d3-499d-b506-5774a8e6c571", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(43, "e520e8ce-21d3-487e-9aff-526f9830f806", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(44, "e520e8ce-21d3-487e-9aff-526f9830f806", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(45, "71014f46-c75b-4732-a469-8bd9c4e6e40f", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(46, "71014f46-c75b-4732-a469-8bd9c4e6e40f", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(47, "38b29dd6-3a59-4b49-b8f5-68c75cb8e7dc", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(48, "36b07477-0e85-4a5f-8102-aaabfa5d760c", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(49, "36b07477-0e85-4a5f-8102-aaabfa5d760c", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(50, "13501ce2-919d-4582-9271-708703cfc462", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(51, "13501ce2-919d-4582-9271-708703cfc462", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(52, "9a47ce8e-47d3-4e22-b7db-be88d8195348", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(53, "9a47ce8e-47d3-4e22-b7db-be88d8195348", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(54, "f9b6f9b7-5a99-4b7c-ba86-e3a55d2d919f", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(55, "f9b6f9b7-5a99-4b7c-ba86-e3a55d2d919f", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(56, "6d2712b5-2af5-4536-a313-80e81760193c", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(57, "6d2712b5-2af5-4536-a313-80e81760193c", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(58, "98d57495-1f9b-4eff-8b86-ae20189197f1", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(59, "98d57495-1f9b-4eff-8b86-ae20189197f1", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(60, "8d5278d0-4552-488f-9843-66f61001de5a", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(61, "87cf9771-2732-4e9a-bf17-e3357f1a9c40", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(62, "8b269fa2-3dce-4dec-a260-3f651fc15139", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(63, "8b269fa2-3dce-4dec-a260-3f651fc15139", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(64, "e3b346c1-6a2c-4c96-8b56-581aba0241fb", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(65, "e3b346c1-6a2c-4c96-8b56-581aba0241fb", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(66, "e78564f7-8ab3-49af-bbd0-54f4dad13a0b", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(67, "87cf9771-2732-4e9a-bf17-e3357f1a9c40", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(68, "98f222a9-ffe5-4235-9744-a85f9cb79122", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(69, "8bae0a73-0994-4ce1-ab42-b6ff905c5507", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(70, "8bae0a73-0994-4ce1-ab42-b6ff905c5507", 1, false)
        };

        public override Microsoft.XLANGs.RuntimeTypes.Location[] EventLocations
        {
            get { return __eventLocations; }
        }

        public static Microsoft.XLANGs.RuntimeTypes.EventData[] __eventData = new Microsoft.XLANGs.RuntimeTypes.EventData[] {
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Body),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Receive),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Scope),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Construct),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Send),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Expression),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Expression),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.If),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.If),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.WhileBody),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.While),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.While),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.WhileBody),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Catch),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Terminate),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Catch),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Scope),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Body)
        };

        public static int[] __progressLocation0 = new int[] { 0,0,0,3,3,};
        public static int[] __progressLocation1 = new int[] { 0,0,1,1,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,4,4,4,68,69,69,69,70,3,3,3,3,};
        public static int[] __progressLocation2 = new int[] { 6,6,6,7,8,8,8,9,10,10,11,12,12,13,14,14,15,15,15,15,17,17,18,18,19,20,20,21,22,22,23,24,24,25,26,26,27,27,28,29,29,29,30,31,31,32,33,33,34,34,35,36,36,37,38,38,38,39,39,40,41,41,41,42,43,43,44,45,45,46,46,46,46,46,46,46,46,46,47,47,47,48,48,49,50,50,51,52,52,52,53,54,54,55,56,56,57,17,58,58,59,60,60,60,60,};
        public static int[] __progressLocation3 = new int[] { 61,61,62,62,63,64,64,64,65,66,66,67,67,};

        public static int[][] __progressLocations = new int[4] [] {__progressLocation0,__progressLocation1,__progressLocation2,__progressLocation3};
        public override int[][] ProgressLocations {get {return __progressLocations;} }

        public Microsoft.XLANGs.Core.StopConditions segment0(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[0];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[0];
            __ListLogic_1 __ctx1__ = (__ListLogic_1)_stateMgrs[1];
            __ListLogic_root_0 __ctx0__ = (__ListLogic_root_0)_stateMgrs[0];

            switch (__seg__.Progress)
            {
            case 0:
                DocumentListPort = new DocumentListPortType(0, this);
                RestQueryApplicationInfoPort = new RestQueryApplicationInfoPortType(1, this);
                RestQueryClosingDocumentsPort = new RestQueryClosingDocumentsPortType(2, this);
                RestQueryApplicantandApplicationDocumentsPort = new RestQueryApplicantandApplicationDocumentsPortType(3, this);
                __ctx__.PrologueCompleted = true;
                __ctx0__.__subWrapper0 = new Microsoft.XLANGs.Core.SubscriptionWrapper(ActivationSubGuids[0], DocumentListPort, this);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.Initialized) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.Initialized;
                goto case 1;
            case 1:
                __ctx1__ = new __ListLogic_1(this);
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
            ____scope35_2 __ctx2__ = (____scope35_2)_stateMgrs[2];
            __ListLogic_1 __ctx1__ = (__ListLogic_1)_stateMgrs[1];
            __ListLogic_root_0 __ctx0__ = (__ListLogic_root_0)_stateMgrs[0];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx1__.__TempClosingDocList = new Microsoft.XLANGs.RuntimeTypes.XmlDocumentSerializationProxy();
                __ctx1__.__ClosingDocStrTempEmpty = default(System.String);
                __ctx1__.__ChecklistStrTempEmpty = default(System.String);
                __ctx1__.__ChecklistItemTempDoc = new Microsoft.XLANGs.RuntimeTypes.XmlDocumentSerializationProxy();
                __ctx1__.__ChecklistItemLoopCount = default(System.Int32);
                __ctx1__.__ApplicantCount = default(System.Int32);
                __ctx1__.__LoopCount = default(System.Int32);
                __ctx1__.__ApplicantSFID = default(System.String);
                __ctx1__.__StrTemp = default(System.Text.StringBuilder);
                __ctx1__.__TempDoc = new Microsoft.XLANGs.RuntimeTypes.XmlDocumentSerializationProxy();
                __ctx1__.__TempApplicationDocList = new Microsoft.XLANGs.RuntimeTypes.XmlDocumentSerializationProxy();
                __ctx1__.__ApplicantSFIDXpath = default(System.String);
                __ctx1__.__StrTempEmpty = default(System.String);
                __ctx1__.__ApplicationID = default(System.String);
                __ctx1__.__ApplicationIDStatus = default(System.Boolean);
                __ctx1__.__Flag = default(System.Boolean);
                __ctx1__.__Status = default(System.String);
                __ctx1__.__ApplicationNumber = default(System.String);
                __ctx1__.__Stage = default(System.String);
                __ctx1__.__SalesForceObjectName = default(System.String);
                __ctx1__.__SalesForceObjectId = default(System.String);
                __ctx1__.__Message = default(System.String);
                __ctx1__.__ApplicationSFID = default(System.String);
                __ctx1__.__ExMessageTemp = default(System.String);
                __ctx1__.__TempFaultResponse = new Microsoft.XLANGs.RuntimeTypes.XmlDocumentSerializationProxy();
                __ctx1__.__DLAPUserID = default(System.String);
                __ctx1__.__ApplicationStrTempEmpty = default(System.String);
                __ctx1__.__ApplicationTempDoc = new Microsoft.XLANGs.RuntimeTypes.XmlDocumentSerializationProxy();
                __ctx1__.__ApplicantNameXpath = default(System.String);
                __ctx1__.__ApplicantName = default(System.String);
                __ctx1__.__ApplicantDocCount = default(System.Int32);
                __ctx1__.__ChecklistItemCount = default(System.Int32);
                __ctx1__.__ChecklistItemClosingDocSFIDxpath = default(System.String);
                __ctx1__.__ChecklistItemClosingDocSFID = default(System.String);
                __ctx1__.__ClosingDocApplicantSFIDxpath = default(System.String);
                __ctx1__.__ClosingDocApplicantSFID = default(System.String);
                __ctx1__.__ClosingDocChecklistItemStatusxPath = default(System.String);
                __ctx1__.__ClosingDocChecklistItemStatus = default(System.String);
                __ctx1__.__DocumentMasterCheckListNamexPath = default(System.String);
                __ctx1__.__DocumentMasterCheckListDescxPath = default(System.String);
                __ctx1__.__DocumentMasterCheckListDesc = default(System.String);
                __ctx1__.__DocumentMasterCheckListName = default(System.String);
                __ctx1__.__ChecklistItemSFIDS = default(System.String);
                __ctx1__.__CHECKLISTITEM_SOQL_QUERY = default(System.String);
                __ctx1__.__DOCUMENT_SOQL_QUERY = default(System.String);
                __ctx1__.__ApplicationNumberList = default(System.String);
                __ctx1__.__APPLICATION_INFO_SOQL_QUERY = default(System.String);
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
                if (!DocumentListPort.GetMessageId(__ctx0__.__subWrapper0.getSubscription(this), __seg__, __ctx1__, out __msgEnv__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx1__.__DocumentListRequestMsg != null)
                    __ctx1__.UnrefMessage(__ctx1__.__DocumentListRequestMsg);
                __ctx1__.__DocumentListRequestMsg = new DocumentListRequestType("DocumentListRequestMsg", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__DocumentListRequestMsg);
                DocumentListPort.ReceiveMessage(0, __msgEnv__, __ctx1__.__DocumentListRequestMsg, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__DocumentListRequestMsg);
                    __edata.PortName = @"DocumentListPort";
                    Tracker.FireEvent(__eventLocations[2],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                __ctx1__.__TempClosingDocList.UnderlyingXmlDocument = new System.Xml.XmlDocument();
                if ( !PostProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 6;
            case 6:
                __ctx1__.__ClosingDocStrTempEmpty = "";
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                __ctx1__.__ChecklistStrTempEmpty = "";
                if ( !PostProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 8;
            case 8:
                __ctx1__.__ChecklistItemTempDoc.UnderlyingXmlDocument = new System.Xml.XmlDocument();
                if ( !PostProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 9;
            case 9:
                __ctx1__.__ChecklistItemLoopCount = 1;
                if ( !PostProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 10;
            case 10:
                __ctx1__.__LoopCount = 1;
                if ( !PostProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 11;
            case 11:
                __ctx1__.__ApplicantSFID = "";
                if ( !PostProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 12;
            case 12:
                __ctx1__.__StrTemp = new System.Text.StringBuilder();
                if (__ctx1__ != null)
                    __ctx1__.__StrTemp = null;
                if ( !PostProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 13;
            case 13:
                __ctx1__.__TempDoc.UnderlyingXmlDocument = new System.Xml.XmlDocument();
                if ( !PostProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 14;
            case 14:
                __ctx1__.__TempApplicationDocList.UnderlyingXmlDocument = new System.Xml.XmlDocument();
                if ( !PostProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 15;
            case 15:
                __ctx1__.__ApplicantSFIDXpath = "";
                if ( !PostProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 16;
            case 16:
                __ctx1__.__StrTempEmpty = "";
                if ( !PostProgressInc( __seg__, __ctx__, 17 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 17;
            case 17:
                __ctx1__.__ApplicationID = "";
                if (__ctx1__ != null)
                    __ctx1__.__ApplicationID = null;
                if ( !PostProgressInc( __seg__, __ctx__, 18 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 18;
            case 18:
                __ctx1__.__ApplicationIDStatus = true;
                if ( !PostProgressInc( __seg__, __ctx__, 19 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 19;
            case 19:
                __ctx1__.__Flag = true;
                if ( !PostProgressInc( __seg__, __ctx__, 20 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 20;
            case 20:
                __ctx1__.__Status = "";
                if (__ctx1__ != null)
                    __ctx1__.__Status = null;
                if ( !PostProgressInc( __seg__, __ctx__, 21 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 21;
            case 21:
                __ctx1__.__ApplicationNumber = "";
                if (__ctx1__ != null)
                    __ctx1__.__ApplicationNumber = null;
                if ( !PostProgressInc( __seg__, __ctx__, 22 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 22;
            case 22:
                __ctx1__.__Stage = "";
                if (__ctx1__ != null)
                    __ctx1__.__Stage = null;
                if ( !PostProgressInc( __seg__, __ctx__, 23 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 23;
            case 23:
                __ctx1__.__SalesForceObjectName = "";
                if (__ctx1__ != null)
                    __ctx1__.__SalesForceObjectName = null;
                if ( !PostProgressInc( __seg__, __ctx__, 24 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 24;
            case 24:
                __ctx1__.__SalesForceObjectId = "";
                if (__ctx1__ != null)
                    __ctx1__.__SalesForceObjectId = null;
                if ( !PostProgressInc( __seg__, __ctx__, 25 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 25;
            case 25:
                __ctx1__.__Message = "";
                if (__ctx1__ != null)
                    __ctx1__.__Message = null;
                if ( !PostProgressInc( __seg__, __ctx__, 26 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 26;
            case 26:
                __ctx1__.__ApplicationSFID = "";
                if ( !PostProgressInc( __seg__, __ctx__, 27 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 27;
            case 27:
                __ctx1__.__ExMessageTemp = "";
                if (__ctx1__ != null)
                    __ctx1__.__ExMessageTemp = null;
                if ( !PostProgressInc( __seg__, __ctx__, 28 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 28;
            case 28:
                __ctx1__.__TempFaultResponse.UnderlyingXmlDocument = new System.Xml.XmlDocument();
                if ( !PostProgressInc( __seg__, __ctx__, 29 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 29;
            case 29:
                __ctx1__.__DLAPUserID = "";
                if ( !PostProgressInc( __seg__, __ctx__, 30 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 30;
            case 30:
                __ctx1__.__ApplicationStrTempEmpty = "";
                if ( !PostProgressInc( __seg__, __ctx__, 31 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 31;
            case 31:
                __ctx1__.__ApplicationTempDoc.UnderlyingXmlDocument = new System.Xml.XmlDocument();
                if (__ctx1__ != null)
                    __ctx1__.__ApplicationTempDoc = null;
                if ( !PostProgressInc( __seg__, __ctx__, 32 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 32;
            case 32:
                __ctx1__.__ApplicantNameXpath = "";
                if ( !PostProgressInc( __seg__, __ctx__, 33 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 33;
            case 33:
                __ctx1__.__ApplicantName = "";
                if ( !PostProgressInc( __seg__, __ctx__, 34 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 34;
            case 34:
                __ctx1__.__ChecklistItemClosingDocSFIDxpath = "";
                if (__ctx1__ != null)
                    __ctx1__.__ChecklistItemClosingDocSFIDxpath = null;
                if ( !PostProgressInc( __seg__, __ctx__, 35 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 35;
            case 35:
                __ctx1__.__ChecklistItemClosingDocSFID = "";
                if (__ctx1__ != null)
                    __ctx1__.__ChecklistItemClosingDocSFID = null;
                if ( !PostProgressInc( __seg__, __ctx__, 36 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 36;
            case 36:
                __ctx1__.__ClosingDocApplicantSFIDxpath = "";
                if (__ctx1__ != null)
                    __ctx1__.__ClosingDocApplicantSFIDxpath = null;
                if ( !PostProgressInc( __seg__, __ctx__, 37 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 37;
            case 37:
                __ctx1__.__ClosingDocApplicantSFID = "";
                if (__ctx1__ != null)
                    __ctx1__.__ClosingDocApplicantSFID = null;
                if ( !PostProgressInc( __seg__, __ctx__, 38 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 38;
            case 38:
                __ctx1__.__ClosingDocChecklistItemStatusxPath = "";
                if (__ctx1__ != null)
                    __ctx1__.__ClosingDocChecklistItemStatusxPath = null;
                if ( !PostProgressInc( __seg__, __ctx__, 39 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 39;
            case 39:
                __ctx1__.__ClosingDocChecklistItemStatus = "";
                if (__ctx1__ != null)
                    __ctx1__.__ClosingDocChecklistItemStatus = null;
                if ( !PostProgressInc( __seg__, __ctx__, 40 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 40;
            case 40:
                __ctx1__.__DocumentMasterCheckListNamexPath = "";
                if (__ctx1__ != null)
                    __ctx1__.__DocumentMasterCheckListNamexPath = null;
                if ( !PostProgressInc( __seg__, __ctx__, 41 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 41;
            case 41:
                __ctx1__.__DocumentMasterCheckListDescxPath = "";
                if (__ctx1__ != null)
                    __ctx1__.__DocumentMasterCheckListDescxPath = null;
                if ( !PostProgressInc( __seg__, __ctx__, 42 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 42;
            case 42:
                __ctx1__.__DocumentMasterCheckListDesc = "";
                if (__ctx1__ != null)
                    __ctx1__.__DocumentMasterCheckListDesc = null;
                if ( !PostProgressInc( __seg__, __ctx__, 43 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 43;
            case 43:
                __ctx1__.__DocumentMasterCheckListName = "";
                if (__ctx1__ != null)
                    __ctx1__.__DocumentMasterCheckListName = null;
                if ( !PostProgressInc( __seg__, __ctx__, 44 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 44;
            case 44:
                __ctx1__.__ChecklistItemSFIDS = "";
                if ( !PostProgressInc( __seg__, __ctx__, 45 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 45;
            case 45:
                __ctx1__.__CHECKLISTITEM_SOQL_QUERY = "";
                if ( !PostProgressInc( __seg__, __ctx__, 46 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 46;
            case 46:
                __ctx1__.__DOCUMENT_SOQL_QUERY = "";
                if ( !PostProgressInc( __seg__, __ctx__, 47 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 47;
            case 47:
                __ctx1__.__ApplicationNumberList = "";
                if ( !PostProgressInc( __seg__, __ctx__, 48 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 48;
            case 48:
                __ctx1__.__APPLICATION_INFO_SOQL_QUERY = "";
                if ( !PostProgressInc( __seg__, __ctx__, 49 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 49;
            case 49:
                if ( !PreProgressInc( __seg__, __ctx__, 50 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[4],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 50;
            case 50:
                __ctx2__ = new ____scope35_2(this);
                _stateMgrs[2] = __ctx2__;
                if ( !PostProgressInc( __seg__, __ctx__, 51 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 51;
            case 51:
                __ctx1__.StartContext(__seg__, __ctx2__);
                if ( !PostProgressInc( __seg__, __ctx__, 52 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 52:
                if ( !PreProgressInc( __seg__, __ctx__, 53 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if (__ctx1__ != null)
                    __ctx1__.__APPLICATION_INFO_SOQL_QUERY = null;
                if (__ctx1__ != null)
                    __ctx1__.__ApplicationNumberList = null;
                if (__ctx1__ != null)
                    __ctx1__.__DOCUMENT_SOQL_QUERY = null;
                if (__ctx1__ != null)
                    __ctx1__.__CHECKLISTITEM_SOQL_QUERY = null;
                if (__ctx1__ != null)
                    __ctx1__.__ChecklistItemSFIDS = null;
                if (__ctx1__ != null)
                    __ctx1__.__ApplicantName = null;
                if (__ctx1__ != null)
                    __ctx1__.__ApplicantNameXpath = null;
                if (__ctx1__ != null)
                    __ctx1__.__ApplicationStrTempEmpty = null;
                if (__ctx1__ != null)
                    __ctx1__.__DLAPUserID = null;
                if (__ctx1__ != null)
                    __ctx1__.__TempFaultResponse = null;
                if (__ctx1__ != null)
                    __ctx1__.__ApplicationSFID = null;
                if (__ctx1__ != null)
                    __ctx1__.__StrTempEmpty = null;
                if (__ctx1__ != null)
                    __ctx1__.__ApplicantSFIDXpath = null;
                if (__ctx1__ != null)
                    __ctx1__.__TempApplicationDocList = null;
                if (__ctx1__ != null)
                    __ctx1__.__TempDoc = null;
                if (__ctx1__ != null)
                    __ctx1__.__ApplicantSFID = null;
                if (__ctx1__ != null)
                    __ctx1__.__ChecklistItemTempDoc = null;
                if (__ctx1__ != null)
                    __ctx1__.__ChecklistStrTempEmpty = null;
                if (__ctx1__ != null)
                    __ctx1__.__ClosingDocStrTempEmpty = null;
                if (__ctx1__ != null)
                    __ctx1__.__TempClosingDocList = null;
                if (__ctx1__ != null && __ctx1__.__DocumentListRequestMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__DocumentListRequestMsg);
                    __ctx1__.__DocumentListRequestMsg = null;
                }
                if (RestQueryApplicantandApplicationDocumentsPort != null)
                {
                    RestQueryApplicantandApplicationDocumentsPort.Close(__ctx1__, __seg__);
                    RestQueryApplicantandApplicationDocumentsPort = null;
                }
                if (RestQueryClosingDocumentsPort != null)
                {
                    RestQueryClosingDocumentsPort.Close(__ctx1__, __seg__);
                    RestQueryClosingDocumentsPort = null;
                }
                if (RestQueryApplicationInfoPort != null)
                {
                    RestQueryApplicationInfoPort.Close(__ctx1__, __seg__);
                    RestQueryApplicationInfoPort = null;
                }
                Tracker.FireEvent(__eventLocations[68],__eventData[16],_stateMgrs[1].TrackDataStream );
                __ctx2__.Finally();
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 53;
            case 53:
                if ( !PreProgressInc( __seg__, __ctx__, 54 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[69],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 54;
            case 54:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 55 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 55;
            case 55:
                if ( !PreProgressInc( __seg__, __ctx__, 56 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                DocumentListPort.SendMessage(0, __ctx1__.__DocumentListResponseMsg, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.NextActivityPersists );
                if (DocumentListPort != null)
                {
                    DocumentListPort.Close(__ctx1__, __seg__);
                    DocumentListPort = null;
                }
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingResp) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingResp;
                goto case 56;
            case 56:
                if ( !PreProgressInc( __seg__, __ctx__, 57 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__DocumentListResponseMsg);
                    __edata.PortName = @"DocumentListPort";
                    Tracker.FireEvent(__eventLocations[70],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__DocumentListResponseMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__DocumentListResponseMsg);
                    __ctx1__.__DocumentListResponseMsg = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 57;
            case 57:
                if ( !PreProgressInc( __seg__, __ctx__, 58 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[3],__eventData[17],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 58;
            case 58:
                if (!__ctx1__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 59 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 59;
            case 59:
                if ( !PreProgressInc( __seg__, __ctx__, 60 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx1__.OnCommit();
                goto case 60;
            case 60:
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
            ____scope35_2 __ctx2__ = (____scope35_2)_stateMgrs[2];
            __ListLogic_1 __ctx1__ = (__ListLogic_1)_stateMgrs[1];
            __ListLogic_root_0 __ctx0__ = (__ListLogic_root_0)_stateMgrs[0];

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
                {
                    RestApplicationInfoRequestType __RestApplicationInfoRequestMsg = new RestApplicationInfoRequestType("RestApplicationInfoRequestMsg", __ctx1__);

                    ApplyTransform(typeof(DLAPDocumentListLogic.MakeRestApplicationInfoRequest), new object[] {__RestApplicationInfoRequestMsg.MessagePart}, new object[] {__ctx1__.__DocumentListRequestMsg.MessagePart});
                    __ctx1__.__DLAPUserID = (System.String)Microsoft.XLANGs.Core.Part.XPathLoad(__ctx1__.__DocumentListRequestMsg.MessagePart, "string(/*[local-name()='DocumentListRequest' and namespace-uri()='http://SBA.gov/DLAPDocumentList/DocumentListRequest']/*[local-name()='UserID' and namespace-uri()=''])", typeof(System.String));
                    __ctx1__.__ApplicationNumberList = (System.String)Microsoft.XLANGs.Core.Part.XPathLoad(__ctx1__.__DocumentListRequestMsg.MessagePart, "string(/*[local-name()='DocumentListRequest' and namespace-uri()='http://SBA.gov/DLAPDocumentList/DocumentListRequest']/*[local-name()='ApplicationNumber' and namespace-uri()=''])", typeof(System.String));
                    __ctx1__.__APPLICATION_INFO_SOQL_QUERY = @"Select Id, Name, Loan_Type__c, DLAP_Status_Description__c, DLAP_Status__c, Disaster_Declaration__r.Name,Disaster_Declaration__r.Disaster_Description__c, Disaster_Declaration__r.Disaster_Deadline_Date__c,(Select Id, External_ID__c, Name, Applicant_Relation_Type__c, Trade_Name__c, Contact__r.LastName, Contact__r.FirstName,Account__r.Name, Account__r.Business_Type__c from Applicants__r),(Select Id, Name, Case__c, Applicant__c, Application__c, Checklist_Item_Status__c, Checklist_Item_Text__c, Type__c, DocumentType__c, Verified_Date__c, CreatedDate, Checklist_Item_Due_Date__c, Applicant__r.External_ID__c, Master_Checklist__r.Name, Master_Checklist__r.Checklist_Description__c FROM Checklist_Items__r WHERE ((Type__c != 'Interface' AND Checklist_Item_Status__c = 'Requested') OR (((Type__c = 'Closing Documents') AND ((( Checklist_Item_Status__c ='Finalized') AND (Document_Generated__c = true)) OR (Checklist_Item_Status__c = 'Pending Borrower\'s Verification'))))) AND Id != NULL) FROM Application__c WHERE Name IN " + "('" + __ctx1__.__ApplicationNumberList + "') AND Name != NULL";
                    __RestApplicationInfoRequestMsg.SetPropertyValue(typeof(DLAPDocumentListSalesforceDefinition.Rest_Schemas.APPLICATION_INFO_SOQL_QUERY), __ctx1__.__APPLICATION_INFO_SOQL_QUERY);

                    if (__ctx1__.__RestApplicationInfoRequestMsg != null)
                        __ctx1__.UnrefMessage(__ctx1__.__RestApplicationInfoRequestMsg);
                    __ctx1__.__RestApplicationInfoRequestMsg = __RestApplicationInfoRequestMsg;
                    __ctx1__.RefMessage(__ctx1__.__RestApplicationInfoRequestMsg);
                }
                __ctx1__.__RestApplicationInfoRequestMsg.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 3;
            case 3:
                if ( !PreProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__RestApplicationInfoRequestMsg);
                    __edata.Messages.Add(__ctx1__.__DocumentListRequestMsg);
                    Tracker.FireEvent(__eventLocations[7],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[8],__eventData[4],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                if (!__ctx2__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 6;
            case 6:
                if ( !PreProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                RestQueryApplicationInfoPort.SendMessage(0, __ctx1__.__RestApplicationInfoRequestMsg, null, null, out __ctx0__.__subWrapper1, __ctx2__, __seg__ );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 7;
            case 7:
                if ( !PreProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__RestApplicationInfoRequestMsg);
                    __edata.PortName = @"RestQueryApplicationInfoPort";
                    Tracker.FireEvent(__eventLocations[9],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__RestApplicationInfoRequestMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__RestApplicationInfoRequestMsg);
                    __ctx1__.__RestApplicationInfoRequestMsg = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 8;
            case 8:
                if ( !PreProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[10],__eventData[1],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 9;
            case 9:
                if (!RestQueryApplicationInfoPort.GetMessageId(__ctx0__.__subWrapper1.getSubscription(this), __seg__, __ctx1__, out __msgEnv__, _locations[0]))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx0__ != null && __ctx0__.__subWrapper1 != null)
                {
                    __ctx0__.__subWrapper1.Destroy(this, __ctx0__);
                    __ctx0__.__subWrapper1 = null;
                }
                if (__ctx1__.__RestApplicationInfoResponseMsg != null)
                    __ctx1__.UnrefMessage(__ctx1__.__RestApplicationInfoResponseMsg);
                __ctx1__.__RestApplicationInfoResponseMsg = new RestApplicationInfoResponseType("RestApplicationInfoResponseMsg", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__RestApplicationInfoResponseMsg);
                RestQueryApplicationInfoPort.ReceiveMessage(0, __msgEnv__, __ctx1__.__RestApplicationInfoResponseMsg, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[2], __seg__);
                if ( !PostProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 10;
            case 10:
                if ( !PreProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__RestApplicationInfoResponseMsg);
                    __edata.PortName = @"RestQueryApplicationInfoPort";
                    Tracker.FireEvent(__eventLocations[11],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 11;
            case 11:
                if ( !PreProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[12],__eventData[3],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 12;
            case 12:
                {
                    SalesforceQueryApplicationInfoResponseType __SalesforceQueryApplicationInfoResponseMsg = new SalesforceQueryApplicationInfoResponseType("SalesforceQueryApplicationInfoResponseMsg", __ctx1__);

                    ApplyTransform(typeof(DLAPDocumentListLogic.MakeSalesforceApplicationResponse), new object[] {__SalesforceQueryApplicationInfoResponseMsg.MessagePart}, new object[] {__ctx1__.__RestApplicationInfoResponseMsg.MessagePart});

                    if (__ctx1__.__SalesforceQueryApplicationInfoResponseMsg != null)
                        __ctx1__.UnrefMessage(__ctx1__.__SalesforceQueryApplicationInfoResponseMsg);
                    __ctx1__.__SalesforceQueryApplicationInfoResponseMsg = __SalesforceQueryApplicationInfoResponseMsg;
                    __ctx1__.RefMessage(__ctx1__.__SalesforceQueryApplicationInfoResponseMsg);
                }
                __ctx1__.__SalesforceQueryApplicationInfoResponseMsg.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 13;
            case 13:
                if ( !PreProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__SalesforceQueryApplicationInfoResponseMsg);
                    __edata.Messages.Add(__ctx1__.__RestApplicationInfoResponseMsg);
                    Tracker.FireEvent(__eventLocations[13],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 14;
            case 14:
                if ( !PreProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[14],__eventData[5],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 15;
            case 15:
                __ctx1__.__ApplicantCount = System.Convert.ToInt32(Microsoft.XLANGs.Core.Part.XPathLoad(__ctx1__.__SalesforceQueryApplicationInfoResponseMsg.MessagePart, "count(/*[local-name()='Response' and namespace-uri()='http://SBA.gov/DLAPDocumentList/Application_Info__c']/*[local-name()='row' and namespace-uri()='http://SBA.gov/DLAPDocumentList/Application_Info__c']/*[local-name()='ApplicantId' and namespace-uri()='http://SBA.gov/DLAPDocumentList/Application_Info__c'])", typeof(System.Object)));
                if ( !PostProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 16;
            case 16:
                if ( !PreProgressInc( __seg__, __ctx__, 17 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[15],__eventData[6],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 17;
            case 17:
                __ctx1__.__StrTempEmpty = System.String.Empty;
                if ( !PostProgressInc( __seg__, __ctx__, 18 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 18;
            case 18:
                __ctx1__.__ApplicationStrTempEmpty = System.String.Empty;
                if ( !PostProgressInc( __seg__, __ctx__, 19 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 19;
            case 19:
                __ctx1__.__ApplicationSFID = (System.String)Microsoft.XLANGs.Core.Part.XPathLoad(__ctx1__.__SalesforceQueryApplicationInfoResponseMsg.MessagePart, "string(/*[local-name()='Response' and namespace-uri()='http://SBA.gov/DLAPDocumentList/Application_Info__c']/*[local-name()='row' and namespace-uri()='http://SBA.gov/DLAPDocumentList/Application_Info__c'][1]/*[local-name()='ApplicationId' and namespace-uri()='http://SBA.gov/DLAPDocumentList/Application_Info__c'])", typeof(System.String));
                if ( !PostProgressInc( __seg__, __ctx__, 20 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 20;
            case 20:
                if ( !PreProgressInc( __seg__, __ctx__, 21 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[17],__eventData[7],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 21;
            case 21:
                __condition__ = (__ctx1__.__ApplicantCount > 0) || (!System.String.IsNullOrEmpty(__ctx1__.__ApplicationSFID));
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 98 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 98;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 22 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 22;
            case 22:
                if ( !PreProgressInc( __seg__, __ctx__, 23 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[18],__eventData[3],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 23;
            case 23:
                {
                    SalesforceQueryChecklistItemResponseType __SalesforceQueryChecklistItemResponseMsg = new SalesforceQueryChecklistItemResponseType("SalesforceQueryChecklistItemResponseMsg", __ctx1__);

                    ApplyTransform(typeof(DLAPDocumentListLogic.MakeSalesforceCheckListItemResponse), new object[] {__SalesforceQueryChecklistItemResponseMsg.MessagePart}, new object[] {__ctx1__.__RestApplicationInfoResponseMsg.MessagePart});

                    if (__ctx1__.__SalesforceQueryChecklistItemResponseMsg != null)
                        __ctx1__.UnrefMessage(__ctx1__.__SalesforceQueryChecklistItemResponseMsg);
                    __ctx1__.__SalesforceQueryChecklistItemResponseMsg = __SalesforceQueryChecklistItemResponseMsg;
                    __ctx1__.RefMessage(__ctx1__.__SalesforceQueryChecklistItemResponseMsg);
                }
                __ctx1__.__SalesforceQueryChecklistItemResponseMsg.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 24 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 24;
            case 24:
                if ( !PreProgressInc( __seg__, __ctx__, 25 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__SalesforceQueryChecklistItemResponseMsg);
                    __edata.Messages.Add(__ctx1__.__RestApplicationInfoResponseMsg);
                    Tracker.FireEvent(__eventLocations[19],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 25;
            case 25:
                if ( !PreProgressInc( __seg__, __ctx__, 26 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[20],__eventData[5],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 26;
            case 26:
                __ctx1__.__ChecklistItemCount = (System.Int32)Microsoft.XLANGs.Core.Part.XPathLoad(__ctx1__.__SalesforceQueryChecklistItemResponseMsg.MessagePart, "count(/*[local-name()='Response' and namespace-uri()='http://SBA.gov/DLAPDocumentList/Checklist_Item__c']/*[local-name()='row' and namespace-uri()='http://SBA.gov/DLAPDocumentList/Checklist_Item__c']/*[local-name()='Id' and namespace-uri()='http://SBA.gov/DLAPDocumentList/Checklist_Item__c'])", typeof(System.Int32));
                if ( !PostProgressInc( __seg__, __ctx__, 27 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 27;
            case 27:
                if ( !PreProgressInc( __seg__, __ctx__, 28 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[21],__eventData[6],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 28;
            case 28:
                if ( !PreProgressInc( __seg__, __ctx__, 29 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[22],__eventData[3],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 29;
            case 29:
                {
                    ChecklistitemClosingDocsSFIDValuesType __ChecklistitemClosingDocsSFIDValuesMsg = new ChecklistitemClosingDocsSFIDValuesType("ChecklistitemClosingDocsSFIDValuesMsg", __ctx1__);

                    ApplyTransform(typeof(DLAPDocumentListLogic.MakeConcatenatedCheckListItemSFIDValues), new object[] {__ChecklistitemClosingDocsSFIDValuesMsg.MessagePart}, new object[] {__ctx1__.__SalesforceQueryChecklistItemResponseMsg.MessagePart});

                    if (__ctx1__.__ChecklistitemClosingDocsSFIDValuesMsg != null)
                        __ctx1__.UnrefMessage(__ctx1__.__ChecklistitemClosingDocsSFIDValuesMsg);
                    __ctx1__.__ChecklistitemClosingDocsSFIDValuesMsg = __ChecklistitemClosingDocsSFIDValuesMsg;
                    __ctx1__.RefMessage(__ctx1__.__ChecklistitemClosingDocsSFIDValuesMsg);
                }
                __ctx1__.__ChecklistitemClosingDocsSFIDValuesMsg.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 30 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 30;
            case 30:
                if ( !PreProgressInc( __seg__, __ctx__, 31 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__ChecklistitemClosingDocsSFIDValuesMsg);
                    __edata.Messages.Add(__ctx1__.__SalesforceQueryChecklistItemResponseMsg);
                    Tracker.FireEvent(__eventLocations[23],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 31;
            case 31:
                if ( !PreProgressInc( __seg__, __ctx__, 32 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[24],__eventData[5],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 32;
            case 32:
                __ctx1__.__ChecklistItemSFIDS = (System.String)Microsoft.XLANGs.Core.Part.XPathLoad(__ctx1__.__ChecklistitemClosingDocsSFIDValuesMsg.MessagePart, "string(/*[local-name()='SFIDValues' and namespace-uri()='http://DLAPDocumentListDefinition.ClosingDocsSFID']/*[local-name()='Multiple_Checklistitem_SFID_Values' and namespace-uri()=''])", typeof(System.String));
                if (__ctx1__ != null && __ctx1__.__ChecklistitemClosingDocsSFIDValuesMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__ChecklistitemClosingDocsSFIDValuesMsg);
                    __ctx1__.__ChecklistitemClosingDocsSFIDValuesMsg = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 33 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 33;
            case 33:
                if ( !PreProgressInc( __seg__, __ctx__, 34 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[25],__eventData[6],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 34;
            case 34:
                if ( !PreProgressInc( __seg__, __ctx__, 35 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[26],__eventData[7],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 35;
            case 35:
                __condition__ = (!System.String.IsNullOrWhiteSpace(__ctx1__.__ChecklistItemSFIDS));
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 50 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 50;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 36 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 36;
            case 36:
                if ( !PreProgressInc( __seg__, __ctx__, 37 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[27],__eventData[3],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 37;
            case 37:
                {
                    RestCheckListItemDocumentDetailsRequestType __RestCheckListItemDocumentDetailsRequestMsg = new RestCheckListItemDocumentDetailsRequestType("RestCheckListItemDocumentDetailsRequestMsg", __ctx1__);

                    ApplyTransform(typeof(DLAPDocumentListLogic.MakeRestCheckListItemDocumentRequest), new object[] {__RestCheckListItemDocumentDetailsRequestMsg.MessagePart}, new object[] {__ctx1__.__SalesforceQueryApplicationInfoResponseMsg.MessagePart});
                    __ctx1__.__CHECKLISTITEM_SOQL_QUERY = @"SELECT ContentDocument.LatestPublishedVersion.DLAP_Document_Type__c,ContentDocument.LatestPublishedVersion.Title,ContentDocument.LatestPublishedVersion.Id,ContentDocument.LatestPublishedVersion.Description,ContentDocument.LatestPublishedVersion.Document_Validity__c,ContentDocument.LatestPublishedVersion.CreatedDate,ContentDocument.LatestPublishedVersion.Document_Type__c,LinkedEntityId FROM ContentDocumentLink WHERE LinkedEntityId IN" + "(" + __ctx1__.__ChecklistItemSFIDS + ")";
                    __RestCheckListItemDocumentDetailsRequestMsg.SetPropertyValue(typeof(DLAPDocumentListSalesforceDefinition.Rest_Schemas.SF_CHECKLISTITEM_QUERY), __ctx1__.__CHECKLISTITEM_SOQL_QUERY);

                    if (__ctx1__.__RestCheckListItemDocumentDetailsRequestMsg != null)
                        __ctx1__.UnrefMessage(__ctx1__.__RestCheckListItemDocumentDetailsRequestMsg);
                    __ctx1__.__RestCheckListItemDocumentDetailsRequestMsg = __RestCheckListItemDocumentDetailsRequestMsg;
                    __ctx1__.RefMessage(__ctx1__.__RestCheckListItemDocumentDetailsRequestMsg);
                }
                __ctx1__.__RestCheckListItemDocumentDetailsRequestMsg.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 38 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 38;
            case 38:
                if ( !PreProgressInc( __seg__, __ctx__, 39 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__RestCheckListItemDocumentDetailsRequestMsg);
                    __edata.Messages.Add(__ctx1__.__SalesforceQueryApplicationInfoResponseMsg);
                    Tracker.FireEvent(__eventLocations[28],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 39;
            case 39:
                if ( !PreProgressInc( __seg__, __ctx__, 40 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[29],__eventData[4],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 40;
            case 40:
                if (!__ctx2__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 41 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 41;
            case 41:
                if ( !PreProgressInc( __seg__, __ctx__, 42 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                RestQueryClosingDocumentsPort.SendMessage(0, __ctx1__.__RestCheckListItemDocumentDetailsRequestMsg, null, null, out __ctx0__.__subWrapper2, __ctx2__, __seg__ );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 42;
            case 42:
                if ( !PreProgressInc( __seg__, __ctx__, 43 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__RestCheckListItemDocumentDetailsRequestMsg);
                    __edata.PortName = @"RestQueryClosingDocumentsPort";
                    Tracker.FireEvent(__eventLocations[30],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__RestCheckListItemDocumentDetailsRequestMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__RestCheckListItemDocumentDetailsRequestMsg);
                    __ctx1__.__RestCheckListItemDocumentDetailsRequestMsg = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 43;
            case 43:
                if ( !PreProgressInc( __seg__, __ctx__, 44 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[31],__eventData[1],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 44;
            case 44:
                if (!RestQueryClosingDocumentsPort.GetMessageId(__ctx0__.__subWrapper2.getSubscription(this), __seg__, __ctx1__, out __msgEnv__, _locations[1]))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx0__ != null && __ctx0__.__subWrapper2 != null)
                {
                    __ctx0__.__subWrapper2.Destroy(this, __ctx0__);
                    __ctx0__.__subWrapper2 = null;
                }
                if (__ctx1__.__RestCheckListItemDocumentDetailsResponseMsg != null)
                    __ctx1__.UnrefMessage(__ctx1__.__RestCheckListItemDocumentDetailsResponseMsg);
                __ctx1__.__RestCheckListItemDocumentDetailsResponseMsg = new RestCheckListItemDocumentDetailsResponseType("RestCheckListItemDocumentDetailsResponseMsg", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__RestCheckListItemDocumentDetailsResponseMsg);
                RestQueryClosingDocumentsPort.ReceiveMessage(0, __msgEnv__, __ctx1__.__RestCheckListItemDocumentDetailsResponseMsg, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[2], __seg__);
                if ( !PostProgressInc( __seg__, __ctx__, 45 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 45;
            case 45:
                if ( !PreProgressInc( __seg__, __ctx__, 46 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__RestCheckListItemDocumentDetailsResponseMsg);
                    __edata.PortName = @"RestQueryClosingDocumentsPort";
                    Tracker.FireEvent(__eventLocations[32],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 46;
            case 46:
                if ( !PreProgressInc( __seg__, __ctx__, 47 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[33],__eventData[5],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 47;
            case 47:
                __ctx1__.__ChecklistItemTempDoc.UnderlyingXmlDocument = __ctx1__.__RestCheckListItemDocumentDetailsResponseMsg.MessagePart.TypedValue;
                if (__ctx1__ != null && __ctx1__.__RestCheckListItemDocumentDetailsResponseMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__RestCheckListItemDocumentDetailsResponseMsg);
                    __ctx1__.__RestCheckListItemDocumentDetailsResponseMsg = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 48 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 48;
            case 48:
                if ( !PreProgressInc( __seg__, __ctx__, 49 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[34],__eventData[6],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 49;
            case 49:
                __ctx1__.__ChecklistStrTempEmpty = __ctx1__.__ChecklistStrTempEmpty + @"<Responses>" + __ctx1__.__ChecklistItemTempDoc.UnderlyingXmlDocument.InnerXml + "</Responses>";
                if ( !PostProgressInc( __seg__, __ctx__, 50 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 50;
            case 50:
                if ( !PreProgressInc( __seg__, __ctx__, 51 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[35],__eventData[8],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 51;
            case 51:
                if ( !PreProgressInc( __seg__, __ctx__, 52 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[36],__eventData[3],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 52;
            case 52:
                {
                    RestMultipleChecklistItemDocumentDetailsResponseType __RestMultipleChecklistItemDocumentDetailsResponseMsg = new RestMultipleChecklistItemDocumentDetailsResponseType("RestMultipleChecklistItemDocumentDetailsResponseMsg", __ctx1__);

                    __ctx1__.__ClosingDocStrTempEmpty = @"<ChecklistItemDocumentList xmlns='http://SBA.gov/DLAP/DocumentList'>" + __ctx1__.__ChecklistStrTempEmpty + "</ChecklistItemDocumentList>";
                    __ctx1__.__TempClosingDocList.UnderlyingXmlDocument.LoadXml(__ctx1__.__ClosingDocStrTempEmpty);
                    __RestMultipleChecklistItemDocumentDetailsResponseMsg.MessagePart.LoadFrom((System.Xml.XmlDocument)__ctx1__.__TempClosingDocList.UnderlyingXmlDocument);

                    if (__ctx1__.__RestMultipleChecklistItemDocumentDetailsResponseMsg != null)
                        __ctx1__.UnrefMessage(__ctx1__.__RestMultipleChecklistItemDocumentDetailsResponseMsg);
                    __ctx1__.__RestMultipleChecklistItemDocumentDetailsResponseMsg = __RestMultipleChecklistItemDocumentDetailsResponseMsg;
                    __ctx1__.RefMessage(__ctx1__.__RestMultipleChecklistItemDocumentDetailsResponseMsg);
                }
                __ctx1__.__RestMultipleChecklistItemDocumentDetailsResponseMsg.ConstructionCompleteEvent(false);
                if ( !PostProgressInc( __seg__, __ctx__, 53 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 53;
            case 53:
                if ( !PreProgressInc( __seg__, __ctx__, 54 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__RestMultipleChecklistItemDocumentDetailsResponseMsg);
                    Tracker.FireEvent(__eventLocations[37],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 54;
            case 54:
                if ( !PreProgressInc( __seg__, __ctx__, 55 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[38],__eventData[9],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 55;
            case 55:
                __condition__ = __ctx1__.__LoopCount <= __ctx1__.__ApplicantCount;
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 80 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 80;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 56 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 56;
            case 56:
                if ( !PreProgressInc( __seg__, __ctx__, 57 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[38],__eventData[10],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 57;
            case 57:
                if ( !PreProgressInc( __seg__, __ctx__, 58 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[39],__eventData[3],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 58;
            case 58:
                {
                    RestDocumentDetailsRequestType __RestDocumentDetailsRequestMsg = new RestDocumentDetailsRequestType("RestDocumentDetailsRequestMsg", __ctx1__);

                    ApplyTransform(typeof(DLAPDocumentListLogic.MakeRestDocumentRequest), new object[] {__RestDocumentDetailsRequestMsg.MessagePart}, new object[] {__ctx1__.__SalesforceQueryApplicationInfoResponseMsg.MessagePart});
                    __ctx1__.__ApplicantSFIDXpath = System.String.Format("string(/*[local-name()='Response' and namespace-uri()='http://SBA.gov/DLAPDocumentList/Application_Info__c']/*[local-name()='row' and namespace-uri()='http://SBA.gov/DLAPDocumentList/Application_Info__c'][{0}]/*[local-name()='ApplicantId' and namespace-uri()='http://SBA.gov/DLAPDocumentList/Application_Info__c'])", __ctx1__.__LoopCount);
                    __ctx1__.__ApplicantSFID = (System.String)Microsoft.XLANGs.Core.Part.XPathLoad(__ctx1__.__SalesforceQueryApplicationInfoResponseMsg.MessagePart, __ctx1__.__ApplicantSFIDXpath, typeof(System.String));
                    __ctx1__.__ApplicantNameXpath = System.String.Format("string(/*[local-name()='Response' and namespace-uri()='http://SBA.gov/DLAPDocumentList/Application_Info__c']/*[local-name()='row' and namespace-uri()='http://SBA.gov/DLAPDocumentList/Application_Info__c'][{0}]/*[local-name()='ApplicantExternalID' and namespace-uri()='http://SBA.gov/DLAPDocumentList/Application_Info__c'])", __ctx1__.__LoopCount);
                    __ctx1__.__ApplicantName = (System.String)Microsoft.XLANGs.Core.Part.XPathLoad(__ctx1__.__SalesforceQueryApplicationInfoResponseMsg.MessagePart, __ctx1__.__ApplicantNameXpath, typeof(System.String));
                    __ctx1__.__DOCUMENT_SOQL_QUERY = @"SELECT ContentDocument.LatestPublishedVersion.DLAP_Document_Type__c,ContentDocument.LatestPublishedVersion.Title,ContentDocument.LatestPublishedVersion.Id,ContentDocument.LatestPublishedVersion.Description,ContentDocument.LatestPublishedVersion.Document_Validity__c,ContentDocument.LatestPublishedVersion.CreatedDate,ContentDocument.LatestPublishedVersion.Document_Type__c FROM ContentDocumentLink WHERE LinkedEntityId =" + "'" + __ctx1__.__ApplicantSFID + "' AND ContentDocument.LatestPublishedVersion.DLAPUserID__c =" + "'" + __ctx1__.__DLAPUserID + "'";
                    __RestDocumentDetailsRequestMsg.SetPropertyValue(typeof(DLAPDocumentListSalesforceDefinition.Rest_Schemas.SF_DOCUMENT_QUERY), __ctx1__.__DOCUMENT_SOQL_QUERY);

                    if (__ctx1__.__RestDocumentDetailsRequestMsg != null)
                        __ctx1__.UnrefMessage(__ctx1__.__RestDocumentDetailsRequestMsg);
                    __ctx1__.__RestDocumentDetailsRequestMsg = __RestDocumentDetailsRequestMsg;
                    __ctx1__.RefMessage(__ctx1__.__RestDocumentDetailsRequestMsg);
                }
                __ctx1__.__RestDocumentDetailsRequestMsg.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 59 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 59;
            case 59:
                if ( !PreProgressInc( __seg__, __ctx__, 60 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__RestDocumentDetailsRequestMsg);
                    __edata.Messages.Add(__ctx1__.__SalesforceQueryApplicationInfoResponseMsg);
                    Tracker.FireEvent(__eventLocations[40],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 60;
            case 60:
                if ( !PreProgressInc( __seg__, __ctx__, 61 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[41],__eventData[4],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 61;
            case 61:
                if (!__ctx2__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 62 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 62;
            case 62:
                if ( !PreProgressInc( __seg__, __ctx__, 63 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                RestQueryApplicantandApplicationDocumentsPort.SendMessage(0, __ctx1__.__RestDocumentDetailsRequestMsg, null, null, out __ctx0__.__subWrapper3, __ctx2__, __seg__ );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 63;
            case 63:
                if ( !PreProgressInc( __seg__, __ctx__, 64 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__RestDocumentDetailsRequestMsg);
                    __edata.PortName = @"RestQueryApplicantandApplicationDocumentsPort";
                    Tracker.FireEvent(__eventLocations[42],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 64;
            case 64:
                if ( !PreProgressInc( __seg__, __ctx__, 65 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[43],__eventData[1],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 65;
            case 65:
                if (!RestQueryApplicantandApplicationDocumentsPort.GetMessageId(__ctx0__.__subWrapper3.getSubscription(this), __seg__, __ctx1__, out __msgEnv__, _locations[2]))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx0__ != null && __ctx0__.__subWrapper3 != null)
                {
                    __ctx0__.__subWrapper3.Destroy(this, __ctx0__);
                    __ctx0__.__subWrapper3 = null;
                }
                if (__ctx1__.__RestDocumentDetailsResponseMsg != null)
                    __ctx1__.UnrefMessage(__ctx1__.__RestDocumentDetailsResponseMsg);
                __ctx1__.__RestDocumentDetailsResponseMsg = new RestDocumentDetailsResponseType("RestDocumentDetailsResponseMsg", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__RestDocumentDetailsResponseMsg);
                RestQueryApplicantandApplicationDocumentsPort.ReceiveMessage(0, __msgEnv__, __ctx1__.__RestDocumentDetailsResponseMsg, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[2], __seg__);
                if ( !PostProgressInc( __seg__, __ctx__, 66 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 66;
            case 66:
                if ( !PreProgressInc( __seg__, __ctx__, 67 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__RestDocumentDetailsResponseMsg);
                    __edata.PortName = @"RestQueryApplicantandApplicationDocumentsPort";
                    Tracker.FireEvent(__eventLocations[44],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 67;
            case 67:
                if ( !PreProgressInc( __seg__, __ctx__, 68 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[45],__eventData[5],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 68;
            case 68:
                __ctx1__.__LoopCount = __ctx1__.__LoopCount + 1;
                if ( !PostProgressInc( __seg__, __ctx__, 69 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 69;
            case 69:
                if ( !PreProgressInc( __seg__, __ctx__, 70 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[46],__eventData[6],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 70;
            case 70:
                __ctx1__.__TempDoc.UnderlyingXmlDocument = __ctx1__.__RestDocumentDetailsResponseMsg.MessagePart.TypedValue;
                if ( !PostProgressInc( __seg__, __ctx__, 71 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 71;
            case 71:
                __ctx1__.__ApplicantDocCount = System.Convert.ToInt32(Microsoft.XLANGs.Core.Part.XPathLoad(__ctx1__.__RestDocumentDetailsResponseMsg.MessagePart, "count(/*[local-name()='QueryResult' and namespace-uri()='http://SBA.gov/REST/AppDocumentList'])", typeof(System.Object)));
                if ( !PostProgressInc( __seg__, __ctx__, 72 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 72;
            case 72:
                if ( !PreProgressInc( __seg__, __ctx__, 73 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[5],__eventData[7],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 73;
            case 73:
                __condition__ = __ctx1__.__ApplicantDocCount > 0;
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 76 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 76;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 74 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 74;
            case 74:
                __ctx1__.__StrTempEmpty = __ctx1__.__StrTempEmpty + @"<Responses>" + __ctx1__.__TempDoc.UnderlyingXmlDocument.InnerXml + "<DocumentApplicantId>" + __ctx1__.__ApplicantName + "</DocumentApplicantId></Responses>";
                if ( !PostProgressInc( __seg__, __ctx__, 75 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 75;
            case 75:
                if ( !PostProgressInc( __seg__, __ctx__, 77 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 77;
            case 76:
                __ctx1__.__StrTempEmpty = __ctx1__.__StrTempEmpty;
                if ( !PostProgressInc( __seg__, __ctx__, 77 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 77;
            case 77:
                if ( !PreProgressInc( __seg__, __ctx__, 78 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[16],__eventData[8],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 78;
            case 78:
                if ( !PreProgressInc( __seg__, __ctx__, 79 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[47],__eventData[11],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 79;
            case 79:
                if ( !PostProgressInc( __seg__, __ctx__, 55 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 55;
            case 80:
                if ( !PreProgressInc( __seg__, __ctx__, 81 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[47],__eventData[12],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 81;
            case 81:
                if ( !PreProgressInc( __seg__, __ctx__, 82 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[48],__eventData[3],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 82;
            case 82:
                {
                    RestMultipleDocumentDetailsResponseType __RestMultipleDocumentDetailsResponseMsg = new RestMultipleDocumentDetailsResponseType("RestMultipleDocumentDetailsResponseMsg", __ctx1__);

                    __ctx1__.__ApplicationStrTempEmpty = @"<AppDocumentList xmlns='http://SBA.gov/DLAP/DocumentList'>" + __ctx1__.__StrTempEmpty + "</AppDocumentList>";
                    __ctx1__.__TempApplicationDocList.UnderlyingXmlDocument.LoadXml(__ctx1__.__ApplicationStrTempEmpty);
                    __RestMultipleDocumentDetailsResponseMsg.MessagePart.LoadFrom((System.Xml.XmlDocument)__ctx1__.__TempApplicationDocList.UnderlyingXmlDocument);

                    if (__ctx1__.__RestMultipleDocumentDetailsResponseMsg != null)
                        __ctx1__.UnrefMessage(__ctx1__.__RestMultipleDocumentDetailsResponseMsg);
                    __ctx1__.__RestMultipleDocumentDetailsResponseMsg = __RestMultipleDocumentDetailsResponseMsg;
                    __ctx1__.RefMessage(__ctx1__.__RestMultipleDocumentDetailsResponseMsg);
                }
                __ctx1__.__RestMultipleDocumentDetailsResponseMsg.ConstructionCompleteEvent(false);
                if ( !PostProgressInc( __seg__, __ctx__, 83 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 83;
            case 83:
                if ( !PreProgressInc( __seg__, __ctx__, 84 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__RestMultipleDocumentDetailsResponseMsg);
                    Tracker.FireEvent(__eventLocations[49],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 84;
            case 84:
                if ( !PreProgressInc( __seg__, __ctx__, 85 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[50],__eventData[3],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 85;
            case 85:
                {
                    RestDocumentDetailsRequestType __RestDocumentDetailsRequestMsg = new RestDocumentDetailsRequestType("RestDocumentDetailsRequestMsg", __ctx1__);

                    ApplyTransform(typeof(DLAPDocumentListLogic.MakeRestDocumentRequest), new object[] {__RestDocumentDetailsRequestMsg.MessagePart}, new object[] {__ctx1__.__SalesforceQueryApplicationInfoResponseMsg.MessagePart});
                    __ctx1__.__DOCUMENT_SOQL_QUERY = @"SELECT ContentDocument.LatestPublishedVersion.DLAP_Document_Type__c,ContentDocument.LatestPublishedVersion.Title,ContentDocument.LatestPublishedVersion.Id,ContentDocument.LatestPublishedVersion.Description,ContentDocument.LatestPublishedVersion.Document_Validity__c,ContentDocument.LatestPublishedVersion.CreatedDate,ContentDocument.LatestPublishedVersion.Document_Type__c FROM ContentDocumentLink WHERE LinkedEntityId =" + "'" + __ctx1__.__ApplicationSFID + "' AND ContentDocument.LatestPublishedVersion.DLAPUserID__c =" + "'" + __ctx1__.__DLAPUserID + "'";
                    __RestDocumentDetailsRequestMsg.SetPropertyValue(typeof(DLAPDocumentListSalesforceDefinition.Rest_Schemas.SF_DOCUMENT_QUERY), __ctx1__.__DOCUMENT_SOQL_QUERY);

                    if (__ctx1__.__RestDocumentDetailsRequestMsg != null)
                        __ctx1__.UnrefMessage(__ctx1__.__RestDocumentDetailsRequestMsg);
                    __ctx1__.__RestDocumentDetailsRequestMsg = __RestDocumentDetailsRequestMsg;
                    __ctx1__.RefMessage(__ctx1__.__RestDocumentDetailsRequestMsg);
                }
                __ctx1__.__RestDocumentDetailsRequestMsg.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 86 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 86;
            case 86:
                if ( !PreProgressInc( __seg__, __ctx__, 87 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__RestDocumentDetailsRequestMsg);
                    __edata.Messages.Add(__ctx1__.__SalesforceQueryApplicationInfoResponseMsg);
                    Tracker.FireEvent(__eventLocations[51],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 87;
            case 87:
                if ( !PreProgressInc( __seg__, __ctx__, 88 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[52],__eventData[4],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 88;
            case 88:
                if (!__ctx2__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 89 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 89;
            case 89:
                if ( !PreProgressInc( __seg__, __ctx__, 90 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                RestQueryApplicantandApplicationDocumentsPort.SendMessage(0, __ctx1__.__RestDocumentDetailsRequestMsg, null, null, out __ctx0__.__subWrapper4, __ctx2__, __seg__ );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 90;
            case 90:
                if ( !PreProgressInc( __seg__, __ctx__, 91 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__RestDocumentDetailsRequestMsg);
                    __edata.PortName = @"RestQueryApplicantandApplicationDocumentsPort";
                    Tracker.FireEvent(__eventLocations[53],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__RestDocumentDetailsRequestMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__RestDocumentDetailsRequestMsg);
                    __ctx1__.__RestDocumentDetailsRequestMsg = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 91;
            case 91:
                if ( !PreProgressInc( __seg__, __ctx__, 92 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[54],__eventData[1],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 92;
            case 92:
                if (!RestQueryApplicantandApplicationDocumentsPort.GetMessageId(__ctx0__.__subWrapper4.getSubscription(this), __seg__, __ctx1__, out __msgEnv__, _locations[3]))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx0__ != null && __ctx0__.__subWrapper4 != null)
                {
                    __ctx0__.__subWrapper4.Destroy(this, __ctx0__);
                    __ctx0__.__subWrapper4 = null;
                }
                if (__ctx1__.__RestDocumentDetailsResponseMsg != null)
                    __ctx1__.UnrefMessage(__ctx1__.__RestDocumentDetailsResponseMsg);
                __ctx1__.__RestDocumentDetailsResponseMsg = new RestDocumentDetailsResponseType("RestDocumentDetailsResponseMsg", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__RestDocumentDetailsResponseMsg);
                RestQueryApplicantandApplicationDocumentsPort.ReceiveMessage(0, __msgEnv__, __ctx1__.__RestDocumentDetailsResponseMsg, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[2], __seg__);
                if ( !PostProgressInc( __seg__, __ctx__, 93 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 93;
            case 93:
                if ( !PreProgressInc( __seg__, __ctx__, 94 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__RestDocumentDetailsResponseMsg);
                    __edata.PortName = @"RestQueryApplicantandApplicationDocumentsPort";
                    Tracker.FireEvent(__eventLocations[55],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 94;
            case 94:
                if ( !PreProgressInc( __seg__, __ctx__, 95 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[56],__eventData[3],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 95;
            case 95:
                {
                    DocumentListResponseType __DocumentListResponseMsg = new DocumentListResponseType("DocumentListResponseMsg", __ctx1__);

                    ApplyTransform(typeof(DocumentListLogic.MakeDocumentListResponse), new object[] {__DocumentListResponseMsg.MessagePart}, new object[] {__ctx1__.__RestMultipleDocumentDetailsResponseMsg.MessagePart, __ctx1__.__RestDocumentDetailsResponseMsg.MessagePart, __ctx1__.__SalesforceQueryApplicationInfoResponseMsg.MessagePart, __ctx1__.__SalesforceQueryChecklistItemResponseMsg.MessagePart, __ctx1__.__RestMultipleChecklistItemDocumentDetailsResponseMsg.MessagePart});

                    if (__ctx1__.__DocumentListResponseMsg != null)
                        __ctx1__.UnrefMessage(__ctx1__.__DocumentListResponseMsg);
                    __ctx1__.__DocumentListResponseMsg = __DocumentListResponseMsg;
                    __ctx1__.RefMessage(__ctx1__.__DocumentListResponseMsg);
                }
                __ctx1__.__DocumentListResponseMsg.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 96 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 96;
            case 96:
                if ( !PreProgressInc( __seg__, __ctx__, 97 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__DocumentListResponseMsg);
                    __edata.Messages.Add(__ctx1__.__RestMultipleDocumentDetailsResponseMsg);
                    __edata.Messages.Add(__ctx1__.__RestDocumentDetailsResponseMsg);
                    __edata.Messages.Add(__ctx1__.__SalesforceQueryApplicationInfoResponseMsg);
                    __edata.Messages.Add(__ctx1__.__SalesforceQueryChecklistItemResponseMsg);
                    __edata.Messages.Add(__ctx1__.__RestMultipleChecklistItemDocumentDetailsResponseMsg);
                    Tracker.FireEvent(__eventLocations[57],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__RestMultipleDocumentDetailsResponseMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__RestMultipleDocumentDetailsResponseMsg);
                    __ctx1__.__RestMultipleDocumentDetailsResponseMsg = null;
                }
                if (__ctx1__ != null && __ctx1__.__RestMultipleChecklistItemDocumentDetailsResponseMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__RestMultipleChecklistItemDocumentDetailsResponseMsg);
                    __ctx1__.__RestMultipleChecklistItemDocumentDetailsResponseMsg = null;
                }
                if (__ctx1__ != null && __ctx1__.__RestDocumentDetailsResponseMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__RestDocumentDetailsResponseMsg);
                    __ctx1__.__RestDocumentDetailsResponseMsg = null;
                }
                if (__ctx1__ != null && __ctx1__.__SalesforceQueryChecklistItemResponseMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__SalesforceQueryChecklistItemResponseMsg);
                    __ctx1__.__SalesforceQueryChecklistItemResponseMsg = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 97;
            case 97:
                if ( !PostProgressInc( __seg__, __ctx__, 101 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 101;
            case 98:
                if ( !PreProgressInc( __seg__, __ctx__, 99 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[58],__eventData[3],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 99;
            case 99:
                {
                    DocumentListResponseType __DocumentListResponseMsg = new DocumentListResponseType("DocumentListResponseMsg", __ctx1__);

                    ApplyTransform(typeof(DocumentListLogic.MakeDocumentListErrorResponse), new object[] {__DocumentListResponseMsg.MessagePart}, new object[] {__ctx1__.__DocumentListRequestMsg.MessagePart});

                    if (__ctx1__.__DocumentListResponseMsg != null)
                        __ctx1__.UnrefMessage(__ctx1__.__DocumentListResponseMsg);
                    __ctx1__.__DocumentListResponseMsg = __DocumentListResponseMsg;
                    __ctx1__.RefMessage(__ctx1__.__DocumentListResponseMsg);
                }
                __ctx1__.__DocumentListResponseMsg.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 100 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 100;
            case 100:
                if ( !PreProgressInc( __seg__, __ctx__, 101 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__DocumentListResponseMsg);
                    __edata.Messages.Add(__ctx1__.__DocumentListRequestMsg);
                    Tracker.FireEvent(__eventLocations[59],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 101;
            case 101:
                if ( !PreProgressInc( __seg__, __ctx__, 102 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if (__ctx1__ != null && __ctx1__.__RestApplicationInfoResponseMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__RestApplicationInfoResponseMsg);
                    __ctx1__.__RestApplicationInfoResponseMsg = null;
                }
                if (__ctx1__ != null && __ctx1__.__SalesforceQueryApplicationInfoResponseMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__SalesforceQueryApplicationInfoResponseMsg);
                    __ctx1__.__SalesforceQueryApplicationInfoResponseMsg = null;
                }
                Tracker.FireEvent(__eventLocations[60],__eventData[8],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 102;
            case 102:
                if (!__ctx2__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 103 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 103;
            case 103:
                if ( !PreProgressInc( __seg__, __ctx__, 104 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx2__.OnCommit();
                goto case 104;
            case 104:
                __seg__.SegmentDone();
                _segments[1].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment3(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[3];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[2];
            ____scope35_2 __ctx2__ = (____scope35_2)_stateMgrs[2];
            __ListLogic_1 __ctx1__ = (__ListLogic_1)_stateMgrs[1];
            __ListLogic_root_0 __ctx0__ = (__ListLogic_root_0)_stateMgrs[0];

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
                Tracker.FireEvent(__eventLocations[61],__eventData[13],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[62],__eventData[3],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 3;
            case 3:
                {
                    DocumentListFaultResponseType __DocumentListFaultResponseMsg = new DocumentListFaultResponseType("DocumentListFaultResponseMsg", __ctx1__);

                    __ctx1__.__TempFaultResponse.UnderlyingXmlDocument = new System.Xml.XmlDocument();
                    __ctx1__.__TempFaultResponse.UnderlyingXmlDocument.LoadXml(@"<ns0:Fault xmlns:ns0='http://SBA.gov/DLAPDocumentList/DocumentListFault'><FaultString>Exception:Internal Error</FaultString><FaultCode>An error occurred while processing the Document Retrieval</FaultCode></ns0:Fault>");
                    __DocumentListFaultResponseMsg.MessagePart.LoadFrom((System.Xml.XmlDocument)__ctx1__.__TempFaultResponse.UnderlyingXmlDocument);
                    System.Diagnostics.EventLog.WriteEntry("DLAP Document List Exception", __ctx2__.__Ex_0.Message);
                    if (__ctx2__ != null)
                        __ctx2__.__Ex_0 = null;

                    if (__ctx1__.__DocumentListFaultResponseMsg != null)
                        __ctx1__.UnrefMessage(__ctx1__.__DocumentListFaultResponseMsg);
                    __ctx1__.__DocumentListFaultResponseMsg = __DocumentListFaultResponseMsg;
                    __ctx1__.RefMessage(__ctx1__.__DocumentListFaultResponseMsg);
                }
                __ctx1__.__DocumentListFaultResponseMsg.ConstructionCompleteEvent(false);
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__DocumentListFaultResponseMsg);
                    Tracker.FireEvent(__eventLocations[63],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                if ( !PreProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[64],__eventData[4],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 6;
            case 6:
                if (!__ctx2__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                if ( !PreProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                DocumentListPort.SendFault(0, 0, __ctx1__.__DocumentListFaultResponseMsg, null, null, __ctx2__, __seg__);
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingResp) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingResp;
                goto case 8;
            case 8:
                if ( !PreProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__DocumentListFaultResponseMsg);
                    __edata.PortName = @"DocumentListPort";
                    Tracker.FireEvent(__eventLocations[65],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__DocumentListFaultResponseMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__DocumentListFaultResponseMsg);
                    __ctx1__.__DocumentListFaultResponseMsg = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 9;
            case 9:
                if ( !PreProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[66],__eventData[14],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 10;
            case 10:
                RequestTerminate(__ctx2__,"An error occurred while processing the DLAP Document List");
                __seg__.SegmentDone();
                break;
            case 11:
                if ( !PreProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[67],__eventData[15],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 12;
            case 12:
                __ctx2__.__exv__ = null;
                OnEndCatchHandler(2, __seg__);
                __seg__.SegmentDone();
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }
        private static Microsoft.XLANGs.Core.CachedObject[] _locations = new Microsoft.XLANGs.Core.CachedObject[] {
            new Microsoft.XLANGs.Core.CachedObject(new System.Guid("{4AA20387-022A-4DA5-8537-4970DFB49896}")),
            new Microsoft.XLANGs.Core.CachedObject(new System.Guid("{740FBEEE-475B-4EF5-8233-9A658C3E512C}")),
            new Microsoft.XLANGs.Core.CachedObject(new System.Guid("{7936E28E-A58C-467C-812A-B0829DF5CB35}")),
            new Microsoft.XLANGs.Core.CachedObject(new System.Guid("{E3D55F03-3348-4D45-BC98-A40D3B218AE1}"))
        };

    }

    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed public class _MODULE_PROXY_ { }
}
