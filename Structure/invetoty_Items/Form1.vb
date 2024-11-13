Public Class Form1
    'Design an application for tracking inventory items, capturing details like ItemID, Name, Quantity,
    'And Unit Price in a structure named InventoryItem. Display a summary of all items in a
    'MessageBox when the user clicks a "Show Inventory Summary" button, formatting each item's
    'details for readability.

    Public Structure InventoryItem
        Dim item_Id As Integer
        Dim name As String
        Dim quantity As Double
        Dim unit_Price As Double
    End Structure

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim item_details As InventoryItem = New InventoryItem()

        TextBox1.Text = item_details.item_Id
        TextBox2.Text = item_details.name
        TextBox3.Text = item_details.quantity
        TextBox4.Text = item_details.unit_Price


        Dim message As String = String.Format("Item ID: {0}, Item Name: {1}, Item Quantity: {2}, Item Unit Price: {3}", item_details.item_Id, item_details.name, item_details.quantity, item_details.unit_Price)
        MessageBox.Show(message)



    End Sub
End Class
