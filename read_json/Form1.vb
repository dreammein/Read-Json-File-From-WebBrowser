Public Class Form1

    Private Sub enter_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles enter.KeyDown

        If e.KeyCode = Keys.Enter Then
            Dim req As Net.HttpWebRequest = Net.WebRequest.Create(enter.Text)

            'Make the web request and get the response
            Dim response As Net.WebResponse = req.GetResponse

            Dim stream As System.IO.Stream = response.GetResponseStream

            'Prepare buffer for reading from stream
            Dim buffer As Byte() = New Byte(1000) {}

            'Data read from stream is gathered here
            Dim data As New List(Of Byte)

            'Start reading stream
            Dim bytesRead = stream.Read(buffer, 0, buffer.Length)

            Do Until bytesRead = 0
                For i = 0 To bytesRead - 1
                    data.Add(buffer(i))
                Next

                bytesRead = stream.Read(buffer, 0, buffer.Length)
            Loop


            'Gets the JSON data
            json_file.Text = System.Text.Encoding.UTF8.GetString(data.ToArray)

            response.Close()
            stream.Close()
        End If

    End Sub
End Class
