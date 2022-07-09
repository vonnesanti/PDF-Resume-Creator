Imports System.IO
Imports Newtonsoft.Json
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports iTextSharp.text.pdf.draw


Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub createBtn_Click(sender As Object, e As EventArgs) Handles createBtn.Click
        Dim json_pathfile As String = "C:\Users\fujjitsu\source\repos\PDF Resume Creator\REsume.json"
        Dim open_jsonfile As String = File.ReadAllText(json_pathfile)
        Dim outputJson As readJson = JsonConvert.DeserializeObject(Of readJson)(open_jsonfile)
        Dim MyResume As Document = New Document()
        PdfWriter.GetInstance(MyResume, New FileStream("C:\Users\fujjitsu\source\repos\PDF Resume Creator\Yvonne.pdf", FileMode.Create))

        Dim main_font As iTextSharp.text.Font = FontFactory.GetFont(iTextSharp.text.Font.FontFamily.ARIAL.ToString(), 22, iTextSharp.text.Font.BOLD)
        Dim lessmain_font As iTextSharp.text.Font = FontFactory.GetFont(iTextSharp.text.Font.FontFamily.ARIAL.ToString(), 17, iTextSharp.text.Font.BOLD)
        Dim second_font As iTextSharp.text.Font = FontFactory.GetFont(iTextSharp.text.Font.FontFamily.ARIAL.ToString(), 15, iTextSharp.text.Font.BOLD)
        Dim normal_font As iTextSharp.text.Font = FontFactory.GetFont(iTextSharp.text.Font.FontFamily.ARIAL.ToString(), 12, iTextSharp.text.Font.NORMAL)
        Dim smaller_font As iTextSharp.text.Font = FontFactory.GetFont(iTextSharp.text.Font.FontFamily.ARIAL.ToString(), 10, iTextSharp.text.Font.NORMAL)
        Dim space_font As iTextSharp.text.Font = FontFactory.GetFont(iTextSharp.text.Font.FontFamily.ARIAL.ToString(), 5, iTextSharp.text.Font.NORMAL)
        Dim normal_bold As iTextSharp.text.Font = FontFactory.GetFont(iTextSharp.text.Font.FontFamily.ARIAL.ToString(), 12, iTextSharp.text.Font.ITALIC)
        Dim image As iTextSharp.text.Image = iTextSharp.text.Image.GetInstance(outputJson.image)
        image.ScalePercent(25.0F)
        image.SetAbsolutePosition(MyResume.PageSize.Width - 30.0F - 135.0F, MyResume.PageSize.Height - 30.0F - 150.0F)
        Dim separate As LineSeparator = New LineSeparator(2.0F, 100.0F, BaseColor.BLACK, Element.ALIGN_BOTTOM, 1)
        Dim name As Paragraph = New Paragraph(outputJson.FullName & vbLf, main_font)
        Dim ContactTitle As Paragraph = New Paragraph(outputJson.ContactTitle.ToString(), lessmain_font)
        Dim address As Paragraph = New Paragraph(vbLf & outputJson.Address & vbLf)
        Dim cityAddress As Paragraph = New Paragraph(outputJson.CityAddress & vbLf)
        Dim phoneNum As Paragraph = New Paragraph(vbLf & outputJson.PhoneNumber & vbLf)
        Dim emailAdd As Paragraph = New Paragraph(outputJson.EmailAddress & vbLf & vbLf & vbLf)
        Dim AboutTitle As Paragraph = New Paragraph(outputJson.AboutTitle & vbLf, lessmain_font)
        Dim Profile As Paragraph = New Paragraph(vbLf & outputJson.Profile & vbLf & vbLf, normal_font)
        Dim space As Paragraph = New Paragraph(vbLf, space_font)
        Dim EducationTitle As Paragraph = New Paragraph(outputJson.EducationTitle.ToString(), lessmain_font)
        Dim EducTitle1 As Paragraph = New Paragraph(vbLf & outputJson.EducTitle1.ToString(), second_font)
        Dim Educ1 As Paragraph = New Paragraph(outputJson.Educ1.ToString(), normal_bold)
        Dim EducSchool1 As Paragraph = New Paragraph(outputJson.EducSchool1.ToString(), smaller_font)
        Dim EducDesc1 As Paragraph = New Paragraph(outputJson.EducDesc1.ToString(), smaller_font)
        Dim EducTitle2 As Paragraph = New Paragraph(outputJson.EducTitle2.ToString().PadRight(50) & outputJson.WorkTitle2, second_font)
        Dim Educ2 As Paragraph = New Paragraph(outputJson.Educ2.ToString().PadRight(76) & outputJson.Work2.ToString(), normal_bold)
        Dim EducSchool2 As Paragraph = New Paragraph(outputJson.EducSchool2.ToString().PadRight(90) & outputJson.WorkComp2.ToString() & vbLf, smaller_font)
        Dim EducDesc2 As Paragraph = New Paragraph(outputJson.EducDesc2.ToString().PadRight(68) & outputJson.WorkDesc2.ToString() & vbLf & vbLf, smaller_font)
        Dim Skills As Paragraph = New Paragraph(outputJson.Skills.ToString(), lessmain_font)
        Dim Skill1 As Paragraph = New Paragraph(outputJson.Skill1.ToString().PadRight(30) & outputJson.Skill2.ToString().PadRight(20) & outputJson.Skill3.ToString().PadRight(20) & outputJson.Skill4.ToString().PadRight(20) & outputJson.Skill5.ToString() & vbLf, normal_font)
        Dim WorkTitle As Paragraph = New Paragraph(outputJson.WorkTitle.ToString(), lessmain_font)
        Dim Work1 As Paragraph = New Paragraph(outputJson.Work1.ToString(), normal_font)
        Dim WorkTitle1 As Paragraph = New Paragraph(outputJson.WorkTitle1.ToString(), normal_font)
        Dim WorkComp1 As Paragraph = New Paragraph(outputJson.WorkComp1.ToString(), normal_font)
        Dim WorkDesc1 As Paragraph = New Paragraph(outputJson.WorkDesc1, normal_font)
        Dim Work2 As Paragraph = New Paragraph(outputJson.Work2, normal_font)
        Dim WorkTitle2 As Paragraph = New Paragraph(outputJson.WorkTitle2.ToString(), normal_font)
        Dim WorkComp2 As Paragraph = New Paragraph(outputJson.WorkComp2.ToString(), normal_font)
    End Sub

    profile.Alignment = Element.ALIGN_JUSTIFIED
            MyResume.Open()
            MyResume.Add(image)
            MyResume.Add(name)
            MyResume.Add(space)
            MyResume.Add(separate)
            MyResume.Add(separate)
            MyResume.Add(ContactTitle)
            MyResume.Add(address)
            MyResume.Add(cityAddress)
            MyResume.Add(phoneNum)
            MyResume.Add(emailAdd)
            MyResume.Add(separate)
            MyResume.Add(space)
            MyResume.Add(AboutTitle)
            MyResume.Add(Profile)
            MyResume.Add(space)
            MyResume.Add(space)
            MyResume.Add(separate)
            MyResume.Add(EducationTitle)
            MyResume.Add(EducTitle1)
            MyResume.Add(Educ1)
            MyResume.Add(EducSchool1)
            MyResume.Add(EducDesc1)
            MyResume.Add(EducTitle2)
            MyResume.Add(Educ2)
            MyResume.Add(EducSchool2)
            MyResume.Add(EducDesc2)
            MyResume.Add(space)
            MyResume.Add(separate)
            MyResume.Add(space)
            MyResume.Add(Skills)
            MyResume.Add(space)
            MyResume.Add(Skill1)
            MyResume.Add(space)
            MyResume.Add(separate)
            MyResume.Add(space)
            MyResume.Add(WorkTitle)
            MyResume.Add(space)
            MyResume.Add(WorkTitle1)
            MyResume.Add(WorkComp1)
            MyResume.Add(WorkDesc1)
            MyResume.Add(Work2)
            MyResume.Add(WorkTitle2)
            MyResume.Add(WorkComp2)
            MyResume.Close()
            MessageBox.Show("PDF Created!.")
      

    Public Class readJson
        Public Property FullName As String
        Public Property image As String
        Public Property ContactTitle As String
        Public Property Address As String
        Public Property CityAddress As String
        Public Property PhoneNumber As String
        Public Property EmailAddress As String
        Public Property AboutTitle As String
        Public Property Profile As String
        Public Property EducationTitle As String
        Public Property Educ1 As String
        Public Property EducTitle1 As String
        Public Property EducSchool1 As String
        Public Property EducDesc1 As String
        Public Property Educ2 As String
        Public Property EducTitle2 As String
        Public Property EducSchool2 As String
        Public Property EducDesc2 As String
        Public Property WorkTitle As String
        Public Property Work1 As String
        Public Property WorkTitle1 As String
        Public Property WorkComp1 As String
        Public Property WorkDesc1 As String
        Public Property Work2 As String
        Public Property WorkTitle2 As String
        Public Property WorkComp2 As String
        Public Property WorkDesc2 As String
        Public Property Skills As String
        Public Property Skill1 As String
        Public Property Skill2 As String
        Public Property Skill3 As String
        Public Property Skill4 As String
        Public Property Skill5 As String
    End Class
End Class
