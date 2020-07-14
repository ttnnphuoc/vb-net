Public Class ExampleControlDevexpress 

    Private Sub ExampleControlDevexpress_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PropertiesControlButton()
        PropertiesControlCheckBox()
        PropertiesControlComboBox()
    End Sub
#Region "Button"
    ''' <summary>
    ''' The event is often used
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnClick_Click(sender As Object, e As EventArgs) Handles btnClick.Click
        MessageBox.Show("Button 1 is clicked")
        Return
    End Sub

    ''' <summary>
    ''' The properties is often used
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub PropertiesControlButton()


        ' Gets or sets a value indicating whether the control can respond to user interaction
        ' False is disable, True is enable
        btnClick.Enabled = True

        ' Gets or sets whether the control's size is automatically calculated based on its contents.
        ' False is not auto size, True is auto size
        btnClick.AutoSize = True

        ' Gets or sets a value indicating whether the control and all its parent controls are displayed.
        ' False is not display, True is display
        btnClick.Visible = True

        'Gets or sets the button's background color.
        btnClick.BackColor = Color.Red

        ' Gets or sets the control's foreground color
        btnClick.ForeColor = Color.Green

        ' Gets or sets the width of the control.
        btnClick.Width = 90

        ' Gets or sets the height of the control. 
        btnClick.Height = 30

        ' Gets or sets the text string displayed within the button control
        btnClick.Text = "Click 1"

        ' Gets or sets the button's image with url of image.
        btnClick.Image = Image.FromFile("C:\Users\ngocp\OneDrive\Desktop\C#\PTProject\PTProject\image\export_excel.png")

        ' Gets or sets which control borders are docked to its parent control and determines how a control is resized with its parent
        ' Value: Fill,Left,Right,Button, Top,None
        btnClick.Dock = DockStyle.None
    End Sub

    ''' <summary>
    ''' The method is used
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles btnClick2.Click
        ' Responds to button clicks
        btnClick.PerformClick()
    End Sub
#End Region

#Region "CheckBox"
    ''' <summary>
    ''' The properties is often used
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub PropertiesControlCheckBox()
        ' Gets or sets whether the check editor is in the checked state.
        ' True is checked, False is not checked
        chkOption.Checked = True

        ' Gets or sets a value indicating whether the control can respond to user interaction
        ' True is enable, False is disable
        chkOption.Enabled = False

        ' Gets or sets the editor content's foreground color.
        chkOption.ForeColor = Color.Red

        ' Gets or sets whether the editor's value cannot be changed by end-users.
        ' True is read only, False is not
        chkOption.ReadOnly = True

        ' Gets or sets the text label associated with a check editor
        chkOption.Text = "My checked"

        ' Gets or sets a value indicating whether the control and all its parent controls are displayed.
        ' True is display, False is not
        chkOption.Visible = True
    End Sub

    ''' <summary>
    ''' Fires after the Checked property value has been changed.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub chkOption_CheckedChanged(sender As Object, e As EventArgs) Handles chkOption.CheckedChanged
    End Sub

    ''' <summary>
    ''' The event is often used
    ''' Fires after the Checked property value has been changed.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub chkCheck2_CheckedChanged(sender As Object, e As EventArgs) Handles chkCheck2.CheckedChanged
    End Sub

    ''' <summary>
    ''' Fires immediately after the edit value has been changed. 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub chkCheck2_EditValueChanged(sender As Object, e As EventArgs) Handles chkCheck2.EditValueChanged
    End Sub

    ''' <summary>
    ''' Fires after the CheckState property value has been changed.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub chkCheck2_CheckStateChanged(sender As Object, e As EventArgs) Handles chkCheck2.CheckStateChanged
    End Sub

    ''' <summary>
    ''' Fires when the editor's value is about to change.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub chkCheck2_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles chkCheck2.EditValueChanging
    End Sub
#End Region

#Region "ComboBox"

    Private Sub InitData()
        For i = 0 To 4
            Dim name = String.Format("Name {0}", i)
            cbbEdit.Properties.Items.Add(name)
        Next i
    End Sub

    Private Sub PropertiesControlComboBox()
        ' Gets or sets whether the editor's value cannot be changed by end-user
        ' False can't editor, True is editor
        cbbEdit.ReadOnly = False

        ' Gets or sets the text displayed in the edit box
        cbbEdit.Text = "Combo Box"

        ' Gets the last successfully validated value.
        Dim oldValue As String = DirectCast(cbbEdit.OldEditValue, String)

        ' Gets or sets the editor content's foreground color. 
        cbbEdit.ForeColor = Color.Red

        ' Gets or sets the index of the selected ComboBox item
        cbbEdit.SelectedIndex = 1

        ' Set data for comboBox
        InitData()

    End Sub

    ''' <summary>
    ''' Fires immediately after the edit value has been changed.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub cbbEdit_EditValueChanged(sender As Object, e As EventArgs) Handles cbbEdit.EditValueChanged
    End Sub

    ''' <summary>
    ''' Fires when the editor's value is about to change.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub cbbEdit_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles cbbEdit.EditValueChanging
    End Sub

    ''' <summary>
    ''' Occurs when the selection moves from one ComboBoxEditor item to another.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub cbbEdit_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbEdit.SelectedIndexChanged

    End Sub

    ''' <summary>
    ''' Occurs when changing the index of the selected value in the combo box editor.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub cbbEdit_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbbEdit.SelectedValueChanged

    End Sub
#End Region

#Region "ContextMenuStrip"
    ''' <summary>
    ''' Event click to menu
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Menu1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Menu1ToolStripMenuItem.Click

    End Sub

    ''' <summary>
    ''' Event click to menu
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Menu2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Menu2ToolStripMenuItem.Click

    End Sub

    ''' <summary>
    ''' Event click to menu
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Menu21ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Menu21ToolStripMenuItem.Click

    End Sub
#End Region

#Region "DateEdit"
    ''' <summary>
    ''' The properties is often used
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub PropertiesControlDateEdit()
        ' Gets or sets the date/time value in the control.
        dteEdit.DateTime = Date.Now

        ' Gets or sets the edit value (current date).
        dteEdit.EditValue = Date.Now

        ' 	Gets or sets a value indicating whether the control can respond to user interaction.
        dteEdit.Enabled = False

        ' Gets or sets the editor content's foreground color.
        dteEdit.ForeColor = Color.Aqua

        ' Gets the last successfully validated value.
        Dim oldValue As String = DirectCast(dteEdit.OldEditValue, String)

        ' Gets or sets whether the editor's value cannot be changed by end-users. 
        dteEdit.ReadOnly = False

        ' Gets or sets a value indicating whether the control and all its parent controls are displayed.
        dteEdit.Visible = True

        ' Gets or sets the text displayed within the edit box.
        dteEdit.Text = ""
    End Sub


    ''' <summary>
    ''' The method is often used
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub MethodControlDateEdit()
        ' Closes the popup window accepting the changes made.
        dteEdit.ClosePopup()

        ' Sets input focus to the control.
        dteEdit.Focus()

        ' Selects all text within the text box.
        dteEdit.SelectAll()

        ' Clears text box selection.
        dteEdit.DeselectAll()
    End Sub

    Private Sub dteEdit_EditValueChanged(sender As Object, e As EventArgs) Handles dteEdit.EditValueChanged

    End Sub

    Private Sub dteEdit_Click(sender As Object, e As EventArgs) Handles dteEdit.Click

    End Sub

    Private Sub dteEdit_Closed(sender As Object, e As DevExpress.XtraEditors.Controls.ClosedEventArgs) Handles dteEdit.Closed

    End Sub

    Private Sub dteEdit_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles dteEdit.EditValueChanging

    End Sub
#End Region

#Region "Group Control"
    ''' <summary>
    ''' The properties is often used
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub PropertiesControlGroupControl()

        ' 	Gets or sets a value indicating whether the control can respond to user interaction.
        groupControl.Enabled = False

        ' Gets or sets the editor content's foreground color.
        groupControl.ForeColor = Color.Aqua

        ' Gets or sets a value indicating whether the control and all its parent controls are displayed.
        groupControl.Visible = True

        ' Gets or sets the text displayed within the edit box.
        groupControl.Text = ""

    End Sub


    ''' <summary>
    ''' The method is often used
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub MethodControlGroupControl()

        ' Sets input focus to the control.
        groupControl.Focus()

        ' Conceals the control from the user..
        groupControl.Hide()

        ' Displays the control to the user.
        groupControl.Show()
    End Sub

    Private Sub groupControl_Click(sender As Object, e As EventArgs) Handles groupControl.Click

    End Sub

    Private Sub groupControl_DoubleClick(sender As Object, e As EventArgs) Handles groupControl.DoubleClick

    End Sub

    Private Sub groupControl_Leave(sender As Object, e As EventArgs) Handles groupControl.Leave

    End Sub

    Private Sub groupControl_Scroll(sender As Object, e As DevExpress.XtraEditors.XtraScrollEventArgs) Handles groupControl.Scroll

    End Sub
#End Region

#Region "Label Control"
    ''' <summary>
    ''' The properties is often used
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub PropertiesControlLabelControl()

        ' 	Gets or sets a value indicating whether the control can respond to user interaction.
        lblText.Enabled = False

        ' Gets or sets the editor content's foreground color.
        lblText.ForeColor = Color.Aqua

        ' Gets or sets the label control's background color.
        lblText.BackColor = Color.Aquamarine

        ' Gets or sets a value indicating whether the control and all its parent controls are displayed.
        lblText.Visible = True

        ' Gets or sets the text displayed within the edit box.
        lblText.Text = ""

    End Sub


    ''' <summary>
    ''' The method is often used
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub MethodControlLabelControl()

        ' Sets input focus to the control.
        lblText.Focus()

        ' Conceals the control from the user..
        lblText.Hide()

        ' Displays the control to the user.
        lblText.Show()
    End Sub

    Private Sub lblText_Click(sender As Object, e As EventArgs) Handles lblText.Click

    End Sub

    Private Sub lblText_HyperlinkClick(sender As Object, e As DevExpress.Utils.HyperlinkClickEventArgs) Handles lblText.HyperlinkClick

    End Sub

#End Region

#Region "ListBoxControl"
    ''' <summary>
    ''' The properties is often used
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub PropertiesControlListBoxControl()
        ' Gets or sets the data source that provides items to display in the control
        lstBoxControl.DataSource = ""

        ' Gets or sets the name of the data source field that provides display text for listbox items. 
        lstBoxControl.DisplayMember = ""

        ' Gets or sets the field name in the bound data source whose contents are assigned to item values. 
        lstBoxControl.ValueMember = ""

        ' Gets or sets the index of the currently selected item. 
        lstBoxControl.SelectedIndex = 0

        ' Gets or sets the currently selected item's value.
        lstBoxControl.SelectedValue = ""

        ' 	Gets or sets the currently selected item.
        lstBoxControl.SelectedItem = ""

        ' Gets or sets a value indicating whether the control can respond to user interaction.
        lstBoxControl.Enabled = False

        ' Gets or sets the editor content's foreground color.
        lstBoxControl.ForeColor = Color.Aqua

        ' Gets or sets the label control's background color.
        lstBoxControl.BackColor = Color.Aquamarine

        ' Gets or sets a value indicating whether the control and all its parent controls are displayed.
        lstBoxControl.Visible = True

        ' Gets or sets the text displayed within the edit box.
        lstBoxControl.Text = ""

    End Sub


    ''' <summary>
    ''' The method is often used
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub MethodControlListBoxControl()

        ' Sets input focus to the control.
        lstBoxControl.Focus()

        ' Conceals the control from the user..
        lstBoxControl.Hide()

        ' Displays the control to the user.
        lstBoxControl.Show()

        ' Overloaded. Searches for the first list box item in the specified direction from the specified index, using a cusom algorithm
        lstBoxControl.FindItem("")

        ' Overloaded. Finds the first item in the list box control which starts with the specified string. The search starts at a starting index specified by the parameter.
        lstBoxControl.FindString("")

        ' 	Gets an item at the specified position. 
        lstBoxControl.GetItem(0)

        ' Gets the text string displayed by the item. 
        lstBoxControl.GetItemText(0)

        ' Gets the specified item's value.
        lstBoxControl.GetItemValue(0)

        ' Selects all items when multiple item selection is enabled.
        lstBoxControl.SelectAll()

        ' Unselects all items when multiple item selection is enabled.
        lstBoxControl.UnSelectAll()

        ' Assigns a new value to the specified item. 
        lstBoxControl.SetItemValue("", 0)
    End Sub

    Private Sub lstBoxControl_Click(sender As Object, e As EventArgs) Handles lstBoxControl.Click

    End Sub

    Private Sub lstBoxControl_DoubleClick(sender As Object, e As EventArgs) Handles lstBoxControl.DoubleClick

    End Sub

    Private Sub lstBoxControl_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstBoxControl.SelectedIndexChanged

    End Sub

    Private Sub lstBoxControl_SelectedValueChanged(sender As Object, e As EventArgs) Handles lstBoxControl.SelectedValueChanged

    End Sub

    Private Sub lstBoxControl_ValueMemberChanged(sender As Object, e As EventArgs) Handles lstBoxControl.ValueMemberChanged

    End Sub
#End Region

#Region "Bar Manager"
    ''' <summary>
    ''' The properties is often used
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub PropertiesControlBarManager()


    End Sub


    ''' <summary>
    ''' The method is often used
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub MethodControlBarManager()

    End Sub

    Private Sub BrManager_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BrManager.ItemClick

    End Sub

    Private Sub BrManager_ItemDoubleClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BrManager.ItemDoubleClick

    End Sub
#End Region

#Region "Panel Control"
    ''' <summary>
    ''' The properties is often used
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub PropertiesControlPanelControl()

        ' 	Gets or sets a value indicating whether the control can respond to user interaction.
        pnControl.Enabled = False

        ' Gets or sets the editor content's foreground color.
        pnControl.ForeColor = Color.Aqua

        ' Gets or sets the label control's background color.
        pnControl.BackColor = Color.Aquamarine

        ' Gets or sets a value indicating whether the control and all its parent controls are displayed.
        pnControl.Visible = True

        ' Gets or sets the text displayed within the edit box.
        pnControl.Text = ""

        ' Gets or sets the panel's border style.
        pnControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default

        ' Gets or sets which control borders are docked to its parent control and determines how a control is resized with its parent.
        pnControl.Dock = DockStyle.None
    End Sub


    ''' <summary>
    ''' The method is often used
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub MethodControlPanelControl()

        ' Sets input focus to the control.
        pnControl.Focus()

        ' Conceals the control from the user..
        pnControl.Hide()

        ' Displays the control to the user.
        pnControl.Show()
    End Sub

    Private Sub pnControl_Click(sender As Object, e As EventArgs) Handles pnControl.Click

    End Sub

    Private Sub pnControl_DoubleClick(sender As Object, e As EventArgs) Handles pnControl.DoubleClick

    End Sub

    Private Sub pnControl_Leave(sender As Object, e As EventArgs) Handles pnControl.Leave

    End Sub

#End Region

#Region "PictureEdit"
    ''' <summary>
    ''' The properties is often used
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub PropertiesControlPictureEdit()

        ' Gets or sets a value indicating whether the control can respond to user interaction.
        pctEdit.Enabled = False

        ' Gets or sets the editor content's foreground color.
        pctEdit.ForeColor = Color.Aqua

        ' Sets or gets the image displayed by the editor.
        pctEdit.Image = Image.FromFile("C:\Users\ngocp\OneDrive\Desktop\C#\PTProject\PTProject\image\export_excel.png")

        ' Gets or sets the label control's background color.
        pctEdit.BackColor = Color.Aquamarine

        ' Gets or sets a value indicating whether the control and all its parent controls are displayed.
        pctEdit.Visible = True

        ' Gets or sets the text displayed within the edit box.
        pctEdit.Text = ""

        ' Gets or sets whether the editor's value cannot be changed by end-users.
        pctEdit.ReadOnly = False

        ' Gets an object containing properties and methods specific to the picture editor.
        'pctEdit.Properties
    End Sub


    ''' <summary>
    ''' The method is often used
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub MethodControlPictureEdit()

        ' Sets input focus to the control.
        pctEdit.Focus()

        ' Conceals the control from the user..
        pctEdit.Hide()

        ' Displays the control to the user.
        pctEdit.Show()

        ' Clears selection within the editor
        pctEdit.DeselectAll()
    End Sub

    Private Sub pctEdit_Click(sender As Object, e As EventArgs) Handles pctEdit.Click

    End Sub

    Private Sub pctEdit_DoubleClick(sender As Object, e As EventArgs) Handles pctEdit.DoubleClick

    End Sub

    Private Sub pctEdit_EditValueChanged(sender As Object, e As EventArgs) Handles pctEdit.EditValueChanged

    End Sub

    Private Sub pctEdit_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles pctEdit.EditValueChanging

    End Sub

    Private Sub pctEdit_ImageChanged(sender As Object, e As EventArgs) Handles pctEdit.ImageChanged

    End Sub
#End Region
#Region "ProgressBarControl"
    ''' <summary>
    ''' The properties is often used
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub PropertiesControlProgressBarControl()

        ' 	Gets or sets a value indicating whether the control can respond to user interaction.
        pgBarControl.Enabled = False

        ' Gets or sets the editor content's foreground color.
        pgBarControl.ForeColor = Color.Aqua

        ' Gets or sets the label control's background color.
        pgBarControl.BackColor = Color.Aquamarine

        ' Gets or sets a value indicating whether the control and all its parent controls are displayed.
        pgBarControl.Visible = True

        ' Gets or sets the text displayed within the edit box.
        pgBarControl.Text = ""

        ' Gets or sets the value representing the progress bar's current position.
        pgBarControl.EditValue = ""

        ' Gets an object containing properties, methods and events specific to progress bar controls.
        'pgBarControl.Properties

        ' Gets or sets whether the editor's value cannot be changed by end-users. 
        pgBarControl.ReadOnly = False

    End Sub


    ''' <summary>
    ''' The method is often used
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub MethodControlProgressBarControl()

        ' Sets input focus to the control.
        pgBarControl.Focus()

        ' Conceals the control from the user..
        pgBarControl.Hide()

        ' Displays the control to the user.
        pgBarControl.Show()

        ' Clears selection within the editor.
        pgBarControl.DeselectAll()

        ' Decreases the progress bar's position by a specified value.
        pgBarControl.Decrement(0)

        ' Increases the progress bar's current position by a specified value.
        pgBarControl.Increment(0)
    End Sub

    Private Sub pgBarControl_Click(sender As Object, e As EventArgs) Handles pgBarControl.Click

    End Sub

    Private Sub pgBarControl_DoubleClick(sender As Object, e As EventArgs) Handles pgBarControl.DoubleClick

    End Sub

    Private Sub pgBarControl_Leave(sender As Object, e As EventArgs) Handles pgBarControl.Leave

    End Sub

    Private Sub pgBarControl_EditValueChanged(sender As Object, e As EventArgs) Handles pgBarControl.EditValueChanged

    End Sub

    Private Sub pgBarControl_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles pgBarControl.EditValueChanging

    End Sub

#End Region

#Region "Radio Group"
    ''' <summary>
    ''' The properties is often used
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub PropertiesControlRadioGroup()

        ' 	Gets or sets a value indicating whether the control can respond to user interaction.
        radioGroup.Enabled = False

        ' Gets or sets the editor content's foreground color.
        radioGroup.ForeColor = Color.Aqua

        ' Gets or sets the label control's background color.
        radioGroup.BackColor = Color.Aquamarine

        ' Gets or sets a value indicating whether the control and all its parent controls are displayed.
        radioGroup.Visible = True

        ' Gets or sets the text displayed within the edit box.
        radioGroup.Text = ""

        ' Gets or sets whether the editor's value cannot be changed by end-users. 
        radioGroup.ReadOnly = False
    End Sub


    ''' <summary>
    ''' The method is often used
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub MethodControlRadioGroup()

        ' Sets input focus to the control.
        radioGroup.Focus()

        ' Conceals the control from the user..
        radioGroup.Hide()

        ' Displays the control to the user.
        radioGroup.Show()

        ' Clears selection within the editor. 
        radioGroup.DeselectAll()

        ' Selects the editor's entire content. 
        radioGroup.SelectAll()
    End Sub

    Private Sub radioGroup_Click(sender As Object, e As EventArgs) Handles radioGroup.Click

    End Sub

    Private Sub radioGroup_DoubleClick(sender As Object, e As EventArgs) Handles radioGroup.DoubleClick

    End Sub

    Private Sub radioGroup_EditValueChanged(sender As Object, e As EventArgs) Handles radioGroup.EditValueChanged

    End Sub

    Private Sub radioGroup_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles radioGroup.EditValueChanging

    End Sub

    Private Sub radioGroup_SelectedIndexChanged(sender As Object, e As EventArgs) Handles radioGroup.SelectedIndexChanged

    End Sub

#End Region

#Region "Xtra Tab Control"
    ''' <summary>
    ''' The properties is often used
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub PropertiesControlXtraTabControl()

        ' 	Gets or sets a value indicating whether the control can respond to user interaction.
        tabControl.Enabled = False

        ' Gets or sets the editor content's foreground color.
        tabControl.ForeColor = Color.Aqua

        ' Gets or sets the label control's background color.
        tabControl.BackColor = Color.Aquamarine

        ' Gets or sets a value indicating whether the control and all its parent controls are displayed.
        tabControl.Visible = True

        ' Gets or sets the text displayed within the edit box.
        tabControl.Text = ""

        ' Gets or sets the index of the tab page whose header is the first visible header onscreen.
        tabControl.FirstVisiblePageIndex = 0

        ' Gets or sets the currently selected tab page.
        tabControl.SelectedTabPage = Nothing

        ' Gets or sets the index of the currently selected tab page.
        tabControl.SelectedTabPageIndex = 0

    End Sub


    ''' <summary>
    ''' The method is often used
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub MethodControlXtraTabControl()

        ' Sets input focus to the control.
        tabControl.Focus()

        ' Conceals the control from the user..
        tabControl.Hide()

        ' Displays the control to the user.
        tabControl.Show()
    End Sub

    Private Sub tabControl_Click(sender As Object, e As EventArgs) Handles tabControl.Click

    End Sub

    Private Sub tabControl_Deselected(sender As Object, e As DevExpress.XtraTab.TabPageEventArgs) Handles tabControl.Deselected

    End Sub

    Private Sub tabControl_Deselecting(sender As Object, e As DevExpress.XtraTab.TabPageCancelEventArgs) Handles tabControl.Deselecting

    End Sub

    Private Sub tabControl_DoubleClick(sender As Object, e As EventArgs) Handles tabControl.DoubleClick

    End Sub

    Private Sub tabControl_Leave(sender As Object, e As EventArgs) Handles tabControl.Leave

    End Sub

    Private Sub tabControl_Selected(sender As Object, e As DevExpress.XtraTab.TabPageEventArgs) Handles tabControl.Selected

    End Sub

    Private Sub tabControl_SelectedPageChanging(sender As Object, e As DevExpress.XtraTab.TabPageChangingEventArgs) Handles tabControl.SelectedPageChanging

    End Sub

    Private Sub tabControl_SelectedPageChanged(sender As Object, e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles tabControl.SelectedPageChanged

    End Sub

    Private Sub tabControl_Selecting(sender As Object, e As DevExpress.XtraTab.TabPageCancelEventArgs) Handles tabControl.Selecting

    End Sub

#End Region

#Region "Text Edit"
    ''' <summary>
    ''' The properties is often used
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub PropertiesControlTextEdit()

        ' 	Gets or sets a value indicating whether the control can respond to user interaction.
        txtEdit.Enabled = False

        ' Gets or sets the editor content's foreground color.
        txtEdit.ForeColor = Color.Aqua

        ' Gets or sets the label control's background color.
        txtEdit.BackColor = Color.Aquamarine

        ' Gets or sets a value indicating whether the control and all its parent controls are displayed.
        txtEdit.Visible = True

        ' Gets or sets the text displayed within the edit box.
        txtEdit.Text = ""

        ' Gets or sets whether the editor's value cannot be changed by end-users. 
        txtEdit.ReadOnly = False

        ' Gets an object containing this editor's settings.
        'txtEdit.Properties

        ' Gets or sets the editor's value.
        txtEdit.EditValue = ""
    End Sub


    ''' <summary>
    ''' The method is often used
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub MethodControlTextEdit()

        ' Sets input focus to the control.
        txtEdit.Focus()

        ' Conceals the control from the user..
        txtEdit.Hide()

        ' Displays the control to the user.
        txtEdit.Show()

        txtEdit.Undo()

        txtEdit.DeselectAll()
    End Sub

    Private Sub txtEdit_EditValueChanged(sender As Object, e As EventArgs) Handles txtEdit.EditValueChanged

    End Sub

    Private Sub txtEdit_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtEdit.EditValueChanging

    End Sub

    Private Sub txtEdit_Click(sender As Object, e As EventArgs) Handles txtEdit.Click

    End Sub

    Private Sub txtEdit_DoubleClick(sender As Object, e As EventArgs) Handles txtEdit.DoubleClick

    End Sub
#End Region

#Region "Tool Tip"
    ''' <summary>
    ''' The properties is often used
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub PropertiesControlToolTip()

        'Gets or sets whether the component's functionality is enabled.
        ToolTipController1.Active = False

        'Gets or sets the index of an image to be displayed within tooltips.
        ToolTipController1.ImageIndex = 0

        'Gets or sets the source of the images that can be displayed within tooltips.
        ToolTipController1.ImageList = Nothing

        'Gets or sets the look-and-feel of regular tooltips.
        ToolTipController1.ToolTipStyle = DevExpress.Utils.ToolTipStyle.Default

    End Sub


    ''' <summary>
    ''' The method is often used
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub MethodControlToolTip()

        ' Gets a regular tooltip for the specified control.
        ToolTipController1.GetToolTip(lblText)

        ' Gets a regular tooltip's title displayed within the specified control.
        ToolTipController1.GetTitle(lblText)

        ' Sets a regular tooltip's title for the specified control.
        ToolTipController1.SetTitle(lblText, "")

        ' Sets a regular tooltip for the specified control.
        ToolTipController1.SetToolTip(lblText, "")
    End Sub


    Private Sub ToolTipController1_HyperlinkClick(sender As Object, e As DevExpress.Utils.HyperlinkClickEventArgs) Handles ToolTipController1.HyperlinkClick

    End Sub

    Private Sub ToolTipController1_BeforeShow(sender As Object, e As DevExpress.Utils.ToolTipControllerShowEventArgs) Handles ToolTipController1.BeforeShow

    End Sub

#End Region
#Region "Ribbon Status Bar"
    ''' <summary>
    ''' The properties is often used
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub PropertiesControlStatusStrip()

        ' 	Gets or sets a value indicating whether the control can respond to user interaction.
        RibbonStatusBar1.Enabled = False

        ' Gets or sets the editor content's foreground color.
        RibbonStatusBar1.ForeColor = Color.Aqua

        ' Gets or sets the label control's background color.
        RibbonStatusBar1.BackColor = Color.Aquamarine

        ' Gets or sets a value indicating whether the control and all its parent controls are displayed.
        RibbonStatusBar1.Visible = True

        ' Gets or sets the text displayed within the edit box.
        RibbonStatusBar1.Text = ""

        'Gets or sets a Ribbon Control which the status bar belongs to.
        RibbonStatusBar1.Ribbon = Nothing

        ' 	Gets or sets the tooltip controller component that controls the appearance, position and content of tooltips displayed by elements of the RibbonStatusBar.
        RibbonStatusBar1.ToolTipController = Nothing

    End Sub


    ''' <summary>
    ''' The method is often used
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub MethodControlStatusStrip()

        ' Sets input focus to the control.
        RibbonStatusBar1.Focus()

        ' Conceals the control from the user..
        RibbonStatusBar1.Hide()

        ' Displays the control to the user.
        RibbonStatusBar1.Show()
    End Sub

    Private Sub RibbonStatusBar1_Click(sender As Object, e As EventArgs) Handles RibbonStatusBar1.Click

    End Sub

    Private Sub RibbonStatusBar1_DoubleClick(sender As Object, e As EventArgs) Handles RibbonStatusBar1.DoubleClick

    End Sub

#End Region


End Class