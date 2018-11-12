
Imports MySql.Data.MySqlClient
Public Class VIewStudentRecords
    'variable for mysql connection
    Dim MysqlConn As MySqlConnection
    Dim result As Integer
    Private Sub VIewStudentRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            MysqlConn = New MySqlConnection
            MysqlConn.ConnectionString = "server='" & My.Settings.Server & "';user='" & My.Settings.DbUser & "';password='" & My.Settings.DbPass & "';database='" & My.Settings.Db & "';SslMode=none"
            Dim sql As String = "select admno as Admission_Number, concat(firstname,' ', lastname, '', othernames) as Name, gender as Gender, doa as Admission_Date, dob as Date_Of_Birth, kcpemarks KCPE_marks, kcpeschool as KCPE_School, concat(classes.name,'', stream.name ) as Class from student INNER join classes on class = classes.id INNER JOIN stream on student.stream = stream.id"
            Dim dataadapter As New MySqlDataAdapter(sql, MysqlConn)
            Dim ds As New DataSet()
            MysqlConn.Open()
            dataadapter.Fill(ds, "students")
            MysqlConn.Close()
            DgvStudent.DataSource = ds
            DgvStudent.DataMember = "students"
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
End Class