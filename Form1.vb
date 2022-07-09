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
        Dim PDFResume As Document = New Document()
        PdfWriter.GetInstance(PDFResume, New FileStream("C:\Users\fujjitsu\source\repos\PDF Resume Creator\Yvonne.pdf", FileMode.Create))

        Dim main_font As iTextSharp.text.Font = FontFactory.GetFont(iTextSharp.text.Font.FontFamily.TIMES_ROMAN.ToString(), 22, iTextSharp.text.Font.BOLD)
        Dim lessmain_font As iTextSharp.text.Font = FontFactory.GetFont(iTextSharp.text.Font.FontFamily.TIMES_ROMAN.ToString(), 17, iTextSharp.text.Font.BOLD)
        Dim second_font As iTextSharp.text.Font = FontFactory.GetFont(iTextSharp.text.Font.FontFamily.TIMES_ROMAN.ToString(), 15, iTextSharp.text.Font.BOLD)
        Dim normal_font As iTextSharp.text.Font = FontFactory.GetFont(iTextSharp.text.Font.FontFamily.TIMES_ROMAN.ToString(), 12, iTextSharp.text.Font.NORMAL)
        Dim smaller_font As iTextSharp.text.Font = FontFactory.GetFont(iTextSharp.text.Font.FontFamily.TIMES_ROMAN.ToString(), 10, iTextSharp.text.Font.NORMAL)
        Dim space_font As iTextSharp.text.Font = FontFactory.GetFont(iTextSharp.text.Font.FontFamily.TIMES_ROMAN.ToString(), 5, iTextSharp.text.Font.NORMAL)
        Dim normal_bold As iTextSharp.text.Font = FontFactory.GetFont(iTextSharp.text.Font.FontFamily.TIMES_ROMAN.ToString(), 12, iTextSharp.text.Font.ITALIC)
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

        Profile.Alignment = Element.ALIGN_JUSTIFIED
        PDFResume.Open()
        PDFResume.Add(name)
        PDFResume.Add(space)
        PDFResume.Add(separate)
        PDFResume.Add(separate)
        PDFResume.Add(ContactTitle)
        PDFResume.Add(address)
        PDFResume.Add(cityAddress)
        PDFResume.Add(phoneNum)
        PDFResume.Add(emailAdd)
        PDFResume.Add(separate)
        PDFResume.Add(space)
        PDFResume.Add(AboutTitle)
        PDFResume.Add(Profile)
        PDFResume.Add(space)
        PDFResume.Add(space)
        PDFResume.Add(separate)
        PDFResume.Add(EducationTitle)
        PDFResume.Add(EducTitle1)
        PDFResume.Add(Educ1)
        PDFResume.Add(EducSchool1)
        PDFResume.Add(EducDesc1)
        PDFResume.Add(EducTitle2)
        PDFResume.Add(Educ2)
        PDFResume.Add(EducSchool2)
        PDFResume.Add(EducDesc2)
        PDFResume.Add(space)
        PDFResume.Add(separate)
        PDFResume.Add(space)
        PDFResume.Add(Skills)
        PDFResume.Add(space)
        PDFResume.Add(Skill1)
        PDFResume.Add(space)
        PDFResume.Add(separate)
        PDFResume.Add(space)
        PDFResume.Add(WorkTitle)
        PDFResume.Add(space)
        PDFResume.Add(WorkTitle1)
        PDFResume.Add(WorkComp1)
        PDFResume.Add(WorkDesc1)
        PDFResume.Add(Work2)
        PDFResume.Add(WorkTitle2)
        PDFResume.Add(WorkComp2)
        PDFResume.Close()
        MessageBox.Show("PDF Created!.")

    End Sub



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




    Private Sub viewBtn_Click(sender As Object, e As EventArgs) Handles viewBtn.Click
        'walatohahaha
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged
        'waldintohahahah
    End Sub
End Class
