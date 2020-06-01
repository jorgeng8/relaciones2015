Public Class Form1

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Label1.Text = 0
        Label2.Text = 0
        Label3.Text = 0
        Label4.Text = 0
        Label5.Text = 0
        Label6.Text = 0
        Label7.Text = 0
        Label8.Text = 0
        Label9.Text = 0
        Label10.Text = 0
        Label11.Text = 0
        Label12.Text = 0
        Label13.Text = 0
        Label14.Text = 0
        Label15.Text = 0
        Label16.Text = 0
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        TextBox9.Clear()
        TextBox10.Clear()
        TextBox11.Clear()
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        'Dim numero1 As String = Label1.Text

        'Dim num As Integer : Dim suma As Integer = 0 : Dim cant As Integer : Dim x As Integer
        '''''''''''''''''
        'Dim cadena1 As String = Label1.Text
        ' Dim cadena2 As String = Label2.Text
        'Dim numeros1() As String = cadena1.Split(",")
        'Dim numeros2() As String = cadena2.Split(",")
        
        ' For i = 0 To 2

        'TextBox3.Text += (numeros1(i)) + 1

        'Next
        '''''''''''''''''
        'TextBox3.Text = x
        'TextBox3.Text += Mid(numero1, 1, x - 1)
        ' numero1 = Mid(numero1, x + 1)

        'For i = 0 To numero1.Length - 1
        'num = numero1.Substring(i, 1)
        'suma += num
        'cant += 1
        'Next
        'TextBox3.Text = "la suma es :" & suma & vbNewLine & "la cantidad es " & cant
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        
        If ComboBox1.Text = "+" Then
            Label1.Text = Val(TextBox1.Text) + Val(TextBox5.Text)
            Label2.Text = Val(TextBox1.Text) + Val(TextBox6.Text)
            Label3.Text = Val(TextBox1.Text) + Val(TextBox7.Text)
            Label4.Text = Val(TextBox1.Text) + Val(TextBox8.Text)
            Label5.Text = Val(TextBox2.Text) + Val(TextBox5.Text)
            Label6.Text = Val(TextBox2.Text) + Val(TextBox6.Text)
            Label7.Text = Val(TextBox2.Text) + Val(TextBox7.Text)
            Label8.Text = Val(TextBox2.Text) + Val(TextBox8.Text)
            Label9.Text = Val(TextBox3.Text) + Val(TextBox5.Text)
            Label10.Text = Val(TextBox3.Text) + Val(TextBox6.Text)
            Label11.Text = Val(TextBox3.Text) + Val(TextBox7.Text)
            Label12.Text = Val(TextBox3.Text) + Val(TextBox8.Text)
            Label13.Text = Val(TextBox4.Text) + Val(TextBox5.Text)
            Label14.Text = Val(TextBox4.Text) + Val(TextBox6.Text)
            Label15.Text = Val(TextBox4.Text) + Val(TextBox7.Text)
            Label16.Text = Val(TextBox4.Text) + Val(TextBox8.Text)
            ''''''''''
            'textBox11.'text += "(" + 'textBox1.'text + ", " + 'textBox5.'text + ")"
            'textBox11.'text += "(" + 'textBox1.'text + ", " + 'textBox6.'text + ")"
            'textBox11.'text += "(" + 'textBox1.'text + ", " + 'textBox7.'text + ")"
            'textBox11.'text += "(" + 'textBox1.'text + ", " + 'textBox8.'text + ")"
            'textBox11.'text += "(" + 'textBox2.'text + ", " + 'textBox5.'text + ")"
            'textBox11.'text += "(" + 'textBox2.'text + ", " + 'textBox6.'text + ")"
            'textBox11.'text += "(" + 'textBox2.'text + ", " + 'textBox7.'text + ")"
            'textBox11.'text += "(" + 'textBox2.'text + ", " + 'textBox8.'text + ")"
            'textBox11.'text += "(" + 'textBox3.'text + ", " + 'textBox5.'text + ")"
            'textBox11.'text += "(" + 'textBox3.'text + ", " + 'textBox6.'text + ")"
            'textBox11.'text += "(" + 'textBox3.'text + ", " + 'textBox7.'text + ")"
            'textBox11.'text += "(" + 'textBox3.'text + ", " + 'textBox8.'text + ")"
            'textBox11.'text += "(" + 'textBox4.'text + ", " + 'textBox5.'text + ")"
            'textBox11.'text += "(" + 'textBox4.'text + ", " + 'textBox6.'text + ")"
            'textBox11.'text += "(" + 'textBox4.'text + ", " + 'textBox7.'text + ")"
            'textBox11.'text += "(" + 'textBox4.'text + ", " + 'textBox8.'text + ")"
        End If
        If ComboBox1.Text = "-" Then
            Label1.Text = Val(TextBox1.Text) - Val(TextBox5.Text)
            Label2.Text = Val(TextBox1.Text) - Val(TextBox6.Text)
            Label3.Text = Val(TextBox1.Text) - Val(TextBox7.Text)
            Label4.Text = Val(TextBox1.Text) - Val(TextBox8.Text)
            Label5.Text = Val(TextBox2.Text) - Val(TextBox5.Text)
            Label6.Text = Val(TextBox2.Text) - Val(TextBox6.Text)
            Label7.Text = Val(TextBox2.Text) - Val(TextBox7.Text)
            Label8.Text = Val(TextBox2.Text) - Val(TextBox8.Text)
            Label9.Text = Val(TextBox3.Text) - Val(TextBox5.Text)
            Label10.Text = Val(TextBox3.Text) - Val(TextBox6.Text)
            Label11.Text = Val(TextBox3.Text) - Val(TextBox7.Text)
            Label12.Text = Val(TextBox3.Text) - Val(TextBox8.Text)
            Label13.Text = Val(TextBox4.Text) - Val(TextBox5.Text)
            Label14.Text = Val(TextBox4.Text) - Val(TextBox6.Text)
            Label15.Text = Val(TextBox4.Text) - Val(TextBox7.Text)
            Label16.Text = Val(TextBox4.Text) - Val(TextBox8.Text)
        End If
        If ComboBox1.Text = "*" Then
            Label1.Text = Val(TextBox1.Text) * Val(TextBox5.Text)
            Label2.Text = Val(TextBox1.Text) * Val(TextBox6.Text)
            Label3.Text = Val(TextBox1.Text) * Val(TextBox7.Text)
            Label4.Text = Val(TextBox1.Text) * Val(TextBox8.Text)
            Label5.Text = Val(TextBox2.Text) * Val(TextBox5.Text)
            Label6.Text = Val(TextBox2.Text) * Val(TextBox6.Text)
            Label7.Text = Val(TextBox2.Text) * Val(TextBox7.Text)
            Label8.Text = Val(TextBox2.Text) * Val(TextBox8.Text)
            Label9.Text = Val(TextBox3.Text) * Val(TextBox5.Text)
            Label10.Text = Val(TextBox3.Text) * Val(TextBox6.Text)
            Label11.Text = Val(TextBox3.Text) * Val(TextBox7.Text)
            Label12.Text = Val(TextBox3.Text) * Val(TextBox8.Text)
            Label13.Text = Val(TextBox4.Text) * Val(TextBox5.Text)
            Label14.Text = Val(TextBox4.Text) * Val(TextBox6.Text)
            Label15.Text = Val(TextBox4.Text) * Val(TextBox7.Text)
            Label16.Text = Val(TextBox4.Text) * Val(TextBox8.Text)
        End If

        If ComboBox2.Text = "<" Then
            If Label1.Text < TextBox9.Text Then
                TextBox10.Text += Label1.Text + ","
                TextBox11.Text += "(" + TextBox1.Text + ", " + TextBox5.Text + ")" + ";"
            End If
        End If
        If ComboBox2.Text = "<" Then
            If Label2.Text < TextBox9.Text Then
                TextBox10.Text += Label2.Text + ","
                TextBox11.Text += "(" + TextBox1.Text + ", " + TextBox6.Text + ")" + ";"
            End If
        End If
        If ComboBox2.Text = "<" Then
            If Label3.Text < TextBox9.Text Then
                TextBox10.Text += Label3.Text + ","
                TextBox11.Text += "(" + TextBox1.Text + ", " + TextBox7.Text + ")" + ";"
            End If
        End If
        If ComboBox2.Text = "<" Then
            If Label4.Text < TextBox9.Text Then
                TextBox10.Text += Label4.Text + ","
                TextBox11.Text += "(" + TextBox1.Text + ", " + TextBox8.Text + ")" + ";"
            End If
        End If
        If ComboBox2.Text = "<" Then
            If Label5.Text < TextBox9.Text Then
                TextBox10.Text += Label5.Text + ","
                TextBox11.Text += "(" + TextBox2.Text + ", " + TextBox5.Text + ")" + ";"
            End If
        End If
        If ComboBox2.Text = "<" Then
            If Label6.Text < TextBox9.Text Then
                TextBox10.Text += Label6.Text + ","
                TextBox11.Text += "(" + TextBox2.Text + ", " + TextBox6.Text + ")" + ";"
            End If
        End If
        If ComboBox2.Text = "<" Then
            If Label7.Text < TextBox9.Text Then
                TextBox10.Text += Label7.Text + ","
                TextBox11.Text += "(" + TextBox2.Text + ", " + TextBox7.Text + ")" + ";"
            End If
        End If
        If ComboBox2.Text = "<" Then
            If Label8.Text < TextBox9.Text Then
                TextBox10.Text += Label8.Text + ","
                TextBox11.Text += "(" + TextBox2.Text + ", " + TextBox8.Text + ")" + ";"
            End If
        End If
        If ComboBox2.Text = "<" Then
            If Label9.Text < TextBox9.Text Then
                TextBox10.Text += Label9.Text + ","
                TextBox11.Text += "(" + TextBox3.Text + ", " + TextBox5.Text + ")" + ";"

            End If
        End If
        If ComboBox2.Text = "<" Then
            If Label10.Text < TextBox9.Text Then
                TextBox10.Text += Label10.Text + ","
                TextBox11.Text += "(" + TextBox3.Text + ", " + TextBox6.Text + ")" + ";"

            End If
        End If
        If ComboBox2.Text = "<" Then
            If Label11.Text < TextBox9.Text Then
                TextBox10.Text += Label11.Text + ","
                TextBox11.Text += "(" + TextBox3.Text + ", " + TextBox7.Text + ")" + ";"

            End If
        End If
        If ComboBox2.Text = "<" Then
            If Label12.Text < TextBox9.Text Then
                TextBox10.Text += Label12.Text + ","
                TextBox11.Text += "(" + TextBox3.Text + ", " + TextBox8.Text + ")" + ";"

            End If
        End If
        If ComboBox2.Text = "<" Then
            If Label13.Text < TextBox9.Text Then
                TextBox10.Text += Label13.Text + ","
                TextBox11.Text += "(" + TextBox4.Text + ", " + TextBox5.Text + ")" + ";"

            End If
        End If
        If ComboBox2.Text = "<" Then
            If Label14.Text < TextBox9.Text Then
                TextBox10.Text += Label14.Text + ","
                TextBox11.Text += "(" + TextBox4.Text + ", " + TextBox6.Text + ")" + ";"

            End If
        End If
        If ComboBox2.Text = "<" Then
            If Label15.Text < TextBox9.Text Then
                TextBox10.Text += Label15.Text + ","
                TextBox11.Text += "(" + TextBox4.Text + ", " + TextBox7.Text + ")" + ";"

            End If
        End If
        If ComboBox2.Text = "<" Then
            If Label16.Text < TextBox9.Text Then
                TextBox10.Text += Label16.Text + ","
                TextBox11.Text += "(" + TextBox4.Text + ", " + TextBox8.Text + ")" + ";"
            End If
        End If
        ''''''''''''
        If ComboBox2.Text = ">" Then
            If Label1.Text > TextBox9.Text Then
                TextBox10.Text += Label1.Text + ","
                TextBox11.Text += "(" + TextBox1.Text + ", " + TextBox5.Text + ")" + ";"

            End If
        End If
        If ComboBox2.Text = ">" Then
            If Label2.Text > TextBox9.Text Then
                TextBox10.Text += Label2.Text + ","
                TextBox11.Text += "(" + TextBox1.Text + ", " + TextBox6.Text + ")" + ";"

            End If
        End If
        If ComboBox2.Text = ">" Then
            If Label3.Text > TextBox9.Text Then
                TextBox10.Text += Label3.Text + ","
                TextBox11.Text += "(" + TextBox1.Text + ", " + TextBox7.Text + ")" + ";"

            End If
        End If
        If ComboBox2.Text = ">" Then
            If Label4.Text > TextBox9.Text Then
                TextBox10.Text += Label4.Text + ","
                TextBox11.Text += "(" + TextBox1.Text + ", " + TextBox8.Text + ")" + ";"

            End If
        End If
        If ComboBox2.Text = ">" Then
            If Label5.Text > TextBox9.Text Then
                TextBox10.Text += Label5.Text + ","
                TextBox11.Text += "(" + TextBox2.Text + ", " + TextBox5.Text + ")" + ";"

            End If
        End If
        If ComboBox2.Text = ">" Then
            If Label6.Text > TextBox9.Text Then
                TextBox10.Text += Label6.Text + ","
                TextBox11.Text += "(" + TextBox2.Text + ", " + TextBox6.Text + ")" + ";"

            End If
        End If
        If ComboBox2.Text = ">" Then
            If Label7.Text > TextBox9.Text Then
                TextBox10.Text += Label7.Text + ","
                TextBox11.Text += "(" + TextBox2.Text + ", " + TextBox7.Text + ")" + ";"

            End If
        End If
        If ComboBox2.Text = ">" Then
            If Label8.Text > TextBox9.Text Then
                TextBox10.Text += Label8.Text + ","
                TextBox11.Text += "(" + TextBox2.Text + ", " + TextBox8.Text + ")" + ";"

            End If
        End If
        If ComboBox2.Text = ">" Then
            If Label9.Text > TextBox9.Text Then
                TextBox10.Text += Label9.Text + ","
                TextBox11.Text += "(" + TextBox3.Text + ", " + TextBox5.Text + ")" + ";"

            End If
        End If
        If ComboBox2.Text = ">" Then
            If Label10.Text > TextBox9.Text Then
                TextBox10.Text += Label10.Text + ","
                TextBox11.Text += "(" + TextBox3.Text + ", " + TextBox6.Text + ")" + ";"

            End If
        End If
        If ComboBox2.Text = ">" Then
            If Label11.Text > TextBox9.Text Then
                TextBox10.Text += Label11.Text + ","
                TextBox11.Text += "(" + TextBox3.Text + ", " + TextBox7.Text + ")" + ";"

            End If
        End If
        If ComboBox2.Text = ">" Then
            If Label12.Text > TextBox9.Text Then
                TextBox10.Text += Label12.Text + ","
                TextBox11.Text += "(" + TextBox3.Text + ", " + TextBox8.Text + ")" + ";"

            End If
        End If
        If ComboBox2.Text = ">" Then
            If Label13.Text > TextBox9.Text Then
                TextBox10.Text += Label13.Text + ","
                TextBox11.Text += "(" + TextBox4.Text + ", " + TextBox5.Text + ")" + ";"

            End If
        End If
        If ComboBox2.Text = ">" Then
            If Label14.Text > TextBox9.Text Then
                TextBox10.Text += Label14.Text + ","
                TextBox11.Text += "(" + TextBox4.Text + ", " + TextBox6.Text + ")" + ";"

            End If
        End If
        If ComboBox2.Text = ">" Then
            If Label15.Text > TextBox9.Text Then
                TextBox10.Text += Label15.Text + ","
                TextBox11.Text += "(" + TextBox4.Text + ", " + TextBox7.Text + ")" + ";"

            End If
        End If
        If ComboBox2.Text = ">" Then
            If Label16.Text > TextBox9.Text Then
                TextBox10.Text += Label16.Text + ","
                TextBox11.Text += "(" + TextBox4.Text + ", " + TextBox8.Text + ")" + ";"
            End If
        End If
        '''''''''''''''''''''
        If ComboBox2.Text = "≥" Then
            If Label1.Text >= TextBox9.Text Then
                TextBox10.Text += Label1.Text + ","
                TextBox11.Text += "(" + TextBox1.Text + ", " + TextBox5.Text + ")" + ";"

            End If
        End If
        If ComboBox2.Text = "≥" Then
            If Label2.Text >= TextBox9.Text Then
                TextBox10.Text += Label2.Text + ","
                TextBox11.Text += "(" + TextBox1.Text + ", " + TextBox6.Text + ")" + ";"

            End If
        End If
        If ComboBox2.Text = "≥" Then
            If Label3.Text >= TextBox9.Text Then
                TextBox10.Text += Label3.Text + ","
                TextBox11.Text += "(" + TextBox1.Text + ", " + TextBox7.Text + ")" + ";"

            End If
        End If
        If ComboBox2.Text = "≥" Then
            If Label4.Text >= TextBox9.Text Then
                TextBox10.Text += Label4.Text + ","
                TextBox11.Text += "(" + TextBox1.Text + ", " + TextBox8.Text + ")" + ";"

            End If
        End If
        If ComboBox2.Text = "≥" Then
            If Label5.Text >= TextBox9.Text Then
                TextBox10.Text += Label5.Text + ","
                TextBox11.Text += "(" + TextBox2.Text + ", " + TextBox5.Text + ")" + ";"

            End If
        End If
        If ComboBox2.Text = "≥" Then
            If Label6.Text >= TextBox9.Text Then
                TextBox10.Text += Label6.Text + ","
                TextBox11.Text += "(" + TextBox2.Text + ", " + TextBox6.Text + ")" + ";"

            End If
        End If
        If ComboBox2.Text = "≥" Then
            If Label7.Text >= TextBox9.Text Then
                TextBox10.Text += Label7.Text + ","
                TextBox11.Text += "(" + TextBox2.Text + ", " + TextBox7.Text + ")" + ";"

            End If
        End If
        If ComboBox2.Text = "≥" Then
            If Label8.Text >= TextBox9.Text Then
                TextBox10.Text += Label8.Text + ","
                TextBox11.Text += "(" + TextBox2.Text + ", " + TextBox8.Text + ")" + ";"

            End If
        End If
        If ComboBox2.Text = "≥" Then
            If Label9.Text >= TextBox9.Text Then
                TextBox10.Text += Label9.Text + ","
                TextBox11.Text += "(" + TextBox3.Text + ", " + TextBox5.Text + ")" + ";"

            End If
        End If
        If ComboBox2.Text = "≥" Then
            If Label10.Text >= TextBox9.Text Then
                TextBox10.Text += Label10.Text + ","
                TextBox11.Text += "(" + TextBox3.Text + ", " + TextBox6.Text + ")" + ";"

            End If
        End If
        If ComboBox2.Text = "≥" Then
            If Label11.Text >= TextBox9.Text Then
                TextBox10.Text += Label11.Text + ","
                TextBox11.Text += "(" + TextBox3.Text + ", " + TextBox7.Text + ")" + ";"

            End If
        End If
        If ComboBox2.Text = "≥" Then
            If Label12.Text >= TextBox9.Text Then
                TextBox10.Text += Label12.Text + ","
                TextBox11.Text += "(" + TextBox3.Text + ", " + TextBox8.Text + ")" + ";"

            End If
        End If
        If ComboBox2.Text = "≥" Then
            If Label13.Text >= TextBox9.Text Then
                TextBox10.Text += Label13.Text + ","
                TextBox11.Text += "(" + TextBox4.Text + ", " + TextBox5.Text + ")" + ";"

            End If
        End If
        If ComboBox2.Text = "≥" Then
            If Label14.Text >= TextBox9.Text Then
                TextBox10.Text += Label14.Text + ","
                TextBox11.Text += "(" + TextBox4.Text + ", " + TextBox6.Text + ")" + ";"


            End If
        End If
        If ComboBox2.Text = "≥" Then
            If Label15.Text >= TextBox9.Text Then
                TextBox10.Text += Label15.Text + ","
                TextBox11.Text += "(" + TextBox4.Text + ", " + TextBox7.Text + ")" + ";"

            End If
        End If
        If ComboBox2.Text = "≥" Then
            If Label16.Text >= TextBox9.Text Then
                TextBox10.Text += Label16.Text + ","
                TextBox11.Text += "(" + TextBox4.Text + ", " + TextBox8.Text + ")" + ";"
            End If
        End If
        ''''''''''''''
        If ComboBox2.Text = "≤" Then
            If Label1.Text <= TextBox9.Text Then
                TextBox10.Text += Label1.Text + ","
                TextBox11.Text += "(" + TextBox1.Text + ", " + TextBox5.Text + ")" + ";"

            End If
        End If
        If ComboBox2.Text = "≤" Then
            If Label2.Text <= TextBox9.Text Then
                TextBox10.Text += Label2.Text + ","
                TextBox11.Text += "(" + TextBox1.Text + ", " + TextBox6.Text + ")" + ";"

            End If
        End If
        If ComboBox2.Text = "≤" Then
            If Label3.Text <= TextBox9.Text Then
                TextBox10.Text += Label3.Text + ","
                TextBox11.Text += "(" + TextBox1.Text + ", " + TextBox7.Text + ")" + ";"

            End If
        End If
        If ComboBox2.Text = "≤" Then
            If Label4.Text <= TextBox9.Text Then
                TextBox10.Text += Label4.Text + ","
                TextBox11.Text += "(" + TextBox1.Text + ", " + TextBox8.Text + ")" + ";"

            End If
        End If
        If ComboBox2.Text = "≤" Then
            If Label5.Text <= TextBox9.Text Then
                TextBox10.Text += Label5.Text + ","
                TextBox11.Text += "(" + TextBox2.Text + ", " + TextBox5.Text + ")" + ";"

            End If
        End If
        If ComboBox2.Text = "≤" Then
            If Label6.Text <= TextBox9.Text Then
                TextBox10.Text += Label6.Text + ","
                TextBox11.Text += "(" + TextBox2.Text + ", " + TextBox6.Text + ")" + ";"

            End If
        End If
        If ComboBox2.Text = "≤" Then
            If Label7.Text <= TextBox9.Text Then
                TextBox10.Text += Label7.Text + ","
                TextBox11.Text += "(" + TextBox2.Text + ", " + TextBox7.Text + ")" + ";"

            End If
        End If
        If ComboBox2.Text = "≤" Then
            If Label8.Text <= TextBox9.Text Then
                TextBox10.Text += Label8.Text + ","
                TextBox11.Text += "(" + TextBox2.Text + ", " + TextBox8.Text + ")" + ";"

            End If
        End If
        If ComboBox2.Text = "≤" Then
            If Label9.Text <= TextBox9.Text Then
                TextBox10.Text += Label9.Text + ","
                TextBox11.Text += "(" + TextBox3.Text + ", " + TextBox5.Text + ")" + ";"

            End If
        End If
        If ComboBox2.Text = "≤" Then
            If Label10.Text <= TextBox9.Text Then
                TextBox10.Text += Label10.Text + ","
                TextBox11.Text += "(" + TextBox3.Text + ", " + TextBox6.Text + ")" + ";"

            End If
        End If
        If ComboBox2.Text = "≤" Then
            If Label11.Text <= TextBox9.Text Then
                TextBox10.Text += Label11.Text + ","
                TextBox11.Text += "(" + TextBox3.Text + ", " + TextBox7.Text + ")" + ";"

            End If
        End If
        If ComboBox2.Text = "≤" Then
            If Label12.Text <= TextBox9.Text Then
                TextBox10.Text += Label12.Text + ","
                TextBox11.Text += "(" + TextBox3.Text + ", " + TextBox8.Text + ")" + ";"

            End If
        End If
        If ComboBox2.Text = "≤" Then
            If Label13.Text <= TextBox9.Text Then
                TextBox10.Text += Label13.Text + ","
                TextBox11.Text += "(" + TextBox4.Text + ", " + TextBox5.Text + ")" + ";"

            End If
        End If
        If ComboBox2.Text = "≤" Then
            If Label14.Text <= TextBox9.Text Then
                TextBox10.Text += Label14.Text + ","
                TextBox11.Text += "(" + TextBox4.Text + ", " + TextBox6.Text + ")" + ";"

            End If
        End If
        If ComboBox2.Text = "≤" Then
            If Label15.Text <= TextBox9.Text Then
                TextBox10.Text += Label15.Text + ","
                TextBox11.Text += "(" + TextBox4.Text + ", " + TextBox7.Text + ")" + ";"

            End If
        End If
        If ComboBox2.Text = "≤" Then
            If Label16.Text <= TextBox9.Text Then
                TextBox10.Text += Label16.Text + ","
                TextBox11.Text += "(" + TextBox4.Text + ", " + TextBox8.Text + ")" + ";"
            End If
        End If
        '''''''''''''
        If ComboBox2.Text = "=" Then
            If Label1.Text = TextBox9.Text Then
                TextBox10.Text += Label1.Text + ","
                TextBox11.Text += "(" + TextBox1.Text + ", " + TextBox5.Text + ")"
                
            End If
        End If
        If ComboBox2.Text = "=" Then
            If Label2.Text = TextBox9.Text Then
                TextBox10.Text += Label2.Text + ","
                TextBox11.Text += "(" + TextBox1.Text + ", " + TextBox6.Text + ")"
                
            End If
        End If
        If ComboBox2.Text = "=" Then
            If Label3.Text = TextBox9.Text Then
                TextBox10.Text += Label3.Text + ","
                TextBox11.Text += "(" + TextBox1.Text + ", " + TextBox7.Text + ")"
                
            End If
        End If
        If ComboBox2.Text = "=" Then
            If Label4.Text = TextBox9.Text Then
                TextBox10.Text += Label4.Text + ","
                TextBox11.Text += "(" + TextBox1.Text + ", " + TextBox8.Text + ")"
                
            End If
        End If
        If ComboBox2.Text = "=" Then
            If Label5.Text = TextBox9.Text Then
                TextBox10.Text += Label5.Text + ","
                TextBox11.Text += "(" + TextBox2.Text + ", " + TextBox5.Text + ")"
                
            End If
        End If
        If ComboBox2.Text = "=" Then
            If Label6.Text = TextBox9.Text Then
                TextBox10.Text += Label6.Text + ","
                TextBox11.Text += "(" + TextBox2.Text + ", " + TextBox6.Text + ")"
                
            End If
        End If
        If ComboBox2.Text = "=" Then
            If Label7.Text = TextBox9.Text Then
                TextBox10.Text += Label7.Text + ","
                TextBox11.Text += "(" + TextBox2.Text + ", " + TextBox7.Text + ")"
                
            End If
        End If
        If ComboBox2.Text = "=" Then
            If Label8.Text = TextBox9.Text Then
                TextBox10.Text += Label8.Text + ","
                TextBox11.Text += "(" + TextBox2.Text + ", " + TextBox8.Text + ")"
                
            End If
        End If
        If ComboBox2.Text = "=" Then
            If Label9.Text = TextBox9.Text Then
                TextBox10.Text += Label9.Text + ","
                TextBox11.Text += "(" + TextBox3.Text + ", " + TextBox5.Text + ")"
                
            End If
        End If
        If ComboBox2.Text = "=" Then
            If Label10.Text = TextBox9.Text Then
                TextBox10.Text += Label10.Text + ","
                TextBox11.Text += "(" + TextBox3.Text + ", " + TextBox6.Text + ")"
                
            End If
        End If
        If ComboBox2.Text = "=" Then
            If Label11.Text = TextBox9.Text Then
                TextBox10.Text += Label11.Text + ","
                TextBox11.Text += "(" + TextBox3.Text + ", " + TextBox7.Text + ")"
                
            End If
        End If
        If ComboBox2.Text = "=" Then
            If Label12.Text = TextBox9.Text Then

                TextBox10.Text += Label12.Text + ","
                TextBox11.Text += "(" + TextBox3.Text + ", " + TextBox8.Text + ")"
                
            End If
        End If
        If ComboBox2.Text = "=" Then
            If Label13.Text = TextBox9.Text Then
                TextBox10.Text += Label13.Text + ","
                TextBox11.Text += "(" + TextBox4.Text + ", " + TextBox5.Text + ")"
                
            End If
        End If
        If ComboBox2.Text = "=" Then
            If Label14.Text = TextBox9.Text Then
                TextBox10.Text += Label14.Text + ","
                TextBox11.Text += "(" + TextBox4.Text + ", " + TextBox6.Text + ")"
                
            End If
        End If
        If ComboBox2.Text = "=" Then
            If Label15.Text = TextBox9.Text Then
                TextBox10.Text += Label15.Text + ","
                TextBox11.Text += "(" + TextBox4.Text + ", " + TextBox7.Text + ")"
                TextBox11.Text += "(" + TextBox4.Text + ", " + TextBox8.Text + ")"
            End If
        End If
        If ComboBox2.Text = "=" Then
            If Label16.Text = TextBox9.Text Then
                TextBox10.Text += Label16.Text + ","
                TextBox11.Text += "(" + TextBox4.Text + ", " + TextBox8.Text + ")"
            End If

        End If
        '">"
        '"≥"
        '"≤"
        ' "="

















        'Label1.Text += TextBox1.Text + ", "
        'TextBox1.Clear()
        'Label2.Text += TextBox2.Text + ", "
        'TextBox2.Clear()

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("+")
        ComboBox1.Items.Add("-")
        ComboBox1.Items.Add("*")
        ComboBox2.Items.Add("<")
        ComboBox2.Items.Add(">")
        ComboBox2.Items.Add("≥")
        ComboBox2.Items.Add("≤")
        ComboBox2.Items.Add("=")
    End Sub

    Private Sub Label16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label16.Click

    End Sub

    Private Sub TextBox11_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox11.TextChanged

    End Sub
End Class
