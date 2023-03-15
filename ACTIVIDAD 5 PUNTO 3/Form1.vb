Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub btnIdentificar_Click_1(sender As Object, e As EventArgs) Handles btnIdentificar.Click

        ' Arreglo unidimensional
        Dim numeros1D() As Integer = {2, 4, 6, 8, 10}

            MessageBox.Show("Arreglo unidimensional" & vbNewLine & vbNewLine &
                        $"Cantidad de elementos: {numeros1D.Length}" & vbNewLine &
                        $"Elemento más grande: {numeros1D.Max()}" & vbNewLine &
                        $"Elemento más pequeño: {numeros1D.Min()}")

            ' Arreglo bidimensional
            Dim numeros2D(,) As Integer = {{1, 2}, {3, 4}, {5, 6}}

            MessageBox.Show("Arreglo bidimensional" & vbNewLine & vbNewLine &
                        $"Cantidad de filas: {numeros2D.GetLength(0)}" & vbNewLine &
                        $"Cantidad de columnas: {numeros2D.GetLength(1)}" & vbNewLine &
                        $"Elemento en la fila 2, columna 1: {numeros2D(1, 0)}" & vbNewLine &
                        $"Elemento en la fila 3, columna 2: {numeros2D(2, 1)}")

            ' Arreglo tridimensional
            Dim numeros3D(,,) As Integer = {{{1, 2, 3}, {4, 5, 6}}, {{7, 8, 9}, {10, 11, 12}}}

            MessageBox.Show("Arreglo tridimensional" & vbNewLine & vbNewLine &
                        $"Cantidad de páginas: {numeros3D.GetLength(0)}" & vbNewLine &
                        $"Cantidad de filas: {numeros3D.GetLength(1)}" & vbNewLine &
                        $"Cantidad de columnas: {numeros3D.GetLength(2)}" & vbNewLine &
                        $"Elemento en la página 1, fila 1, columna 3: {numeros3D(0, 0, 2)}" & vbNewLine &
                        $"Elemento en la página 2, fila 2, columna 2: {numeros3D(1, 1, 1)}")


        End Sub
End Class
