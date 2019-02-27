
#pragma warning disable 162

namespace Application_Import_Logic
{

    [System.SerializableAttribute]
    sealed public class __Oracle_Application_Import_Definition_DLAPOracle_SUBMITTED_DOCUMENTS_DCMS2_SelectResponse__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static Oracle_Application_Import_Definition.DLAPOracle_SUBMITTED_DOCUMENTS_DCMS2.SelectResponse _schema = new Oracle_Application_Import_Definition.DLAPOracle_SUBMITTED_DOCUMENTS_DCMS2.SelectResponse();

        public __Oracle_Application_Import_Definition_DLAPOracle_SUBMITTED_DOCUMENTS_DCMS2_SelectResponse__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eNone,
        "",
        new System.Type[]{
            typeof(Oracle_Application_Import_Definition.DLAPOracle_SUBMITTED_DOCUMENTS_DCMS2.SelectResponse)
        },
        new string[]{
            "parameters"
        },
        new System.Type[]{
            typeof(__Oracle_Application_Import_Definition_DLAPOracle_SUBMITTED_DOCUMENTS_DCMS2_SelectResponse__)
        },
        0,
        @"http://Microsoft.LobServices.OracleDB/2007/03/ELA_DB/View/SUBMITTED_DOCUMENTS_DCMS2#SelectResponse"
    )]
    [System.SerializableAttribute]
    sealed public class ELA_DB_View_SUBMITTED_DOCUMENTS_DCMS2_Select_OutputMessage : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __Oracle_Application_Import_Definition_DLAPOracle_SUBMITTED_DOCUMENTS_DCMS2_SelectResponse__ parameters;

        private void __CreatePartWrappers()
        {
            parameters = new __Oracle_Application_Import_Definition_DLAPOracle_SUBMITTED_DOCUMENTS_DCMS2_SelectResponse__(this, "parameters", 0);
            this.AddPart("parameters", 0, parameters);
        }

        public ELA_DB_View_SUBMITTED_DOCUMENTS_DCMS2_Select_OutputMessage(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __Oracle_Application_Import_Definition_DLAPOracle_SUBMITTED_DOCUMENTS_DCMS2_Select__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static Oracle_Application_Import_Definition.DLAPOracle_SUBMITTED_DOCUMENTS_DCMS2.Select _schema = new Oracle_Application_Import_Definition.DLAPOracle_SUBMITTED_DOCUMENTS_DCMS2.Select();

        public __Oracle_Application_Import_Definition_DLAPOracle_SUBMITTED_DOCUMENTS_DCMS2_Select__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eNone,
        "",
        new System.Type[]{
            typeof(Oracle_Application_Import_Definition.DLAPOracle_SUBMITTED_DOCUMENTS_DCMS2.Select)
        },
        new string[]{
            "parameters"
        },
        new System.Type[]{
            typeof(__Oracle_Application_Import_Definition_DLAPOracle_SUBMITTED_DOCUMENTS_DCMS2_Select__)
        },
        0,
        @"http://Microsoft.LobServices.OracleDB/2007/03/ELA_DB/View/SUBMITTED_DOCUMENTS_DCMS2#Select"
    )]
    [System.SerializableAttribute]
    sealed public class ELA_DB_View_SUBMITTED_DOCUMENTS_DCMS2_Select_InputMessage : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __Oracle_Application_Import_Definition_DLAPOracle_SUBMITTED_DOCUMENTS_DCMS2_Select__ parameters;

        private void __CreatePartWrappers()
        {
            parameters = new __Oracle_Application_Import_Definition_DLAPOracle_SUBMITTED_DOCUMENTS_DCMS2_Select__(this, "parameters", 0);
            this.AddPart("parameters", 0, parameters);
        }

        public ELA_DB_View_SUBMITTED_DOCUMENTS_DCMS2_Select_InputMessage(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Select",
        new System.Type[]{
            typeof(Application_Import_Logic.ELA_DB_View_SUBMITTED_DOCUMENTS_DCMS2_Select_InputMessage), 
            typeof(Application_Import_Logic.ELA_DB_View_SUBMITTED_DOCUMENTS_DCMS2_Select_OutputMessage)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic, "")]
    [System.SerializableAttribute]
    sealed public class ELA_DB_View_SUBMITTED_DOCUMENTS_DCMS2 : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public ELA_DB_View_SUBMITTED_DOCUMENTS_DCMS2(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public ELA_DB_View_SUBMITTED_DOCUMENTS_DCMS2(ELA_DB_View_SUBMITTED_DOCUMENTS_DCMS2 p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            ELA_DB_View_SUBMITTED_DOCUMENTS_DCMS2 p = new ELA_DB_View_SUBMITTED_DOCUMENTS_DCMS2(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Select = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Select",
            System.Web.Services.Description.OperationFlow.RequestResponse,
            typeof(ELA_DB_View_SUBMITTED_DOCUMENTS_DCMS2),
            typeof(ELA_DB_View_SUBMITTED_DOCUMENTS_DCMS2_Select_InputMessage),
            typeof(ELA_DB_View_SUBMITTED_DOCUMENTS_DCMS2_Select_OutputMessage),
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "Select" ] = Select;
                return h;
            }
        }
        #endregion // port reflection support
    }
    //#line 514 "C:\Users\skyeniga\Source\Repos\Biztalk\DLAP Application Import\Document Upload Logic\Document Coordinator.odx"
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        },
        new System.Type[] {
            typeof(Application_Import_Logic.ELA_DB_View_SUBMITTED_DOCUMENTS_DCMS2)
        },
        new System.String[] {
            "OraclePort"
        },
        new System.Type[] {
            null
        }
    )]
    [Microsoft.XLANGs.BaseTypes.ServiceCallTreeAttribute(
        new System.Type[] {
            typeof(SBA.BizTalk.Shared.Salesforce.Documents.Logic.Upload)
        },
        new System.Type[] {
        },
        new System.Type[] {
        }
    )]
    [Microsoft.XLANGs.BaseTypes.ServiceAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSServiceInfo.eCallable|Microsoft.XLANGs.BaseTypes.EXLangSServiceInfo.eExecable
    )]
    [System.SerializableAttribute]
    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed public class DocumentCoordinatorLogic : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
    {
        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic;
        public static readonly bool __execable = true;
        [Microsoft.XLANGs.BaseTypes.CallCompensationAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSCallCompensationInfo.eHasRequestResponse
,
            new System.String[] {
                "SBA.BizTalk.Shared.Salesforce.Documents.Logic.Upload"
            },
            new System.String[] {
            }
        )]
        public static void __bodyProxy(
            [ Microsoft.XLANGs.BaseTypes.ServiceParameterAttribute(Microsoft.XLANGs.BaseTypes.EXLangSParameter.eMessage, "") ] Application_Import_Definition.HomeDisasterLoanApplicationCanonical Trigger)
        {
        }
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(DocumentCoordinatorLogic));
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

        static DocumentCoordinatorLogic()
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
            _rootContext = new __DocumentCoordinatorLogic_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[3];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public DocumentCoordinatorLogic(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "DocumentCoordinatorLogic", tracker)
        {
            ConstructorHelper();
        }

        public DocumentCoordinatorLogic(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "DocumentCoordinatorLogic")
        {
            ConstructorHelper();
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>7d89560b-9475-40af-b607-d43bf7402beb</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>MessageDeclarationShape</shapeType>      <ShapeID>e2b28e50-91e2-4ceb-b1fe-69d6b99bc129</ShapeID>      <ParentLink>ServiceBody_Declaration</ParentLink>                <shapeText>Trigger</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>TaskShape</shapeType>      <ShapeID>cda0eee5-1eec-4cd1-8505-b130608ff41b</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>DLAP ELA Document Coordinator </shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>346f7cbb-c9e0-4216-9419-a55f93f5dcf4</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>ConstructRequest</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>c4fde389-850a-4aa1-9fdf-3c666f897eaf</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Create Request</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>1b833534-5273-4517-b247-4c4cb045902c</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>dae7e68a-d0ab-4d3a-9107-4b9a4d6aca28</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>478e6def-33a6-4879-a898-98d54219868e</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>02839fd4-8d8f-4eca-8bf0-785b8ed00b81</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Send Document Request</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>4bb90429-bb54-4694-96e8-7a47e56a7fbb</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Receive Documents</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>f18dc206-63ca-4da8-852d-a3248ee609c2</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Get Document Count</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>WhileShape</shapeType>      <ShapeID>3d3fbf1f-c110-4861-a7ce-74f998fc2130</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Loop Through Documents</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>d8020666-ede3-4e56-bfb0-999a5910b646</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Update Index</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>8d757d4c-d8e6-4112-a28c-41a9617dd824</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>DOC_ORIGIN</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionShape</shapeType>      <ShapeID>600288b1-4579-46a4-a720-eccc701e630d</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Application or Applicant?</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>92dea4f3-e980-4f7d-b229-659e5e200137</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>Application Linking</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>0270ef9a-fd90-4d5c-8075-ee541ded90f1</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Extract Metadata to Application</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>a490871a-60b4-49c7-baac-ac5b9c87289f</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>Else</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>5f9f04ae-1e5e-49b6-b585-bd05c9cd0ac1</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Extract Metadata to Applicant</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>CallShape</shapeType>      <ShapeID>2af17403-74d9-423f-a208-fa5d1306cb51</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>CallOrchestration_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>6774a9d6-cf98-49cc-b8eb-a538338430f0</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>DOC_TITLE</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>e59fb430-0ca5-4160-ba25-3609a7062667</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>DOC_DESCRIPTION</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>afa2384d-9e47-4cdb-94f9-b91cbc029499</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>DOC_PATHONCLIENT</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>30c126fa-0780-4404-a565-7d585bb54f82</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>DOC_DATA</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>fc3b3b74-56ad-40e0-b0c7-8f8bfdf8dfce</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>DOC_FILEEXTENSION</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>53f9b178-ca7e-44ae-833f-348966a31f5b</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>DOC_TYPE_VAL</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>4a48209a-a669-45b7-b409-3bc2f5223e33</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>DOC_REASONFORCHANGE</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>1ffce533-adf4-4a36-95bf-843a6db9e3e0</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>SalesForceApplicantId</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>ed0bd7ee-729c-4968-ad34-3b61852e7db9</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>USR_USER_ID</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>37bb103e-f87d-40fd-9047-8a50a3147cbd</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>DOCUMENT_TYPE_CD_ODA</shapeText>                  
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
<ActionName>'DocumentCoordinatorLogic'</ActionName><IsAtomic>0</IsAtomic><Line>514</Line><Position>12</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
<Messages>
	<MsgInfo><name>Trigger</name><part>part</part><schema>Application_Import_Definition.HomeDisasterLoanApplicationCanonical</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>570</Line><Position>13</Position><ShapeID>'346f7cbb-c9e0-4216-9419-a55f93f5dcf4'</ShapeID>
<Messages>
	<MsgInfo><name>SubmittedDocumentsRequestMsg</name><part>parameters</part><schema>Oracle_Application_Import_Definition.DLAPOracle_SUBMITTED_DOCUMENTS_DCMS2+Select</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>Trigger</name><part>part</part><schema>Application_Import_Definition.HomeDisasterLoanApplicationCanonical</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>576</Line><Position>13</Position><ShapeID>'02839fd4-8d8f-4eca-8bf0-785b8ed00b81'</ShapeID>
<Messages>
	<MsgInfo><name>SubmittedDocumentsRequestMsg</name><part>parameters</part><schema>Oracle_Application_Import_Definition.DLAPOracle_SUBMITTED_DOCUMENTS_DCMS2+Select</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>578</Line><Position>13</Position><ShapeID>'4bb90429-bb54-4694-96e8-7a47e56a7fbb'</ShapeID>
<Messages>
	<MsgInfo><name>SubmittedDocumentsResponseMsg</name><part>parameters</part><schema>Oracle_Application_Import_Definition.DLAPOracle_SUBMITTED_DOCUMENTS_DCMS2+SelectResponse</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>580</Line><Position>24</Position><ShapeID>'f18dc206-63ca-4da8-852d-a3248ee609c2'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>582</Line><Position>13</Position><ShapeID>'3d3fbf1f-c110-4861-a7ce-74f998fc2130'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>585</Line><Position>23</Position><ShapeID>'d8020666-ede3-4e56-bfb0-999a5910b646'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>587</Line><Position>36</Position><ShapeID>'8d757d4c-d8e6-4112-a28c-41a9617dd824'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>597</Line><Position>17</Position><ShapeID>'600288b1-4579-46a4-a720-eccc701e630d'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>600</Line><Position>40</Position><ShapeID>'0270ef9a-fd90-4d5c-8075-ee541ded90f1'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>656</Line><Position>40</Position><ShapeID>'5f9f04ae-1e5e-49b6-b585-bd05c9cd0ac1'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>718</Line><Position>75</Position><ShapeID>'2af17403-74d9-423f-a208-fa5d1306cb51'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='a89c2bae-7595-4c69-ba37-a59e5617ccb5' LowerBound='1.1' HigherBound='229.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='Application_Import_Logic' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='ServiceDeclaration' OID='0b48e5fa-ad9b-42f5-8b1d-c0e2b591ed9e' ParentLink='Module_ServiceDeclaration' LowerBound='19.1' HigherBound='228.1'>
            <om:Property Name='InitializedTransactionType' Value='False' />
            <om:Property Name='IsInvokable' Value='True' />
            <om:Property Name='TypeModifier' Value='Public' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='DocumentCoordinatorLogic' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='VariableDeclaration' OID='b09145c1-d2ed-47f9-b84b-da4501a6fdf9' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='26.1' HigherBound='27.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.Int32' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='TotalCount' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='44384d14-db79-490e-addb-de33eecace68' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='27.1' HigherBound='28.1'>
                <om:Property Name='InitialValue' Value='0' />
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.Int32' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Index' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='246b6c02-eea8-444a-9a69-effaafa7ff17' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='28.1' HigherBound='29.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='DocumentIndexXpath' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='2b091026-00d1-492d-b8c4-6d8dee52c0ad' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='29.1' HigherBound='30.1'>
                <om:Property Name='InitialValue' Value='System.String.Empty' />
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='DOC_DESCRIPTION' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='7ef9b07a-bd87-486b-b054-b70f7bd74e14' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='30.1' HigherBound='31.1'>
                <om:Property Name='InitialValue' Value='System.String.Empty' />
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='DOC_APPLICATIONID' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='3fba68a6-d83c-4574-acf4-010f041dedc8' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='31.1' HigherBound='32.1'>
                <om:Property Name='InitialValue' Value='System.String.Empty' />
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='DOC_DATA' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='91e8aacb-c1d9-4ee6-8ad2-5ecb301a2072' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='32.1' HigherBound='33.1'>
                <om:Property Name='InitialValue' Value='&quot;Tax Transcript&quot;' />
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='DOC_DOCUMENT_C' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='7ae5ae1d-a36c-499e-91ef-45949b58f618' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='33.1' HigherBound='34.1'>
                <om:Property Name='InitialValue' Value='System.String.Empty' />
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='DOC_FILEEXTENSION' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='189709b2-167f-4372-a486-b724bdf9e7c0' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='34.1' HigherBound='35.1'>
                <om:Property Name='InitialValue' Value='&quot;/fake/path&quot;' />
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='DOC_PATHONCLIENT' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='394162ee-8eaa-45c7-9aa0-9572f5d815f7' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='35.1' HigherBound='36.1'>
                <om:Property Name='InitialValue' Value=' &quot;Initial ELA Pull from DLAP&quot;' />
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='DOC_REASONFORCHANGE' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='73739f1d-3005-4784-9dc0-1214181459fb' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='36.1' HigherBound='37.1'>
                <om:Property Name='InitialValue' Value='System.String.Empty' />
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='DOC_TITLE' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='00ddf5a4-3e7b-4ff1-9d8a-b898254973d4' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='37.1' HigherBound='38.1'>
                <om:Property Name='InitialValue' Value='&quot;string(/*[local-name()=&apos;SelectResponse&apos; and namespace-uri()=&apos;http://Microsoft.LobServices.OracleDB/2007/03/ELA_DB/View/SUBMITTED_DOCUMENTS_DCMS2&apos;]/*[local-name()=&apos;SelectResult&apos; and namespace-uri()=&apos;http://Microsoft.LobServices.OracleDB/2007/03/ELA_DB/View/SUBMITTED_DOCUMENTS_DCMS2&apos;]/*[local-name()=&apos;SUBMITTED_DOCUMENTS_DCMS2RECORDSELECT&apos; and namespace-uri()=&apos;http://Microsoft.LobServices.OracleDB/2007/03/ELA_DB/View/SUBMITTED_DOCUMENTS_DCMS2&apos;][{0}]/*[local-name()=&apos;{1}&apos; and namespace-uri()=&apos;http://Microsoft.LobServices.OracleDB/2007/03/ELA_DB/View/SUBMITTED_DOCUMENTS_DCMS2&apos;]/text())&quot;' />
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='GetDocField' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='1c2ceb9a-6436-4216-8b11-5e7682a71944' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='38.1' HigherBound='39.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='DocAppSalesForceId' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='7e85cb1d-a1fc-4979-92d8-d338564317ea' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='39.1' HigherBound='40.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='DOC_APPLICANT_ID' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='ec2e76a8-7cb0-4490-af60-0b1bbfd372c4' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='40.1' HigherBound='41.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SalesForceApplicantId' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='d5608be5-2527-4ca7-9b5e-e1e785aa571e' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='41.1' HigherBound='42.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='DOC_ORIGIN' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='116a4173-73c5-4642-8427-0d7a5201c0ed' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='42.1' HigherBound='43.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='UserIdIndexXpath' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='7c2bfb6f-38b3-472d-b7e1-8a029cde89a3' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='43.1' HigherBound='44.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='USR_USER_ID' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='c63678ac-5563-4835-96cf-2310d2cd8488' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='44.1' HigherBound='45.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='TITLE' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='d832ed57-1fbd-40c3-bc7c-d20da574d842' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='45.1' HigherBound='46.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='DOC_TYPE_VAL' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='58bcd809-2592-45d2-aeb5-34f4a4cb459d' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='46.1' HigherBound='47.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='DOCUMENT_TYPE_CD_ODA' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='2417de8a-402c-4389-9ded-3f71240a7ef3' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='47.1' HigherBound='48.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='DocumentType_c' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='20c9c94e-ff38-43b9-a4ac-4645459987ca' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='48.1' HigherBound='49.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='FileName_TITLE' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='3cc53ac9-ca77-45e8-8129-f8de8b5d3cc1' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='49.1' HigherBound='50.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='FileName_TITLE_Escape' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='bc208aa6-d606-4e39-94ee-10f6a86fe3d7' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='24.1' HigherBound='25.1'>
                <om:Property Name='Type' Value='Application_Import_Logic.ELA_DB_View_SUBMITTED_DOCUMENTS_DCMS2_Select_InputMessage' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SubmittedDocumentsRequestMsg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='8d906607-ca00-425c-9669-a785c56640e5' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='25.1' HigherBound='26.1'>
                <om:Property Name='Type' Value='Application_Import_Logic.ELA_DB_View_SUBMITTED_DOCUMENTS_DCMS2_Select_OutputMessage' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SubmittedDocumentsResponseMsg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='ServiceBody' OID='7d89560b-9475-40af-b607-d43bf7402beb' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageDeclaration' OID='e2b28e50-91e2-4ceb-b1fe-69d6b99bc129' ParentLink='ServiceBody_Declaration' LowerBound='50.15' HigherBound='50.97'>
                    <om:Property Name='Type' Value='Application_Import_Definition.HomeDisasterLoanApplicationCanonical' />
                    <om:Property Name='ParamDirection' Value='In' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Trigger' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Task' OID='cda0eee5-1eec-4cd1-8505-b130608ff41b' ParentLink='ServiceBody_Statement' LowerBound='75.1' HigherBound='226.1'>
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='DLAP ELA Document Coordinator ' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='Construct' OID='346f7cbb-c9e0-4216-9419-a55f93f5dcf4' ParentLink='ComplexStatement_Statement' LowerBound='75.1' HigherBound='81.1'>
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='ConstructRequest' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='Transform' OID='c4fde389-850a-4aa1-9fdf-3c666f897eaf' ParentLink='ComplexStatement_Statement' LowerBound='78.1' HigherBound='80.1'>
                            <om:Property Name='ClassName' Value='Document_Upload_Logic.CreateOracleRequest' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Create Request' />
                            <om:Property Name='Signal' Value='True' />
                            <om:Element Type='MessagePartRef' OID='1b833534-5273-4517-b247-4c4cb045902c' ParentLink='Transform_InputMessagePartRef' LowerBound='79.114' HigherBound='79.121'>
                                <om:Property Name='MessageRef' Value='Trigger' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='MessagePartReference_1' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='MessagePartRef' OID='dae7e68a-d0ab-4d3a-9107-4b9a4d6aca28' ParentLink='Transform_OutputMessagePartRef' LowerBound='79.28' HigherBound='79.67'>
                                <om:Property Name='MessageRef' Value='SubmittedDocumentsRequestMsg' />
                                <om:Property Name='PartRef' Value='parameters' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='MessagePartReference_2' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                        </om:Element>
                        <om:Element Type='MessageRef' OID='478e6def-33a6-4879-a898-98d54219868e' ParentLink='Construct_MessageRef' LowerBound='76.23' HigherBound='76.51'>
                            <om:Property Name='Ref' Value='SubmittedDocumentsRequestMsg' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='Send' OID='02839fd4-8d8f-4eca-8bf0-785b8ed00b81' ParentLink='ComplexStatement_Statement' LowerBound='81.1' HigherBound='83.1'>
                        <om:Property Name='PortName' Value='OraclePort' />
                        <om:Property Name='MessageName' Value='SubmittedDocumentsRequestMsg' />
                        <om:Property Name='OperationName' Value='Select' />
                        <om:Property Name='OperationMessageName' Value='Request' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Send Document Request' />
                        <om:Property Name='Signal' Value='True' />
                    </om:Element>
                    <om:Element Type='Receive' OID='4bb90429-bb54-4694-96e8-7a47e56a7fbb' ParentLink='ComplexStatement_Statement' LowerBound='83.1' HigherBound='85.1'>
                        <om:Property Name='Activate' Value='False' />
                        <om:Property Name='PortName' Value='OraclePort' />
                        <om:Property Name='MessageName' Value='SubmittedDocumentsResponseMsg' />
                        <om:Property Name='OperationName' Value='Select' />
                        <om:Property Name='OperationMessageName' Value='Response' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Receive Documents' />
                        <om:Property Name='Signal' Value='True' />
                    </om:Element>
                    <om:Element Type='VariableAssignment' OID='f18dc206-63ca-4da8-852d-a3248ee609c2' ParentLink='ComplexStatement_Statement' LowerBound='85.1' HigherBound='87.1'>
                        <om:Property Name='Expression' Value='TotalCount =  xpath(SubmittedDocumentsResponseMsg.parameters, &quot;count(/*[local-name()=&apos;SelectResponse&apos; and namespace-uri()=&apos;http://Microsoft.LobServices.OracleDB/2007/03/ELA_DB/View/SUBMITTED_DOCUMENTS_DCMS2&apos;]/*[local-name()=&apos;SelectResult&apos; and namespace-uri()=&apos;http://Microsoft.LobServices.OracleDB/2007/03/ELA_DB/View/SUBMITTED_DOCUMENTS_DCMS2&apos;]/*[local-name()=&apos;SUBMITTED_DOCUMENTS_DCMS2RECORDSELECT&apos; and namespace-uri()=&apos;http://Microsoft.LobServices.OracleDB/2007/03/ELA_DB/View/SUBMITTED_DOCUMENTS_DCMS2&apos;])&quot;);' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Get Document Count' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                    <om:Element Type='While' OID='3d3fbf1f-c110-4861-a7ce-74f998fc2130' ParentLink='ComplexStatement_Statement' LowerBound='87.1' HigherBound='226.1'>
                        <om:Property Name='Expression' Value='Index &lt; TotalCount' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Loop Through Documents' />
                        <om:Property Name='Signal' Value='False' />
                        <om:Element Type='VariableAssignment' OID='d8020666-ede3-4e56-bfb0-999a5910b646' ParentLink='ComplexStatement_Statement' LowerBound='90.1' HigherBound='92.1'>
                            <om:Property Name='Expression' Value='Index = Index + 1;' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Update Index' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                        <om:Element Type='VariableAssignment' OID='8d757d4c-d8e6-4112-a28c-41a9617dd824' ParentLink='ComplexStatement_Statement' LowerBound='92.1' HigherBound='102.1'>
                            <om:Property Name='Expression' Value='DocumentIndexXpath = System.String.Format(GetDocField, Index, &quot;DOC_ORIGIN&quot;);&#xD;&#xA;DOC_ORIGIN = xpath(SubmittedDocumentsResponseMsg.parameters, DocumentIndexXpath);&#xD;&#xA;&#xD;&#xA;DocumentIndexXpath = System.String.Format(GetDocField, Index, &quot;DOC_APPLICANT_ID&quot;);&#xD;&#xA;DOC_APPLICANT_ID = xpath(SubmittedDocumentsResponseMsg.parameters, DocumentIndexXpath);&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='DOC_ORIGIN' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                        <om:Element Type='Decision' OID='600288b1-4579-46a4-a720-eccc701e630d' ParentLink='ComplexStatement_Statement' LowerBound='102.1' HigherBound='223.1'>
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Application or Applicant?' />
                            <om:Property Name='Signal' Value='True' />
                            <om:Element Type='DecisionBranch' OID='92dea4f3-e980-4f7d-b229-659e5e200137' ParentLink='ReallyComplexStatement_Branch' LowerBound='103.17' HigherBound='159.1'>
                                <om:Property Name='Expression' Value='DOC_APPLICANT_ID == &quot;0&quot;' />
                                <om:Property Name='IsGhostBranch' Value='True' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Application Linking' />
                                <om:Property Name='Signal' Value='False' />
                                <om:Element Type='VariableAssignment' OID='0270ef9a-fd90-4d5c-8075-ee541ded90f1' ParentLink='ComplexStatement_Statement' LowerBound='105.1' HigherBound='158.1'>
                                    <om:Property Name='Expression' Value='DocumentIndexXpath = System.String.Format(GetDocField, Index, &quot;DOC_ID&quot;);&#xD;&#xA;DOC_DESCRIPTION = xpath(SubmittedDocumentsResponseMsg.parameters, DocumentIndexXpath);&#xD;&#xA;&#xD;&#xA;DocumentIndexXpath = System.String.Format(GetDocField, Index, &quot;DOC_CONTENTS&quot;);&#xD;&#xA;DOC_DATA = xpath(SubmittedDocumentsResponseMsg.parameters, DocumentIndexXpath);&#xD;&#xA;&#xD;&#xA;DocumentIndexXpath = System.String.Format(GetDocField, Index, &quot;DOC_CONTENT_TYPE&quot;);&#xD;&#xA;DOC_FILEEXTENSION = xpath(SubmittedDocumentsResponseMsg.parameters, DocumentIndexXpath);&#xD;&#xA;&#xD;&#xA;DocumentIndexXpath = System.String.Format(GetDocField, Index, &quot;DOC_INSTANCE_NAME&quot;);&#xD;&#xA;TITLE = xpath(SubmittedDocumentsResponseMsg.parameters, DocumentIndexXpath);&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;FileName_TITLE_Escape = System.IO.Path.GetFileNameWithoutExtension(TITLE);&#xD;&#xA;&#xD;&#xA;FileName_TITLE = System.Security.SecurityElement.Escape(FileName_TITLE_Escape);&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;if(DOC_FILEEXTENSION == &quot;application/pdf&quot;)&#xD;&#xA;{DOC_TITLE = FileName_TITLE+&quot;.pdf&quot;;}&#xD;&#xA;else{DOC_TITLE = FileName_TITLE+&quot;.pdf&quot;;}&#xD;&#xA;&#xD;&#xA;DOC_PATHONCLIENT = &quot;/fake/&quot; + DOC_TITLE;&#xD;&#xA;&#xD;&#xA;DocumentIndexXpath = System.String.Format(GetDocField, Index, &quot;DOC_APPLICANT_ID&quot;);&#xD;&#xA;&#xD;&#xA;DOC_APPLICANT_ID = xpath(SubmittedDocumentsResponseMsg.parameters, DocumentIndexXpath);&#xD;&#xA;&#xD;&#xA;SalesForceApplicantId = xpath(Trigger, @&quot;string(/*[local-name()=&apos;Application&apos; and namespace-uri()=&apos;http://SBA.ODA.Gov/CanonicalApplication&apos;]/*[local-name()=&apos;SalesForceApplication__cID&apos; and namespace-uri()=&apos;&apos;]/text())&quot;);&#xD;&#xA;&#xD;&#xA;DocumentIndexXpath = System.String.Format(GetDocField, Index, &quot;DOC_TYPE&quot;);&#xD;&#xA;DOCUMENT_TYPE_CD_ODA = xpath(SubmittedDocumentsResponseMsg.parameters, Docume"+
@"ntIndexXpath);&#xD;&#xA;&#xD;&#xA;if(!System.String.IsNullOrWhiteSpace(DOCUMENT_TYPE_CD_ODA))&#xD;&#xA;{&#xD;&#xA;    if (DOCUMENT_TYPE_CD_ODA == &quot;525&quot;)&#xD;&#xA;        { DOC_TYPE_VAL = &quot;4506T&quot;; }&#xD;&#xA;		&#xD;&#xA;    else if (DOCUMENT_TYPE_CD_ODA == &quot;542&quot;)&#xD;&#xA;        { DOC_TYPE_VAL = &quot;Schedule of Liabilities (2202)&quot;; }&#xD;&#xA;		&#xD;&#xA;    else if (DOCUMENT_TYPE_CD_ODA == &quot;544&quot;)&#xD;&#xA;        { DOC_TYPE_VAL = &quot;Personal Financial Statement (413)&quot;; }&#xD;&#xA;    &#xD;&#xA;    else{ DOC_TYPE_VAL = &quot;Other&quot;;}&#xD;&#xA;}		&#xD;&#xA;else{ DOC_TYPE_VAL = &quot;Other&quot;;}&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;UserIdIndexXpath = System.String.Format(GetDocField, Index, &quot;DOC_USR_ID&quot;);&#xD;&#xA;USR_USER_ID = xpath(SubmittedDocumentsResponseMsg.parameters, UserIdIndexXpath);' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='Extract Metadata to Application' />
                                    <om:Property Name='Signal' Value='True' />
                                </om:Element>
                            </om:Element>
                            <om:Element Type='DecisionBranch' OID='a490871a-60b4-49c7-baac-ac5b9c87289f' ParentLink='ReallyComplexStatement_Branch'>
                                <om:Property Name='IsGhostBranch' Value='True' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Else' />
                                <om:Property Name='Signal' Value='False' />
                                <om:Element Type='VariableAssignment' OID='5f9f04ae-1e5e-49b6-b585-bd05c9cd0ac1' ParentLink='ComplexStatement_Statement' LowerBound='161.1' HigherBound='222.1'>
                                    <om:Property Name='Expression' Value='DocumentIndexXpath = System.String.Format(GetDocField, Index, &quot;DOC_ID&quot;);&#xD;&#xA;DOC_DESCRIPTION = xpath(SubmittedDocumentsResponseMsg.parameters, DocumentIndexXpath);&#xD;&#xA;&#xD;&#xA;DocumentIndexXpath = System.String.Format(GetDocField, Index, &quot;DOC_CONTENTS&quot;);&#xD;&#xA;DOC_DATA = xpath(SubmittedDocumentsResponseMsg.parameters, DocumentIndexXpath);&#xD;&#xA;&#xD;&#xA;DocumentIndexXpath = System.String.Format(GetDocField, Index, &quot;DOC_CONTENT_TYPE&quot;);&#xD;&#xA;DOC_FILEEXTENSION = xpath(SubmittedDocumentsResponseMsg.parameters, DocumentIndexXpath);&#xD;&#xA;&#xD;&#xA;DocumentIndexXpath = System.String.Format(GetDocField, Index, &quot;DOC_INSTANCE_NAME&quot;);&#xD;&#xA;TITLE = xpath(SubmittedDocumentsResponseMsg.parameters, DocumentIndexXpath);&#xD;&#xA;&#xD;&#xA;FileName_TITLE = System.IO.Path.GetFileNameWithoutExtension(TITLE);&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;FileName_TITLE_Escape = System.IO.Path.GetFileNameWithoutExtension(TITLE);&#xD;&#xA;&#xD;&#xA;FileName_TITLE = System.Security.SecurityElement.Escape(FileName_TITLE_Escape);&#xD;&#xA;&#xD;&#xA;if(DOC_FILEEXTENSION == &quot;application/pdf&quot;)&#xD;&#xA;{DOC_TITLE = FileName_TITLE+&quot;.pdf&quot;;}&#xD;&#xA;else{DOC_TITLE = FileName_TITLE+&quot;.pdf&quot;;}&#xD;&#xA;&#xD;&#xA;DOC_PATHONCLIENT = &quot;/fake/&quot; + DOC_TITLE;&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;DocumentIndexXpath = System.String.Format(GetDocField, Index, &quot;DOC_APPLICANT_ID&quot;);&#xD;&#xA;DOC_APPLICANT_ID = xpath(SubmittedDocumentsResponseMsg.parameters, DocumentIndexXpath);&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;SalesForceApplicantId = xpath(Trigger, @&quot;string(&#xD;&#xA;/*[local-name()=&apos;Application&apos; and namespace-uri()=&apos;http://SBA.ODA.Gov/CanonicalApplication&apos;]&#xD;&#xA;/*[local-name()=&apos;ApplicantColl&apos; and namespace-uri()=&apos;&apos;]&#xD;&#xA;/*[local-name()=&apos;Applicants&apos; and namespace-uri()=&apos;&apos; ]&#xD;&#xA;/*[local-name()=&apos;Applican"+
@"tId&apos; and namespace-uri()=&apos;&apos; and text()=&apos;&quot;+DOC_APPLICANT_ID+@&quot;&apos;]/..&#xD;&#xA;/*[local-name()=&apos;SalesForceApplicantID&apos; and namespace-uri()=&apos;&apos;]/text())&quot;);&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;DocumentIndexXpath = System.String.Format(GetDocField, Index, &quot;DOC_TYPE&quot;);&#xD;&#xA;DOCUMENT_TYPE_CD_ODA = xpath(SubmittedDocumentsResponseMsg.parameters, DocumentIndexXpath);&#xD;&#xA;&#xD;&#xA;if(!System.String.IsNullOrWhiteSpace(DOCUMENT_TYPE_CD_ODA))&#xD;&#xA;{&#xD;&#xA;    if (DOCUMENT_TYPE_CD_ODA == &quot;525&quot;)&#xD;&#xA;        { DOC_TYPE_VAL = &quot;4506T&quot;; }&#xD;&#xA;		&#xD;&#xA;    else if (DOCUMENT_TYPE_CD_ODA == &quot;542&quot;)&#xD;&#xA;        { DOC_TYPE_VAL = &quot;Schedule of Liabilities (2202)&quot;; }&#xD;&#xA;		&#xD;&#xA;    else if (DOCUMENT_TYPE_CD_ODA == &quot;544&quot;)&#xD;&#xA;        { DOC_TYPE_VAL = &quot;Personal Financial Statement (413)&quot;; }&#xD;&#xA;&#xD;&#xA;    else{ DOC_TYPE_VAL = &quot;Other&quot;;}&#xD;&#xA;}		&#xD;&#xA;else{ DOC_TYPE_VAL = &quot;Other&quot;;}&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;UserIdIndexXpath = System.String.Format(GetDocField, Index, &quot;DOC_USR_ID&quot;);&#xD;&#xA;USR_USER_ID = xpath(SubmittedDocumentsResponseMsg.parameters, UserIdIndexXpath);' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='Extract Metadata to Applicant' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                            </om:Element>
                        </om:Element>
                        <om:Element Type='Call' OID='2af17403-74d9-423f-a208-fa5d1306cb51' ParentLink='ComplexStatement_Statement' LowerBound='223.1' HigherBound='225.1'>
                            <om:Property Name='Identifier' Value='CallOrchestration_1' />
                            <om:Property Name='Invokee' Value='SBA.BizTalk.Shared.Salesforce.Documents.Logic.Upload' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='CallOrchestration_1' />
                            <om:Property Name='Signal' Value='True' />
                            <om:Element Type='Parameter' OID='6774a9d6-cf98-49cc-b8eb-a538338430f0' ParentLink='InvokeStatement_Parameter'>
                                <om:Property Name='Direction' Value='In' />
                                <om:Property Name='Name' Value='DOC_TITLE' />
                                <om:Property Name='Type' Value='System.String' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='Parameter' OID='e59fb430-0ca5-4160-ba25-3609a7062667' ParentLink='InvokeStatement_Parameter'>
                                <om:Property Name='Direction' Value='In' />
                                <om:Property Name='Name' Value='DOC_DESCRIPTION' />
                                <om:Property Name='Type' Value='System.String' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='Parameter' OID='afa2384d-9e47-4cdb-94f9-b91cbc029499' ParentLink='InvokeStatement_Parameter'>
                                <om:Property Name='Direction' Value='In' />
                                <om:Property Name='Name' Value='DOC_PATHONCLIENT' />
                                <om:Property Name='Type' Value='System.String' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='Parameter' OID='30c126fa-0780-4404-a565-7d585bb54f82' ParentLink='InvokeStatement_Parameter'>
                                <om:Property Name='Direction' Value='In' />
                                <om:Property Name='Name' Value='DOC_DATA' />
                                <om:Property Name='Type' Value='System.String' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='Parameter' OID='fc3b3b74-56ad-40e0-b0c7-8f8bfdf8dfce' ParentLink='InvokeStatement_Parameter'>
                                <om:Property Name='Direction' Value='In' />
                                <om:Property Name='Name' Value='DOC_FILEEXTENSION' />
                                <om:Property Name='Type' Value='System.String' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='Parameter' OID='53f9b178-ca7e-44ae-833f-348966a31f5b' ParentLink='InvokeStatement_Parameter'>
                                <om:Property Name='Direction' Value='In' />
                                <om:Property Name='Name' Value='DOC_TYPE_VAL' />
                                <om:Property Name='Type' Value='System.String' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='Parameter' OID='4a48209a-a669-45b7-b409-3bc2f5223e33' ParentLink='InvokeStatement_Parameter'>
                                <om:Property Name='Direction' Value='In' />
                                <om:Property Name='Name' Value='DOC_REASONFORCHANGE' />
                                <om:Property Name='Type' Value='System.String' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='Parameter' OID='1ffce533-adf4-4a36-95bf-843a6db9e3e0' ParentLink='InvokeStatement_Parameter'>
                                <om:Property Name='Direction' Value='In' />
                                <om:Property Name='Name' Value='SalesForceApplicantId' />
                                <om:Property Name='Type' Value='System.String' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='Parameter' OID='ed0bd7ee-729c-4968-ad34-3b61852e7db9' ParentLink='InvokeStatement_Parameter'>
                                <om:Property Name='Direction' Value='In' />
                                <om:Property Name='Name' Value='USR_USER_ID' />
                                <om:Property Name='Type' Value='System.String' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='Parameter' OID='37bb103e-f87d-40fd-9047-8a50a3147cbd' ParentLink='InvokeStatement_Parameter'>
                                <om:Property Name='Direction' Value='In' />
                                <om:Property Name='Name' Value='DOCUMENT_TYPE_CD_ODA' />
                                <om:Property Name='Type' Value='System.String' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                        </om:Element>
                    </om:Element>
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='04fea88e-76ea-4a44-9756-cc75edcd0b7a' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='22.1' HigherBound='24.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='15' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='Application_Import_Logic.ELA_DB_View_SUBMITTED_DOCUMENTS_DCMS2' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='OraclePort' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='de1d0f62-2a2e-433d-af9f-47f0b447ad88' ParentLink='PortDeclaration_CLRAttribute' LowerBound='22.1' HigherBound='23.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='cd4de54a-8e43-4068-87bb-8640f546af7e' ParentLink='Module_PortType' LowerBound='12.1' HigherBound='19.1'>
            <om:Property Name='Synchronous' Value='True' />
            <om:Property Name='TypeModifier' Value='Public' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='AnalystComments' Value='Adapter metadata port type: ' />
            <om:Property Name='Name' Value='ELA_DB_View_SUBMITTED_DOCUMENTS_DCMS2' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='9190447c-d67c-48b2-acb0-c654bc62bd3d' ParentLink='PortType_OperationDeclaration' LowerBound='14.1' HigherBound='18.1'>
                <om:Property Name='OperationType' Value='RequestResponse' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='AnalystComments' Value='Adapter metadata operation: ' />
                <om:Property Name='Name' Value='Select' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='c428b989-02cd-4fa1-8f4e-92ce2cc03a51' ParentLink='OperationDeclaration_ResponseMessageRef' LowerBound='16.72' HigherBound='16.130'>
                    <om:Property Name='Ref' Value='Application_Import_Logic.ELA_DB_View_SUBMITTED_DOCUMENTS_DCMS2_Select_OutputMessage' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='AnalystComments' Value='Adapter metadata operation message: ' />
                    <om:Property Name='Name' Value='Response' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='MessageRef' OID='aafef394-0475-4f7a-97d6-a457e984abf1' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='16.13' HigherBound='16.70'>
                    <om:Property Name='Ref' Value='Application_Import_Logic.ELA_DB_View_SUBMITTED_DOCUMENTS_DCMS2_Select_InputMessage' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='AnalystComments' Value='Adapter metadata operation message: ' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='MultipartMessageType' OID='debb0056-3070-4fe2-979f-f2819366911a' ParentLink='Module_MessageType' LowerBound='4.1' HigherBound='8.1'>
            <om:Property Name='TypeModifier' Value='Public' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='AnalystComments' Value='Adapter metadata message type: ' />
            <om:Property Name='Name' Value='ELA_DB_View_SUBMITTED_DOCUMENTS_DCMS2_Select_OutputMessage' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='PartDeclaration' OID='1f83fc6f-1f26-42a0-a935-a0ad669b2418' ParentLink='MultipartMessageType_PartDeclaration' LowerBound='6.1' HigherBound='7.1'>
                <om:Property Name='ClassName' Value='Oracle_Application_Import_Definition.DLAPOracle_SUBMITTED_DOCUMENTS_DCMS2.SelectResponse' />
                <om:Property Name='IsBodyPart' Value='True' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='AnalystComments' Value='Adapter metadata message part: ' />
                <om:Property Name='Name' Value='parameters' />
                <om:Property Name='Signal' Value='False' />
            </om:Element>
        </om:Element>
        <om:Element Type='MultipartMessageType' OID='4f184f1b-680b-4a09-8809-e9f35daa5520' ParentLink='Module_MessageType' LowerBound='8.1' HigherBound='12.1'>
            <om:Property Name='TypeModifier' Value='Public' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='AnalystComments' Value='Adapter metadata message type: ' />
            <om:Property Name='Name' Value='ELA_DB_View_SUBMITTED_DOCUMENTS_DCMS2_Select_InputMessage' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='PartDeclaration' OID='9d49d600-6c92-4bd5-8548-240df099a566' ParentLink='MultipartMessageType_PartDeclaration' LowerBound='10.1' HigherBound='11.1'>
                <om:Property Name='ClassName' Value='Oracle_Application_Import_Definition.DLAPOracle_SUBMITTED_DOCUMENTS_DCMS2.Select' />
                <om:Property Name='IsBodyPart' Value='True' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='AnalystComments' Value='Adapter metadata message part: ' />
                <om:Property Name='Name' Value='parameters' />
                <om:Property Name='Signal' Value='False' />
            </om:Element>
        </om:Element>
    </om:Element>
</om:MetaModel>
";

        [System.SerializableAttribute]
        public class __DocumentCoordinatorLogic_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __DocumentCoordinatorLogic_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "DocumentCoordinatorLogic")
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
                DocumentCoordinatorLogic __svc__ = (DocumentCoordinatorLogic)_service;
                __DocumentCoordinatorLogic_root_0 __ctx0__ = (__DocumentCoordinatorLogic_root_0)(__svc__._stateMgrs[0]);

                if (__svc__.OraclePort != null)
                {
                    __svc__.OraclePort.Close(this, null);
                    __svc__.OraclePort = null;
                }
                base.Finally();
            }

            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper0;
        }


        [System.SerializableAttribute]
        public class __DocumentCoordinatorLogic_1 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public __DocumentCoordinatorLogic_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "DocumentCoordinatorLogic")
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
                DocumentCoordinatorLogic __svc__ = (DocumentCoordinatorLogic)_service;
                __DocumentCoordinatorLogic_root_0 __ctx0__ = (__DocumentCoordinatorLogic_root_0)(__svc__._stateMgrs[0]);
                __DocumentCoordinatorLogic_1 __ctx1__ = (__DocumentCoordinatorLogic_1)(__svc__._stateMgrs[1]);

                if (__ctx0__ != null && __ctx0__.__subWrapper0 != null)
                {
                    __ctx0__.__subWrapper0.Destroy(__svc__, __ctx0__);
                    __ctx0__.__subWrapper0 = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__DOC_TYPE_VAL = null;
                if (__ctx1__ != null)
                    __ctx1__.__DocumentType_c = null;
                if (__ctx1__ != null && __ctx1__.__Trigger != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Trigger);
                    __ctx1__.__Trigger = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__FileName_TITLE = null;
                if (__ctx1__ != null)
                    __ctx1__.__FileName_TITLE_Escape = null;
                if (__ctx1__ != null)
                    __ctx1__.__TITLE = null;
                if (__ctx1__ != null)
                    __ctx1__.__DOCUMENT_TYPE_CD_ODA = null;
                if (__ctx1__ != null)
                    __ctx1__.__USR_USER_ID = null;
                if (__ctx1__ != null)
                    __ctx1__.__UserIdIndexXpath = null;
                if (__ctx1__ != null)
                    __ctx1__.__DOC_DATA = null;
                if (__ctx1__ != null)
                    __ctx1__.__DOC_FILEEXTENSION = null;
                if (__ctx1__ != null)
                    __ctx1__.__DOC_PATHONCLIENT = null;
                if (__ctx1__ != null)
                    __ctx1__.__DOC_TITLE = null;
                if (__ctx1__ != null)
                    __ctx1__.__DOC_REASONFORCHANGE = null;
                if (__ctx1__ != null)
                    __ctx1__.__DOC_APPLICATIONID = null;
                if (__ctx1__ != null)
                    __ctx1__.__GetDocField = null;
                if (__ctx1__ != null)
                    __ctx1__.__DocumentIndexXpath = null;
                if (__ctx1__ != null)
                    __ctx1__.__DocAppSalesForceId = null;
                if (__ctx1__ != null)
                    __ctx1__.__DOC_APPLICANT_ID = null;
                if (__ctx1__ != null)
                    __ctx1__.__SalesForceApplicantId = null;
                if (__ctx1__ != null)
                    __ctx1__.__DOC_ORIGIN = null;
                if (__ctx1__ != null && __ctx1__.__SubmittedDocumentsRequestMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__SubmittedDocumentsRequestMsg);
                    __ctx1__.__SubmittedDocumentsRequestMsg = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__DOC_DOCUMENT_C = null;
                if (__ctx1__ != null)
                    __ctx1__.__DOC_DESCRIPTION = null;
                if (__ctx1__ != null && __ctx1__.__SubmittedDocumentsResponseMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__SubmittedDocumentsResponseMsg);
                    __ctx1__.__SubmittedDocumentsResponseMsg = null;
                }
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("SubmittedDocumentsRequestMsg")]
            internal ELA_DB_View_SUBMITTED_DOCUMENTS_DCMS2_Select_InputMessage __SubmittedDocumentsRequestMsg;
            [Microsoft.XLANGs.Core.UserVariableAttribute("SubmittedDocumentsResponseMsg")]
            internal ELA_DB_View_SUBMITTED_DOCUMENTS_DCMS2_Select_OutputMessage __SubmittedDocumentsResponseMsg;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Trigger")]
            public __messagetype_Application_Import_Definition_HomeDisasterLoanApplicationCanonical __Trigger;
            [Microsoft.XLANGs.Core.UserVariableAttribute("TotalCount")]
            internal System.Int32 __TotalCount;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Index")]
            internal System.Int32 __Index;
            [Microsoft.XLANGs.Core.UserVariableAttribute("DocumentIndexXpath")]
            internal System.String __DocumentIndexXpath;
            [Microsoft.XLANGs.Core.UserVariableAttribute("DOC_DESCRIPTION")]
            internal System.String __DOC_DESCRIPTION;
            [Microsoft.XLANGs.Core.UserVariableAttribute("DOC_APPLICATIONID")]
            internal System.String __DOC_APPLICATIONID;
            [Microsoft.XLANGs.Core.UserVariableAttribute("DOC_DATA")]
            internal System.String __DOC_DATA;
            [Microsoft.XLANGs.Core.UserVariableAttribute("DOC_DOCUMENT_C")]
            internal System.String __DOC_DOCUMENT_C;
            [Microsoft.XLANGs.Core.UserVariableAttribute("DOC_FILEEXTENSION")]
            internal System.String __DOC_FILEEXTENSION;
            [Microsoft.XLANGs.Core.UserVariableAttribute("DOC_PATHONCLIENT")]
            internal System.String __DOC_PATHONCLIENT;
            [Microsoft.XLANGs.Core.UserVariableAttribute("DOC_REASONFORCHANGE")]
            internal System.String __DOC_REASONFORCHANGE;
            [Microsoft.XLANGs.Core.UserVariableAttribute("DOC_TITLE")]
            internal System.String __DOC_TITLE;
            [Microsoft.XLANGs.Core.UserVariableAttribute("GetDocField")]
            internal System.String __GetDocField;
            [Microsoft.XLANGs.Core.UserVariableAttribute("DocAppSalesForceId")]
            internal System.String __DocAppSalesForceId;
            [Microsoft.XLANGs.Core.UserVariableAttribute("DOC_APPLICANT_ID")]
            internal System.String __DOC_APPLICANT_ID;
            [Microsoft.XLANGs.Core.UserVariableAttribute("SalesForceApplicantId")]
            internal System.String __SalesForceApplicantId;
            [Microsoft.XLANGs.Core.UserVariableAttribute("DOC_ORIGIN")]
            internal System.String __DOC_ORIGIN;
            [Microsoft.XLANGs.Core.UserVariableAttribute("UserIdIndexXpath")]
            internal System.String __UserIdIndexXpath;
            [Microsoft.XLANGs.Core.UserVariableAttribute("USR_USER_ID")]
            internal System.String __USR_USER_ID;
            [Microsoft.XLANGs.Core.UserVariableAttribute("TITLE")]
            internal System.String __TITLE;
            [Microsoft.XLANGs.Core.UserVariableAttribute("DOC_TYPE_VAL")]
            internal System.String __DOC_TYPE_VAL;
            [Microsoft.XLANGs.Core.UserVariableAttribute("DOCUMENT_TYPE_CD_ODA")]
            internal System.String __DOCUMENT_TYPE_CD_ODA;
            [Microsoft.XLANGs.Core.UserVariableAttribute("DocumentType_c")]
            internal System.String __DocumentType_c;
            [Microsoft.XLANGs.Core.UserVariableAttribute("FileName_TITLE")]
            internal System.String __FileName_TITLE;
            [Microsoft.XLANGs.Core.UserVariableAttribute("FileName_TITLE_Escape")]
            internal System.String __FileName_TITLE_Escape;
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
        [Microsoft.XLANGs.Core.UserVariableAttribute("OraclePort")]
        internal ELA_DB_View_SUBMITTED_DOCUMENTS_DCMS2 OraclePort;

        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {ELA_DB_View_SUBMITTED_DOCUMENTS_DCMS2.Select},
                                               typeof(DocumentCoordinatorLogic).GetField("OraclePort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(DocumentCoordinatorLogic), "OraclePort"),
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
                    typeof(SBA.BizTalk.Shared.Salesforce.Documents.Logic.Upload)                    
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
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "346f7cbb-c9e0-4216-9419-a55f93f5dcf4", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "346f7cbb-c9e0-4216-9419-a55f93f5dcf4", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "02839fd4-8d8f-4eca-8bf0-785b8ed00b81", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "02839fd4-8d8f-4eca-8bf0-785b8ed00b81", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(6, "4bb90429-bb54-4694-96e8-7a47e56a7fbb", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(7, "4bb90429-bb54-4694-96e8-7a47e56a7fbb", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(8, "f18dc206-63ca-4da8-852d-a3248ee609c2", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(9, "f18dc206-63ca-4da8-852d-a3248ee609c2", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(10, "3d3fbf1f-c110-4861-a7ce-74f998fc2130", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(11, "d8020666-ede3-4e56-bfb0-999a5910b646", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(12, "d8020666-ede3-4e56-bfb0-999a5910b646", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(13, "8d757d4c-d8e6-4112-a28c-41a9617dd824", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(14, "8d757d4c-d8e6-4112-a28c-41a9617dd824", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(15, "600288b1-4579-46a4-a720-eccc701e630d", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(16, "0270ef9a-fd90-4d5c-8075-ee541ded90f1", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(17, "0270ef9a-fd90-4d5c-8075-ee541ded90f1", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(18, "5f9f04ae-1e5e-49b6-b585-bd05c9cd0ac1", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(19, "5f9f04ae-1e5e-49b6-b585-bd05c9cd0ac1", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(20, "600288b1-4579-46a4-a720-eccc701e630d", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(21, "2af17403-74d9-423f-a208-fa5d1306cb51", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(22, "2af17403-74d9-423f-a208-fa5d1306cb51", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(23, "3d3fbf1f-c110-4861-a7ce-74f998fc2130", 1, false)
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
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.WhileBody),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.While),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.If),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.If),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Call),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Call),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.While),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.WhileBody)
        };

        public static int[] __progressLocation0 = new int[] { 0,0,0,1,1,};
        public static int[] __progressLocation1 = new int[] { 0,0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,2,2,3,4,4,4,5,6,6,7,8,8,9,10,10,10,11,11,12,13,13,14,14,14,14,15,15,16,16,17,17,17,17,17,17,17,17,17,17,17,17,17,17,17,17,17,17,17,17,17,17,17,17,17,17,17,17,17,17,17,17,17,17,17,17,17,17,17,17,17,17,17,17,17,15,18,18,19,19,19,19,19,19,19,19,19,19,19,19,19,19,19,19,19,19,19,19,19,19,19,19,19,19,19,19,19,19,19,19,19,19,19,19,19,19,19,19,19,19,19,19,19,19,20,21,21,22,23,23,23,1,1,1,1,};

        public static int[][] __progressLocations = new int[2] [] {__progressLocation0,__progressLocation1};
        public override int[][] ProgressLocations {get {return __progressLocations;} }

        public Microsoft.XLANGs.Core.StopConditions segment0(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[0];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[0];
            __DocumentCoordinatorLogic_root_0 __ctx0__ = (__DocumentCoordinatorLogic_root_0)_stateMgrs[0];
            __DocumentCoordinatorLogic_1 __ctx1__ = (__DocumentCoordinatorLogic_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                OraclePort = new ELA_DB_View_SUBMITTED_DOCUMENTS_DCMS2(0, this);
                __ctx__.PrologueCompleted = true;
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.Initialized) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.Initialized;
                goto case 1;
            case 1:
                __ctx1__ = new __DocumentCoordinatorLogic_1(this);
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
            __DocumentCoordinatorLogic_root_0 __ctx0__ = (__DocumentCoordinatorLogic_root_0)_stateMgrs[0];
            __DocumentCoordinatorLogic_1 __ctx1__ = (__DocumentCoordinatorLogic_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx1__.__Trigger = new __messagetype_Application_Import_Definition_HomeDisasterLoanApplicationCanonical("Trigger", __ctx1__);
                __ctx1__.__Trigger.CopyFrom((Microsoft.XLANGs.Core.XMessage)Args[0]);
                __ctx1__.RefMessage(__ctx1__.__Trigger);
                __ctx1__.__Trigger.ConstructionCompleteEvent();
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 1;
            case 1:
                __ctx1__.__TotalCount = default(System.Int32);
                __ctx1__.__Index = default(System.Int32);
                __ctx1__.__DocumentIndexXpath = default(System.String);
                __ctx1__.__DOC_DESCRIPTION = default(System.String);
                __ctx1__.__DOC_APPLICATIONID = default(System.String);
                __ctx1__.__DOC_DATA = default(System.String);
                __ctx1__.__DOC_DOCUMENT_C = default(System.String);
                __ctx1__.__DOC_FILEEXTENSION = default(System.String);
                __ctx1__.__DOC_PATHONCLIENT = default(System.String);
                __ctx1__.__DOC_REASONFORCHANGE = default(System.String);
                __ctx1__.__DOC_TITLE = default(System.String);
                __ctx1__.__GetDocField = default(System.String);
                __ctx1__.__DocAppSalesForceId = default(System.String);
                __ctx1__.__DOC_APPLICANT_ID = default(System.String);
                __ctx1__.__SalesForceApplicantId = default(System.String);
                __ctx1__.__DOC_ORIGIN = default(System.String);
                __ctx1__.__UserIdIndexXpath = default(System.String);
                __ctx1__.__USR_USER_ID = default(System.String);
                __ctx1__.__TITLE = default(System.String);
                __ctx1__.__DOC_TYPE_VAL = default(System.String);
                __ctx1__.__DOCUMENT_TYPE_CD_ODA = default(System.String);
                __ctx1__.__DocumentType_c = default(System.String);
                __ctx1__.__FileName_TITLE = default(System.String);
                __ctx1__.__FileName_TITLE_Escape = default(System.String);
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
                __ctx1__.__Index = 0;
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                __ctx1__.__DocumentIndexXpath = "";
                if ( !PostProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 5;
            case 5:
                __ctx1__.__DOC_DESCRIPTION = System.String.Empty;
                if ( !PostProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 6;
            case 6:
                __ctx1__.__DOC_APPLICATIONID = System.String.Empty;
                if (__ctx1__ != null)
                    __ctx1__.__DOC_APPLICATIONID = null;
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                __ctx1__.__DOC_DATA = System.String.Empty;
                if ( !PostProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 8;
            case 8:
                __ctx1__.__DOC_DOCUMENT_C = "Tax Transcript";
                if (__ctx1__ != null)
                    __ctx1__.__DOC_DOCUMENT_C = null;
                if ( !PostProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 9;
            case 9:
                __ctx1__.__DOC_FILEEXTENSION = System.String.Empty;
                if ( !PostProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 10;
            case 10:
                __ctx1__.__DOC_PATHONCLIENT = "/fake/path";
                if ( !PostProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 11;
            case 11:
                __ctx1__.__DOC_REASONFORCHANGE = "Initial ELA Pull from DLAP";
                if ( !PostProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 12;
            case 12:
                __ctx1__.__DOC_TITLE = System.String.Empty;
                if ( !PostProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 13;
            case 13:
                __ctx1__.__GetDocField = "string(/*[local-name()='SelectResponse' and namespace-uri()='http://Microsoft.LobServices.OracleDB/2007/03/ELA_DB/View/SUBMITTED_DOCUMENTS_DCMS2']/*[local-name()='SelectResult' and namespace-uri()='http://Microsoft.LobServices.OracleDB/2007/03/ELA_DB/View/SUBMITTED_DOCUMENTS_DCMS2']/*[local-name()='SUBMITTED_DOCUMENTS_DCMS2RECORDSELECT' and namespace-uri()='http://Microsoft.LobServices.OracleDB/2007/03/ELA_DB/View/SUBMITTED_DOCUMENTS_DCMS2'][{0}]/*[local-name()='{1}' and namespace-uri()='http://Microsoft.LobServices.OracleDB/2007/03/ELA_DB/View/SUBMITTED_DOCUMENTS_DCMS2']/text())";
                if ( !PostProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 14;
            case 14:
                __ctx1__.__DocAppSalesForceId = "";
                if (__ctx1__ != null)
                    __ctx1__.__DocAppSalesForceId = null;
                if ( !PostProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 15;
            case 15:
                __ctx1__.__DOC_APPLICANT_ID = "";
                if ( !PostProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 16;
            case 16:
                __ctx1__.__SalesForceApplicantId = "";
                if ( !PostProgressInc( __seg__, __ctx__, 17 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 17;
            case 17:
                __ctx1__.__DOC_ORIGIN = "";
                if ( !PostProgressInc( __seg__, __ctx__, 18 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 18;
            case 18:
                __ctx1__.__UserIdIndexXpath = "";
                if ( !PostProgressInc( __seg__, __ctx__, 19 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 19;
            case 19:
                __ctx1__.__USR_USER_ID = "";
                if ( !PostProgressInc( __seg__, __ctx__, 20 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 20;
            case 20:
                __ctx1__.__TITLE = "";
                if ( !PostProgressInc( __seg__, __ctx__, 21 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 21;
            case 21:
                __ctx1__.__DOC_TYPE_VAL = "";
                if ( !PostProgressInc( __seg__, __ctx__, 22 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 22;
            case 22:
                __ctx1__.__DOCUMENT_TYPE_CD_ODA = "";
                if ( !PostProgressInc( __seg__, __ctx__, 23 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 23;
            case 23:
                __ctx1__.__DocumentType_c = "";
                if (__ctx1__ != null)
                    __ctx1__.__DocumentType_c = null;
                if ( !PostProgressInc( __seg__, __ctx__, 24 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 24;
            case 24:
                __ctx1__.__FileName_TITLE = "";
                if ( !PostProgressInc( __seg__, __ctx__, 25 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 25;
            case 25:
                __ctx1__.__FileName_TITLE_Escape = "";
                if ( !PostProgressInc( __seg__, __ctx__, 26 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 26;
            case 26:
                if ( !PreProgressInc( __seg__, __ctx__, 27 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[2],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 27;
            case 27:
                {
                    ELA_DB_View_SUBMITTED_DOCUMENTS_DCMS2_Select_InputMessage __SubmittedDocumentsRequestMsg = new ELA_DB_View_SUBMITTED_DOCUMENTS_DCMS2_Select_InputMessage("SubmittedDocumentsRequestMsg", __ctx1__);

                    ApplyTransform(typeof(Document_Upload_Logic.CreateOracleRequest), new object[] {__SubmittedDocumentsRequestMsg.parameters}, new object[] {__ctx1__.__Trigger.part});

                    if (__ctx1__.__SubmittedDocumentsRequestMsg != null)
                        __ctx1__.UnrefMessage(__ctx1__.__SubmittedDocumentsRequestMsg);
                    __ctx1__.__SubmittedDocumentsRequestMsg = __SubmittedDocumentsRequestMsg;
                    __ctx1__.RefMessage(__ctx1__.__SubmittedDocumentsRequestMsg);
                }
                __ctx1__.__SubmittedDocumentsRequestMsg.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 28 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 28;
            case 28:
                if ( !PreProgressInc( __seg__, __ctx__, 29 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__SubmittedDocumentsRequestMsg);
                    __edata.Messages.Add(__ctx1__.__Trigger);
                    Tracker.FireEvent(__eventLocations[3],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 29;
            case 29:
                if ( !PreProgressInc( __seg__, __ctx__, 30 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[4],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 30;
            case 30:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 31 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 31;
            case 31:
                if ( !PreProgressInc( __seg__, __ctx__, 32 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                OraclePort.SendMessage(0, __ctx1__.__SubmittedDocumentsRequestMsg, null, null, out __ctx0__.__subWrapper0, __ctx1__, __seg__ );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 32;
            case 32:
                if ( !PreProgressInc( __seg__, __ctx__, 33 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__SubmittedDocumentsRequestMsg);
                    __edata.PortName = @"OraclePort";
                    Tracker.FireEvent(__eventLocations[5],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__SubmittedDocumentsRequestMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__SubmittedDocumentsRequestMsg);
                    __ctx1__.__SubmittedDocumentsRequestMsg = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 33;
            case 33:
                if ( !PreProgressInc( __seg__, __ctx__, 34 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[6],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 34;
            case 34:
                if (!OraclePort.GetMessageId(__ctx0__.__subWrapper0.getSubscription(this), __seg__, __ctx1__, out __msgEnv__, _locations[0]))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx0__ != null && __ctx0__.__subWrapper0 != null)
                {
                    __ctx0__.__subWrapper0.Destroy(this, __ctx0__);
                    __ctx0__.__subWrapper0 = null;
                }
                if (__ctx1__.__SubmittedDocumentsResponseMsg != null)
                    __ctx1__.UnrefMessage(__ctx1__.__SubmittedDocumentsResponseMsg);
                __ctx1__.__SubmittedDocumentsResponseMsg = new ELA_DB_View_SUBMITTED_DOCUMENTS_DCMS2_Select_OutputMessage("SubmittedDocumentsResponseMsg", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__SubmittedDocumentsResponseMsg);
                OraclePort.ReceiveMessage(0, __msgEnv__, __ctx1__.__SubmittedDocumentsResponseMsg, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if (OraclePort != null)
                {
                    OraclePort.Close(__ctx1__, __seg__);
                    OraclePort = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 35 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 35;
            case 35:
                if ( !PreProgressInc( __seg__, __ctx__, 36 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__SubmittedDocumentsResponseMsg);
                    __edata.PortName = @"OraclePort";
                    Tracker.FireEvent(__eventLocations[7],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 36;
            case 36:
                if ( !PreProgressInc( __seg__, __ctx__, 37 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[8],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 37;
            case 37:
                __ctx1__.__TotalCount = (System.Int32)Microsoft.XLANGs.Core.Part.XPathLoad(__ctx1__.__SubmittedDocumentsResponseMsg.parameters, "count(/*[local-name()='SelectResponse' and namespace-uri()='http://Microsoft.LobServices.OracleDB/2007/03/ELA_DB/View/SUBMITTED_DOCUMENTS_DCMS2']/*[local-name()='SelectResult' and namespace-uri()='http://Microsoft.LobServices.OracleDB/2007/03/ELA_DB/View/SUBMITTED_DOCUMENTS_DCMS2']/*[local-name()='SUBMITTED_DOCUMENTS_DCMS2RECORDSELECT' and namespace-uri()='http://Microsoft.LobServices.OracleDB/2007/03/ELA_DB/View/SUBMITTED_DOCUMENTS_DCMS2'])", typeof(System.Int32));
                if ( !PostProgressInc( __seg__, __ctx__, 38 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 38;
            case 38:
                if ( !PreProgressInc( __seg__, __ctx__, 39 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[9],__eventData[6],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 39;
            case 39:
                if ( !PreProgressInc( __seg__, __ctx__, 40 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[10],__eventData[7],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 40;
            case 40:
                __condition__ = __ctx1__.__Index < __ctx1__.__TotalCount;
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 155 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 155;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 41 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 41;
            case 41:
                if ( !PreProgressInc( __seg__, __ctx__, 42 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[10],__eventData[8],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 42;
            case 42:
                if ( !PreProgressInc( __seg__, __ctx__, 43 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[11],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 43;
            case 43:
                __ctx1__.__Index = __ctx1__.__Index + 1;
                if ( !PostProgressInc( __seg__, __ctx__, 44 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 44;
            case 44:
                if ( !PreProgressInc( __seg__, __ctx__, 45 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[12],__eventData[6],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 45;
            case 45:
                if ( !PreProgressInc( __seg__, __ctx__, 46 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[13],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 46;
            case 46:
                __ctx1__.__DocumentIndexXpath = System.String.Format(__ctx1__.__GetDocField, __ctx1__.__Index, "DOC_ORIGIN");
                if ( !PostProgressInc( __seg__, __ctx__, 47 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 47;
            case 47:
                if ( !PreProgressInc( __seg__, __ctx__, 48 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[14],__eventData[6],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 48;
            case 48:
                __ctx1__.__DOC_ORIGIN = (System.String)Microsoft.XLANGs.Core.Part.XPathLoad(__ctx1__.__SubmittedDocumentsResponseMsg.parameters, __ctx1__.__DocumentIndexXpath, typeof(System.String));
                if ( !PostProgressInc( __seg__, __ctx__, 49 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 49;
            case 49:
                __ctx1__.__DocumentIndexXpath = System.String.Format(__ctx1__.__GetDocField, __ctx1__.__Index, "DOC_APPLICANT_ID");
                if ( !PostProgressInc( __seg__, __ctx__, 50 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 50;
            case 50:
                __ctx1__.__DOC_APPLICANT_ID = (System.String)Microsoft.XLANGs.Core.Part.XPathLoad(__ctx1__.__SubmittedDocumentsResponseMsg.parameters, __ctx1__.__DocumentIndexXpath, typeof(System.String));
                if ( !PostProgressInc( __seg__, __ctx__, 51 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 51;
            case 51:
                if ( !PreProgressInc( __seg__, __ctx__, 52 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[15],__eventData[9],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 52;
            case 52:
                __condition__ = __ctx1__.__DOC_APPLICANT_ID == "0";
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 101 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 101;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 53 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 53;
            case 53:
                if ( !PreProgressInc( __seg__, __ctx__, 54 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[16],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 54;
            case 54:
                __ctx1__.__DocumentIndexXpath = System.String.Format(__ctx1__.__GetDocField, __ctx1__.__Index, "DOC_ID");
                if ( !PostProgressInc( __seg__, __ctx__, 55 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 55;
            case 55:
                if ( !PreProgressInc( __seg__, __ctx__, 56 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[17],__eventData[6],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 56;
            case 56:
                __ctx1__.__DOC_DESCRIPTION = (System.String)Microsoft.XLANGs.Core.Part.XPathLoad(__ctx1__.__SubmittedDocumentsResponseMsg.parameters, __ctx1__.__DocumentIndexXpath, typeof(System.String));
                if ( !PostProgressInc( __seg__, __ctx__, 57 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 57;
            case 57:
                __ctx1__.__DocumentIndexXpath = System.String.Format(__ctx1__.__GetDocField, __ctx1__.__Index, "DOC_CONTENTS");
                if ( !PostProgressInc( __seg__, __ctx__, 58 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 58;
            case 58:
                __ctx1__.__DOC_DATA = (System.String)Microsoft.XLANGs.Core.Part.XPathLoad(__ctx1__.__SubmittedDocumentsResponseMsg.parameters, __ctx1__.__DocumentIndexXpath, typeof(System.String));
                if ( !PostProgressInc( __seg__, __ctx__, 59 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 59;
            case 59:
                __ctx1__.__DocumentIndexXpath = System.String.Format(__ctx1__.__GetDocField, __ctx1__.__Index, "DOC_CONTENT_TYPE");
                if ( !PostProgressInc( __seg__, __ctx__, 60 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 60;
            case 60:
                __ctx1__.__DOC_FILEEXTENSION = (System.String)Microsoft.XLANGs.Core.Part.XPathLoad(__ctx1__.__SubmittedDocumentsResponseMsg.parameters, __ctx1__.__DocumentIndexXpath, typeof(System.String));
                if ( !PostProgressInc( __seg__, __ctx__, 61 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 61;
            case 61:
                __ctx1__.__DocumentIndexXpath = System.String.Format(__ctx1__.__GetDocField, __ctx1__.__Index, "DOC_INSTANCE_NAME");
                if ( !PostProgressInc( __seg__, __ctx__, 62 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 62;
            case 62:
                __ctx1__.__TITLE = (System.String)Microsoft.XLANGs.Core.Part.XPathLoad(__ctx1__.__SubmittedDocumentsResponseMsg.parameters, __ctx1__.__DocumentIndexXpath, typeof(System.String));
                if ( !PostProgressInc( __seg__, __ctx__, 63 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 63;
            case 63:
                __ctx1__.__FileName_TITLE_Escape = System.IO.Path.GetFileNameWithoutExtension(__ctx1__.__TITLE);
                if ( !PostProgressInc( __seg__, __ctx__, 64 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 64;
            case 64:
                __ctx1__.__FileName_TITLE = System.Security.SecurityElement.Escape(__ctx1__.__FileName_TITLE_Escape);
                if ( !PostProgressInc( __seg__, __ctx__, 65 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 65;
            case 65:
                if ( !PreProgressInc( __seg__, __ctx__, 66 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[1],__eventData[9],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 66;
            case 66:
                __condition__ = __ctx1__.__DOC_FILEEXTENSION == "application/pdf";
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 69 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 69;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 67 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 67;
            case 67:
                __ctx1__.__DOC_TITLE = __ctx1__.__FileName_TITLE + ".pdf";
                if ( !PostProgressInc( __seg__, __ctx__, 68 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 68;
            case 68:
                if ( !PostProgressInc( __seg__, __ctx__, 70 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 70;
            case 69:
                __ctx1__.__DOC_TITLE = __ctx1__.__FileName_TITLE + ".pdf";
                if ( !PostProgressInc( __seg__, __ctx__, 70 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 70;
            case 70:
                if ( !PreProgressInc( __seg__, __ctx__, 71 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[0],__eventData[10],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 71;
            case 71:
                __ctx1__.__DOC_PATHONCLIENT = "/fake/" + __ctx1__.__DOC_TITLE;
                if ( !PostProgressInc( __seg__, __ctx__, 72 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 72;
            case 72:
                __ctx1__.__DocumentIndexXpath = System.String.Format(__ctx1__.__GetDocField, __ctx1__.__Index, "DOC_APPLICANT_ID");
                if ( !PostProgressInc( __seg__, __ctx__, 73 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 73;
            case 73:
                __ctx1__.__DOC_APPLICANT_ID = (System.String)Microsoft.XLANGs.Core.Part.XPathLoad(__ctx1__.__SubmittedDocumentsResponseMsg.parameters, __ctx1__.__DocumentIndexXpath, typeof(System.String));
                if ( !PostProgressInc( __seg__, __ctx__, 74 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 74;
            case 74:
                __ctx1__.__SalesForceApplicantId = (System.String)Microsoft.XLANGs.Core.Part.XPathLoad(__ctx1__.__Trigger.part, @"string(/*[local-name()='Application' and namespace-uri()='http://SBA.ODA.Gov/CanonicalApplication']/*[local-name()='SalesForceApplication__cID' and namespace-uri()='']/text())", typeof(System.String));
                if ( !PostProgressInc( __seg__, __ctx__, 75 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 75;
            case 75:
                __ctx1__.__DocumentIndexXpath = System.String.Format(__ctx1__.__GetDocField, __ctx1__.__Index, "DOC_TYPE");
                if ( !PostProgressInc( __seg__, __ctx__, 76 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 76;
            case 76:
                __ctx1__.__DOCUMENT_TYPE_CD_ODA = (System.String)Microsoft.XLANGs.Core.Part.XPathLoad(__ctx1__.__SubmittedDocumentsResponseMsg.parameters, __ctx1__.__DocumentIndexXpath, typeof(System.String));
                if ( !PostProgressInc( __seg__, __ctx__, 77 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 77;
            case 77:
                if ( !PreProgressInc( __seg__, __ctx__, 78 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[1],__eventData[9],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 78;
            case 78:
                __condition__ = !System.String.IsNullOrWhiteSpace(__ctx1__.__DOCUMENT_TYPE_CD_ODA);
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 96 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 96;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 79 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 79;
            case 79:
                if ( !PreProgressInc( __seg__, __ctx__, 80 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[1],__eventData[9],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 80;
            case 80:
                __condition__ = __ctx1__.__DOCUMENT_TYPE_CD_ODA == "525";
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 83 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 83;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 81 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 81;
            case 81:
                __ctx1__.__DOC_TYPE_VAL = "4506T";
                if ( !PostProgressInc( __seg__, __ctx__, 82 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 82;
            case 82:
                if ( !PostProgressInc( __seg__, __ctx__, 94 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 94;
            case 83:
                if ( !PreProgressInc( __seg__, __ctx__, 84 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[1],__eventData[9],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 84;
            case 84:
                __condition__ = __ctx1__.__DOCUMENT_TYPE_CD_ODA == "542";
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 87 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 87;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 85 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 85;
            case 85:
                __ctx1__.__DOC_TYPE_VAL = "Schedule of Liabilities (2202)";
                if ( !PostProgressInc( __seg__, __ctx__, 86 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 86;
            case 86:
                if ( !PostProgressInc( __seg__, __ctx__, 93 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 93;
            case 87:
                if ( !PreProgressInc( __seg__, __ctx__, 88 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[1],__eventData[9],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 88;
            case 88:
                __condition__ = __ctx1__.__DOCUMENT_TYPE_CD_ODA == "544";
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 91 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 91;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 89 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 89;
            case 89:
                __ctx1__.__DOC_TYPE_VAL = "Personal Financial Statement (413)";
                if ( !PostProgressInc( __seg__, __ctx__, 90 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 90;
            case 90:
                if ( !PostProgressInc( __seg__, __ctx__, 92 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 92;
            case 91:
                __ctx1__.__DOC_TYPE_VAL = "Other";
                if ( !PostProgressInc( __seg__, __ctx__, 92 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 92;
            case 92:
                if ( !PreProgressInc( __seg__, __ctx__, 93 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[0],__eventData[10],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 93;
            case 93:
                if ( !PreProgressInc( __seg__, __ctx__, 94 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[0],__eventData[10],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 94;
            case 94:
                if ( !PreProgressInc( __seg__, __ctx__, 95 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[0],__eventData[10],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 95;
            case 95:
                if ( !PostProgressInc( __seg__, __ctx__, 97 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 97;
            case 96:
                __ctx1__.__DOC_TYPE_VAL = "Other";
                if ( !PostProgressInc( __seg__, __ctx__, 97 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 97;
            case 97:
                if ( !PreProgressInc( __seg__, __ctx__, 98 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[0],__eventData[10],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 98;
            case 98:
                __ctx1__.__UserIdIndexXpath = System.String.Format(__ctx1__.__GetDocField, __ctx1__.__Index, "DOC_USR_ID");
                if ( !PostProgressInc( __seg__, __ctx__, 99 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 99;
            case 99:
                __ctx1__.__USR_USER_ID = (System.String)Microsoft.XLANGs.Core.Part.XPathLoad(__ctx1__.__SubmittedDocumentsResponseMsg.parameters, __ctx1__.__UserIdIndexXpath, typeof(System.String));
                if ( !PostProgressInc( __seg__, __ctx__, 100 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 100;
            case 100:
                if ( !PostProgressInc( __seg__, __ctx__, 149 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 149;
            case 101:
                if ( !PreProgressInc( __seg__, __ctx__, 102 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[18],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 102;
            case 102:
                __ctx1__.__DocumentIndexXpath = System.String.Format(__ctx1__.__GetDocField, __ctx1__.__Index, "DOC_ID");
                if ( !PostProgressInc( __seg__, __ctx__, 103 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 103;
            case 103:
                if ( !PreProgressInc( __seg__, __ctx__, 104 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[19],__eventData[6],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 104;
            case 104:
                __ctx1__.__DOC_DESCRIPTION = (System.String)Microsoft.XLANGs.Core.Part.XPathLoad(__ctx1__.__SubmittedDocumentsResponseMsg.parameters, __ctx1__.__DocumentIndexXpath, typeof(System.String));
                if ( !PostProgressInc( __seg__, __ctx__, 105 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 105;
            case 105:
                __ctx1__.__DocumentIndexXpath = System.String.Format(__ctx1__.__GetDocField, __ctx1__.__Index, "DOC_CONTENTS");
                if ( !PostProgressInc( __seg__, __ctx__, 106 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 106;
            case 106:
                __ctx1__.__DOC_DATA = (System.String)Microsoft.XLANGs.Core.Part.XPathLoad(__ctx1__.__SubmittedDocumentsResponseMsg.parameters, __ctx1__.__DocumentIndexXpath, typeof(System.String));
                if ( !PostProgressInc( __seg__, __ctx__, 107 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 107;
            case 107:
                __ctx1__.__DocumentIndexXpath = System.String.Format(__ctx1__.__GetDocField, __ctx1__.__Index, "DOC_CONTENT_TYPE");
                if ( !PostProgressInc( __seg__, __ctx__, 108 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 108;
            case 108:
                __ctx1__.__DOC_FILEEXTENSION = (System.String)Microsoft.XLANGs.Core.Part.XPathLoad(__ctx1__.__SubmittedDocumentsResponseMsg.parameters, __ctx1__.__DocumentIndexXpath, typeof(System.String));
                if ( !PostProgressInc( __seg__, __ctx__, 109 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 109;
            case 109:
                __ctx1__.__DocumentIndexXpath = System.String.Format(__ctx1__.__GetDocField, __ctx1__.__Index, "DOC_INSTANCE_NAME");
                if ( !PostProgressInc( __seg__, __ctx__, 110 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 110;
            case 110:
                __ctx1__.__TITLE = (System.String)Microsoft.XLANGs.Core.Part.XPathLoad(__ctx1__.__SubmittedDocumentsResponseMsg.parameters, __ctx1__.__DocumentIndexXpath, typeof(System.String));
                if ( !PostProgressInc( __seg__, __ctx__, 111 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 111;
            case 111:
                __ctx1__.__FileName_TITLE = System.IO.Path.GetFileNameWithoutExtension(__ctx1__.__TITLE);
                if ( !PostProgressInc( __seg__, __ctx__, 112 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 112;
            case 112:
                __ctx1__.__FileName_TITLE_Escape = System.IO.Path.GetFileNameWithoutExtension(__ctx1__.__TITLE);
                if ( !PostProgressInc( __seg__, __ctx__, 113 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 113;
            case 113:
                __ctx1__.__FileName_TITLE = System.Security.SecurityElement.Escape(__ctx1__.__FileName_TITLE_Escape);
                if ( !PostProgressInc( __seg__, __ctx__, 114 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 114;
            case 114:
                if ( !PreProgressInc( __seg__, __ctx__, 115 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[1],__eventData[9],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 115;
            case 115:
                __condition__ = __ctx1__.__DOC_FILEEXTENSION == "application/pdf";
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 118 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 118;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 116 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 116;
            case 116:
                __ctx1__.__DOC_TITLE = __ctx1__.__FileName_TITLE + ".pdf";
                if ( !PostProgressInc( __seg__, __ctx__, 117 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 117;
            case 117:
                if ( !PostProgressInc( __seg__, __ctx__, 119 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 119;
            case 118:
                __ctx1__.__DOC_TITLE = __ctx1__.__FileName_TITLE + ".pdf";
                if ( !PostProgressInc( __seg__, __ctx__, 119 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 119;
            case 119:
                if ( !PreProgressInc( __seg__, __ctx__, 120 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[0],__eventData[10],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 120;
            case 120:
                __ctx1__.__DOC_PATHONCLIENT = "/fake/" + __ctx1__.__DOC_TITLE;
                if ( !PostProgressInc( __seg__, __ctx__, 121 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 121;
            case 121:
                __ctx1__.__DocumentIndexXpath = System.String.Format(__ctx1__.__GetDocField, __ctx1__.__Index, "DOC_APPLICANT_ID");
                if ( !PostProgressInc( __seg__, __ctx__, 122 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 122;
            case 122:
                __ctx1__.__DOC_APPLICANT_ID = (System.String)Microsoft.XLANGs.Core.Part.XPathLoad(__ctx1__.__SubmittedDocumentsResponseMsg.parameters, __ctx1__.__DocumentIndexXpath, typeof(System.String));
                if ( !PostProgressInc( __seg__, __ctx__, 123 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 123;
            case 123:
                __ctx1__.__SalesForceApplicantId = (System.String)Microsoft.XLANGs.Core.Part.XPathLoad(__ctx1__.__Trigger.part, @"string(
                    /*[local-name()='Application' and namespace-uri()='http://SBA.ODA.Gov/CanonicalApplication']
                    /*[local-name()='ApplicantColl' and namespace-uri()='']
                    /*[local-name()='Applicants' and namespace-uri()='' ]
                    /*[local-name()='ApplicantId' and namespace-uri()='' and text()='" + __ctx1__.__DOC_APPLICANT_ID + @"']/..
                    /*[local-name()='SalesForceApplicantID' and namespace-uri()='']/text())", typeof(System.String));
                if ( !PostProgressInc( __seg__, __ctx__, 124 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 124;
            case 124:
                __ctx1__.__DocumentIndexXpath = System.String.Format(__ctx1__.__GetDocField, __ctx1__.__Index, "DOC_TYPE");
                if ( !PostProgressInc( __seg__, __ctx__, 125 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 125;
            case 125:
                __ctx1__.__DOCUMENT_TYPE_CD_ODA = (System.String)Microsoft.XLANGs.Core.Part.XPathLoad(__ctx1__.__SubmittedDocumentsResponseMsg.parameters, __ctx1__.__DocumentIndexXpath, typeof(System.String));
                if ( !PostProgressInc( __seg__, __ctx__, 126 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 126;
            case 126:
                if ( !PreProgressInc( __seg__, __ctx__, 127 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[1],__eventData[9],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 127;
            case 127:
                __condition__ = !System.String.IsNullOrWhiteSpace(__ctx1__.__DOCUMENT_TYPE_CD_ODA);
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 145 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 145;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 128 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 128;
            case 128:
                if ( !PreProgressInc( __seg__, __ctx__, 129 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[1],__eventData[9],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 129;
            case 129:
                __condition__ = __ctx1__.__DOCUMENT_TYPE_CD_ODA == "525";
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 132 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 132;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 130 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 130;
            case 130:
                __ctx1__.__DOC_TYPE_VAL = "4506T";
                if ( !PostProgressInc( __seg__, __ctx__, 131 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 131;
            case 131:
                if ( !PostProgressInc( __seg__, __ctx__, 143 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 143;
            case 132:
                if ( !PreProgressInc( __seg__, __ctx__, 133 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[1],__eventData[9],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 133;
            case 133:
                __condition__ = __ctx1__.__DOCUMENT_TYPE_CD_ODA == "542";
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 136 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 136;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 134 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 134;
            case 134:
                __ctx1__.__DOC_TYPE_VAL = "Schedule of Liabilities (2202)";
                if ( !PostProgressInc( __seg__, __ctx__, 135 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 135;
            case 135:
                if ( !PostProgressInc( __seg__, __ctx__, 142 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 142;
            case 136:
                if ( !PreProgressInc( __seg__, __ctx__, 137 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[1],__eventData[9],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 137;
            case 137:
                __condition__ = __ctx1__.__DOCUMENT_TYPE_CD_ODA == "544";
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 140 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 140;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 138 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 138;
            case 138:
                __ctx1__.__DOC_TYPE_VAL = "Personal Financial Statement (413)";
                if ( !PostProgressInc( __seg__, __ctx__, 139 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 139;
            case 139:
                if ( !PostProgressInc( __seg__, __ctx__, 141 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 141;
            case 140:
                __ctx1__.__DOC_TYPE_VAL = "Other";
                if ( !PostProgressInc( __seg__, __ctx__, 141 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 141;
            case 141:
                if ( !PreProgressInc( __seg__, __ctx__, 142 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[0],__eventData[10],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 142;
            case 142:
                if ( !PreProgressInc( __seg__, __ctx__, 143 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[0],__eventData[10],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 143;
            case 143:
                if ( !PreProgressInc( __seg__, __ctx__, 144 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[0],__eventData[10],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 144;
            case 144:
                if ( !PostProgressInc( __seg__, __ctx__, 146 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 146;
            case 145:
                __ctx1__.__DOC_TYPE_VAL = "Other";
                if ( !PostProgressInc( __seg__, __ctx__, 146 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 146;
            case 146:
                if ( !PreProgressInc( __seg__, __ctx__, 147 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[0],__eventData[10],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 147;
            case 147:
                __ctx1__.__UserIdIndexXpath = System.String.Format(__ctx1__.__GetDocField, __ctx1__.__Index, "DOC_USR_ID");
                if ( !PostProgressInc( __seg__, __ctx__, 148 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 148;
            case 148:
                __ctx1__.__USR_USER_ID = (System.String)Microsoft.XLANGs.Core.Part.XPathLoad(__ctx1__.__SubmittedDocumentsResponseMsg.parameters, __ctx1__.__UserIdIndexXpath, typeof(System.String));
                if ( !PostProgressInc( __seg__, __ctx__, 149 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 149;
            case 149:
                if ( !PreProgressInc( __seg__, __ctx__, 150 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[20],__eventData[10],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 150;
            case 150:
                if ( !PreProgressInc( __seg__, __ctx__, 151 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[21],__eventData[11],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 151;
            case 151:
                {
                    Microsoft.XLANGs.Core.Service svc = new SBA.BizTalk.Shared.Salesforce.Documents.Logic.Upload(2, InstanceId, this);
                    _stateMgrs[2] = svc;
                    __ctx1__.StartCall(__seg__, svc, __eventLocations[21],new object[] {__ctx1__.__DOC_TITLE, __ctx1__.__DOC_DESCRIPTION, __ctx1__.__DOC_PATHONCLIENT, __ctx1__.__DOC_DATA, __ctx1__.__DOC_FILEEXTENSION, __ctx1__.__DOC_TYPE_VAL, __ctx1__.__DOC_REASONFORCHANGE, __ctx1__.__SalesForceApplicantId, __ctx1__.__USR_USER_ID, __ctx1__.__DOCUMENT_TYPE_CD_ODA});
                }
                if ( !PostProgressInc( __seg__, __ctx__, 152 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 152:
                if ( !PreProgressInc( __seg__, __ctx__, 153 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    object[] args = ((Microsoft.XLANGs.Core.Service)_stateMgrs[2]).Args;
                }
                Tracker.FireEvent(__eventLocations[22],__eventData[12],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 153;
            case 153:
                if ( !PreProgressInc( __seg__, __ctx__, 154 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[23],__eventData[13],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 154;
            case 154:
                if ( !PostProgressInc( __seg__, __ctx__, 40 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 40;
            case 155:
                if ( !PreProgressInc( __seg__, __ctx__, 156 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if (__ctx1__ != null)
                    __ctx1__.__FileName_TITLE_Escape = null;
                if (__ctx1__ != null)
                    __ctx1__.__FileName_TITLE = null;
                if (__ctx1__ != null)
                    __ctx1__.__DOCUMENT_TYPE_CD_ODA = null;
                if (__ctx1__ != null)
                    __ctx1__.__DOC_TYPE_VAL = null;
                if (__ctx1__ != null)
                    __ctx1__.__TITLE = null;
                if (__ctx1__ != null)
                    __ctx1__.__USR_USER_ID = null;
                if (__ctx1__ != null)
                    __ctx1__.__UserIdIndexXpath = null;
                if (__ctx1__ != null)
                    __ctx1__.__DOC_ORIGIN = null;
                if (__ctx1__ != null)
                    __ctx1__.__SalesForceApplicantId = null;
                if (__ctx1__ != null)
                    __ctx1__.__DOC_APPLICANT_ID = null;
                if (__ctx1__ != null)
                    __ctx1__.__GetDocField = null;
                if (__ctx1__ != null)
                    __ctx1__.__DOC_TITLE = null;
                if (__ctx1__ != null)
                    __ctx1__.__DOC_REASONFORCHANGE = null;
                if (__ctx1__ != null)
                    __ctx1__.__DOC_PATHONCLIENT = null;
                if (__ctx1__ != null)
                    __ctx1__.__DOC_FILEEXTENSION = null;
                if (__ctx1__ != null)
                    __ctx1__.__DOC_DATA = null;
                if (__ctx1__ != null)
                    __ctx1__.__DOC_DESCRIPTION = null;
                if (__ctx1__ != null)
                    __ctx1__.__DocumentIndexXpath = null;
                if (__ctx1__ != null && __ctx1__.__SubmittedDocumentsResponseMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__SubmittedDocumentsResponseMsg);
                    __ctx1__.__SubmittedDocumentsResponseMsg = null;
                }
                Tracker.FireEvent(__eventLocations[23],__eventData[14],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 156;
            case 156:
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Body);
                    __edata.Messages.Add(__ctx1__.__Trigger);
                    Tracker.FireEvent(__eventLocations[0],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__Trigger != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Trigger);
                    __ctx1__.__Trigger = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 157 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 157;
            case 157:
                if (!__ctx1__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 158 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 158;
            case 158:
                if ( !PreProgressInc( __seg__, __ctx__, 159 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx1__.OnCommit();
                goto case 159;
            case 159:
                __seg__.SegmentDone();
                _segments[0].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }
        private static Microsoft.XLANGs.Core.CachedObject[] _locations = new Microsoft.XLANGs.Core.CachedObject[] {
            new Microsoft.XLANGs.Core.CachedObject(new System.Guid("{74BDFDC1-852B-4754-8092-767904E1218C}"))
        };

    }

    [System.SerializableAttribute]
    sealed public class __Application_Import_Definition_HomeDisasterLoanApplicationCanonical__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static Application_Import_Definition.HomeDisasterLoanApplicationCanonical _schema = new Application_Import_Definition.HomeDisasterLoanApplicationCanonical();

        public __Application_Import_Definition_HomeDisasterLoanApplicationCanonical__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "Application_Import_Definition.HomeDisasterLoanApplicationCanonical",
        new System.Type[]{
            typeof(Application_Import_Definition.HomeDisasterLoanApplicationCanonical)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__Application_Import_Definition_HomeDisasterLoanApplicationCanonical__)
        },
        0,
        @"http://SBA.ODA.Gov/CanonicalApplication#Application"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_Application_Import_Definition_HomeDisasterLoanApplicationCanonical : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __Application_Import_Definition_HomeDisasterLoanApplicationCanonical__ part;

        private void __CreatePartWrappers()
        {
            part = new __Application_Import_Definition_HomeDisasterLoanApplicationCanonical__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_Application_Import_Definition_HomeDisasterLoanApplicationCanonical(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed public class _MODULE_PROXY_ { }
}
