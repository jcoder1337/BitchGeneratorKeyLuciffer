Imports System.Net.NetworkInformation
Imports System.Runtime.CompilerServices
Imports Microsoft.VisualBasic.CompilerServices
Imports BitchGeneratorKeyLuciffer.My

Class SecurityManager
    Public Function GetSerial() As Long
        Dim text As String = ""
        Dim allNetworkInterfaces As NetworkInterface() = NetworkInterface.GetAllNetworkInterfaces()
        Dim nic As Boolean = allNetworkInterfaces Is Nothing OrElse allNetworkInterfaces.Length < 1
        Dim registry1 As Boolean = nic
        If registry1 Then
            text = Conversions.ToString(RuntimeHelpers.GetObjectValue(MyProject.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\HARDWARE\DESCRIPTION\SYSTEM\CentralProcessor\0", "ProcessorNameString", Nothing)))
        Else
            Dim array As NetworkInterface() = allNetworkInterfaces
            Dim num As Integer = array.Length - 1
            For i As Integer = 0 To num
                Dim networkInterface As NetworkInterface = array(i)
                nic = (networkInterface.OperationalStatus = OperationalStatus.Up And networkInterface.NetworkInterfaceType = NetworkInterfaceType.Ethernet And Operators.CompareString(networkInterface.Name, "Local Area Connection", False) = 0)
                Dim memek As Boolean = nic
                If memek Then
                    Dim physicalAddress As PhysicalAddress = networkInterface.GetPhysicalAddress()
                    text = physicalAddress.ToString()
                End If
                nic = (Strings.Len(text) > 0)
                Dim jilatmemek As Boolean = nic
                If jilatmemek Then
                    Exit For
                End If
            Next
        End If
        nic = (Strings.Len(text) = 0)
        Dim isapmemek As Boolean = nic
        If isapmemek Then
            text = Conversions.ToString(RuntimeHelpers.GetObjectValue(MyProject.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\HARDWARE\DESCRIPTION\SYSTEM\CentralProcessor\0", "ProcessorNameString", Nothing)))
        End If
        Dim num2 As Long = 0L
        Dim num3 As Integer = 1
        Dim text2 As String = text
        Dim j As Integer = 0
        Dim length As Integer = text2.Length
        While j < length
            Dim c As Char = text2(j)
            nic = Char.IsDigit(c)
            Dim kocokmemeknya As Boolean = nic
            If kocokmemeknya Then
                num2 += num2 + CLng((Integer.Parse(Conversions.ToString(c)) * (num3 * 2)))
            Else
                nic = Char.IsLetter(c)
                Dim fuck As Boolean = nic
                If fuck Then
                    Dim left As String = c.ToString().ToUpper()
                    Dim ngentodlagi As Boolean = Operators.CompareString(left, "A", False) = 0
                    Dim bukamemeknya As Boolean = ngentodlagi
                    If bukamemeknya Then
                        num2 += num2 + CLng((10 * (num3 * 2)))
                    Else
                        ngentodlagi = (Operators.CompareString(left, "B", False) = 0)
                        Dim isapteteknya As Boolean = ngentodlagi
                        If isapteteknya Then
                            num2 += num2 + CLng((11 * (num3 * 2)))
                        Else
                            ngentodlagi = (Operators.CompareString(left, "C", False) = 0)
                            Dim pantatcwemontok As Boolean = ngentodlagi
                            If pantatcwemontok Then
                                num2 += num2 + CLng((12 * (num3 * 2)))
                            Else
                                ngentodlagi = (Operators.CompareString(left, "D", False) = 0)
                                Dim mulaiketagihan As Boolean = ngentodlagi
                                If mulaiketagihan Then
                                    num2 += num2 + CLng((13 * (num3 * 2)))
                                Else
                                    ngentodlagi = (Operators.CompareString(left, "E", False) = 0)
                                    Dim masihkuatdikocok As Boolean = ngentodlagi
                                    If masihkuatdikocok Then
                                        num2 += num2 + CLng((14 * (num3 * 2)))
                                    Else
                                        ngentodlagi = (Operators.CompareString(left, "F", False) = 0)
                                        Dim makinsukadikentod As Boolean = ngentodlagi
                                        If makinsukadikentod Then
                                            num2 += num2 + CLng((15 * (num3 * 2)))
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
            num3 += 1
            j += 1
        End While
        Return num2
    End Function

    Public Function CheckKey(ByVal key As Long) As Boolean
        Dim serial As Long = Me.GetSerial()
        Dim num As Long = CLng(Math.Round(Math.Round(CDbl((serial * serial)) + 41.0 / CDbl(serial) + 212.0 * (CDbl(serial) / 4.0))))
        Return num = key
    End Function
End Class
