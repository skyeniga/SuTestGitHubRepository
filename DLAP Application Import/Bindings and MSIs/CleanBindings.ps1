$BindingFilePath = '.\DLAP Application Import Bindings For Deployment.xml'
$BindingFilePathClean = '..\Deployment\DLAP Application Import.xml'


#
#	All SalesForce credentials are replaced with {SFUSERNAME}, {SFPASSWORD}, and {SFAPIKEY}
#	All Oracle passwords are replaced with {ORACLEUSERNAME} and {ORACLEPASSWORD}
#
#InboundMessageBody OutboundMessageBody
#<Tracking>0</Tracking>
#Salesforce:
#Login URL=https://sba-oda--dev10.cs32.my.salesforce.com/services/Soap/c/40.0
$SFLoginUrl = 'Login URL="?https://sba-oda--dev10.cs32.my.salesforce.com/services/Soap/c/40.0;?"?'
$SFLoginUrlGeneric = 'Login URL={SFADDRESS}'
$SFPassword = "Password=`"?7YrfB-X]4pgBd6`'G`"?"
$SFPasswordGeneric = "Password={SFPASSWORD}"
$SFUserName = "User=biztalk-dev10@sba.gov.dev10"
$SFUserNameGeneric = "User={SFUSERNAME}"
$SFSecurityToken = "Security Token=Y4rGmcwYHjJzlmHqe0VxgVElq"
$SFSecurityTokenGeneric = "Security Token={SFAPIKEY}"

#Oracle:
$ORAUserName = "&lt;UserName vt=`"8`"&gt;DCMS_INT&lt;/UserName&gt"
$ORAUserNameGeneric = "&lt;UserName vt=`"8`"&gt;{ORACLEUSERNAME}&lt;/UserName&gt"
$OraPassword = "&lt;PassWord vt=`"8`"&gt;bld1_sbx0707&lt;/PassWord&gt;"
$OraPasswordGeneric = "&lt;PassWord vt=`"8`"&gt;{ORACLEPASSWORD}&lt;/PassWord&gt;"
$OraServer = 'oracledb://ela_dev3.sba.gov'
$OraServerGeneric = 'oracledb://{ORACLEADDRESS}'

#Tracking:
$FindTracking = '<Tracking>(([0-1]?[0-9]?[0-9])|([2][0-4][0-9])|(25[0-5]))</Tracking>'
$NewTracking = '<Tracking>0</Tracking>'
$BodyTrackingFull = 'TrackingOption="ServiceStartEnd MessageSendReceive InboundMessageBody OutboundMessageBody'
$BodyTrackingNone = 'TrackingOption="ServiceStartEnd MessageSendReceive'



#Tracking


Clear-host
"Reading Input file " + $BindingFilePath
$input = Get-Content -Path $BindingFilePath
"Replacing SF Username"
$a = $input -replace $SFUserName, $SFUserNameGeneric
"Replacing SF Login URL"
$b = $a -replace $SFLoginUrl, $SFLoginUrlGeneric
"Replacing SF Password"
$c = $b -replace $SFPassword, $SFPasswordGeneric
"Replacing SF Security Token"
$d = $c -replace $SFSecurityToken, $SFSecurityTokenGeneric

"Replacing Oracle Username"
$e = $d -replace $ORAUserName, $ORAUserNameGeneric
"Replacing Oracle Password"
$f = $e -replace $OraPassword, $OraPasswordGeneric
"Replacing Oracle Server"
$z = $f -replace $OraServer, $OraServerGeneric

"Removing Tracking"
#$h = $g -replace $FindTracking, $NewTracking
#$z = $h -replace $BodyTrackingFull, $BodyTrackingNone


"Writing results file " + $BindingFilePathClean
$z | Set-Content -Path $BindingFilePathClean