
#pragma warning disable 162

namespace DLAPEvents
{

    [System.SerializableAttribute]
    sealed public class __DLAPEventsSalesforceDefinition_SingleNotificationEvent__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static DLAPEventsSalesforceDefinition.SingleNotificationEvent _schema = new DLAPEventsSalesforceDefinition.SingleNotificationEvent();

        public __DLAPEventsSalesforceDefinition_SingleNotificationEvent__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eNone,
        "",
        new System.Type[]{
            typeof(DLAPEventsSalesforceDefinition.SingleNotificationEvent)
        },
        new string[]{
            "MessagePart"
        },
        new System.Type[]{
            typeof(__DLAPEventsSalesforceDefinition_SingleNotificationEvent__)
        },
        0,
        @"http://DLAPEventsSalesforceDefinition/SingleNotificationEvent#Notifications"
    )]
    [System.SerializableAttribute]
    sealed internal class SingleNotificationEventType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __DLAPEventsSalesforceDefinition_SingleNotificationEvent__ MessagePart;

        private void __CreatePartWrappers()
        {
            MessagePart = new __DLAPEventsSalesforceDefinition_SingleNotificationEvent__(this, "MessagePart", 0);
            this.AddPart("MessagePart", 0, MessagePart);
        }

        public SingleNotificationEventType(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __DLAPEventsDefinition_EventStatusResponse__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static DLAPEventsDefinition.EventStatusResponse _schema = new DLAPEventsDefinition.EventStatusResponse();

        public __DLAPEventsDefinition_EventStatusResponse__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eNone,
        "",
        new System.Type[]{
            typeof(DLAPEventsDefinition.EventStatusResponse)
        },
        new string[]{
            "MessagePart"
        },
        new System.Type[]{
            typeof(__DLAPEventsDefinition_EventStatusResponse__)
        },
        0,
        @"STATUS"
    )]
    [System.SerializableAttribute]
    sealed internal class StatusResponseType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __DLAPEventsDefinition_EventStatusResponse__ MessagePart;

        private void __CreatePartWrappers()
        {
            MessagePart = new __DLAPEventsDefinition_EventStatusResponse__(this, "MessagePart", 0);
            this.AddPart("MessagePart", 0, MessagePart);
        }

        public StatusResponseType(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __DLAPEventsDefinition_EventDocumentListResponse__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static DLAPEventsDefinition.EventDocumentListResponse _schema = new DLAPEventsDefinition.EventDocumentListResponse();

        public __DLAPEventsDefinition_EventDocumentListResponse__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eNone,
        "",
        new System.Type[]{
            typeof(DLAPEventsDefinition.EventDocumentListResponse)
        },
        new string[]{
            "MessagePart"
        },
        new System.Type[]{
            typeof(__DLAPEventsDefinition_EventDocumentListResponse__)
        },
        0,
        @"DOCUMENT"
    )]
    [System.SerializableAttribute]
    sealed internal class DocumentResponseType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __DLAPEventsDefinition_EventDocumentListResponse__ MessagePart;

        private void __CreatePartWrappers()
        {
            MessagePart = new __DLAPEventsDefinition_EventDocumentListResponse__(this, "MessagePart", 0);
            this.AddPart("MessagePart", 0, MessagePart);
        }

        public DocumentResponseType(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __DLAPEventsOracleDefinition_OracleEventNotification_Insert__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static DLAPEventsOracleDefinition.OracleEventNotification.Insert _schema = new DLAPEventsOracleDefinition.OracleEventNotification.Insert();

        public __DLAPEventsOracleDefinition_OracleEventNotification_Insert__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eNone,
        "",
        new System.Type[]{
            typeof(DLAPEventsOracleDefinition.OracleEventNotification.Insert)
        },
        new string[]{
            "MessagePart"
        },
        new System.Type[]{
            typeof(__DLAPEventsOracleDefinition_OracleEventNotification_Insert__)
        },
        0,
        @"http://Microsoft.LobServices.OracleDB/2007/03/DCMS_INT/View/EVENT_NOTIFICATION_DCMS#Insert"
    )]
    [System.SerializableAttribute]
    sealed internal class OracleEventNotificationRequestType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __DLAPEventsOracleDefinition_OracleEventNotification_Insert__ MessagePart;

        private void __CreatePartWrappers()
        {
            MessagePart = new __DLAPEventsOracleDefinition_OracleEventNotification_Insert__(this, "MessagePart", 0);
            this.AddPart("MessagePart", 0, MessagePart);
        }

        public OracleEventNotificationRequestType(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __DLAPEventsOracleDefinition_OracleEventNotification_InsertResponse__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static DLAPEventsOracleDefinition.OracleEventNotification.InsertResponse _schema = new DLAPEventsOracleDefinition.OracleEventNotification.InsertResponse();

        public __DLAPEventsOracleDefinition_OracleEventNotification_InsertResponse__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eNone,
        "",
        new System.Type[]{
            typeof(DLAPEventsOracleDefinition.OracleEventNotification.InsertResponse)
        },
        new string[]{
            "MessagePart"
        },
        new System.Type[]{
            typeof(__DLAPEventsOracleDefinition_OracleEventNotification_InsertResponse__)
        },
        0,
        @"http://Microsoft.LobServices.OracleDB/2007/03/DCMS_INT/View/EVENT_NOTIFICATION_DCMS#InsertResponse"
    )]
    [System.SerializableAttribute]
    sealed internal class OracleEventNotificationResponseType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __DLAPEventsOracleDefinition_OracleEventNotification_InsertResponse__ MessagePart;

        private void __CreatePartWrappers()
        {
            MessagePart = new __DLAPEventsOracleDefinition_OracleEventNotification_InsertResponse__(this, "MessagePart", 0);
            this.AddPart("MessagePart", 0, MessagePart);
        }

        public OracleEventNotificationResponseType(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __DLAPEventsSalesforceDefinition_Salesforce_EventRequest_Request__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static DLAPEventsSalesforceDefinition.Salesforce_EventRequest.Request _schema = new DLAPEventsSalesforceDefinition.Salesforce_EventRequest.Request();

        public __DLAPEventsSalesforceDefinition_Salesforce_EventRequest_Request__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eNone,
        "",
        new System.Type[]{
            typeof(DLAPEventsSalesforceDefinition.Salesforce_EventRequest.Request)
        },
        new string[]{
            "MessagePart"
        },
        new System.Type[]{
            typeof(__DLAPEventsSalesforceDefinition_Salesforce_EventRequest_Request__)
        },
        0,
        @"http://SBA.gov/DLAPEvents/Event_Request__c#Request"
    )]
    [System.SerializableAttribute]
    sealed internal class SalesforceEventRequestType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __DLAPEventsSalesforceDefinition_Salesforce_EventRequest_Request__ MessagePart;

        private void __CreatePartWrappers()
        {
            MessagePart = new __DLAPEventsSalesforceDefinition_Salesforce_EventRequest_Request__(this, "MessagePart", 0);
            this.AddPart("MessagePart", 0, MessagePart);
        }

        public SalesforceEventRequestType(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __DLAPEventsSalesforceDefinition_Salesforce_EventRequest_Response__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static DLAPEventsSalesforceDefinition.Salesforce_EventRequest.Response _schema = new DLAPEventsSalesforceDefinition.Salesforce_EventRequest.Response();

        public __DLAPEventsSalesforceDefinition_Salesforce_EventRequest_Response__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eNone,
        "",
        new System.Type[]{
            typeof(DLAPEventsSalesforceDefinition.Salesforce_EventRequest.Response)
        },
        new string[]{
            "MessagePart"
        },
        new System.Type[]{
            typeof(__DLAPEventsSalesforceDefinition_Salesforce_EventRequest_Response__)
        },
        0,
        @"http://SBA.gov/DLAPEvents/Event_Request__c#Response"
    )]
    [System.SerializableAttribute]
    sealed internal class SalesforceEventResponseType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __DLAPEventsSalesforceDefinition_Salesforce_EventRequest_Response__ MessagePart;

        private void __CreatePartWrappers()
        {
            MessagePart = new __DLAPEventsSalesforceDefinition_Salesforce_EventRequest_Response__(this, "MessagePart", 0);
            this.AddPart("MessagePart", 0, MessagePart);
        }

        public SalesforceEventResponseType(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __DLAPEventsSalesforceDefinition_SalesforceQuery__Application_Info__c_Request__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static DLAPEventsSalesforceDefinition.SalesforceQuery__Application_Info__c.Request _schema = new DLAPEventsSalesforceDefinition.SalesforceQuery__Application_Info__c.Request();

        public __DLAPEventsSalesforceDefinition_SalesforceQuery__Application_Info__c_Request__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eNone,
        "",
        new System.Type[]{
            typeof(DLAPEventsSalesforceDefinition.SalesforceQuery__Application_Info__c.Request)
        },
        new string[]{
            "MessagePart"
        },
        new System.Type[]{
            typeof(__DLAPEventsSalesforceDefinition_SalesforceQuery__Application_Info__c_Request__)
        },
        0,
        @"http://SBA.gov/DLAPEvents/Application_Info__c#Request"
    )]
    [System.SerializableAttribute]
    sealed internal class SalesforceQueryStatusApplicationInfoRequestType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __DLAPEventsSalesforceDefinition_SalesforceQuery__Application_Info__c_Request__ MessagePart;

        private void __CreatePartWrappers()
        {
            MessagePart = new __DLAPEventsSalesforceDefinition_SalesforceQuery__Application_Info__c_Request__(this, "MessagePart", 0);
            this.AddPart("MessagePart", 0, MessagePart);
        }

        public SalesforceQueryStatusApplicationInfoRequestType(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __DLAPEventsSalesforceDefinition_SalesforceQuery__Application_Info__c_Response__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static DLAPEventsSalesforceDefinition.SalesforceQuery__Application_Info__c.Response _schema = new DLAPEventsSalesforceDefinition.SalesforceQuery__Application_Info__c.Response();

        public __DLAPEventsSalesforceDefinition_SalesforceQuery__Application_Info__c_Response__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eNone,
        "",
        new System.Type[]{
            typeof(DLAPEventsSalesforceDefinition.SalesforceQuery__Application_Info__c.Response)
        },
        new string[]{
            "MessagePart"
        },
        new System.Type[]{
            typeof(__DLAPEventsSalesforceDefinition_SalesforceQuery__Application_Info__c_Response__)
        },
        0,
        @"http://SBA.gov/DLAPEvents/Application_Info__c#Response"
    )]
    [System.SerializableAttribute]
    sealed internal class SalesforceQueryStatusApplicationInfoResponseType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __DLAPEventsSalesforceDefinition_SalesforceQuery__Application_Info__c_Response__ MessagePart;

        private void __CreatePartWrappers()
        {
            MessagePart = new __DLAPEventsSalesforceDefinition_SalesforceQuery__Application_Info__c_Response__(this, "MessagePart", 0);
            this.AddPart("MessagePart", 0, MessagePart);
        }

        public SalesforceQueryStatusApplicationInfoResponseType(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __DLAPEventsSalesforceDefinition_SalesforceQuery__Checklist_Item__c_Request__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static DLAPEventsSalesforceDefinition.SalesforceQuery__Checklist_Item__c.Request _schema = new DLAPEventsSalesforceDefinition.SalesforceQuery__Checklist_Item__c.Request();

        public __DLAPEventsSalesforceDefinition_SalesforceQuery__Checklist_Item__c_Request__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eNone,
        "",
        new System.Type[]{
            typeof(DLAPEventsSalesforceDefinition.SalesforceQuery__Checklist_Item__c.Request)
        },
        new string[]{
            "MessagePart"
        },
        new System.Type[]{
            typeof(__DLAPEventsSalesforceDefinition_SalesforceQuery__Checklist_Item__c_Request__)
        },
        0,
        @"http://SBA.gov/DLAPEvents/Checklist_Item__c#Request"
    )]
    [System.SerializableAttribute]
    sealed internal class SalesforceQueryStatusChecklistItemRequestType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __DLAPEventsSalesforceDefinition_SalesforceQuery__Checklist_Item__c_Request__ MessagePart;

        private void __CreatePartWrappers()
        {
            MessagePart = new __DLAPEventsSalesforceDefinition_SalesforceQuery__Checklist_Item__c_Request__(this, "MessagePart", 0);
            this.AddPart("MessagePart", 0, MessagePart);
        }

        public SalesforceQueryStatusChecklistItemRequestType(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __DLAPEventsSalesforceDefinition_SalesforceQuery__Checklist_Item__c_Response__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static DLAPEventsSalesforceDefinition.SalesforceQuery__Checklist_Item__c.Response _schema = new DLAPEventsSalesforceDefinition.SalesforceQuery__Checklist_Item__c.Response();

        public __DLAPEventsSalesforceDefinition_SalesforceQuery__Checklist_Item__c_Response__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eNone,
        "",
        new System.Type[]{
            typeof(DLAPEventsSalesforceDefinition.SalesforceQuery__Checklist_Item__c.Response)
        },
        new string[]{
            "MessagePart"
        },
        new System.Type[]{
            typeof(__DLAPEventsSalesforceDefinition_SalesforceQuery__Checklist_Item__c_Response__)
        },
        0,
        @"http://SBA.gov/DLAPEvents/Checklist_Item__c#Response"
    )]
    [System.SerializableAttribute]
    sealed internal class SalesforceQueryStatusChecklistItemResponseType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __DLAPEventsSalesforceDefinition_SalesforceQuery__Checklist_Item__c_Response__ MessagePart;

        private void __CreatePartWrappers()
        {
            MessagePart = new __DLAPEventsSalesforceDefinition_SalesforceQuery__Checklist_Item__c_Response__(this, "MessagePart", 0);
            this.AddPart("MessagePart", 0, MessagePart);
        }

        public SalesforceQueryStatusChecklistItemResponseType(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __DLAPEventsSalesforceDefinition_SalesforceQuery_Loan_c_Request__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static DLAPEventsSalesforceDefinition.SalesforceQuery_Loan_c.Request _schema = new DLAPEventsSalesforceDefinition.SalesforceQuery_Loan_c.Request();

        public __DLAPEventsSalesforceDefinition_SalesforceQuery_Loan_c_Request__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eNone,
        "",
        new System.Type[]{
            typeof(DLAPEventsSalesforceDefinition.SalesforceQuery_Loan_c.Request)
        },
        new string[]{
            "MessagePart"
        },
        new System.Type[]{
            typeof(__DLAPEventsSalesforceDefinition_SalesforceQuery_Loan_c_Request__)
        },
        0,
        @"http://SBA.gov/DLAPEvents/Loan_Info__c#Request"
    )]
    [System.SerializableAttribute]
    sealed internal class SalesforceQueryStatusLoanRequestType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __DLAPEventsSalesforceDefinition_SalesforceQuery_Loan_c_Request__ MessagePart;

        private void __CreatePartWrappers()
        {
            MessagePart = new __DLAPEventsSalesforceDefinition_SalesforceQuery_Loan_c_Request__(this, "MessagePart", 0);
            this.AddPart("MessagePart", 0, MessagePart);
        }

        public SalesforceQueryStatusLoanRequestType(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __DLAPEventsSalesforceDefinition_SalesforceQuery_Loan_c_Response__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static DLAPEventsSalesforceDefinition.SalesforceQuery_Loan_c.Response _schema = new DLAPEventsSalesforceDefinition.SalesforceQuery_Loan_c.Response();

        public __DLAPEventsSalesforceDefinition_SalesforceQuery_Loan_c_Response__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eNone,
        "",
        new System.Type[]{
            typeof(DLAPEventsSalesforceDefinition.SalesforceQuery_Loan_c.Response)
        },
        new string[]{
            "MessagePart"
        },
        new System.Type[]{
            typeof(__DLAPEventsSalesforceDefinition_SalesforceQuery_Loan_c_Response__)
        },
        0,
        @"http://SBA.gov/DLAPEvents/Loan_Info__c#Response"
    )]
    [System.SerializableAttribute]
    sealed internal class SalesforceQueryStatusLoanResponseType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __DLAPEventsSalesforceDefinition_SalesforceQuery_Loan_c_Response__ MessagePart;

        private void __CreatePartWrappers()
        {
            MessagePart = new __DLAPEventsSalesforceDefinition_SalesforceQuery_Loan_c_Response__(this, "MessagePart", 0);
            this.AddPart("MessagePart", 0, MessagePart);
        }

        public SalesforceQueryStatusLoanResponseType(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __DLAPEventsSalesforceDefinition_RestCheckStatus_RestCheckStatusSalesforceRequest__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static DLAPEventsSalesforceDefinition.RestCheckStatus.RestCheckStatusSalesforceRequest _schema = new DLAPEventsSalesforceDefinition.RestCheckStatus.RestCheckStatusSalesforceRequest();

        public __DLAPEventsSalesforceDefinition_RestCheckStatus_RestCheckStatusSalesforceRequest__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eNone,
        "",
        new System.Type[]{
            typeof(DLAPEventsSalesforceDefinition.RestCheckStatus.RestCheckStatusSalesforceRequest)
        },
        new string[]{
            "MessagePart"
        },
        new System.Type[]{
            typeof(__DLAPEventsSalesforceDefinition_RestCheckStatus_RestCheckStatusSalesforceRequest__)
        },
        0,
        @"http://SBA.gov/REST/Query/DLAPEvents/CheckStatusApplicationInfoRequest#RestApplicationRequest"
    )]
    [System.SerializableAttribute]
    sealed internal class RestQueryApplicationInfoRequestType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __DLAPEventsSalesforceDefinition_RestCheckStatus_RestCheckStatusSalesforceRequest__ MessagePart;

        private void __CreatePartWrappers()
        {
            MessagePart = new __DLAPEventsSalesforceDefinition_RestCheckStatus_RestCheckStatusSalesforceRequest__(this, "MessagePart", 0);
            this.AddPart("MessagePart", 0, MessagePart);
        }

        public RestQueryApplicationInfoRequestType(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __DLAPEventsSalesforceDefinition_RestCheckStatus_RestCheckStatusSalesforceResponse__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static DLAPEventsSalesforceDefinition.RestCheckStatus.RestCheckStatusSalesforceResponse _schema = new DLAPEventsSalesforceDefinition.RestCheckStatus.RestCheckStatusSalesforceResponse();

        public __DLAPEventsSalesforceDefinition_RestCheckStatus_RestCheckStatusSalesforceResponse__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eNone,
        "",
        new System.Type[]{
            typeof(DLAPEventsSalesforceDefinition.RestCheckStatus.RestCheckStatusSalesforceResponse)
        },
        new string[]{
            "MessagePart"
        },
        new System.Type[]{
            typeof(__DLAPEventsSalesforceDefinition_RestCheckStatus_RestCheckStatusSalesforceResponse__)
        },
        0,
        @"http://SBA.gov/REST/Query/DLAPEvents/CheckStatusApplicationInfoResponse#QueryResult"
    )]
    [System.SerializableAttribute]
    sealed internal class RestQueryApplicationInfoResponseType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __DLAPEventsSalesforceDefinition_RestCheckStatus_RestCheckStatusSalesforceResponse__ MessagePart;

        private void __CreatePartWrappers()
        {
            MessagePart = new __DLAPEventsSalesforceDefinition_RestCheckStatus_RestCheckStatusSalesforceResponse__(this, "MessagePart", 0);
            this.AddPart("MessagePart", 0, MessagePart);
        }

        public RestQueryApplicationInfoResponseType(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __DLAPEventsSalesforceDefinition_DocumentDetails__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static DLAPEventsSalesforceDefinition.DocumentDetails _schema = new DLAPEventsSalesforceDefinition.DocumentDetails();

        public __DLAPEventsSalesforceDefinition_DocumentDetails__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eNone,
        "",
        new System.Type[]{
            typeof(DLAPEventsSalesforceDefinition.DocumentDetails)
        },
        new string[]{
            "MessagePart"
        },
        new System.Type[]{
            typeof(__DLAPEventsSalesforceDefinition_DocumentDetails__)
        },
        0,
        @"http://SBA.gov/DLAPEvents#DocumentList"
    )]
    [System.SerializableAttribute]
    sealed internal class MultipleDocumentListDetailsResponseType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __DLAPEventsSalesforceDefinition_DocumentDetails__ MessagePart;

        private void __CreatePartWrappers()
        {
            MessagePart = new __DLAPEventsSalesforceDefinition_DocumentDetails__(this, "MessagePart", 0);
            this.AddPart("MessagePart", 0, MessagePart);
        }

        public MultipleDocumentListDetailsResponseType(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __DLAPEventsSalesforceDefinition_SalesforceQuery_ContentVersion__c_Response__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static DLAPEventsSalesforceDefinition.SalesforceQuery_ContentVersion__c.Response _schema = new DLAPEventsSalesforceDefinition.SalesforceQuery_ContentVersion__c.Response();

        public __DLAPEventsSalesforceDefinition_SalesforceQuery_ContentVersion__c_Response__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eNone,
        "",
        new System.Type[]{
            typeof(DLAPEventsSalesforceDefinition.SalesforceQuery_ContentVersion__c.Response)
        },
        new string[]{
            "MessagePart"
        },
        new System.Type[]{
            typeof(__DLAPEventsSalesforceDefinition_SalesforceQuery_ContentVersion__c_Response__)
        },
        0,
        @"http://SBA.gov/DLAPEvents/ContentVersion__c#Response"
    )]
    [System.SerializableAttribute]
    sealed internal class SalesforceQueryContentVersionResponseType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __DLAPEventsSalesforceDefinition_SalesforceQuery_ContentVersion__c_Response__ MessagePart;

        private void __CreatePartWrappers()
        {
            MessagePart = new __DLAPEventsSalesforceDefinition_SalesforceQuery_ContentVersion__c_Response__(this, "MessagePart", 0);
            this.AddPart("MessagePart", 0, MessagePart);
        }

        public SalesforceQueryContentVersionResponseType(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __DLAPEventsSalesforceDefinition_SalesforceQuery_ContentVersion__c_Request__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static DLAPEventsSalesforceDefinition.SalesforceQuery_ContentVersion__c.Request _schema = new DLAPEventsSalesforceDefinition.SalesforceQuery_ContentVersion__c.Request();

        public __DLAPEventsSalesforceDefinition_SalesforceQuery_ContentVersion__c_Request__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eNone,
        "",
        new System.Type[]{
            typeof(DLAPEventsSalesforceDefinition.SalesforceQuery_ContentVersion__c.Request)
        },
        new string[]{
            "MessagePart"
        },
        new System.Type[]{
            typeof(__DLAPEventsSalesforceDefinition_SalesforceQuery_ContentVersion__c_Request__)
        },
        0,
        @"http://SBA.gov/DLAPEvents/ContentVersion__c#Request"
    )]
    [System.SerializableAttribute]
    sealed internal class SalesforceQueryContentVersionRequestType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __DLAPEventsSalesforceDefinition_SalesforceQuery_ContentVersion__c_Request__ MessagePart;

        private void __CreatePartWrappers()
        {
            MessagePart = new __DLAPEventsSalesforceDefinition_SalesforceQuery_ContentVersion__c_Request__(this, "MessagePart", 0);
            this.AddPart("MessagePart", 0, MessagePart);
        }

        public SalesforceQueryContentVersionRequestType(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __DLAPEventsSalesforceDefinition_SalesforceQuery_Document_Checklist_Item__c_Request__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static DLAPEventsSalesforceDefinition.SalesforceQuery_Document_Checklist_Item__c.Request _schema = new DLAPEventsSalesforceDefinition.SalesforceQuery_Document_Checklist_Item__c.Request();

        public __DLAPEventsSalesforceDefinition_SalesforceQuery_Document_Checklist_Item__c_Request__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eNone,
        "",
        new System.Type[]{
            typeof(DLAPEventsSalesforceDefinition.SalesforceQuery_Document_Checklist_Item__c.Request)
        },
        new string[]{
            "MessagePart"
        },
        new System.Type[]{
            typeof(__DLAPEventsSalesforceDefinition_SalesforceQuery_Document_Checklist_Item__c_Request__)
        },
        0,
        @"http://SBA.gov/DLAPEventsDocument/Checklist_Item__c#Request"
    )]
    [System.SerializableAttribute]
    sealed internal class SalesforceQueryDocumentChecklistItemRequestType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __DLAPEventsSalesforceDefinition_SalesforceQuery_Document_Checklist_Item__c_Request__ MessagePart;

        private void __CreatePartWrappers()
        {
            MessagePart = new __DLAPEventsSalesforceDefinition_SalesforceQuery_Document_Checklist_Item__c_Request__(this, "MessagePart", 0);
            this.AddPart("MessagePart", 0, MessagePart);
        }

        public SalesforceQueryDocumentChecklistItemRequestType(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __DLAPEventsSalesforceDefinition_SalesforceQuery_Document_Checklist_Item__c_Response__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static DLAPEventsSalesforceDefinition.SalesforceQuery_Document_Checklist_Item__c.Response _schema = new DLAPEventsSalesforceDefinition.SalesforceQuery_Document_Checklist_Item__c.Response();

        public __DLAPEventsSalesforceDefinition_SalesforceQuery_Document_Checklist_Item__c_Response__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eNone,
        "",
        new System.Type[]{
            typeof(DLAPEventsSalesforceDefinition.SalesforceQuery_Document_Checklist_Item__c.Response)
        },
        new string[]{
            "MessagePart"
        },
        new System.Type[]{
            typeof(__DLAPEventsSalesforceDefinition_SalesforceQuery_Document_Checklist_Item__c_Response__)
        },
        0,
        @"http://SBA.gov/DLAPEventsDocument/Checklist_Item__c#Response"
    )]
    [System.SerializableAttribute]
    sealed internal class SalesforceQueryDocumentChecklistItemResponseType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __DLAPEventsSalesforceDefinition_SalesforceQuery_Document_Checklist_Item__c_Response__ MessagePart;

        private void __CreatePartWrappers()
        {
            MessagePart = new __DLAPEventsSalesforceDefinition_SalesforceQuery_Document_Checklist_Item__c_Response__(this, "MessagePart", 0);
            this.AddPart("MessagePart", 0, MessagePart);
        }

        public SalesforceQueryDocumentChecklistItemResponseType(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __DLAPEventsSalesforceDefinition_ChecklistItemDocumentDetails__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static DLAPEventsSalesforceDefinition.ChecklistItemDocumentDetails _schema = new DLAPEventsSalesforceDefinition.ChecklistItemDocumentDetails();

        public __DLAPEventsSalesforceDefinition_ChecklistItemDocumentDetails__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eNone,
        "",
        new System.Type[]{
            typeof(DLAPEventsSalesforceDefinition.ChecklistItemDocumentDetails)
        },
        new string[]{
            "MessagePart"
        },
        new System.Type[]{
            typeof(__DLAPEventsSalesforceDefinition_ChecklistItemDocumentDetails__)
        },
        0,
        @"http://SBA.gov/DLAPEvents/ChecklistItemDocumentList#ChecklistItemDocumentList"
    )]
    [System.SerializableAttribute]
    sealed internal class SalesforceCheckListDocumentListDetailsResponseType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __DLAPEventsSalesforceDefinition_ChecklistItemDocumentDetails__ MessagePart;

        private void __CreatePartWrappers()
        {
            MessagePart = new __DLAPEventsSalesforceDefinition_ChecklistItemDocumentDetails__(this, "MessagePart", 0);
            this.AddPart("MessagePart", 0, MessagePart);
        }

        public SalesforceCheckListDocumentListDetailsResponseType(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __DLAPEventsSalesforceDefinition_RestDocument_RequestResponse_Request__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static DLAPEventsSalesforceDefinition.RestDocument.RequestResponse.Request _schema = new DLAPEventsSalesforceDefinition.RestDocument.RequestResponse.Request();

        public __DLAPEventsSalesforceDefinition_RestDocument_RequestResponse_Request__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eNone,
        "",
        new System.Type[]{
            typeof(DLAPEventsSalesforceDefinition.RestDocument.RequestResponse.Request)
        },
        new string[]{
            "MessagePart"
        },
        new System.Type[]{
            typeof(__DLAPEventsSalesforceDefinition_RestDocument_RequestResponse_Request__)
        },
        0,
        @"http://SBA.gov/REST/Query/DLAPEvents/DocumentsDetailsRequestResponse#Request"
    )]
    [System.SerializableAttribute]
    sealed internal class RestDocumentDetailsRequestType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __DLAPEventsSalesforceDefinition_RestDocument_RequestResponse_Request__ MessagePart;

        private void __CreatePartWrappers()
        {
            MessagePart = new __DLAPEventsSalesforceDefinition_RestDocument_RequestResponse_Request__(this, "MessagePart", 0);
            this.AddPart("MessagePart", 0, MessagePart);
        }

        public RestDocumentDetailsRequestType(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __DLAPEventsSalesforceDefinition_RestDocument_RequestResponse_QueryResult__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static DLAPEventsSalesforceDefinition.RestDocument.RequestResponse.QueryResult _schema = new DLAPEventsSalesforceDefinition.RestDocument.RequestResponse.QueryResult();

        public __DLAPEventsSalesforceDefinition_RestDocument_RequestResponse_QueryResult__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eNone,
        "",
        new System.Type[]{
            typeof(DLAPEventsSalesforceDefinition.RestDocument.RequestResponse.QueryResult)
        },
        new string[]{
            "MessagePart"
        },
        new System.Type[]{
            typeof(__DLAPEventsSalesforceDefinition_RestDocument_RequestResponse_QueryResult__)
        },
        0,
        @"http://SBA.gov/REST/Query/DLAPEvents/DocumentsDetailsRequestResponse#QueryResult"
    )]
    [System.SerializableAttribute]
    sealed internal class RestDocumentDetailsResponseType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __DLAPEventsSalesforceDefinition_RestDocument_RequestResponse_QueryResult__ MessagePart;

        private void __CreatePartWrappers()
        {
            MessagePart = new __DLAPEventsSalesforceDefinition_RestDocument_RequestResponse_QueryResult__(this, "MessagePart", 0);
            this.AddPart("MessagePart", 0, MessagePart);
        }

        public RestDocumentDetailsResponseType(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __DLAPEventsSalesforceDefinition_RestEventRequest_SaveRequest__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static DLAPEventsSalesforceDefinition.RestEventRequest.SaveRequest _schema = new DLAPEventsSalesforceDefinition.RestEventRequest.SaveRequest();

        public __DLAPEventsSalesforceDefinition_RestEventRequest_SaveRequest__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eNone,
        "",
        new System.Type[]{
            typeof(DLAPEventsSalesforceDefinition.RestEventRequest.SaveRequest)
        },
        new string[]{
            "MessagePart"
        },
        new System.Type[]{
            typeof(__DLAPEventsSalesforceDefinition_RestEventRequest_SaveRequest__)
        },
        0,
        @"http://SBA.gov/DLAPEvents/REST/INSERT/EventRequest#SaveRequest"
    )]
    [System.SerializableAttribute]
    sealed internal class RestEventRequestType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __DLAPEventsSalesforceDefinition_RestEventRequest_SaveRequest__ MessagePart;

        private void __CreatePartWrappers()
        {
            MessagePart = new __DLAPEventsSalesforceDefinition_RestEventRequest_SaveRequest__(this, "MessagePart", 0);
            this.AddPart("MessagePart", 0, MessagePart);
        }

        public RestEventRequestType(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __DLAPEventsSalesforceDefinition_RestEventRequest_results__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static DLAPEventsSalesforceDefinition.RestEventRequest.results _schema = new DLAPEventsSalesforceDefinition.RestEventRequest.results();

        public __DLAPEventsSalesforceDefinition_RestEventRequest_results__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eNone,
        "",
        new System.Type[]{
            typeof(DLAPEventsSalesforceDefinition.RestEventRequest.results)
        },
        new string[]{
            "MessagePart"
        },
        new System.Type[]{
            typeof(__DLAPEventsSalesforceDefinition_RestEventRequest_results__)
        },
        0,
        @"http://SBA.gov/DLAPEvents/REST/INSERT/EventRequest#results"
    )]
    [System.SerializableAttribute]
    sealed internal class RestEventResponseType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __DLAPEventsSalesforceDefinition_RestEventRequest_results__ MessagePart;

        private void __CreatePartWrappers()
        {
            MessagePart = new __DLAPEventsSalesforceDefinition_RestEventRequest_results__(this, "MessagePart", 0);
            this.AddPart("MessagePart", 0, MessagePart);
        }

        public RestEventResponseType(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __DLAPEventsSalesforceDefinition_NotificationService_outbound_notificationsResponse__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static DLAPEventsSalesforceDefinition.NotificationService_outbound.notificationsResponse _schema = new DLAPEventsSalesforceDefinition.NotificationService_outbound.notificationsResponse();

        public __DLAPEventsSalesforceDefinition_NotificationService_outbound_notificationsResponse__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eNone,
        "",
        new System.Type[]{
            typeof(DLAPEventsSalesforceDefinition.NotificationService_outbound.notificationsResponse)
        },
        new string[]{
            "MessagePart"
        },
        new System.Type[]{
            typeof(__DLAPEventsSalesforceDefinition_NotificationService_outbound_notificationsResponse__)
        },
        0,
        @"http://soap.sforce.com/2005/09/outbound#notificationsResponse"
    )]
    [System.SerializableAttribute]
    sealed internal class SalesforceNotificationEventResponseType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __DLAPEventsSalesforceDefinition_NotificationService_outbound_notificationsResponse__ MessagePart;

        private void __CreatePartWrappers()
        {
            MessagePart = new __DLAPEventsSalesforceDefinition_NotificationService_outbound_notificationsResponse__(this, "MessagePart", 0);
            this.AddPart("MessagePart", 0, MessagePart);
        }

        public SalesforceNotificationEventResponseType(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __DLAPEventsSalesforceDefinition_NotificationService_outbound_notifications__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static DLAPEventsSalesforceDefinition.NotificationService_outbound.notifications _schema = new DLAPEventsSalesforceDefinition.NotificationService_outbound.notifications();

        public __DLAPEventsSalesforceDefinition_NotificationService_outbound_notifications__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eNone,
        "",
        new System.Type[]{
            typeof(DLAPEventsSalesforceDefinition.NotificationService_outbound.notifications)
        },
        new string[]{
            "MessagePart"
        },
        new System.Type[]{
            typeof(__DLAPEventsSalesforceDefinition_NotificationService_outbound_notifications__)
        },
        0,
        @"http://soap.sforce.com/2005/09/outbound#notifications"
    )]
    [System.SerializableAttribute]
    sealed internal class SalesforceNotificationEventRequestType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __DLAPEventsSalesforceDefinition_NotificationService_outbound_notifications__ MessagePart;

        private void __CreatePartWrappers()
        {
            MessagePart = new __DLAPEventsSalesforceDefinition_NotificationService_outbound_notifications__(this, "MessagePart", 0);
            this.AddPart("MessagePart", 0, MessagePart);
        }

        public SalesforceNotificationEventRequestType(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __DLAPEventsDefinition_OrchestrationInstanceId__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static DLAPEventsDefinition.OrchestrationInstanceId _schema = new DLAPEventsDefinition.OrchestrationInstanceId();

        public __DLAPEventsDefinition_OrchestrationInstanceId__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eNone,
        "",
        new System.Type[]{
            typeof(DLAPEventsDefinition.OrchestrationInstanceId)
        },
        new string[]{
            "MessagePart"
        },
        new System.Type[]{
            typeof(__DLAPEventsDefinition_OrchestrationInstanceId__)
        },
        0,
        @"http://DLAPEventsDefinition.OrchestrationInstanceId#Instance"
    )]
    [System.SerializableAttribute]
    sealed internal class OrchestrationInstaceIdType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __DLAPEventsDefinition_OrchestrationInstanceId__ MessagePart;

        private void __CreatePartWrappers()
        {
            MessagePart = new __DLAPEventsDefinition_OrchestrationInstanceId__(this, "MessagePart", 0);
            this.AddPart("MessagePart", 0, MessagePart);
        }

        public OrchestrationInstaceIdType(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation",
        new System.Type[]{
            typeof(DLAPEvents.OracleEventNotificationRequestType), 
            typeof(DLAPEvents.OracleEventNotificationResponseType)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class OracleEventNotificationPortType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public OracleEventNotificationPortType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public OracleEventNotificationPortType(OracleEventNotificationPortType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            OracleEventNotificationPortType p = new OracleEventNotificationPortType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation",
            System.Web.Services.Description.OperationFlow.RequestResponse,
            typeof(OracleEventNotificationPortType),
            typeof(OracleEventNotificationRequestType),
            typeof(OracleEventNotificationResponseType),
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
            typeof(DLAPEvents.SingleNotificationEventType)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class SalesforceNotificationSingleEventPortType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public SalesforceNotificationSingleEventPortType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public SalesforceNotificationSingleEventPortType(SalesforceNotificationSingleEventPortType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            SalesforceNotificationSingleEventPortType p = new SalesforceNotificationSingleEventPortType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(SalesforceNotificationSingleEventPortType),
            typeof(SingleNotificationEventType),
            null,
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
            typeof(DLAPEvents.RestQueryApplicationInfoRequestType), 
            typeof(DLAPEvents.RestQueryApplicationInfoResponseType)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class RestQueryStatusApplicationInfoPortType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public RestQueryStatusApplicationInfoPortType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public RestQueryStatusApplicationInfoPortType(RestQueryStatusApplicationInfoPortType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            RestQueryStatusApplicationInfoPortType p = new RestQueryStatusApplicationInfoPortType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation",
            System.Web.Services.Description.OperationFlow.RequestResponse,
            typeof(RestQueryStatusApplicationInfoPortType),
            typeof(RestQueryApplicationInfoRequestType),
            typeof(RestQueryApplicationInfoResponseType),
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
            typeof(DLAPEvents.SalesforceQueryContentVersionRequestType), 
            typeof(DLAPEvents.SalesforceQueryContentVersionResponseType)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class SalesforceQueryContentVersionPortType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public SalesforceQueryContentVersionPortType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public SalesforceQueryContentVersionPortType(SalesforceQueryContentVersionPortType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            SalesforceQueryContentVersionPortType p = new SalesforceQueryContentVersionPortType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation",
            System.Web.Services.Description.OperationFlow.RequestResponse,
            typeof(SalesforceQueryContentVersionPortType),
            typeof(SalesforceQueryContentVersionRequestType),
            typeof(SalesforceQueryContentVersionResponseType),
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
            typeof(DLAPEvents.RestQueryApplicationInfoRequestType), 
            typeof(DLAPEvents.RestQueryApplicationInfoResponseType)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class SalesforceQueryDocumentApplicationInfoPortType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public SalesforceQueryDocumentApplicationInfoPortType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public SalesforceQueryDocumentApplicationInfoPortType(SalesforceQueryDocumentApplicationInfoPortType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            SalesforceQueryDocumentApplicationInfoPortType p = new SalesforceQueryDocumentApplicationInfoPortType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation",
            System.Web.Services.Description.OperationFlow.RequestResponse,
            typeof(SalesforceQueryDocumentApplicationInfoPortType),
            typeof(RestQueryApplicationInfoRequestType),
            typeof(RestQueryApplicationInfoResponseType),
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
            typeof(DLAPEvents.RestDocumentDetailsRequestType), 
            typeof(DLAPEvents.RestDocumentDetailsResponseType)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class RestDocumentChecklistItemQueryPortType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public RestDocumentChecklistItemQueryPortType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public RestDocumentChecklistItemQueryPortType(RestDocumentChecklistItemQueryPortType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            RestDocumentChecklistItemQueryPortType p = new RestDocumentChecklistItemQueryPortType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation",
            System.Web.Services.Description.OperationFlow.RequestResponse,
            typeof(RestDocumentChecklistItemQueryPortType),
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

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation",
        new System.Type[]{
            typeof(DLAPEvents.RestEventRequestType), 
            typeof(DLAPEvents.RestEventResponseType)
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

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation",
        new System.Type[]{
            typeof(DLAPEvents.SalesforceNotificationEventRequestType), 
            typeof(DLAPEvents.SalesforceNotificationEventResponseType)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class SalesforceNotificationMultipleEventPortType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public SalesforceNotificationMultipleEventPortType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public SalesforceNotificationMultipleEventPortType(SalesforceNotificationMultipleEventPortType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            SalesforceNotificationMultipleEventPortType p = new SalesforceNotificationMultipleEventPortType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation",
            System.Web.Services.Description.OperationFlow.RequestResponse,
            typeof(SalesforceNotificationMultipleEventPortType),
            typeof(SalesforceNotificationEventRequestType),
            typeof(SalesforceNotificationEventResponseType),
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
    //#line 841 "C:\Users\skyeniga\Source\Repos\Biztalk\DLAP Events\DLAP Events Logic\DLAPEventLogic.odx"
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        0, "SalesforceNotificationEventPort", "Operation", -1, -1, true
    )]
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        },
        new System.Type[] {
            typeof(DLAPEvents.SalesforceNotificationSingleEventPortType),
            typeof(DLAPEvents.OracleEventNotificationPortType)
        },
        new System.String[] {
            "SalesforceNotificationEventPort",
            "OracleEventNotificationPort"
        },
        new System.Type[] {
            null,
            null
        }
    )]
    [Microsoft.XLANGs.BaseTypes.ServiceCallTreeAttribute(
        new System.Type[] {
            typeof(DLAPEvents.StatusLogic),
            typeof(DLAPEvents.DocumentLogic),
            typeof(DLAPEvents.EventRequest),
            typeof(DLAPEvents.EventRequest),
            typeof(DLAPEvents.EventRequest)
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
    sealed internal class ProcessLogic : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
    {
        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        public static readonly bool __execable = false;
        [Microsoft.XLANGs.BaseTypes.CallCompensationAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSCallCompensationInfo.eHasRequestResponse
,
            new System.String[] {
                "DLAPEvents.StatusLogic",
                "DLAPEvents.DocumentLogic",
                "DLAPEvents.EventRequest",
                "DLAPEvents.EventRequest",
                "DLAPEvents.EventRequest"
            },
            new System.String[] {
            }
        )]
        public static void __bodyProxy()
        {
        }
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(ProcessLogic));
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

        static ProcessLogic()
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
            _rootContext = new __ProcessLogic_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[8];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public ProcessLogic(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "ProcessLogic", tracker)
        {
            ConstructorHelper();
        }

        public ProcessLogic(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "ProcessLogic")
        {
            ConstructorHelper();
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>a5dfd349-1cbe-4402-8c63-b48f5ebbf506</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>e2ea0da0-d7b5-4af2-b8ac-350fe2ef6466</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Receive Salesforce Notification Single Request</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ScopeShape</shapeType>      <ShapeID>d0023d93-2d4c-487c-880f-73e070a50553</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>DLAP Events Error Scope</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>TaskShape</shapeType>      <ShapeID>d12b70c3-6b6d-46a1-8ec8-131da1e538eb</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>DLAP Events Processing</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>1057fb8f-0194-4a95-a7db-f0a8c9855b3a</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Extracting Notification Values</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionShape</shapeType>      <ShapeID>687ad16b-c3fe-44b1-b7cb-0a21dec125a8</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Decide STATUS or DOCUMENT?</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>af06bd87-4027-49be-b473-18c4dd5e962e</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>STATUS</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>CallShape</shapeType>      <ShapeID>f377d934-0366-49be-99c3-5acdedacc7bd</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Call Event Status Orchestration</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>43100881-d2bf-4f97-a2b6-c2503ae38955</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>StatusResponseMsg</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>576449ea-9ee1-45a0-8af6-98a91409a763</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>SingleNotificationEventMsg</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>16874ef5-8197-4c22-bbad-8b7d39b76169</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Construct Oracle Status Event Notification Request Msg</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>7e39a3a7-3c15-4102-a12d-22a251c2607d</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Make Oracle Event Notification Request</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>2b690cff-0e69-453d-a346-a367e4f5f747</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>6e9db079-c5d9-4ab1-bb25-a9d896edbf77</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>39827598-58d1-48dc-84f5-c4644b55634d</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Inject XML Data</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>2663eb79-7590-45c3-83e0-e66828c365e9</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>cbdfb823-1ae5-4098-8833-f86ace3c8b93</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>DOCUMENT</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>CallShape</shapeType>      <ShapeID>604eae71-1f71-4a65-a543-7e40b54ecb20</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Call Event Document Orchestration</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>4bca4e98-9f44-4b1c-81ca-ce32918235ed</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>SingleNotificationEventMsg</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>22a82d62-5d6b-410f-8fe7-9268ee594830</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>DocumentResponseMsg</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>7e09cc83-6023-4e01-ab52-924dca5527e2</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Construct Oracle Document Event Notification Request Msg</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>8fafed2e-6618-4a48-9bb1-d6fa17c69ba2</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>992fb53c-d50e-4250-9b7e-ddc9f262b58a</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Make Oracle Event Notification Request</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>df4fdb3e-20a0-4b50-a27a-5bcde16c0c8a</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_3</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>3b48b2db-53a8-46de-884d-f5daabdd6646</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_4</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>105728d5-8f82-4dd0-8177-a715f35a9b05</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Inject XML Data</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>fd683370-8fbd-4a47-8e24-76a349a6ccb4</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>Else</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>c19a9e6c-b5d2-4f6d-9cb5-107c37dee52d</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Set Error Values</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>CallShape</shapeType>      <ShapeID>5cf1137a-9f2b-49d1-b317-6a186319a5d1</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Call Event Request Update Orchestration</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>4daeea25-336b-48d1-8081-57b1ad9c2772</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>ApplicationNumber</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>c4ea263c-82f7-4c96-878d-4bed1cd9fefd</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>SFObjectID</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>b9c92ea1-0b87-432c-b58d-ac67c68f278a</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>Message</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>3daf1c28-607e-4f19-abfd-345dc3d133c4</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>SFObjectName</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>0fdcd268-67ca-44a5-84b1-09c79dc9541d</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>Stage</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>38a0221f-1e30-4e48-9769-883dc961649b</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>Status</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>b53efc4c-b860-4b09-95e1-ef05d9cf9ef8</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>Empty</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>f9bf2014-586b-4616-a91d-da6d505f711f</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>OrchestrationInstanceId</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>682f3c2c-3660-4e00-8752-07c1ba292dff</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>EventRequestId</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>TerminateShape</shapeType>      <ShapeID>79306503-8674-4b41-8f30-6a8c7de9179b</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Terminate DLAP Events Process</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>f070f669-6261-428d-be3c-1104bec87cb5</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Send Oracle Event Notification Request</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>33899330-d30d-49d5-984b-64ae18720186</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Receive Oracle Event Notification Response</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>41fbc912-f350-4904-8e7a-b334dceef314</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Extract Values</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionShape</shapeType>      <ShapeID>26efe9df-a4b5-43db-b93f-45a60ea0db2d</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Success or Error?</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>40bdb364-0691-4ecf-8a79-8bcc7452a6aa</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>Success</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>cd943a38-e9f2-4109-be33-4852b9d6f45b</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Set Values</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>91da081c-dab5-4f8a-ad48-d193394fed09</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>Else</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>1f1171f5-fa36-4358-8a2f-da0a722ed065</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Set Error Values</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>CallShape</shapeType>      <ShapeID>04cd7dd9-cf34-4e05-a830-ee691ad130f2</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Call Event Request Update Orchestration</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>fec054d6-fe84-4034-82df-9c4b9107861a</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>ApplicationNumber</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>b6482677-bb1c-4fba-af02-c7cafc089875</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>SFObjectID</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>82d7227b-b530-47e7-aed7-757a5d7a3531</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>Message</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>7a6b65c6-c32c-4176-95c7-dc4e907fe9ae</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>SFObjectName</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>2f0ad188-2d2e-4f98-b24d-d12ea501088c</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>Stage</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>96648f73-c9b2-45ae-8b84-9348c3e7bcd9</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>Status</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>c01e6e70-12ac-43e3-9831-49fa305da0ff</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>Empty</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>37ffe96f-7fc3-4c36-94c7-4107edb9a236</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>OrchestrationInstanceId</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>da3786f7-80dc-41bb-8de6-b17e0dd17637</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>EventRequestId</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>CatchShape</shapeType>      <ShapeID>c3f16b07-6828-4d8a-887e-6de53677a0da</ShapeID>      <ParentLink>Scope_Catch</ParentLink>                <shapeText>System Exception</shapeText>                      <ExceptionType>System.Exception</ExceptionType>            
<children>                          
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>730ca7c5-f219-49d0-be77-2c942de21371</ShapeID>      <ParentLink>Catch_Statement</ParentLink>                <shapeText>Set Error Values</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>CallShape</shapeType>      <ShapeID>d0adfcc0-1cf9-40ea-8369-a25e66777fd7</ShapeID>      <ParentLink>Catch_Statement</ParentLink>                <shapeText>Call Event Request Update Orchestration</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>8ab9fe6a-0d02-4efb-b0a7-23a9c6b6e32b</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>ApplicationNumber</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>07d75c59-fa63-45e4-bb44-d473d07eece3</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>SFObjectID</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>57e6518c-89ab-41f6-adf2-c7c8ae1831df</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>ErrorMessage</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>bf84a487-f182-4010-bb35-05470d9979a5</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>SFObjectName</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>c53895d6-64b2-40a4-8efc-5a5c52d6c26e</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>Stage</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>a23f64f1-367a-46a8-b266-9a885c10a06c</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>Status</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>e65ad802-fff4-4d1d-bfd8-d525119dd60d</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>Empty</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>d9740e13-8aad-4422-9dc7-67e60afb5350</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>OrchestrationInstanceId</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>bc912448-f0f1-4864-b46c-54b72f31775b</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>EventRequestId</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>TerminateShape</shapeType>      <ShapeID>978f33a9-6659-4cf9-b0b7-b76917fb3992</ShapeID>      <ParentLink>Catch_Statement</ParentLink>                <shapeText>Terminate</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow><Metadata>

<TrkMetadata>
<ActionName>'ProcessLogic'</ActionName><IsAtomic>0</IsAtomic><Line>841</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
</TrkMetadata>

<TrkMetadata>
<Line>872</Line><Position>22</Position><ShapeID>'e2ea0da0-d7b5-4af2-b8ac-350fe2ef6466'</ShapeID>
<Messages>
	<MsgInfo><name>SingleNotificationEventMsg</name><part>MessagePart</part><schema>DLAPEventsSalesforceDefinition.SingleNotificationEvent</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<ActionName>'??__scope35'</ActionName><IsAtomic>0</IsAtomic><Line>888</Line><Position>13</Position><ShapeID>'d0023d93-2d4c-487c-880f-73e070a50553'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>895</Line><Position>39</Position><ShapeID>'1057fb8f-0194-4a95-a7db-f0a8c9855b3a'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>911</Line><Position>21</Position><ShapeID>'687ad16b-c3fe-44b1-b7cb-0a21dec125a8'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>915</Line><Position>53</Position><ShapeID>'f377d934-0366-49be-99c3-5acdedacc7bd'</ShapeID>
<Messages>
	<MsgInfo><name>StatusResponseMsg</name><part>MessagePart</part><schema>DLAPEventsDefinition.EventStatusResponse</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>SingleNotificationEventMsg</name><part>MessagePart</part><schema>DLAPEventsSalesforceDefinition.SingleNotificationEvent</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>917</Line><Position>25</Position><ShapeID>'16874ef5-8197-4c22-bbad-8b7d39b76169'</ShapeID>
<Messages>
	<MsgInfo><name>OracleEventNotificationRequestMsg</name><part>MessagePart</part><schema>DLAPEventsOracleDefinition.OracleEventNotification+Insert</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>SingleNotificationEventMsg</name><part>MessagePart</part><schema>DLAPEventsSalesforceDefinition.SingleNotificationEvent</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>932</Line><Position>55</Position><ShapeID>'604eae71-1f71-4a65-a543-7e40b54ecb20'</ShapeID>
<Messages>
	<MsgInfo><name>SingleNotificationEventMsg</name><part>MessagePart</part><schema>DLAPEventsSalesforceDefinition.SingleNotificationEvent</schema><direction>In</direction></MsgInfo>
	<MsgInfo><name>DocumentResponseMsg</name><part>MessagePart</part><schema>DLAPEventsDefinition.EventDocumentListResponse</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>934</Line><Position>25</Position><ShapeID>'7e09cc83-6023-4e01-ab52-924dca5527e2'</ShapeID>
<Messages>
	<MsgInfo><name>OracleEventNotificationRequestMsg</name><part>MessagePart</part><schema>DLAPEventsOracleDefinition.OracleEventNotification+Insert</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>SingleNotificationEventMsg</name><part>MessagePart</part><schema>DLAPEventsSalesforceDefinition.SingleNotificationEvent</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>951</Line><Position>33</Position><ShapeID>'c19a9e6c-b5d2-4f6d-9cb5-107c37dee52d'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>959</Line><Position>54</Position><ShapeID>'5cf1137a-9f2b-49d1-b317-6a186319a5d1'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>961</Line><Position>25</Position><ShapeID>'79306503-8674-4b41-8f30-6a8c7de9179b'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>964</Line><Position>21</Position><ShapeID>'f070f669-6261-428d-be3c-1104bec87cb5'</ShapeID>
<Messages>
	<MsgInfo><name>OracleEventNotificationRequestMsg</name><part>MessagePart</part><schema>DLAPEventsOracleDefinition.OracleEventNotification+Insert</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>966</Line><Position>21</Position><ShapeID>'33899330-d30d-49d5-984b-64ae18720186'</ShapeID>
<Messages>
	<MsgInfo><name>OracleEventNotificationResponseMsg</name><part>MessagePart</part><schema>DLAPEventsOracleDefinition.OracleEventNotification+InsertResponse</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>968</Line><Position>40</Position><ShapeID>'41fbc912-f350-4904-8e7a-b334dceef314'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>970</Line><Position>21</Position><ShapeID>'26efe9df-a4b5-43db-b93f-45a60ea0db2d'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>974</Line><Position>31</Position><ShapeID>'cd943a38-e9f2-4109-be33-4852b9d6f45b'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>986</Line><Position>33</Position><ShapeID>'1f1171f5-fa36-4358-8a2f-da0a722ed065'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>993</Line><Position>50</Position><ShapeID>'04cd7dd9-cf34-4e05-a830-ee691ad130f2'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>998</Line><Position>21</Position><ShapeID>'c3f16b07-6828-4d8a-887e-6de53677a0da'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1001</Line><Position>25</Position><ShapeID>'730ca7c5-f219-49d0-be77-2c942de21371'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1026</Line><Position>54</Position><ShapeID>'d0adfcc0-1cf9-40ea-8369-a25e66777fd7'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1028</Line><Position>25</Position><ShapeID>'978f33a9-6659-4cf9-b0b7-b76917fb3992'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='10062ff2-5137-44c5-8aaf-d7d191995f6c' LowerBound='1.1' HigherBound='241.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='DLAPEvents' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='ServiceDeclaration' OID='cab74aa5-52c2-4187-b61e-d8e37cbe73d4' ParentLink='Module_ServiceDeclaration' LowerBound='46.1' HigherBound='240.1'>
            <om:Property Name='InitializedTransactionType' Value='False' />
            <om:Property Name='IsInvokable' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='ProcessLogic' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='VariableDeclaration' OID='d596d002-6d29-4e8a-a5f2-05deb256937b' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='60.1' HigherBound='61.1'>
                <om:Property Name='UseDefaultConstructor' Value='True' />
                <om:Property Name='Type' Value='System.Xml.XmlDocument' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='TempDocumentResponse' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='7e1c5a1c-7111-4bd4-a5f0-f3113f478b01' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='61.1' HigherBound='62.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ApplicationNumber' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='092e8e62-bfe3-42d3-a59a-346086b0ae0a' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='62.1' HigherBound='63.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='LogMessage' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='fae3832d-30f4-45a8-b0dd-c3c6a869fbc6' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='63.1' HigherBound='64.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SFObjectID' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='8f982089-747a-44f3-94a3-9e9cb61af255' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='64.1' HigherBound='65.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SFObjectName' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='c72a746c-0ba1-45a1-b727-ab22d97055bf' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='65.1' HigherBound='66.1'>
                <om:Property Name='UseDefaultConstructor' Value='True' />
                <om:Property Name='Type' Value='System.Xml.XmlDocument' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='TempStatusResponse' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='342ffee8-1769-4151-9dc5-67ca0b53f6fd' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='66.1' HigherBound='67.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='MessageTemp' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='f82258c4-eb5a-44df-a120-79c49d07d100' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='67.1' HigherBound='68.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ErrorMessage' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='b7e8e195-11b3-4188-90ab-0968432e723f' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='68.1' HigherBound='69.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.Guid' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='OrchestrationInstanceId' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='3e9714a1-64c8-4189-ae04-fcdf036a21e7' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='69.1' HigherBound='70.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Stage' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='b469b145-a31b-4d82-9d5b-68d8abd71e36' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='70.1' HigherBound='71.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Status' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='194d2f3d-2850-4f41-85e6-1284cb2d0665' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='71.1' HigherBound='72.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='EventRequestId' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='714fe673-1493-4d76-a0e0-8c4c8e426ead' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='72.1' HigherBound='73.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Empty' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='c447b0b7-08c7-4409-8599-f05f24e192f5' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='73.1' HigherBound='74.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Message' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='76dc7069-e1b4-4695-af2a-05d79c232692' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='74.1' HigherBound='75.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='OracleInsertStatus' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='6cf33ccd-3da5-46b6-8a12-62f5381ac264' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='53.1' HigherBound='54.1'>
                <om:Property Name='Type' Value='DLAPEvents.DocumentResponseType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='DocumentResponseMsg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='f362f750-4091-4d96-8938-0cf5aa2fbc83' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='54.1' HigherBound='55.1'>
                <om:Property Name='Type' Value='DLAPEvents.StatusResponseType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='StatusResponseMsg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='18b90747-3d91-435e-b9b0-ef9e01fa9829' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='55.1' HigherBound='56.1'>
                <om:Property Name='Type' Value='DLAPEvents.OracleEventNotificationRequestType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='OracleEventNotificationRequestMsg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='577ce9c3-fdbc-409a-af28-44ede69c3b02' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='56.1' HigherBound='57.1'>
                <om:Property Name='Type' Value='DLAPEvents.OracleEventNotificationResponseType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='OracleEventNotificationResponseMsg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='f131e660-bcc3-4c95-9c26-5393b1ee2ecc' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='57.1' HigherBound='58.1'>
                <om:Property Name='Type' Value='DLAPEvents.SalesforceEventRequestType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SalesforceEventRequestMsg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='272845ae-8def-46bc-9428-a0ac6b5f66b5' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='58.1' HigherBound='59.1'>
                <om:Property Name='Type' Value='DLAPEvents.SalesforceEventResponseType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SalesforceEventResponseMsg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='dc5e2bca-693a-4f96-a802-22a0f0fb7d09' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='59.1' HigherBound='60.1'>
                <om:Property Name='Type' Value='DLAPEvents.SingleNotificationEventType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SingleNotificationEventMsg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='ServiceBody' OID='a5dfd349-1cbe-4402-8c63-b48f5ebbf506' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='Receive' OID='e2ea0da0-d7b5-4af2-b8ac-350fe2ef6466' ParentLink='ServiceBody_Statement' LowerBound='77.1' HigherBound='93.1'>
                    <om:Property Name='Activate' Value='True' />
                    <om:Property Name='PortName' Value='SalesforceNotificationEventPort' />
                    <om:Property Name='MessageName' Value='SingleNotificationEventMsg' />
                    <om:Property Name='OperationName' Value='Operation' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Receive Salesforce Notification Single Request' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Scope' OID='d0023d93-2d4c-487c-880f-73e070a50553' ParentLink='ServiceBody_Statement' LowerBound='93.1' HigherBound='238.1'>
                    <om:Property Name='InitializedTransactionType' Value='True' />
                    <om:Property Name='IsSynchronized' Value='False' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='DLAP Events Error Scope' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='Task' OID='d12b70c3-6b6d-46a1-8ec8-131da1e538eb' ParentLink='ComplexStatement_Statement' LowerBound='98.1' HigherBound='200.1'>
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='DLAP Events Processing' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='VariableAssignment' OID='1057fb8f-0194-4a95-a7db-f0a8c9855b3a' ParentLink='ComplexStatement_Statement' LowerBound='98.1' HigherBound='116.1'>
                            <om:Property Name='Expression' Value='//Extracting SF Notification Request Values&#xD;&#xA;&#xD;&#xA;ApplicationNumber = xpath(SingleNotificationEventMsg.MessagePart, &quot;string(/*[local-name()=&apos;Notifications&apos; and namespace-uri()=&apos;http://DLAPEventsSalesforceDefinition/SingleNotificationEvent&apos;]/*[local-name()=&apos;Notification&apos; and namespace-uri()=&apos;http://soap.sforce.com/2005/09/outbound&apos;]/*[local-name()=&apos;sObject&apos; and namespace-uri()=&apos;http://soap.sforce.com/2005/09/outbound&apos;]/*[local-name()=&apos;Application_Number__c&apos; and namespace-uri()=&apos;urn:sobject.enterprise.soap.sforce.com&apos;])&quot;);&#xD;&#xA;&#xD;&#xA;LogMessage = xpath(SingleNotificationEventMsg.MessagePart, &quot;string(/*[local-name()=&apos;Notifications&apos; and namespace-uri()=&apos;http://DLAPEventsSalesforceDefinition/SingleNotificationEvent&apos;]/*[local-name()=&apos;Notification&apos; and namespace-uri()=&apos;http://soap.sforce.com/2005/09/outbound&apos;]/*[local-name()=&apos;sObject&apos; and namespace-uri()=&apos;http://soap.sforce.com/2005/09/outbound&apos;]/*[local-name()=&apos;Log_Message__c&apos; and namespace-uri()=&apos;urn:sobject.enterprise.soap.sforce.com&apos;])&quot;);&#xD;&#xA;&#xD;&#xA;SFObjectID = xpath(SingleNotificationEventMsg.MessagePart, &quot;string(/*[local-name()=&apos;Notifications&apos; and namespace-uri()=&apos;http://DLAPEventsSalesforceDefinition/SingleNotificationEvent&apos;]/*[local-name()=&apos;Notification&apos; and namespace-uri()=&apos;http://soap.sforce.com/2005/09/outbound&apos;]/*[local-name()=&apos;sObject&apos; and namespace-uri()=&apos;http://soap.sforce.com/2005/09/outbound&apos;]/*[local-name()=&apos;SObject_ID__c&apos; and namespace-uri()=&apos;urn:sobject.enterprise.soap.sforce.com&apos;])&quot;);&#xD;&#xA;&#xD;&#xA;SFObjectName = xpath(SingleNotificationEventMsg.MessagePart, &quot;string(/*[local-name()=&apos;Notifications&apos; and namespace-uri()=&apos;http://DLAPEventsSalesforceDefinition/"+
@"SingleNotificationEvent&apos;]/*[local-name()=&apos;Notification&apos; and namespace-uri()=&apos;http://soap.sforce.com/2005/09/outbound&apos;]/*[local-name()=&apos;sObject&apos; and namespace-uri()=&apos;http://soap.sforce.com/2005/09/outbound&apos;]/*[local-name()=&apos;SObject_Name__c&apos; and namespace-uri()=&apos;urn:sobject.enterprise.soap.sforce.com&apos;])&quot;);&#xD;&#xA;&#xD;&#xA;EventRequestId = xpath(SingleNotificationEventMsg.MessagePart, &quot;string(/*[local-name()=&apos;Notifications&apos; and namespace-uri()=&apos;http://DLAPEventsSalesforceDefinition/SingleNotificationEvent&apos;]/*[local-name()=&apos;Notification&apos; and namespace-uri()=&apos;http://soap.sforce.com/2005/09/outbound&apos;]/*[local-name()=&apos;sObject&apos; and namespace-uri()=&apos;http://soap.sforce.com/2005/09/outbound&apos;]/*[local-name()=&apos;Id&apos; and namespace-uri()=&apos;urn:sobject.enterprise.soap.sforce.com&apos;])&quot;);&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;OrchestrationInstanceId = Microsoft.XLANGs.Core.Service.RootService.InstanceId;&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Extracting Notification Values' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                        <om:Element Type='Decision' OID='687ad16b-c3fe-44b1-b7cb-0a21dec125a8' ParentLink='ComplexStatement_Statement' LowerBound='116.1' HigherBound='169.1'>
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Decide STATUS or DOCUMENT?' />
                            <om:Property Name='Signal' Value='True' />
                            <om:Element Type='DecisionBranch' OID='af06bd87-4027-49be-b473-18c4dd5e962e' ParentLink='ReallyComplexStatement_Branch' LowerBound='117.21' HigherBound='135.1'>
                                <om:Property Name='Expression' Value='&#xD;&#xA;((!System.String.IsNullOrWhiteSpace(ApplicationNumber))&amp;&amp;(!System.String.IsNullOrWhiteSpace(LogMessage)))&amp;&amp;(System.String.IsNullOrWhiteSpace(SFObjectID))&#xD;&#xA;' />
                                <om:Property Name='IsGhostBranch' Value='True' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='STATUS' />
                                <om:Property Name='Signal' Value='False' />
                                <om:Element Type='Call' OID='f377d934-0366-49be-99c3-5acdedacc7bd' ParentLink='ComplexStatement_Statement' LowerBound='120.1' HigherBound='122.1'>
                                    <om:Property Name='Identifier' Value='CallStatusOrchestration' />
                                    <om:Property Name='Invokee' Value='DLAPEvents.StatusLogic' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='Call Event Status Orchestration' />
                                    <om:Property Name='Signal' Value='False' />
                                    <om:Element Type='Parameter' OID='43100881-d2bf-4f97-a2b6-c2503ae38955' ParentLink='InvokeStatement_Parameter'>
                                        <om:Property Name='Direction' Value='Out' />
                                        <om:Property Name='Name' Value='StatusResponseMsg' />
                                        <om:Property Name='Type' Value='DLAPEvents.StatusResponseType' />
                                        <om:Property Name='Signal' Value='False' />
                                    </om:Element>
                                    <om:Element Type='Parameter' OID='576449ea-9ee1-45a0-8af6-98a91409a763' ParentLink='InvokeStatement_Parameter'>
                                        <om:Property Name='Direction' Value='In' />
                                        <om:Property Name='Name' Value='SingleNotificationEventMsg' />
                                        <om:Property Name='Type' Value='DLAPEvents.SingleNotificationEventType' />
                                        <om:Property Name='Signal' Value='False' />
                                    </om:Element>
                                </om:Element>
                                <om:Element Type='Construct' OID='16874ef5-8197-4c22-bbad-8b7d39b76169' ParentLink='ComplexStatement_Statement' LowerBound='122.1' HigherBound='134.1'>
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='Construct Oracle Status Event Notification Request Msg' />
                                    <om:Property Name='Signal' Value='True' />
                                    <om:Element Type='Transform' OID='7e39a3a7-3c15-4102-a12d-22a251c2607d' ParentLink='ComplexStatement_Statement' LowerBound='125.1' HigherBound='127.1'>
                                        <om:Property Name='ClassName' Value='DLAPEventsLogic.MakeOracleEventNotificationStatusRequest' />
                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                        <om:Property Name='Name' Value='Make Oracle Event Notification Request' />
                                        <om:Property Name='Signal' Value='True' />
                                        <om:Element Type='MessagePartRef' OID='2b690cff-0e69-453d-a346-a367e4f5f747' ParentLink='Transform_InputMessagePartRef' LowerBound='126.147' HigherBound='126.185'>
                                            <om:Property Name='MessageRef' Value='SingleNotificationEventMsg' />
                                            <om:Property Name='PartRef' Value='MessagePart' />
                                            <om:Property Name='ReportToAnalyst' Value='True' />
                                            <om:Property Name='Name' Value='MessagePartReference_1' />
                                            <om:Property Name='Signal' Value='False' />
                                        </om:Element>
                                        <om:Element Type='MessagePartRef' OID='6e9db079-c5d9-4ab1-bb25-a9d896edbf77' ParentLink='Transform_OutputMessagePartRef' LowerBound='126.40' HigherBound='126.85'>
                                            <om:Property Name='MessageRef' Value='OracleEventNotificationRequestMsg' />
                                            <om:Property Name='PartRef' Value='MessagePart' />
                                            <om:Property Name='ReportToAnalyst' Value='True' />
                                            <om:Property Name='Name' Value='MessagePartReference_2' />
                                            <om:Property Name='Signal' Value='False' />
                                        </om:Element>
                                    </om:Element>
                                    <om:Element Type='MessageAssignment' OID='39827598-58d1-48dc-84f5-c4644b55634d' ParentLink='ComplexStatement_Statement' LowerBound='127.1' HigherBound='133.1'>
                                        <om:Property Name='Expression' Value='TempStatusResponse = StatusResponseMsg.MessagePart;&#xD;&#xA;&#xD;&#xA;xpath(OracleEventNotificationRequestMsg.MessagePart,&quot;/*[local-name()=&apos;Insert&apos; and namespace-uri()=&apos;http://Microsoft.LobServices.OracleDB/2007/03/DCMS_INT/View/EVENT_NOTIFICATION_DCMS&apos;]/*[local-name()=&apos;RECORDSET&apos; and namespace-uri()=&apos;http://Microsoft.LobServices.OracleDB/2007/03/DCMS_INT/View/EVENT_NOTIFICATION_DCMS&apos;]/*[local-name()=&apos;EVENT_NOTIFICATION_DCMSRECORDINSERT&apos; and namespace-uri()=&apos;http://Microsoft.LobServices.OracleDB/2007/03/DCMS_INT/View/EVENT_NOTIFICATION_DCMS&apos;]/*[local-name()=&apos;EVENT_DATA&apos; and namespace-uri()=&apos;http://Microsoft.LobServices.OracleDB/2007/03/DCMS_INT/View/EVENT_NOTIFICATION_DCMS&apos;]&quot;) = TempStatusResponse.OuterXml;&#xD;&#xA;&#xD;&#xA;xpath(OracleEventNotificationRequestMsg.MessagePart,&quot;/*[local-name()=&apos;Insert&apos; and namespace-uri()=&apos;http://Microsoft.LobServices.OracleDB/2007/03/DCMS_INT/View/EVENT_NOTIFICATION_DCMS&apos;]/*[local-name()=&apos;RECORDSET&apos; and namespace-uri()=&apos;http://Microsoft.LobServices.OracleDB/2007/03/DCMS_INT/View/EVENT_NOTIFICATION_DCMS&apos;]/*[local-name()=&apos;EVENT_NOTIFICATION_DCMSRECORDINSERT&apos; and namespace-uri()=&apos;http://Microsoft.LobServices.OracleDB/2007/03/DCMS_INT/View/EVENT_NOTIFICATION_DCMS&apos;]/*[local-name()=&apos;EVENT_TYPE&apos; and namespace-uri()=&apos;http://Microsoft.LobServices.OracleDB/2007/03/DCMS_INT/View/EVENT_NOTIFICATION_DCMS&apos;]&quot;) =&quot;STATUS&quot;;&#xD;&#xA;' />
                                        <om:Property Name='ReportToAnalyst' Value='False' />
                                        <om:Property Name='Name' Value='Inject XML Data' />
                                        <om:Property Name='Signal' Value='True' />
                                    </om:Element>
                                    <om:Element Type='MessageRef' OID='2663eb79-7590-45c3-83e0-e66828c365e9' ParentLink='Construct_MessageRef' LowerBound='123.35' HigherBound='123.68'>
                                        <om:Property Name='Ref' Value='OracleEventNotificationRequestMsg' />
                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                        <om:Property Name='Signal' Value='False' />
                                    </om:Element>
                                </om:Element>
                            </om:Element>
                            <om:Element Type='DecisionBranch' OID='cbdfb823-1ae5-4098-8833-f86ace3c8b93' ParentLink='ReallyComplexStatement_Branch' LowerBound='135.26' HigherBound='152.1'>
                                <om:Property Name='Expression' Value='((!System.String.IsNullOrWhiteSpace(ApplicationNumber))&amp;&amp;(!System.String.IsNullOrWhiteSpace(SFObjectID)))&amp;&amp;(System.String.IsNullOrWhiteSpace(LogMessage))' />
                                <om:Property Name='IsGhostBranch' Value='True' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='DOCUMENT' />
                                <om:Property Name='Signal' Value='True' />
                                <om:Element Type='Call' OID='604eae71-1f71-4a65-a543-7e40b54ecb20' ParentLink='ComplexStatement_Statement' LowerBound='137.1' HigherBound='139.1'>
                                    <om:Property Name='Identifier' Value='CallDocumentOrchestration' />
                                    <om:Property Name='Invokee' Value='DLAPEvents.DocumentLogic' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='Call Event Document Orchestration' />
                                    <om:Property Name='Signal' Value='False' />
                                    <om:Element Type='Parameter' OID='4bca4e98-9f44-4b1c-81ca-ce32918235ed' ParentLink='InvokeStatement_Parameter'>
                                        <om:Property Name='Direction' Value='In' />
                                        <om:Property Name='Name' Value='SingleNotificationEventMsg' />
                                        <om:Property Name='Type' Value='DLAPEvents.SingleNotificationEventType' />
                                        <om:Property Name='Signal' Value='False' />
                                    </om:Element>
                                    <om:Element Type='Parameter' OID='22a82d62-5d6b-410f-8fe7-9268ee594830' ParentLink='InvokeStatement_Parameter'>
                                        <om:Property Name='Direction' Value='Out' />
                                        <om:Property Name='Name' Value='DocumentResponseMsg' />
                                        <om:Property Name='Type' Value='DLAPEvents.DocumentResponseType' />
                                        <om:Property Name='Signal' Value='False' />
                                    </om:Element>
                                </om:Element>
                                <om:Element Type='Construct' OID='7e09cc83-6023-4e01-ab52-924dca5527e2' ParentLink='ComplexStatement_Statement' LowerBound='139.1' HigherBound='151.1'>
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='Construct Oracle Document Event Notification Request Msg' />
                                    <om:Property Name='Signal' Value='True' />
                                    <om:Element Type='MessageRef' OID='8fafed2e-6618-4a48-9bb1-d6fa17c69ba2' ParentLink='Construct_MessageRef' LowerBound='140.35' HigherBound='140.68'>
                                        <om:Property Name='Ref' Value='OracleEventNotificationRequestMsg' />
                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                        <om:Property Name='Signal' Value='False' />
                                    </om:Element>
                                    <om:Element Type='Transform' OID='992fb53c-d50e-4250-9b7e-ddc9f262b58a' ParentLink='ComplexStatement_Statement' LowerBound='142.1' HigherBound='144.1'>
                                        <om:Property Name='ClassName' Value='DLAPEventsLogic.MakeOracleEventNotificationStatusRequest' />
                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                        <om:Property Name='Name' Value='Make Oracle Event Notification Request' />
                                        <om:Property Name='Signal' Value='False' />
                                        <om:Element Type='MessagePartRef' OID='df4fdb3e-20a0-4b50-a27a-5bcde16c0c8a' ParentLink='Transform_InputMessagePartRef' LowerBound='143.147' HigherBound='143.185'>
                                            <om:Property Name='MessageRef' Value='SingleNotificationEventMsg' />
                                            <om:Property Name='PartRef' Value='MessagePart' />
                                            <om:Property Name='ReportToAnalyst' Value='True' />
                                            <om:Property Name='Name' Value='MessagePartReference_3' />
                                            <om:Property Name='Signal' Value='False' />
                                        </om:Element>
                                        <om:Element Type='MessagePartRef' OID='3b48b2db-53a8-46de-884d-f5daabdd6646' ParentLink='Transform_OutputMessagePartRef' LowerBound='143.40' HigherBound='143.85'>
                                            <om:Property Name='MessageRef' Value='OracleEventNotificationRequestMsg' />
                                            <om:Property Name='PartRef' Value='MessagePart' />
                                            <om:Property Name='ReportToAnalyst' Value='True' />
                                            <om:Property Name='Name' Value='MessagePartReference_4' />
                                            <om:Property Name='Signal' Value='False' />
                                        </om:Element>
                                    </om:Element>
                                    <om:Element Type='MessageAssignment' OID='105728d5-8f82-4dd0-8177-a715f35a9b05' ParentLink='ComplexStatement_Statement' LowerBound='144.1' HigherBound='150.1'>
                                        <om:Property Name='Expression' Value='TempDocumentResponse = DocumentResponseMsg.MessagePart;&#xD;&#xA;&#xD;&#xA;xpath(OracleEventNotificationRequestMsg.MessagePart,&quot;/*[local-name()=&apos;Insert&apos; and namespace-uri()=&apos;http://Microsoft.LobServices.OracleDB/2007/03/DCMS_INT/View/EVENT_NOTIFICATION_DCMS&apos;]/*[local-name()=&apos;RECORDSET&apos; and namespace-uri()=&apos;http://Microsoft.LobServices.OracleDB/2007/03/DCMS_INT/View/EVENT_NOTIFICATION_DCMS&apos;]/*[local-name()=&apos;EVENT_NOTIFICATION_DCMSRECORDINSERT&apos; and namespace-uri()=&apos;http://Microsoft.LobServices.OracleDB/2007/03/DCMS_INT/View/EVENT_NOTIFICATION_DCMS&apos;]/*[local-name()=&apos;EVENT_DATA&apos; and namespace-uri()=&apos;http://Microsoft.LobServices.OracleDB/2007/03/DCMS_INT/View/EVENT_NOTIFICATION_DCMS&apos;]&quot;) = TempDocumentResponse.OuterXml;&#xD;&#xA;&#xD;&#xA;xpath(OracleEventNotificationRequestMsg.MessagePart,&quot;/*[local-name()=&apos;Insert&apos; and namespace-uri()=&apos;http://Microsoft.LobServices.OracleDB/2007/03/DCMS_INT/View/EVENT_NOTIFICATION_DCMS&apos;]/*[local-name()=&apos;RECORDSET&apos; and namespace-uri()=&apos;http://Microsoft.LobServices.OracleDB/2007/03/DCMS_INT/View/EVENT_NOTIFICATION_DCMS&apos;]/*[local-name()=&apos;EVENT_NOTIFICATION_DCMSRECORDINSERT&apos; and namespace-uri()=&apos;http://Microsoft.LobServices.OracleDB/2007/03/DCMS_INT/View/EVENT_NOTIFICATION_DCMS&apos;]/*[local-name()=&apos;EVENT_TYPE&apos; and namespace-uri()=&apos;http://Microsoft.LobServices.OracleDB/2007/03/DCMS_INT/View/EVENT_NOTIFICATION_DCMS&apos;]&quot;) =&quot;DOCUMENT&quot;;' />
                                        <om:Property Name='ReportToAnalyst' Value='False' />
                                        <om:Property Name='Name' Value='Inject XML Data' />
                                        <om:Property Name='Signal' Value='True' />
                                    </om:Element>
                                </om:Element>
                            </om:Element>
                            <om:Element Type='DecisionBranch' OID='fd683370-8fbd-4a47-8e24-76a349a6ccb4' ParentLink='ReallyComplexStatement_Branch'>
                                <om:Property Name='IsGhostBranch' Value='True' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Else' />
                                <om:Property Name='Signal' Value='False' />
                                <om:Element Type='VariableAssignment' OID='c19a9e6c-b5d2-4f6d-9cb5-107c37dee52d' ParentLink='ComplexStatement_Statement' LowerBound='154.1' HigherBound='164.1'>
                                    <om:Property Name='Expression' Value='&#xD;&#xA;&#xD;&#xA;Message = &quot;DLAP Events SF Notification Request Validation Failed for STATUS/DOCUMENT&quot;;&#xD;&#xA;&#xD;&#xA;Stage = &quot;Notification Sent to DLAP&quot;;&#xD;&#xA;&#xD;&#xA;Status = &quot;Error&quot;;&#xD;&#xA;&#xD;&#xA;OrchestrationInstanceId = Microsoft.XLANGs.Core.Service.RootService.InstanceId;' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='Set Error Values' />
                                    <om:Property Name='Signal' Value='True' />
                                </om:Element>
                                <om:Element Type='Call' OID='5cf1137a-9f2b-49d1-b317-6a186319a5d1' ParentLink='ComplexStatement_Statement' LowerBound='164.1' HigherBound='166.1'>
                                    <om:Property Name='Identifier' Value='CallOrchestration_2' />
                                    <om:Property Name='Invokee' Value='DLAPEvents.EventRequest' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='Call Event Request Update Orchestration' />
                                    <om:Property Name='Signal' Value='True' />
                                    <om:Element Type='Parameter' OID='4daeea25-336b-48d1-8081-57b1ad9c2772' ParentLink='InvokeStatement_Parameter'>
                                        <om:Property Name='Direction' Value='In' />
                                        <om:Property Name='Name' Value='ApplicationNumber' />
                                        <om:Property Name='Type' Value='System.String' />
                                        <om:Property Name='Signal' Value='False' />
                                    </om:Element>
                                    <om:Element Type='Parameter' OID='c4ea263c-82f7-4c96-878d-4bed1cd9fefd' ParentLink='InvokeStatement_Parameter'>
                                        <om:Property Name='Direction' Value='In' />
                                        <om:Property Name='Name' Value='SFObjectID' />
                                        <om:Property Name='Type' Value='System.String' />
                                        <om:Property Name='Signal' Value='False' />
                                    </om:Element>
                                    <om:Element Type='Parameter' OID='b9c92ea1-0b87-432c-b58d-ac67c68f278a' ParentLink='InvokeStatement_Parameter'>
                                        <om:Property Name='Direction' Value='In' />
                                        <om:Property Name='Name' Value='Message' />
                                        <om:Property Name='Type' Value='System.String' />
                                        <om:Property Name='Signal' Value='False' />
                                    </om:Element>
                                    <om:Element Type='Parameter' OID='3daf1c28-607e-4f19-abfd-345dc3d133c4' ParentLink='InvokeStatement_Parameter'>
                                        <om:Property Name='Direction' Value='In' />
                                        <om:Property Name='Name' Value='SFObjectName' />
                                        <om:Property Name='Type' Value='System.String' />
                                        <om:Property Name='Signal' Value='False' />
                                    </om:Element>
                                    <om:Element Type='Parameter' OID='0fdcd268-67ca-44a5-84b1-09c79dc9541d' ParentLink='InvokeStatement_Parameter'>
                                        <om:Property Name='Direction' Value='In' />
                                        <om:Property Name='Name' Value='Stage' />
                                        <om:Property Name='Type' Value='System.String' />
                                        <om:Property Name='Signal' Value='False' />
                                    </om:Element>
                                    <om:Element Type='Parameter' OID='38a0221f-1e30-4e48-9769-883dc961649b' ParentLink='InvokeStatement_Parameter'>
                                        <om:Property Name='Direction' Value='In' />
                                        <om:Property Name='Name' Value='Status' />
                                        <om:Property Name='Type' Value='System.String' />
                                        <om:Property Name='Signal' Value='False' />
                                    </om:Element>
                                    <om:Element Type='Parameter' OID='b53efc4c-b860-4b09-95e1-ef05d9cf9ef8' ParentLink='InvokeStatement_Parameter'>
                                        <om:Property Name='Direction' Value='In' />
                                        <om:Property Name='Name' Value='Empty' />
                                        <om:Property Name='Type' Value='System.String' />
                                        <om:Property Name='Signal' Value='False' />
                                    </om:Element>
                                    <om:Element Type='Parameter' OID='f9bf2014-586b-4616-a91d-da6d505f711f' ParentLink='InvokeStatement_Parameter'>
                                        <om:Property Name='Direction' Value='In' />
                                        <om:Property Name='Name' Value='OrchestrationInstanceId' />
                                        <om:Property Name='Type' Value='System.Guid' />
                                        <om:Property Name='Signal' Value='False' />
                                    </om:Element>
                                    <om:Element Type='Parameter' OID='682f3c2c-3660-4e00-8752-07c1ba292dff' ParentLink='InvokeStatement_Parameter'>
                                        <om:Property Name='Direction' Value='In' />
                                        <om:Property Name='Name' Value='EventRequestId' />
                                        <om:Property Name='Type' Value='System.String' />
                                        <om:Property Name='Signal' Value='False' />
                                    </om:Element>
                                </om:Element>
                                <om:Element Type='Terminate' OID='79306503-8674-4b41-8f30-6a8c7de9179b' ParentLink='ComplexStatement_Statement' LowerBound='166.1' HigherBound='168.1'>
                                    <om:Property Name='ErrorMessage' Value='&quot;DLAP Events SF Notification Request Validation Failed&quot;;' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='Terminate DLAP Events Process' />
                                    <om:Property Name='Signal' Value='True' />
                                </om:Element>
                            </om:Element>
                        </om:Element>
                        <om:Element Type='Send' OID='f070f669-6261-428d-be3c-1104bec87cb5' ParentLink='ComplexStatement_Statement' LowerBound='169.1' HigherBound='171.1'>
                            <om:Property Name='PortName' Value='OracleEventNotificationPort' />
                            <om:Property Name='MessageName' Value='OracleEventNotificationRequestMsg' />
                            <om:Property Name='OperationName' Value='Operation' />
                            <om:Property Name='OperationMessageName' Value='Request' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Send Oracle Event Notification Request' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                        <om:Element Type='Receive' OID='33899330-d30d-49d5-984b-64ae18720186' ParentLink='ComplexStatement_Statement' LowerBound='171.1' HigherBound='173.1'>
                            <om:Property Name='Activate' Value='False' />
                            <om:Property Name='PortName' Value='OracleEventNotificationPort' />
                            <om:Property Name='MessageName' Value='OracleEventNotificationResponseMsg' />
                            <om:Property Name='OperationName' Value='Operation' />
                            <om:Property Name='OperationMessageName' Value='Response' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Receive Oracle Event Notification Response' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                        <om:Element Type='VariableAssignment' OID='41fbc912-f350-4904-8e7a-b334dceef314' ParentLink='ComplexStatement_Statement' LowerBound='173.1' HigherBound='175.1'>
                            <om:Property Name='Expression' Value='OracleInsertStatus = xpath(OracleEventNotificationResponseMsg.MessagePart,&quot;string(/*[local-name()=&apos;Root&apos; and namespace-uri()=&apos;http://schemas.microsoft.com/BizTalk/2003/aggschema&apos;]/*[local-name()=&apos;InputMessagePart_1&apos; and namespace-uri()=&apos;&apos;]/*[local-name()=&apos;InsertResponse&apos; and namespace-uri()=&apos;http://Microsoft.LobServices.OracleDB/2007/03/DCMS_INT/View/EVENT_NOTIFICATION_DCMS&apos;]/*[local-name()=&apos;InsertResult&apos; and namespace-uri()=&apos;http://Microsoft.LobServices.OracleDB/2007/03/DCMS_INT/View/EVENT_NOTIFICATION_DCMS&apos;])&quot;);' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Extract Values' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                        <om:Element Type='Decision' OID='26efe9df-a4b5-43db-b93f-45a60ea0db2d' ParentLink='ComplexStatement_Statement' LowerBound='175.1' HigherBound='198.1'>
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Success or Error?' />
                            <om:Property Name='Signal' Value='True' />
                            <om:Element Type='DecisionBranch' OID='40bdb364-0691-4ecf-8a79-8bcc7452a6aa' ParentLink='ReallyComplexStatement_Branch' LowerBound='176.21' HigherBound='187.1'>
                                <om:Property Name='Expression' Value='OracleInsertStatus != &quot;0&quot;' />
                                <om:Property Name='IsGhostBranch' Value='True' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Success' />
                                <om:Property Name='Signal' Value='True' />
                                <om:Element Type='VariableAssignment' OID='cd943a38-e9f2-4109-be33-4852b9d6f45b' ParentLink='ComplexStatement_Statement' LowerBound='178.1' HigherBound='186.1'>
                                    <om:Property Name='Expression' Value='&#xD;&#xA;Stage = &quot;Notification Sent to DLAP&quot;;&#xD;&#xA;&#xD;&#xA;Status = &quot;Success&quot;;&#xD;&#xA;&#xD;&#xA;Message = &quot;Successfully Sent Notification to DLAP&quot;;&#xD;&#xA;&#xD;&#xA;' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='Set Values' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                            </om:Element>
                            <om:Element Type='DecisionBranch' OID='91da081c-dab5-4f8a-ad48-d193394fed09' ParentLink='ReallyComplexStatement_Branch'>
                                <om:Property Name='IsGhostBranch' Value='True' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Else' />
                                <om:Property Name='Signal' Value='False' />
                                <om:Element Type='VariableAssignment' OID='1f1171f5-fa36-4358-8a2f-da0a722ed065' ParentLink='ComplexStatement_Statement' LowerBound='189.1' HigherBound='197.1'>
                                    <om:Property Name='Expression' Value='&#xD;&#xA;&#xD;&#xA;Message = &quot;DLAP Notification Oracle Insertion Failed&quot;;&#xD;&#xA;&#xD;&#xA;Stage = &quot;Notification Sent to DLAP&quot;;&#xD;&#xA;&#xD;&#xA;Status = &quot;Error&quot;;' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='Set Error Values' />
                                    <om:Property Name='Signal' Value='True' />
                                </om:Element>
                            </om:Element>
                        </om:Element>
                        <om:Element Type='Call' OID='04cd7dd9-cf34-4e05-a830-ee691ad130f2' ParentLink='ComplexStatement_Statement' LowerBound='198.1' HigherBound='200.1'>
                            <om:Property Name='Identifier' Value='CallOrchestration_1' />
                            <om:Property Name='Invokee' Value='DLAPEvents.EventRequest' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Call Event Request Update Orchestration' />
                            <om:Property Name='Signal' Value='True' />
                            <om:Element Type='Parameter' OID='fec054d6-fe84-4034-82df-9c4b9107861a' ParentLink='InvokeStatement_Parameter'>
                                <om:Property Name='Direction' Value='In' />
                                <om:Property Name='Name' Value='ApplicationNumber' />
                                <om:Property Name='Type' Value='System.String' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='Parameter' OID='b6482677-bb1c-4fba-af02-c7cafc089875' ParentLink='InvokeStatement_Parameter'>
                                <om:Property Name='Direction' Value='In' />
                                <om:Property Name='Name' Value='SFObjectID' />
                                <om:Property Name='Type' Value='System.String' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='Parameter' OID='82d7227b-b530-47e7-aed7-757a5d7a3531' ParentLink='InvokeStatement_Parameter'>
                                <om:Property Name='Direction' Value='In' />
                                <om:Property Name='Name' Value='Message' />
                                <om:Property Name='Type' Value='System.String' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='Parameter' OID='7a6b65c6-c32c-4176-95c7-dc4e907fe9ae' ParentLink='InvokeStatement_Parameter'>
                                <om:Property Name='Direction' Value='In' />
                                <om:Property Name='Name' Value='SFObjectName' />
                                <om:Property Name='Type' Value='System.String' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='Parameter' OID='2f0ad188-2d2e-4f98-b24d-d12ea501088c' ParentLink='InvokeStatement_Parameter'>
                                <om:Property Name='Direction' Value='In' />
                                <om:Property Name='Name' Value='Stage' />
                                <om:Property Name='Type' Value='System.String' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='Parameter' OID='96648f73-c9b2-45ae-8b84-9348c3e7bcd9' ParentLink='InvokeStatement_Parameter'>
                                <om:Property Name='Direction' Value='In' />
                                <om:Property Name='Name' Value='Status' />
                                <om:Property Name='Type' Value='System.String' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='Parameter' OID='c01e6e70-12ac-43e3-9831-49fa305da0ff' ParentLink='InvokeStatement_Parameter'>
                                <om:Property Name='Direction' Value='In' />
                                <om:Property Name='Name' Value='Empty' />
                                <om:Property Name='Type' Value='System.String' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='Parameter' OID='37ffe96f-7fc3-4c36-94c7-4107edb9a236' ParentLink='InvokeStatement_Parameter'>
                                <om:Property Name='Direction' Value='In' />
                                <om:Property Name='Name' Value='OrchestrationInstanceId' />
                                <om:Property Name='Type' Value='System.Guid' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='Parameter' OID='da3786f7-80dc-41bb-8de6-b17e0dd17637' ParentLink='InvokeStatement_Parameter'>
                                <om:Property Name='Direction' Value='In' />
                                <om:Property Name='Name' Value='EventRequestId' />
                                <om:Property Name='Type' Value='System.String' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                        </om:Element>
                    </om:Element>
                    <om:Element Type='Catch' OID='c3f16b07-6828-4d8a-887e-6de53677a0da' ParentLink='Scope_Catch' LowerBound='203.1' HigherBound='236.1'>
                        <om:Property Name='ExceptionName' Value='EEx' />
                        <om:Property Name='ExceptionType' Value='System.Exception' />
                        <om:Property Name='IsFaultMessage' Value='False' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='System Exception' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='VariableAssignment' OID='730ca7c5-f219-49d0-be77-2c942de21371' ParentLink='Catch_Statement' LowerBound='206.1' HigherBound='231.1'>
                            <om:Property Name='Expression' Value='if(EEx.InnerException != null)&#xD;&#xA;{&#xD;&#xA;MessageTemp = EEx.InnerException.ToString();&#xD;&#xA;&#xD;&#xA;ErrorMessage = MessageTemp.Substring(0, System.Convert.ToInt32(System.Math.Min(900, MessageTemp.Length))) +&quot;Total String Length:&quot;+MessageTemp.Length.ToString();&#xD;&#xA;&#xD;&#xA;System.Diagnostics.EventLog.WriteEntry(&quot;DLAP Events Exception&quot;,ErrorMessage,System.Diagnostics.EventLogEntryType.Error);&#xD;&#xA;&#xD;&#xA;}&#xD;&#xA;&#xD;&#xA;else&#xD;&#xA;{&#xD;&#xA;MessageTemp = EEx.Message.ToString();&#xD;&#xA;&#xD;&#xA;ErrorMessage = MessageTemp.Substring(0, System.Convert.ToInt32(System.Math.Min(900, MessageTemp.Length))) +&quot;Total String Length:&quot;+MessageTemp.Length.ToString();&#xD;&#xA;&#xD;&#xA;System.Diagnostics.EventLog.WriteEntry(&quot;DLAP Events Exception&quot;,ErrorMessage,System.Diagnostics.EventLogEntryType.Error);&#xD;&#xA;}&#xD;&#xA;&#xD;&#xA;OrchestrationInstanceId = Microsoft.XLANGs.Core.Service.RootService.InstanceId;&#xD;&#xA;&#xD;&#xA;Stage = &quot;Notification Sent to DLAP&quot;;&#xD;&#xA;&#xD;&#xA;Status = &quot;Error&quot;;' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Set Error Values' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                        <om:Element Type='Call' OID='d0adfcc0-1cf9-40ea-8369-a25e66777fd7' ParentLink='Catch_Statement' LowerBound='231.1' HigherBound='233.1'>
                            <om:Property Name='Identifier' Value='CallEventRequestUpdateOrchestration' />
                            <om:Property Name='Invokee' Value='DLAPEvents.EventRequest' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Call Event Request Update Orchestration' />
                            <om:Property Name='Signal' Value='False' />
                            <om:Element Type='Parameter' OID='8ab9fe6a-0d02-4efb-b0a7-23a9c6b6e32b' ParentLink='InvokeStatement_Parameter'>
                                <om:Property Name='Direction' Value='In' />
                                <om:Property Name='Name' Value='ApplicationNumber' />
                                <om:Property Name='Type' Value='System.String' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='Parameter' OID='07d75c59-fa63-45e4-bb44-d473d07eece3' ParentLink='InvokeStatement_Parameter'>
                                <om:Property Name='Direction' Value='In' />
                                <om:Property Name='Name' Value='SFObjectID' />
                                <om:Property Name='Type' Value='System.String' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='Parameter' OID='57e6518c-89ab-41f6-adf2-c7c8ae1831df' ParentLink='InvokeStatement_Parameter'>
                                <om:Property Name='Direction' Value='In' />
                                <om:Property Name='Name' Value='ErrorMessage' />
                                <om:Property Name='Type' Value='System.String' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='Parameter' OID='bf84a487-f182-4010-bb35-05470d9979a5' ParentLink='InvokeStatement_Parameter'>
                                <om:Property Name='Direction' Value='In' />
                                <om:Property Name='Name' Value='SFObjectName' />
                                <om:Property Name='Type' Value='System.String' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='Parameter' OID='c53895d6-64b2-40a4-8efc-5a5c52d6c26e' ParentLink='InvokeStatement_Parameter'>
                                <om:Property Name='Direction' Value='In' />
                                <om:Property Name='Name' Value='Stage' />
                                <om:Property Name='Type' Value='System.String' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='Parameter' OID='a23f64f1-367a-46a8-b266-9a885c10a06c' ParentLink='InvokeStatement_Parameter'>
                                <om:Property Name='Direction' Value='In' />
                                <om:Property Name='Name' Value='Status' />
                                <om:Property Name='Type' Value='System.String' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='Parameter' OID='e65ad802-fff4-4d1d-bfd8-d525119dd60d' ParentLink='InvokeStatement_Parameter'>
                                <om:Property Name='Direction' Value='In' />
                                <om:Property Name='Name' Value='Empty' />
                                <om:Property Name='Type' Value='System.String' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='Parameter' OID='d9740e13-8aad-4422-9dc7-67e60afb5350' ParentLink='InvokeStatement_Parameter'>
                                <om:Property Name='Direction' Value='In' />
                                <om:Property Name='Name' Value='OrchestrationInstanceId' />
                                <om:Property Name='Type' Value='System.Guid' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='Parameter' OID='bc912448-f0f1-4864-b46c-54b72f31775b' ParentLink='InvokeStatement_Parameter'>
                                <om:Property Name='Direction' Value='In' />
                                <om:Property Name='Name' Value='EventRequestId' />
                                <om:Property Name='Type' Value='System.String' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                        </om:Element>
                        <om:Element Type='Terminate' OID='978f33a9-6659-4cf9-b0b7-b76917fb3992' ParentLink='Catch_Statement' LowerBound='233.1' HigherBound='235.1'>
                            <om:Property Name='ErrorMessage' Value='&quot;An error occurred while processing the DLAP Events&quot;;' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Terminate' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                    </om:Element>
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='2581fa87-94ed-4a2f-a3ce-7d1cc3224e8f' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='49.1' HigherBound='51.1'>
                <om:Property Name='PortModifier' Value='Implements' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='DLAPEvents.SalesforceNotificationSingleEventPortType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SalesforceNotificationEventPort' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='DirectBindingAttribute' OID='548d8fb0-fad6-430d-855c-116adc915f8b' ParentLink='PortDeclaration_CLRAttribute' LowerBound='49.1' HigherBound='50.1'>
                    <om:Property Name='PartnerPort' Value='SalesforceNotificationEventPort' />
                    <om:Property Name='PartnerService' Value='DLAPEvents.ProcessLogic' />
                    <om:Property Name='DirectBindingType' Value='PartnerPort' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='957b98c7-f93a-44d5-ab75-a0d97c9957a1' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='51.1' HigherBound='53.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='48' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='DLAPEvents.OracleEventNotificationPortType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='OracleEventNotificationPort' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='8c358447-6dc2-4511-8403-e6055f346845' ParentLink='PortDeclaration_CLRAttribute' LowerBound='51.1' HigherBound='52.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='MultipartMessageType' OID='78704d25-1016-4518-acf8-83b0d29787e6' ParentLink='Module_MessageType' LowerBound='4.1' HigherBound='8.1'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='SingleNotificationEventType' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='PartDeclaration' OID='85ac0eb7-8360-45c6-9768-8dd5990b6409' ParentLink='MultipartMessageType_PartDeclaration' LowerBound='6.1' HigherBound='7.1'>
                <om:Property Name='ClassName' Value='DLAPEventsSalesforceDefinition.SingleNotificationEvent' />
                <om:Property Name='IsBodyPart' Value='True' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='MessagePart' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
        </om:Element>
        <om:Element Type='MultipartMessageType' OID='3cb596f4-f9bb-48f2-918c-e1b83896942b' ParentLink='Module_MessageType' LowerBound='8.1' HigherBound='12.1'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='StatusResponseType' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='PartDeclaration' OID='eba6753a-d6ec-40ef-9e2b-da3148b0495c' ParentLink='MultipartMessageType_PartDeclaration' LowerBound='10.1' HigherBound='11.1'>
                <om:Property Name='ClassName' Value='DLAPEventsDefinition.EventStatusResponse' />
                <om:Property Name='IsBodyPart' Value='True' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='MessagePart' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
        </om:Element>
        <om:Element Type='MultipartMessageType' OID='33cfec91-667f-46f9-9ee6-122c6ee26fcd' ParentLink='Module_MessageType' LowerBound='12.1' HigherBound='16.1'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='DocumentResponseType' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='PartDeclaration' OID='e64a16c2-aef9-4082-a54e-caecbeaa5148' ParentLink='MultipartMessageType_PartDeclaration' LowerBound='14.1' HigherBound='15.1'>
                <om:Property Name='ClassName' Value='DLAPEventsDefinition.EventDocumentListResponse' />
                <om:Property Name='IsBodyPart' Value='True' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='MessagePart' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
        </om:Element>
        <om:Element Type='MultipartMessageType' OID='f523bdc6-776f-4bd6-9668-1d0d745f5314' ParentLink='Module_MessageType' LowerBound='16.1' HigherBound='20.1'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='OracleEventNotificationRequestType' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='PartDeclaration' OID='9a9ff685-dcaf-457c-b4df-804858ae4b4b' ParentLink='MultipartMessageType_PartDeclaration' LowerBound='18.1' HigherBound='19.1'>
                <om:Property Name='ClassName' Value='DLAPEventsOracleDefinition.OracleEventNotification.Insert' />
                <om:Property Name='IsBodyPart' Value='True' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='MessagePart' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
        </om:Element>
        <om:Element Type='MultipartMessageType' OID='449cf230-4105-4fe0-ae3b-9fe5c8554f0b' ParentLink='Module_MessageType' LowerBound='20.1' HigherBound='24.1'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='OracleEventNotificationResponseType' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='PartDeclaration' OID='7a86fc9e-6b04-42c7-a534-cc86bfcf33ba' ParentLink='MultipartMessageType_PartDeclaration' LowerBound='22.1' HigherBound='23.1'>
                <om:Property Name='ClassName' Value='DLAPEventsOracleDefinition.OracleEventNotification.InsertResponse' />
                <om:Property Name='IsBodyPart' Value='True' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='MessagePart' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
        </om:Element>
        <om:Element Type='MultipartMessageType' OID='0bdbe99d-0b7d-4df4-a98f-dddb1fc0ad9a' ParentLink='Module_MessageType' LowerBound='24.1' HigherBound='28.1'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='SalesforceEventRequestType' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='PartDeclaration' OID='0f1bd916-4139-44fd-9adc-da346dd8d74c' ParentLink='MultipartMessageType_PartDeclaration' LowerBound='26.1' HigherBound='27.1'>
                <om:Property Name='ClassName' Value='DLAPEventsSalesforceDefinition.Salesforce_EventRequest.Request' />
                <om:Property Name='IsBodyPart' Value='True' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='MessagePart' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
        </om:Element>
        <om:Element Type='MultipartMessageType' OID='b778d0f9-7e1b-4981-980e-03743667b1dc' ParentLink='Module_MessageType' LowerBound='28.1' HigherBound='32.1'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='SalesforceEventResponseType' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='PartDeclaration' OID='6eb39da6-fad1-4efa-8489-1d203fb87f91' ParentLink='MultipartMessageType_PartDeclaration' LowerBound='30.1' HigherBound='31.1'>
                <om:Property Name='ClassName' Value='DLAPEventsSalesforceDefinition.Salesforce_EventRequest.Response' />
                <om:Property Name='IsBodyPart' Value='True' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='MessagePart' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='ba8a930a-7819-488f-a8a1-2eddd5caf3f9' ParentLink='Module_PortType' LowerBound='32.1' HigherBound='39.1'>
            <om:Property Name='Synchronous' Value='True' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='OracleEventNotificationPortType' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='OperationDeclaration' OID='8ce57377-62b3-48e0-9f76-1c9106c7c030' ParentLink='PortType_OperationDeclaration' LowerBound='34.1' HigherBound='38.1'>
                <om:Property Name='OperationType' Value='RequestResponse' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='3f0e2f0c-5c78-4b22-a0ba-d67a9f748200' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='36.13' HigherBound='36.47'>
                    <om:Property Name='Ref' Value='DLAPEvents.OracleEventNotificationRequestType' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
                <om:Element Type='MessageRef' OID='f2165db6-31b3-4fc3-b4dc-1e2ccffd25f5' ParentLink='OperationDeclaration_ResponseMessageRef' LowerBound='36.49' HigherBound='36.84'>
                    <om:Property Name='Ref' Value='DLAPEvents.OracleEventNotificationResponseType' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Response' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='1ccc8542-5f9f-41f0-842e-8e10a00dc8fc' ParentLink='Module_PortType' LowerBound='39.1' HigherBound='46.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='SalesforceNotificationSingleEventPortType' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='OperationDeclaration' OID='ec1652c2-8965-477a-92ff-0c1bcb702376' ParentLink='PortType_OperationDeclaration' LowerBound='41.1' HigherBound='45.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='677bd3a8-5d13-4435-bc33-cabc50d004ee' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='43.13' HigherBound='43.40'>
                    <om:Property Name='Ref' Value='DLAPEvents.SingleNotificationEventType' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
        </om:Element>
    </om:Element>
</om:MetaModel>
";

        [System.SerializableAttribute]
        public class __ProcessLogic_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __ProcessLogic_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "ProcessLogic")
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
                ProcessLogic __svc__ = (ProcessLogic)_service;
                __ProcessLogic_root_0 __ctx0__ = (__ProcessLogic_root_0)(__svc__._stateMgrs[0]);

                if (__svc__.SalesforceNotificationEventPort != null)
                {
                    __svc__.SalesforceNotificationEventPort.Close(this, null);
                    __svc__.SalesforceNotificationEventPort = null;
                }
                if (__svc__.OracleEventNotificationPort != null)
                {
                    __svc__.OracleEventNotificationPort.Close(this, null);
                    __svc__.OracleEventNotificationPort = null;
                }
                base.Finally();
            }

            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper0;
            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper1;
        }


        [System.SerializableAttribute]
        public class __ProcessLogic_1 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public __ProcessLogic_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "ProcessLogic")
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
                ProcessLogic __svc__ = (ProcessLogic)_service;
                __ProcessLogic_1 __ctx1__ = (__ProcessLogic_1)(__svc__._stateMgrs[1]);

                if (__ctx1__ != null)
                    __ctx1__.__Empty = null;
                if (__ctx1__ != null)
                    __ctx1__.__Message = null;
                if (__ctx1__ != null)
                    __ctx1__.__OracleInsertStatus = null;
                if (__ctx1__ != null)
                    __ctx1__.__Status = null;
                if (__ctx1__ != null)
                    __ctx1__.__EventRequestId = null;
                if (__ctx1__ != null)
                    __ctx1__.__SFObjectID = null;
                if (__ctx1__ != null)
                    __ctx1__.__ApplicationNumber = null;
                if (__ctx1__ != null)
                    __ctx1__.__ErrorMessage = null;
                if (__ctx1__ != null)
                    __ctx1__.__MessageTemp = null;
                if (__ctx1__ != null && __ctx1__.__SingleNotificationEventMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__SingleNotificationEventMsg);
                    __ctx1__.__SingleNotificationEventMsg = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__SFObjectName = null;
                if (__ctx1__ != null)
                    __ctx1__.__TempDocumentResponse = null;
                if (__ctx1__ != null)
                    __ctx1__.__TempStatusResponse = null;
                if (__ctx1__ != null)
                    __ctx1__.__Stage = null;
                if (__ctx1__ != null)
                    __ctx1__.__LogMessage = null;
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("DocumentResponseMsg")]
            internal DocumentResponseType __DocumentResponseMsg;
            [Microsoft.XLANGs.Core.UserVariableAttribute("StatusResponseMsg")]
            internal StatusResponseType __StatusResponseMsg;
            [Microsoft.XLANGs.Core.UserVariableAttribute("OracleEventNotificationRequestMsg")]
            internal OracleEventNotificationRequestType __OracleEventNotificationRequestMsg;
            [Microsoft.XLANGs.Core.UserVariableAttribute("OracleEventNotificationResponseMsg")]
            internal OracleEventNotificationResponseType __OracleEventNotificationResponseMsg;
            [Microsoft.XLANGs.Core.UserVariableAttribute("SingleNotificationEventMsg")]
            internal SingleNotificationEventType __SingleNotificationEventMsg;
            [Microsoft.XLANGs.Core.UserVariableAttribute("TempDocumentResponse")]
            internal Microsoft.XLANGs.RuntimeTypes.XmlDocumentSerializationProxy __TempDocumentResponse;
            [Microsoft.XLANGs.Core.UserVariableAttribute("ApplicationNumber")]
            internal System.String __ApplicationNumber;
            [Microsoft.XLANGs.Core.UserVariableAttribute("LogMessage")]
            internal System.String __LogMessage;
            [Microsoft.XLANGs.Core.UserVariableAttribute("SFObjectID")]
            internal System.String __SFObjectID;
            [Microsoft.XLANGs.Core.UserVariableAttribute("SFObjectName")]
            internal System.String __SFObjectName;
            [Microsoft.XLANGs.Core.UserVariableAttribute("TempStatusResponse")]
            internal Microsoft.XLANGs.RuntimeTypes.XmlDocumentSerializationProxy __TempStatusResponse;
            [Microsoft.XLANGs.Core.UserVariableAttribute("MessageTemp")]
            internal System.String __MessageTemp;
            [Microsoft.XLANGs.Core.UserVariableAttribute("ErrorMessage")]
            internal System.String __ErrorMessage;
            [Microsoft.XLANGs.Core.UserVariableAttribute("OrchestrationInstanceId")]
            internal System.Guid __OrchestrationInstanceId;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Stage")]
            internal System.String __Stage;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Status")]
            internal System.String __Status;
            [Microsoft.XLANGs.Core.UserVariableAttribute("EventRequestId")]
            internal System.String __EventRequestId;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Empty")]
            internal System.String __Empty;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Message")]
            internal System.String __Message;
            [Microsoft.XLANGs.Core.UserVariableAttribute("OracleInsertStatus")]
            internal System.String __OracleInsertStatus;
        }


        [System.SerializableAttribute]
        public class ____scope35_2 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public ____scope35_2(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "??__scope35")
            {
            }

            public override int Index { get { return 2; } }

            public override bool CombineParentCommit { get { return true; } }

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
                ProcessLogic __svc__ = (ProcessLogic)_service;
                ____scope35_2 __ctx2__ = (____scope35_2)(__svc__._stateMgrs[2]);
                __ProcessLogic_1 __ctx1__ = (__ProcessLogic_1)(__svc__._stateMgrs[1]);
                __ProcessLogic_root_0 __ctx0__ = (__ProcessLogic_root_0)(__svc__._stateMgrs[0]);

                if (__ctx2__ != null)
                    __ctx2__.__EEx_0 = null;
                if (__ctx1__ != null && __ctx1__.__StatusResponseMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__StatusResponseMsg);
                    __ctx1__.__StatusResponseMsg = null;
                }
                if (__ctx1__ != null && __ctx1__.__OracleEventNotificationRequestMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__OracleEventNotificationRequestMsg);
                    __ctx1__.__OracleEventNotificationRequestMsg = null;
                }
                if (__ctx1__ != null && __ctx1__.__OracleEventNotificationResponseMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__OracleEventNotificationResponseMsg);
                    __ctx1__.__OracleEventNotificationResponseMsg = null;
                }
                if (__ctx1__ != null && __ctx1__.__DocumentResponseMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__DocumentResponseMsg);
                    __ctx1__.__DocumentResponseMsg = null;
                }
                if (__ctx0__ != null && __ctx0__.__subWrapper1 != null)
                {
                    __ctx0__.__subWrapper1.Destroy(__svc__, __ctx0__);
                    __ctx0__.__subWrapper1 = null;
                }
                base.Finally();
            }

            internal object __exv__;
            internal System.Exception __EEx_0
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

        [Microsoft.XLANGs.BaseTypes.DirectBindingAttribute(typeof(ProcessLogic), "SalesforceNotificationEventPort")]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("SalesforceNotificationEventPort")]
        internal SalesforceNotificationSingleEventPortType SalesforceNotificationEventPort;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("OracleEventNotificationPort")]
        internal OracleEventNotificationPortType OracleEventNotificationPort;

        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {SalesforceNotificationSingleEventPortType.Operation},
                                               typeof(ProcessLogic).GetField("SalesforceNotificationEventPort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.implements,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(ProcessLogic), "SalesforceNotificationEventPort"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {OracleEventNotificationPortType.Operation},
                                               typeof(ProcessLogic).GetField("OracleEventNotificationPort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(ProcessLogic), "OracleEventNotificationPort"),
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
                    typeof(DLAPEvents.StatusLogic),
                    typeof(DLAPEvents.DocumentLogic),
                    typeof(DLAPEvents.EventRequest)                    
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
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "e2ea0da0-d7b5-4af2-b8ac-350fe2ef6466", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "e2ea0da0-d7b5-4af2-b8ac-350fe2ef6466", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "00000000-0000-0000-0000-000000000000", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "d0023d93-2d4c-487c-880f-73e070a50553", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "00000000-0000-0000-0000-000000000000", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(6, "1057fb8f-0194-4a95-a7db-f0a8c9855b3a", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(7, "1057fb8f-0194-4a95-a7db-f0a8c9855b3a", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(8, "00000000-0000-0000-0000-000000000000", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(9, "687ad16b-c3fe-44b1-b7cb-0a21dec125a8", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(10, "f377d934-0366-49be-99c3-5acdedacc7bd", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(11, "f377d934-0366-49be-99c3-5acdedacc7bd", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(12, "16874ef5-8197-4c22-bbad-8b7d39b76169", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(13, "16874ef5-8197-4c22-bbad-8b7d39b76169", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(14, "604eae71-1f71-4a65-a543-7e40b54ecb20", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(15, "604eae71-1f71-4a65-a543-7e40b54ecb20", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(16, "7e09cc83-6023-4e01-ab52-924dca5527e2", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(17, "7e09cc83-6023-4e01-ab52-924dca5527e2", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(18, "c19a9e6c-b5d2-4f6d-9cb5-107c37dee52d", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(19, "c19a9e6c-b5d2-4f6d-9cb5-107c37dee52d", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(20, "5cf1137a-9f2b-49d1-b317-6a186319a5d1", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(21, "5cf1137a-9f2b-49d1-b317-6a186319a5d1", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(22, "79306503-8674-4b41-8f30-6a8c7de9179b", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(23, "687ad16b-c3fe-44b1-b7cb-0a21dec125a8", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(24, "f070f669-6261-428d-be3c-1104bec87cb5", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(25, "f070f669-6261-428d-be3c-1104bec87cb5", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(26, "33899330-d30d-49d5-984b-64ae18720186", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(27, "33899330-d30d-49d5-984b-64ae18720186", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(28, "41fbc912-f350-4904-8e7a-b334dceef314", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(29, "41fbc912-f350-4904-8e7a-b334dceef314", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(30, "26efe9df-a4b5-43db-b93f-45a60ea0db2d", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(31, "cd943a38-e9f2-4109-be33-4852b9d6f45b", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(32, "cd943a38-e9f2-4109-be33-4852b9d6f45b", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(33, "1f1171f5-fa36-4358-8a2f-da0a722ed065", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(34, "1f1171f5-fa36-4358-8a2f-da0a722ed065", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(35, "26efe9df-a4b5-43db-b93f-45a60ea0db2d", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(36, "04cd7dd9-cf34-4e05-a830-ee691ad130f2", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(37, "04cd7dd9-cf34-4e05-a830-ee691ad130f2", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(38, "c3f16b07-6828-4d8a-887e-6de53677a0da", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(39, "730ca7c5-f219-49d0-be77-2c942de21371", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(40, "00000000-0000-0000-0000-000000000000", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(41, "00000000-0000-0000-0000-000000000000", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(42, "730ca7c5-f219-49d0-be77-2c942de21371", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(43, "d0adfcc0-1cf9-40ea-8369-a25e66777fd7", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(44, "d0adfcc0-1cf9-40ea-8369-a25e66777fd7", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(45, "978f33a9-6659-4cf9-b0b7-b76917fb3992", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(46, "c3f16b07-6828-4d8a-887e-6de53677a0da", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(47, "d0023d93-2d4c-487c-880f-73e070a50553", 1, false)
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
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Call),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Call),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Construct),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Terminate),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.If),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Send),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Catch),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Catch),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Scope),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Body)
        };

        public static int[] __progressLocation0 = new int[] { 0,0,0,3,3,};
        public static int[] __progressLocation1 = new int[] { 0,0,1,1,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,4,4,4,47,3,3,3,3,};
        public static int[] __progressLocation2 = new int[] { 6,6,6,7,7,7,7,7,7,9,9,10,10,11,12,12,13,9,9,9,14,14,15,16,16,17,17,18,18,19,19,19,19,20,20,21,22,22,22,23,24,24,24,25,26,26,27,28,28,29,30,30,31,31,32,32,32,30,33,33,34,34,34,35,36,36,37,37,37,37,};
        public static int[] __progressLocation3 = new int[] { 38,38,39,39,39,39,39,39,39,39,39,42,42,42,42,43,43,44,45,45,46,46,};

        public static int[][] __progressLocations = new int[4] [] {__progressLocation0,__progressLocation1,__progressLocation2,__progressLocation3};
        public override int[][] ProgressLocations {get {return __progressLocations;} }

        public Microsoft.XLANGs.Core.StopConditions segment0(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[0];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[0];
            __ProcessLogic_1 __ctx1__ = (__ProcessLogic_1)_stateMgrs[1];
            __ProcessLogic_root_0 __ctx0__ = (__ProcessLogic_root_0)_stateMgrs[0];

            switch (__seg__.Progress)
            {
            case 0:
                SalesforceNotificationEventPort = new SalesforceNotificationSingleEventPortType(0, this);
                OracleEventNotificationPort = new OracleEventNotificationPortType(1, this);
                __ctx__.PrologueCompleted = true;
                __ctx0__.__subWrapper0 = new Microsoft.XLANGs.Core.SubscriptionWrapper(ActivationSubGuids[0], SalesforceNotificationEventPort, this);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.Initialized) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.Initialized;
                goto case 1;
            case 1:
                __ctx1__ = new __ProcessLogic_1(this);
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
            __ProcessLogic_1 __ctx1__ = (__ProcessLogic_1)_stateMgrs[1];
            __ProcessLogic_root_0 __ctx0__ = (__ProcessLogic_root_0)_stateMgrs[0];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx1__.__TempDocumentResponse = new Microsoft.XLANGs.RuntimeTypes.XmlDocumentSerializationProxy();
                __ctx1__.__ApplicationNumber = default(System.String);
                __ctx1__.__LogMessage = default(System.String);
                __ctx1__.__SFObjectID = default(System.String);
                __ctx1__.__SFObjectName = default(System.String);
                __ctx1__.__TempStatusResponse = new Microsoft.XLANGs.RuntimeTypes.XmlDocumentSerializationProxy();
                __ctx1__.__MessageTemp = default(System.String);
                __ctx1__.__ErrorMessage = default(System.String);
                __ctx1__.__OrchestrationInstanceId = default(System.Guid);
                __ctx1__.__Stage = default(System.String);
                __ctx1__.__Status = default(System.String);
                __ctx1__.__EventRequestId = default(System.String);
                __ctx1__.__Empty = default(System.String);
                __ctx1__.__Message = default(System.String);
                __ctx1__.__OracleInsertStatus = default(System.String);
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
                if (!SalesforceNotificationEventPort.GetMessageId(__ctx0__.__subWrapper0.getSubscription(this), __seg__, __ctx1__, out __msgEnv__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx1__.__SingleNotificationEventMsg != null)
                    __ctx1__.UnrefMessage(__ctx1__.__SingleNotificationEventMsg);
                __ctx1__.__SingleNotificationEventMsg = new SingleNotificationEventType("SingleNotificationEventMsg", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__SingleNotificationEventMsg);
                SalesforceNotificationEventPort.ReceiveMessage(0, __msgEnv__, __ctx1__.__SingleNotificationEventMsg, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if (SalesforceNotificationEventPort != null)
                {
                    SalesforceNotificationEventPort.Close(__ctx1__, __seg__);
                    SalesforceNotificationEventPort = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__SingleNotificationEventMsg);
                    __edata.PortName = @"SalesforceNotificationEventPort";
                    Tracker.FireEvent(__eventLocations[2],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                __ctx1__.__TempDocumentResponse.UnderlyingXmlDocument = new System.Xml.XmlDocument();
                if ( !PostProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 6;
            case 6:
                __ctx1__.__ApplicationNumber = "";
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                __ctx1__.__LogMessage = "";
                if ( !PostProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 8;
            case 8:
                __ctx1__.__SFObjectID = "";
                if ( !PostProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 9;
            case 9:
                __ctx1__.__SFObjectName = "";
                if ( !PostProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 10;
            case 10:
                __ctx1__.__TempStatusResponse.UnderlyingXmlDocument = new System.Xml.XmlDocument();
                if ( !PostProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 11;
            case 11:
                __ctx1__.__MessageTemp = "";
                if ( !PostProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 12;
            case 12:
                __ctx1__.__ErrorMessage = "";
                if ( !PostProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 13;
            case 13:
                __ctx1__.__Stage = "";
                if ( !PostProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 14;
            case 14:
                __ctx1__.__Status = "";
                if ( !PostProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 15;
            case 15:
                __ctx1__.__EventRequestId = "";
                if ( !PostProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 16;
            case 16:
                __ctx1__.__Empty = "";
                if ( !PostProgressInc( __seg__, __ctx__, 17 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 17;
            case 17:
                __ctx1__.__Message = "";
                if ( !PostProgressInc( __seg__, __ctx__, 18 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 18;
            case 18:
                __ctx1__.__OracleInsertStatus = "";
                if ( !PostProgressInc( __seg__, __ctx__, 19 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 19;
            case 19:
                if ( !PreProgressInc( __seg__, __ctx__, 20 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[4],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 20;
            case 20:
                __ctx2__ = new ____scope35_2(this);
                _stateMgrs[2] = __ctx2__;
                if ( !PostProgressInc( __seg__, __ctx__, 21 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 21;
            case 21:
                __ctx1__.StartContext(__seg__, __ctx2__);
                if ( !PostProgressInc( __seg__, __ctx__, 22 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 22:
                if ( !PreProgressInc( __seg__, __ctx__, 23 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if (__ctx1__ != null)
                    __ctx1__.__OracleInsertStatus = null;
                if (__ctx1__ != null)
                    __ctx1__.__Message = null;
                if (__ctx1__ != null)
                    __ctx1__.__Empty = null;
                if (__ctx1__ != null)
                    __ctx1__.__EventRequestId = null;
                if (__ctx1__ != null)
                    __ctx1__.__Status = null;
                if (__ctx1__ != null)
                    __ctx1__.__Stage = null;
                if (__ctx1__ != null)
                    __ctx1__.__ErrorMessage = null;
                if (__ctx1__ != null)
                    __ctx1__.__MessageTemp = null;
                if (__ctx1__ != null)
                    __ctx1__.__TempStatusResponse = null;
                if (__ctx1__ != null)
                    __ctx1__.__SFObjectName = null;
                if (__ctx1__ != null)
                    __ctx1__.__SFObjectID = null;
                if (__ctx1__ != null)
                    __ctx1__.__LogMessage = null;
                if (__ctx1__ != null)
                    __ctx1__.__ApplicationNumber = null;
                if (__ctx1__ != null)
                    __ctx1__.__TempDocumentResponse = null;
                if (__ctx1__ != null && __ctx1__.__SingleNotificationEventMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__SingleNotificationEventMsg);
                    __ctx1__.__SingleNotificationEventMsg = null;
                }
                if (OracleEventNotificationPort != null)
                {
                    OracleEventNotificationPort.Close(__ctx1__, __seg__);
                    OracleEventNotificationPort = null;
                }
                Tracker.FireEvent(__eventLocations[47],__eventData[14],_stateMgrs[1].TrackDataStream );
                __ctx2__.Finally();
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 23;
            case 23:
                if ( !PreProgressInc( __seg__, __ctx__, 24 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[3],__eventData[15],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 24;
            case 24:
                if (!__ctx1__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 25 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 25;
            case 25:
                if ( !PreProgressInc( __seg__, __ctx__, 26 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx1__.OnCommit();
                goto case 26;
            case 26:
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
            __ProcessLogic_1 __ctx1__ = (__ProcessLogic_1)_stateMgrs[1];
            __ProcessLogic_root_0 __ctx0__ = (__ProcessLogic_root_0)_stateMgrs[0];

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
                __ctx1__.__ApplicationNumber = (System.String)Microsoft.XLANGs.Core.Part.XPathLoad(__ctx1__.__SingleNotificationEventMsg.MessagePart, "string(/*[local-name()='Notifications' and namespace-uri()='http://DLAPEventsSalesforceDefinition/SingleNotificationEvent']/*[local-name()='Notification' and namespace-uri()='http://soap.sforce.com/2005/09/outbound']/*[local-name()='sObject' and namespace-uri()='http://soap.sforce.com/2005/09/outbound']/*[local-name()='Application_Number__c' and namespace-uri()='urn:sobject.enterprise.soap.sforce.com'])", typeof(System.String));
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
                __ctx1__.__LogMessage = (System.String)Microsoft.XLANGs.Core.Part.XPathLoad(__ctx1__.__SingleNotificationEventMsg.MessagePart, "string(/*[local-name()='Notifications' and namespace-uri()='http://DLAPEventsSalesforceDefinition/SingleNotificationEvent']/*[local-name()='Notification' and namespace-uri()='http://soap.sforce.com/2005/09/outbound']/*[local-name()='sObject' and namespace-uri()='http://soap.sforce.com/2005/09/outbound']/*[local-name()='Log_Message__c' and namespace-uri()='urn:sobject.enterprise.soap.sforce.com'])", typeof(System.String));
                if ( !PostProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 5;
            case 5:
                __ctx1__.__SFObjectID = (System.String)Microsoft.XLANGs.Core.Part.XPathLoad(__ctx1__.__SingleNotificationEventMsg.MessagePart, "string(/*[local-name()='Notifications' and namespace-uri()='http://DLAPEventsSalesforceDefinition/SingleNotificationEvent']/*[local-name()='Notification' and namespace-uri()='http://soap.sforce.com/2005/09/outbound']/*[local-name()='sObject' and namespace-uri()='http://soap.sforce.com/2005/09/outbound']/*[local-name()='SObject_ID__c' and namespace-uri()='urn:sobject.enterprise.soap.sforce.com'])", typeof(System.String));
                if ( !PostProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 6;
            case 6:
                __ctx1__.__SFObjectName = (System.String)Microsoft.XLANGs.Core.Part.XPathLoad(__ctx1__.__SingleNotificationEventMsg.MessagePart, "string(/*[local-name()='Notifications' and namespace-uri()='http://DLAPEventsSalesforceDefinition/SingleNotificationEvent']/*[local-name()='Notification' and namespace-uri()='http://soap.sforce.com/2005/09/outbound']/*[local-name()='sObject' and namespace-uri()='http://soap.sforce.com/2005/09/outbound']/*[local-name()='SObject_Name__c' and namespace-uri()='urn:sobject.enterprise.soap.sforce.com'])", typeof(System.String));
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                __ctx1__.__EventRequestId = (System.String)Microsoft.XLANGs.Core.Part.XPathLoad(__ctx1__.__SingleNotificationEventMsg.MessagePart, "string(/*[local-name()='Notifications' and namespace-uri()='http://DLAPEventsSalesforceDefinition/SingleNotificationEvent']/*[local-name()='Notification' and namespace-uri()='http://soap.sforce.com/2005/09/outbound']/*[local-name()='sObject' and namespace-uri()='http://soap.sforce.com/2005/09/outbound']/*[local-name()='Id' and namespace-uri()='urn:sobject.enterprise.soap.sforce.com'])", typeof(System.String));
                if ( !PostProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 8;
            case 8:
                __ctx1__.__OrchestrationInstanceId = Microsoft.XLANGs.Core.Service.RootService.InstanceId;
                if ( !PostProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 9;
            case 9:
                if ( !PreProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[9],__eventData[5],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 10;
            case 10:
                __condition__ = ((!System.String.IsNullOrWhiteSpace(__ctx1__.__ApplicationNumber)) && (!System.String.IsNullOrWhiteSpace(__ctx1__.__LogMessage))) && (System.String.IsNullOrWhiteSpace(__ctx1__.__SFObjectID));
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 18 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 18;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 11;
            case 11:
                if ( !PreProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[10],__eventData[6],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 12;
            case 12:
                {
                    Microsoft.XLANGs.Core.Service svc = new DLAPEvents.StatusLogic(3, InstanceId, this);
                    _stateMgrs[3] = svc;
                    __ctx2__.StartCall(__seg__, svc, __eventLocations[10],new object[] {new Microsoft.XLANGs.Core.MessageTuple((Microsoft.XLANGs.Core.Context)_stateMgrs[1], null), __ctx1__.__SingleNotificationEventMsg});
                }
                if ( !PostProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 13:
                if ( !PreProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    object[] args = ((Microsoft.XLANGs.Core.Service)_stateMgrs[3]).Args;
                    __ctx1__.__StatusResponseMsg = (StatusResponseType)((Microsoft.XLANGs.Core.MessageTuple)(args[0])).message;
                    __ctx1__.__StatusResponseMsg.MessageName = "StatusResponseMsg";
                }
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Call);
                    __edata.Messages.Add(__ctx1__.__StatusResponseMsg);
                    __edata.Messages.Add(__ctx1__.__SingleNotificationEventMsg);
                    Tracker.FireEvent(__eventLocations[11],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 14;
            case 14:
                if ( !PreProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[12],__eventData[8],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 15;
            case 15:
                {
                    OracleEventNotificationRequestType __OracleEventNotificationRequestMsg = new OracleEventNotificationRequestType("OracleEventNotificationRequestMsg", __ctx1__);

                    ApplyTransform(typeof(DLAPEventsLogic.MakeOracleEventNotificationStatusRequest), new object[] {__OracleEventNotificationRequestMsg.MessagePart}, new object[] {__ctx1__.__SingleNotificationEventMsg.MessagePart});
                    __ctx1__.__TempStatusResponse.UnderlyingXmlDocument = __ctx1__.__StatusResponseMsg.MessagePart.TypedValue;
                    if (__ctx1__ != null && __ctx1__.__StatusResponseMsg != null)
                    {
                        __ctx1__.UnrefMessage(__ctx1__.__StatusResponseMsg);
                        __ctx1__.__StatusResponseMsg = null;
                    }
                    __OracleEventNotificationRequestMsg.MessagePart.XPathStore(__ctx1__.__TempStatusResponse.UnderlyingXmlDocument.OuterXml, "/*[local-name()='Insert' and namespace-uri()='http://Microsoft.LobServices.OracleDB/2007/03/DCMS_INT/View/EVENT_NOTIFICATION_DCMS']/*[local-name()='RECORDSET' and namespace-uri()='http://Microsoft.LobServices.OracleDB/2007/03/DCMS_INT/View/EVENT_NOTIFICATION_DCMS']/*[local-name()='EVENT_NOTIFICATION_DCMSRECORDINSERT' and namespace-uri()='http://Microsoft.LobServices.OracleDB/2007/03/DCMS_INT/View/EVENT_NOTIFICATION_DCMS']/*[local-name()='EVENT_DATA' and namespace-uri()='http://Microsoft.LobServices.OracleDB/2007/03/DCMS_INT/View/EVENT_NOTIFICATION_DCMS']");
                    __OracleEventNotificationRequestMsg.MessagePart.XPathStore("STATUS", "/*[local-name()='Insert' and namespace-uri()='http://Microsoft.LobServices.OracleDB/2007/03/DCMS_INT/View/EVENT_NOTIFICATION_DCMS']/*[local-name()='RECORDSET' and namespace-uri()='http://Microsoft.LobServices.OracleDB/2007/03/DCMS_INT/View/EVENT_NOTIFICATION_DCMS']/*[local-name()='EVENT_NOTIFICATION_DCMSRECORDINSERT' and namespace-uri()='http://Microsoft.LobServices.OracleDB/2007/03/DCMS_INT/View/EVENT_NOTIFICATION_DCMS']/*[local-name()='EVENT_TYPE' and namespace-uri()='http://Microsoft.LobServices.OracleDB/2007/03/DCMS_INT/View/EVENT_NOTIFICATION_DCMS']");

                    if (__ctx1__.__OracleEventNotificationRequestMsg != null)
                        __ctx1__.UnrefMessage(__ctx1__.__OracleEventNotificationRequestMsg);
                    __ctx1__.__OracleEventNotificationRequestMsg = __OracleEventNotificationRequestMsg;
                    __ctx1__.RefMessage(__ctx1__.__OracleEventNotificationRequestMsg);
                }
                __ctx1__.__OracleEventNotificationRequestMsg.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 16;
            case 16:
                if ( !PreProgressInc( __seg__, __ctx__, 17 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__OracleEventNotificationRequestMsg);
                    __edata.Messages.Add(__ctx1__.__SingleNotificationEventMsg);
                    Tracker.FireEvent(__eventLocations[13],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 17;
            case 17:
                if ( !PostProgressInc( __seg__, __ctx__, 39 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 39;
            case 18:
                if ( !PreProgressInc( __seg__, __ctx__, 19 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[5],__eventData[5],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 19;
            case 19:
                __condition__ = ((!System.String.IsNullOrWhiteSpace(__ctx1__.__ApplicationNumber)) && (!System.String.IsNullOrWhiteSpace(__ctx1__.__SFObjectID))) && (System.String.IsNullOrWhiteSpace(__ctx1__.__LogMessage));
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 27 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 27;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 20 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 20;
            case 20:
                if ( !PreProgressInc( __seg__, __ctx__, 21 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[14],__eventData[6],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 21;
            case 21:
                {
                    Microsoft.XLANGs.Core.Service svc = new DLAPEvents.DocumentLogic(4, InstanceId, this);
                    _stateMgrs[4] = svc;
                    __ctx2__.StartCall(__seg__, svc, __eventLocations[14],new object[] {__ctx1__.__SingleNotificationEventMsg, new Microsoft.XLANGs.Core.MessageTuple((Microsoft.XLANGs.Core.Context)_stateMgrs[1], null)});
                }
                if ( !PostProgressInc( __seg__, __ctx__, 22 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 22:
                if ( !PreProgressInc( __seg__, __ctx__, 23 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    object[] args = ((Microsoft.XLANGs.Core.Service)_stateMgrs[4]).Args;
                    __ctx1__.__DocumentResponseMsg = (DocumentResponseType)((Microsoft.XLANGs.Core.MessageTuple)(args[1])).message;
                    __ctx1__.__DocumentResponseMsg.MessageName = "DocumentResponseMsg";
                }
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Call);
                    __edata.Messages.Add(__ctx1__.__SingleNotificationEventMsg);
                    __edata.Messages.Add(__ctx1__.__DocumentResponseMsg);
                    Tracker.FireEvent(__eventLocations[15],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 23;
            case 23:
                if ( !PreProgressInc( __seg__, __ctx__, 24 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[16],__eventData[8],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 24;
            case 24:
                {
                    OracleEventNotificationRequestType __OracleEventNotificationRequestMsg = new OracleEventNotificationRequestType("OracleEventNotificationRequestMsg", __ctx1__);

                    ApplyTransform(typeof(DLAPEventsLogic.MakeOracleEventNotificationStatusRequest), new object[] {__OracleEventNotificationRequestMsg.MessagePart}, new object[] {__ctx1__.__SingleNotificationEventMsg.MessagePart});
                    __ctx1__.__TempDocumentResponse.UnderlyingXmlDocument = __ctx1__.__DocumentResponseMsg.MessagePart.TypedValue;
                    if (__ctx1__ != null && __ctx1__.__DocumentResponseMsg != null)
                    {
                        __ctx1__.UnrefMessage(__ctx1__.__DocumentResponseMsg);
                        __ctx1__.__DocumentResponseMsg = null;
                    }
                    __OracleEventNotificationRequestMsg.MessagePart.XPathStore(__ctx1__.__TempDocumentResponse.UnderlyingXmlDocument.OuterXml, "/*[local-name()='Insert' and namespace-uri()='http://Microsoft.LobServices.OracleDB/2007/03/DCMS_INT/View/EVENT_NOTIFICATION_DCMS']/*[local-name()='RECORDSET' and namespace-uri()='http://Microsoft.LobServices.OracleDB/2007/03/DCMS_INT/View/EVENT_NOTIFICATION_DCMS']/*[local-name()='EVENT_NOTIFICATION_DCMSRECORDINSERT' and namespace-uri()='http://Microsoft.LobServices.OracleDB/2007/03/DCMS_INT/View/EVENT_NOTIFICATION_DCMS']/*[local-name()='EVENT_DATA' and namespace-uri()='http://Microsoft.LobServices.OracleDB/2007/03/DCMS_INT/View/EVENT_NOTIFICATION_DCMS']");
                    __OracleEventNotificationRequestMsg.MessagePart.XPathStore("DOCUMENT", "/*[local-name()='Insert' and namespace-uri()='http://Microsoft.LobServices.OracleDB/2007/03/DCMS_INT/View/EVENT_NOTIFICATION_DCMS']/*[local-name()='RECORDSET' and namespace-uri()='http://Microsoft.LobServices.OracleDB/2007/03/DCMS_INT/View/EVENT_NOTIFICATION_DCMS']/*[local-name()='EVENT_NOTIFICATION_DCMSRECORDINSERT' and namespace-uri()='http://Microsoft.LobServices.OracleDB/2007/03/DCMS_INT/View/EVENT_NOTIFICATION_DCMS']/*[local-name()='EVENT_TYPE' and namespace-uri()='http://Microsoft.LobServices.OracleDB/2007/03/DCMS_INT/View/EVENT_NOTIFICATION_DCMS']");

                    if (__ctx1__.__OracleEventNotificationRequestMsg != null)
                        __ctx1__.UnrefMessage(__ctx1__.__OracleEventNotificationRequestMsg);
                    __ctx1__.__OracleEventNotificationRequestMsg = __OracleEventNotificationRequestMsg;
                    __ctx1__.RefMessage(__ctx1__.__OracleEventNotificationRequestMsg);
                }
                __ctx1__.__OracleEventNotificationRequestMsg.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 25 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 25;
            case 25:
                if ( !PreProgressInc( __seg__, __ctx__, 26 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__OracleEventNotificationRequestMsg);
                    __edata.Messages.Add(__ctx1__.__SingleNotificationEventMsg);
                    Tracker.FireEvent(__eventLocations[17],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 26;
            case 26:
                if ( !PostProgressInc( __seg__, __ctx__, 38 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 38;
            case 27:
                if ( !PreProgressInc( __seg__, __ctx__, 28 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[18],__eventData[3],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 28;
            case 28:
                __ctx1__.__Message = "DLAP Events SF Notification Request Validation Failed for STATUS/DOCUMENT";
                if ( !PostProgressInc( __seg__, __ctx__, 29 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 29;
            case 29:
                if ( !PreProgressInc( __seg__, __ctx__, 30 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[19],__eventData[4],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 30;
            case 30:
                __ctx1__.__Stage = "Notification Sent to DLAP";
                if ( !PostProgressInc( __seg__, __ctx__, 31 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 31;
            case 31:
                __ctx1__.__Status = "Error";
                if ( !PostProgressInc( __seg__, __ctx__, 32 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 32;
            case 32:
                __ctx1__.__OrchestrationInstanceId = Microsoft.XLANGs.Core.Service.RootService.InstanceId;
                if ( !PostProgressInc( __seg__, __ctx__, 33 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 33;
            case 33:
                if ( !PreProgressInc( __seg__, __ctx__, 34 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[20],__eventData[6],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 34;
            case 34:
                {
                    Microsoft.XLANGs.Core.Service svc = new DLAPEvents.EventRequest(5, InstanceId, this);
                    _stateMgrs[5] = svc;
                    __ctx2__.StartCall(__seg__, svc, __eventLocations[20],new object[] {__ctx1__.__ApplicationNumber, __ctx1__.__SFObjectID, __ctx1__.__Message, __ctx1__.__SFObjectName, __ctx1__.__Stage, __ctx1__.__Status, __ctx1__.__Empty, __ctx1__.__OrchestrationInstanceId, __ctx1__.__EventRequestId});
                }
                if ( !PostProgressInc( __seg__, __ctx__, 35 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 35:
                if ( !PreProgressInc( __seg__, __ctx__, 36 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    object[] args = ((Microsoft.XLANGs.Core.Service)_stateMgrs[5]).Args;
                }
                Tracker.FireEvent(__eventLocations[21],__eventData[7],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 36;
            case 36:
                if ( !PreProgressInc( __seg__, __ctx__, 37 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[22],__eventData[9],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 37;
            case 37:
                RequestTerminate(__ctx2__,"DLAP Events SF Notification Request Validation Failed");
                __seg__.SegmentDone();
                break;
            case 38:
                if ( !PreProgressInc( __seg__, __ctx__, 39 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[8],__eventData[10],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 39;
            case 39:
                if ( !PreProgressInc( __seg__, __ctx__, 40 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[23],__eventData[10],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 40;
            case 40:
                if ( !PreProgressInc( __seg__, __ctx__, 41 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[24],__eventData[11],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 41;
            case 41:
                if (!__ctx2__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 42 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 42;
            case 42:
                if ( !PreProgressInc( __seg__, __ctx__, 43 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                OracleEventNotificationPort.SendMessage(0, __ctx1__.__OracleEventNotificationRequestMsg, null, null, out __ctx0__.__subWrapper1, __ctx2__, __seg__ );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 43;
            case 43:
                if ( !PreProgressInc( __seg__, __ctx__, 44 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__OracleEventNotificationRequestMsg);
                    __edata.PortName = @"OracleEventNotificationPort";
                    Tracker.FireEvent(__eventLocations[25],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__OracleEventNotificationRequestMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__OracleEventNotificationRequestMsg);
                    __ctx1__.__OracleEventNotificationRequestMsg = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 44;
            case 44:
                if ( !PreProgressInc( __seg__, __ctx__, 45 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[26],__eventData[1],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 45;
            case 45:
                if (!OracleEventNotificationPort.GetMessageId(__ctx0__.__subWrapper1.getSubscription(this), __seg__, __ctx1__, out __msgEnv__, _locations[0]))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx0__ != null && __ctx0__.__subWrapper1 != null)
                {
                    __ctx0__.__subWrapper1.Destroy(this, __ctx0__);
                    __ctx0__.__subWrapper1 = null;
                }
                if (__ctx1__.__OracleEventNotificationResponseMsg != null)
                    __ctx1__.UnrefMessage(__ctx1__.__OracleEventNotificationResponseMsg);
                __ctx1__.__OracleEventNotificationResponseMsg = new OracleEventNotificationResponseType("OracleEventNotificationResponseMsg", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__OracleEventNotificationResponseMsg);
                OracleEventNotificationPort.ReceiveMessage(0, __msgEnv__, __ctx1__.__OracleEventNotificationResponseMsg, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[2], __seg__);
                if ( !PostProgressInc( __seg__, __ctx__, 46 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 46;
            case 46:
                if ( !PreProgressInc( __seg__, __ctx__, 47 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__OracleEventNotificationResponseMsg);
                    __edata.PortName = @"OracleEventNotificationPort";
                    Tracker.FireEvent(__eventLocations[27],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 47;
            case 47:
                if ( !PreProgressInc( __seg__, __ctx__, 48 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[28],__eventData[3],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 48;
            case 48:
                __ctx1__.__OracleInsertStatus = (System.String)Microsoft.XLANGs.Core.Part.XPathLoad(__ctx1__.__OracleEventNotificationResponseMsg.MessagePart, "string(/*[local-name()='Root' and namespace-uri()='http://schemas.microsoft.com/BizTalk/2003/aggschema']/*[local-name()='InputMessagePart_1' and namespace-uri()='']/*[local-name()='InsertResponse' and namespace-uri()='http://Microsoft.LobServices.OracleDB/2007/03/DCMS_INT/View/EVENT_NOTIFICATION_DCMS']/*[local-name()='InsertResult' and namespace-uri()='http://Microsoft.LobServices.OracleDB/2007/03/DCMS_INT/View/EVENT_NOTIFICATION_DCMS'])", typeof(System.String));
                if (__ctx1__ != null && __ctx1__.__OracleEventNotificationResponseMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__OracleEventNotificationResponseMsg);
                    __ctx1__.__OracleEventNotificationResponseMsg = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 49 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 49;
            case 49:
                if ( !PreProgressInc( __seg__, __ctx__, 50 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[29],__eventData[4],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 50;
            case 50:
                if ( !PreProgressInc( __seg__, __ctx__, 51 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[30],__eventData[5],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 51;
            case 51:
                __condition__ = __ctx1__.__OracleInsertStatus != "0";
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 58 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 58;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 52 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 52;
            case 52:
                if ( !PreProgressInc( __seg__, __ctx__, 53 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[31],__eventData[3],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 53;
            case 53:
                __ctx1__.__Stage = "Notification Sent to DLAP";
                if ( !PostProgressInc( __seg__, __ctx__, 54 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 54;
            case 54:
                if ( !PreProgressInc( __seg__, __ctx__, 55 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[32],__eventData[4],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 55;
            case 55:
                __ctx1__.__Status = "Success";
                if ( !PostProgressInc( __seg__, __ctx__, 56 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 56;
            case 56:
                __ctx1__.__Message = "Successfully Sent Notification to DLAP";
                if ( !PostProgressInc( __seg__, __ctx__, 57 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 57;
            case 57:
                if ( !PostProgressInc( __seg__, __ctx__, 63 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 63;
            case 58:
                if ( !PreProgressInc( __seg__, __ctx__, 59 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[33],__eventData[3],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 59;
            case 59:
                __ctx1__.__Message = "DLAP Notification Oracle Insertion Failed";
                if ( !PostProgressInc( __seg__, __ctx__, 60 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 60;
            case 60:
                if ( !PreProgressInc( __seg__, __ctx__, 61 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[34],__eventData[4],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 61;
            case 61:
                __ctx1__.__Stage = "Notification Sent to DLAP";
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
                Tracker.FireEvent(__eventLocations[35],__eventData[10],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 64;
            case 64:
                if ( !PreProgressInc( __seg__, __ctx__, 65 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[36],__eventData[6],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 65;
            case 65:
                {
                    Microsoft.XLANGs.Core.Service svc = new DLAPEvents.EventRequest(6, InstanceId, this);
                    _stateMgrs[6] = svc;
                    __ctx2__.StartCall(__seg__, svc, __eventLocations[36],new object[] {__ctx1__.__ApplicationNumber, __ctx1__.__SFObjectID, __ctx1__.__Message, __ctx1__.__SFObjectName, __ctx1__.__Stage, __ctx1__.__Status, __ctx1__.__Empty, __ctx1__.__OrchestrationInstanceId, __ctx1__.__EventRequestId});
                }
                if ( !PostProgressInc( __seg__, __ctx__, 66 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 66:
                if ( !PreProgressInc( __seg__, __ctx__, 67 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    object[] args = ((Microsoft.XLANGs.Core.Service)_stateMgrs[6]).Args;
                }
                Tracker.FireEvent(__eventLocations[37],__eventData[7],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 67;
            case 67:
                if (!__ctx2__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 68 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 68;
            case 68:
                if ( !PreProgressInc( __seg__, __ctx__, 69 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx2__.OnCommit();
                goto case 69;
            case 69:
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
            ____scope35_2 __ctx2__ = (____scope35_2)_stateMgrs[2];
            __ProcessLogic_1 __ctx1__ = (__ProcessLogic_1)_stateMgrs[1];

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
                Tracker.FireEvent(__eventLocations[38],__eventData[12],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[39],__eventData[5],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 3;
            case 3:
                __condition__ = __ctx2__.__EEx_0.InnerException != null;
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
                __ctx1__.__MessageTemp = __ctx2__.__EEx_0.InnerException.ToString();
                if ( !PostProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 5;
            case 5:
                __ctx1__.__ErrorMessage = __ctx1__.__MessageTemp.Substring(0, System.Convert.ToInt32(System.Math.Min(900U, __ctx1__.__MessageTemp.Length))) + "Total String Length:" + __ctx1__.__MessageTemp.Length.ToString();
                if ( !PostProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 6;
            case 6:
                System.Diagnostics.EventLog.WriteEntry("DLAP Events Exception", __ctx1__.__ErrorMessage, System.Diagnostics.EventLogEntryType.Error);
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                if ( !PostProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 11;
            case 8:
                __ctx1__.__MessageTemp = __ctx2__.__EEx_0.Message.ToString();
                if ( !PostProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 9;
            case 9:
                __ctx1__.__ErrorMessage = __ctx1__.__MessageTemp.Substring(0, System.Convert.ToInt32(System.Math.Min(900U, __ctx1__.__MessageTemp.Length))) + "Total String Length:" + __ctx1__.__MessageTemp.Length.ToString();
                if ( !PostProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 10;
            case 10:
                System.Diagnostics.EventLog.WriteEntry("DLAP Events Exception", __ctx1__.__ErrorMessage, System.Diagnostics.EventLogEntryType.Error);
                if ( !PostProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 11;
            case 11:
                if ( !PreProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if (__ctx2__ != null)
                    __ctx2__.__EEx_0 = null;
                Tracker.FireEvent(__eventLocations[42],__eventData[10],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 12;
            case 12:
                __ctx1__.__OrchestrationInstanceId = Microsoft.XLANGs.Core.Service.RootService.InstanceId;
                if ( !PostProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 13;
            case 13:
                __ctx1__.__Stage = "Notification Sent to DLAP";
                if ( !PostProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 14;
            case 14:
                __ctx1__.__Status = "Error";
                if ( !PostProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 15;
            case 15:
                if ( !PreProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[43],__eventData[6],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 16;
            case 16:
                {
                    Microsoft.XLANGs.Core.Service svc = new DLAPEvents.EventRequest(7, InstanceId, this);
                    _stateMgrs[7] = svc;
                    __ctx2__.StartCall(__seg__, svc, __eventLocations[43],new object[] {__ctx1__.__ApplicationNumber, __ctx1__.__SFObjectID, __ctx1__.__ErrorMessage, __ctx1__.__SFObjectName, __ctx1__.__Stage, __ctx1__.__Status, __ctx1__.__Empty, __ctx1__.__OrchestrationInstanceId, __ctx1__.__EventRequestId});
                }
                if ( !PostProgressInc( __seg__, __ctx__, 17 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 17:
                if ( !PreProgressInc( __seg__, __ctx__, 18 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    object[] args = ((Microsoft.XLANGs.Core.Service)_stateMgrs[7]).Args;
                }
                Tracker.FireEvent(__eventLocations[44],__eventData[7],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 18;
            case 18:
                if ( !PreProgressInc( __seg__, __ctx__, 19 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[45],__eventData[9],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 19;
            case 19:
                RequestTerminate(__ctx2__,"An error occurred while processing the DLAP Events");
                __seg__.SegmentDone();
                break;
            case 20:
                if ( !PreProgressInc( __seg__, __ctx__, 21 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[46],__eventData[13],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 21;
            case 21:
                __ctx2__.__exv__ = null;
                OnEndCatchHandler(2, __seg__);
                __seg__.SegmentDone();
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }
        private static Microsoft.XLANGs.Core.CachedObject[] _locations = new Microsoft.XLANGs.Core.CachedObject[] {
            new Microsoft.XLANGs.Core.CachedObject(new System.Guid("{F45566EF-D3E4-41FB-B809-B06F8920E182}"))
        };

    }
    //#line 458 "C:\Users\skyeniga\Source\Repos\Biztalk\DLAP Events\DLAP Events Logic\DLAPEventStatusLogic.odx"
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        },
        new System.Type[] {
            typeof(DLAPEvents.RestQueryStatusApplicationInfoPortType)
        },
        new System.String[] {
            "RestQueryStatusApplicationInfoPort"
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
        Microsoft.XLANGs.BaseTypes.EXLangSServiceInfo.eCallable
    )]
    [System.SerializableAttribute]
    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed internal class StatusLogic : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
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
        public static void __bodyProxy(
            [ Microsoft.XLANGs.BaseTypes.ServiceParameterAttribute(Microsoft.XLANGs.BaseTypes.EXLangSParameter.eMessage, "") ] out DLAPEvents.StatusResponseType StatusResponse,
            [ Microsoft.XLANGs.BaseTypes.ServiceParameterAttribute(Microsoft.XLANGs.BaseTypes.EXLangSParameter.eMessage, "") ] DLAPEvents.SingleNotificationEventType SalesforceEventRequest)
        {
            StatusResponse = default(DLAPEvents.StatusResponseType);
        }
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(StatusLogic));
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

        static StatusLogic()
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
            _rootContext = new __StatusLogic_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[2];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public StatusLogic(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "StatusLogic", tracker)
        {
            ConstructorHelper();
        }

        public StatusLogic(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "StatusLogic")
        {
            ConstructorHelper();
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>82aaa170-1eb6-468a-85a3-f241450681cf</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>MessageDeclarationShape</shapeType>      <ShapeID>801fb5e7-ad1d-47b3-8d8c-a06e9b1dbfaf</ShapeID>      <ParentLink>ServiceBody_Declaration</ParentLink>                <shapeText>StatusResponse</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageDeclarationShape</shapeType>      <ShapeID>9fd9b467-9e25-463a-9c38-cad1352265e4</ShapeID>      <ParentLink>ServiceBody_Declaration</ParentLink>                <shapeText>SalesforceEventRequest</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>TaskShape</shapeType>      <ShapeID>49d5206a-d3f0-4105-99a5-8525b0999c98</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>DLAP Check Status</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>TaskShape</shapeType>      <ShapeID>da521731-6f94-4e37-a621-4f57dcfb6903</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>DLAP Events Status Notification</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>412389c3-118f-4079-be64-e957e5ce7813</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Extract Application Number</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>cb8d1e10-c867-4760-ab93-2085c6090d02</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Construct Rest Status Application Info Request Msg</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>6afdc18a-6b34-49dc-84bf-e93cee429368</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Make Rest Query Application Info Request </shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>ea92e57a-8437-4480-afb2-a6988b559842</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_3</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>2959a187-52db-480b-b548-21910b2b7a5d</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_4</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>2507d8da-05e8-4b1d-ae7b-7abd6c95b140</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Injecting Application SOQL Query</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>edbdffdc-7e70-4bf6-9fd6-cce34c1716ff</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>4b1a1346-b279-4475-ae5e-4732501d82b3</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Send Rest Application Request Msg</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>97fa94a4-a0c0-4548-9af3-476415580155</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Receive Application Info Response</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>04cea421-26f7-441e-b48e-7c3576334ef1</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Application Value Extract</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionShape</shapeType>      <ShapeID>8d3451b7-30c7-49e5-ae92-b6c35b9031b4</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Application Exists?</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>c9704286-69fe-4cf5-a5ff-b2f42053ae97</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>Valid Application Number</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>00a2f099-886a-4d2a-bcf2-a9484c2450cc</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Construct Event Status Response Msg</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>2f5bf8bd-7eda-4cb0-8b86-8be75b225863</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Make  Check Status Response Msg</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>7d212324-0f10-4683-8a34-16121bf6bf6e</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>3ae28b90-8160-4ce9-a953-45ae1f580857</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>25155801-5be6-47ee-9022-5ceb77d8a7e6</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>2704740a-bf9b-47ad-b671-3c7a420cc7c8</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>Else</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>cc4df9c1-f24c-402a-b2a7-8076922456c8</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Rest Exception</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ThrowShape</shapeType>      <ShapeID>d20063c4-edd4-4a99-a0d7-9215b4ee8bca</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Rest Error </shapeText>                  
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
                  </children>
  </ProcessFlow><Metadata>

<TrkMetadata>
<ActionName>'StatusLogic'</ActionName><IsAtomic>0</IsAtomic><Line>458</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
<Messages>
	<MsgInfo><name>StatusResponse</name><part>MessagePart</part><schema>DLAPEventsDefinition.EventStatusResponse</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>SalesforceEventRequest</name><part>MessagePart</part><schema>DLAPEventsSalesforceDefinition.SingleNotificationEvent</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>483</Line><Position>31</Position><ShapeID>'412389c3-118f-4079-be64-e957e5ce7813'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>487</Line><Position>13</Position><ShapeID>'cb8d1e10-c867-4760-ab93-2085c6090d02'</ShapeID>
<Messages>
	<MsgInfo><name>RestQueryApplicationInfoRequestMsg</name><part>MessagePart</part><schema>DLAPEventsSalesforceDefinition.RestCheckStatus.RestCheckStatusSalesforceRequest</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>SalesforceEventRequest</name><part>MessagePart</part><schema>DLAPEventsSalesforceDefinition.SingleNotificationEvent</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>503</Line><Position>13</Position><ShapeID>'4b1a1346-b279-4475-ae5e-4732501d82b3'</ShapeID>
<Messages>
	<MsgInfo><name>RestQueryApplicationInfoRequestMsg</name><part>MessagePart</part><schema>DLAPEventsSalesforceDefinition.RestCheckStatus.RestCheckStatusSalesforceRequest</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>505</Line><Position>13</Position><ShapeID>'97fa94a4-a0c0-4548-9af3-476415580155'</ShapeID>
<Messages>
	<MsgInfo><name>RestQueryApplicationInfoResponseMsg</name><part>MessagePart</part><schema>DLAPEventsSalesforceDefinition.RestCheckStatus.RestCheckStatusSalesforceResponse</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>507</Line><Position>29</Position><ShapeID>'04cea421-26f7-441e-b48e-7c3576334ef1'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>509</Line><Position>13</Position><ShapeID>'8d3451b7-30c7-49e5-ae92-b6c35b9031b4'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>512</Line><Position>17</Position><ShapeID>'00a2f099-886a-4d2a-bcf2-a9484c2450cc'</ShapeID>
<Messages>
	<MsgInfo><name>StatusResponse</name><part>MessagePart</part><schema>DLAPEventsDefinition.EventStatusResponse</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>RestQueryApplicationInfoResponseMsg</name><part>MessagePart</part><schema>DLAPEventsSalesforceDefinition.RestCheckStatus.RestCheckStatusSalesforceResponse</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>521</Line><Position>36</Position><ShapeID>'cc4df9c1-f24c-402a-b2a7-8076922456c8'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>523</Line><Position>17</Position><ShapeID>'d20063c4-edd4-4a99-a0d7-9215b4ee8bca'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='e715f91c-70b5-4351-b3dd-e9b5472057e2' LowerBound='1.1' HigherBound='114.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='DLAPEvents' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='MultipartMessageType' OID='c9b99409-d755-40ef-9998-5f0ecb2f57b3' ParentLink='Module_MessageType' LowerBound='4.1' HigherBound='8.1'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='SalesforceQueryStatusApplicationInfoRequestType' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='PartDeclaration' OID='3b6c1bea-e5d4-412f-b1e4-c92a9928b5fa' ParentLink='MultipartMessageType_PartDeclaration' LowerBound='6.1' HigherBound='7.1'>
                <om:Property Name='ClassName' Value='DLAPEventsSalesforceDefinition.SalesforceQuery__Application_Info__c.Request' />
                <om:Property Name='IsBodyPart' Value='True' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='MessagePart' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
        </om:Element>
        <om:Element Type='MultipartMessageType' OID='a5318ef5-41a4-407a-813a-bd31e087b75b' ParentLink='Module_MessageType' LowerBound='8.1' HigherBound='12.1'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='SalesforceQueryStatusApplicationInfoResponseType' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='PartDeclaration' OID='b244f2e3-125e-45fa-8d46-6142ff14570f' ParentLink='MultipartMessageType_PartDeclaration' LowerBound='10.1' HigherBound='11.1'>
                <om:Property Name='ClassName' Value='DLAPEventsSalesforceDefinition.SalesforceQuery__Application_Info__c.Response' />
                <om:Property Name='IsBodyPart' Value='True' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='MessagePart' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
        </om:Element>
        <om:Element Type='MultipartMessageType' OID='8470c7f2-84fc-47e7-8977-3e6ada0379ed' ParentLink='Module_MessageType' LowerBound='12.1' HigherBound='16.1'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='SalesforceQueryStatusChecklistItemRequestType' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='PartDeclaration' OID='0e8323d9-c702-4674-8889-a2f52011e34f' ParentLink='MultipartMessageType_PartDeclaration' LowerBound='14.1' HigherBound='15.1'>
                <om:Property Name='ClassName' Value='DLAPEventsSalesforceDefinition.SalesforceQuery__Checklist_Item__c.Request' />
                <om:Property Name='IsBodyPart' Value='True' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='MessagePart' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
        </om:Element>
        <om:Element Type='MultipartMessageType' OID='99597d95-6044-487d-bb05-6807467d8b39' ParentLink='Module_MessageType' LowerBound='16.1' HigherBound='20.1'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='SalesforceQueryStatusChecklistItemResponseType' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='PartDeclaration' OID='7a26f8b7-524d-4f86-af04-f98f9036033b' ParentLink='MultipartMessageType_PartDeclaration' LowerBound='18.1' HigherBound='19.1'>
                <om:Property Name='ClassName' Value='DLAPEventsSalesforceDefinition.SalesforceQuery__Checklist_Item__c.Response' />
                <om:Property Name='IsBodyPart' Value='True' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='MessagePart' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
        </om:Element>
        <om:Element Type='MultipartMessageType' OID='4723e1dc-2b61-409a-b693-a1683029462c' ParentLink='Module_MessageType' LowerBound='20.1' HigherBound='24.1'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='SalesforceQueryStatusLoanRequestType' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='PartDeclaration' OID='37a62f97-ca7d-44a0-a00d-c8f7e87daca1' ParentLink='MultipartMessageType_PartDeclaration' LowerBound='22.1' HigherBound='23.1'>
                <om:Property Name='ClassName' Value='DLAPEventsSalesforceDefinition.SalesforceQuery_Loan_c.Request' />
                <om:Property Name='IsBodyPart' Value='True' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='MessagePart' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
        </om:Element>
        <om:Element Type='MultipartMessageType' OID='7c25ca94-300a-4a1e-9e42-54fcb5dd2dce' ParentLink='Module_MessageType' LowerBound='24.1' HigherBound='28.1'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='SalesforceQueryStatusLoanResponseType' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='PartDeclaration' OID='6b5c9b7c-72aa-404a-9439-627b9da462ed' ParentLink='MultipartMessageType_PartDeclaration' LowerBound='26.1' HigherBound='27.1'>
                <om:Property Name='ClassName' Value='DLAPEventsSalesforceDefinition.SalesforceQuery_Loan_c.Response' />
                <om:Property Name='IsBodyPart' Value='True' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='MessagePart' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
        </om:Element>
        <om:Element Type='MultipartMessageType' OID='bc9a9243-0320-44da-accc-f3bf36a4180d' ParentLink='Module_MessageType' LowerBound='28.1' HigherBound='32.1'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='RestQueryApplicationInfoRequestType' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='PartDeclaration' OID='ef702adb-2e64-4111-9d51-61cfab100682' ParentLink='MultipartMessageType_PartDeclaration' LowerBound='30.1' HigherBound='31.1'>
                <om:Property Name='ClassName' Value='DLAPEventsSalesforceDefinition.RestCheckStatus.RestCheckStatusSalesforceRequest' />
                <om:Property Name='IsBodyPart' Value='True' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='MessagePart' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
        </om:Element>
        <om:Element Type='MultipartMessageType' OID='d713a5b3-759a-4242-ab53-860c45e521eb' ParentLink='Module_MessageType' LowerBound='32.1' HigherBound='36.1'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='RestQueryApplicationInfoResponseType' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='PartDeclaration' OID='acbc14bf-363b-4297-a8dd-7bc98ed127df' ParentLink='MultipartMessageType_PartDeclaration' LowerBound='34.1' HigherBound='35.1'>
                <om:Property Name='ClassName' Value='DLAPEventsSalesforceDefinition.RestCheckStatus.RestCheckStatusSalesforceResponse' />
                <om:Property Name='IsBodyPart' Value='True' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='MessagePart' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
        </om:Element>
        <om:Element Type='ServiceDeclaration' OID='90c8f530-2dd2-4da9-aa28-25ee32e67904' ParentLink='Module_ServiceDeclaration' LowerBound='43.1' HigherBound='113.1'>
            <om:Property Name='InitializedTransactionType' Value='False' />
            <om:Property Name='IsInvokable' Value='True' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='StatusLogic' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='VariableDeclaration' OID='10b70487-998f-43d1-afc5-53972fdabd7d' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='56.1' HigherBound='57.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ApplicationNumber' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='e6a65495-8a16-4f83-b245-2af0ad066229' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='57.1' HigherBound='58.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ApplicationNumberList' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='eb1187c0-6b1e-483e-b9b3-c02dc7a52dae' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='58.1' HigherBound='59.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='APPLICATION_INFO_SOQL_QUERY' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='c56a87cb-406b-4149-8b68-82200400b604' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='59.1' HigherBound='60.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ApplicationSFID' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='ccd0356d-5855-4988-a48e-0d83838c2929' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='60.1' HigherBound='61.1'>
                <om:Property Name='UseDefaultConstructor' Value='True' />
                <om:Property Name='Type' Value='System.Exception' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='RestQueryException' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='271bc206-6cc1-443e-aefd-3a8311bf2c97' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='48.1' HigherBound='49.1'>
                <om:Property Name='Type' Value='DLAPEvents.SalesforceQueryStatusLoanResponseType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SalesforceQueryStatusLoanResponseMsg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='0187e14a-00f4-429a-8560-164750de9fcc' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='49.1' HigherBound='50.1'>
                <om:Property Name='Type' Value='DLAPEvents.SalesforceQueryStatusLoanRequestType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SalesforceQueryStatusLoanRequestMsg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='89d1e7c6-b067-482f-bcc3-19322eea162c' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='50.1' HigherBound='51.1'>
                <om:Property Name='Type' Value='DLAPEvents.SalesforceQueryStatusChecklistItemResponseType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SalesforceQueryStatusChecklistItemResponseMsg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='50cd6927-ef29-4020-842c-145d665ad25b' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='51.1' HigherBound='52.1'>
                <om:Property Name='Type' Value='DLAPEvents.SalesforceQueryStatusChecklistItemRequestType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SalesforceQueryStatusChecklistItemRequestMsg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='886ac54a-f2e7-4d14-a475-1d2bb21cc6c7' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='52.1' HigherBound='53.1'>
                <om:Property Name='Type' Value='DLAPEvents.SalesforceQueryStatusApplicationInfoResponseType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SalesforceQueryStatusApplicationInfoResponseMsg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='d956406b-568f-44cf-9b95-12fcd9623260' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='53.1' HigherBound='54.1'>
                <om:Property Name='Type' Value='DLAPEvents.SalesforceQueryStatusApplicationInfoRequestType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SalesforceQueryStatusApplicationInfoRequestMsg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='c1704585-1c4e-4767-b0e1-a060aa9ca0ef' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='54.1' HigherBound='55.1'>
                <om:Property Name='Type' Value='DLAPEvents.RestQueryApplicationInfoRequestType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='RestQueryApplicationInfoRequestMsg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='06dfb4d3-ee45-4800-a1fe-ab25f1845e18' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='55.1' HigherBound='56.1'>
                <om:Property Name='Type' Value='DLAPEvents.RestQueryApplicationInfoResponseType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='RestQueryApplicationInfoResponseMsg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='ServiceBody' OID='82aaa170-1eb6-468a-85a3-f241450681cf' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageDeclaration' OID='801fb5e7-ad1d-47b3-8d8c-a06e9b1dbfaf' ParentLink='ServiceBody_Declaration' LowerBound='61.15' HigherBound='61.60'>
                    <om:Property Name='Type' Value='DLAPEvents.StatusResponseType' />
                    <om:Property Name='ParamDirection' Value='Out' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='StatusResponse' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='MessageDeclaration' OID='9fd9b467-9e25-463a-9c38-cad1352265e4' ParentLink='ServiceBody_Declaration' LowerBound='61.62' HigherBound='61.120'>
                    <om:Property Name='Type' Value='DLAPEvents.SingleNotificationEventType' />
                    <om:Property Name='ParamDirection' Value='In' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='SalesforceEventRequest' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Task' OID='49d5206a-d3f0-4105-99a5-8525b0999c98' ParentLink='ServiceBody_Statement' LowerBound='68.1' HigherBound='111.1'>
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='DLAP Check Status' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='Task' OID='da521731-6f94-4e37-a621-4f57dcfb6903' ParentLink='ComplexStatement_Statement' LowerBound='68.1' HigherBound='111.1'>
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='DLAP Events Status Notification' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='VariableAssignment' OID='412389c3-118f-4079-be64-e957e5ce7813' ParentLink='ComplexStatement_Statement' LowerBound='68.1' HigherBound='72.1'>
                            <om:Property Name='Expression' Value='ApplicationNumber = xpath(SalesforceEventRequest.MessagePart, &quot;string(/*[local-name()=&apos;Notifications&apos; and namespace-uri()=&apos;http://DLAPEventsSalesforceDefinition/SingleNotificationEvent&apos;]/*[local-name()=&apos;Notification&apos; and namespace-uri()=&apos;http://soap.sforce.com/2005/09/outbound&apos;]/*[local-name()=&apos;sObject&apos; and namespace-uri()=&apos;http://soap.sforce.com/2005/09/outbound&apos;]/*[local-name()=&apos;Application_Number__c&apos; and namespace-uri()=&apos;urn:sobject.enterprise.soap.sforce.com&apos;])&quot;);&#xD;&#xA;&#xD;&#xA;ApplicationNumberList = &quot;&apos;&quot;+ApplicationNumber+&quot;&apos;&quot;;' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Extract Application Number' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                        <om:Element Type='Construct' OID='cb8d1e10-c867-4760-ab93-2085c6090d02' ParentLink='ComplexStatement_Statement' LowerBound='72.1' HigherBound='88.1'>
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Construct Rest Status Application Info Request Msg' />
                            <om:Property Name='Signal' Value='True' />
                            <om:Element Type='Transform' OID='6afdc18a-6b34-49dc-84bf-e93cee429368' ParentLink='ComplexStatement_Statement' LowerBound='75.1' HigherBound='77.1'>
                                <om:Property Name='ClassName' Value='DLAPEventsLogic.MakeRestQueryApplicationInfoRequest' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Make Rest Query Application Info Request ' />
                                <om:Property Name='Signal' Value='True' />
                                <om:Element Type='MessagePartRef' OID='ea92e57a-8437-4480-afb2-a6988b559842' ParentLink='Transform_InputMessagePartRef' LowerBound='76.131' HigherBound='76.165'>
                                    <om:Property Name='MessageRef' Value='SalesforceEventRequest' />
                                    <om:Property Name='PartRef' Value='MessagePart' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='MessagePartReference_3' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                                <om:Element Type='MessagePartRef' OID='2959a187-52db-480b-b548-21910b2b7a5d' ParentLink='Transform_OutputMessagePartRef' LowerBound='76.28' HigherBound='76.74'>
                                    <om:Property Name='MessageRef' Value='RestQueryApplicationInfoRequestMsg' />
                                    <om:Property Name='PartRef' Value='MessagePart' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='MessagePartReference_4' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                            </om:Element>
                            <om:Element Type='MessageAssignment' OID='2507d8da-05e8-4b1d-ae7b-7abd6c95b140' ParentLink='ComplexStatement_Statement' LowerBound='77.1' HigherBound='87.1'>
                                <om:Property Name='Expression' Value='//SOQL Query For Rest&#xD;&#xA;&#xD;&#xA;APPLICATION_INFO_SOQL_QUERY = @&quot;Select Id, Name, Loan_Type__c, DLAP_Status_Description__c, DLAP_Status__c, Disaster_Declaration__r.Name,Disaster_Declaration__r.Disaster_Description__c, Disaster_Declaration__r.Disaster_Deadline_Date__c, (Select Id,Checklist_Item_Status__c FROM Checklist_Items__r WHERE ((Type__c != &apos;Interface&apos; AND Checklist_Item_Status__c = &apos;Requested&apos;) OR (((Type__c = &apos;Closing Documents&apos;) AND (Checklist_Item_Status__c = &apos;Pending Borrower\&apos;s Verification&apos;))))),(Select Id,Name from Loans__r) FROM Application__c WHERE Name IN &quot;+&quot;(&quot;+ApplicationNumberList+&quot;)&quot;;&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;RestQueryApplicationInfoRequestMsg(DLAPEventsSalesforceDefinition.RestCheckStatus.SF_APPLICATION_QUERY) = APPLICATION_INFO_SOQL_QUERY; &#xD;&#xA;&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;' />
                                <om:Property Name='ReportToAnalyst' Value='False' />
                                <om:Property Name='Name' Value='Injecting Application SOQL Query' />
                                <om:Property Name='Signal' Value='True' />
                            </om:Element>
                            <om:Element Type='MessageRef' OID='edbdffdc-7e70-4bf6-9fd6-cce34c1716ff' ParentLink='Construct_MessageRef' LowerBound='73.23' HigherBound='73.57'>
                                <om:Property Name='Ref' Value='RestQueryApplicationInfoRequestMsg' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                        </om:Element>
                        <om:Element Type='Send' OID='4b1a1346-b279-4475-ae5e-4732501d82b3' ParentLink='ComplexStatement_Statement' LowerBound='88.1' HigherBound='90.1'>
                            <om:Property Name='PortName' Value='RestQueryStatusApplicationInfoPort' />
                            <om:Property Name='MessageName' Value='RestQueryApplicationInfoRequestMsg' />
                            <om:Property Name='OperationName' Value='Operation' />
                            <om:Property Name='OperationMessageName' Value='Request' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Send Rest Application Request Msg' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                        <om:Element Type='Receive' OID='97fa94a4-a0c0-4548-9af3-476415580155' ParentLink='ComplexStatement_Statement' LowerBound='90.1' HigherBound='92.1'>
                            <om:Property Name='Activate' Value='False' />
                            <om:Property Name='PortName' Value='RestQueryStatusApplicationInfoPort' />
                            <om:Property Name='MessageName' Value='RestQueryApplicationInfoResponseMsg' />
                            <om:Property Name='OperationName' Value='Operation' />
                            <om:Property Name='OperationMessageName' Value='Response' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Receive Application Info Response' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                        <om:Element Type='VariableAssignment' OID='04cea421-26f7-441e-b48e-7c3576334ef1' ParentLink='ComplexStatement_Statement' LowerBound='92.1' HigherBound='94.1'>
                            <om:Property Name='Expression' Value='ApplicationSFID = xpath(RestQueryApplicationInfoResponseMsg.MessagePart, &quot;string(/*[local-name()=&apos;QueryResult&apos; and namespace-uri()=&apos;http://SBA.gov/REST/Query/DLAPEvents/CheckStatusApplicationInfoResponse&apos;]/*[local-name()=&apos;records&apos; and namespace-uri()=&apos;http://SBA.gov/REST/Query/DLAPEvents/CheckStatusApplicationInfoResponse&apos;]/*[local-name()=&apos;Id&apos; and namespace-uri()=&apos;http://SBA.gov/REST/Query/DLAPEvents/CheckStatusApplicationInfoResponse&apos;])&quot;);' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Application Value Extract' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                        <om:Element Type='Decision' OID='8d3451b7-30c7-49e5-ae92-b6c35b9031b4' ParentLink='ComplexStatement_Statement' LowerBound='94.1' HigherBound='111.1'>
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Application Exists?' />
                            <om:Property Name='Signal' Value='True' />
                            <om:Element Type='DecisionBranch' OID='c9704286-69fe-4cf5-a5ff-b2f42053ae97' ParentLink='ReallyComplexStatement_Branch' LowerBound='95.13' HigherBound='104.1'>
                                <om:Property Name='Expression' Value='(!System.String.IsNullOrEmpty(ApplicationSFID))' />
                                <om:Property Name='IsGhostBranch' Value='True' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Valid Application Number' />
                                <om:Property Name='Signal' Value='False' />
                                <om:Element Type='Construct' OID='00a2f099-886a-4d2a-bcf2-a9484c2450cc' ParentLink='ComplexStatement_Statement' LowerBound='97.1' HigherBound='103.1'>
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='Construct Event Status Response Msg' />
                                    <om:Property Name='Signal' Value='True' />
                                    <om:Element Type='Transform' OID='2f5bf8bd-7eda-4cb0-8b86-8be75b225863' ParentLink='ComplexStatement_Statement' LowerBound='100.1' HigherBound='102.1'>
                                        <om:Property Name='ClassName' Value='DLAPEventsLogic.MakeRestDLAPEventsStatusResponse' />
                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                        <om:Property Name='Name' Value='Make  Check Status Response Msg' />
                                        <om:Property Name='Signal' Value='False' />
                                        <om:Element Type='MessagePartRef' OID='7d212324-0f10-4683-8a34-16121bf6bf6e' ParentLink='Transform_InputMessagePartRef' LowerBound='101.112' HigherBound='101.159'>
                                            <om:Property Name='MessageRef' Value='RestQueryApplicationInfoResponseMsg' />
                                            <om:Property Name='PartRef' Value='MessagePart' />
                                            <om:Property Name='ReportToAnalyst' Value='True' />
                                            <om:Property Name='Name' Value='MessagePartReference_1' />
                                            <om:Property Name='Signal' Value='False' />
                                        </om:Element>
                                        <om:Element Type='MessagePartRef' OID='3ae28b90-8160-4ce9-a953-45ae1f580857' ParentLink='Transform_OutputMessagePartRef' LowerBound='101.32' HigherBound='101.58'>
                                            <om:Property Name='MessageRef' Value='StatusResponse' />
                                            <om:Property Name='PartRef' Value='MessagePart' />
                                            <om:Property Name='ReportToAnalyst' Value='True' />
                                            <om:Property Name='Name' Value='MessagePartReference_2' />
                                            <om:Property Name='Signal' Value='False' />
                                        </om:Element>
                                    </om:Element>
                                    <om:Element Type='MessageRef' OID='25155801-5be6-47ee-9022-5ceb77d8a7e6' ParentLink='Construct_MessageRef' LowerBound='98.27' HigherBound='98.41'>
                                        <om:Property Name='Ref' Value='StatusResponse' />
                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                        <om:Property Name='Signal' Value='False' />
                                    </om:Element>
                                </om:Element>
                            </om:Element>
                            <om:Element Type='DecisionBranch' OID='2704740a-bf9b-47ad-b671-3c7a420cc7c8' ParentLink='ReallyComplexStatement_Branch'>
                                <om:Property Name='IsGhostBranch' Value='True' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Else' />
                                <om:Property Name='Signal' Value='False' />
                                <om:Element Type='VariableAssignment' OID='cc4df9c1-f24c-402a-b2a7-8076922456c8' ParentLink='ComplexStatement_Statement' LowerBound='106.1' HigherBound='108.1'>
                                    <om:Property Name='Expression' Value='RestQueryException = new System.Exception(&quot;DLAP Events: Exception occurred while processing DLAP Events Status&quot;);' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='Rest Exception' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                                <om:Element Type='Throw' OID='d20063c4-edd4-4a99-a0d7-9215b4ee8bca' ParentLink='ComplexStatement_Statement' LowerBound='108.1' HigherBound='110.1'>
                                    <om:Property Name='ThrownReference' Value='RestQueryException' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='Rest Error ' />
                                    <om:Property Name='Signal' Value='True' />
                                </om:Element>
                            </om:Element>
                        </om:Element>
                    </om:Element>
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='275dd5b4-c1fe-4fa4-94da-f062d93f77a2' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='46.1' HigherBound='48.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='33' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='DLAPEvents.RestQueryStatusApplicationInfoPortType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='RestQueryStatusApplicationInfoPort' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='LogicalBindingAttribute' OID='9375d239-6e43-4380-ab6b-16a1828c03fb' ParentLink='PortDeclaration_CLRAttribute' LowerBound='46.1' HigherBound='47.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='5b142db7-6ea2-465a-b891-8ad25a19c5ba' ParentLink='Module_PortType' LowerBound='36.1' HigherBound='43.1'>
            <om:Property Name='Synchronous' Value='True' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='RestQueryStatusApplicationInfoPortType' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='OperationDeclaration' OID='8bd42525-23da-44df-bf08-9e817ccfc64d' ParentLink='PortType_OperationDeclaration' LowerBound='38.1' HigherBound='42.1'>
                <om:Property Name='OperationType' Value='RequestResponse' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='5a6d49e3-b3ac-4613-a86c-f8868f87da4e' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='40.13' HigherBound='40.48'>
                    <om:Property Name='Ref' Value='DLAPEvents.RestQueryApplicationInfoRequestType' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='MessageRef' OID='798a27e7-bc3e-4b5a-96d4-366566ead7dc' ParentLink='OperationDeclaration_ResponseMessageRef' LowerBound='40.50' HigherBound='40.86'>
                    <om:Property Name='Ref' Value='DLAPEvents.RestQueryApplicationInfoResponseType' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Response' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
        </om:Element>
    </om:Element>
</om:MetaModel>
";

        [System.SerializableAttribute]
        public class __StatusLogic_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __StatusLogic_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "StatusLogic")
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
                StatusLogic __svc__ = (StatusLogic)_service;
                __StatusLogic_root_0 __ctx0__ = (__StatusLogic_root_0)(__svc__._stateMgrs[0]);

                if (__svc__.RestQueryStatusApplicationInfoPort != null)
                {
                    __svc__.RestQueryStatusApplicationInfoPort.Close(this, null);
                    __svc__.RestQueryStatusApplicationInfoPort = null;
                }
                base.Finally();
            }

            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper0;
        }


        [System.SerializableAttribute]
        public class __StatusLogic_1 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public __StatusLogic_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "StatusLogic")
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
                StatusLogic __svc__ = (StatusLogic)_service;
                __StatusLogic_1 __ctx1__ = (__StatusLogic_1)(__svc__._stateMgrs[1]);
                __StatusLogic_root_0 __ctx0__ = (__StatusLogic_root_0)(__svc__._stateMgrs[0]);

                if (__ctx1__ != null)
                    __ctx1__.__RestQueryException = null;
                if (__ctx1__ != null)
                    __ctx1__.__APPLICATION_INFO_SOQL_QUERY = null;
                if (__ctx1__ != null && __ctx1__.__RestQueryApplicationInfoRequestMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__RestQueryApplicationInfoRequestMsg);
                    __ctx1__.__RestQueryApplicationInfoRequestMsg = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__ApplicationNumber = null;
                if (__ctx1__ != null && __ctx1__.__RestQueryApplicationInfoResponseMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__RestQueryApplicationInfoResponseMsg);
                    __ctx1__.__RestQueryApplicationInfoResponseMsg = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__ApplicationSFID = null;
                if (__ctx1__ != null)
                    __ctx1__.__ApplicationNumberList = null;
                if (__ctx1__ != null && __ctx1__.__SalesforceEventRequest != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__SalesforceEventRequest);
                    __ctx1__.__SalesforceEventRequest = null;
                }
                if (__ctx0__ != null && __ctx0__.__subWrapper0 != null)
                {
                    __ctx0__.__subWrapper0.Destroy(__svc__, __ctx0__);
                    __ctx0__.__subWrapper0 = null;
                }
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("RestQueryApplicationInfoRequestMsg")]
            internal RestQueryApplicationInfoRequestType __RestQueryApplicationInfoRequestMsg;
            [Microsoft.XLANGs.Core.UserVariableAttribute("RestQueryApplicationInfoResponseMsg")]
            internal RestQueryApplicationInfoResponseType __RestQueryApplicationInfoResponseMsg;
            [Microsoft.XLANGs.Core.UserVariableAttribute("StatusResponse")]
            internal StatusResponseType __StatusResponse;
            [Microsoft.XLANGs.Core.UserVariableAttribute("SalesforceEventRequest")]
            internal SingleNotificationEventType __SalesforceEventRequest;
            [Microsoft.XLANGs.Core.UserVariableAttribute("ApplicationNumber")]
            internal System.String __ApplicationNumber;
            [Microsoft.XLANGs.Core.UserVariableAttribute("ApplicationNumberList")]
            internal System.String __ApplicationNumberList;
            [Microsoft.XLANGs.Core.UserVariableAttribute("APPLICATION_INFO_SOQL_QUERY")]
            internal System.String __APPLICATION_INFO_SOQL_QUERY;
            [Microsoft.XLANGs.Core.UserVariableAttribute("ApplicationSFID")]
            internal System.String __ApplicationSFID;
            [Microsoft.XLANGs.Core.UserVariableAttribute("RestQueryException")]
            internal System.Exception __RestQueryException;
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
        [Microsoft.XLANGs.Core.UserVariableAttribute("RestQueryStatusApplicationInfoPort")]
        internal RestQueryStatusApplicationInfoPortType RestQueryStatusApplicationInfoPort;

        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {RestQueryStatusApplicationInfoPortType.Operation},
                                               typeof(StatusLogic).GetField("RestQueryStatusApplicationInfoPort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(StatusLogic), "RestQueryStatusApplicationInfoPort"),
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
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "412389c3-118f-4079-be64-e957e5ce7813", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "412389c3-118f-4079-be64-e957e5ce7813", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "cb8d1e10-c867-4760-ab93-2085c6090d02", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "cb8d1e10-c867-4760-ab93-2085c6090d02", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(6, "4b1a1346-b279-4475-ae5e-4732501d82b3", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(7, "4b1a1346-b279-4475-ae5e-4732501d82b3", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(8, "97fa94a4-a0c0-4548-9af3-476415580155", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(9, "97fa94a4-a0c0-4548-9af3-476415580155", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(10, "04cea421-26f7-441e-b48e-7c3576334ef1", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(11, "04cea421-26f7-441e-b48e-7c3576334ef1", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(12, "8d3451b7-30c7-49e5-ae92-b6c35b9031b4", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(13, "00a2f099-886a-4d2a-bcf2-a9484c2450cc", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(14, "00a2f099-886a-4d2a-bcf2-a9484c2450cc", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(15, "cc4df9c1-f24c-402a-b2a7-8076922456c8", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(16, "cc4df9c1-f24c-402a-b2a7-8076922456c8", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(17, "d20063c4-edd4-4a99-a0d7-9215b4ee8bca", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(18, "8d3451b7-30c7-49e5-ae92-b6c35b9031b4", 1, false)
        };

        public override Microsoft.XLANGs.RuntimeTypes.Location[] EventLocations
        {
            get { return __eventLocations; }
        }

        public static Microsoft.XLANGs.RuntimeTypes.EventData[] __eventData = new Microsoft.XLANGs.RuntimeTypes.EventData[] {
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Body),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Body),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Expression),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Expression),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Construct),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Send),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Receive),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.If),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Throw),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.If)
        };

        public static int[] __progressLocation0 = new int[] { 0,0,0,1,1,};
        public static int[] __progressLocation1 = new int[] { 0,0,1,1,1,1,1,1,2,2,3,3,4,4,5,6,6,6,7,8,8,9,10,10,11,12,12,13,13,14,12,15,15,16,17,17,18,1,1,1,1,1,};

        public static int[][] __progressLocations = new int[2] [] {__progressLocation0,__progressLocation1};
        public override int[][] ProgressLocations {get {return __progressLocations;} }

        public Microsoft.XLANGs.Core.StopConditions segment0(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[0];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[0];
            __StatusLogic_1 __ctx1__ = (__StatusLogic_1)_stateMgrs[1];
            __StatusLogic_root_0 __ctx0__ = (__StatusLogic_root_0)_stateMgrs[0];

            switch (__seg__.Progress)
            {
            case 0:
                RestQueryStatusApplicationInfoPort = new RestQueryStatusApplicationInfoPortType(0, this);
                __ctx__.PrologueCompleted = true;
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.Initialized) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.Initialized;
                goto case 1;
            case 1:
                __ctx1__ = new __StatusLogic_1(this);
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
            __StatusLogic_1 __ctx1__ = (__StatusLogic_1)_stateMgrs[1];
            __StatusLogic_root_0 __ctx0__ = (__StatusLogic_root_0)_stateMgrs[0];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx1__.__StatusResponse = null;
                __ctx1__.__SalesforceEventRequest = new SingleNotificationEventType("SalesforceEventRequest", __ctx1__);
                __ctx1__.__SalesforceEventRequest.CopyFrom((Microsoft.XLANGs.Core.XMessage)Args[1]);
                __ctx1__.RefMessage(__ctx1__.__SalesforceEventRequest);
                __ctx1__.__SalesforceEventRequest.ConstructionCompleteEvent();
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 1;
            case 1:
                __ctx1__.__ApplicationNumber = default(System.String);
                __ctx1__.__ApplicationNumberList = default(System.String);
                __ctx1__.__APPLICATION_INFO_SOQL_QUERY = default(System.String);
                __ctx1__.__ApplicationSFID = default(System.String);
                __ctx1__.__RestQueryException = default(System.Exception);
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
                __ctx1__.__ApplicationNumber = "";
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                __ctx1__.__ApplicationNumberList = "";
                if ( !PostProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 5;
            case 5:
                __ctx1__.__APPLICATION_INFO_SOQL_QUERY = "";
                if ( !PostProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 6;
            case 6:
                __ctx1__.__ApplicationSFID = "";
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                __ctx1__.__RestQueryException = new System.Exception();
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
                __ctx1__.__ApplicationNumber = (System.String)Microsoft.XLANGs.Core.Part.XPathLoad(__ctx1__.__SalesforceEventRequest.MessagePart, "string(/*[local-name()='Notifications' and namespace-uri()='http://DLAPEventsSalesforceDefinition/SingleNotificationEvent']/*[local-name()='Notification' and namespace-uri()='http://soap.sforce.com/2005/09/outbound']/*[local-name()='sObject' and namespace-uri()='http://soap.sforce.com/2005/09/outbound']/*[local-name()='Application_Number__c' and namespace-uri()='urn:sobject.enterprise.soap.sforce.com'])", typeof(System.String));
                if ( !PostProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 10;
            case 10:
                if ( !PreProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[3],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 11;
            case 11:
                __ctx1__.__ApplicationNumberList = "'" + __ctx1__.__ApplicationNumber + "'";
                if (__ctx1__ != null)
                    __ctx1__.__ApplicationNumber = null;
                if ( !PostProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 12;
            case 12:
                if ( !PreProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[4],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 13;
            case 13:
                {
                    RestQueryApplicationInfoRequestType __RestQueryApplicationInfoRequestMsg = new RestQueryApplicationInfoRequestType("RestQueryApplicationInfoRequestMsg", __ctx1__);

                    ApplyTransform(typeof(DLAPEventsLogic.MakeRestQueryApplicationInfoRequest), new object[] {__RestQueryApplicationInfoRequestMsg.MessagePart}, new object[] {__ctx1__.__SalesforceEventRequest.MessagePart});
                    __ctx1__.__APPLICATION_INFO_SOQL_QUERY = @"Select Id, Name, Loan_Type__c, DLAP_Status_Description__c, DLAP_Status__c, Disaster_Declaration__r.Name,Disaster_Declaration__r.Disaster_Description__c, Disaster_Declaration__r.Disaster_Deadline_Date__c, (Select Id,Checklist_Item_Status__c FROM Checklist_Items__r WHERE ((Type__c != 'Interface' AND Checklist_Item_Status__c = 'Requested') OR (((Type__c = 'Closing Documents') AND (Checklist_Item_Status__c = 'Pending Borrower\'s Verification'))))),(Select Id,Name from Loans__r) FROM Application__c WHERE Name IN " + "(" + __ctx1__.__ApplicationNumberList + ")";
                    if (__ctx1__ != null)
                        __ctx1__.__ApplicationNumberList = null;
                    __RestQueryApplicationInfoRequestMsg.SetPropertyValue(typeof(DLAPEventsSalesforceDefinition.RestCheckStatus.SF_APPLICATION_QUERY), __ctx1__.__APPLICATION_INFO_SOQL_QUERY);
                    if (__ctx1__ != null)
                        __ctx1__.__APPLICATION_INFO_SOQL_QUERY = null;

                    if (__ctx1__.__RestQueryApplicationInfoRequestMsg != null)
                        __ctx1__.UnrefMessage(__ctx1__.__RestQueryApplicationInfoRequestMsg);
                    __ctx1__.__RestQueryApplicationInfoRequestMsg = __RestQueryApplicationInfoRequestMsg;
                    __ctx1__.RefMessage(__ctx1__.__RestQueryApplicationInfoRequestMsg);
                }
                __ctx1__.__RestQueryApplicationInfoRequestMsg.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 14;
            case 14:
                if ( !PreProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__RestQueryApplicationInfoRequestMsg);
                    __edata.Messages.Add(__ctx1__.__SalesforceEventRequest);
                    Tracker.FireEvent(__eventLocations[5],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 15;
            case 15:
                if ( !PreProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[6],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 16;
            case 16:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 17 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 17;
            case 17:
                if ( !PreProgressInc( __seg__, __ctx__, 18 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                RestQueryStatusApplicationInfoPort.SendMessage(0, __ctx1__.__RestQueryApplicationInfoRequestMsg, null, null, out __ctx0__.__subWrapper0, __ctx1__, __seg__ );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 18;
            case 18:
                if ( !PreProgressInc( __seg__, __ctx__, 19 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__RestQueryApplicationInfoRequestMsg);
                    __edata.PortName = @"RestQueryStatusApplicationInfoPort";
                    Tracker.FireEvent(__eventLocations[7],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__RestQueryApplicationInfoRequestMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__RestQueryApplicationInfoRequestMsg);
                    __ctx1__.__RestQueryApplicationInfoRequestMsg = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 19;
            case 19:
                if ( !PreProgressInc( __seg__, __ctx__, 20 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[8],__eventData[6],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 20;
            case 20:
                if (!RestQueryStatusApplicationInfoPort.GetMessageId(__ctx0__.__subWrapper0.getSubscription(this), __seg__, __ctx1__, out __msgEnv__, _locations[0]))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx0__ != null && __ctx0__.__subWrapper0 != null)
                {
                    __ctx0__.__subWrapper0.Destroy(this, __ctx0__);
                    __ctx0__.__subWrapper0 = null;
                }
                if (__ctx1__.__RestQueryApplicationInfoResponseMsg != null)
                    __ctx1__.UnrefMessage(__ctx1__.__RestQueryApplicationInfoResponseMsg);
                __ctx1__.__RestQueryApplicationInfoResponseMsg = new RestQueryApplicationInfoResponseType("RestQueryApplicationInfoResponseMsg", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__RestQueryApplicationInfoResponseMsg);
                RestQueryStatusApplicationInfoPort.ReceiveMessage(0, __msgEnv__, __ctx1__.__RestQueryApplicationInfoResponseMsg, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if (RestQueryStatusApplicationInfoPort != null)
                {
                    RestQueryStatusApplicationInfoPort.Close(__ctx1__, __seg__);
                    RestQueryStatusApplicationInfoPort = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 21 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 21;
            case 21:
                if ( !PreProgressInc( __seg__, __ctx__, 22 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__RestQueryApplicationInfoResponseMsg);
                    __edata.PortName = @"RestQueryStatusApplicationInfoPort";
                    Tracker.FireEvent(__eventLocations[9],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 22;
            case 22:
                if ( !PreProgressInc( __seg__, __ctx__, 23 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[10],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 23;
            case 23:
                __ctx1__.__ApplicationSFID = (System.String)Microsoft.XLANGs.Core.Part.XPathLoad(__ctx1__.__RestQueryApplicationInfoResponseMsg.MessagePart, "string(/*[local-name()='QueryResult' and namespace-uri()='http://SBA.gov/REST/Query/DLAPEvents/CheckStatusApplicationInfoResponse']/*[local-name()='records' and namespace-uri()='http://SBA.gov/REST/Query/DLAPEvents/CheckStatusApplicationInfoResponse']/*[local-name()='Id' and namespace-uri()='http://SBA.gov/REST/Query/DLAPEvents/CheckStatusApplicationInfoResponse'])", typeof(System.String));
                if ( !PostProgressInc( __seg__, __ctx__, 24 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 24;
            case 24:
                if ( !PreProgressInc( __seg__, __ctx__, 25 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[11],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 25;
            case 25:
                if ( !PreProgressInc( __seg__, __ctx__, 26 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[12],__eventData[7],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 26;
            case 26:
                __condition__ = (!System.String.IsNullOrEmpty(__ctx1__.__ApplicationSFID));
                if (__ctx1__ != null)
                    __ctx1__.__ApplicationSFID = null;
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 31 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 31;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 27 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 27;
            case 27:
                if ( !PreProgressInc( __seg__, __ctx__, 28 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[13],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 28;
            case 28:
                {
                    StatusResponseType __StatusResponse = new StatusResponseType("StatusResponse", __ctx1__);

                    ApplyTransform(typeof(DLAPEventsLogic.MakeRestDLAPEventsStatusResponse), new object[] {__StatusResponse.MessagePart}, new object[] {__ctx1__.__RestQueryApplicationInfoResponseMsg.MessagePart});

                    if (__ctx1__.__StatusResponse != null)
                        __ctx1__.UnrefMessage(__ctx1__.__StatusResponse);
                    __ctx1__.__StatusResponse = __StatusResponse;
                    __ctx1__.RefMessage(__ctx1__.__StatusResponse);
                }
                __ctx1__.__StatusResponse.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 29 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 29;
            case 29:
                if ( !PreProgressInc( __seg__, __ctx__, 30 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__StatusResponse);
                    __edata.Messages.Add(__ctx1__.__RestQueryApplicationInfoResponseMsg);
                    Tracker.FireEvent(__eventLocations[14],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 30;
            case 30:
                if ( !PostProgressInc( __seg__, __ctx__, 36 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 36;
            case 31:
                if ( !PreProgressInc( __seg__, __ctx__, 32 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[15],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 32;
            case 32:
                __ctx1__.__RestQueryException = new System.Exception("DLAP Events: Exception occurred while processing DLAP Events Status");
                if ( !PostProgressInc( __seg__, __ctx__, 33 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 33;
            case 33:
                if ( !PreProgressInc( __seg__, __ctx__, 34 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[16],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 34;
            case 34:
                if ( !PreProgressInc( __seg__, __ctx__, 35 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[17],__eventData[8],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 35;
            case 35:
                throw __ctx1__.__RestQueryException;
            case 36:
                if ( !PreProgressInc( __seg__, __ctx__, 37 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if (__ctx1__ != null)
                    __ctx1__.__RestQueryException = null;
                if (__ctx1__ != null && __ctx1__.__RestQueryApplicationInfoResponseMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__RestQueryApplicationInfoResponseMsg);
                    __ctx1__.__RestQueryApplicationInfoResponseMsg = null;
                }
                Tracker.FireEvent(__eventLocations[18],__eventData[9],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 37;
            case 37:
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Body);
                    __edata.Messages.Add(__ctx1__.__StatusResponse);
                    __edata.Messages.Add(__ctx1__.__SalesforceEventRequest);
                    Tracker.FireEvent(__eventLocations[0],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__SalesforceEventRequest != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__SalesforceEventRequest);
                    __ctx1__.__SalesforceEventRequest = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 38 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 38;
            case 38:
                if (!__ctx1__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 39 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 39;
            case 39:
                if ( !PreProgressInc( __seg__, __ctx__, 40 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx1__.OnCommit();
                goto case 40;
            case 40:
                ((Microsoft.XLANGs.Core.MessageTuple)(Args[0])).message = __ctx1__.__StatusResponse;
                ((Microsoft.XLANGs.Core.MessageTuple)(Args[0])).context.RefMessage(__ctx1__.__StatusResponse);
                if ( !PostProgressInc( __seg__, __ctx__, 41 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 41;
            case 41:
                __seg__.SegmentDone();
                _segments[0].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }
        private static Microsoft.XLANGs.Core.CachedObject[] _locations = new Microsoft.XLANGs.Core.CachedObject[] {
            new Microsoft.XLANGs.Core.CachedObject(new System.Guid("{CEAA2FE7-02DE-4389-B7E5-32F9F0612A3C}"))
        };

    }
    //#line 949 "C:\Users\skyeniga\Source\Repos\Biztalk\DLAP Events\DLAP Events Logic\DLAPEventDocumentLogic.odx"
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        },
        new System.Type[] {
            typeof(DLAPEvents.SalesforceQueryDocumentApplicationInfoPortType),
            typeof(DLAPEvents.RestDocumentChecklistItemQueryPortType)
        },
        new System.String[] {
            "RestApplicationInfoPort",
            "RestDocumentChecklistItemQueryPort"
        },
        new System.Type[] {
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
        Microsoft.XLANGs.BaseTypes.EXLangSServiceInfo.eCallable
    )]
    [System.SerializableAttribute]
    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed internal class DocumentLogic : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
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
        public static void __bodyProxy(
            [ Microsoft.XLANGs.BaseTypes.ServiceParameterAttribute(Microsoft.XLANGs.BaseTypes.EXLangSParameter.eMessage, "") ] DLAPEvents.SingleNotificationEventType SalesforceNotificationEventRequest,
            [ Microsoft.XLANGs.BaseTypes.ServiceParameterAttribute(Microsoft.XLANGs.BaseTypes.EXLangSParameter.eMessage, "") ] out DLAPEvents.DocumentResponseType DocumentResponse)
        {
            DocumentResponse = default(DLAPEvents.DocumentResponseType);
        }
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(DocumentLogic));
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

        static DocumentLogic()
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
            _rootContext = new __DocumentLogic_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[2];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public DocumentLogic(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "DocumentLogic", tracker)
        {
            ConstructorHelper();
        }

        public DocumentLogic(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "DocumentLogic")
        {
            ConstructorHelper();
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>dda8238e-921f-4606-9ea6-2967a3c9b5b6</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>MessageDeclarationShape</shapeType>      <ShapeID>10a214a2-2d0c-458b-989c-75376e969864</ShapeID>      <ParentLink>ServiceBody_Declaration</ParentLink>                <shapeText>SalesforceNotificationEventRequest</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageDeclarationShape</shapeType>      <ShapeID>6e6a3b73-b8f9-4ba0-bfb7-1a36c3be48bc</ShapeID>      <ParentLink>ServiceBody_Declaration</ParentLink>                <shapeText>DocumentResponse</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>TaskShape</shapeType>      <ShapeID>06a9dbfa-c48c-43d6-b01c-52a7f07c51fa</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Document Response Processing</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>TaskShape</shapeType>      <ShapeID>1eb749f3-111e-43a6-86ee-220591f96e23</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Application Info Processing</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>973848db-e00c-4821-b311-436460a589b4</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Extract Application Number</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>ff02eb63-5cf3-4fb9-8c20-546665f4988c</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Construct Rest Status Application Info Request Msg</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>40b46181-b7da-4552-902a-26a7e87d29e9</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>e8b44302-9b67-4ff9-a4c0-8dc187bd7a08</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Make Rest Query Application Info Request </shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>ca33649e-554d-450f-b7b4-d0d5cd144e9a</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_9</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>fcfb3b1a-393d-4b6e-b9ec-e6410ecf800e</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_10</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>89807a37-b59c-4af6-afad-6b4a4cbca7d3</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Injecting Application SOQL Query</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>60a96da9-e7db-446d-abcd-da44b5f6d237</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Send Rest Request</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>4f58ced4-49f2-471d-89da-d0cfda0691c6</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Receive Rest Response</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>c0a9c700-9ddb-4114-b579-85f2f1de01eb</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Construct Application Info Response Msg</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>2e50cea7-14ad-4934-ac26-45d8a4bc945c</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Make Application Info Response </shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>2d679693-ec90-489f-8d1d-85912af85b42</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>adf057b9-000d-4cb7-895a-b198fa9775f9</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>974d536c-f2d1-4bea-8740-16b573d230f1</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>95498e81-b9fc-4a66-9f94-5e20c9fec88a</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Construct Document CheckList Item Response Msg</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>08f9b13e-6456-48db-84aa-7b680f900ca9</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>MakeSalesforceCheckListItemResponse</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>d36c0d53-c6d2-4fd6-b088-55b97c804c7a</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_13</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>fa1495a6-a243-4370-84de-bd7ccc63a652</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_14</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>afb96788-57cf-4a2e-ab34-dc8b738c68ea</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>97efb380-5fee-4155-a44f-1d0a40e1b531</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Applicant Count</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>TaskShape</shapeType>      <ShapeID>79fd6574-c5e6-445f-875f-7295bba562b7</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Application Document List Processing</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>4d9fe9c1-21e5-416a-afc5-2551eec53f4e</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Construct Rest Document Request Msg</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>ab30e0c6-bcc8-4113-9f73-0576bf7441a8</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Make Rest Document Request</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>080f4863-f488-496a-8a65-8b381682303f</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_7</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>b4d15d87-2581-4050-b902-904fa209bf68</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_8</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>4db0dde8-5a5a-4c30-a638-3b115007e1f4</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Injecting Applicant Document SOQL Query</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>30ec3273-ff9c-436d-8005-7137afce5d36</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>5e89cfd3-7fe6-4a67-9cfa-e0871299f174</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Send Rest Document Request</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>14e485b4-b001-48ee-883f-6923c74f1997</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Receive Rest Document Response</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>1ebb7433-719c-4a87-9a6a-b4a9df250381</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Construct Checklist Item Document Response</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>cff756f6-2040-4b6c-874b-5d7a55800a34</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Make Salesforce Checklist Item Document Response</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>77031742-b4f3-49b5-a161-3b519b09a5f6</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_11</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>4cf97a20-4986-4925-98b4-25eb8eec9666</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_12</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>12bde222-0009-4a05-982c-1453705ad42c</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>ea1d3ad9-d64c-4ea2-a36e-ace0fac0a94e</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Construct Checklist Item Document Message</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>1344b71d-0416-467f-b8c2-7dfc91b6d07e</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Make Checklist Item Document Response</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>0521582a-d718-4778-9172-1477888381c1</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>161ded47-84ac-4f07-a96d-113b9fa50f30</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Construct Document List Response Msg</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>76515481-42c5-42bb-b758-94209a24e196</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>eb8522ce-1fdf-4050-b286-bd797746e67a</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Make DocumentList Response</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>666a0333-86b3-4f18-aa50-c77605a6a9f6</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_6</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>dcec46e6-3239-488f-b693-d08d34a33dc4</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_3</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>1ae496f7-3855-42ad-93a8-23121fe16caa</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_4</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>759aa04d-c8da-4917-8399-141601af07c4</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_5</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow><Metadata>

<TrkMetadata>
<ActionName>'DocumentLogic'</ActionName><IsAtomic>0</IsAtomic><Line>949</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
<Messages>
	<MsgInfo><name>SalesforceNotificationEventRequest</name><part>MessagePart</part><schema>DLAPEventsSalesforceDefinition.SingleNotificationEvent</schema><direction>In</direction></MsgInfo>
	<MsgInfo><name>DocumentResponse</name><part>MessagePart</part><schema>DLAPEventsDefinition.EventDocumentListResponse</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1036</Line><Position>31</Position><ShapeID>'973848db-e00c-4821-b311-436460a589b4'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1045</Line><Position>13</Position><ShapeID>'ff02eb63-5cf3-4fb9-8c20-546665f4988c'</ShapeID>
<Messages>
	<MsgInfo><name>RestQueryApplicationInfoRequestMsg</name><part>MessagePart</part><schema>DLAPEventsSalesforceDefinition.RestCheckStatus.RestCheckStatusSalesforceRequest</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>SalesforceNotificationEventRequest</name><part>MessagePart</part><schema>DLAPEventsSalesforceDefinition.SingleNotificationEvent</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1062</Line><Position>13</Position><ShapeID>'60a96da9-e7db-446d-abcd-da44b5f6d237'</ShapeID>
<Messages>
	<MsgInfo><name>RestQueryApplicationInfoRequestMsg</name><part>MessagePart</part><schema>DLAPEventsSalesforceDefinition.RestCheckStatus.RestCheckStatusSalesforceRequest</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1064</Line><Position>13</Position><ShapeID>'4f58ced4-49f2-471d-89da-d0cfda0691c6'</ShapeID>
<Messages>
	<MsgInfo><name>RestQueryApplicationInfoResponseMsg</name><part>MessagePart</part><schema>DLAPEventsSalesforceDefinition.RestCheckStatus.RestCheckStatusSalesforceResponse</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1066</Line><Position>13</Position><ShapeID>'c0a9c700-9ddb-4114-b579-85f2f1de01eb'</ShapeID>
<Messages>
	<MsgInfo><name>SalesforceQueryApplicationInfoResponseMsg</name><part>MessagePart</part><schema>DLAPEventsSalesforceDefinition.SalesforceQuery__Application_Info__c+Response</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>RestQueryApplicationInfoResponseMsg</name><part>MessagePart</part><schema>DLAPEventsSalesforceDefinition.RestCheckStatus.RestCheckStatusSalesforceResponse</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1072</Line><Position>13</Position><ShapeID>'95498e81-b9fc-4a66-9f94-5e20c9fec88a'</ShapeID>
<Messages>
	<MsgInfo><name>SalesforceQueryDocumentChecklistItemResponseMsg</name><part>MessagePart</part><schema>DLAPEventsSalesforceDefinition.SalesforceQuery_Document_Checklist_Item__c+Response</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>RestQueryApplicationInfoResponseMsg</name><part>MessagePart</part><schema>DLAPEventsSalesforceDefinition.RestCheckStatus.RestCheckStatusSalesforceResponse</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1079</Line><Position>28</Position><ShapeID>'97efb380-5fee-4155-a44f-1d0a40e1b531'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1081</Line><Position>13</Position><ShapeID>'4d9fe9c1-21e5-416a-afc5-2551eec53f4e'</ShapeID>
<Messages>
	<MsgInfo><name>RestDocumentDetailsRequestMsg</name><part>MessagePart</part><schema>DLAPEventsSalesforceDefinition.RestDocument.RequestResponse+Request</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>SalesforceNotificationEventRequest</name><part>MessagePart</part><schema>DLAPEventsSalesforceDefinition.SingleNotificationEvent</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1093</Line><Position>13</Position><ShapeID>'5e89cfd3-7fe6-4a67-9cfa-e0871299f174'</ShapeID>
<Messages>
	<MsgInfo><name>RestDocumentDetailsRequestMsg</name><part>MessagePart</part><schema>DLAPEventsSalesforceDefinition.RestDocument.RequestResponse+Request</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1095</Line><Position>13</Position><ShapeID>'14e485b4-b001-48ee-883f-6923c74f1997'</ShapeID>
<Messages>
	<MsgInfo><name>RestDocumentDetailsResponseMsg</name><part>MessagePart</part><schema>DLAPEventsSalesforceDefinition.RestDocument.RequestResponse+QueryResult</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1097</Line><Position>13</Position><ShapeID>'1ebb7433-719c-4a87-9a6a-b4a9df250381'</ShapeID>
<Messages>
	<MsgInfo><name>SalesforceQueryContentVersionResponseMsg</name><part>MessagePart</part><schema>DLAPEventsSalesforceDefinition.SalesforceQuery_ContentVersion__c+Response</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>RestDocumentDetailsResponseMsg</name><part>MessagePart</part><schema>DLAPEventsSalesforceDefinition.RestDocument.RequestResponse+QueryResult</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1103</Line><Position>13</Position><ShapeID>'ea1d3ad9-d64c-4ea2-a36e-ace0fac0a94e'</ShapeID>
<Messages>
	<MsgInfo><name>SalesforceCheckListDocumentListDetailsResponseMsg</name><part>MessagePart</part><schema>DLAPEventsSalesforceDefinition.ChecklistItemDocumentDetails</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1139</Line><Position>13</Position><ShapeID>'161ded47-84ac-4f07-a96d-113b9fa50f30'</ShapeID>
<Messages>
	<MsgInfo><name>DocumentResponse</name><part>MessagePart</part><schema>DLAPEventsDefinition.EventDocumentListResponse</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>SalesforceCheckListDocumentListDetailsResponseMsg</name><part>MessagePart</part><schema>DLAPEventsSalesforceDefinition.ChecklistItemDocumentDetails</schema><direction>In</direction></MsgInfo>
	<MsgInfo><name>SalesforceQueryApplicationInfoResponseMsg</name><part>MessagePart</part><schema>DLAPEventsSalesforceDefinition.SalesforceQuery__Application_Info__c+Response</schema><direction>In</direction></MsgInfo>
	<MsgInfo><name>SalesforceQueryDocumentChecklistItemResponseMsg</name><part>MessagePart</part><schema>DLAPEventsSalesforceDefinition.SalesforceQuery_Document_Checklist_Item__c+Response</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='916623db-8707-42d9-abaa-6ad0ca2193a2' LowerBound='1.1' HigherBound='256.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='DLAPEvents' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='ServiceDeclaration' OID='9240d5eb-aff8-4a83-a8bd-9b76d9a50dca' ParentLink='Module_ServiceDeclaration' LowerBound='57.1' HigherBound='255.1'>
            <om:Property Name='InitializedTransactionType' Value='False' />
            <om:Property Name='IsInvokable' Value='True' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='DocumentLogic' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='VariableDeclaration' OID='0b267230-817f-48d5-968c-bdf173a18eaf' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='76.1' HigherBound='77.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ApplicationSFID' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='c6f1b65b-4a8d-4c95-98c6-1a411fbefdb4' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='77.1' HigherBound='78.1'>
                <om:Property Name='UseDefaultConstructor' Value='True' />
                <om:Property Name='Type' Value='System.Xml.XmlDocument' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='TempApplicationDocList' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='f4efe5af-70bc-4691-b2bc-49bf00fc1d4d' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='78.1' HigherBound='79.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ApplicationStrTempEmpty' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='5ee7bf4e-8df5-4a6f-a915-48ea0618bf17' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='79.1' HigherBound='80.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='StrTempEmpty' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='b5c76327-a324-47a9-bf59-9f5db110eddb' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='80.1' HigherBound='81.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.Int32' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ApplicantDocCount' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='d443ddb8-0994-4c98-9854-c0be698232bc' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='81.1' HigherBound='82.1'>
                <om:Property Name='UseDefaultConstructor' Value='True' />
                <om:Property Name='Type' Value='System.Xml.XmlDocument' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='TempDoc' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='f32bd802-b2cb-4a7e-b2c5-7da0bcfd485f' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='82.1' HigherBound='83.1'>
                <om:Property Name='InitialValue' Value='1' />
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.Int32' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='LoopCount' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='ebcc7a41-7d03-4bd6-8760-56bb0ad5b8b9' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='83.1' HigherBound='84.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.Int32' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ApplicantCount' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='cea388ff-702d-4e32-a728-4c92125da612' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='84.1' HigherBound='85.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ApplicantSFIDXpath' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='6e45c094-4088-49bb-a748-c6c34918d85f' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='85.1' HigherBound='86.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ApplicantSFID' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='fe3427fa-60d1-46ef-80ed-83e4ea2f17aa' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='86.1' HigherBound='87.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ApplicantNameXpath' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='282c4d53-eeab-4cce-820f-a7414b4c8e73' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='87.1' HigherBound='88.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ApplicantName' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='1a7ed1cf-de71-4aa9-9f2b-1ffbc1231330' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='88.1' HigherBound='89.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='DLAPUserID' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='e493af59-eff9-4f23-8e10-cc251a2379d9' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='89.1' HigherBound='90.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SFObjectID' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='3887a24d-2db9-4068-a5e5-5a67ae294c77' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='90.1' HigherBound='91.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ChecklistItemDocApplicantSFIDxpath' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='e3925d3c-150a-41d1-a8ba-f8ee52f2d9f2' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='91.1' HigherBound='92.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ChecklistItemDocApplicantSFID' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='78d7d741-9d30-4d00-b267-0d137c5981a5' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='92.1' HigherBound='93.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ChecklistItemStatusxPath' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='052cda37-4f6d-4b94-bd7e-e7bd82327b58' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='93.1' HigherBound='94.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ChecklistItemStatus' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='80bef668-d23e-48e1-8598-36391059521f' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='94.1' HigherBound='95.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='DocumentMasterCheckListNamexPath' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='d1821625-2049-498b-b628-4a19739df62c' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='95.1' HigherBound='96.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='DocumentMasterCheckListName' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='47cc5e3a-6821-4b5a-98f4-5a070579ec1a' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='96.1' HigherBound='97.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='DocumentMasterCheckListDescxPath' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='7749a57c-9a8e-466e-a193-5848f782b2d6' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='97.1' HigherBound='98.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='DocumentMasterCheckListDesc' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='3dbee88f-4ff6-43bc-a7a4-af495ed586e9' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='98.1' HigherBound='99.1'>
                <om:Property Name='UseDefaultConstructor' Value='True' />
                <om:Property Name='Type' Value='System.Xml.XmlDocument' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ChecklistItemTempDoc' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='a9a5b8cc-719b-42e7-a560-b24dfa5d4694' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='99.1' HigherBound='100.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ChecklistStrTempEmpty' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='260515ae-e5a3-446f-b441-3cae27c48d5a' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='100.1' HigherBound='101.1'>
                <om:Property Name='UseDefaultConstructor' Value='True' />
                <om:Property Name='Type' Value='System.Xml.XmlDocument' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='TempChecklistItemDocList' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='faef5a79-f263-4dbf-9274-3484b08efb4a' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='101.1' HigherBound='102.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ChecklistItemTypexPath' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='231ffa93-7a0f-457f-8fbe-36b3d0c34050' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='102.1' HigherBound='103.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ChecklistItemType' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='74b28e5f-6153-4041-b5c4-de40a70cb4f9' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='103.1' HigherBound='104.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='APPLICATION_INFO_SOQL_QUERY' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='933868f6-7560-4bf7-9d3f-29307ea9ab59' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='104.1' HigherBound='105.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ApplicationNumber' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='9008a66c-96d5-43a7-a0ea-46b1c3882aec' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='105.1' HigherBound='106.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ApplicationNumberList' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='ee3da71b-fad4-4131-85fc-c05eac6ee2b2' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='106.1' HigherBound='107.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='CheckListItem_DOCUMENT_SOQL_QUERY' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='b0aeef5f-ec79-4971-95db-217f37f5c466' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='107.1' HigherBound='108.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ChecklistItemSFID' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='ede80b2d-10f2-4afe-bb0d-1c6bf8141576' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='108.1' HigherBound='109.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ChecklistItemSFIDList' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='0ed78513-551e-4512-9f6a-1c919115002b' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='109.1' HigherBound='110.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='DOCUMENT_APPLICATION_INFO_SOQL_QUERY' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='f5c3a667-376c-4dfb-adbf-f84e224a058d' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='64.1' HigherBound='65.1'>
                <om:Property Name='Type' Value='DLAPEvents.RestQueryApplicationInfoResponseType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='RestQueryApplicationInfoResponseMsg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='6794b5d1-1b69-4d06-8eec-cc39a26d2a64' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='65.1' HigherBound='66.1'>
                <om:Property Name='Type' Value='DLAPEvents.RestQueryApplicationInfoRequestType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='RestQueryApplicationInfoRequestMsg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='33d4a83a-2e57-4b59-b2f6-9e5b35184a37' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='66.1' HigherBound='67.1'>
                <om:Property Name='Type' Value='DLAPEvents.MultipleDocumentListDetailsResponseType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='MultipleDocumentListDetailsResponseMsg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='3ce8dec2-78b0-4b71-9715-edde8089b83f' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='67.1' HigherBound='68.1'>
                <om:Property Name='Type' Value='DLAPEvents.SalesforceQueryStatusApplicationInfoRequestType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SalesforceQueryApplicationInfoRequestMsg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='6b0f9a34-f2e9-4e06-92b4-a2730c1466db' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='68.1' HigherBound='69.1'>
                <om:Property Name='Type' Value='DLAPEvents.SalesforceQueryStatusApplicationInfoResponseType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SalesforceQueryApplicationInfoResponseMsg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='51a13ccf-61bb-4903-b541-4d8599e5d9f6' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='69.1' HigherBound='70.1'>
                <om:Property Name='Type' Value='DLAPEvents.SalesforceQueryDocumentChecklistItemRequestType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SalesforceQueryDocumentChecklistItemRequestMsg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='cbfdc515-a191-4a9e-aea0-5aa006dc36b4' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='70.1' HigherBound='71.1'>
                <om:Property Name='Type' Value='DLAPEvents.SalesforceQueryDocumentChecklistItemResponseType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SalesforceQueryDocumentChecklistItemResponseMsg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='f670f69a-1fab-4c8c-be91-ba3f7c4db595' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='71.1' HigherBound='72.1'>
                <om:Property Name='Type' Value='DLAPEvents.SalesforceQueryContentVersionResponseType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SalesforceQueryContentVersionResponseMsg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='27081256-25cd-43f8-bd2c-2a0e722097dd' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='72.1' HigherBound='73.1'>
                <om:Property Name='Type' Value='DLAPEvents.SalesforceQueryContentVersionRequestType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SalesforceQueryContentVersionRequestMsg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='b9bcd03e-f8be-48b3-88d3-7da552c69907' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='73.1' HigherBound='74.1'>
                <om:Property Name='Type' Value='DLAPEvents.SalesforceCheckListDocumentListDetailsResponseType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SalesforceCheckListDocumentListDetailsResponseMsg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='814ec7e0-8305-49e1-b884-be281af904ea' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='74.1' HigherBound='75.1'>
                <om:Property Name='Type' Value='DLAPEvents.RestDocumentDetailsRequestType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='RestDocumentDetailsRequestMsg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='8a1cd8ce-a42c-43d1-9c73-2f685223349c' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='75.1' HigherBound='76.1'>
                <om:Property Name='Type' Value='DLAPEvents.RestDocumentDetailsResponseType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='RestDocumentDetailsResponseMsg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='ServiceBody' OID='dda8238e-921f-4606-9ea6-2967a3c9b5b6' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageDeclaration' OID='10a214a2-2d0c-458b-989c-75376e969864' ParentLink='ServiceBody_Declaration' LowerBound='110.15' HigherBound='110.85'>
                    <om:Property Name='Type' Value='DLAPEvents.SingleNotificationEventType' />
                    <om:Property Name='ParamDirection' Value='In' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='SalesforceNotificationEventRequest' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='MessageDeclaration' OID='6e6a3b73-b8f9-4ba0-bfb7-1a36c3be48bc' ParentLink='ServiceBody_Declaration' LowerBound='110.87' HigherBound='110.136'>
                    <om:Property Name='Type' Value='DLAPEvents.DocumentResponseType' />
                    <om:Property Name='ParamDirection' Value='Out' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='DocumentResponse' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Task' OID='06a9dbfa-c48c-43d6-b01c-52a7f07c51fa' ParentLink='ServiceBody_Statement' LowerBound='144.1' HigherBound='253.1'>
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Document Response Processing' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='Task' OID='1eb749f3-111e-43a6-86ee-220591f96e23' ParentLink='ComplexStatement_Statement' LowerBound='144.1' HigherBound='189.1'>
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Application Info Processing' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='VariableAssignment' OID='973848db-e00c-4821-b311-436460a589b4' ParentLink='ComplexStatement_Statement' LowerBound='144.1' HigherBound='153.1'>
                            <om:Property Name='Expression' Value='ApplicationNumber = xpath(SalesforceNotificationEventRequest.MessagePart, &quot;string(/*[local-name()=&apos;Notifications&apos; and namespace-uri()=&apos;http://DLAPEventsSalesforceDefinition/SingleNotificationEvent&apos;]/*[local-name()=&apos;Notification&apos; and namespace-uri()=&apos;http://soap.sforce.com/2005/09/outbound&apos;]/*[local-name()=&apos;sObject&apos; and namespace-uri()=&apos;http://soap.sforce.com/2005/09/outbound&apos;]/*[local-name()=&apos;Application_Number__c&apos; and namespace-uri()=&apos;urn:sobject.enterprise.soap.sforce.com&apos;])&quot;);&#xD;&#xA;&#xD;&#xA;ApplicationNumberList = &quot;&apos;&quot;+ApplicationNumber+&quot;&apos;&quot;;&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;ChecklistItemSFID = xpath(SalesforceNotificationEventRequest.MessagePart,&quot;string(/*[local-name()=&apos;Notifications&apos; and namespace-uri()=&apos;http://DLAPEventsSalesforceDefinition/SingleNotificationEvent&apos;]/*[local-name()=&apos;Notification&apos; and namespace-uri()=&apos;http://soap.sforce.com/2005/09/outbound&apos;]/*[local-name()=&apos;sObject&apos; and namespace-uri()=&apos;http://soap.sforce.com/2005/09/outbound&apos;]/*[local-name()=&apos;SObject_ID__c&apos; and namespace-uri()=&apos;urn:sobject.enterprise.soap.sforce.com&apos;])&quot;);&#xD;&#xA;&#xD;&#xA;ChecklistItemSFIDList = &quot;&apos;&quot;+ChecklistItemSFID+&quot;&apos;&quot;;' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Extract Application Number' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                        <om:Element Type='Construct' OID='ff02eb63-5cf3-4fb9-8c20-546665f4988c' ParentLink='ComplexStatement_Statement' LowerBound='153.1' HigherBound='170.1'>
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Construct Rest Status Application Info Request Msg' />
                            <om:Property Name='Signal' Value='True' />
                            <om:Element Type='MessageRef' OID='40b46181-b7da-4552-902a-26a7e87d29e9' ParentLink='Construct_MessageRef' LowerBound='154.23' HigherBound='154.57'>
                                <om:Property Name='Ref' Value='RestQueryApplicationInfoRequestMsg' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='Transform' OID='e8b44302-9b67-4ff9-a4c0-8dc187bd7a08' ParentLink='ComplexStatement_Statement' LowerBound='156.1' HigherBound='158.1'>
                                <om:Property Name='ClassName' Value='DLAPEventsLogic.MakeRestQueryApplicationInfoRequest' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Make Rest Query Application Info Request ' />
                                <om:Property Name='Signal' Value='False' />
                                <om:Element Type='MessagePartRef' OID='ca33649e-554d-450f-b7b4-d0d5cd144e9a' ParentLink='Transform_InputMessagePartRef' LowerBound='157.131' HigherBound='157.177'>
                                    <om:Property Name='MessageRef' Value='SalesforceNotificationEventRequest' />
                                    <om:Property Name='PartRef' Value='MessagePart' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='MessagePartReference_9' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                                <om:Element Type='MessagePartRef' OID='fcfb3b1a-393d-4b6e-b9ec-e6410ecf800e' ParentLink='Transform_OutputMessagePartRef' LowerBound='157.28' HigherBound='157.74'>
                                    <om:Property Name='MessageRef' Value='RestQueryApplicationInfoRequestMsg' />
                                    <om:Property Name='PartRef' Value='MessagePart' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='MessagePartReference_10' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                            </om:Element>
                            <om:Element Type='MessageAssignment' OID='89807a37-b59c-4af6-afad-6b4a4cbca7d3' ParentLink='ComplexStatement_Statement' LowerBound='158.1' HigherBound='169.1'>
                                <om:Property Name='Expression' Value='//SOQL Query For Rest&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;DOCUMENT_APPLICATION_INFO_SOQL_QUERY = @&quot;Select Id, Name, Loan_Type__c, DLAP_Status_Description__c, DLAP_Status__c, Disaster_Declaration__r.Name,Disaster_Declaration__r.Disaster_Description__c, Disaster_Declaration__r.Disaster_Deadline_Date__c,(Select Id, External_ID__c, Name, Applicant_Relation_Type__c, Trade_Name__c, Contact__r.LastName, Contact__r.FirstName from Applicants__r),(Select Id, Name, Case__c, Applicant__c, Application__c, Checklist_Item_Status__c, Checklist_Item_Text__c, Type__c, DocumentType__c, Verified_Date__c, CreatedDate, Checklist_Item_Due_Date__c, Applicant__r.External_ID__c, Master_Checklist__r.Name, Master_Checklist__r.Checklist_Description__c FROM Checklist_Items__r WHERE Id IN &quot;+&quot;(&quot;+ChecklistItemSFIDList+&quot;) and Id !=NULL) FROM Application__c WHERE Name IN &quot;+&quot;(&quot;+ApplicationNumberList+&quot;) AND Name != NULL&quot;;&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;RestQueryApplicationInfoRequestMsg(DLAPEventsSalesforceDefinition.RestCheckStatus.SF_APPLICATION_QUERY) = DOCUMENT_APPLICATION_INFO_SOQL_QUERY; &#xD;&#xA;&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;' />
                                <om:Property Name='ReportToAnalyst' Value='False' />
                                <om:Property Name='Name' Value='Injecting Application SOQL Query' />
                                <om:Property Name='Signal' Value='True' />
                            </om:Element>
                        </om:Element>
                        <om:Element Type='Send' OID='60a96da9-e7db-446d-abcd-da44b5f6d237' ParentLink='ComplexStatement_Statement' LowerBound='170.1' HigherBound='172.1'>
                            <om:Property Name='PortName' Value='RestApplicationInfoPort' />
                            <om:Property Name='MessageName' Value='RestQueryApplicationInfoRequestMsg' />
                            <om:Property Name='OperationName' Value='Operation' />
                            <om:Property Name='OperationMessageName' Value='Request' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Send Rest Request' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                        <om:Element Type='Receive' OID='4f58ced4-49f2-471d-89da-d0cfda0691c6' ParentLink='ComplexStatement_Statement' LowerBound='172.1' HigherBound='174.1'>
                            <om:Property Name='Activate' Value='False' />
                            <om:Property Name='PortName' Value='RestApplicationInfoPort' />
                            <om:Property Name='MessageName' Value='RestQueryApplicationInfoResponseMsg' />
                            <om:Property Name='OperationName' Value='Operation' />
                            <om:Property Name='OperationMessageName' Value='Response' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Receive Rest Response' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                        <om:Element Type='Construct' OID='c0a9c700-9ddb-4114-b579-85f2f1de01eb' ParentLink='ComplexStatement_Statement' LowerBound='174.1' HigherBound='180.1'>
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Construct Application Info Response Msg' />
                            <om:Property Name='Signal' Value='True' />
                            <om:Element Type='Transform' OID='2e50cea7-14ad-4934-ac26-45d8a4bc945c' ParentLink='ComplexStatement_Statement' LowerBound='177.1' HigherBound='179.1'>
                                <om:Property Name='ClassName' Value='DLAPEventsLogic.MakeApplicationInfoResponse' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Make Application Info Response ' />
                                <om:Property Name='Signal' Value='False' />
                                <om:Element Type='MessagePartRef' OID='2d679693-ec90-489f-8d1d-85912af85b42' ParentLink='Transform_InputMessagePartRef' LowerBound='178.130' HigherBound='178.177'>
                                    <om:Property Name='MessageRef' Value='RestQueryApplicationInfoResponseMsg' />
                                    <om:Property Name='PartRef' Value='MessagePart' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='MessagePartReference_1' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                                <om:Element Type='MessagePartRef' OID='adf057b9-000d-4cb7-895a-b198fa9775f9' ParentLink='Transform_OutputMessagePartRef' LowerBound='178.28' HigherBound='178.81'>
                                    <om:Property Name='MessageRef' Value='SalesforceQueryApplicationInfoResponseMsg' />
                                    <om:Property Name='PartRef' Value='MessagePart' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='MessagePartReference_2' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                            </om:Element>
                            <om:Element Type='MessageRef' OID='974d536c-f2d1-4bea-8740-16b573d230f1' ParentLink='Construct_MessageRef' LowerBound='175.23' HigherBound='175.64'>
                                <om:Property Name='Ref' Value='SalesforceQueryApplicationInfoResponseMsg' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                        </om:Element>
                        <om:Element Type='Construct' OID='95498e81-b9fc-4a66-9f94-5e20c9fec88a' ParentLink='ComplexStatement_Statement' LowerBound='180.1' HigherBound='186.1'>
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Construct Document CheckList Item Response Msg' />
                            <om:Property Name='Signal' Value='True' />
                            <om:Element Type='Transform' OID='08f9b13e-6456-48db-84aa-7b680f900ca9' ParentLink='ComplexStatement_Statement' LowerBound='183.1' HigherBound='185.1'>
                                <om:Property Name='ClassName' Value='DLAPEventsLogic.MakeSalesforceCheckListItemResponse' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='MakeSalesforceCheckListItemResponse' />
                                <om:Property Name='Signal' Value='True' />
                                <om:Element Type='MessagePartRef' OID='d36c0d53-c6d2-4fd6-b088-55b97c804c7a' ParentLink='Transform_InputMessagePartRef' LowerBound='184.144' HigherBound='184.191'>
                                    <om:Property Name='MessageRef' Value='RestQueryApplicationInfoResponseMsg' />
                                    <om:Property Name='PartRef' Value='MessagePart' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='MessagePartReference_13' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                                <om:Element Type='MessagePartRef' OID='fa1495a6-a243-4370-84de-bd7ccc63a652' ParentLink='Transform_OutputMessagePartRef' LowerBound='184.28' HigherBound='184.87'>
                                    <om:Property Name='MessageRef' Value='SalesforceQueryDocumentChecklistItemResponseMsg' />
                                    <om:Property Name='PartRef' Value='MessagePart' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='MessagePartReference_14' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                            </om:Element>
                            <om:Element Type='MessageRef' OID='afb96788-57cf-4a2e-ab34-dc8b738c68ea' ParentLink='Construct_MessageRef' LowerBound='181.23' HigherBound='181.70'>
                                <om:Property Name='Ref' Value='SalesforceQueryDocumentChecklistItemResponseMsg' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                        </om:Element>
                        <om:Element Type='VariableAssignment' OID='97efb380-5fee-4155-a44f-1d0a40e1b531' ParentLink='ComplexStatement_Statement' LowerBound='186.1' HigherBound='189.1'>
                            <om:Property Name='Expression' Value='//Counting Number of Applicants on Application&#xD;&#xA;ApplicantCount = System.Convert.ToInt32(xpath(SalesforceQueryApplicationInfoResponseMsg.MessagePart, &quot;count(/*[local-name()=&apos;Response&apos; and namespace-uri()=&apos;http://SBA.gov/DLAPEvents/Application_Info__c&apos;]/*[local-name()=&apos;row&apos; and namespace-uri()=&apos;http://SBA.gov/DLAPEvents/Application_Info__c&apos;]/*[local-name()=&apos;ApplicantId&apos; and namespace-uri()=&apos;http://SBA.gov/DLAPEvents/Application_Info__c&apos;])&quot;));&#xD;&#xA;' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Applicant Count' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='Task' OID='79fd6574-c5e6-445f-875f-7295bba562b7' ParentLink='ComplexStatement_Statement' LowerBound='189.1' HigherBound='247.1'>
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Application Document List Processing' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='Construct' OID='4d9fe9c1-21e5-416a-afc5-2551eec53f4e' ParentLink='ComplexStatement_Statement' LowerBound='189.1' HigherBound='201.1'>
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Construct Rest Document Request Msg' />
                            <om:Property Name='Signal' Value='True' />
                            <om:Element Type='Transform' OID='ab30e0c6-bcc8-4113-9f73-0576bf7441a8' ParentLink='ComplexStatement_Statement' LowerBound='192.1' HigherBound='194.1'>
                                <om:Property Name='ClassName' Value='DLAPEventsLogic.MakeRestDocumentRequest' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Make Rest Document Request' />
                                <om:Property Name='Signal' Value='True' />
                                <om:Element Type='MessagePartRef' OID='080f4863-f488-496a-8a65-8b381682303f' ParentLink='Transform_InputMessagePartRef' LowerBound='193.114' HigherBound='193.160'>
                                    <om:Property Name='MessageRef' Value='SalesforceNotificationEventRequest' />
                                    <om:Property Name='PartRef' Value='MessagePart' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='MessagePartReference_7' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                                <om:Element Type='MessagePartRef' OID='b4d15d87-2581-4050-b902-904fa209bf68' ParentLink='Transform_OutputMessagePartRef' LowerBound='193.28' HigherBound='193.69'>
                                    <om:Property Name='MessageRef' Value='RestDocumentDetailsRequestMsg' />
                                    <om:Property Name='PartRef' Value='MessagePart' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='MessagePartReference_8' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                            </om:Element>
                            <om:Element Type='MessageAssignment' OID='4db0dde8-5a5a-4c30-a638-3b115007e1f4' ParentLink='ComplexStatement_Statement' LowerBound='194.1' HigherBound='200.1'>
                                <om:Property Name='Expression' Value='&#xD;&#xA;//Injecting SOQL Query&#xD;&#xA;CheckListItem_DOCUMENT_SOQL_QUERY = @&quot;SELECT ContentDocument.LatestPublishedVersion.DLAP_Document_Type__c,ContentDocument.LatestPublishedVersion.Title,ContentDocument.LatestPublishedVersion.Id,ContentDocument.LatestPublishedVersion.Description,ContentDocument.LatestPublishedVersion.Document_Validity__c,ContentDocument.LatestPublishedVersion.CreatedDate,ContentDocument.LatestPublishedVersion.Document_Type__c FROM ContentDocumentLink WHERE LinkedEntityId IN &quot;+&quot;(&apos;&quot;+ChecklistItemSFID+&quot;&apos;) AND LinkedEntityId != null&quot;; &#xD;&#xA;RestDocumentDetailsRequestMsg(DLAPEventsSalesforceDefinition.RestDocument.DOCUMENT_SOQL_Query) = CheckListItem_DOCUMENT_SOQL_QUERY; &#xD;&#xA;&#xD;&#xA;' />
                                <om:Property Name='ReportToAnalyst' Value='False' />
                                <om:Property Name='Name' Value='Injecting Applicant Document SOQL Query' />
                                <om:Property Name='Signal' Value='True' />
                            </om:Element>
                            <om:Element Type='MessageRef' OID='30ec3273-ff9c-436d-8005-7137afce5d36' ParentLink='Construct_MessageRef' LowerBound='190.23' HigherBound='190.52'>
                                <om:Property Name='Ref' Value='RestDocumentDetailsRequestMsg' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                        </om:Element>
                        <om:Element Type='Send' OID='5e89cfd3-7fe6-4a67-9cfa-e0871299f174' ParentLink='ComplexStatement_Statement' LowerBound='201.1' HigherBound='203.1'>
                            <om:Property Name='PortName' Value='RestDocumentChecklistItemQueryPort' />
                            <om:Property Name='MessageName' Value='RestDocumentDetailsRequestMsg' />
                            <om:Property Name='OperationName' Value='Operation' />
                            <om:Property Name='OperationMessageName' Value='Request' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Send Rest Document Request' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                        <om:Element Type='Receive' OID='14e485b4-b001-48ee-883f-6923c74f1997' ParentLink='ComplexStatement_Statement' LowerBound='203.1' HigherBound='205.1'>
                            <om:Property Name='Activate' Value='False' />
                            <om:Property Name='PortName' Value='RestDocumentChecklistItemQueryPort' />
                            <om:Property Name='MessageName' Value='RestDocumentDetailsResponseMsg' />
                            <om:Property Name='OperationName' Value='Operation' />
                            <om:Property Name='OperationMessageName' Value='Response' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Receive Rest Document Response' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                        <om:Element Type='Construct' OID='1ebb7433-719c-4a87-9a6a-b4a9df250381' ParentLink='ComplexStatement_Statement' LowerBound='205.1' HigherBound='211.1'>
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Construct Checklist Item Document Response' />
                            <om:Property Name='Signal' Value='True' />
                            <om:Element Type='Transform' OID='cff756f6-2040-4b6c-874b-5d7a55800a34' ParentLink='ComplexStatement_Statement' LowerBound='208.1' HigherBound='210.1'>
                                <om:Property Name='ClassName' Value='DLAPEventsLogic.MakeSalesforceChecklistItemDocumentResponse' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Make Salesforce Checklist Item Document Response' />
                                <om:Property Name='Signal' Value='True' />
                                <om:Element Type='MessagePartRef' OID='77031742-b4f3-49b5-a161-3b519b09a5f6' ParentLink='Transform_InputMessagePartRef' LowerBound='209.145' HigherBound='209.187'>
                                    <om:Property Name='MessageRef' Value='RestDocumentDetailsResponseMsg' />
                                    <om:Property Name='PartRef' Value='MessagePart' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='MessagePartReference_11' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                                <om:Element Type='MessagePartRef' OID='4cf97a20-4986-4925-98b4-25eb8eec9666' ParentLink='Transform_OutputMessagePartRef' LowerBound='209.28' HigherBound='209.80'>
                                    <om:Property Name='MessageRef' Value='SalesforceQueryContentVersionResponseMsg' />
                                    <om:Property Name='PartRef' Value='MessagePart' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='MessagePartReference_12' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                            </om:Element>
                            <om:Element Type='MessageRef' OID='12bde222-0009-4a05-982c-1453705ad42c' ParentLink='Construct_MessageRef' LowerBound='206.23' HigherBound='206.63'>
                                <om:Property Name='Ref' Value='SalesforceQueryContentVersionResponseMsg' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                        </om:Element>
                        <om:Element Type='Construct' OID='ea1d3ad9-d64c-4ea2-a36e-ace0fac0a94e' ParentLink='ComplexStatement_Statement' LowerBound='211.1' HigherBound='247.1'>
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Construct Checklist Item Document Message' />
                            <om:Property Name='Signal' Value='True' />
                            <om:Element Type='MessageAssignment' OID='1344b71d-0416-467f-b8c2-7dfc91b6d07e' ParentLink='ComplexStatement_Statement' LowerBound='214.1' HigherBound='246.1'>
                                <om:Property Name='Expression' Value='&#xD;&#xA;&#xD;&#xA;ChecklistItemDocApplicantSFIDxpath = &quot;string(/*[local-name()=&apos;Response&apos; and namespace-uri()=&apos;http://SBA.gov/DLAPEventsDocument/Checklist_Item__c&apos;]/*[local-name()=&apos;row&apos; and namespace-uri()=&apos;http://SBA.gov/DLAPEventsDocument/Checklist_Item__c&apos;]/*[local-name()=&apos;ApplicantExternalId&apos; and namespace-uri()=&apos;http://SBA.gov/DLAPEventsDocument/Checklist_Item__c&apos;])&quot;;&#xD;&#xA;ChecklistItemDocApplicantSFID = xpath(SalesforceQueryDocumentChecklistItemResponseMsg.MessagePart,ChecklistItemDocApplicantSFIDxpath);&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;ChecklistItemStatusxPath = &quot;string(/*[local-name()=&apos;Response&apos; and namespace-uri()=&apos;http://SBA.gov/DLAPEventsDocument/Checklist_Item__c&apos;]/*[local-name()=&apos;row&apos; and namespace-uri()=&apos;http://SBA.gov/DLAPEventsDocument/Checklist_Item__c&apos;]/*[local-name()=&apos;Checklist_Item_Status__c&apos; and namespace-uri()=&apos;http://SBA.gov/DLAPEventsDocument/Checklist_Item__c&apos;])&quot;;&#xD;&#xA;ChecklistItemStatus = xpath(SalesforceQueryDocumentChecklistItemResponseMsg.MessagePart,ChecklistItemStatusxPath);&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;DocumentMasterCheckListNamexPath = &quot;string(/*[local-name()=&apos;Response&apos; and namespace-uri()=&apos;http://SBA.gov/DLAPEventsDocument/Checklist_Item__c&apos;]/*[local-name()=&apos;row&apos; and namespace-uri()=&apos;http://SBA.gov/DLAPEventsDocument/Checklist_Item__c&apos;]/*[local-name()=&apos;MasterCheckListName&apos; and namespace-uri()=&apos;http://SBA.gov/DLAPEventsDocument/Checklist_Item__c&apos;])&quot;;&#xD;&#xA;DocumentMasterCheckListName = xpath(SalesforceQueryDocumentChecklistItemResponseMsg.MessagePart,DocumentMasterCheckListNamexPath);&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;DocumentMasterCheckListDescxPath = &quot;string(/*[local-name()=&apos;Response&apos; and namespace-uri()=&apos;http://SBA.gov/DLAPEventsDocument/Checklist_Item__c&apos;]/*[loca"+
@"l-name()=&apos;row&apos; and namespace-uri()=&apos;http://SBA.gov/DLAPEventsDocument/Checklist_Item__c&apos;]/*[local-name()=&apos;MasterCheckListDescription&apos; and namespace-uri()=&apos;http://SBA.gov/DLAPEventsDocument/Checklist_Item__c&apos;])&quot;;&#xD;&#xA;DocumentMasterCheckListDesc = xpath(SalesforceQueryDocumentChecklistItemResponseMsg.MessagePart,DocumentMasterCheckListDescxPath);&#xD;&#xA;&#xD;&#xA;ChecklistItemTypexPath = &quot;string(/*[local-name()=&apos;Response&apos; and namespace-uri()=&apos;http://SBA.gov/DLAPEventsDocument/Checklist_Item__c&apos;]/*[local-name()=&apos;row&apos; and namespace-uri()=&apos;http://SBA.gov/DLAPEventsDocument/Checklist_Item__c&apos;]/*[local-name()=&apos;Type__c&apos; and namespace-uri()=&apos;http://SBA.gov/DLAPEventsDocument/Checklist_Item__c&apos;])&quot;;&#xD;&#xA;ChecklistItemType = xpath(SalesforceQueryDocumentChecklistItemResponseMsg.MessagePart,ChecklistItemTypexPath);&#xD;&#xA;&#xD;&#xA;//Create CheckListItem DOCUMENT Message&#xD;&#xA;&#xD;&#xA;ChecklistItemTempDoc = SalesforceQueryContentVersionResponseMsg.MessagePart;&#xD;&#xA;ChecklistStrTempEmpty =  @&quot;&lt;ChecklistItemDocumentList xmlns=&apos;http://SBA.gov/DLAPEvents/ChecklistItemDocumentList&apos;&gt;&lt;Responses&gt;&quot;+ChecklistItemTempDoc.InnerXml+&quot;&lt;ClosingDocumentApplicantId&gt;&quot;+ChecklistItemDocApplicantSFID+&quot;&lt;/ClosingDocumentApplicantId&gt;&lt;DocumentChecklist_Item_Status__c&gt;&quot;+ChecklistItemStatus+&quot;&lt;/DocumentChecklist_Item_Status__c&gt;&lt;DocumentMasterCheckListName&gt;&quot;+DocumentMasterCheckListName+&quot;&lt;/DocumentMasterCheckListName&gt;&lt;DocumentMasterChecklist_Description__c&gt;&quot;+DocumentMasterCheckListDesc+&quot;&lt;/DocumentMasterChecklist_Description__c&gt;&lt;Type&gt;&quot;+ChecklistItemType+&quot;&lt;/Type&gt;&lt;/Responses&gt;&lt;/ChecklistItemDocumentList&gt;&quot;;&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;//Load message&#xD;&#xA;&#xD;&#xA;TempChecklistItemDocList.LoadXml(ChecklistStrTempEmpty);&#xD;&#xA;SalesforceC"+
@"heckListDocumentListDetailsResponseMsg.MessagePart = TempChecklistItemDocList;&#xD;&#xA;' />
                                <om:Property Name='ReportToAnalyst' Value='False' />
                                <om:Property Name='Name' Value='Make Checklist Item Document Response' />
                                <om:Property Name='Signal' Value='True' />
                            </om:Element>
                            <om:Element Type='MessageRef' OID='0521582a-d718-4778-9172-1477888381c1' ParentLink='Construct_MessageRef' LowerBound='212.23' HigherBound='212.72'>
                                <om:Property Name='Ref' Value='SalesforceCheckListDocumentListDetailsResponseMsg' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                        </om:Element>
                    </om:Element>
                    <om:Element Type='Construct' OID='161ded47-84ac-4f07-a96d-113b9fa50f30' ParentLink='ComplexStatement_Statement' LowerBound='247.1' HigherBound='253.1'>
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Construct Document List Response Msg' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='MessageRef' OID='76515481-42c5-42bb-b758-94209a24e196' ParentLink='Construct_MessageRef' LowerBound='248.23' HigherBound='248.39'>
                            <om:Property Name='Ref' Value='DocumentResponse' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                        <om:Element Type='Transform' OID='eb8522ce-1fdf-4050-b286-bd797746e67a' ParentLink='ComplexStatement_Statement' LowerBound='250.1' HigherBound='252.1'>
                            <om:Property Name='ClassName' Value='DLAPEventsLogic.MakeDocumentListResponse' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Make DocumentList Response' />
                            <om:Property Name='Signal' Value='False' />
                            <om:Element Type='MessagePartRef' OID='666a0333-86b3-4f18-aa50-c77605a6a9f6' ParentLink='Transform_OutputMessagePartRef' LowerBound='251.28' HigherBound='251.56'>
                                <om:Property Name='MessageRef' Value='DocumentResponse' />
                                <om:Property Name='PartRef' Value='MessagePart' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='MessagePartReference_6' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='MessagePartRef' OID='dcec46e6-3239-488f-b693-d08d34a33dc4' ParentLink='Transform_InputMessagePartRef' LowerBound='251.102' HigherBound='251.163'>
                                <om:Property Name='MessageRef' Value='SalesforceCheckListDocumentListDetailsResponseMsg' />
                                <om:Property Name='PartRef' Value='MessagePart' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='MessagePartReference_3' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='MessagePartRef' OID='1ae496f7-3855-42ad-93a8-23121fe16caa' ParentLink='Transform_InputMessagePartRef' LowerBound='251.165' HigherBound='251.218'>
                                <om:Property Name='MessageRef' Value='SalesforceQueryApplicationInfoResponseMsg' />
                                <om:Property Name='PartRef' Value='MessagePart' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='MessagePartReference_4' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='MessagePartRef' OID='759aa04d-c8da-4917-8399-141601af07c4' ParentLink='Transform_InputMessagePartRef' LowerBound='251.220' HigherBound='251.279'>
                                <om:Property Name='MessageRef' Value='SalesforceQueryDocumentChecklistItemResponseMsg' />
                                <om:Property Name='PartRef' Value='MessagePart' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='MessagePartReference_5' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                        </om:Element>
                    </om:Element>
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='f98206f6-cafb-4339-a990-1092587e674d' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='60.1' HigherBound='62.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='13' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='DLAPEvents.SalesforceQueryDocumentApplicationInfoPortType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='RestApplicationInfoPort' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='LogicalBindingAttribute' OID='5b087735-8f04-462d-9829-d4ef16880428' ParentLink='PortDeclaration_CLRAttribute' LowerBound='60.1' HigherBound='61.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='bf0f98a0-969c-4078-becb-31303c43b0d3' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='62.1' HigherBound='64.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='76' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='DLAPEvents.RestDocumentChecklistItemQueryPortType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='RestDocumentChecklistItemQueryPort' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='33842395-6d67-4824-9218-650edccfd732' ParentLink='PortDeclaration_CLRAttribute' LowerBound='62.1' HigherBound='63.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='MultipartMessageType' OID='3a767fe9-3c4f-4521-9b74-910e96dba13c' ParentLink='Module_MessageType' LowerBound='4.1' HigherBound='8.1'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='MultipleDocumentListDetailsResponseType' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='PartDeclaration' OID='9affcb75-d33c-49d3-9c83-a16bf801e97f' ParentLink='MultipartMessageType_PartDeclaration' LowerBound='6.1' HigherBound='7.1'>
                <om:Property Name='ClassName' Value='DLAPEventsSalesforceDefinition.DocumentDetails' />
                <om:Property Name='IsBodyPart' Value='True' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='MessagePart' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
        </om:Element>
        <om:Element Type='MultipartMessageType' OID='51a3e069-b137-4d44-a6cc-cbe7cc8e473d' ParentLink='Module_MessageType' LowerBound='8.1' HigherBound='12.1'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='SalesforceQueryContentVersionResponseType' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='PartDeclaration' OID='ef31ab31-2d12-4299-8c31-213faf06ee6a' ParentLink='MultipartMessageType_PartDeclaration' LowerBound='10.1' HigherBound='11.1'>
                <om:Property Name='ClassName' Value='DLAPEventsSalesforceDefinition.SalesforceQuery_ContentVersion__c.Response' />
                <om:Property Name='IsBodyPart' Value='True' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='MessagePart' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
        </om:Element>
        <om:Element Type='MultipartMessageType' OID='23dc2809-5cf4-458e-a7fc-02d39cc5d8ec' ParentLink='Module_MessageType' LowerBound='12.1' HigherBound='16.1'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='SalesforceQueryContentVersionRequestType' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='PartDeclaration' OID='9496ae05-4172-4751-9db2-3ab100a81686' ParentLink='MultipartMessageType_PartDeclaration' LowerBound='14.1' HigherBound='15.1'>
                <om:Property Name='ClassName' Value='DLAPEventsSalesforceDefinition.SalesforceQuery_ContentVersion__c.Request' />
                <om:Property Name='IsBodyPart' Value='True' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='MessagePart' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
        </om:Element>
        <om:Element Type='MultipartMessageType' OID='22627067-1c2b-4294-95a7-0b9e8b268f3d' ParentLink='Module_MessageType' LowerBound='16.1' HigherBound='20.1'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='SalesforceQueryDocumentChecklistItemRequestType' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='PartDeclaration' OID='54e46f9b-2d5b-4f06-bafc-12c1b3f568e0' ParentLink='MultipartMessageType_PartDeclaration' LowerBound='18.1' HigherBound='19.1'>
                <om:Property Name='ClassName' Value='DLAPEventsSalesforceDefinition.SalesforceQuery_Document_Checklist_Item__c.Request' />
                <om:Property Name='IsBodyPart' Value='True' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='MessagePart' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
        </om:Element>
        <om:Element Type='MultipartMessageType' OID='1ec1b548-f522-4355-b12f-1596fa466025' ParentLink='Module_MessageType' LowerBound='20.1' HigherBound='24.1'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='SalesforceQueryDocumentChecklistItemResponseType' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='PartDeclaration' OID='313bf52b-a7e1-4388-aaac-2f968ce95be5' ParentLink='MultipartMessageType_PartDeclaration' LowerBound='22.1' HigherBound='23.1'>
                <om:Property Name='ClassName' Value='DLAPEventsSalesforceDefinition.SalesforceQuery_Document_Checklist_Item__c.Response' />
                <om:Property Name='IsBodyPart' Value='True' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='MessagePart' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
        </om:Element>
        <om:Element Type='MultipartMessageType' OID='de26397f-a8e2-4b46-8724-347fa4a9e268' ParentLink='Module_MessageType' LowerBound='24.1' HigherBound='28.1'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='SalesforceCheckListDocumentListDetailsResponseType' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='PartDeclaration' OID='455ef014-f891-472f-b7df-95cd73213a0f' ParentLink='MultipartMessageType_PartDeclaration' LowerBound='26.1' HigherBound='27.1'>
                <om:Property Name='ClassName' Value='DLAPEventsSalesforceDefinition.ChecklistItemDocumentDetails' />
                <om:Property Name='IsBodyPart' Value='True' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='MessagePart' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
        </om:Element>
        <om:Element Type='MultipartMessageType' OID='2e2d7506-961e-44dc-bf2c-b2d052240666' ParentLink='Module_MessageType' LowerBound='28.1' HigherBound='32.1'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='RestDocumentDetailsRequestType' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='PartDeclaration' OID='9421beb0-c3bb-49c6-b118-7073cc338b7a' ParentLink='MultipartMessageType_PartDeclaration' LowerBound='30.1' HigherBound='31.1'>
                <om:Property Name='ClassName' Value='DLAPEventsSalesforceDefinition.RestDocument.RequestResponse.Request' />
                <om:Property Name='IsBodyPart' Value='True' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='MessagePart' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
        </om:Element>
        <om:Element Type='MultipartMessageType' OID='56b95047-64df-4ddd-80f4-aeb73ff711b2' ParentLink='Module_MessageType' LowerBound='32.1' HigherBound='36.1'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='RestDocumentDetailsResponseType' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='PartDeclaration' OID='38a7e9fc-6049-45c7-913b-8e6f5a567959' ParentLink='MultipartMessageType_PartDeclaration' LowerBound='34.1' HigherBound='35.1'>
                <om:Property Name='ClassName' Value='DLAPEventsSalesforceDefinition.RestDocument.RequestResponse.QueryResult' />
                <om:Property Name='IsBodyPart' Value='True' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='MessagePart' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='be6c8557-913d-4046-a9b3-1bdb856b28d8' ParentLink='Module_PortType' LowerBound='36.1' HigherBound='43.1'>
            <om:Property Name='Synchronous' Value='True' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='SalesforceQueryContentVersionPortType' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='OperationDeclaration' OID='032f359b-dd05-44a2-af04-0383feadfabd' ParentLink='PortType_OperationDeclaration' LowerBound='38.1' HigherBound='42.1'>
                <om:Property Name='OperationType' Value='RequestResponse' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='4e91d838-50b5-466f-aafe-42cdb72b55d9' ParentLink='OperationDeclaration_ResponseMessageRef' LowerBound='40.55' HigherBound='40.96'>
                    <om:Property Name='Ref' Value='DLAPEvents.SalesforceQueryContentVersionResponseType' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Response' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='MessageRef' OID='24f2cf72-cb77-41af-9d0d-165d1c31f927' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='40.13' HigherBound='40.53'>
                    <om:Property Name='Ref' Value='DLAPEvents.SalesforceQueryContentVersionRequestType' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='7d853920-cc26-4d65-8077-e95bd98a3ceb' ParentLink='Module_PortType' LowerBound='43.1' HigherBound='50.1'>
            <om:Property Name='Synchronous' Value='True' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='SalesforceQueryDocumentApplicationInfoPortType' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='OperationDeclaration' OID='d3b02cfe-ed7e-4567-b5ec-c5c5433654d7' ParentLink='PortType_OperationDeclaration' LowerBound='45.1' HigherBound='49.1'>
                <om:Property Name='OperationType' Value='RequestResponse' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='b8ced0d0-9ac9-4b58-aea3-bde3ac442568' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='47.13' HigherBound='47.48'>
                    <om:Property Name='Ref' Value='DLAPEvents.RestQueryApplicationInfoRequestType' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='MessageRef' OID='d4157d04-bee3-4a83-a139-302ea0ce8c41' ParentLink='OperationDeclaration_ResponseMessageRef' LowerBound='47.50' HigherBound='47.86'>
                    <om:Property Name='Ref' Value='DLAPEvents.RestQueryApplicationInfoResponseType' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Response' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='8363d452-5beb-4ff9-bf66-93c74f33ab74' ParentLink='Module_PortType' LowerBound='50.1' HigherBound='57.1'>
            <om:Property Name='Synchronous' Value='True' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='RestDocumentChecklistItemQueryPortType' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='OperationDeclaration' OID='17fb87ac-bc9e-4ecd-8daf-bd8186571f3c' ParentLink='PortType_OperationDeclaration' LowerBound='52.1' HigherBound='56.1'>
                <om:Property Name='OperationType' Value='RequestResponse' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='360e838f-2848-4502-bd70-8a33b64941fb' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='54.13' HigherBound='54.43'>
                    <om:Property Name='Ref' Value='DLAPEvents.RestDocumentDetailsRequestType' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='MessageRef' OID='4106ab0a-616a-4857-945b-857ccd10ccd5' ParentLink='OperationDeclaration_ResponseMessageRef' LowerBound='54.45' HigherBound='54.76'>
                    <om:Property Name='Ref' Value='DLAPEvents.RestDocumentDetailsResponseType' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Response' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
        </om:Element>
    </om:Element>
</om:MetaModel>
";

        [System.SerializableAttribute]
        public class __DocumentLogic_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __DocumentLogic_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "DocumentLogic")
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
                DocumentLogic __svc__ = (DocumentLogic)_service;
                __DocumentLogic_root_0 __ctx0__ = (__DocumentLogic_root_0)(__svc__._stateMgrs[0]);

                if (__svc__.RestDocumentChecklistItemQueryPort != null)
                {
                    __svc__.RestDocumentChecklistItemQueryPort.Close(this, null);
                    __svc__.RestDocumentChecklistItemQueryPort = null;
                }
                if (__svc__.RestApplicationInfoPort != null)
                {
                    __svc__.RestApplicationInfoPort.Close(this, null);
                    __svc__.RestApplicationInfoPort = null;
                }
                base.Finally();
            }

            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper0;
            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper1;
        }


        [System.SerializableAttribute]
        public class __DocumentLogic_1 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public __DocumentLogic_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "DocumentLogic")
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
                DocumentLogic __svc__ = (DocumentLogic)_service;
                __DocumentLogic_1 __ctx1__ = (__DocumentLogic_1)(__svc__._stateMgrs[1]);
                __DocumentLogic_root_0 __ctx0__ = (__DocumentLogic_root_0)(__svc__._stateMgrs[0]);

                if (__ctx1__ != null)
                    __ctx1__.__ApplicantName = null;
                if (__ctx1__ != null && __ctx1__.__RestQueryApplicationInfoResponseMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__RestQueryApplicationInfoResponseMsg);
                    __ctx1__.__RestQueryApplicationInfoResponseMsg = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__DLAPUserID = null;
                if (__ctx1__ != null)
                    __ctx1__.__SFObjectID = null;
                if (__ctx1__ != null)
                    __ctx1__.__StrTempEmpty = null;
                if (__ctx1__ != null && __ctx1__.__SalesforceQueryDocumentChecklistItemResponseMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__SalesforceQueryDocumentChecklistItemResponseMsg);
                    __ctx1__.__SalesforceQueryDocumentChecklistItemResponseMsg = null;
                }
                if (__ctx1__ != null && __ctx1__.__SalesforceCheckListDocumentListDetailsResponseMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__SalesforceCheckListDocumentListDetailsResponseMsg);
                    __ctx1__.__SalesforceCheckListDocumentListDetailsResponseMsg = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__ApplicationSFID = null;
                if (__ctx1__ != null)
                    __ctx1__.__TempDoc = null;
                if (__ctx1__ != null && __ctx1__.__RestQueryApplicationInfoRequestMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__RestQueryApplicationInfoRequestMsg);
                    __ctx1__.__RestQueryApplicationInfoRequestMsg = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__ChecklistItemDocApplicantSFID = null;
                if (__ctx1__ != null)
                    __ctx1__.__ApplicantSFID = null;
                if (__ctx1__ != null)
                    __ctx1__.__ChecklistItemStatusxPath = null;
                if (__ctx1__ != null)
                    __ctx1__.__ChecklistItemStatus = null;
                if (__ctx1__ != null)
                    __ctx1__.__ChecklistItemDocApplicantSFIDxpath = null;
                if (__ctx1__ != null)
                    __ctx1__.__ApplicationStrTempEmpty = null;
                if (__ctx1__ != null && __ctx1__.__RestDocumentDetailsRequestMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__RestDocumentDetailsRequestMsg);
                    __ctx1__.__RestDocumentDetailsRequestMsg = null;
                }
                if (__ctx1__ != null && __ctx1__.__RestDocumentDetailsResponseMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__RestDocumentDetailsResponseMsg);
                    __ctx1__.__RestDocumentDetailsResponseMsg = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__TempApplicationDocList = null;
                if (__ctx1__ != null)
                    __ctx1__.__ApplicantSFIDXpath = null;
                if (__ctx1__ != null && __ctx1__.__SalesforceQueryApplicationInfoResponseMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__SalesforceQueryApplicationInfoResponseMsg);
                    __ctx1__.__SalesforceQueryApplicationInfoResponseMsg = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__ApplicantNameXpath = null;
                if (__ctx1__ != null && __ctx1__.__SalesforceQueryContentVersionResponseMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__SalesforceQueryContentVersionResponseMsg);
                    __ctx1__.__SalesforceQueryContentVersionResponseMsg = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__ChecklistItemTempDoc = null;
                if (__ctx1__ != null)
                    __ctx1__.__DocumentMasterCheckListName = null;
                if (__ctx1__ != null)
                    __ctx1__.__ChecklistStrTempEmpty = null;
                if (__ctx1__ != null)
                    __ctx1__.__ChecklistItemTypexPath = null;
                if (__ctx1__ != null)
                    __ctx1__.__ApplicationNumber = null;
                if (__ctx1__ != null)
                    __ctx1__.__DocumentMasterCheckListDesc = null;
                if (__ctx1__ != null)
                    __ctx1__.__ApplicationNumberList = null;
                if (__ctx1__ != null)
                    __ctx1__.__CheckListItem_DOCUMENT_SOQL_QUERY = null;
                if (__ctx1__ != null)
                    __ctx1__.__TempChecklistItemDocList = null;
                if (__ctx1__ != null)
                    __ctx1__.__DocumentMasterCheckListNamexPath = null;
                if (__ctx1__ != null)
                    __ctx1__.__ChecklistItemType = null;
                if (__ctx1__ != null)
                    __ctx1__.__ChecklistItemSFID = null;
                if (__ctx1__ != null)
                    __ctx1__.__APPLICATION_INFO_SOQL_QUERY = null;
                if (__ctx1__ != null)
                    __ctx1__.__ChecklistItemSFIDList = null;
                if (__ctx1__ != null)
                    __ctx1__.__DocumentMasterCheckListDescxPath = null;
                if (__ctx1__ != null && __ctx1__.__SalesforceNotificationEventRequest != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__SalesforceNotificationEventRequest);
                    __ctx1__.__SalesforceNotificationEventRequest = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__DOCUMENT_APPLICATION_INFO_SOQL_QUERY = null;
                if (__ctx0__ != null && __ctx0__.__subWrapper0 != null)
                {
                    __ctx0__.__subWrapper0.Destroy(__svc__, __ctx0__);
                    __ctx0__.__subWrapper0 = null;
                }
                if (__ctx0__ != null && __ctx0__.__subWrapper1 != null)
                {
                    __ctx0__.__subWrapper1.Destroy(__svc__, __ctx0__);
                    __ctx0__.__subWrapper1 = null;
                }
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("RestQueryApplicationInfoResponseMsg")]
            internal RestQueryApplicationInfoResponseType __RestQueryApplicationInfoResponseMsg;
            [Microsoft.XLANGs.Core.UserVariableAttribute("RestQueryApplicationInfoRequestMsg")]
            internal RestQueryApplicationInfoRequestType __RestQueryApplicationInfoRequestMsg;
            [Microsoft.XLANGs.Core.UserVariableAttribute("SalesforceQueryApplicationInfoResponseMsg")]
            internal SalesforceQueryStatusApplicationInfoResponseType __SalesforceQueryApplicationInfoResponseMsg;
            [Microsoft.XLANGs.Core.UserVariableAttribute("SalesforceQueryDocumentChecklistItemResponseMsg")]
            internal SalesforceQueryDocumentChecklistItemResponseType __SalesforceQueryDocumentChecklistItemResponseMsg;
            [Microsoft.XLANGs.Core.UserVariableAttribute("SalesforceQueryContentVersionResponseMsg")]
            internal SalesforceQueryContentVersionResponseType __SalesforceQueryContentVersionResponseMsg;
            [Microsoft.XLANGs.Core.UserVariableAttribute("SalesforceCheckListDocumentListDetailsResponseMsg")]
            internal SalesforceCheckListDocumentListDetailsResponseType __SalesforceCheckListDocumentListDetailsResponseMsg;
            [Microsoft.XLANGs.Core.UserVariableAttribute("RestDocumentDetailsRequestMsg")]
            internal RestDocumentDetailsRequestType __RestDocumentDetailsRequestMsg;
            [Microsoft.XLANGs.Core.UserVariableAttribute("RestDocumentDetailsResponseMsg")]
            internal RestDocumentDetailsResponseType __RestDocumentDetailsResponseMsg;
            [Microsoft.XLANGs.Core.UserVariableAttribute("SalesforceNotificationEventRequest")]
            internal SingleNotificationEventType __SalesforceNotificationEventRequest;
            [Microsoft.XLANGs.Core.UserVariableAttribute("DocumentResponse")]
            internal DocumentResponseType __DocumentResponse;
            [Microsoft.XLANGs.Core.UserVariableAttribute("ApplicationSFID")]
            internal System.String __ApplicationSFID;
            [Microsoft.XLANGs.Core.UserVariableAttribute("TempApplicationDocList")]
            internal Microsoft.XLANGs.RuntimeTypes.XmlDocumentSerializationProxy __TempApplicationDocList;
            [Microsoft.XLANGs.Core.UserVariableAttribute("ApplicationStrTempEmpty")]
            internal System.String __ApplicationStrTempEmpty;
            [Microsoft.XLANGs.Core.UserVariableAttribute("StrTempEmpty")]
            internal System.String __StrTempEmpty;
            [Microsoft.XLANGs.Core.UserVariableAttribute("TempDoc")]
            internal Microsoft.XLANGs.RuntimeTypes.XmlDocumentSerializationProxy __TempDoc;
            [Microsoft.XLANGs.Core.UserVariableAttribute("LoopCount")]
            internal System.Int32 __LoopCount;
            [Microsoft.XLANGs.Core.UserVariableAttribute("ApplicantCount")]
            internal System.Int32 __ApplicantCount;
            [Microsoft.XLANGs.Core.UserVariableAttribute("ApplicantSFIDXpath")]
            internal System.String __ApplicantSFIDXpath;
            [Microsoft.XLANGs.Core.UserVariableAttribute("ApplicantSFID")]
            internal System.String __ApplicantSFID;
            [Microsoft.XLANGs.Core.UserVariableAttribute("ApplicantNameXpath")]
            internal System.String __ApplicantNameXpath;
            [Microsoft.XLANGs.Core.UserVariableAttribute("ApplicantName")]
            internal System.String __ApplicantName;
            [Microsoft.XLANGs.Core.UserVariableAttribute("DLAPUserID")]
            internal System.String __DLAPUserID;
            [Microsoft.XLANGs.Core.UserVariableAttribute("SFObjectID")]
            internal System.String __SFObjectID;
            [Microsoft.XLANGs.Core.UserVariableAttribute("ChecklistItemDocApplicantSFIDxpath")]
            internal System.String __ChecklistItemDocApplicantSFIDxpath;
            [Microsoft.XLANGs.Core.UserVariableAttribute("ChecklistItemDocApplicantSFID")]
            internal System.String __ChecklistItemDocApplicantSFID;
            [Microsoft.XLANGs.Core.UserVariableAttribute("ChecklistItemStatusxPath")]
            internal System.String __ChecklistItemStatusxPath;
            [Microsoft.XLANGs.Core.UserVariableAttribute("ChecklistItemStatus")]
            internal System.String __ChecklistItemStatus;
            [Microsoft.XLANGs.Core.UserVariableAttribute("DocumentMasterCheckListNamexPath")]
            internal System.String __DocumentMasterCheckListNamexPath;
            [Microsoft.XLANGs.Core.UserVariableAttribute("DocumentMasterCheckListName")]
            internal System.String __DocumentMasterCheckListName;
            [Microsoft.XLANGs.Core.UserVariableAttribute("DocumentMasterCheckListDescxPath")]
            internal System.String __DocumentMasterCheckListDescxPath;
            [Microsoft.XLANGs.Core.UserVariableAttribute("DocumentMasterCheckListDesc")]
            internal System.String __DocumentMasterCheckListDesc;
            [Microsoft.XLANGs.Core.UserVariableAttribute("ChecklistItemTempDoc")]
            internal Microsoft.XLANGs.RuntimeTypes.XmlDocumentSerializationProxy __ChecklistItemTempDoc;
            [Microsoft.XLANGs.Core.UserVariableAttribute("ChecklistStrTempEmpty")]
            internal System.String __ChecklistStrTempEmpty;
            [Microsoft.XLANGs.Core.UserVariableAttribute("TempChecklistItemDocList")]
            internal Microsoft.XLANGs.RuntimeTypes.XmlDocumentSerializationProxy __TempChecklistItemDocList;
            [Microsoft.XLANGs.Core.UserVariableAttribute("ChecklistItemTypexPath")]
            internal System.String __ChecklistItemTypexPath;
            [Microsoft.XLANGs.Core.UserVariableAttribute("ChecklistItemType")]
            internal System.String __ChecklistItemType;
            [Microsoft.XLANGs.Core.UserVariableAttribute("APPLICATION_INFO_SOQL_QUERY")]
            internal System.String __APPLICATION_INFO_SOQL_QUERY;
            [Microsoft.XLANGs.Core.UserVariableAttribute("ApplicationNumber")]
            internal System.String __ApplicationNumber;
            [Microsoft.XLANGs.Core.UserVariableAttribute("ApplicationNumberList")]
            internal System.String __ApplicationNumberList;
            [Microsoft.XLANGs.Core.UserVariableAttribute("CheckListItem_DOCUMENT_SOQL_QUERY")]
            internal System.String __CheckListItem_DOCUMENT_SOQL_QUERY;
            [Microsoft.XLANGs.Core.UserVariableAttribute("ChecklistItemSFID")]
            internal System.String __ChecklistItemSFID;
            [Microsoft.XLANGs.Core.UserVariableAttribute("ChecklistItemSFIDList")]
            internal System.String __ChecklistItemSFIDList;
            [Microsoft.XLANGs.Core.UserVariableAttribute("DOCUMENT_APPLICATION_INFO_SOQL_QUERY")]
            internal System.String __DOCUMENT_APPLICATION_INFO_SOQL_QUERY;
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
        [Microsoft.XLANGs.Core.UserVariableAttribute("RestApplicationInfoPort")]
        internal SalesforceQueryDocumentApplicationInfoPortType RestApplicationInfoPort;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("RestDocumentChecklistItemQueryPort")]
        internal RestDocumentChecklistItemQueryPortType RestDocumentChecklistItemQueryPort;

        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {SalesforceQueryDocumentApplicationInfoPortType.Operation},
                                               typeof(DocumentLogic).GetField("RestApplicationInfoPort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(DocumentLogic), "RestApplicationInfoPort"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {RestDocumentChecklistItemQueryPortType.Operation},
                                               typeof(DocumentLogic).GetField("RestDocumentChecklistItemQueryPort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(DocumentLogic), "RestDocumentChecklistItemQueryPort"),
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
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "973848db-e00c-4821-b311-436460a589b4", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "973848db-e00c-4821-b311-436460a589b4", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "ff02eb63-5cf3-4fb9-8c20-546665f4988c", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "ff02eb63-5cf3-4fb9-8c20-546665f4988c", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(6, "60a96da9-e7db-446d-abcd-da44b5f6d237", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(7, "60a96da9-e7db-446d-abcd-da44b5f6d237", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(8, "4f58ced4-49f2-471d-89da-d0cfda0691c6", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(9, "4f58ced4-49f2-471d-89da-d0cfda0691c6", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(10, "c0a9c700-9ddb-4114-b579-85f2f1de01eb", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(11, "c0a9c700-9ddb-4114-b579-85f2f1de01eb", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(12, "95498e81-b9fc-4a66-9f94-5e20c9fec88a", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(13, "95498e81-b9fc-4a66-9f94-5e20c9fec88a", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(14, "97efb380-5fee-4155-a44f-1d0a40e1b531", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(15, "97efb380-5fee-4155-a44f-1d0a40e1b531", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(16, "4d9fe9c1-21e5-416a-afc5-2551eec53f4e", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(17, "4d9fe9c1-21e5-416a-afc5-2551eec53f4e", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(18, "5e89cfd3-7fe6-4a67-9cfa-e0871299f174", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(19, "5e89cfd3-7fe6-4a67-9cfa-e0871299f174", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(20, "14e485b4-b001-48ee-883f-6923c74f1997", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(21, "14e485b4-b001-48ee-883f-6923c74f1997", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(22, "1ebb7433-719c-4a87-9a6a-b4a9df250381", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(23, "1ebb7433-719c-4a87-9a6a-b4a9df250381", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(24, "ea1d3ad9-d64c-4ea2-a36e-ace0fac0a94e", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(25, "ea1d3ad9-d64c-4ea2-a36e-ace0fac0a94e", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(26, "161ded47-84ac-4f07-a96d-113b9fa50f30", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(27, "161ded47-84ac-4f07-a96d-113b9fa50f30", 1, false)
        };

        public override Microsoft.XLANGs.RuntimeTypes.Location[] EventLocations
        {
            get { return __eventLocations; }
        }

        public static Microsoft.XLANGs.RuntimeTypes.EventData[] __eventData = new Microsoft.XLANGs.RuntimeTypes.EventData[] {
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Body),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Body),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Expression),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Expression),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Construct),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Send),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Receive)
        };

        public static int[] __progressLocation0 = new int[] { 0,0,0,1,1,};
        public static int[] __progressLocation1 = new int[] { 0,0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,2,2,3,3,3,3,4,4,5,6,6,6,7,8,8,9,10,10,11,12,12,13,14,14,15,16,16,17,18,18,18,19,20,20,21,22,22,23,24,24,25,26,26,27,1,1,1,1,1,};

        public static int[][] __progressLocations = new int[2] [] {__progressLocation0,__progressLocation1};
        public override int[][] ProgressLocations {get {return __progressLocations;} }

        public Microsoft.XLANGs.Core.StopConditions segment0(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[0];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[0];
            __DocumentLogic_1 __ctx1__ = (__DocumentLogic_1)_stateMgrs[1];
            __DocumentLogic_root_0 __ctx0__ = (__DocumentLogic_root_0)_stateMgrs[0];

            switch (__seg__.Progress)
            {
            case 0:
                RestApplicationInfoPort = new SalesforceQueryDocumentApplicationInfoPortType(0, this);
                RestDocumentChecklistItemQueryPort = new RestDocumentChecklistItemQueryPortType(1, this);
                __ctx__.PrologueCompleted = true;
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.Initialized) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.Initialized;
                goto case 1;
            case 1:
                __ctx1__ = new __DocumentLogic_1(this);
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
            __DocumentLogic_1 __ctx1__ = (__DocumentLogic_1)_stateMgrs[1];
            __DocumentLogic_root_0 __ctx0__ = (__DocumentLogic_root_0)_stateMgrs[0];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx1__.__SalesforceNotificationEventRequest = new SingleNotificationEventType("SalesforceNotificationEventRequest", __ctx1__);
                __ctx1__.__SalesforceNotificationEventRequest.CopyFrom((Microsoft.XLANGs.Core.XMessage)Args[0]);
                __ctx1__.RefMessage(__ctx1__.__SalesforceNotificationEventRequest);
                __ctx1__.__SalesforceNotificationEventRequest.ConstructionCompleteEvent();
                __ctx1__.__DocumentResponse = null;
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 1;
            case 1:
                __ctx1__.__ApplicationSFID = default(System.String);
                __ctx1__.__TempApplicationDocList = new Microsoft.XLANGs.RuntimeTypes.XmlDocumentSerializationProxy();
                __ctx1__.__ApplicationStrTempEmpty = default(System.String);
                __ctx1__.__StrTempEmpty = default(System.String);
                __ctx1__.__TempDoc = new Microsoft.XLANGs.RuntimeTypes.XmlDocumentSerializationProxy();
                __ctx1__.__LoopCount = default(System.Int32);
                __ctx1__.__ApplicantCount = default(System.Int32);
                __ctx1__.__ApplicantSFIDXpath = default(System.String);
                __ctx1__.__ApplicantSFID = default(System.String);
                __ctx1__.__ApplicantNameXpath = default(System.String);
                __ctx1__.__ApplicantName = default(System.String);
                __ctx1__.__DLAPUserID = default(System.String);
                __ctx1__.__SFObjectID = default(System.String);
                __ctx1__.__ChecklistItemDocApplicantSFIDxpath = default(System.String);
                __ctx1__.__ChecklistItemDocApplicantSFID = default(System.String);
                __ctx1__.__ChecklistItemStatusxPath = default(System.String);
                __ctx1__.__ChecklistItemStatus = default(System.String);
                __ctx1__.__DocumentMasterCheckListNamexPath = default(System.String);
                __ctx1__.__DocumentMasterCheckListName = default(System.String);
                __ctx1__.__DocumentMasterCheckListDescxPath = default(System.String);
                __ctx1__.__DocumentMasterCheckListDesc = default(System.String);
                __ctx1__.__ChecklistItemTempDoc = new Microsoft.XLANGs.RuntimeTypes.XmlDocumentSerializationProxy();
                __ctx1__.__ChecklistStrTempEmpty = default(System.String);
                __ctx1__.__TempChecklistItemDocList = new Microsoft.XLANGs.RuntimeTypes.XmlDocumentSerializationProxy();
                __ctx1__.__ChecklistItemTypexPath = default(System.String);
                __ctx1__.__ChecklistItemType = default(System.String);
                __ctx1__.__APPLICATION_INFO_SOQL_QUERY = default(System.String);
                __ctx1__.__ApplicationNumber = default(System.String);
                __ctx1__.__ApplicationNumberList = default(System.String);
                __ctx1__.__CheckListItem_DOCUMENT_SOQL_QUERY = default(System.String);
                __ctx1__.__ChecklistItemSFID = default(System.String);
                __ctx1__.__ChecklistItemSFIDList = default(System.String);
                __ctx1__.__DOCUMENT_APPLICATION_INFO_SOQL_QUERY = default(System.String);
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
                __ctx1__.__ApplicationSFID = "";
                if (__ctx1__ != null)
                    __ctx1__.__ApplicationSFID = null;
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                __ctx1__.__TempApplicationDocList.UnderlyingXmlDocument = new System.Xml.XmlDocument();
                if (__ctx1__ != null)
                    __ctx1__.__TempApplicationDocList = null;
                if ( !PostProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 5;
            case 5:
                __ctx1__.__ApplicationStrTempEmpty = "";
                if (__ctx1__ != null)
                    __ctx1__.__ApplicationStrTempEmpty = null;
                if ( !PostProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 6;
            case 6:
                __ctx1__.__StrTempEmpty = "";
                if (__ctx1__ != null)
                    __ctx1__.__StrTempEmpty = null;
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                __ctx1__.__TempDoc.UnderlyingXmlDocument = new System.Xml.XmlDocument();
                if (__ctx1__ != null)
                    __ctx1__.__TempDoc = null;
                if ( !PostProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 8;
            case 8:
                __ctx1__.__LoopCount = 1;
                if ( !PostProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 9;
            case 9:
                __ctx1__.__ApplicantSFIDXpath = "";
                if (__ctx1__ != null)
                    __ctx1__.__ApplicantSFIDXpath = null;
                if ( !PostProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 10;
            case 10:
                __ctx1__.__ApplicantSFID = "";
                if (__ctx1__ != null)
                    __ctx1__.__ApplicantSFID = null;
                if ( !PostProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 11;
            case 11:
                __ctx1__.__ApplicantNameXpath = "";
                if (__ctx1__ != null)
                    __ctx1__.__ApplicantNameXpath = null;
                if ( !PostProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 12;
            case 12:
                __ctx1__.__ApplicantName = "";
                if (__ctx1__ != null)
                    __ctx1__.__ApplicantName = null;
                if ( !PostProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 13;
            case 13:
                __ctx1__.__DLAPUserID = "";
                if (__ctx1__ != null)
                    __ctx1__.__DLAPUserID = null;
                if ( !PostProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 14;
            case 14:
                __ctx1__.__SFObjectID = "";
                if (__ctx1__ != null)
                    __ctx1__.__SFObjectID = null;
                if ( !PostProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 15;
            case 15:
                __ctx1__.__ChecklistItemDocApplicantSFIDxpath = "";
                if ( !PostProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 16;
            case 16:
                __ctx1__.__ChecklistItemDocApplicantSFID = "";
                if ( !PostProgressInc( __seg__, __ctx__, 17 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 17;
            case 17:
                __ctx1__.__ChecklistItemStatusxPath = "";
                if ( !PostProgressInc( __seg__, __ctx__, 18 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 18;
            case 18:
                __ctx1__.__ChecklistItemStatus = "";
                if ( !PostProgressInc( __seg__, __ctx__, 19 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 19;
            case 19:
                __ctx1__.__DocumentMasterCheckListNamexPath = "";
                if ( !PostProgressInc( __seg__, __ctx__, 20 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 20;
            case 20:
                __ctx1__.__DocumentMasterCheckListName = "";
                if ( !PostProgressInc( __seg__, __ctx__, 21 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 21;
            case 21:
                __ctx1__.__DocumentMasterCheckListDescxPath = "";
                if ( !PostProgressInc( __seg__, __ctx__, 22 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 22;
            case 22:
                __ctx1__.__DocumentMasterCheckListDesc = "";
                if ( !PostProgressInc( __seg__, __ctx__, 23 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 23;
            case 23:
                __ctx1__.__ChecklistItemTempDoc.UnderlyingXmlDocument = new System.Xml.XmlDocument();
                if ( !PostProgressInc( __seg__, __ctx__, 24 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 24;
            case 24:
                __ctx1__.__ChecklistStrTempEmpty = "";
                if ( !PostProgressInc( __seg__, __ctx__, 25 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 25;
            case 25:
                __ctx1__.__TempChecklistItemDocList.UnderlyingXmlDocument = new System.Xml.XmlDocument();
                if ( !PostProgressInc( __seg__, __ctx__, 26 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 26;
            case 26:
                __ctx1__.__ChecklistItemTypexPath = "";
                if ( !PostProgressInc( __seg__, __ctx__, 27 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 27;
            case 27:
                __ctx1__.__ChecklistItemType = "";
                if ( !PostProgressInc( __seg__, __ctx__, 28 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 28;
            case 28:
                __ctx1__.__APPLICATION_INFO_SOQL_QUERY = "";
                if (__ctx1__ != null)
                    __ctx1__.__APPLICATION_INFO_SOQL_QUERY = null;
                if ( !PostProgressInc( __seg__, __ctx__, 29 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 29;
            case 29:
                __ctx1__.__ApplicationNumber = "";
                if ( !PostProgressInc( __seg__, __ctx__, 30 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 30;
            case 30:
                __ctx1__.__ApplicationNumberList = "";
                if ( !PostProgressInc( __seg__, __ctx__, 31 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 31;
            case 31:
                __ctx1__.__CheckListItem_DOCUMENT_SOQL_QUERY = "";
                if ( !PostProgressInc( __seg__, __ctx__, 32 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 32;
            case 32:
                __ctx1__.__ChecklistItemSFID = "";
                if ( !PostProgressInc( __seg__, __ctx__, 33 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 33;
            case 33:
                __ctx1__.__ChecklistItemSFIDList = "";
                if ( !PostProgressInc( __seg__, __ctx__, 34 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 34;
            case 34:
                __ctx1__.__DOCUMENT_APPLICATION_INFO_SOQL_QUERY = "";
                if ( !PostProgressInc( __seg__, __ctx__, 35 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 35;
            case 35:
                if ( !PreProgressInc( __seg__, __ctx__, 36 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[2],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 36;
            case 36:
                __ctx1__.__ApplicationNumber = (System.String)Microsoft.XLANGs.Core.Part.XPathLoad(__ctx1__.__SalesforceNotificationEventRequest.MessagePart, "string(/*[local-name()='Notifications' and namespace-uri()='http://DLAPEventsSalesforceDefinition/SingleNotificationEvent']/*[local-name()='Notification' and namespace-uri()='http://soap.sforce.com/2005/09/outbound']/*[local-name()='sObject' and namespace-uri()='http://soap.sforce.com/2005/09/outbound']/*[local-name()='Application_Number__c' and namespace-uri()='urn:sobject.enterprise.soap.sforce.com'])", typeof(System.String));
                if ( !PostProgressInc( __seg__, __ctx__, 37 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 37;
            case 37:
                if ( !PreProgressInc( __seg__, __ctx__, 38 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[3],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 38;
            case 38:
                __ctx1__.__ApplicationNumberList = "'" + __ctx1__.__ApplicationNumber + "'";
                if (__ctx1__ != null)
                    __ctx1__.__ApplicationNumber = null;
                if ( !PostProgressInc( __seg__, __ctx__, 39 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 39;
            case 39:
                __ctx1__.__ChecklistItemSFID = (System.String)Microsoft.XLANGs.Core.Part.XPathLoad(__ctx1__.__SalesforceNotificationEventRequest.MessagePart, "string(/*[local-name()='Notifications' and namespace-uri()='http://DLAPEventsSalesforceDefinition/SingleNotificationEvent']/*[local-name()='Notification' and namespace-uri()='http://soap.sforce.com/2005/09/outbound']/*[local-name()='sObject' and namespace-uri()='http://soap.sforce.com/2005/09/outbound']/*[local-name()='SObject_ID__c' and namespace-uri()='urn:sobject.enterprise.soap.sforce.com'])", typeof(System.String));
                if ( !PostProgressInc( __seg__, __ctx__, 40 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 40;
            case 40:
                __ctx1__.__ChecklistItemSFIDList = "'" + __ctx1__.__ChecklistItemSFID + "'";
                if ( !PostProgressInc( __seg__, __ctx__, 41 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 41;
            case 41:
                if ( !PreProgressInc( __seg__, __ctx__, 42 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[4],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 42;
            case 42:
                {
                    RestQueryApplicationInfoRequestType __RestQueryApplicationInfoRequestMsg = new RestQueryApplicationInfoRequestType("RestQueryApplicationInfoRequestMsg", __ctx1__);

                    ApplyTransform(typeof(DLAPEventsLogic.MakeRestQueryApplicationInfoRequest), new object[] {__RestQueryApplicationInfoRequestMsg.MessagePart}, new object[] {__ctx1__.__SalesforceNotificationEventRequest.MessagePart});
                    __ctx1__.__DOCUMENT_APPLICATION_INFO_SOQL_QUERY = @"Select Id, Name, Loan_Type__c, DLAP_Status_Description__c, DLAP_Status__c, Disaster_Declaration__r.Name,Disaster_Declaration__r.Disaster_Description__c, Disaster_Declaration__r.Disaster_Deadline_Date__c,(Select Id, External_ID__c, Name, Applicant_Relation_Type__c, Trade_Name__c, Contact__r.LastName, Contact__r.FirstName from Applicants__r),(Select Id, Name, Case__c, Applicant__c, Application__c, Checklist_Item_Status__c, Checklist_Item_Text__c, Type__c, DocumentType__c, Verified_Date__c, CreatedDate, Checklist_Item_Due_Date__c, Applicant__r.External_ID__c, Master_Checklist__r.Name, Master_Checklist__r.Checklist_Description__c FROM Checklist_Items__r WHERE Id IN " + "(" + __ctx1__.__ChecklistItemSFIDList + ") and Id !=NULL) FROM Application__c WHERE Name IN " + "(" + __ctx1__.__ApplicationNumberList + ") AND Name != NULL";
                    if (__ctx1__ != null)
                        __ctx1__.__ChecklistItemSFIDList = null;
                    if (__ctx1__ != null)
                        __ctx1__.__ApplicationNumberList = null;
                    __RestQueryApplicationInfoRequestMsg.SetPropertyValue(typeof(DLAPEventsSalesforceDefinition.RestCheckStatus.SF_APPLICATION_QUERY), __ctx1__.__DOCUMENT_APPLICATION_INFO_SOQL_QUERY);
                    if (__ctx1__ != null)
                        __ctx1__.__DOCUMENT_APPLICATION_INFO_SOQL_QUERY = null;

                    if (__ctx1__.__RestQueryApplicationInfoRequestMsg != null)
                        __ctx1__.UnrefMessage(__ctx1__.__RestQueryApplicationInfoRequestMsg);
                    __ctx1__.__RestQueryApplicationInfoRequestMsg = __RestQueryApplicationInfoRequestMsg;
                    __ctx1__.RefMessage(__ctx1__.__RestQueryApplicationInfoRequestMsg);
                }
                __ctx1__.__RestQueryApplicationInfoRequestMsg.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 43 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 43;
            case 43:
                if ( !PreProgressInc( __seg__, __ctx__, 44 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__RestQueryApplicationInfoRequestMsg);
                    __edata.Messages.Add(__ctx1__.__SalesforceNotificationEventRequest);
                    Tracker.FireEvent(__eventLocations[5],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 44;
            case 44:
                if ( !PreProgressInc( __seg__, __ctx__, 45 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[6],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 45;
            case 45:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 46 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 46;
            case 46:
                if ( !PreProgressInc( __seg__, __ctx__, 47 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                RestApplicationInfoPort.SendMessage(0, __ctx1__.__RestQueryApplicationInfoRequestMsg, null, null, out __ctx0__.__subWrapper0, __ctx1__, __seg__ );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 47;
            case 47:
                if ( !PreProgressInc( __seg__, __ctx__, 48 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__RestQueryApplicationInfoRequestMsg);
                    __edata.PortName = @"RestApplicationInfoPort";
                    Tracker.FireEvent(__eventLocations[7],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__RestQueryApplicationInfoRequestMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__RestQueryApplicationInfoRequestMsg);
                    __ctx1__.__RestQueryApplicationInfoRequestMsg = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 48;
            case 48:
                if ( !PreProgressInc( __seg__, __ctx__, 49 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[8],__eventData[6],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 49;
            case 49:
                if (!RestApplicationInfoPort.GetMessageId(__ctx0__.__subWrapper0.getSubscription(this), __seg__, __ctx1__, out __msgEnv__, _locations[0]))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx0__ != null && __ctx0__.__subWrapper0 != null)
                {
                    __ctx0__.__subWrapper0.Destroy(this, __ctx0__);
                    __ctx0__.__subWrapper0 = null;
                }
                if (__ctx1__.__RestQueryApplicationInfoResponseMsg != null)
                    __ctx1__.UnrefMessage(__ctx1__.__RestQueryApplicationInfoResponseMsg);
                __ctx1__.__RestQueryApplicationInfoResponseMsg = new RestQueryApplicationInfoResponseType("RestQueryApplicationInfoResponseMsg", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__RestQueryApplicationInfoResponseMsg);
                RestApplicationInfoPort.ReceiveMessage(0, __msgEnv__, __ctx1__.__RestQueryApplicationInfoResponseMsg, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if (RestApplicationInfoPort != null)
                {
                    RestApplicationInfoPort.Close(__ctx1__, __seg__);
                    RestApplicationInfoPort = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 50 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 50;
            case 50:
                if ( !PreProgressInc( __seg__, __ctx__, 51 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__RestQueryApplicationInfoResponseMsg);
                    __edata.PortName = @"RestApplicationInfoPort";
                    Tracker.FireEvent(__eventLocations[9],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 51;
            case 51:
                if ( !PreProgressInc( __seg__, __ctx__, 52 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[10],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 52;
            case 52:
                {
                    SalesforceQueryStatusApplicationInfoResponseType __SalesforceQueryApplicationInfoResponseMsg = new SalesforceQueryStatusApplicationInfoResponseType("SalesforceQueryApplicationInfoResponseMsg", __ctx1__);

                    ApplyTransform(typeof(DLAPEventsLogic.MakeApplicationInfoResponse), new object[] {__SalesforceQueryApplicationInfoResponseMsg.MessagePart}, new object[] {__ctx1__.__RestQueryApplicationInfoResponseMsg.MessagePart});

                    if (__ctx1__.__SalesforceQueryApplicationInfoResponseMsg != null)
                        __ctx1__.UnrefMessage(__ctx1__.__SalesforceQueryApplicationInfoResponseMsg);
                    __ctx1__.__SalesforceQueryApplicationInfoResponseMsg = __SalesforceQueryApplicationInfoResponseMsg;
                    __ctx1__.RefMessage(__ctx1__.__SalesforceQueryApplicationInfoResponseMsg);
                }
                __ctx1__.__SalesforceQueryApplicationInfoResponseMsg.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 53 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 53;
            case 53:
                if ( !PreProgressInc( __seg__, __ctx__, 54 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__SalesforceQueryApplicationInfoResponseMsg);
                    __edata.Messages.Add(__ctx1__.__RestQueryApplicationInfoResponseMsg);
                    Tracker.FireEvent(__eventLocations[11],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 54;
            case 54:
                if ( !PreProgressInc( __seg__, __ctx__, 55 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[12],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 55;
            case 55:
                {
                    SalesforceQueryDocumentChecklistItemResponseType __SalesforceQueryDocumentChecklistItemResponseMsg = new SalesforceQueryDocumentChecklistItemResponseType("SalesforceQueryDocumentChecklistItemResponseMsg", __ctx1__);

                    ApplyTransform(typeof(DLAPEventsLogic.MakeSalesforceCheckListItemResponse), new object[] {__SalesforceQueryDocumentChecklistItemResponseMsg.MessagePart}, new object[] {__ctx1__.__RestQueryApplicationInfoResponseMsg.MessagePart});

                    if (__ctx1__.__SalesforceQueryDocumentChecklistItemResponseMsg != null)
                        __ctx1__.UnrefMessage(__ctx1__.__SalesforceQueryDocumentChecklistItemResponseMsg);
                    __ctx1__.__SalesforceQueryDocumentChecklistItemResponseMsg = __SalesforceQueryDocumentChecklistItemResponseMsg;
                    __ctx1__.RefMessage(__ctx1__.__SalesforceQueryDocumentChecklistItemResponseMsg);
                }
                __ctx1__.__SalesforceQueryDocumentChecklistItemResponseMsg.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 56 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 56;
            case 56:
                if ( !PreProgressInc( __seg__, __ctx__, 57 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__SalesforceQueryDocumentChecklistItemResponseMsg);
                    __edata.Messages.Add(__ctx1__.__RestQueryApplicationInfoResponseMsg);
                    Tracker.FireEvent(__eventLocations[13],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__RestQueryApplicationInfoResponseMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__RestQueryApplicationInfoResponseMsg);
                    __ctx1__.__RestQueryApplicationInfoResponseMsg = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 57;
            case 57:
                if ( !PreProgressInc( __seg__, __ctx__, 58 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[14],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 58;
            case 58:
                __ctx1__.__ApplicantCount = System.Convert.ToInt32(Microsoft.XLANGs.Core.Part.XPathLoad(__ctx1__.__SalesforceQueryApplicationInfoResponseMsg.MessagePart, "count(/*[local-name()='Response' and namespace-uri()='http://SBA.gov/DLAPEvents/Application_Info__c']/*[local-name()='row' and namespace-uri()='http://SBA.gov/DLAPEvents/Application_Info__c']/*[local-name()='ApplicantId' and namespace-uri()='http://SBA.gov/DLAPEvents/Application_Info__c'])", typeof(System.Object)));
                if ( !PostProgressInc( __seg__, __ctx__, 59 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 59;
            case 59:
                if ( !PreProgressInc( __seg__, __ctx__, 60 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[15],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 60;
            case 60:
                if ( !PreProgressInc( __seg__, __ctx__, 61 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[16],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 61;
            case 61:
                {
                    RestDocumentDetailsRequestType __RestDocumentDetailsRequestMsg = new RestDocumentDetailsRequestType("RestDocumentDetailsRequestMsg", __ctx1__);

                    ApplyTransform(typeof(DLAPEventsLogic.MakeRestDocumentRequest), new object[] {__RestDocumentDetailsRequestMsg.MessagePart}, new object[] {__ctx1__.__SalesforceNotificationEventRequest.MessagePart});
                    __ctx1__.__CheckListItem_DOCUMENT_SOQL_QUERY = @"SELECT ContentDocument.LatestPublishedVersion.DLAP_Document_Type__c,ContentDocument.LatestPublishedVersion.Title,ContentDocument.LatestPublishedVersion.Id,ContentDocument.LatestPublishedVersion.Description,ContentDocument.LatestPublishedVersion.Document_Validity__c,ContentDocument.LatestPublishedVersion.CreatedDate,ContentDocument.LatestPublishedVersion.Document_Type__c FROM ContentDocumentLink WHERE LinkedEntityId IN " + "('" + __ctx1__.__ChecklistItemSFID + "') AND LinkedEntityId != null";
                    if (__ctx1__ != null)
                        __ctx1__.__ChecklistItemSFID = null;
                    __RestDocumentDetailsRequestMsg.SetPropertyValue(typeof(DLAPEventsSalesforceDefinition.RestDocument.DOCUMENT_SOQL_Query), __ctx1__.__CheckListItem_DOCUMENT_SOQL_QUERY);
                    if (__ctx1__ != null)
                        __ctx1__.__CheckListItem_DOCUMENT_SOQL_QUERY = null;

                    if (__ctx1__.__RestDocumentDetailsRequestMsg != null)
                        __ctx1__.UnrefMessage(__ctx1__.__RestDocumentDetailsRequestMsg);
                    __ctx1__.__RestDocumentDetailsRequestMsg = __RestDocumentDetailsRequestMsg;
                    __ctx1__.RefMessage(__ctx1__.__RestDocumentDetailsRequestMsg);
                }
                __ctx1__.__RestDocumentDetailsRequestMsg.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 62 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 62;
            case 62:
                if ( !PreProgressInc( __seg__, __ctx__, 63 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__RestDocumentDetailsRequestMsg);
                    __edata.Messages.Add(__ctx1__.__SalesforceNotificationEventRequest);
                    Tracker.FireEvent(__eventLocations[17],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 63;
            case 63:
                if ( !PreProgressInc( __seg__, __ctx__, 64 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[18],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 64;
            case 64:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 65 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 65;
            case 65:
                if ( !PreProgressInc( __seg__, __ctx__, 66 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                RestDocumentChecklistItemQueryPort.SendMessage(0, __ctx1__.__RestDocumentDetailsRequestMsg, null, null, out __ctx0__.__subWrapper1, __ctx1__, __seg__ );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 66;
            case 66:
                if ( !PreProgressInc( __seg__, __ctx__, 67 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__RestDocumentDetailsRequestMsg);
                    __edata.PortName = @"RestDocumentChecklistItemQueryPort";
                    Tracker.FireEvent(__eventLocations[19],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__RestDocumentDetailsRequestMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__RestDocumentDetailsRequestMsg);
                    __ctx1__.__RestDocumentDetailsRequestMsg = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 67;
            case 67:
                if ( !PreProgressInc( __seg__, __ctx__, 68 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[20],__eventData[6],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 68;
            case 68:
                if (!RestDocumentChecklistItemQueryPort.GetMessageId(__ctx0__.__subWrapper1.getSubscription(this), __seg__, __ctx1__, out __msgEnv__, _locations[1]))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx0__ != null && __ctx0__.__subWrapper1 != null)
                {
                    __ctx0__.__subWrapper1.Destroy(this, __ctx0__);
                    __ctx0__.__subWrapper1 = null;
                }
                if (__ctx1__.__RestDocumentDetailsResponseMsg != null)
                    __ctx1__.UnrefMessage(__ctx1__.__RestDocumentDetailsResponseMsg);
                __ctx1__.__RestDocumentDetailsResponseMsg = new RestDocumentDetailsResponseType("RestDocumentDetailsResponseMsg", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__RestDocumentDetailsResponseMsg);
                RestDocumentChecklistItemQueryPort.ReceiveMessage(0, __msgEnv__, __ctx1__.__RestDocumentDetailsResponseMsg, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if (RestDocumentChecklistItemQueryPort != null)
                {
                    RestDocumentChecklistItemQueryPort.Close(__ctx1__, __seg__);
                    RestDocumentChecklistItemQueryPort = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 69 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 69;
            case 69:
                if ( !PreProgressInc( __seg__, __ctx__, 70 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__RestDocumentDetailsResponseMsg);
                    __edata.PortName = @"RestDocumentChecklistItemQueryPort";
                    Tracker.FireEvent(__eventLocations[21],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 70;
            case 70:
                if ( !PreProgressInc( __seg__, __ctx__, 71 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[22],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 71;
            case 71:
                {
                    SalesforceQueryContentVersionResponseType __SalesforceQueryContentVersionResponseMsg = new SalesforceQueryContentVersionResponseType("SalesforceQueryContentVersionResponseMsg", __ctx1__);

                    ApplyTransform(typeof(DLAPEventsLogic.MakeSalesforceChecklistItemDocumentResponse), new object[] {__SalesforceQueryContentVersionResponseMsg.MessagePart}, new object[] {__ctx1__.__RestDocumentDetailsResponseMsg.MessagePart});

                    if (__ctx1__.__SalesforceQueryContentVersionResponseMsg != null)
                        __ctx1__.UnrefMessage(__ctx1__.__SalesforceQueryContentVersionResponseMsg);
                    __ctx1__.__SalesforceQueryContentVersionResponseMsg = __SalesforceQueryContentVersionResponseMsg;
                    __ctx1__.RefMessage(__ctx1__.__SalesforceQueryContentVersionResponseMsg);
                }
                __ctx1__.__SalesforceQueryContentVersionResponseMsg.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 72 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 72;
            case 72:
                if ( !PreProgressInc( __seg__, __ctx__, 73 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__SalesforceQueryContentVersionResponseMsg);
                    __edata.Messages.Add(__ctx1__.__RestDocumentDetailsResponseMsg);
                    Tracker.FireEvent(__eventLocations[23],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__RestDocumentDetailsResponseMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__RestDocumentDetailsResponseMsg);
                    __ctx1__.__RestDocumentDetailsResponseMsg = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 73;
            case 73:
                if ( !PreProgressInc( __seg__, __ctx__, 74 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[24],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 74;
            case 74:
                {
                    SalesforceCheckListDocumentListDetailsResponseType __SalesforceCheckListDocumentListDetailsResponseMsg = new SalesforceCheckListDocumentListDetailsResponseType("SalesforceCheckListDocumentListDetailsResponseMsg", __ctx1__);

                    __ctx1__.__ChecklistItemDocApplicantSFIDxpath = "string(/*[local-name()='Response' and namespace-uri()='http://SBA.gov/DLAPEventsDocument/Checklist_Item__c']/*[local-name()='row' and namespace-uri()='http://SBA.gov/DLAPEventsDocument/Checklist_Item__c']/*[local-name()='ApplicantExternalId' and namespace-uri()='http://SBA.gov/DLAPEventsDocument/Checklist_Item__c'])";
                    __ctx1__.__ChecklistItemDocApplicantSFID = (System.String)Microsoft.XLANGs.Core.Part.XPathLoad(__ctx1__.__SalesforceQueryDocumentChecklistItemResponseMsg.MessagePart, __ctx1__.__ChecklistItemDocApplicantSFIDxpath, typeof(System.String));
                    if (__ctx1__ != null)
                        __ctx1__.__ChecklistItemDocApplicantSFIDxpath = null;
                    __ctx1__.__ChecklistItemStatusxPath = "string(/*[local-name()='Response' and namespace-uri()='http://SBA.gov/DLAPEventsDocument/Checklist_Item__c']/*[local-name()='row' and namespace-uri()='http://SBA.gov/DLAPEventsDocument/Checklist_Item__c']/*[local-name()='Checklist_Item_Status__c' and namespace-uri()='http://SBA.gov/DLAPEventsDocument/Checklist_Item__c'])";
                    __ctx1__.__ChecklistItemStatus = (System.String)Microsoft.XLANGs.Core.Part.XPathLoad(__ctx1__.__SalesforceQueryDocumentChecklistItemResponseMsg.MessagePart, __ctx1__.__ChecklistItemStatusxPath, typeof(System.String));
                    if (__ctx1__ != null)
                        __ctx1__.__ChecklistItemStatusxPath = null;
                    __ctx1__.__DocumentMasterCheckListNamexPath = "string(/*[local-name()='Response' and namespace-uri()='http://SBA.gov/DLAPEventsDocument/Checklist_Item__c']/*[local-name()='row' and namespace-uri()='http://SBA.gov/DLAPEventsDocument/Checklist_Item__c']/*[local-name()='MasterCheckListName' and namespace-uri()='http://SBA.gov/DLAPEventsDocument/Checklist_Item__c'])";
                    __ctx1__.__DocumentMasterCheckListName = (System.String)Microsoft.XLANGs.Core.Part.XPathLoad(__ctx1__.__SalesforceQueryDocumentChecklistItemResponseMsg.MessagePart, __ctx1__.__DocumentMasterCheckListNamexPath, typeof(System.String));
                    if (__ctx1__ != null)
                        __ctx1__.__DocumentMasterCheckListNamexPath = null;
                    __ctx1__.__DocumentMasterCheckListDescxPath = "string(/*[local-name()='Response' and namespace-uri()='http://SBA.gov/DLAPEventsDocument/Checklist_Item__c']/*[local-name()='row' and namespace-uri()='http://SBA.gov/DLAPEventsDocument/Checklist_Item__c']/*[local-name()='MasterCheckListDescription' and namespace-uri()='http://SBA.gov/DLAPEventsDocument/Checklist_Item__c'])";
                    __ctx1__.__DocumentMasterCheckListDesc = (System.String)Microsoft.XLANGs.Core.Part.XPathLoad(__ctx1__.__SalesforceQueryDocumentChecklistItemResponseMsg.MessagePart, __ctx1__.__DocumentMasterCheckListDescxPath, typeof(System.String));
                    if (__ctx1__ != null)
                        __ctx1__.__DocumentMasterCheckListDescxPath = null;
                    __ctx1__.__ChecklistItemTypexPath = "string(/*[local-name()='Response' and namespace-uri()='http://SBA.gov/DLAPEventsDocument/Checklist_Item__c']/*[local-name()='row' and namespace-uri()='http://SBA.gov/DLAPEventsDocument/Checklist_Item__c']/*[local-name()='Type__c' and namespace-uri()='http://SBA.gov/DLAPEventsDocument/Checklist_Item__c'])";
                    __ctx1__.__ChecklistItemType = (System.String)Microsoft.XLANGs.Core.Part.XPathLoad(__ctx1__.__SalesforceQueryDocumentChecklistItemResponseMsg.MessagePart, __ctx1__.__ChecklistItemTypexPath, typeof(System.String));
                    if (__ctx1__ != null)
                        __ctx1__.__ChecklistItemTypexPath = null;
                    __ctx1__.__ChecklistItemTempDoc.UnderlyingXmlDocument = __ctx1__.__SalesforceQueryContentVersionResponseMsg.MessagePart.TypedValue;
                    if (__ctx1__ != null && __ctx1__.__SalesforceQueryContentVersionResponseMsg != null)
                    {
                        __ctx1__.UnrefMessage(__ctx1__.__SalesforceQueryContentVersionResponseMsg);
                        __ctx1__.__SalesforceQueryContentVersionResponseMsg = null;
                    }
                    __ctx1__.__ChecklistStrTempEmpty = @"<ChecklistItemDocumentList xmlns='http://SBA.gov/DLAPEvents/ChecklistItemDocumentList'><Responses>" + __ctx1__.__ChecklistItemTempDoc.UnderlyingXmlDocument.InnerXml + "<ClosingDocumentApplicantId>" + __ctx1__.__ChecklistItemDocApplicantSFID + "</ClosingDocumentApplicantId><DocumentChecklist_Item_Status__c>" + __ctx1__.__ChecklistItemStatus + "</DocumentChecklist_Item_Status__c><DocumentMasterCheckListName>" + __ctx1__.__DocumentMasterCheckListName + "</DocumentMasterCheckListName><DocumentMasterChecklist_Description__c>" + __ctx1__.__DocumentMasterCheckListDesc + "</DocumentMasterChecklist_Description__c><Type>" + __ctx1__.__ChecklistItemType + "</Type></Responses></ChecklistItemDocumentList>";
                    if (__ctx1__ != null)
                        __ctx1__.__ChecklistItemType = null;
                    if (__ctx1__ != null)
                        __ctx1__.__ChecklistItemTempDoc = null;
                    if (__ctx1__ != null)
                        __ctx1__.__DocumentMasterCheckListDesc = null;
                    if (__ctx1__ != null)
                        __ctx1__.__DocumentMasterCheckListName = null;
                    if (__ctx1__ != null)
                        __ctx1__.__ChecklistItemStatus = null;
                    if (__ctx1__ != null)
                        __ctx1__.__ChecklistItemDocApplicantSFID = null;
                    __ctx1__.__TempChecklistItemDocList.UnderlyingXmlDocument.LoadXml(__ctx1__.__ChecklistStrTempEmpty);
                    if (__ctx1__ != null)
                        __ctx1__.__ChecklistStrTempEmpty = null;
                    __SalesforceCheckListDocumentListDetailsResponseMsg.MessagePart.LoadFrom((System.Xml.XmlDocument)__ctx1__.__TempChecklistItemDocList.UnderlyingXmlDocument);
                    if (__ctx1__ != null)
                        __ctx1__.__TempChecklistItemDocList = null;

                    if (__ctx1__.__SalesforceCheckListDocumentListDetailsResponseMsg != null)
                        __ctx1__.UnrefMessage(__ctx1__.__SalesforceCheckListDocumentListDetailsResponseMsg);
                    __ctx1__.__SalesforceCheckListDocumentListDetailsResponseMsg = __SalesforceCheckListDocumentListDetailsResponseMsg;
                    __ctx1__.RefMessage(__ctx1__.__SalesforceCheckListDocumentListDetailsResponseMsg);
                }
                __ctx1__.__SalesforceCheckListDocumentListDetailsResponseMsg.ConstructionCompleteEvent(false);
                if ( !PostProgressInc( __seg__, __ctx__, 75 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 75;
            case 75:
                if ( !PreProgressInc( __seg__, __ctx__, 76 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__SalesforceCheckListDocumentListDetailsResponseMsg);
                    Tracker.FireEvent(__eventLocations[25],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 76;
            case 76:
                if ( !PreProgressInc( __seg__, __ctx__, 77 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[26],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 77;
            case 77:
                {
                    DocumentResponseType __DocumentResponse = new DocumentResponseType("DocumentResponse", __ctx1__);

                    ApplyTransform(typeof(DLAPEventsLogic.MakeDocumentListResponse), new object[] {__DocumentResponse.MessagePart}, new object[] {__ctx1__.__SalesforceCheckListDocumentListDetailsResponseMsg.MessagePart, __ctx1__.__SalesforceQueryApplicationInfoResponseMsg.MessagePart, __ctx1__.__SalesforceQueryDocumentChecklistItemResponseMsg.MessagePart});

                    if (__ctx1__.__DocumentResponse != null)
                        __ctx1__.UnrefMessage(__ctx1__.__DocumentResponse);
                    __ctx1__.__DocumentResponse = __DocumentResponse;
                    __ctx1__.RefMessage(__ctx1__.__DocumentResponse);
                }
                __ctx1__.__DocumentResponse.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 78 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 78;
            case 78:
                if ( !PreProgressInc( __seg__, __ctx__, 79 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__DocumentResponse);
                    __edata.Messages.Add(__ctx1__.__SalesforceCheckListDocumentListDetailsResponseMsg);
                    __edata.Messages.Add(__ctx1__.__SalesforceQueryApplicationInfoResponseMsg);
                    __edata.Messages.Add(__ctx1__.__SalesforceQueryDocumentChecklistItemResponseMsg);
                    Tracker.FireEvent(__eventLocations[27],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__SalesforceCheckListDocumentListDetailsResponseMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__SalesforceCheckListDocumentListDetailsResponseMsg);
                    __ctx1__.__SalesforceCheckListDocumentListDetailsResponseMsg = null;
                }
                if (__ctx1__ != null && __ctx1__.__SalesforceQueryDocumentChecklistItemResponseMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__SalesforceQueryDocumentChecklistItemResponseMsg);
                    __ctx1__.__SalesforceQueryDocumentChecklistItemResponseMsg = null;
                }
                if (__ctx1__ != null && __ctx1__.__SalesforceQueryApplicationInfoResponseMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__SalesforceQueryApplicationInfoResponseMsg);
                    __ctx1__.__SalesforceQueryApplicationInfoResponseMsg = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 79;
            case 79:
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Body);
                    __edata.Messages.Add(__ctx1__.__SalesforceNotificationEventRequest);
                    __edata.Messages.Add(__ctx1__.__DocumentResponse);
                    Tracker.FireEvent(__eventLocations[0],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__SalesforceNotificationEventRequest != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__SalesforceNotificationEventRequest);
                    __ctx1__.__SalesforceNotificationEventRequest = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 80 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 80;
            case 80:
                if (!__ctx1__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 81 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 81;
            case 81:
                if ( !PreProgressInc( __seg__, __ctx__, 82 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx1__.OnCommit();
                goto case 82;
            case 82:
                ((Microsoft.XLANGs.Core.MessageTuple)(Args[1])).message = __ctx1__.__DocumentResponse;
                ((Microsoft.XLANGs.Core.MessageTuple)(Args[1])).context.RefMessage(__ctx1__.__DocumentResponse);
                if ( !PostProgressInc( __seg__, __ctx__, 83 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 83;
            case 83:
                __seg__.SegmentDone();
                _segments[0].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }
        private static Microsoft.XLANGs.Core.CachedObject[] _locations = new Microsoft.XLANGs.Core.CachedObject[] {
            new Microsoft.XLANGs.Core.CachedObject(new System.Guid("{7D85BEA3-8340-4328-B8A5-B70C315EF94F}")),
            new Microsoft.XLANGs.Core.CachedObject(new System.Guid("{93AFB3D9-C813-4D9C-AD15-CB9835D4C807}"))
        };

    }
    //#line 306 "C:\Users\skyeniga\Source\Repos\Biztalk\DLAP Events\DLAP Events Logic\DLAPEventsEventRequest.odx"
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        },
        new System.Type[] {
            typeof(DLAPEvents.RestEventPortType)
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
    sealed internal class EventRequest : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
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
            [ Microsoft.XLANGs.BaseTypes.ServiceParameterAttribute(Microsoft.XLANGs.BaseTypes.EXLangSParameter.eVariable, "") ] System.Guid OrchestrationInstanceId,
            [ Microsoft.XLANGs.BaseTypes.ServiceParameterAttribute(Microsoft.XLANGs.BaseTypes.EXLangSParameter.eVariable, "") ] System.String EventRequestId)
        {
        }
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(EventRequest));
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

        static EventRequest()
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
            _rootContext = new __EventRequest_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[2];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public EventRequest(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "EventRequest", tracker)
        {
            ConstructorHelper();
        }

        public EventRequest(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "EventRequest")
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
                            
<ShapeInfo>      <shapeType>VariableDeclarationShape</shapeType>      <ShapeID>4134e14f-d720-4458-8665-c86bebce4966</ShapeID>      <ParentLink>ServiceBody_Declaration</ParentLink>                <shapeText>EventRequestId</shapeText>                  
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
<ActionName>'EventRequest'</ActionName><IsAtomic>0</IsAtomic><Line>306</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>325</Line><Position>13</Position><ShapeID>'f84d8b89-0605-4efc-a0fa-b6bca8404099'</ShapeID>
<Messages>
	<MsgInfo><name>RestEventRequestMsg</name><part>MessagePart</part><schema>DLAPEventsSalesforceDefinition.RestEventRequest+SaveRequest</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>352</Line><Position>13</Position><ShapeID>'6d47e91d-bd62-40ed-9a49-af24cec37cc9'</ShapeID>
<Messages>
	<MsgInfo><name>RestEventRequestMsg</name><part>MessagePart</part><schema>DLAPEventsSalesforceDefinition.RestEventRequest+SaveRequest</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>354</Line><Position>13</Position><ShapeID>'6e81659d-4305-431e-a67a-e169f0f4aabe'</ShapeID>
<Messages>
	<MsgInfo><name>RestEventResponseMsg</name><part>MessagePart</part><schema>DLAPEventsSalesforceDefinition.RestEventRequest+results</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>356</Line><Position>30</Position><ShapeID>'9158f587-ec12-486b-bd82-6c1bcab8b47e'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>360</Line><Position>13</Position><ShapeID>'6b1d035d-d610-4c90-af71-267a9a0a5129'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>363</Line><Position>36</Position><ShapeID>'39f3c870-1aa8-4c00-950b-0e1611a58029'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>365</Line><Position>17</Position><ShapeID>'62204449-a1eb-4fc8-b1bf-0121af48e99d'</ShapeID>
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
        <om:Property Name='Name' Value='DLAPEvents' />
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
                    <om:Property Name='Ref' Value='DLAPEvents.RestEventRequestType' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
                <om:Element Type='MessageRef' OID='d5e4a510-d20b-4445-a7b8-b6dab9dd707d' ParentLink='OperationDeclaration_ResponseMessageRef' LowerBound='16.35' HigherBound='16.56'>
                    <om:Property Name='Ref' Value='DLAPEvents.RestEventResponseType' />
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
                <om:Property Name='ClassName' Value='DLAPEventsSalesforceDefinition.RestEventRequest.SaveRequest' />
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
                <om:Property Name='ClassName' Value='DLAPEventsSalesforceDefinition.RestEventRequest.results' />
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
            <om:Property Name='Name' Value='EventRequest' />
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
                <om:Property Name='Type' Value='DLAPEvents.RestEventRequestType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='RestEventRequestMsg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='ea9f32f2-a444-40e6-a63a-fdc3f7748aec' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='25.1' HigherBound='26.1'>
                <om:Property Name='Type' Value='DLAPEvents.RestEventResponseType' />
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
                <om:Element Type='VariableDeclaration' OID='4134e14f-d720-4458-8665-c86bebce4966' ParentLink='ServiceBody_Declaration' LowerBound='31.266' HigherBound='31.294'>
                    <om:Property Name='UseDefaultConstructor' Value='False' />
                    <om:Property Name='Type' Value='System.String' />
                    <om:Property Name='ParamDirection' Value='In' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='EventRequestId' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Construct' OID='f84d8b89-0605-4efc-a0fa-b6bca8404099' ParentLink='ServiceBody_Statement' LowerBound='38.1' HigherBound='65.1'>
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Construct Rest Event Request Msg' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='MessageAssignment' OID='7c03b257-1f9d-4a02-b591-aea5f1667fe7' ParentLink='ComplexStatement_Statement' LowerBound='41.1' HigherBound='64.1'>
                        <om:Property Name='Expression' Value='TempXml = new System.Xml.XmlDocument();&#xD;&#xA;&#xD;&#xA;Status__c = System.Security.SecurityElement.Escape(Status__c); &#xD;&#xA;&#xD;&#xA;Stage__c = System.Security.SecurityElement.Escape(Stage__c);&#xD;&#xA; &#xD;&#xA;Application_Number__c = System.Security.SecurityElement.Escape(Application_Number__c); &#xD;&#xA;&#xD;&#xA;SObject_Name__c = System.Security.SecurityElement.Escape(SObject_Name__c); &#xD;&#xA;&#xD;&#xA;SObject_ID__c= System.Security.SecurityElement.Escape(SObject_ID__c); &#xD;&#xA;&#xD;&#xA;Log_Message__c = System.Security.SecurityElement.Escape(Log_Message__c); &#xD;&#xA;&#xD;&#xA;GUID = System.DateTime.Now.ToString(&quot;yyyyMMddHHmmssfffffff&quot;)+&quot;--&quot;+System.Convert.ToString(OrchestrationInstanceId);&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;TempXml.LoadXml(System.String.Format(&quot;&lt;ns0:SaveRequest xmlns:ns0=&apos;http://SBA.gov/DLAPEvents/REST/INSERT/EventRequest&apos;&gt;&lt;ns0:allOrNone&gt;true&lt;/ns0:allOrNone&gt;&lt;ns0:records type=&apos;Event_Request__c&apos;&gt;&lt;ns0:Id&gt;{8}&lt;/ns0:Id&gt;&lt;ns0:Application_Number__c&gt;{0}&lt;/ns0:Application_Number__c&gt;&lt;ns0:SObject_ID__c&gt;{1}&lt;/ns0:SObject_ID__c&gt;&lt;ns0:Log_Message__c&gt;{2}&lt;/ns0:Log_Message__c&gt;&lt;ns0:SObject_Name__c&gt;{3}&lt;/ns0:SObject_Name__c&gt;&lt;ns0:Stage__c&gt;{4}&lt;/ns0:Stage__c&gt;&lt;ns0:Status__c&gt;{5}&lt;/ns0:Status__c&gt;&lt;ns0:Auto_Decline_Reason__c&gt;{6}&lt;/ns0:Auto_Decline_Reason__c&gt;&lt;ns0:GUID__c&gt;{7}&lt;/ns0:GUID__c&gt;&lt;/ns0:records&gt;&lt;/ns0:SaveRequest&gt;&quot;,Application_Number__c,SObject_ID__c,Log_Message__c,SObject_Name__c,Stage__c,Status__c,Auto_Decline_Reason__c,GUID,EventRequestId));&#xD;&#xA;&#xD;&#xA;RestEventRequestMsg.MessagePart = TempXml;&#xD;&#xA;&#xD;&#xA;' />
                        <om:Property Name='ReportToAnalyst' Value='False' />
                        <om:Property Name='Name' Value='Make Request Msg' />
                        <om:Property Name='Signal' Value='True' />
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
                    <om:Property Name='Expression' Value='RestEventMessage =  xpath(RestEventResponseMsg.MessagePart,&quot;string(/*[local-name()=&apos;results&apos; and namespace-uri()=&apos;http://SBA.gov/DLAPEvents/REST/INSERT/EventRequest&apos;]/*[local-name()=&apos;result&apos; and namespace-uri()=&apos;http://SBA.gov/DLAPEvents/REST/INSERT/EventRequest&apos;]/*[local-name()=&apos;errors&apos; and namespace-uri()=&apos;http://SBA.gov/DLAPEvents/REST/INSERT/EventRequest&apos;]/*[local-name()=&apos;message&apos; and namespace-uri()=&apos;http://SBA.gov/DLAPEvents/REST/INSERT/EventRequest&apos;])&quot;);&#xD;&#xA;&#xD;&#xA;RestEventSFID = xpath(RestEventResponseMsg.MessagePart,&quot;string(/*[local-name()=&apos;results&apos; and namespace-uri()=&apos;http://SBA.gov/DLAPEvents/REST/INSERT/EventRequest&apos;]/*[local-name()=&apos;result&apos; and namespace-uri()=&apos;http://SBA.gov/DLAPEvents/REST/INSERT/EventRequest&apos;]/*[local-name()=&apos;id&apos; and namespace-uri()=&apos;http://SBA.gov/DLAPEvents/REST/INSERT/EventRequest&apos;])&quot;);' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Extract Values' />
                    <om:Property Name='Signal' Value='False' />
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
                            <om:Property Name='Expression' Value='RestEventException = new System.Exception(&quot;DLAP Events Event Request Rest Exception  -  &quot; + RestEventMessage);' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Rest Exception' />
                            <om:Property Name='Signal' Value='False' />
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
                <om:Property Name='Type' Value='DLAPEvents.RestEventPortType' />
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
        public class __EventRequest_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __EventRequest_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "EventRequest")
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
                EventRequest __svc__ = (EventRequest)_service;
                __EventRequest_root_0 __ctx0__ = (__EventRequest_root_0)(__svc__._stateMgrs[0]);

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
        public class __EventRequest_1 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public __EventRequest_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "EventRequest")
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
                EventRequest __svc__ = (EventRequest)_service;
                __EventRequest_1 __ctx1__ = (__EventRequest_1)(__svc__._stateMgrs[1]);
                __EventRequest_root_0 __ctx0__ = (__EventRequest_root_0)(__svc__._stateMgrs[0]);

                if (__ctx1__ != null)
                    __ctx1__.__Status__c = null;
                if (__ctx1__ != null)
                    __ctx1__.__EventRequestId = null;
                if (__ctx1__ != null)
                    __ctx1__.__RestEventException = null;
                if (__ctx1__ != null && __ctx1__.__RestEventRequestMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__RestEventRequestMsg);
                    __ctx1__.__RestEventRequestMsg = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__SObject_ID__c = null;
                if (__ctx1__ != null)
                    __ctx1__.__Auto_Decline_Reason__c = null;
                if (__ctx1__ != null)
                    __ctx1__.__Stage__c = null;
                if (__ctx1__ != null)
                    __ctx1__.__TempXml = null;
                if (__ctx1__ != null)
                    __ctx1__.__RestEventMessage = null;
                if (__ctx1__ != null)
                    __ctx1__.__GUID = null;
                if (__ctx1__ != null)
                    __ctx1__.__Log_Message__c = null;
                if (__ctx1__ != null && __ctx1__.__RestEventResponseMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__RestEventResponseMsg);
                    __ctx1__.__RestEventResponseMsg = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__RestEventSFID = null;
                if (__ctx1__ != null)
                    __ctx1__.__SObject_Name__c = null;
                if (__ctx1__ != null)
                    __ctx1__.__Application_Number__c = null;
                if (__ctx0__ != null && __ctx0__.__subWrapper0 != null)
                {
                    __ctx0__.__subWrapper0.Destroy(__svc__, __ctx0__);
                    __ctx0__.__subWrapper0 = null;
                }
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
            [Microsoft.XLANGs.Core.UserVariableAttribute("EventRequestId")]
            internal System.String __EventRequestId;
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
                                               typeof(EventRequest).GetField("RestEventPort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(EventRequest), "RestEventPort"),
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
            __EventRequest_1 __ctx1__ = (__EventRequest_1)_stateMgrs[1];
            __EventRequest_root_0 __ctx0__ = (__EventRequest_root_0)_stateMgrs[0];

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
                __ctx1__ = new __EventRequest_1(this);
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
            __EventRequest_1 __ctx1__ = (__EventRequest_1)_stateMgrs[1];
            __EventRequest_root_0 __ctx0__ = (__EventRequest_root_0)_stateMgrs[0];

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
                __ctx1__.__EventRequestId = (System.String)Args[8];
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
                    __ctx1__.__TempXml.UnderlyingXmlDocument.LoadXml(System.String.Format("<ns0:SaveRequest xmlns:ns0='http://SBA.gov/DLAPEvents/REST/INSERT/EventRequest'><ns0:allOrNone>true</ns0:allOrNone><ns0:records type='Event_Request__c'><ns0:Id>{8}</ns0:Id><ns0:Application_Number__c>{0}</ns0:Application_Number__c><ns0:SObject_ID__c>{1}</ns0:SObject_ID__c><ns0:Log_Message__c>{2}</ns0:Log_Message__c><ns0:SObject_Name__c>{3}</ns0:SObject_Name__c><ns0:Stage__c>{4}</ns0:Stage__c><ns0:Status__c>{5}</ns0:Status__c><ns0:Auto_Decline_Reason__c>{6}</ns0:Auto_Decline_Reason__c><ns0:GUID__c>{7}</ns0:GUID__c></ns0:records></ns0:SaveRequest>", __ctx1__.__Application_Number__c, __ctx1__.__SObject_ID__c, __ctx1__.__Log_Message__c, __ctx1__.__SObject_Name__c, __ctx1__.__Stage__c, __ctx1__.__Status__c, __ctx1__.__Auto_Decline_Reason__c, __ctx1__.__GUID, __ctx1__.__EventRequestId));
                    if (__ctx1__ != null)
                        __ctx1__.__EventRequestId = null;
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
                __ctx1__.__RestEventMessage = (System.String)Microsoft.XLANGs.Core.Part.XPathLoad(__ctx1__.__RestEventResponseMsg.MessagePart, "string(/*[local-name()='results' and namespace-uri()='http://SBA.gov/DLAPEvents/REST/INSERT/EventRequest']/*[local-name()='result' and namespace-uri()='http://SBA.gov/DLAPEvents/REST/INSERT/EventRequest']/*[local-name()='errors' and namespace-uri()='http://SBA.gov/DLAPEvents/REST/INSERT/EventRequest']/*[local-name()='message' and namespace-uri()='http://SBA.gov/DLAPEvents/REST/INSERT/EventRequest'])", typeof(System.String));
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
                __ctx1__.__RestEventSFID = (System.String)Microsoft.XLANGs.Core.Part.XPathLoad(__ctx1__.__RestEventResponseMsg.MessagePart, "string(/*[local-name()='results' and namespace-uri()='http://SBA.gov/DLAPEvents/REST/INSERT/EventRequest']/*[local-name()='result' and namespace-uri()='http://SBA.gov/DLAPEvents/REST/INSERT/EventRequest']/*[local-name()='id' and namespace-uri()='http://SBA.gov/DLAPEvents/REST/INSERT/EventRequest'])", typeof(System.String));
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
                __ctx1__.__RestEventException = new System.Exception("DLAP Events Event Request Rest Exception  -  " + __ctx1__.__RestEventMessage);
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
            new Microsoft.XLANGs.Core.CachedObject(new System.Guid("{2F7C1CF3-9E45-4B09-BEBC-64C55385C47F}"))
        };

    }
    //#line 537 "C:\Users\skyeniga\Source\Repos\Biztalk\DLAP Events\DLAP Events Logic\DLAPEventsMultipleNotificationsDebatcherLogic.odx"
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        0, "SalesforceNotificationMultipleEventPort", "Operation", -1, -1, true
    )]
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        },
        new System.Type[] {
            typeof(DLAPEvents.SalesforceNotificationMultipleEventPortType),
            typeof(DLAPEvents.SalesforceNotificationSingleEventPortType),
            typeof(DLAPEvents.RestEventPortType)
        },
        new System.String[] {
            "SalesforceNotificationMultipleEventPort",
            "SalesforceNotificationSingleEventPort",
            "RestEventRequestUpdatePort"
        },
        new System.Type[] {
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
    sealed internal class MultipleNotificationsDebatcherLogic : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
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
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(MultipleNotificationsDebatcherLogic));
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

        static MultipleNotificationsDebatcherLogic()
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
            _rootContext = new __MultipleNotificationsDebatcherLogic_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[3];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public MultipleNotificationsDebatcherLogic(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "MultipleNotificationsDebatcherLogic", tracker)
        {
            ConstructorHelper();
        }

        public MultipleNotificationsDebatcherLogic(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "MultipleNotificationsDebatcherLogic")
        {
            ConstructorHelper();
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>7645620a-431c-4d10-b276-e64d96a6efae</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>f6e007f4-3bb3-4036-bbb7-0e245ea7f6ae</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Receive Multiple Salesforce Notification Request</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>7f1f71dd-956f-4521-be44-17aa12712f51</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Construct SF Notification Ack Message </shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>f1fd80c8-649a-4ba0-b0cd-4339644a07f6</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Make SF Notification Ack Msg</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>7d4e6e8b-957f-42d5-9fb4-794b022a1f4d</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>9eb70733-679c-4ce2-9042-e7f2c7cdef7e</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>ba6f27f8-bfa7-41c9-ac80-4b4e0269c7e9</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>38e2e0e4-5f34-41d3-9bf0-38e64b7a369b</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Send SF Notification Ack Msg</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ScopeShape</shapeType>      <ShapeID>6bcffe3a-d22b-41b6-a76f-513b7b2d6782</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Debatch Scope</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>TaskShape</shapeType>      <ShapeID>f9811e9c-b254-4304-8e96-c20329fa9194</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Debacting Multiple Notifications</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>dbbf9ab3-c81a-4eb2-9f40-d67323361d1e</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Notifications Count</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>WhileShape</shapeType>      <ShapeID>1a3485ab-55b5-47bd-a066-6bb49090ba80</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Loop Through Applications</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>28679b4b-f2e1-4080-850a-777a91bd502b</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Construct Single Notification Message</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>27ebbaf4-ad11-4089-ba43-4e84d190517a</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>MessageAssignment_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>9b82309b-b21d-45cb-bdf7-0ff72afc58bd</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>6450dd8f-9039-44da-bad4-de431db9d143</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Send Single Notification Message</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>CatchShape</shapeType>      <ShapeID>a71a4b01-c2df-4262-9775-b2c5daf7e3ef</ShapeID>      <ParentLink>Scope_Catch</ParentLink>                <shapeText>System Exception</shapeText>                      <ExceptionType>System.Exception</ExceptionType>            
<children>                          
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>971481b9-fe58-4359-8224-0116b0a8e62f</ShapeID>      <ParentLink>Catch_Statement</ParentLink>                <shapeText>Set Error Values</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>475bfceb-5371-40b3-b50f-16c2b82e7a41</ShapeID>      <ParentLink>Catch_Statement</ParentLink>                <shapeText>Construct Salesforce Error Event Request Msg</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>79b7e816-710a-42df-857c-5debfc9f2bf2</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>009f44d5-0357-4f35-b6e4-5794f99f4849</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>817c5a0e-4b78-47b2-a2d8-b9d5255ec144</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Set Orchestration Instance Id</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>5d2248c1-904d-46a1-9c3b-355bba5ea962</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Make Salesforce Error Event Request Request</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>b1ec5ae5-2c07-43c9-8469-d69ac79df521</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_4</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>dbbde609-2bac-4e33-b958-0360258cf09f</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_3</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>4106aacd-33cb-479f-8b44-232e66b9e456</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_5</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>10649756-929d-41f3-a8a1-8f06cc1b2f4b</ShapeID>      <ParentLink>Catch_Statement</ParentLink>                <shapeText>Send Event Request</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>5c3b0e9b-8101-4b41-bc15-609b40d5a312</ShapeID>      <ParentLink>Catch_Statement</ParentLink>                <shapeText>Receive Event Request Response</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>9e493c52-be5a-481b-85e0-e21489eab1be</ShapeID>      <ParentLink>Catch_Statement</ParentLink>                <shapeText>Extract Values</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionShape</shapeType>      <ShapeID>f9debd79-b06c-46ce-a384-bc55bd413bcd</ShapeID>      <ParentLink>Catch_Statement</ParentLink>                <shapeText>Valid Response</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>07fcb6cf-9740-410a-b769-b2668309c324</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>Error</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>1a4424d9-565a-408d-9e03-2b05c91b1e5f</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Rest Exception</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ThrowShape</shapeType>      <ShapeID>d7a17469-fb91-4abb-bb49-048be2261f38</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Rest Error </shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>TerminateShape</shapeType>      <ShapeID>76d93904-a54b-4ac6-977a-044ad0097968</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Terminate</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>b513f29b-10fa-473e-bdcd-b6f0fbd5df6b</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>Else</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow><Metadata>

<TrkMetadata>
<ActionName>'MultipleNotificationsDebatcherLogic'</ActionName><IsAtomic>0</IsAtomic><Line>537</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
</TrkMetadata>

<TrkMetadata>
<Line>568</Line><Position>22</Position><ShapeID>'f6e007f4-3bb3-4036-bbb7-0e245ea7f6ae'</ShapeID>
<Messages>
	<MsgInfo><name>SalesforceNotificationEventRequestMsg</name><part>MessagePart</part><schema>DLAPEventsSalesforceDefinition.NotificationService_outbound+notifications</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>583</Line><Position>13</Position><ShapeID>'7f1f71dd-956f-4521-be44-17aa12712f51'</ShapeID>
<Messages>
	<MsgInfo><name>SalesforceNotificationEventResponseMsg</name><part>MessagePart</part><schema>DLAPEventsSalesforceDefinition.NotificationService_outbound+notificationsResponse</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>SalesforceNotificationEventRequestMsg</name><part>MessagePart</part><schema>DLAPEventsSalesforceDefinition.NotificationService_outbound+notifications</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>589</Line><Position>13</Position><ShapeID>'38e2e0e4-5f34-41d3-9bf0-38e64b7a369b'</ShapeID>
<Messages>
	<MsgInfo><name>SalesforceNotificationEventResponseMsg</name><part>MessagePart</part><schema>DLAPEventsSalesforceDefinition.NotificationService_outbound+notificationsResponse</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<ActionName>'??__scope37'</ActionName><IsAtomic>0</IsAtomic><Line>591</Line><Position>13</Position><ShapeID>'6bcffe3a-d22b-41b6-a76f-513b7b2d6782'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>597</Line><Position>40</Position><ShapeID>'dbbf9ab3-c81a-4eb2-9f40-d67323361d1e'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>600</Line><Position>21</Position><ShapeID>'1a3485ab-55b5-47bd-a066-6bb49090ba80'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>603</Line><Position>25</Position><ShapeID>'28679b4b-f2e1-4080-850a-777a91bd502b'</ShapeID>
<Messages>
	<MsgInfo><name>SingleNotificationEventMsg</name><part>MessagePart</part><schema>DLAPEventsSalesforceDefinition.SingleNotificationEvent</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>622</Line><Position>25</Position><ShapeID>'6450dd8f-9039-44da-bad4-de431db9d143'</ShapeID>
<Messages>
	<MsgInfo><name>SingleNotificationEventMsg</name><part>MessagePart</part><schema>DLAPEventsSalesforceDefinition.SingleNotificationEvent</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>628</Line><Position>21</Position><ShapeID>'a71a4b01-c2df-4262-9775-b2c5daf7e3ef'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>631</Line><Position>25</Position><ShapeID>'971481b9-fe58-4359-8224-0116b0a8e62f'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>654</Line><Position>25</Position><ShapeID>'475bfceb-5371-40b3-b50f-16c2b82e7a41'</ShapeID>
<Messages>
	<MsgInfo><name>OrchestrationInstaceIdMsg</name><part>MessagePart</part><schema>DLAPEventsDefinition.OrchestrationInstanceId</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>RestBatchEventRequestMsg</name><part>MessagePart</part><schema>DLAPEventsSalesforceDefinition.RestEventRequest+SaveRequest</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>SalesforceNotificationEventRequestMsg</name><part>MessagePart</part><schema>DLAPEventsSalesforceDefinition.NotificationService_outbound+notifications</schema><direction>In</direction></MsgInfo>
	<MsgInfo><name>OrchestrationInstaceIdMsg</name><part>MessagePart</part><schema>DLAPEventsDefinition.OrchestrationInstanceId</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>678</Line><Position>25</Position><ShapeID>'10649756-929d-41f3-a8a1-8f06cc1b2f4b'</ShapeID>
<Messages>
	<MsgInfo><name>RestBatchEventRequestMsg</name><part>MessagePart</part><schema>DLAPEventsSalesforceDefinition.RestEventRequest+SaveRequest</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>680</Line><Position>25</Position><ShapeID>'5c3b0e9b-8101-4b41-bc15-609b40d5a312'</ShapeID>
<Messages>
	<MsgInfo><name>RestBatchEventResponseMsg</name><part>MessagePart</part><schema>DLAPEventsSalesforceDefinition.RestEventRequest+results</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>682</Line><Position>47</Position><ShapeID>'9e493c52-be5a-481b-85e0-e21489eab1be'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>686</Line><Position>25</Position><ShapeID>'f9debd79-b06c-46ce-a384-bc55bd413bcd'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>689</Line><Position>53</Position><ShapeID>'1a4424d9-565a-408d-9e03-2b05c91b1e5f'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>691</Line><Position>29</Position><ShapeID>'d7a17469-fb91-4abb-bb49-048be2261f38'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>693</Line><Position>29</Position><ShapeID>'76d93904-a54b-4ac6-977a-044ad0097968'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='b6ab2fba-a7f4-477d-b80a-74929797db1a' LowerBound='1.1' HigherBound='188.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='DLAPEvents' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='MultipartMessageType' OID='dd138897-a873-4b7c-b1b7-92bf85dd1117' ParentLink='Module_MessageType' LowerBound='4.1' HigherBound='8.1'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='SalesforceNotificationEventResponseType' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='PartDeclaration' OID='e6fb4774-5c05-473a-b553-02f6f7439e2d' ParentLink='MultipartMessageType_PartDeclaration' LowerBound='6.1' HigherBound='7.1'>
                <om:Property Name='ClassName' Value='DLAPEventsSalesforceDefinition.NotificationService_outbound.notificationsResponse' />
                <om:Property Name='IsBodyPart' Value='True' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='MessagePart' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
        </om:Element>
        <om:Element Type='MultipartMessageType' OID='86c28639-ba9b-474d-b7ee-89e2a8aef1d6' ParentLink='Module_MessageType' LowerBound='8.1' HigherBound='12.1'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='SalesforceNotificationEventRequestType' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='PartDeclaration' OID='edaeec2f-f6c3-402b-af82-87fc6506aeb0' ParentLink='MultipartMessageType_PartDeclaration' LowerBound='10.1' HigherBound='11.1'>
                <om:Property Name='ClassName' Value='DLAPEventsSalesforceDefinition.NotificationService_outbound.notifications' />
                <om:Property Name='IsBodyPart' Value='True' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='MessagePart' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
        </om:Element>
        <om:Element Type='MultipartMessageType' OID='4962e921-35c6-414e-95c7-dd4d50e22394' ParentLink='Module_MessageType' LowerBound='12.1' HigherBound='16.1'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='OrchestrationInstaceIdType' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='PartDeclaration' OID='4194f997-1c75-4e12-a62a-bde20a803969' ParentLink='MultipartMessageType_PartDeclaration' LowerBound='14.1' HigherBound='15.1'>
                <om:Property Name='ClassName' Value='DLAPEventsDefinition.OrchestrationInstanceId' />
                <om:Property Name='IsBodyPart' Value='True' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='MessagePart' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
        </om:Element>
        <om:Element Type='ServiceDeclaration' OID='53d8ac6a-8f45-4bbe-8518-22c1ce6cd9fe' ParentLink='Module_ServiceDeclaration' LowerBound='23.1' HigherBound='187.1'>
            <om:Property Name='InitializedTransactionType' Value='False' />
            <om:Property Name='IsInvokable' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='MultipleNotificationsDebatcherLogic' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='VariableDeclaration' OID='4ca4869e-b8d1-4127-bb81-42d3e76d5700' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='38.1' HigherBound='39.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.Int32' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='NotificationsCount' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='85a50314-bbf4-4816-9cb3-8e4ee2d917a8' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='39.1' HigherBound='40.1'>
                <om:Property Name='InitialValue' Value='1' />
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.Int32' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='LoopCount' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='4cc0974a-914b-4062-be30-144ad7f76f31' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='40.1' HigherBound='41.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SingleNotificationXpath' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='eb06deae-2f9c-41d0-a8e5-584f55532cf8' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='41.1' HigherBound='42.1'>
                <om:Property Name='UseDefaultConstructor' Value='True' />
                <om:Property Name='Type' Value='System.Xml.XmlDocument' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='TempNotificationSingleNode' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='fae638fb-49b8-4f02-8a91-a73c4d84f868' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='42.1' HigherBound='43.1'>
                <om:Property Name='UseDefaultConstructor' Value='True' />
                <om:Property Name='Type' Value='System.Xml.XmlDocument' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='TempSingleNotificationMsg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='6f733ff5-6708-4c56-8dab-ed2102fe6844' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='43.1' HigherBound='44.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ErrorMessage' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='dfdf0066-6aff-4b09-96a1-f0af64d40308' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='44.1' HigherBound='45.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='MessageTemp' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='97bffef9-abd4-4809-a659-0717644ce2b7' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='45.1' HigherBound='46.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ApplicationNumber' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='1787e1c2-8a1d-4729-a142-a5ea7627a3ad' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='46.1' HigherBound='47.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='OrchestrationInstanceId' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='7f40a9d3-2478-4c2c-8b4b-f616740c7de7' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='47.1' HigherBound='48.1'>
                <om:Property Name='UseDefaultConstructor' Value='True' />
                <om:Property Name='Type' Value='System.Xml.XmlDocument' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='TempOrchestrationInstanceMsg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='85bcd107-273a-431f-9668-6e6eb649927d' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='48.1' HigherBound='49.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='OrchestrationInstanceMsg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='ad810c14-b414-4273-8436-04dd205d82d0' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='49.1' HigherBound='50.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='RestBatchEventMessage' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='35ba93e1-f146-4de5-a769-dc3204281098' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='50.1' HigherBound='51.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='RestBatchEventSFID' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='d33e5866-4270-46b4-84de-eb99fbf53bfa' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='51.1' HigherBound='52.1'>
                <om:Property Name='UseDefaultConstructor' Value='True' />
                <om:Property Name='Type' Value='System.Exception' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='RestBatchEventException' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='ca878f5d-8da2-4668-93e8-a01e8bb4aeff' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='32.1' HigherBound='33.1'>
                <om:Property Name='Type' Value='DLAPEvents.RestEventResponseType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='RestBatchEventResponseMsg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='8f29802b-903c-4ab5-bf21-e62a9061e119' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='33.1' HigherBound='34.1'>
                <om:Property Name='Type' Value='DLAPEvents.RestEventRequestType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='RestBatchEventRequestMsg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='dc99b663-3e09-4732-aaf6-7209dddcddd8' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='34.1' HigherBound='35.1'>
                <om:Property Name='Type' Value='DLAPEvents.SingleNotificationEventType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SingleNotificationEventMsg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='9f9c0fdf-5553-40e7-8fc8-3d16205dbfcb' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='35.1' HigherBound='36.1'>
                <om:Property Name='Type' Value='DLAPEvents.SalesforceNotificationEventResponseType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SalesforceNotificationEventResponseMsg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='82adc4f5-fceb-4586-8060-fc9caeddbc78' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='36.1' HigherBound='37.1'>
                <om:Property Name='Type' Value='DLAPEvents.SalesforceNotificationEventRequestType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SalesforceNotificationEventRequestMsg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='12f55eb6-e54f-458d-9cc8-464d55a247a4' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='37.1' HigherBound='38.1'>
                <om:Property Name='Type' Value='DLAPEvents.OrchestrationInstaceIdType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='OrchestrationInstaceIdMsg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='ServiceBody' OID='7645620a-431c-4d10-b276-e64d96a6efae' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='Receive' OID='f6e007f4-3bb3-4036-bbb7-0e245ea7f6ae' ParentLink='ServiceBody_Statement' LowerBound='54.1' HigherBound='69.1'>
                    <om:Property Name='Activate' Value='True' />
                    <om:Property Name='PortName' Value='SalesforceNotificationMultipleEventPort' />
                    <om:Property Name='MessageName' Value='SalesforceNotificationEventRequestMsg' />
                    <om:Property Name='OperationName' Value='Operation' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Receive Multiple Salesforce Notification Request' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Construct' OID='7f1f71dd-956f-4521-be44-17aa12712f51' ParentLink='ServiceBody_Statement' LowerBound='69.1' HigherBound='75.1'>
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Construct SF Notification Ack Message ' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='Transform' OID='f1fd80c8-649a-4ba0-b0cd-4339644a07f6' ParentLink='ComplexStatement_Statement' LowerBound='72.1' HigherBound='74.1'>
                        <om:Property Name='ClassName' Value='DLAPEventsLogic.MakeSFNotificationAckMsg' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Make SF Notification Ack Msg' />
                        <om:Property Name='Signal' Value='False' />
                        <om:Element Type='MessagePartRef' OID='7d4e6e8b-957f-42d5-9fb4-794b022a1f4d' ParentLink='Transform_OutputMessagePartRef' LowerBound='73.28' HigherBound='73.78'>
                            <om:Property Name='MessageRef' Value='SalesforceNotificationEventResponseMsg' />
                            <om:Property Name='PartRef' Value='MessagePart' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='MessagePartReference_2' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                        <om:Element Type='MessagePartRef' OID='9eb70733-679c-4ce2-9042-e7f2c7cdef7e' ParentLink='Transform_InputMessagePartRef' LowerBound='73.124' HigherBound='73.173'>
                            <om:Property Name='MessageRef' Value='SalesforceNotificationEventRequestMsg' />
                            <om:Property Name='PartRef' Value='MessagePart' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='MessagePartReference_1' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='MessageRef' OID='ba6f27f8-bfa7-41c9-ac80-4b4e0269c7e9' ParentLink='Construct_MessageRef' LowerBound='70.23' HigherBound='70.61'>
                        <om:Property Name='Ref' Value='SalesforceNotificationEventResponseMsg' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                </om:Element>
                <om:Element Type='Send' OID='38e2e0e4-5f34-41d3-9bf0-38e64b7a369b' ParentLink='ServiceBody_Statement' LowerBound='75.1' HigherBound='77.1'>
                    <om:Property Name='PortName' Value='SalesforceNotificationMultipleEventPort' />
                    <om:Property Name='MessageName' Value='SalesforceNotificationEventResponseMsg' />
                    <om:Property Name='OperationName' Value='Operation' />
                    <om:Property Name='OperationMessageName' Value='Response' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Send SF Notification Ack Msg' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Scope' OID='6bcffe3a-d22b-41b6-a76f-513b7b2d6782' ParentLink='ServiceBody_Statement' LowerBound='77.1' HigherBound='185.1'>
                    <om:Property Name='InitializedTransactionType' Value='True' />
                    <om:Property Name='IsSynchronized' Value='False' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Debatch Scope' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='Task' OID='f9811e9c-b254-4304-8e96-c20329fa9194' ParentLink='ComplexStatement_Statement' LowerBound='82.1' HigherBound='111.1'>
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Debacting Multiple Notifications' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='VariableAssignment' OID='dbbf9ab3-c81a-4eb2-9f40-d67323361d1e' ParentLink='ComplexStatement_Statement' LowerBound='82.1' HigherBound='86.1'>
                            <om:Property Name='Expression' Value='&#xD;&#xA;NotificationsCount = System.Convert.ToInt32(xpath(SalesforceNotificationEventRequestMsg.MessagePart, &quot;count(/*[local-name()=&apos;notifications&apos; and namespace-uri()=&apos;http://soap.sforce.com/2005/09/outbound&apos;]/*[local-name()=&apos;Notification&apos; and namespace-uri()=&apos;http://soap.sforce.com/2005/09/outbound&apos;])&quot;));&#xD;&#xA;&#xD;&#xA;' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Notifications Count' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                        <om:Element Type='While' OID='1a3485ab-55b5-47bd-a066-6bb49090ba80' ParentLink='ComplexStatement_Statement' LowerBound='86.1' HigherBound='111.1'>
                            <om:Property Name='Expression' Value='LoopCount &lt;= NotificationsCount' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Loop Through Applications' />
                            <om:Property Name='Signal' Value='False' />
                            <om:Element Type='Construct' OID='28679b4b-f2e1-4080-850a-777a91bd502b' ParentLink='ComplexStatement_Statement' LowerBound='89.1' HigherBound='108.1'>
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Construct Single Notification Message' />
                                <om:Property Name='Signal' Value='True' />
                                <om:Element Type='MessageAssignment' OID='27ebbaf4-ad11-4089-ba43-4e84d190517a' ParentLink='ComplexStatement_Statement' LowerBound='92.1' HigherBound='107.1'>
                                    <om:Property Name='Expression' Value='&#xD;&#xA;//Extract Single Notification Request&#xD;&#xA;SingleNotificationXpath = System.String.Format(&quot;/*[local-name()=&apos;notifications&apos; and namespace-uri()=&apos;http://soap.sforce.com/2005/09/outbound&apos;]/*[local-name()=&apos;Notification&apos; and namespace-uri()=&apos;http://soap.sforce.com/2005/09/outbound&apos;][{0}]&quot;,LoopCount);&#xD;&#xA;TempNotificationSingleNode = xpath(SalesforceNotificationEventRequestMsg.MessagePart, SingleNotificationXpath);&#xD;&#xA;&#xD;&#xA;//Load Single Node Into Single Event Notification Message&#xD;&#xA;TempSingleNotificationMsg = new System.Xml.XmlDocument();&#xD;&#xA;TempSingleNotificationMsg.LoadXml(@&quot;&lt;ns0:Notifications xmlns:ns0=&apos;http://DLAPEventsSalesforceDefinition/SingleNotificationEvent&apos;&gt;&quot;+TempNotificationSingleNode.InnerXml+&quot;&lt;/ns0:Notifications&gt;&quot;);&#xD;&#xA;SingleNotificationEventMsg.MessagePart = TempSingleNotificationMsg;&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;//Loop Increment&#xD;&#xA;LoopCount = LoopCount + 1;' />
                                    <om:Property Name='ReportToAnalyst' Value='False' />
                                    <om:Property Name='Name' Value='MessageAssignment_1' />
                                    <om:Property Name='Signal' Value='True' />
                                </om:Element>
                                <om:Element Type='MessageRef' OID='9b82309b-b21d-45cb-bdf7-0ff72afc58bd' ParentLink='Construct_MessageRef' LowerBound='90.35' HigherBound='90.61'>
                                    <om:Property Name='Ref' Value='SingleNotificationEventMsg' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                            </om:Element>
                            <om:Element Type='Send' OID='6450dd8f-9039-44da-bad4-de431db9d143' ParentLink='ComplexStatement_Statement' LowerBound='108.1' HigherBound='110.1'>
                                <om:Property Name='PortName' Value='SalesforceNotificationSingleEventPort' />
                                <om:Property Name='MessageName' Value='SingleNotificationEventMsg' />
                                <om:Property Name='OperationName' Value='Operation' />
                                <om:Property Name='OperationMessageName' Value='Request' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Send Single Notification Message' />
                                <om:Property Name='Signal' Value='True' />
                            </om:Element>
                        </om:Element>
                    </om:Element>
                    <om:Element Type='Catch' OID='a71a4b01-c2df-4262-9775-b2c5daf7e3ef' ParentLink='Scope_Catch' LowerBound='114.1' HigherBound='183.1'>
                        <om:Property Name='ExceptionName' Value='DLAPEventSysEx' />
                        <om:Property Name='ExceptionType' Value='System.Exception' />
                        <om:Property Name='IsFaultMessage' Value='False' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='System Exception' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='VariableAssignment' OID='971481b9-fe58-4359-8224-0116b0a8e62f' ParentLink='Catch_Statement' LowerBound='117.1' HigherBound='140.1'>
                            <om:Property Name='Expression' Value='if(DLAPEventSysEx.InnerException != null)&#xD;&#xA;{&#xD;&#xA;MessageTemp = DLAPEventSysEx.InnerException.ToString();&#xD;&#xA;&#xD;&#xA;ErrorMessage = MessageTemp.Substring(0, System.Convert.ToInt32(System.Math.Min(900, MessageTemp.Length))) +&quot;Total String Length:&quot;+MessageTemp.Length.ToString();&#xD;&#xA;&#xD;&#xA;System.Diagnostics.EventLog.WriteEntry(&quot;DLAP Events Debacting Exception&quot;,ErrorMessage,System.Diagnostics.EventLogEntryType.Error);&#xD;&#xA;&#xD;&#xA;}&#xD;&#xA;&#xD;&#xA;else&#xD;&#xA;{&#xD;&#xA;MessageTemp = DLAPEventSysEx.Message.ToString();&#xD;&#xA;&#xD;&#xA;ErrorMessage = MessageTemp.Substring(0, System.Convert.ToInt32(System.Math.Min(900, MessageTemp.Length))) +&quot;Total String Length:&quot;+MessageTemp.Length.ToString();&#xD;&#xA;&#xD;&#xA;System.Diagnostics.EventLog.WriteEntry(&quot;DLAP Events Debacting Exception&quot;,ErrorMessage,System.Diagnostics.EventLogEntryType.Error);&#xD;&#xA;}&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Set Error Values' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                        <om:Element Type='Construct' OID='475bfceb-5371-40b3-b50f-16c2b82e7a41' ParentLink='Catch_Statement' LowerBound='140.1' HigherBound='164.1'>
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Construct Salesforce Error Event Request Msg' />
                            <om:Property Name='Signal' Value='True' />
                            <om:Element Type='MessageRef' OID='79b7e816-710a-42df-857c-5debfc9f2bf2' ParentLink='Construct_MessageRef' LowerBound='141.35' HigherBound='141.60'>
                                <om:Property Name='Ref' Value='OrchestrationInstaceIdMsg' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='MessageRef' OID='009f44d5-0357-4f35-b6e4-5794f99f4849' ParentLink='Construct_MessageRef' LowerBound='141.62' HigherBound='141.86'>
                                <om:Property Name='Ref' Value='RestBatchEventRequestMsg' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='MessageAssignment' OID='817c5a0e-4b78-47b2-a2d8-b9d5255ec144' ParentLink='ComplexStatement_Statement' LowerBound='143.1' HigherBound='161.1'>
                                <om:Property Name='Expression' Value='OrchestrationInstanceId = System.Convert.ToString(Microsoft.XLANGs.Core.Service.RootService.InstanceId);&#xD;&#xA;&#xD;&#xA;OrchestrationInstanceMsg = @&quot;&lt;ns1:Instance xmlns:ns1 =&apos;http://DLAPEventsDefinition.OrchestrationInstanceId&apos;&gt;&lt;Id&gt;&quot;+OrchestrationInstanceId+&quot;&lt;/Id&gt;&lt;ErrorMessage&gt;&quot;+ErrorMessage+&quot;&lt;/ErrorMessage&gt;&lt;/ns1:Instance&gt;&quot;;&#xD;&#xA;&#xD;&#xA;TempOrchestrationInstanceMsg = new System.Xml.XmlDocument();&#xD;&#xA;&#xD;&#xA;TempOrchestrationInstanceMsg.LoadXml(OrchestrationInstanceMsg);&#xD;&#xA;&#xD;&#xA;OrchestrationInstaceIdMsg.MessagePart = TempOrchestrationInstanceMsg; &#xD;&#xA;&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;' />
                                <om:Property Name='ReportToAnalyst' Value='False' />
                                <om:Property Name='Name' Value='Set Orchestration Instance Id' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='Transform' OID='5d2248c1-904d-46a1-9c3b-355bba5ea962' ParentLink='ComplexStatement_Statement' LowerBound='161.1' HigherBound='163.1'>
                                <om:Property Name='ClassName' Value='DLAPEventsLogic.MakeSalesforceErrorUpdateEventRequest' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Make Salesforce Error Event Request Request' />
                                <om:Property Name='Signal' Value='False' />
                                <om:Element Type='MessagePartRef' OID='b1ec5ae5-2c07-43c9-8469-d69ac79df521' ParentLink='Transform_OutputMessagePartRef' LowerBound='162.40' HigherBound='162.76'>
                                    <om:Property Name='MessageRef' Value='RestBatchEventRequestMsg' />
                                    <om:Property Name='PartRef' Value='MessagePart' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='MessagePartReference_4' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                                <om:Element Type='MessagePartRef' OID='dbbde609-2bac-4e33-b958-0360258cf09f' ParentLink='Transform_InputMessagePartRef' LowerBound='162.135' HigherBound='162.184'>
                                    <om:Property Name='MessageRef' Value='SalesforceNotificationEventRequestMsg' />
                                    <om:Property Name='PartRef' Value='MessagePart' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='MessagePartReference_3' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                                <om:Element Type='MessagePartRef' OID='4106aacd-33cb-479f-8b44-232e66b9e456' ParentLink='Transform_InputMessagePartRef' LowerBound='162.186' HigherBound='162.223'>
                                    <om:Property Name='MessageRef' Value='OrchestrationInstaceIdMsg' />
                                    <om:Property Name='PartRef' Value='MessagePart' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='MessagePartReference_5' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                            </om:Element>
                        </om:Element>
                        <om:Element Type='Send' OID='10649756-929d-41f3-a8a1-8f06cc1b2f4b' ParentLink='Catch_Statement' LowerBound='164.1' HigherBound='166.1'>
                            <om:Property Name='PortName' Value='RestEventRequestUpdatePort' />
                            <om:Property Name='MessageName' Value='RestBatchEventRequestMsg' />
                            <om:Property Name='OperationName' Value='Operation' />
                            <om:Property Name='OperationMessageName' Value='Request' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Send Event Request' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                        <om:Element Type='Receive' OID='5c3b0e9b-8101-4b41-bc15-609b40d5a312' ParentLink='Catch_Statement' LowerBound='166.1' HigherBound='168.1'>
                            <om:Property Name='Activate' Value='False' />
                            <om:Property Name='PortName' Value='RestEventRequestUpdatePort' />
                            <om:Property Name='MessageName' Value='RestBatchEventResponseMsg' />
                            <om:Property Name='OperationName' Value='Operation' />
                            <om:Property Name='OperationMessageName' Value='Response' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Receive Event Request Response' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                        <om:Element Type='VariableAssignment' OID='9e493c52-be5a-481b-85e0-e21489eab1be' ParentLink='Catch_Statement' LowerBound='168.1' HigherBound='172.1'>
                            <om:Property Name='Expression' Value='RestBatchEventMessage =  xpath(RestBatchEventResponseMsg.MessagePart,&quot;string(/*[local-name()=&apos;results&apos; and namespace-uri()=&apos;http://SBA.gov/DLAPEvents/REST/INSERT/EventRequest&apos;]/*[local-name()=&apos;result&apos; and namespace-uri()=&apos;http://SBA.gov/DLAPEvents/REST/INSERT/EventRequest&apos;]/*[local-name()=&apos;errors&apos; and namespace-uri()=&apos;http://SBA.gov/DLAPEvents/REST/INSERT/EventRequest&apos;]/*[local-name()=&apos;message&apos; and namespace-uri()=&apos;http://SBA.gov/DLAPEvents/REST/INSERT/EventRequest&apos;])&quot;);&#xD;&#xA;&#xD;&#xA;RestBatchEventSFID = xpath(RestBatchEventResponseMsg.MessagePart,&quot;string(/*[local-name()=&apos;results&apos; and namespace-uri()=&apos;http://SBA.gov/DLAPEvents/REST/INSERT/EventRequest&apos;]/*[local-name()=&apos;result&apos; and namespace-uri()=&apos;http://SBA.gov/DLAPEvents/REST/INSERT/EventRequest&apos;]/*[local-name()=&apos;id&apos; and namespace-uri()=&apos;http://SBA.gov/DLAPEvents/REST/INSERT/EventRequest&apos;])&quot;);' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Extract Values' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                        <om:Element Type='Decision' OID='f9debd79-b06c-46ce-a384-bc55bd413bcd' ParentLink='Catch_Statement' LowerBound='172.1' HigherBound='182.1'>
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Valid Response' />
                            <om:Property Name='Signal' Value='True' />
                            <om:Element Type='DecisionBranch' OID='07fcb6cf-9740-410a-b769-b2668309c324' ParentLink='ReallyComplexStatement_Branch' LowerBound='173.25' HigherBound='182.1'>
                                <om:Property Name='Expression' Value='!System.String.IsNullOrWhiteSpace(RestBatchEventMessage) &amp;&amp; (RestBatchEventSFID.Length == 0)' />
                                <om:Property Name='IsGhostBranch' Value='True' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Error' />
                                <om:Property Name='Signal' Value='False' />
                                <om:Element Type='VariableAssignment' OID='1a4424d9-565a-408d-9e03-2b05c91b1e5f' ParentLink='ComplexStatement_Statement' LowerBound='175.1' HigherBound='177.1'>
                                    <om:Property Name='Expression' Value='RestBatchEventException = new System.Exception(&quot;DLAP Events Batch Event Request Rest Exception  -  &quot; + RestBatchEventMessage);' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='Rest Exception' />
                                    <om:Property Name='Signal' Value='True' />
                                </om:Element>
                                <om:Element Type='Throw' OID='d7a17469-fb91-4abb-bb49-048be2261f38' ParentLink='ComplexStatement_Statement' LowerBound='177.1' HigherBound='179.1'>
                                    <om:Property Name='ThrownReference' Value='RestBatchEventException' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='Rest Error ' />
                                    <om:Property Name='Signal' Value='True' />
                                </om:Element>
                                <om:Element Type='Terminate' OID='76d93904-a54b-4ac6-977a-044ad0097968' ParentLink='ComplexStatement_Statement' LowerBound='179.1' HigherBound='181.1'>
                                    <om:Property Name='ErrorMessage' Value='&quot;An error occurred while processing the DLAP Events Debatching&quot;;' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='Terminate' />
                                    <om:Property Name='Signal' Value='True' />
                                </om:Element>
                            </om:Element>
                            <om:Element Type='DecisionBranch' OID='b513f29b-10fa-473e-bdcd-b6f0fbd5df6b' ParentLink='ReallyComplexStatement_Branch'>
                                <om:Property Name='IsGhostBranch' Value='True' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Else' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                        </om:Element>
                    </om:Element>
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='91f1ba1c-d2ed-4d0a-9e01-c91b048824e3' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='26.1' HigherBound='28.1'>
                <om:Property Name='PortModifier' Value='Implements' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='DLAPEvents.SalesforceNotificationMultipleEventPortType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SalesforceNotificationMultipleEventPort' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='feaa89d5-9683-466b-9b1e-f9a1af9824c2' ParentLink='PortDeclaration_CLRAttribute' LowerBound='26.1' HigherBound='27.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='8e3bbe24-2332-4cae-950d-65cdb8e9f639' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='28.1' HigherBound='30.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='40' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='DLAPEvents.SalesforceNotificationSingleEventPortType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SalesforceNotificationSingleEventPort' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='DirectBindingAttribute' OID='5bbc9d54-6a88-4fda-af99-40390fbe6c9d' ParentLink='PortDeclaration_CLRAttribute' LowerBound='28.1' HigherBound='29.1'>
                    <om:Property Name='PartnerPort' Value='SalesforceNotificationEventPort' />
                    <om:Property Name='PartnerService' Value='DLAPEvents.ProcessLogic' />
                    <om:Property Name='DirectBindingType' Value='PartnerPort' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='44c492a4-6c45-4141-aaa1-f6286923eabe' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='30.1' HigherBound='32.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='63' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='DLAPEvents.RestEventPortType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='RestEventRequestUpdatePort' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='2b704ab6-a7e0-4a78-81df-cc03226ca037' ParentLink='PortDeclaration_CLRAttribute' LowerBound='30.1' HigherBound='31.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='4bd490f9-d774-4002-8e1d-9dc2f229332e' ParentLink='Module_PortType' LowerBound='16.1' HigherBound='23.1'>
            <om:Property Name='Synchronous' Value='True' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='SalesforceNotificationMultipleEventPortType' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='OperationDeclaration' OID='b4d6cbbe-38d4-4fe3-b0d2-9f9ef01d7c15' ParentLink='PortType_OperationDeclaration' LowerBound='18.1' HigherBound='22.1'>
                <om:Property Name='OperationType' Value='RequestResponse' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='870dc2b7-6cec-4fe5-9001-2fdab1e6fa68' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='20.13' HigherBound='20.51'>
                    <om:Property Name='Ref' Value='DLAPEvents.SalesforceNotificationEventRequestType' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
                <om:Element Type='MessageRef' OID='ae8cbb1c-2830-408b-b326-d5f0dc17ef5f' ParentLink='OperationDeclaration_ResponseMessageRef' LowerBound='20.53' HigherBound='20.92'>
                    <om:Property Name='Ref' Value='DLAPEvents.SalesforceNotificationEventResponseType' />
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
        public class __MultipleNotificationsDebatcherLogic_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __MultipleNotificationsDebatcherLogic_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "MultipleNotificationsDebatcherLogic")
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
                MultipleNotificationsDebatcherLogic __svc__ = (MultipleNotificationsDebatcherLogic)_service;
                __MultipleNotificationsDebatcherLogic_root_0 __ctx0__ = (__MultipleNotificationsDebatcherLogic_root_0)(__svc__._stateMgrs[0]);

                if (__svc__.SalesforceNotificationSingleEventPort != null)
                {
                    __svc__.SalesforceNotificationSingleEventPort.Close(this, null);
                    __svc__.SalesforceNotificationSingleEventPort = null;
                }
                if (__svc__.RestEventRequestUpdatePort != null)
                {
                    __svc__.RestEventRequestUpdatePort.Close(this, null);
                    __svc__.RestEventRequestUpdatePort = null;
                }
                if (__svc__.SalesforceNotificationMultipleEventPort != null)
                {
                    __svc__.SalesforceNotificationMultipleEventPort.Close(this, null);
                    __svc__.SalesforceNotificationMultipleEventPort = null;
                }
                base.Finally();
            }

            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper0;
            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper1;
        }


        [System.SerializableAttribute]
        public class __MultipleNotificationsDebatcherLogic_1 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public __MultipleNotificationsDebatcherLogic_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "MultipleNotificationsDebatcherLogic")
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
                MultipleNotificationsDebatcherLogic __svc__ = (MultipleNotificationsDebatcherLogic)_service;
                __MultipleNotificationsDebatcherLogic_1 __ctx1__ = (__MultipleNotificationsDebatcherLogic_1)(__svc__._stateMgrs[1]);

                if (__ctx1__ != null)
                    __ctx1__.__RestBatchEventSFID = null;
                if (__ctx1__ != null)
                    __ctx1__.__RestBatchEventException = null;
                if (__ctx1__ != null)
                    __ctx1__.__ApplicationNumber = null;
                if (__ctx1__ != null && __ctx1__.__SalesforceNotificationEventResponseMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__SalesforceNotificationEventResponseMsg);
                    __ctx1__.__SalesforceNotificationEventResponseMsg = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__OrchestrationInstanceId = null;
                if (__ctx1__ != null)
                    __ctx1__.__TempOrchestrationInstanceMsg = null;
                if (__ctx1__ != null)
                    __ctx1__.__OrchestrationInstanceMsg = null;
                if (__ctx1__ != null)
                    __ctx1__.__TempNotificationSingleNode = null;
                if (__ctx1__ != null)
                    __ctx1__.__ErrorMessage = null;
                if (__ctx1__ != null)
                    __ctx1__.__MessageTemp = null;
                if (__ctx1__ != null)
                    __ctx1__.__TempSingleNotificationMsg = null;
                if (__ctx1__ != null)
                    __ctx1__.__SingleNotificationXpath = null;
                if (__ctx1__ != null)
                    __ctx1__.__RestBatchEventMessage = null;
                if (__ctx1__ != null && __ctx1__.__SalesforceNotificationEventRequestMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__SalesforceNotificationEventRequestMsg);
                    __ctx1__.__SalesforceNotificationEventRequestMsg = null;
                }
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("RestBatchEventResponseMsg")]
            internal RestEventResponseType __RestBatchEventResponseMsg;
            [Microsoft.XLANGs.Core.UserVariableAttribute("RestBatchEventRequestMsg")]
            internal RestEventRequestType __RestBatchEventRequestMsg;
            [Microsoft.XLANGs.Core.UserVariableAttribute("SingleNotificationEventMsg")]
            internal SingleNotificationEventType __SingleNotificationEventMsg;
            [Microsoft.XLANGs.Core.UserVariableAttribute("SalesforceNotificationEventResponseMsg")]
            internal SalesforceNotificationEventResponseType __SalesforceNotificationEventResponseMsg;
            [Microsoft.XLANGs.Core.UserVariableAttribute("SalesforceNotificationEventRequestMsg")]
            internal SalesforceNotificationEventRequestType __SalesforceNotificationEventRequestMsg;
            [Microsoft.XLANGs.Core.UserVariableAttribute("OrchestrationInstaceIdMsg")]
            internal OrchestrationInstaceIdType __OrchestrationInstaceIdMsg;
            [Microsoft.XLANGs.Core.UserVariableAttribute("NotificationsCount")]
            internal System.Int32 __NotificationsCount;
            [Microsoft.XLANGs.Core.UserVariableAttribute("LoopCount")]
            internal System.Int32 __LoopCount;
            [Microsoft.XLANGs.Core.UserVariableAttribute("SingleNotificationXpath")]
            internal System.String __SingleNotificationXpath;
            [Microsoft.XLANGs.Core.UserVariableAttribute("TempNotificationSingleNode")]
            internal Microsoft.XLANGs.RuntimeTypes.XmlDocumentSerializationProxy __TempNotificationSingleNode;
            [Microsoft.XLANGs.Core.UserVariableAttribute("TempSingleNotificationMsg")]
            internal Microsoft.XLANGs.RuntimeTypes.XmlDocumentSerializationProxy __TempSingleNotificationMsg;
            [Microsoft.XLANGs.Core.UserVariableAttribute("ErrorMessage")]
            internal System.String __ErrorMessage;
            [Microsoft.XLANGs.Core.UserVariableAttribute("MessageTemp")]
            internal System.String __MessageTemp;
            [Microsoft.XLANGs.Core.UserVariableAttribute("ApplicationNumber")]
            internal System.String __ApplicationNumber;
            [Microsoft.XLANGs.Core.UserVariableAttribute("OrchestrationInstanceId")]
            internal System.String __OrchestrationInstanceId;
            [Microsoft.XLANGs.Core.UserVariableAttribute("TempOrchestrationInstanceMsg")]
            internal Microsoft.XLANGs.RuntimeTypes.XmlDocumentSerializationProxy __TempOrchestrationInstanceMsg;
            [Microsoft.XLANGs.Core.UserVariableAttribute("OrchestrationInstanceMsg")]
            internal System.String __OrchestrationInstanceMsg;
            [Microsoft.XLANGs.Core.UserVariableAttribute("RestBatchEventMessage")]
            internal System.String __RestBatchEventMessage;
            [Microsoft.XLANGs.Core.UserVariableAttribute("RestBatchEventSFID")]
            internal System.String __RestBatchEventSFID;
            [Microsoft.XLANGs.Core.UserVariableAttribute("RestBatchEventException")]
            internal System.Exception __RestBatchEventException;
        }


        [System.SerializableAttribute]
        public class ____scope37_2 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public ____scope37_2(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "??__scope37")
            {
            }

            public override int Index { get { return 2; } }

            public override bool CombineParentCommit { get { return true; } }

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
                MultipleNotificationsDebatcherLogic __svc__ = (MultipleNotificationsDebatcherLogic)_service;
                ____scope37_2 __ctx2__ = (____scope37_2)(__svc__._stateMgrs[2]);
                __MultipleNotificationsDebatcherLogic_1 __ctx1__ = (__MultipleNotificationsDebatcherLogic_1)(__svc__._stateMgrs[1]);
                __MultipleNotificationsDebatcherLogic_root_0 __ctx0__ = (__MultipleNotificationsDebatcherLogic_root_0)(__svc__._stateMgrs[0]);

                if (__ctx2__ != null)
                    __ctx2__.__DLAPEventSysEx_0 = null;
                if (__ctx1__ != null && __ctx1__.__OrchestrationInstaceIdMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__OrchestrationInstaceIdMsg);
                    __ctx1__.__OrchestrationInstaceIdMsg = null;
                }
                if (__ctx1__ != null && __ctx1__.__SingleNotificationEventMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__SingleNotificationEventMsg);
                    __ctx1__.__SingleNotificationEventMsg = null;
                }
                if (__ctx1__ != null && __ctx1__.__RestBatchEventRequestMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__RestBatchEventRequestMsg);
                    __ctx1__.__RestBatchEventRequestMsg = null;
                }
                if (__ctx1__ != null && __ctx1__.__RestBatchEventResponseMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__RestBatchEventResponseMsg);
                    __ctx1__.__RestBatchEventResponseMsg = null;
                }
                if (__ctx0__ != null && __ctx0__.__subWrapper1 != null)
                {
                    __ctx0__.__subWrapper1.Destroy(__svc__, __ctx0__);
                    __ctx0__.__subWrapper1 = null;
                }
                base.Finally();
            }

            internal object __exv__;
            internal System.Exception __DLAPEventSysEx_0
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
        [Microsoft.XLANGs.Core.UserVariableAttribute("SalesforceNotificationMultipleEventPort")]
        internal SalesforceNotificationMultipleEventPortType SalesforceNotificationMultipleEventPort;
        [Microsoft.XLANGs.BaseTypes.DirectBindingAttribute(typeof(ProcessLogic), "SalesforceNotificationEventPort")]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("SalesforceNotificationSingleEventPort")]
        internal SalesforceNotificationSingleEventPortType SalesforceNotificationSingleEventPort;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("RestEventRequestUpdatePort")]
        internal RestEventPortType RestEventRequestUpdatePort;

        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {SalesforceNotificationMultipleEventPortType.Operation},
                                               typeof(MultipleNotificationsDebatcherLogic).GetField("SalesforceNotificationMultipleEventPort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.implements,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(MultipleNotificationsDebatcherLogic), "SalesforceNotificationMultipleEventPort"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {SalesforceNotificationSingleEventPortType.Operation},
                                               typeof(MultipleNotificationsDebatcherLogic).GetField("SalesforceNotificationSingleEventPort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(MultipleNotificationsDebatcherLogic), "SalesforceNotificationSingleEventPort"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {RestEventPortType.Operation},
                                               typeof(MultipleNotificationsDebatcherLogic).GetField("RestEventRequestUpdatePort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(MultipleNotificationsDebatcherLogic), "RestEventRequestUpdatePort"),
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
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "f6e007f4-3bb3-4036-bbb7-0e245ea7f6ae", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "f6e007f4-3bb3-4036-bbb7-0e245ea7f6ae", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "00000000-0000-0000-0000-000000000000", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "7f1f71dd-956f-4521-be44-17aa12712f51", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "7f1f71dd-956f-4521-be44-17aa12712f51", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(6, "38e2e0e4-5f34-41d3-9bf0-38e64b7a369b", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(7, "38e2e0e4-5f34-41d3-9bf0-38e64b7a369b", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(8, "6bcffe3a-d22b-41b6-a76f-513b7b2d6782", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(9, "00000000-0000-0000-0000-000000000000", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(10, "dbbf9ab3-c81a-4eb2-9f40-d67323361d1e", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(11, "dbbf9ab3-c81a-4eb2-9f40-d67323361d1e", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(12, "1a3485ab-55b5-47bd-a066-6bb49090ba80", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(13, "28679b4b-f2e1-4080-850a-777a91bd502b", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(14, "28679b4b-f2e1-4080-850a-777a91bd502b", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(15, "6450dd8f-9039-44da-bad4-de431db9d143", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(16, "6450dd8f-9039-44da-bad4-de431db9d143", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(17, "1a3485ab-55b5-47bd-a066-6bb49090ba80", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(18, "a71a4b01-c2df-4262-9775-b2c5daf7e3ef", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(19, "971481b9-fe58-4359-8224-0116b0a8e62f", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(20, "00000000-0000-0000-0000-000000000000", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(21, "00000000-0000-0000-0000-000000000000", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(22, "971481b9-fe58-4359-8224-0116b0a8e62f", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(23, "475bfceb-5371-40b3-b50f-16c2b82e7a41", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(24, "475bfceb-5371-40b3-b50f-16c2b82e7a41", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(25, "10649756-929d-41f3-a8a1-8f06cc1b2f4b", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(26, "10649756-929d-41f3-a8a1-8f06cc1b2f4b", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(27, "5c3b0e9b-8101-4b41-bc15-609b40d5a312", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(28, "5c3b0e9b-8101-4b41-bc15-609b40d5a312", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(29, "9e493c52-be5a-481b-85e0-e21489eab1be", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(30, "9e493c52-be5a-481b-85e0-e21489eab1be", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(31, "f9debd79-b06c-46ce-a384-bc55bd413bcd", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(32, "1a4424d9-565a-408d-9e03-2b05c91b1e5f", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(33, "1a4424d9-565a-408d-9e03-2b05c91b1e5f", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(34, "d7a17469-fb91-4abb-bb49-048be2261f38", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(35, "76d93904-a54b-4ac6-977a-044ad0097968", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(36, "f9debd79-b06c-46ce-a384-bc55bd413bcd", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(37, "a71a4b01-c2df-4262-9775-b2c5daf7e3ef", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(38, "6bcffe3a-d22b-41b6-a76f-513b7b2d6782", 1, false)
        };

        public override Microsoft.XLANGs.RuntimeTypes.Location[] EventLocations
        {
            get { return __eventLocations; }
        }

        public static Microsoft.XLANGs.RuntimeTypes.EventData[] __eventData = new Microsoft.XLANGs.RuntimeTypes.EventData[] {
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Body),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Receive),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Construct),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Send),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Scope),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Expression),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Expression),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.WhileBody),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.While),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.While),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.WhileBody),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Catch),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.If),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.If),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Throw),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Terminate),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Catch),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Scope),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Body)
        };

        public static int[] __progressLocation0 = new int[] { 0,0,0,3,3,};
        public static int[] __progressLocation1 = new int[] { 0,0,1,1,2,2,2,2,2,2,2,2,2,2,2,2,2,2,4,4,5,6,6,6,7,8,8,8,38,3,3,3,3,};
        public static int[] __progressLocation2 = new int[] { 10,10,10,11,12,12,12,13,13,14,15,15,15,16,17,17,17,17,17,17,};
        public static int[] __progressLocation3 = new int[] { 18,18,19,19,19,19,19,19,19,19,19,22,23,23,24,25,25,25,26,27,27,28,29,29,30,30,31,31,32,32,33,34,34,35,35,36,37,37,};

        public static int[][] __progressLocations = new int[4] [] {__progressLocation0,__progressLocation1,__progressLocation2,__progressLocation3};
        public override int[][] ProgressLocations {get {return __progressLocations;} }

        public Microsoft.XLANGs.Core.StopConditions segment0(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[0];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[0];
            __MultipleNotificationsDebatcherLogic_1 __ctx1__ = (__MultipleNotificationsDebatcherLogic_1)_stateMgrs[1];
            __MultipleNotificationsDebatcherLogic_root_0 __ctx0__ = (__MultipleNotificationsDebatcherLogic_root_0)_stateMgrs[0];

            switch (__seg__.Progress)
            {
            case 0:
                SalesforceNotificationMultipleEventPort = new SalesforceNotificationMultipleEventPortType(0, this);
                SalesforceNotificationSingleEventPort = new SalesforceNotificationSingleEventPortType(1, this);
                RestEventRequestUpdatePort = new RestEventPortType(2, this);
                __ctx__.PrologueCompleted = true;
                __ctx0__.__subWrapper0 = new Microsoft.XLANGs.Core.SubscriptionWrapper(ActivationSubGuids[0], SalesforceNotificationMultipleEventPort, this);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.Initialized) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.Initialized;
                goto case 1;
            case 1:
                __ctx1__ = new __MultipleNotificationsDebatcherLogic_1(this);
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
            ____scope37_2 __ctx2__ = (____scope37_2)_stateMgrs[2];
            __MultipleNotificationsDebatcherLogic_1 __ctx1__ = (__MultipleNotificationsDebatcherLogic_1)_stateMgrs[1];
            __MultipleNotificationsDebatcherLogic_root_0 __ctx0__ = (__MultipleNotificationsDebatcherLogic_root_0)_stateMgrs[0];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx1__.__NotificationsCount = default(System.Int32);
                __ctx1__.__LoopCount = default(System.Int32);
                __ctx1__.__SingleNotificationXpath = default(System.String);
                __ctx1__.__TempNotificationSingleNode = new Microsoft.XLANGs.RuntimeTypes.XmlDocumentSerializationProxy();
                __ctx1__.__TempSingleNotificationMsg = new Microsoft.XLANGs.RuntimeTypes.XmlDocumentSerializationProxy();
                __ctx1__.__ErrorMessage = default(System.String);
                __ctx1__.__MessageTemp = default(System.String);
                __ctx1__.__ApplicationNumber = default(System.String);
                __ctx1__.__OrchestrationInstanceId = default(System.String);
                __ctx1__.__TempOrchestrationInstanceMsg = new Microsoft.XLANGs.RuntimeTypes.XmlDocumentSerializationProxy();
                __ctx1__.__OrchestrationInstanceMsg = default(System.String);
                __ctx1__.__RestBatchEventMessage = default(System.String);
                __ctx1__.__RestBatchEventSFID = default(System.String);
                __ctx1__.__RestBatchEventException = default(System.Exception);
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
                if (!SalesforceNotificationMultipleEventPort.GetMessageId(__ctx0__.__subWrapper0.getSubscription(this), __seg__, __ctx1__, out __msgEnv__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx1__.__SalesforceNotificationEventRequestMsg != null)
                    __ctx1__.UnrefMessage(__ctx1__.__SalesforceNotificationEventRequestMsg);
                __ctx1__.__SalesforceNotificationEventRequestMsg = new SalesforceNotificationEventRequestType("SalesforceNotificationEventRequestMsg", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__SalesforceNotificationEventRequestMsg);
                SalesforceNotificationMultipleEventPort.ReceiveMessage(0, __msgEnv__, __ctx1__.__SalesforceNotificationEventRequestMsg, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__SalesforceNotificationEventRequestMsg);
                    __edata.PortName = @"SalesforceNotificationMultipleEventPort";
                    Tracker.FireEvent(__eventLocations[2],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                __ctx1__.__LoopCount = 1;
                if ( !PostProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 6;
            case 6:
                __ctx1__.__SingleNotificationXpath = "";
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                __ctx1__.__TempNotificationSingleNode.UnderlyingXmlDocument = new System.Xml.XmlDocument();
                if ( !PostProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 8;
            case 8:
                __ctx1__.__TempSingleNotificationMsg.UnderlyingXmlDocument = new System.Xml.XmlDocument();
                if ( !PostProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 9;
            case 9:
                __ctx1__.__ErrorMessage = "";
                if ( !PostProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 10;
            case 10:
                __ctx1__.__MessageTemp = "";
                if ( !PostProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 11;
            case 11:
                __ctx1__.__ApplicationNumber = "";
                if (__ctx1__ != null)
                    __ctx1__.__ApplicationNumber = null;
                if ( !PostProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 12;
            case 12:
                __ctx1__.__OrchestrationInstanceId = "";
                if ( !PostProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 13;
            case 13:
                __ctx1__.__TempOrchestrationInstanceMsg.UnderlyingXmlDocument = new System.Xml.XmlDocument();
                if ( !PostProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 14;
            case 14:
                __ctx1__.__OrchestrationInstanceMsg = "";
                if ( !PostProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 15;
            case 15:
                __ctx1__.__RestBatchEventMessage = "";
                if ( !PostProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 16;
            case 16:
                __ctx1__.__RestBatchEventSFID = "";
                if ( !PostProgressInc( __seg__, __ctx__, 17 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 17;
            case 17:
                __ctx1__.__RestBatchEventException = new System.Exception();
                if ( !PostProgressInc( __seg__, __ctx__, 18 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 18;
            case 18:
                if ( !PreProgressInc( __seg__, __ctx__, 19 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[4],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 19;
            case 19:
                {
                    SalesforceNotificationEventResponseType __SalesforceNotificationEventResponseMsg = new SalesforceNotificationEventResponseType("SalesforceNotificationEventResponseMsg", __ctx1__);

                    ApplyTransform(typeof(DLAPEventsLogic.MakeSFNotificationAckMsg), new object[] {__SalesforceNotificationEventResponseMsg.MessagePart}, new object[] {__ctx1__.__SalesforceNotificationEventRequestMsg.MessagePart});

                    if (__ctx1__.__SalesforceNotificationEventResponseMsg != null)
                        __ctx1__.UnrefMessage(__ctx1__.__SalesforceNotificationEventResponseMsg);
                    __ctx1__.__SalesforceNotificationEventResponseMsg = __SalesforceNotificationEventResponseMsg;
                    __ctx1__.RefMessage(__ctx1__.__SalesforceNotificationEventResponseMsg);
                }
                __ctx1__.__SalesforceNotificationEventResponseMsg.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 20 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 20;
            case 20:
                if ( !PreProgressInc( __seg__, __ctx__, 21 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__SalesforceNotificationEventResponseMsg);
                    __edata.Messages.Add(__ctx1__.__SalesforceNotificationEventRequestMsg);
                    Tracker.FireEvent(__eventLocations[5],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 21;
            case 21:
                if ( !PreProgressInc( __seg__, __ctx__, 22 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[6],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 22;
            case 22:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 23 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 23;
            case 23:
                if ( !PreProgressInc( __seg__, __ctx__, 24 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                SalesforceNotificationMultipleEventPort.SendMessage(0, __ctx1__.__SalesforceNotificationEventResponseMsg, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.None );
                if (SalesforceNotificationMultipleEventPort != null)
                {
                    SalesforceNotificationMultipleEventPort.Close(__ctx1__, __seg__);
                    SalesforceNotificationMultipleEventPort = null;
                }
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingResp) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingResp;
                goto case 24;
            case 24:
                if ( !PreProgressInc( __seg__, __ctx__, 25 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__SalesforceNotificationEventResponseMsg);
                    __edata.PortName = @"SalesforceNotificationMultipleEventPort";
                    Tracker.FireEvent(__eventLocations[7],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__SalesforceNotificationEventResponseMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__SalesforceNotificationEventResponseMsg);
                    __ctx1__.__SalesforceNotificationEventResponseMsg = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 25;
            case 25:
                if ( !PreProgressInc( __seg__, __ctx__, 26 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[8],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 26;
            case 26:
                __ctx2__ = new ____scope37_2(this);
                _stateMgrs[2] = __ctx2__;
                if ( !PostProgressInc( __seg__, __ctx__, 27 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 27;
            case 27:
                __ctx1__.StartContext(__seg__, __ctx2__);
                if ( !PostProgressInc( __seg__, __ctx__, 28 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 28:
                if ( !PreProgressInc( __seg__, __ctx__, 29 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if (__ctx1__ != null)
                    __ctx1__.__RestBatchEventException = null;
                if (__ctx1__ != null)
                    __ctx1__.__RestBatchEventSFID = null;
                if (__ctx1__ != null)
                    __ctx1__.__RestBatchEventMessage = null;
                if (__ctx1__ != null)
                    __ctx1__.__OrchestrationInstanceMsg = null;
                if (__ctx1__ != null)
                    __ctx1__.__TempOrchestrationInstanceMsg = null;
                if (__ctx1__ != null)
                    __ctx1__.__OrchestrationInstanceId = null;
                if (__ctx1__ != null)
                    __ctx1__.__MessageTemp = null;
                if (__ctx1__ != null)
                    __ctx1__.__ErrorMessage = null;
                if (__ctx1__ != null)
                    __ctx1__.__TempSingleNotificationMsg = null;
                if (__ctx1__ != null)
                    __ctx1__.__TempNotificationSingleNode = null;
                if (__ctx1__ != null)
                    __ctx1__.__SingleNotificationXpath = null;
                if (__ctx1__ != null && __ctx1__.__SalesforceNotificationEventRequestMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__SalesforceNotificationEventRequestMsg);
                    __ctx1__.__SalesforceNotificationEventRequestMsg = null;
                }
                if (RestEventRequestUpdatePort != null)
                {
                    RestEventRequestUpdatePort.Close(__ctx1__, __seg__);
                    RestEventRequestUpdatePort = null;
                }
                if (SalesforceNotificationSingleEventPort != null)
                {
                    SalesforceNotificationSingleEventPort.Close(__ctx1__, __seg__);
                    SalesforceNotificationSingleEventPort = null;
                }
                Tracker.FireEvent(__eventLocations[38],__eventData[17],_stateMgrs[1].TrackDataStream );
                __ctx2__.Finally();
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 29;
            case 29:
                if ( !PreProgressInc( __seg__, __ctx__, 30 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[3],__eventData[18],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 30;
            case 30:
                if (!__ctx1__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 31 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 31;
            case 31:
                if ( !PreProgressInc( __seg__, __ctx__, 32 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx1__.OnCommit();
                goto case 32;
            case 32:
                __seg__.SegmentDone();
                _segments[0].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment2(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            bool __condition__;
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[2];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[2];
            ____scope37_2 __ctx2__ = (____scope37_2)_stateMgrs[2];
            __MultipleNotificationsDebatcherLogic_1 __ctx1__ = (__MultipleNotificationsDebatcherLogic_1)_stateMgrs[1];
            __MultipleNotificationsDebatcherLogic_root_0 __ctx0__ = (__MultipleNotificationsDebatcherLogic_root_0)_stateMgrs[0];

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
                Tracker.FireEvent(__eventLocations[10],__eventData[5],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 2;
            case 2:
                __ctx1__.__NotificationsCount = System.Convert.ToInt32(Microsoft.XLANGs.Core.Part.XPathLoad(__ctx1__.__SalesforceNotificationEventRequestMsg.MessagePart, "count(/*[local-name()='notifications' and namespace-uri()='http://soap.sforce.com/2005/09/outbound']/*[local-name()='Notification' and namespace-uri()='http://soap.sforce.com/2005/09/outbound'])", typeof(System.Object)));
                if ( !PostProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 3;
            case 3:
                if ( !PreProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[11],__eventData[6],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[12],__eventData[7],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                __condition__ = __ctx1__.__LoopCount <= __ctx1__.__NotificationsCount;
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 16 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 16;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 6;
            case 6:
                if ( !PreProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[12],__eventData[8],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 7;
            case 7:
                if ( !PreProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[13],__eventData[2],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 8;
            case 8:
                {
                    SingleNotificationEventType __SingleNotificationEventMsg = new SingleNotificationEventType("SingleNotificationEventMsg", __ctx1__);

                    __ctx1__.__SingleNotificationXpath = System.String.Format("/*[local-name()='notifications' and namespace-uri()='http://soap.sforce.com/2005/09/outbound']/*[local-name()='Notification' and namespace-uri()='http://soap.sforce.com/2005/09/outbound'][{0}]", __ctx1__.__LoopCount);
                    __ctx1__.__TempNotificationSingleNode.UnderlyingXmlDocument = (System.Xml.XmlDocument)Microsoft.XLANGs.Core.Part.XPathLoad(__ctx1__.__SalesforceNotificationEventRequestMsg.MessagePart, __ctx1__.__SingleNotificationXpath, typeof(System.Xml.XmlDocument));
                    __ctx1__.__TempSingleNotificationMsg.UnderlyingXmlDocument = new System.Xml.XmlDocument();
                    __ctx1__.__TempSingleNotificationMsg.UnderlyingXmlDocument.LoadXml(@"<ns0:Notifications xmlns:ns0='http://DLAPEventsSalesforceDefinition/SingleNotificationEvent'>" + __ctx1__.__TempNotificationSingleNode.UnderlyingXmlDocument.InnerXml + "</ns0:Notifications>");
                    __SingleNotificationEventMsg.MessagePart.LoadFrom((System.Xml.XmlDocument)__ctx1__.__TempSingleNotificationMsg.UnderlyingXmlDocument);
                    __ctx1__.__LoopCount = __ctx1__.__LoopCount + 1;

                    if (__ctx1__.__SingleNotificationEventMsg != null)
                        __ctx1__.UnrefMessage(__ctx1__.__SingleNotificationEventMsg);
                    __ctx1__.__SingleNotificationEventMsg = __SingleNotificationEventMsg;
                    __ctx1__.RefMessage(__ctx1__.__SingleNotificationEventMsg);
                }
                __ctx1__.__SingleNotificationEventMsg.ConstructionCompleteEvent(false);
                if ( !PostProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 9;
            case 9:
                if ( !PreProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__SingleNotificationEventMsg);
                    Tracker.FireEvent(__eventLocations[14],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 10;
            case 10:
                if ( !PreProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[15],__eventData[3],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 11;
            case 11:
                if (!__ctx2__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 12;
            case 12:
                if ( !PreProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                SalesforceNotificationSingleEventPort.SendMessage(0, __ctx1__.__SingleNotificationEventMsg, null, null, __ctx2__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.None );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 13;
            case 13:
                if ( !PreProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__SingleNotificationEventMsg);
                    __edata.PortName = @"SalesforceNotificationSingleEventPort";
                    Tracker.FireEvent(__eventLocations[16],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__SingleNotificationEventMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__SingleNotificationEventMsg);
                    __ctx1__.__SingleNotificationEventMsg = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 14;
            case 14:
                if ( !PreProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[17],__eventData[9],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 15;
            case 15:
                if ( !PostProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 5;
            case 16:
                if ( !PreProgressInc( __seg__, __ctx__, 17 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[17],__eventData[10],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 17;
            case 17:
                if (!__ctx2__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 18 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 18;
            case 18:
                if ( !PreProgressInc( __seg__, __ctx__, 19 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx2__.OnCommit();
                goto case 19;
            case 19:
                __seg__.SegmentDone();
                _segments[1].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment3(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Envelope __msgEnv__ = null;
            bool __condition__;
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[3];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[2];
            ____scope37_2 __ctx2__ = (____scope37_2)_stateMgrs[2];
            __MultipleNotificationsDebatcherLogic_1 __ctx1__ = (__MultipleNotificationsDebatcherLogic_1)_stateMgrs[1];
            __MultipleNotificationsDebatcherLogic_root_0 __ctx0__ = (__MultipleNotificationsDebatcherLogic_root_0)_stateMgrs[0];

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
                Tracker.FireEvent(__eventLocations[18],__eventData[11],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[19],__eventData[12],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 3;
            case 3:
                __condition__ = __ctx2__.__DLAPEventSysEx_0.InnerException != null;
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
                __ctx1__.__MessageTemp = __ctx2__.__DLAPEventSysEx_0.InnerException.ToString();
                if ( !PostProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 5;
            case 5:
                __ctx1__.__ErrorMessage = __ctx1__.__MessageTemp.Substring(0, System.Convert.ToInt32(System.Math.Min(900U, __ctx1__.__MessageTemp.Length))) + "Total String Length:" + __ctx1__.__MessageTemp.Length.ToString();
                if ( !PostProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 6;
            case 6:
                System.Diagnostics.EventLog.WriteEntry("DLAP Events Debacting Exception", __ctx1__.__ErrorMessage, System.Diagnostics.EventLogEntryType.Error);
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                if ( !PostProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 11;
            case 8:
                __ctx1__.__MessageTemp = __ctx2__.__DLAPEventSysEx_0.Message.ToString();
                if ( !PostProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 9;
            case 9:
                __ctx1__.__ErrorMessage = __ctx1__.__MessageTemp.Substring(0, System.Convert.ToInt32(System.Math.Min(900U, __ctx1__.__MessageTemp.Length))) + "Total String Length:" + __ctx1__.__MessageTemp.Length.ToString();
                if ( !PostProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 10;
            case 10:
                System.Diagnostics.EventLog.WriteEntry("DLAP Events Debacting Exception", __ctx1__.__ErrorMessage, System.Diagnostics.EventLogEntryType.Error);
                if ( !PostProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 11;
            case 11:
                if ( !PreProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if (__ctx2__ != null)
                    __ctx2__.__DLAPEventSysEx_0 = null;
                Tracker.FireEvent(__eventLocations[22],__eventData[13],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 12;
            case 12:
                if ( !PreProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[23],__eventData[2],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 13;
            case 13:
                {
                    OrchestrationInstaceIdType __OrchestrationInstaceIdMsg = new OrchestrationInstaceIdType("OrchestrationInstaceIdMsg", __ctx1__);
                    RestEventRequestType __RestBatchEventRequestMsg = new RestEventRequestType("RestBatchEventRequestMsg", __ctx1__);

                    __ctx1__.__OrchestrationInstanceId = System.Convert.ToString(Microsoft.XLANGs.Core.Service.RootService.InstanceId);
                    __ctx1__.__OrchestrationInstanceMsg = @"<ns1:Instance xmlns:ns1 ='http://DLAPEventsDefinition.OrchestrationInstanceId'><Id>" + __ctx1__.__OrchestrationInstanceId + "</Id><ErrorMessage>" + __ctx1__.__ErrorMessage + "</ErrorMessage></ns1:Instance>";
                    __ctx1__.__TempOrchestrationInstanceMsg.UnderlyingXmlDocument = new System.Xml.XmlDocument();
                    __ctx1__.__TempOrchestrationInstanceMsg.UnderlyingXmlDocument.LoadXml(__ctx1__.__OrchestrationInstanceMsg);
                    __OrchestrationInstaceIdMsg.MessagePart.LoadFrom((System.Xml.XmlDocument)__ctx1__.__TempOrchestrationInstanceMsg.UnderlyingXmlDocument);
                    ApplyTransform(typeof(DLAPEventsLogic.MakeSalesforceErrorUpdateEventRequest), new object[] {__RestBatchEventRequestMsg.MessagePart}, new object[] {__ctx1__.__SalesforceNotificationEventRequestMsg.MessagePart, __OrchestrationInstaceIdMsg.MessagePart});

                    if (__ctx1__.__OrchestrationInstaceIdMsg != null)
                        __ctx1__.UnrefMessage(__ctx1__.__OrchestrationInstaceIdMsg);
                    __ctx1__.__OrchestrationInstaceIdMsg = __OrchestrationInstaceIdMsg;
                    __ctx1__.RefMessage(__ctx1__.__OrchestrationInstaceIdMsg);
                    if (__ctx1__.__RestBatchEventRequestMsg != null)
                        __ctx1__.UnrefMessage(__ctx1__.__RestBatchEventRequestMsg);
                    __ctx1__.__RestBatchEventRequestMsg = __RestBatchEventRequestMsg;
                    __ctx1__.RefMessage(__ctx1__.__RestBatchEventRequestMsg);
                }
                __ctx1__.__OrchestrationInstaceIdMsg.ConstructionCompleteEvent(true);
                __ctx1__.__RestBatchEventRequestMsg.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 14;
            case 14:
                if ( !PreProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__OrchestrationInstaceIdMsg);
                    __edata.Messages.Add(__ctx1__.__RestBatchEventRequestMsg);
                    __edata.Messages.Add(__ctx1__.__SalesforceNotificationEventRequestMsg);
                    Tracker.FireEvent(__eventLocations[24],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__OrchestrationInstaceIdMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__OrchestrationInstaceIdMsg);
                    __ctx1__.__OrchestrationInstaceIdMsg = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 15;
            case 15:
                if ( !PreProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[25],__eventData[3],_stateMgrs[2].TrackDataStream );
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
                RestEventRequestUpdatePort.SendMessage(0, __ctx1__.__RestBatchEventRequestMsg, null, null, out __ctx0__.__subWrapper1, __ctx2__, __seg__ );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 18;
            case 18:
                if ( !PreProgressInc( __seg__, __ctx__, 19 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__RestBatchEventRequestMsg);
                    __edata.PortName = @"RestEventRequestUpdatePort";
                    Tracker.FireEvent(__eventLocations[26],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__RestBatchEventRequestMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__RestBatchEventRequestMsg);
                    __ctx1__.__RestBatchEventRequestMsg = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 19;
            case 19:
                if ( !PreProgressInc( __seg__, __ctx__, 20 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[27],__eventData[1],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 20;
            case 20:
                if (!RestEventRequestUpdatePort.GetMessageId(__ctx0__.__subWrapper1.getSubscription(this), __seg__, __ctx1__, out __msgEnv__, _locations[0]))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx0__ != null && __ctx0__.__subWrapper1 != null)
                {
                    __ctx0__.__subWrapper1.Destroy(this, __ctx0__);
                    __ctx0__.__subWrapper1 = null;
                }
                if (__ctx1__.__RestBatchEventResponseMsg != null)
                    __ctx1__.UnrefMessage(__ctx1__.__RestBatchEventResponseMsg);
                __ctx1__.__RestBatchEventResponseMsg = new RestEventResponseType("RestBatchEventResponseMsg", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__RestBatchEventResponseMsg);
                RestEventRequestUpdatePort.ReceiveMessage(0, __msgEnv__, __ctx1__.__RestBatchEventResponseMsg, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[2], __seg__);
                if ( !PostProgressInc( __seg__, __ctx__, 21 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 21;
            case 21:
                if ( !PreProgressInc( __seg__, __ctx__, 22 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__RestBatchEventResponseMsg);
                    __edata.PortName = @"RestEventRequestUpdatePort";
                    Tracker.FireEvent(__eventLocations[28],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 22;
            case 22:
                if ( !PreProgressInc( __seg__, __ctx__, 23 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[29],__eventData[5],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 23;
            case 23:
                __ctx1__.__RestBatchEventMessage = (System.String)Microsoft.XLANGs.Core.Part.XPathLoad(__ctx1__.__RestBatchEventResponseMsg.MessagePart, "string(/*[local-name()='results' and namespace-uri()='http://SBA.gov/DLAPEvents/REST/INSERT/EventRequest']/*[local-name()='result' and namespace-uri()='http://SBA.gov/DLAPEvents/REST/INSERT/EventRequest']/*[local-name()='errors' and namespace-uri()='http://SBA.gov/DLAPEvents/REST/INSERT/EventRequest']/*[local-name()='message' and namespace-uri()='http://SBA.gov/DLAPEvents/REST/INSERT/EventRequest'])", typeof(System.String));
                if ( !PostProgressInc( __seg__, __ctx__, 24 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 24;
            case 24:
                if ( !PreProgressInc( __seg__, __ctx__, 25 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[30],__eventData[6],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 25;
            case 25:
                __ctx1__.__RestBatchEventSFID = (System.String)Microsoft.XLANGs.Core.Part.XPathLoad(__ctx1__.__RestBatchEventResponseMsg.MessagePart, "string(/*[local-name()='results' and namespace-uri()='http://SBA.gov/DLAPEvents/REST/INSERT/EventRequest']/*[local-name()='result' and namespace-uri()='http://SBA.gov/DLAPEvents/REST/INSERT/EventRequest']/*[local-name()='id' and namespace-uri()='http://SBA.gov/DLAPEvents/REST/INSERT/EventRequest'])", typeof(System.String));
                if (__ctx1__ != null && __ctx1__.__RestBatchEventResponseMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__RestBatchEventResponseMsg);
                    __ctx1__.__RestBatchEventResponseMsg = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 26 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 26;
            case 26:
                if ( !PreProgressInc( __seg__, __ctx__, 27 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[31],__eventData[12],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 27;
            case 27:
                __condition__ = !System.String.IsNullOrWhiteSpace(__ctx1__.__RestBatchEventMessage) && (__ctx1__.__RestBatchEventSFID.Length == 0);
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 35 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 35;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 28 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 28;
            case 28:
                if ( !PreProgressInc( __seg__, __ctx__, 29 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[32],__eventData[5],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 29;
            case 29:
                __ctx1__.__RestBatchEventException = new System.Exception("DLAP Events Batch Event Request Rest Exception  -  " + __ctx1__.__RestBatchEventMessage);
                if ( !PostProgressInc( __seg__, __ctx__, 30 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 30;
            case 30:
                if ( !PreProgressInc( __seg__, __ctx__, 31 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[33],__eventData[6],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 31;
            case 31:
                if ( !PreProgressInc( __seg__, __ctx__, 32 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[34],__eventData[14],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 32;
            case 32:
                throw __ctx1__.__RestBatchEventException;
            case 33:
                if ( !PreProgressInc( __seg__, __ctx__, 34 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[35],__eventData[15],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 34;
            case 34:
                RequestTerminate(__ctx2__,"An error occurred while processing the DLAP Events Debatching");
                __seg__.SegmentDone();
                break;
            case 35:
                if ( !PreProgressInc( __seg__, __ctx__, 36 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[36],__eventData[13],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 36;
            case 36:
                if ( !PreProgressInc( __seg__, __ctx__, 37 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[37],__eventData[16],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 37;
            case 37:
                __ctx2__.__exv__ = null;
                OnEndCatchHandler(2, __seg__);
                __seg__.SegmentDone();
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }
        private static Microsoft.XLANGs.Core.CachedObject[] _locations = new Microsoft.XLANGs.Core.CachedObject[] {
            new Microsoft.XLANGs.Core.CachedObject(new System.Guid("{5DFA2183-86A3-4663-80F7-3426A3C6539D}"))
        };

    }

    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed public class _MODULE_PROXY_ { }
}
