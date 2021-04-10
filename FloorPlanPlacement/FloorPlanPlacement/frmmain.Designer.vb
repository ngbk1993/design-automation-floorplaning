<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmmain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.picFloorPlan = New System.Windows.Forms.PictureBox()
        Me.lstLoad = New System.Windows.Forms.ListBox()
        Me.lstNodeWidth = New System.Windows.Forms.ListBox()
        Me.lstNodeHeight = New System.Windows.Forms.ListBox()
        Me.lstNodeName = New System.Windows.Forms.ListBox()
        Me.cmdLoad = New System.Windows.Forms.Button()
        Me.cmdPlacement = New System.Windows.Forms.Button()
        Me.lstNodeNameSort = New System.Windows.Forms.ListBox()
        Me.lstNodeHeightSort = New System.Windows.Forms.ListBox()
        Me.lstNodeWidthSort = New System.Windows.Forms.ListBox()
        Me.lstcordX = New System.Windows.Forms.ListBox()
        Me.lstcordY = New System.Windows.Forms.ListBox()
        Me.cmdlg = New System.Windows.Forms.OpenFileDialog()
        Me.lstlog = New System.Windows.Forms.ListBox()
        Me.cmdRerun = New System.Windows.Forms.Button()
        Me.cboScale = New System.Windows.Forms.ComboBox()
        Me.txtLog = New System.Windows.Forms.TextBox()
        Me.cmdExport = New System.Windows.Forms.Button()
        Me.cmOpendlg = New System.Windows.Forms.SaveFileDialog()
        Me.lstUnscaledNodeWidth = New System.Windows.Forms.ListBox()
        Me.lstUnscaledNodeHeight = New System.Windows.Forms.ListBox()
        CType(Me.picFloorPlan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picFloorPlan
        '
        Me.picFloorPlan.Location = New System.Drawing.Point(12, 12)
        Me.picFloorPlan.Name = "picFloorPlan"
        Me.picFloorPlan.Size = New System.Drawing.Size(811, 429)
        Me.picFloorPlan.TabIndex = 0
        Me.picFloorPlan.TabStop = False
        '
        'lstLoad
        '
        Me.lstLoad.FormattingEnabled = True
        Me.lstLoad.Location = New System.Drawing.Point(284, 638)
        Me.lstLoad.Name = "lstLoad"
        Me.lstLoad.Size = New System.Drawing.Size(330, 95)
        Me.lstLoad.TabIndex = 1
        Me.lstLoad.Visible = False
        '
        'lstNodeWidth
        '
        Me.lstNodeWidth.FormattingEnabled = True
        Me.lstNodeWidth.Location = New System.Drawing.Point(99, 537)
        Me.lstNodeWidth.Name = "lstNodeWidth"
        Me.lstNodeWidth.Size = New System.Drawing.Size(78, 95)
        Me.lstNodeWidth.TabIndex = 2
        Me.lstNodeWidth.Visible = False
        '
        'lstNodeHeight
        '
        Me.lstNodeHeight.FormattingEnabled = True
        Me.lstNodeHeight.Location = New System.Drawing.Point(183, 537)
        Me.lstNodeHeight.Name = "lstNodeHeight"
        Me.lstNodeHeight.Size = New System.Drawing.Size(78, 95)
        Me.lstNodeHeight.TabIndex = 3
        Me.lstNodeHeight.Visible = False
        '
        'lstNodeName
        '
        Me.lstNodeName.FormattingEnabled = True
        Me.lstNodeName.Location = New System.Drawing.Point(15, 537)
        Me.lstNodeName.Name = "lstNodeName"
        Me.lstNodeName.Size = New System.Drawing.Size(78, 95)
        Me.lstNodeName.TabIndex = 4
        Me.lstNodeName.Visible = False
        '
        'cmdLoad
        '
        Me.cmdLoad.Location = New System.Drawing.Point(748, 475)
        Me.cmdLoad.Name = "cmdLoad"
        Me.cmdLoad.Size = New System.Drawing.Size(75, 23)
        Me.cmdLoad.TabIndex = 5
        Me.cmdLoad.Text = "Load"
        Me.cmdLoad.UseVisualStyleBackColor = True
        '
        'cmdPlacement
        '
        Me.cmdPlacement.Location = New System.Drawing.Point(748, 521)
        Me.cmdPlacement.Name = "cmdPlacement"
        Me.cmdPlacement.Size = New System.Drawing.Size(75, 23)
        Me.cmdPlacement.TabIndex = 6
        Me.cmdPlacement.Text = "Placement"
        Me.cmdPlacement.UseVisualStyleBackColor = True
        '
        'lstNodeNameSort
        '
        Me.lstNodeNameSort.FormattingEnabled = True
        Me.lstNodeNameSort.Location = New System.Drawing.Point(15, 638)
        Me.lstNodeNameSort.Name = "lstNodeNameSort"
        Me.lstNodeNameSort.Size = New System.Drawing.Size(78, 95)
        Me.lstNodeNameSort.TabIndex = 9
        Me.lstNodeNameSort.Visible = False
        '
        'lstNodeHeightSort
        '
        Me.lstNodeHeightSort.FormattingEnabled = True
        Me.lstNodeHeightSort.Location = New System.Drawing.Point(183, 638)
        Me.lstNodeHeightSort.Name = "lstNodeHeightSort"
        Me.lstNodeHeightSort.Size = New System.Drawing.Size(78, 95)
        Me.lstNodeHeightSort.TabIndex = 8
        Me.lstNodeHeightSort.Visible = False
        '
        'lstNodeWidthSort
        '
        Me.lstNodeWidthSort.FormattingEnabled = True
        Me.lstNodeWidthSort.Location = New System.Drawing.Point(99, 638)
        Me.lstNodeWidthSort.Name = "lstNodeWidthSort"
        Me.lstNodeWidthSort.Size = New System.Drawing.Size(78, 95)
        Me.lstNodeWidthSort.TabIndex = 7
        Me.lstNodeWidthSort.Visible = False
        '
        'lstcordX
        '
        Me.lstcordX.FormattingEnabled = True
        Me.lstcordX.Location = New System.Drawing.Point(623, 449)
        Me.lstcordX.Name = "lstcordX"
        Me.lstcordX.Size = New System.Drawing.Size(78, 95)
        Me.lstcordX.TabIndex = 10
        Me.lstcordX.Visible = False
        '
        'lstcordY
        '
        Me.lstcordY.FormattingEnabled = True
        Me.lstcordY.Location = New System.Drawing.Point(539, 449)
        Me.lstcordY.Name = "lstcordY"
        Me.lstcordY.Size = New System.Drawing.Size(78, 95)
        Me.lstcordY.TabIndex = 11
        Me.lstcordY.Visible = False
        '
        'lstlog
        '
        Me.lstlog.FormattingEnabled = True
        Me.lstlog.Location = New System.Drawing.Point(15, 447)
        Me.lstlog.Name = "lstlog"
        Me.lstlog.Size = New System.Drawing.Size(706, 199)
        Me.lstlog.TabIndex = 12
        '
        'cmdRerun
        '
        Me.cmdRerun.Location = New System.Drawing.Point(748, 550)
        Me.cmdRerun.Name = "cmdRerun"
        Me.cmdRerun.Size = New System.Drawing.Size(75, 23)
        Me.cmdRerun.TabIndex = 13
        Me.cmdRerun.Text = "ReRunFor"
        Me.cmdRerun.UseVisualStyleBackColor = True
        '
        'cboScale
        '
        Me.cboScale.FormattingEnabled = True
        Me.cboScale.Location = New System.Drawing.Point(748, 448)
        Me.cboScale.Name = "cboScale"
        Me.cboScale.Size = New System.Drawing.Size(75, 21)
        Me.cboScale.TabIndex = 14
        Me.cboScale.Text = "30"
        '
        'txtLog
        '
        Me.txtLog.Location = New System.Drawing.Point(15, 448)
        Me.txtLog.Multiline = True
        Me.txtLog.Name = "txtLog"
        Me.txtLog.Size = New System.Drawing.Size(706, 197)
        Me.txtLog.TabIndex = 15
        '
        'cmdExport
        '
        Me.cmdExport.Location = New System.Drawing.Point(748, 595)
        Me.cmdExport.Name = "cmdExport"
        Me.cmdExport.Size = New System.Drawing.Size(74, 25)
        Me.cmdExport.TabIndex = 16
        Me.cmdExport.Text = "Export"
        Me.cmdExport.UseVisualStyleBackColor = True
        '
        'lstUnscaledNodeWidth
        '
        Me.lstUnscaledNodeWidth.FormattingEnabled = True
        Me.lstUnscaledNodeWidth.Location = New System.Drawing.Point(351, 537)
        Me.lstUnscaledNodeWidth.Name = "lstUnscaledNodeWidth"
        Me.lstUnscaledNodeWidth.Size = New System.Drawing.Size(78, 95)
        Me.lstUnscaledNodeWidth.TabIndex = 18
        Me.lstUnscaledNodeWidth.Visible = False
        '
        'lstUnscaledNodeHeight
        '
        Me.lstUnscaledNodeHeight.FormattingEnabled = True
        Me.lstUnscaledNodeHeight.Location = New System.Drawing.Point(267, 537)
        Me.lstUnscaledNodeHeight.Name = "lstUnscaledNodeHeight"
        Me.lstUnscaledNodeHeight.Size = New System.Drawing.Size(78, 95)
        Me.lstUnscaledNodeHeight.TabIndex = 17
        Me.lstUnscaledNodeHeight.Visible = False
        '
        'frmmain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(835, 657)
        Me.Controls.Add(Me.lstUnscaledNodeWidth)
        Me.Controls.Add(Me.lstUnscaledNodeHeight)
        Me.Controls.Add(Me.cmdExport)
        Me.Controls.Add(Me.txtLog)
        Me.Controls.Add(Me.cboScale)
        Me.Controls.Add(Me.cmdRerun)
        Me.Controls.Add(Me.lstLoad)
        Me.Controls.Add(Me.lstcordY)
        Me.Controls.Add(Me.lstcordX)
        Me.Controls.Add(Me.lstNodeNameSort)
        Me.Controls.Add(Me.lstNodeHeightSort)
        Me.Controls.Add(Me.lstNodeWidthSort)
        Me.Controls.Add(Me.cmdPlacement)
        Me.Controls.Add(Me.cmdLoad)
        Me.Controls.Add(Me.lstNodeName)
        Me.Controls.Add(Me.lstNodeHeight)
        Me.Controls.Add(Me.lstNodeWidth)
        Me.Controls.Add(Me.picFloorPlan)
        Me.Controls.Add(Me.lstlog)
        Me.MaximizeBox = False
        Me.Name = "frmmain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Floor Plan Placement"
        CType(Me.picFloorPlan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picFloorPlan As PictureBox
    Friend WithEvents lstLoad As ListBox
    Friend WithEvents lstNodeWidth As ListBox
    Friend WithEvents lstNodeHeight As ListBox
    Friend WithEvents lstNodeName As ListBox
    Friend WithEvents cmdLoad As Button
    Friend WithEvents cmdPlacement As Button
    Friend WithEvents lstNodeNameSort As ListBox
    Friend WithEvents lstNodeHeightSort As ListBox
    Friend WithEvents lstNodeWidthSort As ListBox
    Friend WithEvents lstcordX As ListBox
    Friend WithEvents lstcordY As ListBox
    Friend WithEvents cmdlg As OpenFileDialog
    Friend WithEvents lstlog As ListBox
    Friend WithEvents cmdRerun As Button
    Friend WithEvents cboScale As ComboBox
    Friend WithEvents txtLog As TextBox
    Friend WithEvents cmdExport As Button
    Friend WithEvents cmOpendlg As SaveFileDialog
    Friend WithEvents lstUnscaledNodeWidth As ListBox
    Friend WithEvents lstUnscaledNodeHeight As ListBox
End Class
