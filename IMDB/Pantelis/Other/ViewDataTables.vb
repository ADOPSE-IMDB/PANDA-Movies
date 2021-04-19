Imports System.Data

Module ViewDataTables
    Public Function ShowTable(ByVal table As DataTable)
        For Each col As DataColumn In table.Columns
            Console.Write("{0,-14}", col.ColumnName)
        Next

        Console.WriteLine()

        For Each row As DataRow In table.Rows

            For Each col As DataColumn In table.Columns

                If col.DataType.Equals(GetType(DateTime)) Then
                    Console.Write("{0,-14:d}", row(col))
                ElseIf col.DataType.Equals(GetType(Decimal)) Then
                    Console.Write("{0,-14:C}", row(col))
                Else
                    Console.Write("{0,-14}", row(col))
                End If
            Next

            Console.WriteLine()
        Next

        Console.WriteLine()
    End Function

    Public Function ShowColTypes(ByVal table As DataTable)
        For Each col As DataColumn In table.Columns
            Console.Write("{0,-14}", col.DataType)
        Next
    End Function
End Module
