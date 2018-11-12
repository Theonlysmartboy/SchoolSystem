Public Class StreamItem
	Public Sub New(ByVal id As Integer, ByVal name As String)
		sID = id
		sName = name
	End Sub
	Private sID As Integer
	Public Property id() As Integer
		Get
			Return sID
		End Get
		Set(ByVal value As Integer)
			sID = value
		End Set
	End Property
	Private sName As String
	Public Property name() As String
		Get
			Return sName
		End Get
		Set(ByVal value As String)
			sName = value
		End Set
	End Property
End Class
