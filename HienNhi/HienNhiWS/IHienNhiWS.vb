Imports System.ServiceModel

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IHienNhiWS" in both code and config file together.
<ServiceContract()>
Public Interface IHienNhiWS

    <OperationContract()>
    Function GetTenSP(MaSP As String) As String


End Interface
