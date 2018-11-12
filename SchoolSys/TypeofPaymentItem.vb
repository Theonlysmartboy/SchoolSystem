Public Class TypeofPaymentItem
	Public Sub New(ByVal id As Integer, ByVal types As String)
		tID = id
		tName = types
	End Sub
	Private tID As Integer
	Public Property id() As Integer
		Get
			Return tID
		End Get
		Set(ByVal value As Integer)
			tID = value
		End Set
	End Property
	Private tName As String
	Public Property types() As String
		Get
			Return tName
		End Get
		Set(ByVal value As String)
			tName = value
		End Set
	End Property
End Class
